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
        public override string DriveForward()
        {
            return "The Really Really Long Bus doesn't drive forward";
        }

        public override string Honk()
        {
            return "BEEP BEEP";
        }

        public override string Reverse()
        {
            return "The Really Really Long Bus doesn't go in reverse";
        }

        public override string TurnOff()
        {
            return "The Really Really Long Bus has been turned off forever";
        }

        public override string TurnOn()
        {
             return "The Really Really Long Bus doesn't turn on";
        }
        
    }
}
