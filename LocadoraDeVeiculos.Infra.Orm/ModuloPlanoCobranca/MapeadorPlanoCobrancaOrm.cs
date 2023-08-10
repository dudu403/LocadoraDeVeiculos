using LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloPlanoCobranca
{
    public class MapeadorPlanoCobrancaOrm : IEntityTypeConfiguration<PlanoCobranca>
    {
        public void Configure(EntityTypeBuilder<PlanoCobranca> builder)
        {
            builder.ToTable("TBPlanoCobranca");

            builder.Property(d => d.id).IsRequired().ValueGeneratedNever();

            builder.Property(d => d.precoDiaria).HasConversion<decimal>().HasPrecision(25,2).IsRequired();

            builder.Property(d => d.tipoPlano).HasConversion<int>().IsRequired();

            builder.Property(d => d.precoPorKm).HasConversion<decimal>().HasPrecision(25,2).IsRequired(false); 

            builder.Property(d => d.precoPorKmExtrapolado).HasConversion<decimal>().HasPrecision(25,2).IsRequired(false); 

            builder.Property(d => d.kmDisponiveis).HasConversion<decimal>().HasPrecision(25,2).IsRequired(false); 

            builder.HasOne(m => m.grupoAutomovel)
                   .WithMany(g => g.planosCobranca)
                   .IsRequired()
                   .HasConstraintName("FK_TBPlanoCobranca_TBGrupoAutomovel")
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
