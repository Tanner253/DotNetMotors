using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.classes
{
    public abstract class DotNetMotors
    {
        abstract public bool Starts { get; set; }
        public abstract bool MakesNoise { get; set; }
        public virtual bool IsReal { get; set; }
        public virtual int Price { get; set; }

        public abstract void TurnOn();
        public abstract void TurnOff();

    }
}
