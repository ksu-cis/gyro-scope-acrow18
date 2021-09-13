﻿/*
 * CancerHalvehCake.cs
 * Author: Alisha C.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyroScope.Data.Treats
{
    /// <summary>
    /// Cancer Halveh Cake
    /// </summary>
    public class CancerHalvehCake : Treat
    {
        /// <summary>
        /// Price of Cancer Halveh Cake
        /// </summary>
        public override decimal Price => 3.00M;

        /// <summary>
        /// Calories of Cancer Halveh Cake
        /// </summary>
        public override uint Calories => 272;
    }
}
