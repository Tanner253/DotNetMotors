using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.classes
{
    public abstract class Cars :  DotNetMotors , IIsCool
    {
        bool IIsCool.IsCool { get; set; }

        public abstract string DriveForward();
        public abstract string Reverse();
       
        string IIsCool.ImCool() => "I am cool";

    }
}
