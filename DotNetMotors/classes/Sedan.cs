using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.classes
{
    class Sedan : RunningCar
    {
        public override bool Starts { get; set; } = true;
        public override bool MakesNoise { get; set; } = true;

        public override int Price { get; set; } = 1000;
        public override string DriveForward()
        {
            return "The car drives forward";
        }

        public override string Honk()
        {
            return "BEEP BEEP";
        }

        public override string Reverse()
        {
            return "The car drives forward";
        }

        public override string TurnOff()
        {
            return "The coupe has turned off";
        }

        public override string TurnOn()
        {
            return "The coupe has turned on";
        }
    }
}
