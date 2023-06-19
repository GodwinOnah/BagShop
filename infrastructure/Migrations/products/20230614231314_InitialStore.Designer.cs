﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using infrastructure.data;

#nullable disable

namespace infrastructure.Migrations.Products
{
    [DbContext(typeof(productContext))]
    [Migration("20230614231314_InitialStore")]
    partial class InitialStore
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("core.Controllers.ProductBrand", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("ProductBrand");
                });

            modelBuilder.Entity("core.Controllers.ProductType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("ProductType");
                });

            modelBuilder.Entity("core.Controllers.Products", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("prodDescription")
                        .HasColumnType("text");

                    b.Property<string>("prodName")
                        .HasColumnType("text");

                    b.Property<string>("prodPicture")
                        .HasColumnType("text");

                    b.Property<decimal>("prodPrice")
                        .HasColumnType("numeric");

                    b.Property<int>("productBrandId")
                        .HasColumnType("integer");

                    b.Property<int>("productTypeId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("productBrandId");

                    b.HasIndex("productTypeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("core.Entities.Adverts.Adverts", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("advert")
                        .HasColumnType("text");

                    b.Property<decimal>("time")
                        .HasColumnType("numeric");

                    b.HasKey("id");

                    b.ToTable("Adverts");
                });

            modelBuilder.Entity("core.Entities.Oders.AdminOrder", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("confirmation")
                        .HasColumnType("text");

                    b.Property<int?>("deliveryid")
                        .HasColumnType("integer");

                    b.Property<DateTime>("orderDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("orderStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("deliveryid");

                    b.ToTable("AdminOrder");
                });

            modelBuilder.Entity("core.Entities.Oders.Delivery", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("delDescription")
                        .HasColumnType("text");

                    b.Property<string>("delName")
                        .HasColumnType("text");

                    b.Property<decimal>("delPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("delTime")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Delivery");
                });

            modelBuilder.Entity("core.Entities.Oders.ItemOrdered", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int?>("AdminOrderid")
                        .HasColumnType("integer");

                    b.Property<int?>("Orderid")
                        .HasColumnType("integer");

                    b.Property<decimal>("itemPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("quantity")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("AdminOrderid");

                    b.HasIndex("Orderid");

                    b.ToTable("ItemOrdered");
                });

            modelBuilder.Entity("core.Entities.Oders.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("confirmation")
                        .HasColumnType("text");

                    b.Property<int?>("deliveryid")
                        .HasColumnType("integer");

                    b.Property<DateTime>("orderDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("orderStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("paymentIntentId")
                        .HasColumnType("text");

                    b.Property<decimal>("subTotal")
                        .HasColumnType("numeric");

                    b.HasKey("id");

                    b.HasIndex("deliveryid");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("core.Controllers.Products", b =>
                {
                    b.HasOne("core.Controllers.ProductBrand", "productBrand")
                        .WithMany()
                        .HasForeignKey("productBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("core.Controllers.ProductType", "productType")
                        .WithMany()
                        .HasForeignKey("productTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("productBrand");

                    b.Navigation("productType");
                });

            modelBuilder.Entity("core.Entities.Oders.AdminOrder", b =>
                {
                    b.HasOne("core.Entities.Oders.Delivery", "delivery")
                        .WithMany()
                        .HasForeignKey("deliveryid");

                    b.OwnsOne("core.Entities.Oders.ShippingAddress", "address", b1 =>
                        {
                            b1.Property<int>("AdminOrderid")
                                .HasColumnType("integer");

                            b1.Property<string>("city")
                                .HasColumnType("text");

                            b1.Property<string>("country")
                                .HasColumnType("text");

                            b1.Property<string>("firstName")
                                .HasColumnType("text");

                            b1.Property<string>("lastName")
                                .HasColumnType("text");

                            b1.Property<string>("middleName")
                                .HasColumnType("text");

                            b1.Property<string>("phone")
                                .HasColumnType("text");

                            b1.Property<string>("street")
                                .HasColumnType("text");

                            b1.Property<string>("zipcode")
                                .HasColumnType("text");

                            b1.HasKey("AdminOrderid");

                            b1.ToTable("AdminOrder");

                            b1.WithOwner()
                                .HasForeignKey("AdminOrderid");
                        });

                    b.Navigation("address")
                        .IsRequired();

                    b.Navigation("delivery");
                });

            modelBuilder.Entity("core.Entities.Oders.ItemOrdered", b =>
                {
                    b.HasOne("core.Entities.Oders.AdminOrder", null)
                        .WithMany("itemOrdered")
                        .HasForeignKey("AdminOrderid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("core.Entities.Oders.Order", null)
                        .WithMany("itemOrdered")
                        .HasForeignKey("Orderid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.OwnsOne("core.Entities.Oders.ProductOrdered", "productOrdered", b1 =>
                        {
                            b1.Property<int>("ItemOrderedid")
                                .HasColumnType("integer");

                            b1.Property<int>("id")
                                .HasColumnType("integer");

                            b1.Property<string>("prodName")
                                .HasColumnType("text");

                            b1.Property<string>("prodPicture")
                                .HasColumnType("text");

                            b1.HasKey("ItemOrderedid");

                            b1.ToTable("ItemOrdered");

                            b1.WithOwner()
                                .HasForeignKey("ItemOrderedid");
                        });

                    b.Navigation("productOrdered");
                });

            modelBuilder.Entity("core.Entities.Oders.Order", b =>
                {
                    b.HasOne("core.Entities.Oders.Delivery", "delivery")
                        .WithMany()
                        .HasForeignKey("deliveryid");

                    b.OwnsOne("core.Entities.Oders.ShippingAddress", "address", b1 =>
                        {
                            b1.Property<int>("Orderid")
                                .HasColumnType("integer");

                            b1.Property<string>("city")
                                .HasColumnType("text");

                            b1.Property<string>("country")
                                .HasColumnType("text");

                            b1.Property<string>("firstName")
                                .HasColumnType("text");

                            b1.Property<string>("lastName")
                                .HasColumnType("text");

                            b1.Property<string>("middleName")
                                .HasColumnType("text");

                            b1.Property<string>("phone")
                                .HasColumnType("text");

                            b1.Property<string>("street")
                                .HasColumnType("text");

                            b1.Property<string>("zipcode")
                                .HasColumnType("text");

                            b1.HasKey("Orderid");

                            b1.ToTable("Order");

                            b1.WithOwner()
                                .HasForeignKey("Orderid");
                        });

                    b.Navigation("address")
                        .IsRequired();

                    b.Navigation("delivery");
                });

            modelBuilder.Entity("core.Entities.Oders.AdminOrder", b =>
                {
                    b.Navigation("itemOrdered");
                });

            modelBuilder.Entity("core.Entities.Oders.Order", b =>
                {
                    b.Navigation("itemOrdered");
                });
#pragma warning restore 612, 618
        }
    }
}