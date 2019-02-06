using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            // LINEDLISTS AND NOTES
            Console.WriteLine("Hello World");
        }
    }

    class dog
    {
        public static int Numberofdogs = 0;
        public dog()
        {
            //constructor is method 
            // that creates objects from a type
        }
        public String dogname;
        public  String dogbreed;
        dog nextdog;
    }


    class linkedlist
        {
        public  dog peanut = new dog();
        public dog fifi = new dog();
        public dog jordan = new dog();
        public dog fido = new dog();

        public void run()
        {
            peanut.dogname = "peanut";
            peanut.dogbreed = "bichon";

            fifi.dogname = "peanut";
            fifi.dogbreed = "bichon";

           jordan.dogname = "peanut";
            jordan.dogbreed = "bichon";

            fido.dogname = "peanut";
           fido.dogbreed = "bichon";
        }
    }
}


