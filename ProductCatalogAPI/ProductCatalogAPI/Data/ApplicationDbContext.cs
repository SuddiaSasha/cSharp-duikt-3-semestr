﻿namespace ProductCatalogAPI.Data
{
    using Microsoft.EntityFrameworkCore;
    using ProductCatalogAPI.Models;

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}