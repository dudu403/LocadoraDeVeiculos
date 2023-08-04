using LocadoraDeVeiculos.Dominio.ModuloTaxaEServico;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloTaxaEServico
{
    public class MapeadorTaxaEServicoOrm : IEntityTypeConfiguration<TaxaEServico>
    {
        public void Configure(EntityTypeBuilder<TaxaEServico> builder)
        {
            builder.ToTable("TBTaxaEServico");

            builder.Property(d => d.id).IsRequired().ValueGeneratedNever();

            builder.Property(d => d.nome).HasColumnType("varchar(200)").IsRequired();

            builder.Property(d => d.preco).HasConversion<decimal>().IsRequired();

            builder.Property(d => d.tipoDoCusto).HasConversion<int>().IsRequired();
        }
    }
}
