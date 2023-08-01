using LocadoraDeVeiculos.Dominio.ModuloAutomovel;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloAutomovel
{
    public class MapeadorAutomovelOrm : IEntityTypeConfiguration<Automovel>
    {
        public void Configure(EntityTypeBuilder<Automovel> builder)
        {
            builder.ToTable("TBAutomovel");

            builder.Property(d => d.id).IsRequired().ValueGeneratedNever();

            builder.Property(d => d.modelo).HasColumnType("varchar(100)").IsRequired();

            builder.Property(d => d.marca).HasColumnType("varchar(100)").IsRequired();

            builder.Property(d => d.cor).HasColumnType("varchar(100)").IsRequired();

            builder.Property(d => d.tipoCombustivel).HasConversion<int>().IsRequired();

            builder.Property(d => d.kilometragem).HasConversion<decimal>().IsRequired();

            builder.Property(d => d.capacidadeTanqueLitros).HasConversion<decimal>().IsRequired();

            builder.HasOne(m => m.grupoAutomovel)
                   .WithMany()
                   .IsRequired()
                   .HasConstraintName("FK_TBAutomovel_TBGrupoAutomovel")
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
