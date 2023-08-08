using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WinApp.ModuloAluguel
{
    public partial class TelaCadastroAluguelForm : Form
    {
        private Aluguel aluguel;

        public event GravarRegistroDelegate<Cupom> onGravarRegistro;

        public TelaCadastroAluguelForm(List<Funcionario>funcionarios,
                                       List<Cliente> clientes,
                                       List<GrupoAutomovel> grupoAutomovels,
                                       List<PlanoCobranca> planoCobrancas,
                                       List<Condutor> Condutors,
                                       List<Automovel> automovels)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarFuncionario(funcionarios);
            CarregarCliente(clientes);
            CarregarGrupoAutomoveis(grupoAutomovels);
            CarregarPlanoCobranca(planoCobrancas);
            CarregarCondutor(Condutors);
            CarregarAutomovel(automovels);
        }

        public void ConfigurarTela(Aluguel aluguel)
        {
            this.aluguel = aluguel;

            txtCupom.Text = aluguel.ToString();
            txtData.Text = aluguel.ToString();
            txtKmAutomovel.Text = aluguel.ToString();
            txtValorTotal.Text = aluguel.ToString();

            cmbFuncionario.SelectedItem = aluguel.funcionario;
            cmbCliente.SelectedItem = aluguel.cliente;
            cmbGAutomovel.SelectedItem = aluguel.grupoAutomovel;
          //  cmbPCobranca.SelectedItem = aluguel.planoCobranca;
            cmbCondutor.SelectedItem = aluguel.condutor;
            cmbAutomovel.SelectedItem = aluguel.automovel;

            //checkBox1;
            //checkBox2;
            //checkBox3;
            //checkBox4;
            //checkBox5;


        }

        public void ObterCadastroAluguel()
        {
            aluguel.funcionario = (Funcionario)cmbFuncionario.SelectedItem;
            aluguel.cliente = (Cliente)cmbCliente.SelectedItem;
            aluguel.grupoAutomovel = (GrupoAutomovel)cmbAutomovel.SelectedItem;
        //    aluguel.planoCobranca = (PlanoCobranca)cmbPCobranca.SelectedItem;
            aluguel.condutor = (Condutor)cmbCondutor.SelectedItem;
            aluguel.automovel = (Automovel)cmbAutomovel.SelectedItem;

            aluguel.kmInicial = Convert.ToDecimal(txtKmAutomovel);
            //aluguel.cupom = txtCupom.Text;
            //aluguel.valorTotalPrevisto = txtValorTotal.Text;
        }
        private void CarregarAutomovel(List<Automovel> automovels)
        {
            cmbAutomovel.Items.Clear();

            foreach (Automovel automovel in automovels)
            {
                cmbAutomovel.Items.Add(automovels);
            }
        }

        private void CarregarCondutor(List<Condutor> condutors)
        {
            cmbCondutor.Items.Clear();

            foreach (Condutor condutor in condutors)
            {
                cmbCondutor.Items.Add(condutors);
            }
        }

        private void CarregarPlanoCobranca(List<PlanoCobranca> planoCobrancas)
        {
            cmbPCobranca.Items.Clear();

            foreach (PlanoCobranca planoCobranca in planoCobrancas)
            {
                cmbPCobranca.Items.Add(planoCobrancas);
            }
        }

        private void CarregarGrupoAutomoveis(List<GrupoAutomovel> grupoAutomovels)
        {
            cmbGAutomovel.Items.Clear();

            foreach (GrupoAutomovel grupoAutomovel in grupoAutomovels)
            {
                cmbGAutomovel.Items.Add(grupoAutomovels);
            }
        }

        private void CarregarCliente(List<Cliente> clientes)
        {
            cmbCliente.Items.Clear();

            foreach (Cliente cliente in clientes)
            {
                cmbCliente.Items.Add(clientes);
            }
        }

        private void CarregarFuncionario(List<Funcionario> funcionarios)
        {
            cmbCliente.Items.Clear();

            foreach (Funcionario funcionario in funcionarios)
            {
                cmbCliente.Items.Add(funcionarios);
            }
        }
    }
}
