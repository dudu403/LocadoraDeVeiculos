namespace LocadoraDeVeiculos.WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        protected string mensagemRodape { get; set; }

        public virtual void Inserir() { }

        public virtual void Editar() { }

        public virtual void Duplicar() { }

        public virtual void Excluir() { }

        public virtual void Filtrar() { }

        public virtual void AdicionarItens() { }

        public virtual void RemoverItens() { }

        public virtual void FinalizarPagamento() { }

        public virtual void Configurar() { }

        public virtual void VisualizarTeste() { }

        public virtual void VisualizarGabarito() { }

        public virtual void GerarPdf() { }

        public virtual void Devolver() { }

        public virtual void Home() { }

        public abstract UserControl ObterListagem();

        public abstract ConfiguracaoToolboxBase ObtemConfiguracaoToolbox();

        public string ObterMensagemRodape() { return mensagemRodape; }
    }
}
