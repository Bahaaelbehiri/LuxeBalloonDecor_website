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
        public LuxeBalloonContext (DbContextOptions<LuxeBalloonContext> options)
            : base(options)
        {
        }

        public DbSet<LuxeBalloonDecor_website.Server.Models.Testimonial> Testimonial { get; set; } = default!;
        public DbSet<LuxeBalloonDecor_website.Server.Models.Booking> Booking { get; set; } = default!;
        public DbSet<LuxeBalloonDecor_website.Server.Models.Customer> Customer { get; set; } = default!;
        public DbSet<LuxeBalloonDecor_website.Server.Models.CustomerBookings> CustomerBookings { get; set; } = default!;
        public DbSet<LuxeBalloonDecor_website.Server.Models.Image> Image { get; set; } = default!;
        public DbSet<LuxeBalloonDecor_website.Server.Models.InventoryItem> InventoryItem { get; set; } = default!;
        public DbSet<LuxeBalloonDecor_website.Server.Models.InventoryVariant> InventoryVariant { get; set; } = default!;
        public DbSet<LuxeBalloonDecor_website.Server.Models.VariantPrice> VariantPrice { get; set; } = default!;
    }
}
