using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCsharpBasics
{
    public class ParameterizedConstructor
    {
        int x;
        public ParameterizedConstructor(int i)
        {
            //Initializing the variable
            x = i;
            Console.WriteLine($"Parameterized Constructor is Called : {i}");
        }

        public ParameterizedConstructor(ParameterizedConstructor obj)
        {
            x= obj.x;
            Console.WriteLine($"Parameterized Constructor is Called : {x}");
        }
        static ParameterizedConstructor()
        {
            Console.WriteLine("Static Constructor Executed!");
        }

        private ParameterizedConstructor()
        {
            Console.WriteLine("This is private constructor");
        }

        public void Display()
        {
            Console.WriteLine($"Value of X = {x}");
        }
    }
}
