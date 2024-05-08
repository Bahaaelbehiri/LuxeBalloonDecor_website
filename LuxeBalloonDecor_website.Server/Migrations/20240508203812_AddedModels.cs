using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LuxeBalloonDecor_website.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    BookingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.BookingID);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerContact = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    ImageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.ImageID);
                });

            migrationBuilder.CreateTable(
                name: "Testimonial",
                columns: table => new
                {
                    TestimonailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestimonialTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestimonialDate = table.Column<DateOnly>(type: "date", nullable: false),
                    TestimonailDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestimonailInitials = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonial", x => x.TestimonailID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerBookings",
                columns: table => new
                {
                    CustomerBookingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    BookingID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBookings", x => x.CustomerBookingID);
                    table.ForeignKey(
                        name: "FK_CustomerBookings_Booking_BookingID",
                        column: x => x.BookingID,
                        principalTable: "Booking",
                        principalColumn: "BookingID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerBookings_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InventoryItem",
                columns: table => new
                {
                    InventoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventoryImageImageID = table.Column<int>(type: "int", nullable: false),
                    InventoryTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InventoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookingID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryItem", x => x.InventoryID);
                    table.ForeignKey(
                        name: "FK_InventoryItem_Booking_BookingID",
                        column: x => x.BookingID,
                        principalTable: "Booking",
                        principalColumn: "BookingID");
                    table.ForeignKey(
                        name: "FK_InventoryItem_Image_InventoryImageImageID",
                        column: x => x.InventoryImageImageID,
                        principalTable: "Image",
                        principalColumn: "ImageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InventoryVariant",
                columns: table => new
                {
                    VariantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    InventoryItemInventoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryVariant", x => x.VariantID);
                    table.ForeignKey(
                        name: "FK_InventoryVariant_InventoryItem_InventoryItemInventoryID",
                        column: x => x.InventoryItemInventoryID,
                        principalTable: "InventoryItem",
                        principalColumn: "InventoryID");
                });

            migrationBuilder.CreateTable(
                name: "VariantPrice",
                columns: table => new
                {
                    PriceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VariantID = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InventoryVariantVariantID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VariantPrice", x => x.PriceId);
                    table.ForeignKey(
                        name: "FK_VariantPrice_InventoryVariant_InventoryVariantVariantID",
                        column: x => x.InventoryVariantVariantID,
                        principalTable: "InventoryVariant",
                        principalColumn: "VariantID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBookings_BookingID",
                table: "CustomerBookings",
                column: "BookingID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBookings_CustomerID",
                table: "CustomerBookings",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryItem_BookingID",
                table: "InventoryItem",
                column: "BookingID");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryItem_InventoryImageImageID",
                table: "InventoryItem",
                column: "InventoryImageImageID");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryVariant_InventoryItemInventoryID",
                table: "InventoryVariant",
                column: "InventoryItemInventoryID");

            migrationBuilder.CreateIndex(
                name: "IX_VariantPrice_InventoryVariantVariantID",
                table: "VariantPrice",
                column: "InventoryVariantVariantID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerBookings");

            migrationBuilder.DropTable(
                name: "Testimonial");

            migrationBuilder.DropTable(
                name: "VariantPrice");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "InventoryVariant");

            migrationBuilder.DropTable(
                name: "InventoryItem");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Image");
        }
    }
}
