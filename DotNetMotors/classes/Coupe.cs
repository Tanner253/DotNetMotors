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

        public override void DriveForward()
        {
            Console.WriteLine("The sedan drives forward");
        }
        public override void Honk()
        {
            Console.WriteLine("BEEP BEEP im a coupe!");
        }

        public override void Reverse()
        {
            Console.WriteLine("The car drives forward");
        }

        public override void TurnOff()
        {
            Console.WriteLine("The sedan has turned off");
        }

        public override void TurnOn()
        {
            Console.WriteLine("The sedan has turned on");
        }
    }
}
