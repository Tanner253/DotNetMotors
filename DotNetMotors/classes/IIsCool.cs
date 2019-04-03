using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DotNetMotors.classes
{
    public interface IIsCool
    {
        bool IsCool { get; set; }
        string ImCool();
        
    }
}
