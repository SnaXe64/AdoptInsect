using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptInsect
{
    internal class Insect
    {
        // Attributes
        public string ScientificName;
        public string Nickname;

        // Methods
        public Insect()
        {
            // contructor
        }

        public void Speak()
        {
            //Do some Speaking
            Console.WriteLine("Hello");
        }

        public string BetterSpeak()
        {
            //Do some Speaking
            return "Hello";
        }
    }
}
