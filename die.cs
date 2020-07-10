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
    class Die
    {
        // static fields are shared across all instances of a class
        static Random rand;

        static Die() // Stataic constroutors are called once for all instances of a class
        {
            rand = new Random();
        }

        public Die()
        {
            Roll(); // roll die on cretion to aviod the 0 glitch
        }

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
        /// and return the newly rolled value.
        /// if the die is held the current value 
        /// will be rreturned and no new value generated
        /// </summary>
        /// <returns></returns>
        public byte Roll()
        {
            Value = (byte)rand.Next(1, 7);
            return Value;
        }
    }
}
