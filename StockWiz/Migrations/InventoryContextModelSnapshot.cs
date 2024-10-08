﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockWiz.InventoryDbContext;

#nullable disable

namespace StockWiz.Migrations
{
    [DbContext(typeof(InventoryContext))]
    partial class InventoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("StockWiz.Features.Common.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ItemType")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasDiscriminator<string>("ItemType").HasValue("Item");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("StockWiz.Features.Common.Models.ElectronicItem", b =>
                {
                    b.HasBaseType("StockWiz.Features.Common.Models.Item");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("WarrantyPeriod")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("Electronic");
                });

            modelBuilder.Entity("StockWiz.Features.Common.Models.GroceryItem", b =>
                {
                    b.HasBaseType("StockWiz.Features.Common.Models.Item");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Grocery");
                });
#pragma warning restore 612, 618
        }
    }
}
