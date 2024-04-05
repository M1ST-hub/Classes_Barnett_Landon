using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Barnett_Landon
{
    //created class
    internal class Greetings
    {
        //void method prints greetings
        public void Welcome()
        {
            Console.WriteLine("Howdy pardner!");
        }
        //void method prints farewell
        public void Hello(string name)
        {
            Console.WriteLine($"{name}, Thanks for dropping by");
        }

    }
}
