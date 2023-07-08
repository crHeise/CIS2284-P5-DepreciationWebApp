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
 * File: InventoryItem.cs
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeiseP5.Data
{
    public class InventoryItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }

        protected DateTime dateAddedToInventory;
        public DateTime DateAdded
        {
            get { return dateAddedToInventory; }
            set { dateAddedToInventory = value; Calc(); }
        }

        protected DateTime dateRemovedFromInventory;
        public DateTime DateRemoved
        {
            get { return dateRemovedFromInventory; }
            set { dateRemovedFromInventory = value; Calc(); }
        }

        protected decimal startValue;
        public decimal StartValue
        {
            get { return startValue; }
            set { startValue = value; Calc(); }
        }


        protected decimal salvageValue;
        public decimal SalvageValue
        {
            get { return salvageValue; }
            set { salvageValue = value; Calc(); }
        }

        protected int lifeTime;
        public int LifeTime
        {
            get { return lifeTime; }
            set { lifeTime = value; Calc(); }
        }

        public decimal CurrentValue { get; protected set; }

        public InventoryItem()
        {
            startValue = 100.0M;
            salvageValue = 10.0M;
            lifeTime = 1;
            dateAddedToInventory = DateTime.Today;
            dateRemovedFromInventory = DateTime.Today;
        }

        protected virtual void Calc()
        {
            //Calculate age of item
            TimeSpan age = dateRemovedFromInventory - dateAddedToInventory;

            //Get age of item in whole days
            int ageInDays = (int)age.TotalDays;

            //Check if item has reached its end of life value
            if (ageInDays < (lifeTime * 365))
            {
                //Depreciation rate
                decimal depAssetCost = startValue - salvageValue;   //from start to end of life
                decimal depPerYear = depAssetCost / lifeTime;       //each year
                decimal depPerDay = depPerYear / 365;               //each day

                CurrentValue = startValue - (depPerDay * ageInDays);
            }
            else
            {
                CurrentValue = salvageValue;
            }
        }
    }
}
