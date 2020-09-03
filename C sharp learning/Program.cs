using System;
using System.Collections.Generic; //массив, списки.
using System.ComponentModel;
using System.Globalization;
using System.Net;

namespace C_sharp_learning
{
    
    enum Breed {Dog, Cat, Bird, Bead, Tiger };


   class Animal
    {
        public Breed breed;

      public  Animal(Breed breed)
        {
            this.breed = breed;
        }

        public void Print()
        {
            Console.WriteLine(breed);
        }
    }


    class MainClass
    {   
        public static void Main(string[] args)
        {
            Animal dog = new Animal(Breed.Bird);
            dog.Print();
            Console.ReadLine();
        }

    }
}