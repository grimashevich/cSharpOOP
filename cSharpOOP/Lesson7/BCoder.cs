using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpOOP.Lesson7
{
    internal class BCoder: ACoder
    {
        public override string Encode(string value)
        {
            char[] arr = value.ToCharArray();
            int shiftLen, start, end;
            for (int i = 0; i < arr.Length; i++)
            {
                GetCharBorder(arr[i], out start, out end);
                shiftLen = (end - (arr[i] - start)) - arr[i];
                arr[i] = ShiftChar(arr[i], shiftLen);
            }
            return (new string(arr));
        }

        public override string Decode(string value)
        {
            char[] arr = value.ToCharArray();
            int shiftLen, start, end;
            for (int i = 0; i < arr.Length; i++)
            {
                GetCharBorder(arr[i], out start, out end);
                shiftLen = (start + (end - arr[i])) - arr[i];
                arr[i] = ShiftChar(arr[i], shiftLen);
            }
            return (new string(arr));
        }
    }
}
