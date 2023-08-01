using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;


namespace LocadoraDeVeiculos.Aplicacao.ModuloFuncionario
{
    public class ServicoFuncionario
    {
        private IRepositorioFuncionario repositorioFuncionario;
        private IValidadorFuncionario validadorFuncionario;

        public ServicoFuncionario(IRepositorioFuncionario repositorioFuncionario, IValidadorFuncionario validadorFuncionario)
        {
            this.repositorioFuncionario = repositorioFuncionario;
            this.validadorFuncionario = validadorFuncionario;
        }

        public Result Inserir(Funcionario funcionario) 
        {
            Log.Debug("Tentando inserir um funcionario...{@d}", funcionario);
            List<string> erros = ValidarFuncionario(funcionario);

            if (erros.Count() > 0)
                return Result.Fail(erros); //cenário 2

            try
            {
                repositorioFuncionario.Inserir(funcionario);

                Log.Debug("Funcionario {GrupoAutomovelId} inserido com sucesso", funcionario.id);

                return Result.Ok(); //cenário 1
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar inserir um funcionario.";

                Log.Error(exc, msgErro + "{@d}", funcionario);

                return Result.Fail(msgErro); //cenário 3
            }
        }


        public Result Editar(Funcionario funcionario)
        {
            Log.Debug("Tentando editar um funcionario...{@d}", funcionario);

            List<string> erros = ValidarFuncionario(funcionario);

            if (erros.Count() > 0)
                return Result.Fail(erros);
            try
            {
                repositorioFuncionario.Editar(funcionario);

                Log.Debug("Grupo de automovel {funcionarioId} editado com sucesso", funcionario.id);

                return Result.Ok();
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar editar um funcionario.";

                Log.Error(exc, msgErro + "{@d}", funcionario);

                return Result.Fail(msgErro);
            }
        }

        private List<string> ValidarFuncionario(Funcionario funcionario)
        {
            var resultadoValidacao = validadorFuncionario.Validate(funcionario);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            if (NomeDuplicado(funcionario))
                erros.Add($"Este nome '{funcionario.nome}' já está sendo utilizado");

            foreach (string erro in erros)
            {
                Log.Warning(erro);
            }

            return erros;
        }

        private bool NomeDuplicado(Funcionario funcionario)
        {
            Funcionario funcionarioEncontrado = repositorioFuncionario.SelecionarPorNome(funcionario.nome);

            if (funcionarioEncontrado != null &&
                funcionarioEncontrado.id != funcionario.id &&
                funcionarioEncontrado.nome == funcionario.nome)
            {
                return true;
            }
            return false;
        }
    }
}


