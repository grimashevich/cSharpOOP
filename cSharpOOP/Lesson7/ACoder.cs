using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpOOP.Lesson7
{

    internal class ACoder : IСoder
    {
        protected readonly int startEngCharUpper = (int)'A';
        protected readonly int endEngCharUpper = (int)'Z';
        protected readonly int startEngCharLower = (int)'a';
        protected readonly int endEngCharLower = (int)'z';
        protected readonly int startRusCharUpper = (int)'А';
        protected readonly int endRusCharUpper = (int)'Я';
        protected readonly int startRusCharLower = (int)'а';
        protected readonly int endRusCharLower = (int)'я';

        private readonly int shiftLen = 1;
        public virtual string Decode(string value)
        {
            char[] arr = value.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = ShiftChar(arr[i], -shiftLen);
            return (new string(arr));
        }

        public virtual string Encode(string value)
        {
            char[] arr = value.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = ShiftChar(arr[i], shiftLen);
            return (new string(arr));
        }

        protected char ShiftChar(char c, int length)
        {
            int start, end, base_scale, new_c;

            GetCharBorder(c, out start, out end);
            if (start == -1)
                return c;
            base_scale = end - start + 1;
            new_c = (int)c + length;
            if (new_c > end)
                new_c = (new_c - end) % base_scale + start - 1;
            else if (new_c < start)
                new_c = end - (start - new_c) % base_scale + 1;
            return (char)new_c;
        }

        protected void GetCharBorder(char c, out int start, out int end)
        {
            int c_int = (int)c;

            if (c_int >= startEngCharUpper && c_int <= endEngCharUpper)
            {
                start = startEngCharUpper;
                end = endEngCharUpper;
            }
            else if (c_int >= startEngCharLower && c_int <= endEngCharLower)
            {
                start = startEngCharLower;
                end = endEngCharLower;
            }
            else if (c_int >= startRusCharUpper && c_int <= endRusCharUpper)
            {
                start = startRusCharUpper;
                end = endRusCharUpper;
            }
            else if (c_int >= startRusCharLower && c_int <= endRusCharLower)
            {
                start = startRusCharLower;
                end = endRusCharLower;
            }
            else
            {
                start = -1;
                end = -1;
            }
        }
    }

}
