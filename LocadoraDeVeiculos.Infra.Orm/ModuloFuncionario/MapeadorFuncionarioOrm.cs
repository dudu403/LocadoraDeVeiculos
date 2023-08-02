using LocadoraDeVeiculos.Dominio.ModuloFuncionario;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloFuncionario
{
    public class MapeadorFuncionarioOrm : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("TBFuncionario");

            builder.Property(d => d.id).IsRequired().ValueGeneratedNever();

            builder.Property(d => d.nome).IsRequired().HasColumnType("varchar(100)");

            builder.Property(d => d.dataAdimissao).IsRequired().HasColumnType("datetime");

            builder.Property(d => d.salario).IsRequired().HasConversion<decimal>();
        }
    }
}
