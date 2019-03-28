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
        public override void DriveForward()
        {
            Console.WriteLine("The car drives forward");
        }

        public override void Honk()
        {
            Console.WriteLine("BEEP BEEP");
        }

        public override void Reverse()
        {
            Console.WriteLine("The car drives forward");
        }

        public override void TurnOff()
        {
            Console.WriteLine("The coupe has turned off");
        }

        public override void TurnOn()
        {
            Console.WriteLine("The coupe has turned on");
        }
    }
}
