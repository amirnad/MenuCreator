using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    class VersionShower
    {
        public void showVersion()
        {
            Console.WriteLine(" Version : 18.2.4.0");
        }
    }
    class Capitals
    {
        public void capitalLettersProcess()
        {
            string message = "there are {0} capital letters in your sentence.";
            int count = 0;
            Console.WriteLine("please enter a sentence and then press enter");
            string str = Console.ReadLine();
            char[] charArrForString = str.ToCharArray();

            foreach (char c in charArrForString)
            {
                if (char.IsUpper(c))
                {
                    count++;
                }
            }

            Console.WriteLine(string.Format(message, count));
        }

        public static implicit operator Capitals(DateShower v)
        {
            throw new NotImplementedException();
        }
    }
}
