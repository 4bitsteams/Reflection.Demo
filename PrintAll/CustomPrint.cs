using System;
using System.Collections.Generic;
using System.Text;

namespace PrintAll
{
    public class CustomPrint
    {
        private string name;
        public void Print()
        {
            Console.WriteLine("Printing from Print");
            PrintKey();
        }
       
        public void PrintKey()
        {
            Console.ReadKey();
        }

        public string GetName()
        {
            return name;
        }


        public void PrintName()
        {
            Console.WriteLine($"Name Set as {name}");
        }

        public void Print(string name)
        {
            Console.WriteLine($"Name Pass Name:{name}");
        }

        public void PrintPrivate()
        {
            Console.WriteLine("Print From Private");
        }

        public string Name => name;

        public static string StaticName =>"Static Property Name";
    }
}
