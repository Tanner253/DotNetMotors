using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.classes
{
    public class ReallyReallyLongBus : BrokenCar 
    {
        public override bool Starts { get; set; } = false;
        public override bool MakesNoise { get; set; } = false;
        public override bool IsReal { get; set; } = false;
        public override int Price { get; set; } = 13000;
        /// <summary>
        /// the action of drivin forward
        /// </summary>
        /// <returns>string</returns>
        public override string DriveForward()
        {
            return "The Really Really Long Bus doesn't drive forward";
        }
        /// <summary>
        /// the action of honking
        /// </summary>
        /// <returns>string</returns>
        public override string Honk() { return "BEEP BEEP"; }
        /// <summary>
        /// the action of going reverse
        /// </summary>
        /// <returns>string</returns>
        public override string Reverse()
        {
            return "The Really Really Long Bus doesn't go in reverse";
        }
        /// <summary>
        /// the action of turning off
        /// </summary>
        /// <returns>string</returns>
        public override string TurnOff()
        {
            return "The Really Really Long Bus has been turned off forever";
        }
        /// <summary>
        /// the action of turning on 
        /// </summary>
        /// <returns>string</returns>
        public override string TurnOn()
        {
             return "The Really Really Long Bus doesn't turn on";
        }
        
    }
}
