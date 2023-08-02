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

                Log.Debug("Funcionario {funcionarioId} editado com sucesso", funcionario.id);

                return Result.Ok();
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar editar um funcionario.";

                Log.Error(exc, msgErro + "{@d}", funcionario);

                return Result.Fail(msgErro);
            }
        }

        public Result Excluir(Funcionario funcionario)
        {
            Log.Debug("Tentando excluir um funcionario...{@d}", funcionario);

            try
            {
                bool funcionarioExiste = repositorioFuncionario.Existe(funcionario);

                if (funcionarioExiste == false)
                {
                    Log.Debug("Funcionario {funcionarioId} não encontrado para excluir", funcionario.id);

                    return Result.Fail("Funcionamrio não encontrado.");
                }

                repositorioFuncionario.Excluir(funcionario);

                Log.Debug("Funcionario {funcionarioId} excluido com sucesso", funcionario.id);

                return Result.Ok();
            }
            catch (Exception exc)
            {
                List<string> erros = new();

                string msgErro;

                if (exc.Message.Contains("FK_TBAluguel_TBFuncionario"))
                    msgErro = "Este funcionario está relacionado a um alguel e não pode ser excluido";
                else
                    msgErro = "Falha ao tentar excluir um funcionario.";

                erros.Add(msgErro);

                Log.Error(exc, msgErro + "{FuncionarioId}", funcionario.id);

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
            return true;
            
            return false;
        }
    }
}


