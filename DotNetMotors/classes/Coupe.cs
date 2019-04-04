using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DotNetMotors.classes
{
    public class Coupe : RunningCar
    {
        public override bool Starts { get ; set ; } = true;
        public override bool MakesNoise { get; set; } = true;
        public override bool IsReal { get; set; } = false;

        public override int Price { get; set; } = 3000;
        /// <summary>
        /// the action of driving forward
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
            return "BEEP BEEP im a coupe!";
        }
        /// <summary>
        /// the action of going reverse
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
            return "The Coupe has turned off";
        }
        /// <summary>
        /// the action of turning on
        /// </summary>
        /// <returns></returns>
        public override string TurnOn()
        {
           return "The Coupe has turned on";
        }
    }
}
