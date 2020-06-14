﻿// <auto-generated />
using System;
using Efcore_ExampleWarehouse.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Efcore_ExampleWarehouse.Migrations
{
    [DbContext(typeof(CatContext))]
    [Migration("20200521174722_one")]
    partial class one
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("Efcore_ExampleWarehouse.Entities.example.Client", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Username");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Efcore_ExampleWarehouse.Entities.example.Location", b =>
                {
                    b.Property<int?>("WarehouseId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Position")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientUsername")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PalletId")
                        .HasColumnType("INTEGER");

                    b.HasKey("WarehouseId", "Position");

                    b.HasIndex("ClientUsername");

                    b.HasIndex("PalletId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Efcore_ExampleWarehouse.Entities.example.Pallet", b =>
                {
                    b.Property<int>("PalletId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClientUsername")
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Weight")
                        .HasColumnType("INTEGER");

                    b.HasKey("PalletId");

                    b.HasIndex("ClientUsername");

                    b.ToTable("Pallets");
                });

            modelBuilder.Entity("Efcore_ExampleWarehouse.Entities.example.Warehouse", b =>
                {
                    b.Property<int>("WarehouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("WarehouseId");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("Efcore_ExampleWarehouse.Entities.example.Location", b =>
                {
                    b.HasOne("Efcore_ExampleWarehouse.Entities.example.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientUsername");

                    b.HasOne("Efcore_ExampleWarehouse.Entities.example.Pallet", "Pallet")
                        .WithMany()
                        .HasForeignKey("PalletId");

                    b.HasOne("Efcore_ExampleWarehouse.Entities.example.Warehouse", null)
                        .WithMany("Locations")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Efcore_ExampleWarehouse.Entities.example.Pallet", b =>
                {
                    b.HasOne("Efcore_ExampleWarehouse.Entities.example.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientUsername");
                });
#pragma warning restore 612, 618
        }
    }
}