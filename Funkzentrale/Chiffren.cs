using System;
using System.Collections.Generic;
using System.Text;

namespace Funkzentrale
{
    public delegate string ChiffrierVerfahren(string klartext);
    public delegate bool Sicherheitspruefung(string text);

    public class Chiffren
    {
        public static string Ruckwaerts(string text)
        {
            char[] signs = text.ToCharArray();
            Array.Reverse(signs);
            return new string(signs);
        }



        public static string VokaleZuSterne(string text)
        {
            char[] vocals = { 'a', 'e', 'i', 'o', 'u' };

            foreach (char vocal in vocals)
            {
                text = text.Replace(vocal, '*');
            }
            return text;

        }


        public static string Leet(string text)
        {
            
            return text

            .Replace('a', '4')
            .Replace('e', '3')
            .Replace('i', '1')
            .Replace('o', '0');

        }


 

    }
}
