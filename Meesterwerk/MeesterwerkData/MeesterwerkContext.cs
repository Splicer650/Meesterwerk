using MeesterwerkData.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace MeesterwerkData
{
    public class MeesterwerkContext : DbContext
    {
        public MeesterwerkContext(DbContextOptions options) : base(options) { }

        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<Drawing> Drawings { get; set; }
    }
}
