using System;
using System.Collections.Generic;
using System.Text;

namespace Funkzentrale
{
    public class Agent
    {
        private string _codename;
        private ChiffrierVerfahren _verfahren;
        private Sicherheitspruefung _pruefung;


        public Agent(string codename, ChiffrierVerfahren verfahren, Sicherheitspruefung pruefung)
        {

            _codename = codename;
            _verfahren = verfahren;
            _pruefung = pruefung;
        }

        public Agent() { }

        public void Melden(string message)
        {
            if (_pruefung(message)) // executes the message with the methods that are saved in the delegate Pruefung
            {

                string versch = _verfahren(message); // same thing, message is getting saved in the delegate Verfahren
                Console.WriteLine($"[{_codename}]: {message} -- {versch}");

            }
            else
            {
                Console.WriteLine($"[{_codename}]: {message} -- ABBRUCH: nicht freigegeben");
            }

        }




    }
}
