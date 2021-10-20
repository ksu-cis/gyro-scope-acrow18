/*
 * Gyro.cs
 * Author: Alisha C.
 */

using GyroScope.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Entrees
/// </summary>
namespace GyroScope.Data.Entrees
{
    /// <summary>
    /// A base class for all Gyros sold at GyroScope
    /// </summary>
    public abstract class Gyro : Entree, IMenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// backing field for meat
        /// </summary>
        public DonerMeat _meat = DonerMeat.Lamb;

        /// <summary>
        /// What kind of meat this Gyro is prepared with
        /// </summary>
        public DonerMeat Meat 
        {
            get => _meat;
            set
            {
                if (_meat != value)
                {
                    _meat = value;
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));
                    OnPropertyChanged(nameof(this.Meat));

                }
            }
        }

        /// <summary>
        /// backing field for pita
        /// </summary>
        public bool _pita;

        /// <summary>
        /// Gyro should be served with a pita bread wrap
        /// </summary>
        public bool Pita 
        {
            get => _pita;
            set
            {
                if (_pita != value)
                {
                    _pita = value;
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));
                    OnPropertyChanged(nameof(this.Pita));

                }
            }
        }

        /// <summary>
        /// backing field for peppers
        /// </summary>
        public bool _peppers;

        /// <summary>
        /// Gyro should be served with peppers
        /// </summary>
        public bool Peppers 
        { 
            get => _peppers;
            set
            {
                if (_peppers != value)
                {
                    _peppers = value;
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));
                    OnPropertyChanged(nameof(this.Peppers));

                }
            }
        }

        /// <summary>
        /// backing field for onion
        /// </summary>
        public bool _onion;

        /// <summary>
        /// Gyro should be served with onion
        /// </summary>
        public bool Onion 
        {
            get => _onion;
            set
            {
                if (_onion != value)
                {
                    _onion = value;
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));
                    OnPropertyChanged(nameof(this.Onion));

                }
            }
        }

        /// <summary>
        /// backing field for lettuce
        /// </summary>
        public bool _lettuce; 

        /// <summary>
        /// Gyro should be served with Lettuce
        /// </summary>
        public bool Lettuce 
        {
            get => _lettuce;
            set
            {
                if (_lettuce != value)
                {
                    _lettuce = value;
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));
                    OnPropertyChanged(nameof(this.Lettuce));

                }
            }
        }

        /// <summary>
        /// backing field for wing sauce
        /// </summary>
        public bool _wingSauce;

        /// <summary>
        /// Gyro should be served with Wing sauce
        /// </summary>
        public bool WingSauce 
        {
            get => _wingSauce;
            set
            {
                if (_wingSauce != value)
                {
                    _wingSauce = value;
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));
                    OnPropertyChanged(nameof(this.WingSauce));

                }
            }
        }

        /// <summary>
        /// backing field for tomato
        /// </summary>
        public bool _tomato; 

        /// <summary>
        /// Gyro should be served with Tomato
        /// </summary>
        public bool Tomato {
            get => _tomato;
            set
            {
                if (_tomato != value)
                {
                    _tomato = value;
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));
                    OnPropertyChanged(nameof(this.Tomato));
                }
            }
        }

        /// <summary>
        /// backing field for eggplant
        /// </summary>
        public bool _eggplant;

        /// <summary>
        /// Gyro should be served with Eggplant
        /// </summary>
        public bool Eggplant {
            get => _eggplant;
            set
            {
                if (_eggplant != value)
                {
                    _eggplant = value;
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));
                    OnPropertyChanged(nameof(this.Eggplant));
                }
            }
        }

        /// <summary>
        /// backing field for mint chutney
        /// </summary>
        public bool _mintChutney;

        /// <summary>
        /// Gyro should be served with Mint chutney
        /// </summary>
        public bool MintChutney {
            get => _mintChutney;
            set
            {
                if (_mintChutney != value)
                {
                    _mintChutney = value;
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));
                    OnPropertyChanged(nameof(this.MintChutney));
                }
            }
        }

        /// <summary>
        /// backing field for tzatziki
        /// </summary>
        public bool _tzatziki;

        /// <summary>
        /// Gyro should be served with Tzatziki sauce
        /// </summary>
        public bool Tzatziki {
            get => _tzatziki;
            set
            {
                if (_tzatziki != value)
                {
                    _tzatziki = value;
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.SpecialInstructions));
                    OnPropertyChanged(nameof(this.Tzatziki));
                }
            }
        }

        /// <summary>
        /// Price of Entree
        /// </summary>
        public override abstract decimal Price { get; }

        /// <summary>
        /// Calories for this gyro
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint calorieSum = 0;
                if (Pita != false)
                {
                    calorieSum += 262;
                }

                if (Tomato != false)
                {
                    calorieSum += 30;
                }

                if (Onion != false)
                {
                    calorieSum += 30;
                }

                if (Eggplant != false)
                {
                    calorieSum += 47;
                }

                if (Lettuce != false)
                {
                    calorieSum += 54;
                }

                if (MintChutney != false)
                {
                    calorieSum += 10;
                }

                if (WingSauce != false)
                {
                    calorieSum += 15;
                }

                if (Tzatziki != false)
                {
                    calorieSum += 30;
                }

                if (Peppers != false)
                {
                    calorieSum += 33;
                }

                if (Meat == DonerMeat.Pork)
                {
                    calorieSum += 187;
                }

                if (Meat == DonerMeat.Lamb)
                {
                    calorieSum += 151;
                }

                if (Meat == DonerMeat.Chicken)
                {
                    calorieSum += 113;
                }

                if (Meat == DonerMeat.Beef)
                {
                    calorieSum += 181;
                }

                return calorieSum;
            }
        }

        /// <summary>
        /// Special instructions
        /// </summary>
        public override abstract IEnumerable<string> SpecialInstructions { get; }

    }
}
