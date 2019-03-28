using System;
using System.Collections.Generic;
using System.Text;
namespace DotNetMotors.classes
{
    abstract class Boat : DotNetMotors 
    {

        public abstract bool Floats { get; set; }
        public abstract int HasFlag { get; set; }
        public abstract bool Flys { get; set; }
        public bool HasBow { get; set; }
        
        public abstract void Drives();
    }
    

     
}
