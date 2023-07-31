using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloPlanoCobranca
{
    public class MapeadorPlanoCobrancaOrm : IEntityTypeConfiguration<PlanoCobranca>
    {
        public void Configure(EntityTypeBuilder<PlanoCobranca> builder)
        {
            builder.ToTable("TBPlanoCobranca");

            builder.Property(d => d.id).IsRequired().ValueGeneratedOnAdd();

            builder.Property(d => d.precoDiaria).HasConversion<decimal>().IsRequired();

            builder.Property(d => d.tipoPlano).HasConversion<int>().IsRequired();

            builder.Property(d => d.precoPorKm).HasConversion<decimal>().IsRequired(false); 

            builder.Property(d => d.precoPorKmExtrapolado).HasConversion<decimal>().IsRequired(false); 

            builder.Property(d => d.kmDisponiveis).HasConversion<decimal>().IsRequired(false); 

            builder.HasOne(m => m.grupoAutomovel)
                   .WithMany()
                   .IsRequired()
                   .HasConstraintName("FK_TBPlanoCobranca_TBGrupoAutomovel")
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
