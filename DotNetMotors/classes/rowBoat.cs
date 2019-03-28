using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.classes
{
    public class RowBoat : Boat , IHasBow, IIsCool
    {
        public override bool Starts { get; set; }
        public override bool MakesNoise { get; set; }
        public override bool Floats { get ; set ; }
        public override int HasFlag { get; set; }
        public override int Price { get; set; } = 300;
        public bool IsCool { get; set; } = true;

        public override bool IsReal { get; set; } = false;

        public bool IHasBow(IHasBow hasBow)
        {
            return true;
        }
        public bool IIsCool(IIsCool isCool)
        {
            return true;
        }

        public override void Drives()
        {
            Console.WriteLine("The Boat is going somewhere.");
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
