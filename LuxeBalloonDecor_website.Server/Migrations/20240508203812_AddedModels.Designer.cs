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
    [Migration("20240508203812_AddedModels")]
    partial class AddedModels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingID"));

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.HasKey("BookingID");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("CustomerContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.CustomerBookings", b =>
                {
                    b.Property<int>("CustomerBookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerBookingID"));

                    b.Property<int>("BookingID")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.HasKey("CustomerBookingID");

                    b.HasIndex("BookingID");

                    b.HasIndex("CustomerID");

                    b.ToTable("CustomerBookings");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.Image", b =>
                {
                    b.Property<int>("ImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageID"));

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageID");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.InventoryItem", b =>
                {
                    b.Property<int>("InventoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InventoryID"));

                    b.Property<int?>("BookingID")
                        .HasColumnType("int");

                    b.Property<string>("InventoryDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InventoryImageImageID")
                        .HasColumnType("int");

                    b.Property<string>("InventoryTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InventoryID");

                    b.HasIndex("BookingID");

                    b.HasIndex("InventoryImageImageID");

                    b.ToTable("InventoryItem");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.InventoryVariant", b =>
                {
                    b.Property<int>("VariantID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VariantID"));

                    b.Property<int?>("InventoryItemInventoryID")
                        .HasColumnType("int");

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.HasKey("VariantID");

                    b.HasIndex("InventoryItemInventoryID");

                    b.ToTable("InventoryVariant");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.Testimonial", b =>
                {
                    b.Property<int>("TestimonailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestimonailID"));

                    b.Property<string>("TestimonailDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestimonailInitials")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("TestimonialDate")
                        .HasColumnType("date");

                    b.Property<string>("TestimonialTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestimonailID");

                    b.ToTable("Testimonial");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.VariantPrice", b =>
                {
                    b.Property<int>("PriceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PriceId"));

                    b.Property<int?>("InventoryVariantVariantID")
                        .HasColumnType("int");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VariantID")
                        .HasColumnType("int");

                    b.HasKey("PriceId");

                    b.HasIndex("InventoryVariantVariantID");

                    b.ToTable("VariantPrice");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.CustomerBookings", b =>
                {
                    b.HasOne("LuxeBalloonDecor_website.Server.Models.Booking", "Booking")
                        .WithMany()
                        .HasForeignKey("BookingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LuxeBalloonDecor_website.Server.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.InventoryItem", b =>
                {
                    b.HasOne("LuxeBalloonDecor_website.Server.Models.Booking", null)
                        .WithMany("BookingItems")
                        .HasForeignKey("BookingID");

                    b.HasOne("LuxeBalloonDecor_website.Server.Models.Image", "InventoryImage")
                        .WithMany()
                        .HasForeignKey("InventoryImageImageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InventoryImage");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.InventoryVariant", b =>
                {
                    b.HasOne("LuxeBalloonDecor_website.Server.Models.InventoryItem", null)
                        .WithMany("Variants")
                        .HasForeignKey("InventoryItemInventoryID");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.VariantPrice", b =>
                {
                    b.HasOne("LuxeBalloonDecor_website.Server.Models.InventoryVariant", null)
                        .WithMany("InventoryPrices")
                        .HasForeignKey("InventoryVariantVariantID");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.Booking", b =>
                {
                    b.Navigation("BookingItems");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.InventoryItem", b =>
                {
                    b.Navigation("Variants");
                });

            modelBuilder.Entity("LuxeBalloonDecor_website.Server.Models.InventoryVariant", b =>
                {
                    b.Navigation("InventoryPrices");
                });
#pragma warning restore 612, 618
        }
    }
}
