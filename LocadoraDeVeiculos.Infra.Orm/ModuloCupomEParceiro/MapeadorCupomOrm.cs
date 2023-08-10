using LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloCupomEParceiro
{
    public class MapeadorCupomOrm : IEntityTypeConfiguration<Cupom>
    {
        public void Configure(EntityTypeBuilder<Cupom> builder)
        {
            builder.ToTable("TBCupom");

            builder.Property(d => d.id).IsRequired().ValueGeneratedNever();

            builder.Property(d => d.nome).HasColumnType("varchar(200)").IsRequired();

            builder.Property(d => d.valor).HasConversion<decimal>().HasPrecision(5,2).IsRequired();

            builder.Property(d => d.validade).IsRequired();

            builder.HasOne(m => m.parceiro)
                   .WithMany()
                   .IsRequired()
                   .HasConstraintName("FK_TBCupom_TBParceiro")
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
