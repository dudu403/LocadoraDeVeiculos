using LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloCupomEParceiro
{
    public class MapeadorParceiroOrm : IEntityTypeConfiguration<Parceiro>
    {
        public void Configure(EntityTypeBuilder<Parceiro> builder)
        {
            builder.ToTable("TBParceiro");

            builder.Property(d => d.id).IsRequired().ValueGeneratedOnAdd();

            builder.Property(d => d.nome).HasColumnType("varchar(200)").IsRequired();
        }
    }
}
