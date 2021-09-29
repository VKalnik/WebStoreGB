﻿using Microsoft.EntityFrameworkCore;
using WebStore.Domain.Entities;

namespace WebStore.DAL.Context
{
    class WebStoreDB : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Section> Sections { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public WebStoreDB(DbContextOptions<WebStoreDB> options) : base(options) { }

        //    protected override void OnModelCreating(ModelBuilder model)
        //    {
        //        base.OnModelCreating(model);

        //        //model.Entity<Section>();
        //    }
    }
}
