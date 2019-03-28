using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.classes
{
    class Coupe : RunningCar
    {
        public override bool Starts { get ; set ; } = true;
        public override bool MakesNoise { get; set; } = true;
        public override bool IsReal { get; set; } = false;

        public override int Price { get; set; } = 3000;

        public override string DriveForward()
        {
            return "The car drives forward";
        }
        public override string Honk()
        {
            return "BEEP BEEP im a coupe!";
        }

        public override string Reverse()
        {
            return "The car drives forward";
        }

        public override string TurnOff()
        {
            return "The sedan has turned off";
        }

        public override string TurnOn()
        {
           return "The sedan has turned on";
        }
    }
}
