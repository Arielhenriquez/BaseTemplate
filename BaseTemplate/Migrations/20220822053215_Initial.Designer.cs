﻿// <auto-generated />
using System;
using BaseTemplate.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaseTemplate.Migrations
{
    [DbContext(typeof(SuperMarketDbContext))]
    [Migration("20220822053215_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BaseTemplate.Data.Entities.Brands", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("BaseTemplate.Data.Entities.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("BaseTemplate.Data.Entities.ShoppingList", b =>
                {
                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("SuperMarketId")
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "SuperMarketId");

                    b.HasIndex("SuperMarketId");

                    b.ToTable("ShoppingLists");
                });

            modelBuilder.Entity("BaseTemplate.Data.Entities.SuperMarkets", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<bool>("IsFavorite")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("ProductId");

                    b.ToTable("SuperMarkets");
                });

            modelBuilder.Entity("BrandsProducts", b =>
                {
                    b.Property<int>("BrandsId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("BrandsId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("BrandsProducts");
                });

            modelBuilder.Entity("BaseTemplate.Data.Entities.ShoppingList", b =>
                {
                    b.HasOne("BaseTemplate.Data.Entities.Products", "Products")
                        .WithMany("ShoppingLists")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaseTemplate.Data.Entities.SuperMarkets", "SuperMarkets")
                        .WithMany("ShoppingLists")
                        .HasForeignKey("SuperMarketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Products");

                    b.Navigation("SuperMarkets");
                });

            modelBuilder.Entity("BaseTemplate.Data.Entities.SuperMarkets", b =>
                {
                    b.HasOne("BaseTemplate.Data.Entities.Brands", "Brands")
                        .WithMany("SuperMarkets")
                        .HasForeignKey("BrandId");

                    b.HasOne("BaseTemplate.Data.Entities.Products", "Products")
                        .WithMany("SuperMarkets")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Brands");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("BrandsProducts", b =>
                {
                    b.HasOne("BaseTemplate.Data.Entities.Brands", null)
                        .WithMany()
                        .HasForeignKey("BrandsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaseTemplate.Data.Entities.Products", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BaseTemplate.Data.Entities.Brands", b =>
                {
                    b.Navigation("SuperMarkets");
                });

            modelBuilder.Entity("BaseTemplate.Data.Entities.Products", b =>
                {
                    b.Navigation("ShoppingLists");

                    b.Navigation("SuperMarkets");
                });

            modelBuilder.Entity("BaseTemplate.Data.Entities.SuperMarkets", b =>
                {
                    b.Navigation("ShoppingLists");
                });
#pragma warning restore 612, 618
        }
    }
}
