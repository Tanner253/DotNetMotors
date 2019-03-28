using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.classes
{
    class ReallyReallyLongBus : BrokenCar 
    {
        public override bool Starts { get; set; }
        public override bool MakesNoise { get; set; }

        public override void DriveForward()
        {
            Console.WriteLine("The Really Really Long Bus drives forward");
        }

        public override void Honk()
        {
            Console.WriteLine("BEEP BEEP");
        }

        public override void Reverse()
        {
            Console.WriteLine("The Really Really Long Bus drives forward");
        }

        public override void TurnOff()
        {
            Console.WriteLine("The Really Really Long Bus has turned off");
        }

        public override void TurnOn()
        {
            Console.WriteLine("The Really Really Long Bus has turned on");
        }
    }
}
