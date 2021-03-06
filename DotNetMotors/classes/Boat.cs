﻿using System;
using System.Collections.Generic;
using System.Text;
namespace DotNetMotors.classes
{
    public abstract class Boat : DotNetMotors 
    {

        public abstract bool Floats { get; set; }
        public abstract int HasFlag { get; set; }
        public bool Flys { get; set; } = false;
        public bool HasBow { get; set; } = true;

        /// <summary>
        /// action of raising flag
        /// </summary>
        /// <returns>string</returns>
        public virtual string RaiseFlag()
        {
            return "The flag is raising";
        }
        
        public abstract string Drives();
    }
    

     
}
