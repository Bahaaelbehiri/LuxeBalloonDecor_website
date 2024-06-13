﻿// <auto-generated />
using System;
using LuxeBalloonDecor_website.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LuxeBalloonDecor_website.Server.Migrations
{
    [DbContext(typeof(LuxeBalloonContext))]
    [Migration("20240529072747_Added-New-Database")]
    partial class AddedNewDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.Address", b =>
                {
                    b.Property<int>("addressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("addressID"));

                    b.Property<int>("addressType")
                        .HasColumnType("int");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("personID")
                        .HasColumnType("int");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("street1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("street2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zipcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("addressID");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.Analytics", b =>
                {
                    b.Property<int>("analyticsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("analyticsID"));

                    b.Property<int>("pageID")
                        .HasColumnType("int");

                    b.Property<int>("view")
                        .HasColumnType("int");

                    b.HasKey("analyticsID");

                    b.ToTable("Analytics");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.Booking", b =>
                {
                    b.Property<int>("bookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("bookingID"));

                    b.Property<int>("bookingStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("orderNumber")
                        .HasColumnType("int");

                    b.Property<int>("personID")
                        .HasColumnType("int");

                    b.Property<int>("venueID")
                        .HasColumnType("int");

                    b.HasKey("bookingID");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.BookingDetails", b =>
                {
                    b.Property<int>("bookingDetailsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("bookingDetailsID"));

                    b.Property<int>("bookingID")
                        .HasColumnType("int");

                    b.HasKey("bookingDetailsID");

                    b.ToTable("BookingDetails");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.BookingInventory", b =>
                {
                    b.Property<int>("bookingInventoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("bookingInventoryID"));

                    b.Property<int>("bookingID")
                        .HasColumnType("int");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("itemID")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.HasKey("bookingInventoryID");

                    b.ToTable("BookingInventory");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.CommunicationLogEntry", b =>
                {
                    b.Property<int>("logID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("logID"));

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<int>("mode")
                        .HasColumnType("int");

                    b.Property<int?>("multimediaContentID")
                        .HasColumnType("int");

                    b.Property<int>("outcome")
                        .HasColumnType("int");

                    b.Property<int>("personID")
                        .HasColumnType("int");

                    b.HasKey("logID");

                    b.ToTable("CommunicationLogEntry");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.ContactInfo", b =>
                {
                    b.Property<int>("contactInfoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("contactInfoID"));

                    b.Property<int?>("PersonDetailspersonID")
                        .HasColumnType("int");

                    b.Property<int>("contactType")
                        .HasColumnType("int");

                    b.Property<int>("personID")
                        .HasColumnType("int");

                    b.Property<string>("value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("contactInfoID");

                    b.HasIndex("PersonDetailspersonID");

                    b.ToTable("ContactInfo");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.FinancialRecord", b =>
                {
                    b.Property<int>("financialRecordID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("financialRecordID"));

                    b.Property<decimal>("amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("bookingID")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("entryType")
                        .HasColumnType("int");

                    b.Property<int>("invoiceDetailsID")
                        .HasColumnType("int");

                    b.Property<int>("personID")
                        .HasColumnType("int");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("financialRecordID");

                    b.ToTable("FinancialRecord");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.InventoryItem", b =>
                {
                    b.Property<int>("itemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("itemID"));

                    b.Property<string>("itemDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("itemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("quantityAvailable")
                        .HasColumnType("int");

                    b.HasKey("itemID");

                    b.ToTable("InventoryItem");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.InventoryRequest", b =>
                {
                    b.Property<int>("requestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("requestID"));

                    b.Property<int>("itemID")
                        .HasColumnType("int");

                    b.Property<int>("reqestStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("requestDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("requestedQuantity")
                        .HasColumnType("int");

                    b.HasKey("requestID");

                    b.ToTable("InventoryRequest");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.InvoiceDetails", b =>
                {
                    b.Property<int>("invoiceDetailsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("invoiceDetailsID"));

                    b.Property<decimal>("amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("financialRecordID")
                        .HasColumnType("int");

                    b.Property<string>("paymentDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("reciptDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("invoiceDetailsID");

                    b.ToTable("InvoiceDetails");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.MultimediaContent", b =>
                {
                    b.Property<int>("multimediaContentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("multimediaContentID"));

                    b.Property<int>("contentType")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fileFormat")
                        .HasColumnType("int");

                    b.Property<string>("filePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("filesize")
                        .HasColumnType("int");

                    b.HasKey("multimediaContentID");

                    b.ToTable("MultimediaContent");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.Page", b =>
                {
                    b.Property<int>("pageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("pageID"));

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("pageID");

                    b.ToTable("Page");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.PageElement", b =>
                {
                    b.Property<int>("elementID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("elementID"));

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("elementType")
                        .HasColumnType("int");

                    b.Property<int?>("multimediaContentID")
                        .HasColumnType("int");

                    b.Property<int>("pageID")
                        .HasColumnType("int");

                    b.Property<decimal?>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("elementID");

                    b.ToTable("PageElement");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.PersonDetails", b =>
                {
                    b.Property<int>("personID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("personID"));

                    b.Property<DateTime>("birthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("role")
                        .HasColumnType("int");

                    b.Property<string>("testimonials")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("personID");

                    b.ToTable("PersonDetails");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.StyleSettings", b =>
                {
                    b.Property<int>("settingsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("settingsID"));

                    b.Property<string>("colorScheme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("font")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pageID")
                        .HasColumnType("int");

                    b.HasKey("settingsID");

                    b.ToTable("StyleSettings");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.UsageDetails", b =>
                {
                    b.Property<int>("usageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("usageID"));

                    b.Property<int>("itemID")
                        .HasColumnType("int");

                    b.Property<string>("purpose")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("quantityUsed")
                        .HasColumnType("int");

                    b.Property<DateTime>("usageDate")
                        .HasColumnType("datetime2");

                    b.HasKey("usageID");

                    b.ToTable("UsageDetails");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.Venue", b =>
                {
                    b.Property<int>("venueID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("venueID"));

                    b.Property<int>("addressID")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("venueID");

                    b.ToTable("Venue");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.ContactInfo", b =>
                {
                    b.HasOne("LuxeBalloonDecor_website.Server.Models.PersonDetails", null)
                        .WithMany("contactDetails")
                        .HasForeignKey("PersonDetailspersonID");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.PersonDetails", b =>
                {
                    b.Navigation("contactDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
