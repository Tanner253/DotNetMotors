using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.classes
{
    public class RowBoat : Boat , IHasBow, IIsCool
    {
        public override bool Starts { get; set; } = false;
        public override bool MakesNoise { get; set; } = false;
        public override bool Floats { get; set; } = true;
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

        public override string Drives()
        {
           return $"The Boat is going somewhere. and is cool : {IsCool}";
        }

        public override string TurnOff()
        {
            return "The boat has turned off." ;
        }
        public override string TurnOn()
        {
            return "The boat cannot turn on";
        }



    }
}
