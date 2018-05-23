using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class SystemFunctionality
    {
        public void showTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }

        public void showDate()
        {
            Console.WriteLine(DateTime.Now.Date.ToShortDateString());
        }

        public void ShowVersion()
        {
            Console.WriteLine(" Version : 18.2.4.0");
        }

        public void CapitalLettersProcess()
        {
            string message = "there are {0} capital letters in your sentence.";
            int countCapitalLetters = 0;
            Console.WriteLine("please enter a sentence and then press enter");
            string str = Console.ReadLine();
            char[] charArrForString = str.ToCharArray();

            foreach (char c in charArrForString)
            {
                if (char.IsUpper(c))
                {
                    countCapitalLetters++;
                }
            }

            Console.WriteLine(string.Format(message, countCapitalLetters));
        }
    }
}
