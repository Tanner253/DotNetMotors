using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMotors.classes
{
    public interface IHasBow
    {
        bool HasBow { get; set; }
        bool HasFlag();
    }
}
