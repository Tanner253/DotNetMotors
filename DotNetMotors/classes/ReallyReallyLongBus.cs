using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.classes
{
    public class ReallyReallyLongBus : BrokenCar 
    {
        public override bool Starts { get; set; } = false;
        public override bool MakesNoise { get; set; } = false;

        public override int Price { get; set; } = 13000;
        public override void DriveForward()
        {
            Console.WriteLine("The Really Really Long Bus doesn't drive forward");
        }

        public override void Honk()
        {
            Console.WriteLine("BEEP BEEP");
        }

        public override void Reverse()
        {
            Console.WriteLine("The Really Really Long Bus doesn't go in reverse");
        }

        public override void TurnOff()
        {
            Console.WriteLine("The Really Really Long Bus has been turned off forever");
        }

        public override void TurnOn()
        {
            Console.WriteLine("The Really Really Long Bus doesn't turn on");
        }
    }
}
