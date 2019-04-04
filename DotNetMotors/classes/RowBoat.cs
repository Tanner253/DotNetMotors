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
        /// <summary>
        /// action of driving
        /// </summary>
        /// <returns>string</returns>
        public override string Drives()
        {
           return $"The Boat is going somewhere. and is cool : {IsCool}";
        }
        /// <summary>
        /// action of turning off
        /// </summary>
        /// <returns>string</returns>
        public override string TurnOff()
        {
            return "The boat has turned off." ;
        }
        /// <summary>
        /// action of turninh on 
        /// </summary>
        /// <returns>string</returns>
        public override string TurnOn()
        {
            return "The boat cannot turn on";
        }

       
        /// <summary>
        /// action of being cool
        /// </summary>
        /// <returns></returns>
        public string ImCool()
        {
            return "i am so cool";
        }
        /// <summary>
        /// action of raising flag
        /// </summary>
        /// <returns>string</returns>
        string IHasBow.HasFlag()
        {
            return "The flag is being raised"
        }
    }
}
