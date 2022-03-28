using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpOOP
{
    internal class EmailParser
    {
        public bool ParseFromFile(string inFile, string outFile, ref int count)
        {
            string line;

            if (!File.Exists(inFile))
            {
                Console.WriteLine($"File {inFile} does not exists.");
                return false;
            }

            using (StreamWriter sw = new StreamWriter(outFile))
            {
                using (StreamReader sr = new StreamReader(inFile))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] words = line.Split('&');
                        foreach (string word in words)
                        {
                            string email = String.Copy(word);
                            SearchMail(ref email);
                            if (email != null)
                            {
                                sw.WriteLine(email);
                                count++;
                            }
                        }
                    }
                }
            }
            return true;
        }

        public void SearchMail(ref string s)
        {
            string[] subStrings = s.Split();
            foreach (string subString in subStrings)
            {
                if (IsStringEmailSimple(subString))
                {
                    s = subString;
                    return;
                }
            }
            s = null;
        }

        private bool IsStringEmailSimple(string str)
        {
            if (str.Length < 5)
                return false;
            if (str.IndexOf('@') == -1)
                return false;
            if (str.IndexOf('.') == -1)
                return false;
            if (str.IndexOf('@') > str.LastIndexOf('.'))
                return false;
            return true;
        }
    }
}
