using LocadoraDeVeiculos.Dominio.ModuloFuncionario;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloFuncionario
{
    public class MapeadorFuncionarioOrm : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("TBFuncionario");

            builder.Property(d => d.id).IsRequired().ValueGeneratedNever();

            builder.Property(d => d.nome).HasColumnType("varchar(100)").IsRequired();

            builder.Property(d => d.dataAdmissao).IsRequired();

            builder.Property(d => d.salario).HasConversion<decimal>().IsRequired();
        }
    }
}
