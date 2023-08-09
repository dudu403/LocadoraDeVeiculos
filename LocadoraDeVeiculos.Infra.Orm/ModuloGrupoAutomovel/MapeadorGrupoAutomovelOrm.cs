using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloGrupoAutomovel
{
    public class MapeadorGrupoAutomovelOrm : IEntityTypeConfiguration<GrupoAutomovel>
    {
        public void Configure(EntityTypeBuilder<GrupoAutomovel> builder)
        {
            builder.ToTable("TBGrupoAutomovel");

            builder.Property(d => d.id).IsRequired().ValueGeneratedNever();

            builder.Property(d => d.nome).HasColumnType("varchar(100)").IsRequired();

     //       builder.Property(d => d.tiposPlano).HasColumnType("varchar(max)").IsRequired(false);
        }
    }
}
