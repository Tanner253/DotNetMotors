using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.classes
{
    public class SpeedBoat : Boat , IHasBow
    {
        public override bool Floats { get; set; }
        public override int HasFlag { get; set; }
        
        public override bool Starts { get; set; }
        public override bool MakesNoise { get; set ; }
        public override int Price { get; set; } = 32000;

        public override bool IsReal { get; set; } = true;
        public bool IHasBow(IHasBow hasBow)
        {
            return true;
        }

        public override void Drives()
        {
            Console.WriteLine("The Boat is Driving!");
        }

        public override void TurnOff()
        {
            Console.WriteLine("The boat has turned off.");
        }

        public override void TurnOn()
        {
            Console.WriteLine("The boat has turned on.");
        }
    }
}
