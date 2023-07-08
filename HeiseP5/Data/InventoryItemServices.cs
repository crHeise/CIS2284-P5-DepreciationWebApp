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
 * File: InventoryItemServices.cs
 */

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeiseP5.Data
{
    public class InventoryItemServices
    {
        #region Private members
        private InventoryDbContext dbContext;
        #endregion

        #region Constructor
        public InventoryItemServices(InventoryDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// This method returns the list of inventory items
        /// </summary>
        /// <returns></returns>
        public async Task<List<InventoryItem>> GetInventoryAsync()
        {
            return await dbContext.InventoryItems.ToListAsync();
        }
        /// <summary>
        /// This method add a new product to the DbContext and saves it
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task<InventoryItem> AddItemAsync(InventoryItem item)
        {
            try
            {
                dbContext.InventoryItems.Add(item);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return item;
        }
        /// <summary>
        /// This method update and existing product and saves the changes
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task<InventoryItem> UpdateItemAsync(InventoryItem item)
        {
            try
            {
                var productExist = dbContext.InventoryItems.FirstOrDefault(p => p.Id == item.Id);
                if (productExist != null)
                {
                    dbContext.Update(item);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return item;
        }
        /// <summary>
        /// This method removes and existing product from the DbContext and saves it
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task DeleteItemAsync(InventoryItem item)
        {
            try
            {
                dbContext.InventoryItems.Remove(item);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
