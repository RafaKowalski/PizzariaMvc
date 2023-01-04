﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzariaMvc.Data;

namespace PizzariaMvc.Migrations
{
    [DbContext(typeof(PizzariaMvcContext))]
    partial class PizzariaMvcContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PizzariaMvc.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Complemento");

                    b.Property<string>("Endereco");

                    b.Property<string>("Nome");

                    b.Property<int>("NumeroEndereco");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("PizzariaMvc.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("QtdPizzas");

                    b.Property<int>("TamanhoPizza");

                    b.Property<double>("TrocoPara");

                    b.Property<double>("ValorFinalDoPedido");

                    b.HasKey("Id");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("PizzariaMvc.Models.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<double>("Preco");

                    b.Property<string>("Sabor");

                    b.HasKey("Id");

                    b.ToTable("Pizzas");
                });
#pragma warning restore 612, 618
        }
    }
}
