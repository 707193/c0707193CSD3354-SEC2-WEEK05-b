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
            linkedlist a = new linkedlist();
            a.run();
            a.walkoverthelist();

       
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
        public dog current;
        public dog head;
        public dog peanut = new dog();
        public dog fifi = new dog();
        public dog jordan = new dog();
        public dog fido = new dog();

        public void run()
        {
            head = peanut;

            peanut.dogname = "peanut";
            peanut.dogbreed = "bichon";
            peanut.nextdog = fifi;
            peanut.previousdog = null;

            fifi.dogname = "fifi";
            fifi.dogbreed = "poodle";
            fifi.nextdog = jordan;
            fifi.previousdog = peanut;

            jordan.dogname = "jordan";
            jordan.dogbreed = "german shepard";
            jordan.nextdog = fido;
            jordan.previousdog = fifi;

            fido.dogname = "fido";
            fido.dogbreed = "beagel";
            fido.nextdog = null;
            fido.previousdog = jordan;
        }


        public void walkoverthelist()
        {
            current = head;
            while (current != null)
            {

                Console.WriteLine(current.dogname);
                current = current.nextdog; 


            }
        }



    }

