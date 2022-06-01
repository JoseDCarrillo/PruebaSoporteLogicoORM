﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PruebaSoporteLogico.Datos;

#nullable disable

namespace PruebaSoporteLogico.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220601015824_SoporteLogico")]
    partial class SoporteLogico
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PruebaSoporteLogico.Models.Empleado", b =>
                {
                    b.Property<int>("IdEmpleado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEmpleado"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCiudad")
                        .HasColumnType("int");

                    b.Property<int>("IdGenero")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEmpleado");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("PruebaSoporteLogico.Models.Vinculacion", b =>
                {
                    b.Property<int>("IdVinculacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVinculacion"), 1L, 1);

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRetiro")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCargo")
                        .HasColumnType("int");

                    b.Property<int>("IdEmpleado_Vinculacion")
                        .HasColumnType("int");

                    b.HasKey("IdVinculacion");

                    b.HasIndex("IdEmpleado_Vinculacion");

                    b.ToTable("Vinculacion");
                });

            modelBuilder.Entity("PruebaSoporteLogico.Models.Vinculacion", b =>
                {
                    b.HasOne("PruebaSoporteLogico.Models.Empleado", "Empleado")
                        .WithMany("vinculacions")
                        .HasForeignKey("IdEmpleado_Vinculacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleado");
                });

            modelBuilder.Entity("PruebaSoporteLogico.Models.Empleado", b =>
                {
                    b.Navigation("vinculacions");
                });
#pragma warning restore 612, 618
        }
    }
}
