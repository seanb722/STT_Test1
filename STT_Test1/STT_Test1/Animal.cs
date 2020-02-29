using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace STT_Test1
{
    public abstract class Animal
    {
        public abstract int Legs();
        public abstract string MakeNoice();
        //public abstract string ToXML();

        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine(dog.MakeNoice());
            Console.WriteLine(dog.Legs());

            Duck duck = new Duck();
            Console.WriteLine(duck.MakeNoice());
            Console.WriteLine(duck.Legs());
            Console.Read();

        }
    }
  
}
