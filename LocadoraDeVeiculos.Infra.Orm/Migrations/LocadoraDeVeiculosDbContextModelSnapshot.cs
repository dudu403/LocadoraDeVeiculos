﻿// <auto-generated />
using System;
using LocadoraDeVeiculos.Infra.Orm.Compartilhado;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LocadoraDeVeiculos.Infra.Orm.Migrations
{
    [DbContext(typeof(LocadoraDeVeiculosDbContext))]
    partial class LocadoraDeVeiculosDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AluguelTaxaEServico", b =>
                {
                    b.Property<Guid>("Aluguelid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("taxasid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Aluguelid", "taxasid");

                    b.HasIndex("taxasid");

                    b.ToTable("TBAluguel_TBTaxaEServico", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloAluguel.Aluguel", b =>
                {
                    b.Property<Guid>("id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("automovelid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("clienteid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("condutorid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("cupomid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("dataDevolucao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dataLocacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dataPrevistaDevolucao")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("funcionarioid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("grupoAutomovelid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("kmFinal")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal>("kmInicial")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal?>("kmPercorrido")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("nivelTanque")
                        .HasColumnType("int");

                    b.Property<Guid>("planoCobrancaid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("valorTotalFinal")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal>("valorTotalPrevisto")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("id");

                    b.HasIndex("automovelid");

                    b.HasIndex("clienteid");

                    b.HasIndex("condutorid");

                    b.HasIndex("cupomid");

                    b.HasIndex("funcionarioid");

                    b.HasIndex("grupoAutomovelid");

                    b.HasIndex("planoCobrancaid");

                    b.ToTable("TBAluguel", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloAutomovel.Automovel", b =>
                {
                    b.Property<Guid>("id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("capacidadeTanqueLitros")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("cor")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<byte[]>("foto")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<Guid>("grupoAutomovelid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("marca")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("modelo")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("placa")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("quilometragem")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("tipoCombustivel")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("grupoAutomovelid");

                    b.ToTable("TBAutomovel", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloCliente.Cliente", b =>
                {
                    b.Property<Guid>("id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("bairro")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("cep")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("cnpj")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("cpf")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<int>("numero")
                        .HasColumnType("int");

                    b.Property<string>("rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("tipoPessoa")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("id");

                    b.ToTable("TBCliente", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloCondutor.Condutor", b =>
                {
                    b.Property<Guid>("id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("clienteid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("cnh")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("validadeCnh")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("clienteid");

                    b.ToTable("TBCondutor", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro.Cupom", b =>
                {
                    b.Property<Guid>("id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<Guid>("parceiroid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("validade")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("valor")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("id");

                    b.HasIndex("parceiroid");

                    b.ToTable("TBCupom", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro.Parceiro", b =>
                {
                    b.Property<Guid>("id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("id");

                    b.ToTable("TBParceiro", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloFuncionario.Funcionario", b =>
                {
                    b.Property<Guid>("id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("dataAdmissao")
                        .HasColumnType("datetime");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("salario")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("id");

                    b.ToTable("TBFuncionario", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel.GrupoAutomovel", b =>
                {
                    b.Property<Guid>("id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("id");

                    b.ToTable("TBGrupoAutomovel", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca.PlanoCobranca", b =>
                {
                    b.Property<Guid>("id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("grupoAutomovelid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("kmDisponiveis")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal>("precoDiaria")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal?>("precoPorKm")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal?>("precoPorKmExtrapolado")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("tipoPlano")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("grupoAutomovelid");

                    b.ToTable("TBPlanoCobranca", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloTaxaEServico.TaxaEServico", b =>
                {
                    b.Property<Guid>("id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<decimal>("preco")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("tipoDoCusto")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("TBTaxaEServico", (string)null);
                });

            modelBuilder.Entity("AluguelTaxaEServico", b =>
                {
                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloAluguel.Aluguel", null)
                        .WithMany()
                        .HasForeignKey("Aluguelid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloTaxaEServico.TaxaEServico", null)
                        .WithMany()
                        .HasForeignKey("taxasid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloAluguel.Aluguel", b =>
                {
                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloAutomovel.Automovel", "automovel")
                        .WithMany()
                        .HasForeignKey("automovelid")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBAluguel_TBAutomovel");

                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloCliente.Cliente", "cliente")
                        .WithMany()
                        .HasForeignKey("clienteid")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBAluguel_TBCliente");

                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloCondutor.Condutor", "condutor")
                        .WithMany()
                        .HasForeignKey("condutorid")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBAluguel_TBCondutor");

                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro.Cupom", "cupom")
                        .WithMany()
                        .HasForeignKey("cupomid")
                        .OnDelete(DeleteBehavior.NoAction)
                        .HasConstraintName("FK_TBAluguel_TBCupom");

                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloFuncionario.Funcionario", "funcionario")
                        .WithMany()
                        .HasForeignKey("funcionarioid")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBAluguel_TBFuncionario");

                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel.GrupoAutomovel", "grupoAutomovel")
                        .WithMany()
                        .HasForeignKey("grupoAutomovelid")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBAluguel_TBGrupoAutomovel");

                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca.PlanoCobranca", "planoCobranca")
                        .WithMany()
                        .HasForeignKey("planoCobrancaid")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBAluguel_TBPlanoCobranca");

                    b.Navigation("automovel");

                    b.Navigation("cliente");

                    b.Navigation("condutor");

                    b.Navigation("cupom");

                    b.Navigation("funcionario");

                    b.Navigation("grupoAutomovel");

                    b.Navigation("planoCobranca");
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloAutomovel.Automovel", b =>
                {
                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel.GrupoAutomovel", "grupoAutomovel")
                        .WithMany("automoveis")
                        .HasForeignKey("grupoAutomovelid")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBAutomovel_TBGrupoAutomovel");

                    b.Navigation("grupoAutomovel");
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloCondutor.Condutor", b =>
                {
                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloCliente.Cliente", "cliente")
                        .WithMany("condutores")
                        .HasForeignKey("clienteid")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBCondutor_TBCliente");

                    b.Navigation("cliente");
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro.Cupom", b =>
                {
                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloCupomEParceiro.Parceiro", "parceiro")
                        .WithMany()
                        .HasForeignKey("parceiroid")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBCupom_TBParceiro");

                    b.Navigation("parceiro");
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca.PlanoCobranca", b =>
                {
                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel.GrupoAutomovel", "grupoAutomovel")
                        .WithMany("planosCobranca")
                        .HasForeignKey("grupoAutomovelid")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBPlanoCobranca_TBGrupoAutomovel");

                    b.Navigation("grupoAutomovel");
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloCliente.Cliente", b =>
                {
                    b.Navigation("condutores");
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel.GrupoAutomovel", b =>
                {
                    b.Navigation("automoveis");

                    b.Navigation("planosCobranca");
                });
#pragma warning restore 612, 618
        }
    }
}
