namespace LocadoraDeVeiculos.WinApp.Compartilhado
{
    public abstract class ConfiguracaoToolboxBase
    {
        #region tooltips dos botões

        public abstract string TipoCadastro { get; }

        public virtual string ToolTipHome { get { return "Voltar a tela inicial"; } }

        public virtual string ToolTipInserir { get { return "Configurar indisponível"; } }

        public virtual string ToolTipEditar { get { return "Editar indisponível"; } }

        public virtual string ToolTipExcluir { get { return "Exlcluír indisponível"; } }

        public virtual string? ToolTipFiltrar { get { return "Filtro indisponível"; } }

        public virtual string? ToolTipAdicionarItens { get { return "Adição indisponível"; } }

        public virtual string? ToolTipRemoverItens { get { return "Conclusão indisponível"; } }

        public virtual string? ToolTipFinalizarPagamento { get { return "Finalizar pagamento indisponível"; } }

        public virtual string? ToolTipConfig { get { return "Configurar indisponível"; } }

        public virtual string? ToolTipVisualizar { get { return "VisualizarTeste indisponível"; } }

        public virtual string? ToolTipVisualizarGabarito { get { return "VisualizarTeste gabarito indisponível"; } }

        public virtual string? ToolTipGerarPdf { get { return "Gerar PDF indisponível"; } }

        #endregion

        #region estados dos botões

        public virtual bool InserirHabilitado { get { return false; } }
        public virtual bool EditarHabilitado { get { return false; } }
        public virtual bool ExcluirHabilitado { get { return false; } }
        public virtual bool HomeHabilitado { get { return true; } }
        public virtual bool FiltrarHabilitado { get { return false; } }
        public virtual bool AdicionarItensHabilitado { get { return false; } }
        public virtual bool RemoverItensHabilitado { get { return false; } }
        public virtual bool FinalizarPagamentoHabilitado { get { return false; } }
        public virtual bool ConfigHabilitado { get { return false; } }
        public virtual bool VisualizarHabilitado { get { return false; } }
        public virtual bool VisualizarGabaritoHabilitado { get { return false; } }
        public virtual bool GerarPdfHabilitado { get { return false; } }

        #endregion

        #region visibilidade dos botões

        public virtual bool InserirVisivel { get { return false; } }
        public virtual bool EditarVisivel { get { return false; } }
        public virtual bool ExcluirVisivel { get { return false; } }
        public virtual bool HomeVisivel { get { return true; } }
        public virtual bool FiltrarVisivel { get { return false; } }
        public virtual bool AdicionarItensVisivel { get { return false; } }
        public virtual bool RemoverItensVisivel { get { return false; } }
        public virtual bool FinalizarPagamentoVisivel { get { return false; } }
        public virtual bool ConfigVisivel { get { return false; } }
        public virtual bool VisualizarVisivel { get { return false; } }
        public virtual bool VisualizarGabaritoVisivel { get { return false; } }
        public virtual bool GerarPdfVisivel { get { return false; } }

        public virtual bool SeparadorVisivel0 { get { return true; } }
        public virtual bool SeparadorVisivel1 { get { return false; } }
        public virtual bool SeparadorVisivel2 { get { return false; } }
        public virtual bool SeparadorVisivel3 { get { return false; } }
        public virtual bool SeparadorVisivel4 { get { return false; } }
        public virtual bool SeparadorVisivel5 { get { return true; } }

        #endregion
    }
}
