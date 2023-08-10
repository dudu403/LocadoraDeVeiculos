using LocadoraDeVeiculos.Dominio.ModuloAluguel;

namespace LocadoraDeVeiculos.Aplicacao.ModuloAluguel
{
    public class ServicoAluguel 
    {
        private IRepositorioAluguel repositorioAluguel;
        private IValidadorAluguel validadorAluguel;

        public ServicoAluguel(IRepositorioAluguel repositorioAluguel, IValidadorAluguel validadorAluguel)
        {
            this.repositorioAluguel = repositorioAluguel;
            this.validadorAluguel = validadorAluguel;
        }

        public Result Inserir(Aluguel aluguel)
        {
            Log.Debug("Tentando inserir aluguel...{@d}", aluguel);

            List<string> erros = ValidarAluguel(aluguel);

            if (erros.Count() > 0)
            {
                return Result.Fail(erros);
            }
            try
            {
                repositorioAluguel.Inserir(aluguel);

                Log.Debug("Aluguel {AluguelId} inserido com sucesso...", aluguel.id);

                return Result.Ok();
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar inserir um Aluguel!";

                Log.Error(exc, msgErro + "{@d}", aluguel);

                return Result.Fail(msgErro);
            }
        }

        public Result Editar(Aluguel aluguel)
        {
            Log.Debug("Tentando editar aluguel...{@d}", aluguel);

            List<string> erros = ValidarAluguel(aluguel);

            if (erros.Count() > 0)
            {
                return Result.Fail(erros);
            }
            try
            {
                repositorioAluguel.Editar(aluguel);

                Log.Debug("Aluguel {aluguelId} editado com sucesso", aluguel.id);

                return Result.Ok();
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar editar um aluguel.";

                Log.Error(exc, msgErro + "{@d}", aluguel);

                return Result.Fail(msgErro);
            }
        }

        public Result Excluir(Aluguel aluguel)
        {
            Log.Debug("Tentando excluir aluguel...{@d}", aluguel);

            try
            {
                bool alguelExiste = repositorioAluguel.Existe(aluguel);

                if (alguelExiste == false)
                {
                    Log.Warning("aluguel {aluguelId} não encontrado para excluir", aluguel.id);

                    return Result.Fail("veiculo não encontrado");
                }

                repositorioAluguel.Excluir(aluguel);

                Log.Debug("veiculo {Alugelid} excluído com sucesso", aluguel.id);

                return Result.Ok();
            }
            catch (Exception ex)
            {
                List<string> erros = new List<string>();

                string msgErro = "Falha ao tentar excluir veiculo";

                erros.Add(msgErro);

                Log.Error(ex, msgErro + " {aluguelId}", aluguel.id);

                return Result.Fail(erros);
            }
        }

        public Result Devolver(Aluguel aluguel)
        {
            Log.Debug("Tentando encerrar aluguel...{@d}", aluguel);

            List<string> erros = ValidarAluguel(aluguel);

            if (erros.Count() > 0)
            {
                return Result.Fail(erros);
            }
            try
            {
                repositorioAluguel.Inserir(aluguel);

                Log.Debug("Aluguel {AluguelId} devolvido com sucesso...", aluguel.id);

                return Result.Ok();
            }
            catch (Exception exc)
            {
                string msgErro = "Falha ao tentar devolver um Aluguel!";

                Log.Error(exc, msgErro + "{@d}", aluguel);

                return Result.Fail(msgErro);
            }
        }

        private List<string> ValidarAluguel(Aluguel aluguel)
        {
            var resultadoValidacao = validadorAluguel.Validate(aluguel);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            foreach (string erro in erros)
            {
                Log.Warning(erro);
            }

            return erros;
        }
    }
}
