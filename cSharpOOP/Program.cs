using cSharpOOP.Lesson7;
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
            Console.WriteLine("ACoder:\n");
            var coder = new ACoder();
            string s1 = "ABCdefАБВгде";
            string s2 = coder.Encode(s1);
            string s3 = coder.Decode(s2);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            
            Console.WriteLine("\nBCoder:\n");
            coder = new BCoder();
            s1 = "ABCdefАБВгде";
            s2 = coder.Encode(s1);
            s3 = coder.Decode(s2);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
    }
}
