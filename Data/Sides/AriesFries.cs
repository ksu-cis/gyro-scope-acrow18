﻿/*
 * AriesFries.cs
 * Author: Alisha C.
 */

using GyroScope.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Sides
/// </summary>
namespace GyroScope.Data.Sides
{
    /// <summary>
    /// Declares a class for the side AresFries
    /// </summary>
    public class AriesFries : Side
    {
        /// <summary>
        /// Price of fries
        /// (1.50 for S, 2.00 for M, 2,50 for L)
        /// </summary>
        public override decimal Price 
        {
            get
            {   
                if (Size == Size.Small)
                {
                    return 1.50M;
                }

                if (Size == Size.Medium)
                {
                     return 2.00M;
                }

                if (Size == Size.Large)
                {
                    return 2.50M;
                }

                throw new InvalidOperationException("Unknown size: " + Size);
            }
        }

        /// <summary>
        /// Calorie of fries 
        /// (304 for S, 456 for M, 608 for L)
        /// </summary>
        public override uint Calories 
        {
            get 
            { 
                if (Size == Size.Small) 
                {
                    return 304;
                }

                if (Size == Size.Medium)
                {
                    return 456;
                }

                if (Size == Size.Large)
                {
                    return 608;
                }

                throw new InvalidOperationException("Unknown size: " + Size);
            }
        }

    }
}
