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
 * File: InvestmentCalcVM.cs
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeiseP5.Models;

namespace HeiseP5.ViewModels
{
    public class InvestmentCalcVM
    {
        public InvestmentCalc InvestmentCalc { get; set; } = new InvestmentCalc();
        public bool ResultsVisible { get; set; } = false;

        public void OnSubmitClick()
        {
            ResultsVisible = true;
        }

        public void OnClearClick()
        {
            InvestmentCalc = new InvestmentCalc();
            ResultsVisible = false;
        }
    }
}
