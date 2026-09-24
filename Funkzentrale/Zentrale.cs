using System;
using System.Collections.Generic;
using System.Text;

namespace Funkzentrale
{
    internal class Zentrale
    {
        public static void Senden(string absender, string nachricht, ChiffrierVerfahren verfahren)
        {
            string schluss = verfahren(nachricht);

            Console.WriteLine($"[{absender}] {schluss}");


        }
    }
}
