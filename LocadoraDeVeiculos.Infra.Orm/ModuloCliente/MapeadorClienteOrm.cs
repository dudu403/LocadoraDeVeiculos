using LocadoraDeVeiculos.Dominio.ModuloCliente;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloCliente
{
    public class MapeadorClienteOrm : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("TBCliente");

            builder.Property(d => d.id).IsRequired().ValueGeneratedNever();

            builder.Property(d => d.nome).HasColumnType("varchar(200)").IsRequired();

            builder.Property(d => d.email).HasColumnType("varchar(200)").IsRequired();

            builder.Property(d => d.telefone).HasColumnType("varchar(200)").IsRequired();

            builder.Property(d => d.tipoPessoa).HasColumnType("varchar(200)").IsRequired();

            builder.Property(d => d.cpf).HasColumnType("varchar(200)").IsRequired(false);

            builder.Property(d => d.cnpj).HasColumnType("varchar(200)").IsRequired(false);

            builder.Property(d => d.estado).HasColumnType("varchar(200)").IsRequired();

            builder.Property(d => d.cidade).HasColumnType("varchar(200)").IsRequired();

            builder.Property(d => d.bairro).HasColumnType("varchar(200)").IsRequired();

            builder.Property(d => d.numero).HasConversion<int>().IsRequired();

            builder.Property(d => d.cep).HasColumnType("varchar(200)").IsRequired();


        }
    }
}
