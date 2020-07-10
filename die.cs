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
        byte minValue;
        byte maxValue;

        static Die() // Stataic constroutors are called once for all instances of a class
        {
            rand = new Random();
        }

        public Die():this(1,6)
        {
            //minValue = 1;
            //maxValue = 6;
            //Roll(); // roll die on cretion to aviod the 0 glitch
        }

        /// <summary>
        /// Creates a die with numbers between the minimum and maximum values
        /// </summary>
        /// <param name="minValue">The inclusive lower bound</param>
        /// <param name="maxValue">The inclusive maximum bound</param>
        public Die(byte minValue, byte maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
            Roll();
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
            if (!IsHeld) // if die is not held
            {
                // add 1 to maxValue due to the upp bound
                // being exclusive
                Value = (byte)rand.Next(minValue, maxValue + 1);
            }
            return Value;
        }
    }
}
