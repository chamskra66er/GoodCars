﻿// <auto-generated />
using System;
using GoodCars.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GoodCars.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("GoodCars.Data.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("DateMade")
                        .HasColumnType("text");

                    b.Property<string>("Mileage")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Power")
                        .HasColumnType("text");

                    b.Property<string>("Price")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("GoodCars.Data.Models.CarOwner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CarId")
                        .HasColumnType("integer");

                    b.Property<string>("Owner")
                        .HasColumnType("text");

                    b.Property<string>("OwnerContent")
                        .HasColumnType("text");

                    b.Property<double>("Period")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("CarOwners");
                });

            modelBuilder.Entity("GoodCars.Data.Models.CarOwner", b =>
                {
                    b.HasOne("GoodCars.Data.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId");
                });
#pragma warning restore 612, 618
        }
    }
}
