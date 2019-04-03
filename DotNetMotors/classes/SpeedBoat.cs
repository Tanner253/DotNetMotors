using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DotNetMotors.classes
{
    public class SpeedBoat : Boat , IHasBow
    {
        public override bool Floats { get; set; }
        public override int HasFlag { get; set; }
        
        public override bool Starts { get; set; }
        public override bool MakesNoise { get; set; } = true;
        public override int Price { get; set; } = 32000;

        public override bool IsReal { get; set; } = true;
        public bool IHasBow(IHasBow hasBow)
        {
            return true;
        }

        public override string Drives()
        {
            return "The Boat is Driving!";
        }

        public override string TurnOff()
        {
            return "The boat has turned off.";
        }

        public override string TurnOn()
        {
            return "The boat has turned on.";
        }
        public string CanReverse()
        {
            return "the boat is going in reverse";
        }

        bool IHasBow.HasFlag()
        {
            return true;
        }
    }
}
