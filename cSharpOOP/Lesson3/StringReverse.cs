using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpOOP
{
    internal class StringReverse
    {
        public static string StrReverse(string str)
        {
            int strLen = str.Length;
            char[] result = new char[strLen];
            for (int i = 0; i < strLen; i++)
                result[i] = str[strLen - i - 1];
            return new string(result);
        }
    }
}
