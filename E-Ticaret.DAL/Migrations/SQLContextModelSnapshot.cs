﻿// <auto-generated />
using System;
using E_Ticaret.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E_Ticaret.DAL.Migrations
{
    [DbContext(typeof(SQLContext))]
    partial class SQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("E_Ticaret.DAL.Entities.Admin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("LastLoginIP")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)");

                    b.Property<DateTime>("LastLongDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameSurname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("Varchar(32)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)");

                    b.HasKey("ID");

                    b.ToTable("Admin");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            LastLoginIP = "",
                            LastLongDate = new DateTime(2023, 8, 13, 2, 44, 52, 892, DateTimeKind.Local).AddTicks(967),
                            NameSurname = "Furkan Adim",
                            Password = "202cb962ac59075b964b07152d234b70",
                            UserName = "furkan"
                        });
                });

            modelBuilder.Entity("E_Ticaret.DAL.Entities.Brand", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("E_Ticaret.DAL.Entities.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("DisplayIndex")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(50)");

                    b.Property<int?>("ParentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ParentID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("E_Ticaret.DAL.Entities.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Country")
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Distirct")
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("MailAddress")
                        .HasMaxLength(80)
                        .HasColumnType("Varchar(80)");

                    b.Property<string>("NameSurname")
                        .HasMaxLength(100)
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("OrderNumber")
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<string>("PaymentOption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)");

                    b.Property<DateTime>("RecDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ShipFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(10)
                        .HasColumnType("Varchar(10)");

                    b.HasKey("ID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("E_Ticaret.DAL.Entities.OrderDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasMaxLength(100)
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("ProductPicture")
                        .HasMaxLength(150)
                        .HasColumnType("Varchar(150)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("E_Ticaret.DAL.Entities.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("BrandID")
                        .HasColumnType("int");

                    b.Property<string>("CargoDetail")
                        .HasColumnType("text");

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("Varchar(250)");

                    b.Property<string>("Detail")
                        .HasColumnType("text");

                    b.Property<int>("DisplayIndex")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("Varchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BrandID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("E_Ticaret.DAL.Entities.ProductPicture", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("DisplayIndex")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("Picture")
                        .HasMaxLength(150)
                        .HasColumnType("Varchar(150)");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductPicture");
                });

            modelBuilder.Entity("E_Ticaret.DAL.Entities.Slide", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("Varchar(250)");

                    b.Property<int>("DisplayIndex")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .HasMaxLength(150)
                        .HasColumnType("Varchar(150)");

                    b.Property<string>("Picture")
                        .HasMaxLength(150)
                        .HasColumnType("Varchar(150)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Slogan")
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Slide");
                });

            modelBuilder.Entity("E_Ticaret.DAL.Entities.Category", b =>
                {
                    b.HasOne("E_Ticaret.DAL.Entities.Category", "ParentCategory")
                        .WithMany("SubCategories")
                        .HasForeignKey("ParentID");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("E_Ticaret.DAL.Entities.OrderDetail", b =>
                {
                    b.HasOne("E_Ticaret.DAL.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("E_Ticaret.DAL.Entities.Product", b =>
                {
                    b.HasOne("E_Ticaret.DAL.Entities.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandID")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("E_Ticaret.DAL.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("E_Ticaret.DAL.Entities.ProductPicture", b =>
                {
                    b.HasOne("E_Ticaret.DAL.Entities.Product", "Product")
                        .WithMany("ProductPictures")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("E_Ticaret.DAL.Entities.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("E_Ticaret.DAL.Entities.Category", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("E_Ticaret.DAL.Entities.Product", b =>
                {
                    b.Navigation("ProductPictures");
                });
#pragma warning restore 612, 618
        }
    }
}
