using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloAluguel
{
    public class MapeadorAluguelOrm : IEntityTypeConfiguration<Aluguel>
    {
        public void Configure(EntityTypeBuilder<Aluguel> builder)
        {
            builder.ToTable("TBAluguel");

            builder.Property(d => d.id).IsRequired().ValueGeneratedOnAdd();

            builder.Property(d => d.dataPrevistaDevolucao).IsRequired();

            builder.Property(d => d.valorTotalPrevisto).HasConversion<decimal>().IsRequired();

            builder.Property(d => d.nivelTanqueLitros).HasConversion<decimal>().IsRequired();

            builder.Property(d => d.valorTotalFinal).HasConversion<decimal>().IsRequired();

            builder.Property(d => d.dataDevolucao).IsRequired();

            builder.Property(d => d.dataLocacao).IsRequired();

            builder.Property(d => d.kmPercorrido).HasConversion<decimal>().IsRequired();

            builder.Property(d => d.kmInicial).HasConversion<decimal>().IsRequired();

            builder.Property(d => d.kmFinal).HasConversion<decimal>().IsRequired();

            builder.HasOne(m => m.grupoAutomovel)
                   .WithMany()
                   .IsRequired()
                   .HasConstraintName("FK_TBAluguel_TBGrupoAutomovel")
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(m => m.funcionario)
                   .WithMany()
                   .IsRequired()
                   .HasConstraintName("FK_TBAluguel_TBFuncionario")
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(m => m.cliente)
                   .WithMany()
                   .IsRequired()
                   .HasConstraintName("FK_TBAluguel_TBCliente")
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(m => m.condutor)
                   .WithMany()
                   .IsRequired()
                   .HasConstraintName("FK_TBAluguel_TBCondutor")
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(m => m.automovel)
                   .WithMany()
                   .IsRequired()
                   .HasConstraintName("FK_TBAluguel_TBAutomovel")
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(m => m.cupom)
                   .WithMany()
                   .IsRequired(false)
                   .HasConstraintName("FK_TBAluguel_TBCupom")
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(t => t.taxas)
                   .WithMany()
                   .UsingEntity(x => x.ToTable("TBAluguel_TBTaxaEServico"));
        }
    }
}
