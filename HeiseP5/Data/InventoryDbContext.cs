/*
 * Programmer: Chris Heise (crheise@icloud.com)
 * School: Central New Mexico Community College
 * Course: CIS 2284 .NET II/C#
 * Instructor: Rob Garner
 * Date: 13 October 2021
 * 
 * Program: P5 Inventory Accounting Application
 * Purpose: Use C#, .NET, and Blazor to build a web application
 *          that can store inventory and calculate depreciated values.
 * File: InventoryDbContext.cs
 */

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;

namespace HeiseP5.Data
{
    public class InventoryDbContext : DbContext
    {
        #region Constructor
        public InventoryDbContext(DbContextOptions<InventoryDbContext> context) : base(context)
        {
        }
        #endregion

        #region Public properties
        public DbSet<InventoryItem> InventoryItems { get; set; }
        #endregion

        #region Overridden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InventoryItem>().HasData(GetInventoryItems());
            base.OnModelCreating(modelBuilder);
        }
        #endregion

        #region Private methods
        //Preload the database with InventoryItems to view and manipulate
        private List<InventoryItem> GetInventoryItems()
        {
            return new List<InventoryItem>
            {
                new InventoryItem {Id = 1001, Title = "Desk Lamp", StartValue = 50.0M, SalvageValue = 5.0M, LifeTime = 20, IsActive = true, DateAdded = new DateTime(2015, 4, 26), DateRemoved = DateTime.Today },
                new InventoryItem {Id = 1002, Title = "Computer Monitor", StartValue = 250.0M, SalvageValue = 20.0M, LifeTime = 10, IsActive = true, DateAdded = new DateTime(2021, 8, 15), DateRemoved = DateTime.Today },
                new InventoryItem {Id = 1003, Title = "Coffee Cup", StartValue = 15.0M, SalvageValue = 0.5M, LifeTime = 30, IsActive = false, DateAdded = new DateTime(2005, 12, 31), DateRemoved = new DateTime(2020, 1, 25) },
                new InventoryItem {Id = 1004, Title = "Keyboard", StartValue = 100.0M, SalvageValue = 10.0M, LifeTime = 10, IsActive = true, DateAdded = new DateTime(2018, 6, 2), DateRemoved = DateTime.Today },
                new InventoryItem {Id = 1005, Title = "Wireless Speaker", StartValue = 75.0M, SalvageValue = 15.0M, LifeTime = 5, IsActive = true, DateAdded = new DateTime(2019, 9, 29), DateRemoved = DateTime.Today }
            };
        }
        #endregion
    }

    //public class InventoryDbContextFactory : IDesignTimeDbContextFactory<InventoryDbContext>
    //{
    //    public InventoryDbContext CreateDbContext(string[] args)
    //    {
    //        var optionsBuilder = new DbContextOptionsBuilder<InventoryDbContext>();
    //        optionsBuilder.UseSqlite("data Source = test.db");

    //        return new InventoryDbContext(optionsBuilder.Options);
    //    }
    //}
}
