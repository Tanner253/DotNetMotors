using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.classes
{
    public abstract class DotNetMotors
    {
        abstract public bool Starts { get; set; }
        public abstract bool MakesNoise { get; set; }
        public virtual bool IsReal { get; set; }
        public virtual int Price { get; set; }
        /// <summary>
        /// turn on
        /// </summary>
        /// <returns>string</returns>
        public abstract string TurnOn();
        /// <summary>
        /// turn off
        /// </summary>
        /// <returns>string</returns>
        public abstract string TurnOff();
        /// <summary>
        /// honk
        /// </summary>
        /// <returns>string</returns>
        public virtual string Honk()
        {
            return "BEEP BEEP";
        }

    }
}
