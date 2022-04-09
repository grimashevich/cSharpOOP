using cSharpOOP.Lesson5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction fr1 = new Fraction(7,13);
            Fraction fr2 = new Fraction(0.5);
            Console.WriteLine(fr1);
            Console.WriteLine(fr2);
            Console.WriteLine($"{fr1} + {fr2} = {fr1 + fr2}");
            Console.WriteLine($"{fr1} - {fr2} = {fr1 - fr2}");
            Console.WriteLine($"{fr1} * {fr2} = {fr1 * fr2}");
            Console.WriteLine($"{fr1} / {fr2} = {fr1 / fr2}");
            Console.WriteLine($"{fr1} % {fr2} = {fr1 % fr2}");
            Console.WriteLine($"{fr1} > {fr2} = {fr1 > fr2}");
            Console.WriteLine($"{fr1} <= {fr2} = {fr1 <= fr2}");
            Console.WriteLine($"{fr1} == {fr2} = {fr1 == fr2}");
            Console.WriteLine($"{fr1} != {fr2} = {fr1 != fr2}");
            Console.WriteLine($"{fr1}++ = {fr1++}");
            Console.WriteLine($"{fr1}-- = {fr1--}");
            Console.WriteLine($"float({fr1}) = {(float)fr1}");
            Console.WriteLine($"double({fr1}) = {(double)fr1}");
            
        }
    }
}
