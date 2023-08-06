using System;
using System.IO;
namespace Helloworld
{ 
    //PascalCase [klasy, pliki, namespace, metody]
    class Program
    {
        public static void Main(string[] args)
        {
            //camelCase [lokalne zmienne, nipubliczne elementy programu]
            string imie = "Pablo";

            //UPPER_CASE
            const double PI_NUMBER = 3.14;
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Yo");
            if (PI_NUMBER > 2)
            {
            }
        }
        private string WritePiNumber(double pi)
        { 
            return ("3.14");
        }
    }

}

public interface Iprogram
    { }