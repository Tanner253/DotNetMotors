using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.classes
{
    public abstract class Cars :  DotNetMotors
    {
        public abstract string DriveForward();
        public abstract string Reverse();
        public abstract string Honk();
    }
}
