using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LuxeBalloonDecor_website.Server.Models;

namespace LuxeBalloonDecor_website.Server.Data
{
    public class LuxeBalloonContext : DbContext
    {
        public LuxeBalloonContext (DbContextOptions<LuxeBalloonContext> options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(type => type.GetProperties())
                .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            {
                property.SetColumnType("decimal(18,2)");
            }
        }


        public DbSet<LuxeBalloonDecor_website.Server.Models.Address> Address { get; set; } = default!;
        public DbSet<LuxeBalloonDecor_website.Server.Models.Analytics> Analytics { get; set; } = default!;
        public DbSet<LuxeBalloonDecor_website.Server.Models.Booking> Booking { get; set; } = default!;
        public DbSet<LuxeBalloonDecor_website.Server.Models.BookingDetails> BookingDetails { get; set; } = default!;
        public DbSet<LuxeBalloonDecor_website.Server.Models.BookingInventory> BookingInventory { get; set; } = default!;
        public DbSet<LuxeBalloonDecor_website.Server.Models.CommunicationLogEntry> CommunicationLogEntry { get; set; } = default!;
        public DbSet<LuxeBalloonDecor_website.Server.Models.ContactInfo> ContactInfo { get; set; } = default!;
        public DbSet<LuxeBalloonDecor_website.Server.Models.FinancialRecord> FinancialRecord { get; set; } = default!;
        public DbSet<LuxeBalloonDecor_website.Server.Models.InventoryItem> InventoryItem { get; set; } = default!;
        public DbSet<LuxeBalloonDecor_website.Server.Models.InventoryRequest> InventoryRequest { get; set; } = default!;
        public DbSet<LuxeBalloonDecor_website.Server.Models.InvoiceDetails> InvoiceDetails { get; set; } = default!;
        public DbSet<LuxeBalloonDecor_website.Server.Models.MultimediaContent> MultimediaContent { get; set; } = default!;
        public DbSet<LuxeBalloonDecor_website.Server.Models.Page> Page { get; set; } = default!;
        public DbSet<LuxeBalloonDecor_website.Server.Models.PageElement> PageElement { get; set; } = default!;
        public DbSet<LuxeBalloonDecor_website.Server.Models.PersonDetails> PersonDetails { get; set; } = default!;
        public DbSet<LuxeBalloonDecor_website.Server.Models.StyleSettings> StyleSettings { get; set; } = default!;
        public DbSet<LuxeBalloonDecor_website.Server.Models.UsageDetails> UsageDetails { get; set; } = default!;
        public DbSet<LuxeBalloonDecor_website.Server.Models.Venue> Venue { get; set; } = default!;


    }
}
