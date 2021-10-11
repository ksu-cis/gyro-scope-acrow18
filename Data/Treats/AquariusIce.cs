/*
 * AquariusIce.cs
 * Modified: Alisha C.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;
using GyroScope.Data.Sides;
using System.ComponentModel;

namespace GyroScope.Data.Treats
{
    /// <summary>
    /// A class representing "Aquarius Ice" - an itialian iced soda
    /// </summary>
    public class AquariusIce : Treat, INotifyPropertyChanged
    {
        /// <summary>
        /// backing field for size
        /// </summary>
        public Size _size = Size.Small;

        /// <summary>
        /// The size of this Aquarius Ice
        /// </summary>
        public override Size Size
        {
            get => _size;
            set
            {
                if (_size != value)
                {
                    _size = value;
                    OnPropertyChanged(nameof(this.Size));
                    OnPropertyChanged(nameof(this.Flavor));
                    OnPropertyChanged(nameof(this.Name));
                }
            }
        }


        ///<summary>
        /// Name of aquarius ice
        /// </summary>
        public override String Name { get { return $"{ Size} {Flavor} Aquarius Ice"; } }

        /// <summary>
        /// backing field for flavor
        /// </summary>
        public AquariusIceFlavor _flavor = AquariusIceFlavor.Lemon;

        /// <summary>
        /// The flavor of this Aquarius Ice
        /// </summary>
        public AquariusIceFlavor Flavor 
        {
            get => _flavor;
            set
            {
                if (_flavor != value)
                {
                    _flavor = value;
                    OnPropertyChanged(nameof(this.Flavor));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.Name));
                }
            }
        }

        /// <summary>
        /// The calories of this Aquarius Ice
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Flavor)
                {
                    case AquariusIceFlavor.Lemon:
                    case AquariusIceFlavor.Orange:
                    case AquariusIceFlavor.Mango:
                    case AquariusIceFlavor.Watermellon:
                        return 45;
                    case AquariusIceFlavor.BlueRaspberry:
                    case AquariusIceFlavor.Strawberry:
                        return 170;
                    default:
                        throw new NotImplementedException($"Unknown Flavor {Flavor}");
                }
            }
        }

        /// <summary>
        /// The price of this Aquarius Ice
        /// </summary>
        public override decimal Price 
        { 
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 2.00m;
                    case Size.Medium:
                        return 2.50m;
                    case Size.Large:
                        return 3.00m;
                    default:
                        throw new NotImplementedException($"Unknown Size {Size}");
                }
            }
        }
    }
}
