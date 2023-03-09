﻿using Microsoft.EntityFrameworkCore;
using StoresG8.Shared.Entities;

namespace StoresG8.API.Data
{
    public class DataContext:DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) :base(options) 
        {
            
        }
       
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();

        }



    }
}
