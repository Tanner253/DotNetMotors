using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DotNetMotors.classes
{
    public class SpeedBoat : Boat, IHasBow
    {
        public override bool Floats { get; set; }
        public override int HasFlag { get; set; }

        public override bool Starts { get; set; }
        public override bool MakesNoise { get; set; } = true;
        public override int Price { get; set; } = 32000;

        public override bool IsReal { get; set; } = true;
        /// <summary>
        /// returns true if has bow
        /// </summary>
        /// <returns>bool</returns>
        public bool IHasBow()
        {
            return true;
        }
        /// <summary>
        /// the action of driving
        /// </summary>
        /// <returns>string</returns>

        public override string Drives()
        {
            return "The Boat is Driving!";
        }
        /// <summary>
        /// the action of turning off
        /// </summary>
        /// <returns>string</returns>
        public override string TurnOff()
        {
            return "The boat has turned off.";
        }
        /// <summary>
        /// The action of turning on
        /// </summary>
        /// <returns></returns>
        public override string TurnOn()
        {
            return "The boat has turned on.";
        }
        /// <summary>
        /// the action of going reverse
        /// </summary>
        /// <returns>string</returns>
        public string CanReverse()
        {
            return "the boat is going in reverse";
        }
        /// <summary>
        /// the action of raising the flag
        /// </summary>
        /// <returns>string</returns>
        string IHasBow.HasFlag()
        {
            return "Raise thy flag";
        }
    }
}
