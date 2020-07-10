using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemoWithDieClass
{
    /// <summary>
    /// Represents an individual dice
    /// </summary>
    class die
    {
        /// <summary>
        /// Face value of die
        /// </summary>
        public byte Value { get;  private set; }

        /// <summary>
        /// is die held or not
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Roll a new random number between one and 6
        /// </summary>
        /// <returns></returns>
        public byte Roll()
        {
            Random rand = new Random();
            Value = (byte)rand.Next(1, 7);
            return Value;
        }
    }
}
