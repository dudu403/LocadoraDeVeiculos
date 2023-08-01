using LocadoraDeVeiculos.Dominio.ModuloCondutor;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloCondutor
{
    public class MapeadorCondutorOrm : IEntityTypeConfiguration<Condutor>
    {
        public void Configure(EntityTypeBuilder<Condutor> builder)
        {
            builder.ToTable("TBCondutor");

            builder.Property(d => d.id).IsRequired().ValueGeneratedNever();

            builder.Property(d => d.nome).HasColumnType("varchar(200)").IsRequired();

            builder.Property(d => d.email).HasColumnType("varchar(200)").IsRequired();

            builder.Property(d => d.telefone).HasColumnType("varchar(20)").IsRequired();

            builder.Property(d => d.cnh).HasColumnType("varchar(20)").IsRequired();

            builder.Property(d => d.cpf).HasColumnType("varchar(200)").IsRequired();

            builder.Property(d => d.validadeCnh).IsRequired();

            builder.HasOne(m => m.cliente)
                   .WithMany()
                   .IsRequired()
                   .HasConstraintName("FK_TBCondutor_TBCliente")
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
