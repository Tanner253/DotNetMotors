using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.classes
{
    public abstract class Cars :  DotNetMotors
    {
        public abstract void DriveForward();
        public abstract void Reverse();
        public abstract void Honk();
    }
}
