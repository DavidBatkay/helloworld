using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    internal class Person
    {
        public string Name="Emanuel";



        public void ReadName()
        {
            Console.Write("Your name is= ");
            Name = Console.ReadLine();
        }


        public void SayHello()

        {
            Console.WriteLine("Hello, my name is " + Name);
        }
    }
}
