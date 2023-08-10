using LocadoraDeVeiculos.Aplicacao.ModuloConfigPreco;
using LocadoraDeVeiculos.Dominio.ModuloConfigPreco;
using Moq;

namespace LocadoraDeVeiculos.TestesUnitarios.Dominio.ModuloConfPreco
{
    public class ServicoConfPrecoTest
    {
        Mock<IRepositorioConfiguracaoPreco> repositorioConfPrecoMoq;
        Mock<IValidadorConfiguracaoPreco> validadorMoq;
        Mock<IContextoPersistencia> contextoMoq;
        private ServicoConfiguracaoPreco configuracaoPreco;

        [TestInitialize]
        public void InicializarTeste()
        {
            repositorioConfPrecoMoq = new Mock<IRepositorioConfiguracaoPreco>();
            validadorMoq = new Mock<IValidadorConfiguracaoPreco>();
            contextoMoq = new Mock<IContextoPersistencia>();
            configuracaoPreco = new ServicoConfiguracaoPreco(repositorioConfPrecoMoq.Object, validadorMoq.Object);
        }
    }

}
