using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpOOP.Lesson7
{
    internal interface IСoder
    {
        string Encode(string value);
        string Decode(string value);
    }
}
