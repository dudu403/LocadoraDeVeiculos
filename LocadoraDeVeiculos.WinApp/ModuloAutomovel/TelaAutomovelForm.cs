using FluentResults;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using System.IO;
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
            automovel.foto = ConverterEmBinario(pctBoxFoto.Image);
            automovel.quilometragem = Convert.ToDouble(txtKm.Text);
            automovel.grupoAutomovel = (GrupoAutomovel)cmbGrpAutomovel.SelectedItem;
            automovel.modelo = txtModelo.Text;
            automovel.marca = txtMarca.Text;
            automovel.cor = txtCor.Text;
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
            cmbTipoCombustivel.SelectedItem = automovel.tipoCombustivel;
            numCapacidadeTanque.Value = automovelSelecionado.capacidadeTanqueLitros;
        }

        private void CarregarTiposCombustiveis()
        {
            cmbTipoCombustivel.Items.Clear();

            cmbTipoCombustivel.Items.Add(TipoCombustivelEnum.Nenhum);
            cmbTipoCombustivel.Items.Add(TipoCombustivelEnum.Gasolina);
            cmbTipoCombustivel.Items.Add(TipoCombustivelEnum.Alcool);
            cmbTipoCombustivel.Items.Add(TipoCombustivelEnum.Disel);
            cmbTipoCombustivel.Items.Add(TipoCombustivelEnum.Gás);
        }

        private void CarregarGruposAutomoveis(List<GrupoAutomovel> gruposAutomoveis)
        {
            cmbGrpAutomovel.Items.Clear();

            foreach (GrupoAutomovel grupo in gruposAutomoveis)
            {
                cmbGrpAutomovel.Items.Add(grupo);
            }
        }

        private Bitmap RedimensionarImagem(string path)
        {
            image = Image.FromFile(path);

            double largura = image.Width;
            double altura = image.Height;

            int novaLargura = 300;

            double proporcao = novaLargura / largura;

            int novaAltura = (int)(proporcao * altura);

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
            
            //file.Filter = "*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            file.Filter = "Bitmaps|*.bmp|jpeg|*.jpg";

            if (file.ShowDialog() == DialogResult.OK)
            {
                image = Bitmap.FromFile(file.FileName);
                    
                RedimensionarImagem(file.FileName);

                pctBoxFoto.Image = image;
            }

            DialogResult = DialogResult.None;
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
