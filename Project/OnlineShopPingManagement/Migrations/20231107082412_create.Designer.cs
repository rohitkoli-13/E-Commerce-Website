﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineShopPingManagement.Entities;

#nullable disable

namespace OnlineShoppingManagement.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    [Migration("20231107082412_create")]
    partial class create
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OnlineShoppingManagement.Entities.Admin", b =>
                {
                    b.Property<string>("AdminId")
                        .HasMaxLength(6)
                        .HasColumnType("varchar(6)");

                    b.Property<string>("AdminEmail")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("AdminName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("AdminPassword")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("AdminId");

                    b.ToTable("AdminDetails");
                });

            modelBuilder.Entity("OnlineShoppingManagement.Entities.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasMaxLength(6)
                        .HasColumnType("varchar(6)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("OnlineShopPingManagement.Entities.Customer", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasMaxLength(7)
                        .HasColumnType("varchar(7)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)");

                    b.HasKey("CustomerId");

                    b.ToTable("CustomerDetails");
                });

            modelBuilder.Entity("OnlineShoppingManagement.Entities.Favourite", b =>
                {
                    b.Property<string>("ProductId")
                        .HasMaxLength(6)
                        .HasColumnType("varchar(6)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(38,17)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Favourites");
                });

            modelBuilder.Entity("OnlineShoppingManagement.Entities.Order", b =>
                {
                    b.Property<string>("OrderId")
                        .HasMaxLength(7)
                        .HasColumnType("varchar(7)");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<string>("DeliveryAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Address");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("DateTime");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("DateTime");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OnlineShoppingManagement.Entities.Payment", b =>
                {
                    b.Property<Guid>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OrderId")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("varchar(7)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("DateTime");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(50)");

                    b.HasKey("PaymentId");

                    b.HasIndex("OrderId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("OnlineShoppingManagement.Entities.Product", b =>
                {
                    b.Property<string>("ProductId")
                        .HasMaxLength(6)
                        .HasColumnType("varchar(6)");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("varchar(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(38,17)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("OnlineShoppingManagement.Entities.YourOrders", b =>
                {
                    b.Property<string>("OrderId")
                        .HasMaxLength(7)
                        .HasColumnType("varchar(7)");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime");

                    b.Property<string>("OrdrerAddress")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.HasKey("OrderId");

                    b.ToTable("YourOrders");
                });

            modelBuilder.Entity("OnlineShoppingManagement.Entities.Payment", b =>
                {
                    b.HasOne("OnlineShoppingManagement.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("OnlineShoppingManagement.Entities.YourOrders", b =>
                {
                    b.HasOne("OnlineShoppingManagement.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}