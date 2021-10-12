﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopSystem.Data;

namespace ShopSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211011110730_cookie2")]
    partial class cookie2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShopSystem.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressType")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("AddressType");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("City");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Country");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FirstName");

                    b.Property<int>("HouseNo")
                        .HasColumnType("int")
                        .HasColumnName("HouseNo");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LastName");

                    b.Property<string>("Salutation")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Salutation");

                    b.Property<int>("SavedFrom")
                        .HasColumnType("int")
                        .HasColumnName("SavedFrom");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Street");

                    b.Property<int>("Zip")
                        .HasColumnType("int")
                        .HasColumnName("Zip");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("ShopSystem.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerNo")
                        .HasColumnType("int")
                        .HasColumnName("CustomerNo");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<int?>("FK_Customers_Addresses_Id")
                        .HasColumnType("int");

                    b.Property<string>("Gln")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Gln");

                    b.Property<string>("GrpStat5")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("GrpStat5");

                    b.Property<int>("Options")
                        .HasColumnType("int")
                        .HasColumnName("Options");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Password");

                    b.HasKey("Id");

                    b.HasIndex("FK_Customers_Addresses_Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ShopSystem.Models.DeliveryNote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeliveryNoteNo")
                        .HasColumnType("int")
                        .HasColumnName("DeliveryNoteNo");

                    b.Property<int?>("FK_DeliveryNotes_Customers_Id")
                        .HasColumnType("int");

                    b.Property<int?>("FK_DeliveryNotes_Orders_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FK_DeliveryNotes_Customers_Id");

                    b.HasIndex("FK_DeliveryNotes_Orders_Id");

                    b.ToTable("DeliveryNotes");
                });

            modelBuilder.Entity("ShopSystem.Models.Invoice", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FK_Invoice_Orders_Id")
                        .HasColumnType("int");

                    b.Property<int?>("FK_Invoices_Customers_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("InvoiceDate");

                    b.Property<int>("InvoiceNo")
                        .HasColumnType("int")
                        .HasColumnName("InvoiceNo");

                    b.HasKey("ID");

                    b.HasIndex("FK_Invoice_Orders_Id");

                    b.HasIndex("FK_Invoices_Customers_Id");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("ShopSystem.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeliveryDate");

                    b.Property<string>("Ean")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ean");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ItemName");

                    b.Property<string>("ItemNo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ItemNo");

                    b.Property<bool>("OnStock")
                        .HasColumnType("bit")
                        .HasColumnName("OnStock");

                    b.Property<int?>("VersionId")
                        .HasColumnType("int")
                        .HasColumnName("VersionId");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("ShopSystem.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("int")
                        .HasColumnName("AddressId");

                    b.Property<int>("DeliveryNoteAddressId")
                        .HasColumnType("int")
                        .HasColumnName("DeliveryNoteAddressId");

                    b.Property<int?>("FK_Orders_Addresses_Id")
                        .HasColumnType("int");

                    b.Property<int?>("InvoiceAddressId")
                        .HasColumnType("int")
                        .HasColumnName("InvoiceAddress");

                    b.Property<string>("Project")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Project");

                    b.Property<DateTime?>("SaveDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("SaveDate");

                    b.HasKey("Id");

                    b.HasIndex("FK_Orders_Addresses_Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ShopSystem.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FK_Positions_Items_Id")
                        .HasColumnType("int");

                    b.Property<int?>("FK_Positions_Orders_Id")
                        .HasColumnType("int");

                    b.Property<string>("ItemId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ItemId");

                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("OrderId");

                    b.Property<int>("Qty")
                        .HasColumnType("int")
                        .HasColumnName("Qty");

                    b.Property<string>("VersionId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VersionId");

                    b.HasKey("Id");

                    b.HasIndex("FK_Positions_Items_Id");

                    b.HasIndex("FK_Positions_Orders_Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("ShopSystem.Models.Customer", b =>
                {
                    b.HasOne("ShopSystem.Models.Address", "Addresses")
                        .WithMany()
                        .HasForeignKey("FK_Customers_Addresses_Id");

                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("ShopSystem.Models.DeliveryNote", b =>
                {
                    b.HasOne("ShopSystem.Models.Customer", "Customers")
                        .WithMany()
                        .HasForeignKey("FK_DeliveryNotes_Customers_Id");

                    b.HasOne("ShopSystem.Models.Order", "Orders")
                        .WithMany()
                        .HasForeignKey("FK_DeliveryNotes_Orders_Id");

                    b.Navigation("Customers");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ShopSystem.Models.Invoice", b =>
                {
                    b.HasOne("ShopSystem.Models.Order", "Orders")
                        .WithMany()
                        .HasForeignKey("FK_Invoice_Orders_Id");

                    b.HasOne("ShopSystem.Models.Customer", "Customers")
                        .WithMany()
                        .HasForeignKey("FK_Invoices_Customers_Id");

                    b.Navigation("Customers");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ShopSystem.Models.Order", b =>
                {
                    b.HasOne("ShopSystem.Models.Address", "Addresses")
                        .WithMany()
                        .HasForeignKey("FK_Orders_Addresses_Id");

                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("ShopSystem.Models.Position", b =>
                {
                    b.HasOne("ShopSystem.Models.Item", "Items")
                        .WithMany()
                        .HasForeignKey("FK_Positions_Items_Id");

                    b.HasOne("ShopSystem.Models.Order", "Orders")
                        .WithMany("Positions")
                        .HasForeignKey("FK_Positions_Orders_Id");

                    b.Navigation("Items");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ShopSystem.Models.Order", b =>
                {
                    b.Navigation("Positions");
                });
#pragma warning restore 612, 618
        }
    }
}
