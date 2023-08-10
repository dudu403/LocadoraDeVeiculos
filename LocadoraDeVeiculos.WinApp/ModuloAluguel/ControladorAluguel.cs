using FluentResults;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using LocadoraDeVeiculos.Aplicacao.ModuloAluguel;
using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using LocadoraDeVeiculos.Dominio.ModuloConfigPreco;
using LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;
using LocadoraDeVeiculos.Dominio.ModuloTaxaEServico;
using LocadoraDeVeiculos.Infra.Json.ModuloConfigPreco;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace LocadoraDeVeiculos.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        private IRepositorioFuncionario repositorioFuncionario;
        private IRepositorioTaxaEServico repositorioTaxaEServico;
        private IRepositorioCondutor repositorioCondutor;
        private IRepositorioCliente repositorioCliente;
        private IRepositorioCupom repositorioCupom;
        private IRepositorioAutomovel repositorioAutomovel;
        private IRepositorioGrupoAutomovel repositorioGrupoAutomovel;
        private IRepositorioConfiguracaoPreco repositorioConfigPreco;
        private IRepositorioPlanoCobranca repositorioPlanoCobranca;

        private IRepositorioAluguel repositorioAluguel;

        private TabelaAluguelControl tabelaAluguel;

        private ServicoAluguel servicoAluguel;

        public ControladorAluguel(IRepositorioFuncionario repositorioFuncionario,
                                   IRepositorioTaxaEServico repositorioTaxaEServico,
                                   IRepositorioCliente repositorioCliente,
                                   IRepositorioCondutor repositorioCondutor,
                                   IRepositorioCupom repositorioCupom,
                                   IRepositorioAutomovel repositorioAutomovel,
                                   IRepositorioGrupoAutomovel repositorioGrupoAutomovel,
                                   IRepositorioPlanoCobranca repositorioPlanoCobranca,
                                   IRepositorioAluguel repositorioAluguel,
                                   ServicoAluguel servicoAluguel,
                                   IRepositorioConfiguracaoPreco repositorioConfigPreco)
        {
            this.repositorioAluguel = repositorioAluguel;
            this.repositorioFuncionario = repositorioFuncionario;
            this.repositorioCliente = repositorioCliente;
            this.repositorioTaxaEServico = repositorioTaxaEServico;
            this.repositorioCondutor = repositorioCondutor;
            this.repositorioCupom = repositorioCupom;
            this.repositorioAutomovel = repositorioAutomovel;
            this.repositorioGrupoAutomovel = repositorioGrupoAutomovel;
            this.repositorioPlanoCobranca = repositorioPlanoCobranca;
            this.servicoAluguel = servicoAluguel;
            this.repositorioConfigPreco = repositorioConfigPreco;
        }


        public override void Inserir()
        {
            var configuracaoPreco = repositorioConfigPreco.ObterConfiguracaoPreco();

            if (configuracaoPreco.precoGasolina == 0 &&
            configuracaoPreco.precoAlcool == 0 &&
            configuracaoPreco.precoDisel == 0 &&
            configuracaoPreco.precoGas == 0)
            {
                MessageBox.Show("Você deve configurar todos os preços de combustíveis para poder cadastrar um Auguel.",
                "Cadastro de Aluguel",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (repositorioFuncionario.SelecionarTodos().Count() == 0)
            {
                MessageBox.Show("Você deve cadastrar ao menos um Funcionario para poder cadastrar um Auguel.",
                "Cadastro de Aluguel",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (repositorioCondutor.SelecionarTodos().Count() == 0)
            {
                MessageBox.Show("Você deve cadastrar ao menos um Condutor para poder cadastrar um Auguel.",
                "Cadastro de Aluguel",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (repositorioAutomovel.SelecionarTodos().Count() == 0)
            {
                MessageBox.Show("Você deve cadastrar ao menos um Automovel para poder cadastrar um Auguel.",
                "Cadastro de Aluguel",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (repositorioTaxaEServico.SelecionarTodos().Count() == 0)
            {
                MessageBox.Show("Você deve cadastrar ao menos um Condutor para poder cadastrar um Auguel.",
                "Cadastro de Aluguel",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (repositorioGrupoAutomovel.SelecionarTodos().Any(p => p.planosCobranca.Count() != 3))
            {
                MessageBox.Show("Você deve cadastrar os três tipos de planos para os seus grupos de automovel para poder cadastrar um Auguel.",
                "Cadastro de Aluguel",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            Aluguel aulguel = new();

            TelaAluguelForm tela = new(false, configuracaoPreco, repositorioFuncionario.SelecionarTodos(), repositorioCliente.SelecionarTodos(),
                                           repositorioGrupoAutomovel.SelecionarTodos(), repositorioCupom.SelecionarTodos(),
                                           repositorioTaxaEServico.SelecionarTodos());  

            tela.onGravarRegistro += servicoAluguel.Inserir;

            tela.ConfigurarTela(aulguel);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                GerarPdfAluguelEEnviarEmail(aulguel);

                CarregarAlugueis();
            }
        }

        public override void Editar()
        {
            var configuracaoPreco = repositorioConfigPreco.ObterConfiguracaoPreco();

            Guid id = tabelaAluguel.ObterIdSelecionado();

            Aluguel aluguelSelecionado = repositorioAluguel.SelecionarPorId(id);

            if (aluguelSelecionado == null)
            {
                MessageBox.Show("Selecione um aluguel primeiro",
                "Edição de Alguel",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            TelaAluguelForm tela = new(false, configuracaoPreco, repositorioFuncionario.SelecionarTodos(), repositorioCliente.SelecionarTodos(),
                                           repositorioGrupoAutomovel.SelecionarTodos(), repositorioCupom.SelecionarTodos(),
                                           repositorioTaxaEServico.SelecionarTodos());

            tela.onGravarRegistro += servicoAluguel.Editar;

            tela.ConfigurarTela(aluguelSelecionado);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                GerarPdfAluguelEEnviarEmail(aluguelSelecionado);

                CarregarAlugueis();
            }
        }

        public override void Excluir()
        {
            Guid id = tabelaAluguel.ObterIdSelecionado();

            Aluguel aluguelSelecionado = repositorioAluguel.SelecionarPorId(id);

            if (aluguelSelecionado == null)
            {
                MessageBox.Show("Selecione um aluguel primeiro",
                "Exclusão de Aluguel",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (aluguelSelecionado.dataDevolucao == null)
            {
                MessageBox.Show("Esse Aluguel ainda não foi encerrado, logo, não pode ser excluido",
                "Exclusão de Aluguel",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida =
               MessageBox.Show($"Deseja realmente excluir o aluguel \"{aluguelSelecionado}\"?",
               "Exclusão de Aluguel",
               MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                Result resultado = servicoAluguel.Excluir(aluguelSelecionado);

                if (resultado.IsFailed)
                {
                    MessageBox.Show(resultado.Errors[0].Message,
                        "Exclusão de Aluguel",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                CarregarAlugueis();
            }
        }

        public override void Devolver()
        {
            var configuracaoPreco = repositorioConfigPreco.ObterConfiguracaoPreco();

            Guid id = tabelaAluguel.ObterIdSelecionado();

            Aluguel aluguelSelecionado = repositorioAluguel.SelecionarPorId(id);

            if (aluguelSelecionado == null)
            {
                MessageBox.Show("Selecione um aluguel primeiro",
                "Edição de Alguel",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (aluguelSelecionado.dataDevolucao != null)
            {
                MessageBox.Show("Esse Aluguel ja foi encerrado, logo, não pode ser encerrado novamente.",
                "Exclusão de Aluguel",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            TelaAluguelForm tela = new(true, configuracaoPreco, repositorioFuncionario.SelecionarTodos(), repositorioCliente.SelecionarTodos(),
                                           repositorioGrupoAutomovel.SelecionarTodos(), repositorioCupom.SelecionarTodos(),
                                           repositorioTaxaEServico.SelecionarTodos());


            tela.onGravarRegistro += servicoAluguel.Inserir;

            tela.ConfigurarTelaDevolucao(aluguelSelecionado);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                GerarPdfAluguelEEnviarEmail(aluguelSelecionado);

                CarregarAlugueis();
            }

        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxAluguel();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaAluguel == null)
                tabelaAluguel = new TabelaAluguelControl();

            CarregarAlugueis();

            return tabelaAluguel;
        }
    
        public void CarregarAlugueis()
        {
            List<Aluguel> aluguels = repositorioAluguel.SelecionarTodos();

            tabelaAluguel.AtualizarRegistros(aluguels);

            mensagemRodape = string.Format("Visualizando {0} alugue{1}", aluguels.Count, aluguels.Count == 1 ? "l" : "is");

            TelaPrincipalForm.Tela.AtualizarRodape(mensagemRodape);
        }

        private void EnviarEmailComPdf(Aluguel aluguel, string pathPdf)
        {
            try
            {
                var message = new MimeMessage();

                message.From.Add(new MailboxAddress("Bugless Squad - Locadora de Veículos", "buglessquad@gmail.com"));

                message.To.Add(new MailboxAddress(aluguel.cliente.nome, aluguel.cliente.email));

                message.Subject = "Detalhes da sua Locação";

                var bodyBuilder = new BodyBuilder();

                if (aluguel.dataDevolucao != null)
                    bodyBuilder.TextBody = "Obrigada pela confiança. Seque em anexo os detalhes da conclusão do seu Aluguel.";
                else
                    bodyBuilder.TextBody = "Detalhes do seu Aluguel!";

                var pdfAttachment = new MimePart("application", "pdf")
                {
                    Content = new MimeContent(File.OpenRead(pathPdf)),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = Path.GetFileName(pathPdf)
                };

                bodyBuilder.Attachments.Add(pdfAttachment);
                message.Body = bodyBuilder.ToMessageBody();

                using (var scl = new SmtpClient())
                {
                    scl.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);

                    scl.Authenticate("buglesssquad@gmail.com", "qxfuczutqfdldgqo");

                    scl.Send(message);

                    scl.Disconnect(true);
                }

                MessageBox.Show("E-mail enviado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar o e-mail: " + ex.Message);
            }
        }

        private void GerarPdfAluguelEEnviarEmail(Aluguel aluguel)
        {
            //    PdfWriter pathPdf = new(Path.GetTempFileName());
            //    PdfDocument pdf = new(pathPdf);
            //    Document doc = new(pdf);

            var diretorio = Path.GetTempPath();
            var pathPdf = Path.Combine(diretorio, $"aluguel-{aluguel.id}.pdf");

            using (var fileStream = new FileStream(pathPdf, FileMode.Create))
            {
                var pdfWriter = new PdfWriter(fileStream);
                var pdfDocument = new PdfDocument(pdfWriter);
                var doc = new Document(pdfDocument);

                Paragraph titulo = new Paragraph("Bugless Squad - Locadora de Veículos")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(21);

                Paragraph subheader = new Paragraph($"Veículo locado: {aluguel.automovel.modelo} - Placa: {aluguel.automovel.placa}. ")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(18)
                    .SetBold();

                doc.Add(titulo);
                doc.Add(subheader);

                doc.Add(new LineSeparator(new SolidLine(1f)));
                doc.Add(new Paragraph(""));

                Paragraph detalhesAluguel = new Paragraph("Detalhes do Aluguel:")
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(12)
                .SetBold();

                Paragraph cliente = new Paragraph($" Cliente: {aluguel.cliente} - E-mail: {aluguel.cliente.email} ")
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(11)
                        .SetBold();

                Paragraph condutor = new Paragraph($" Condutor: {aluguel.condutor} - CNH: {aluguel.condutor.cnh}.")
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(11)
                        .SetBold();

                Paragraph dataLocacao = new Paragraph($" Data da Locação: {aluguel.dataLocacao.ToString("dd/MM/yyyy")}")
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(11)
                        .SetBold();

                Paragraph planoCobranca = new Paragraph($" Cliente: {aluguel.planoCobranca.tipoPlano}")
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(11)
                        .SetBold();

                doc.Add(detalhesAluguel);
                doc.Add(cliente);
                doc.Add(condutor);
                doc.Add(dataLocacao);
                doc.Add(planoCobranca);

                doc.Add(new LineSeparator(new SolidLine(1f)));
                doc.Add(new Paragraph(""));

                Paragraph detalhesAutomovel = new Paragraph("Detalhes do Automovel:")
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(12)
                .SetBold();

                Paragraph marca = new Paragraph($" Marca: {aluguel.automovel.marca}")
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(11)
                        .SetBold();

                Paragraph modelo = new Paragraph($" Modelo: {aluguel.automovel.modelo}")
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(11)
                        .SetBold();

                Paragraph cor = new Paragraph($" Cor: {aluguel.automovel.cor}")
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(11)
                        .SetBold();

                Paragraph placa = new Paragraph($" Placa: {aluguel.automovel.placa}")
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(11)
                        .SetBold();

                Paragraph km = new Paragraph($" Quilometragem: {aluguel.automovel.quilometragem}")
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(11)
                        .SetBold();

                Paragraph capacidadeTanque = new Paragraph($" Capacidade do Tanque de Combustível(L): {aluguel.automovel.capacidadeTanqueLitros}")
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(11)
                        .SetBold();

                doc.Add(detalhesAutomovel);
                doc.Add(marca);
                doc.Add(modelo);
                doc.Add(cor);
                doc.Add(placa);
                doc.Add(km);
                doc.Add(capacidadeTanque);

                doc.Add(new LineSeparator(new SolidLine(1f)));
                doc.Add(new Paragraph(""));

                Paragraph taxasEServicos = new Paragraph("Taxas e Serviços:")
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(12)
                .SetBold();

                Paragraph dataPrevista = new Paragraph($" Data Prevista Para Devolução: {aluguel.dataPrevistaDevolucao}")
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(11)
                        .SetBold();

                Paragraph dataDevolucao = new Paragraph(" Data de Devolução: " + aluguel?.dataDevolucao == null ? "Em aberto." : aluguel?.dataDevolucao?.ToString("dd/MM/yyyy"))
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(11)
                        .SetBold();

                doc.Add(taxasEServicos);
                doc.Add(dataPrevista);
                doc.Add(dataDevolucao);

                doc.Add(new Paragraph(""));
                doc.Add(new Paragraph(""));

                Paragraph cupom = new Paragraph(" Cupom: " + aluguel.cupom.nome == "" ? "Nenhum." : aluguel.cupom.nome)
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(11)
                        .SetBold();

                Paragraph valorParcial = new Paragraph(" Valor Total Parceial:  R$ " + aluguel.valorTotalPrevisto)
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(11)
                        .SetBold();

                Paragraph valorTotal = new Paragraph(" Valor Total Final: " + aluguel.valorTotalFinal == null ? "Em aberto." : "R$ " + aluguel.cupom.nome)
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(11)
                        .SetBold();

                doc.Add(cupom);
                doc.Add(valorParcial);
                doc.Add(valorTotal);

                doc.Add(new Paragraph(""));
                doc.Add(new LineSeparator(new SolidLine(1f)));
                doc.Close();
            }
            EnviarEmailComPdf(aluguel, pathPdf.ToString());
        }
    }
}
