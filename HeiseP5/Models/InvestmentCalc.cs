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
 * File: InvestmentCalc.cs
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HeiseP5.Models
{
    /// <summary>
    /// Calculates the future value of an investment.
    /// </summary>
    public class InvestmentCalc
    {
        private double principleStart;

        /// <summary>
        /// Starting principle amount.
        /// </summary>
        [Required]
        [Range(minimum: 0.0, maximum: double.MaxValue, 
            ErrorMessage = "Principle must be greater than 0 and not too big.")]
        public double PrincipleStart
        {
            get { return principleStart; }
            set { principleStart = value; Calc(); }
        }
        private double interestRate;

        /// <summary>
        /// The annual interest rate.
        /// </summary> 
        [Required]
        [Range(minimum: 0.0, maximum: 100.0, 
            ErrorMessage = "Interest Rate must be between 0 and 100.")]
        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; Calc(); }
        }
        private double timesCompounded;

        /// <summary>
        /// The number of times interest is compounded per year.
        /// </summary>
        [Required]
        [Range(minimum: 1, maximum: 24, 
            ErrorMessage = "Times Compounded/year must be between 1 and 24.")]
        public double TimesCompounded
        {
            get { return timesCompounded; }
            set { timesCompounded = value; Calc(); }
        }
        private double numOfYears;

        /// <summary>
        /// 
        /// </summary>
        [Required]
        [Range(minimum: 1, maximum: 30, 
            ErrorMessage = "Number of Years must be between 1 and 30.")]
        public double NumOfYears
        {
            get { return numOfYears; }
            set 
            { 
                if (value >= 1 && value <= 30)
                {
                    numOfYears = value; 
                    Calc();
                }
                else
                {
                    throw new ArgumentException("Years must be between 1 and 30!");
                }
            }
        }
        /// <summary>
        /// The future value of an investment.
        /// </summary>
        public double FutureValue { get; private set; }

        private void Calc()
        {
            double time = TimesCompounded * NumOfYears;

            //Calculate the future value
            FutureValue = PrincipleStart * Math.Pow(1 + (InterestRate/100 / TimesCompounded), time);
        }
    }
}
