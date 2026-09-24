using System;
using System.Collections.Generic;
using System.Text;

namespace Funkzentrale
{
    public class Agent
    {
        private string _codename;

        public Agent(string codename, ChiffrierVerfahren chiff, ) => _codename = codename;

        public Agent() { }

        public void Melden(string message)
        {
            Console.WriteLine(message);
        }




    }
}
