using System;
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
        
        
        public abstract string Drives();
    }
    

     
}
