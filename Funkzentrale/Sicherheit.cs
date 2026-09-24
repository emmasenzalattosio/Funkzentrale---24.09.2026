using System;
using System.Collections.Generic;
using System.Text;

namespace Funkzentrale
{
    public class Sicherheit
    {
        public static bool NichtZuLang(int zeichnen)
        {

            if (zeichnen <= 20)
            {
                Console.WriteLine("Your message has max 20 characters!!");
                return true;
            }

            else
            {
                Console.WriteLine("Your message has more than 20 characters");
                return false;
            }

        }
        public static bool KeinKlarname(string text)
        {
            if (text != "Moskau")
            {
                Console.WriteLine("The text doesn´t have the word Moskau");#
                return true;
            }

            else
            {
                Console.WriteLine("Oppala!! The text has Moskau in it");
                return false;
            }


        }

    }
}
