using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using System.Text.RegularExpressions;

namespace LocadoraDeVeiculos.WinApp.ModuloAutomovel
{
    public partial class TelaAutomovelForm : Form
    {
        private Automovel automovel { set; get; }
        private Image image { set; get; }

        public event GravarRegistroDelegate<Automovel> onGravarRegistro;

        public TelaAutomovelForm(List<GrupoAutomovel> gruposAutomoveis)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarTiposCombustiveis();

            CarregarGruposAutomoveis(gruposAutomoveis);
        }

        public Automovel ObterAutomovel()
        {
            if (image != null)
                automovel.foto = ConverterEmBinario(pctBoxFoto.Image);

            automovel.quilometragem = Convert.ToDecimal(txtKm.Text);
            automovel.grupoAutomovel = (GrupoAutomovel)cmbGrpAutomovel.SelectedItem;
            automovel.modelo = txtModelo.Text;
            automovel.marca = txtMarca.Text;
            automovel.cor = txtCor.Text;
            automovel.placa = txtPlaca.Text;
            automovel.tipoCombustivel = (TipoCombustivelEnum)cmbTipoCombustivel.SelectedItem;
            automovel.capacidadeTanqueLitros = Convert.ToDecimal(numCapacidadeTanque.Value);

            return automovel;
        }

        public void ConfigurarAutomovel(Automovel automovelSelecionado)
        {
            this.automovel = automovelSelecionado;

            if (automovelSelecionado.foto != null)
                pctBoxFoto.Image = ConverterParaImagem(automovelSelecionado.foto);

            txtKm.Text = automovel.quilometragem.ToString();
            cmbGrpAutomovel.SelectedItem = automovelSelecionado.grupoAutomovel;
            txtModelo.Text = automovelSelecionado.modelo;
            txtMarca.Text = automovelSelecionado.marca;
            txtCor.Text = automovelSelecionado.cor;
            txtPlaca.Text = automovelSelecionado.placa;
            cmbTipoCombustivel.SelectedItem = automovel.tipoCombustivel;
            numCapacidadeTanque.Value = automovelSelecionado.capacidadeTanqueLitros;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.automovel = ObterAutomovel();

            Result resultado = onGravarRegistro(automovel);

            if (resultado.IsFailed)
            {
                string erro = resultado.Errors[0].Message;

                TelaPrincipalForm.Tela.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void CarregarTiposCombustiveis()
        {
            cmbTipoCombustivel.DataSource = Enum.GetValues<TipoCombustivelEnum>();
        }

        private void CarregarGruposAutomoveis(List<GrupoAutomovel> gruposAutomoveis)
        {
            cmbGrpAutomovel.DataSource = gruposAutomoveis;
        }

        private Bitmap RedimensionarImagem(OpenFileDialog file)
        {
            image = Image.FromFile(file.FileName);

            double largura = image.Width;

            double altura = image.Height;

            int novaAltura = 120;

            double proporcao = novaAltura / altura;

            int novaLargura = (int)(proporcao * largura);

            var size = new Size(novaLargura, novaAltura);

            return new Bitmap(image, size);
        }

        private byte[] ConverterEmBinario(Image img)
        {
            var memoryStream = new MemoryStream();

            img.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Gif);

            return memoryStream.ToArray();
        }

        private Image ConverterParaImagem(byte[] bites)
        {
            var memoryStream2 = new MemoryStream(bites);

            return Image.FromStream(memoryStream2);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new();

            file.Filter = "jpg|*.jpg|Bitmaps|*.bmp|png|*.png|jpeg|*.jpeg|Gif|*.gif ";

            if (file.ShowDialog() == DialogResult.OK)
            {
                image = RedimensionarImagem(file);

                pctBoxFoto.Image = image;
            }

            DialogResult = DialogResult.None;
        }

        private void txtKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                TextBox t = (TextBox)sender;
                string s = Regex.Replace(t.Text, "[^0-9]", string.Empty);

                if (s == string.Empty)
                    s = "00";
                if (e.KeyChar.Equals((char)Keys.Back))
                    s = s.Substring(0, s.Length - 1);
                else
                    s += e.KeyChar;

                t.Text = string.Format("{0:#,##0.00}", double.Parse(s) / 100);

                t.Select(t.Text.Length, 0);
            }
            e.Handled = true;
        }
    }
}
