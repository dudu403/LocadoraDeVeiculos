using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LocadoraDeVeiculos.WinApp.ModuloAutomovel
{
    public partial class TelaAutomovelForm : Form
    {
        public TelaAutomovelForm(List<GrupoAutomovel> gruposAutomoveis)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarTiposCombustiveis();

            CarregarGruposAutomoveis(gruposAutomoveis);
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
            cmbTipoCombustivel.Items.Clear();

            foreach (GrupoAutomovel grupo in gruposAutomoveis)
            {
                cmbTipoCombustivel.Items.Add(grupo);
            }
        }

        private Bitmap RedimensionarImagem(string path)
        {
            Image image = Image.FromFile(path);

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
            FolderBrowserDialog folder = new();

            if (folder.ShowDialog() == DialogResult.OK)
                //. = folder.SelectedPath;

                DialogResult = DialogResult.None;
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
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
