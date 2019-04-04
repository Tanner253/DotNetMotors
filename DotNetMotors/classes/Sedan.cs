using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.classes
{
    public class Sedan : RunningCar
    {
        public override bool Starts { get; set; } = true;
        public override bool MakesNoise { get; set; } = true;

        public override int Price { get; set; } = 1000;
        /// <summary>
        /// the acion of driving forward
        /// </summary>
        /// <returns>string</returns>
        public override string DriveForward()
        {
            return "The car drives forward";
        }
        /// <summary>
        /// the action of honking
        /// </summary>
        /// <returns>string</returns>
        public override string Honk()
        {
            return "BEEP BEEP";
        }
        /// <summary>
        /// the action of reversing
        /// </summary>
        /// <returns>string</returns>
        public override string Reverse()
        {
            return "The car Reverses";
        }
        /// <summary>
        /// the action of turning off 
        /// </summary>
        /// <returns>string</returns>
        public override string TurnOff()
        {
            return "The sedan has turned off";
        }
        /// <summary>
        /// this is the action of turning on 
        /// </summary>
        /// <returns>string</returns>
        public override string TurnOn()
        {
            return "The sedan has turned on";
        }
    }
}
