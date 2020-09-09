using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Vasya vasya = new Vasya();
            vasya.ShowParameters("Vasya");
            Console.WriteLine();
            vasya.Eat("Vasya");
            Console.WriteLine("Vasya pokyshal");
            Console.WriteLine();
            vasya.ShowParameters("Vasya");
            //
            Console.WriteLine();
            vasya.Buy("apples", 3);
            Console.WriteLine("Vasya kypil 3 apple");
            Console.WriteLine();
            vasya.ShowParameters("Vasya");
            Console.WriteLine();
            Console.WriteLine();



            Petro petro = new Petro();
            petro.ShowParameters("Petro");
            Console.WriteLine();
            petro.Buy("apples", 5, vasya);
            petro.ShowParameters("Petro");
            vasya.ShowParameters("Vasya");

            Alex alex = new Alex();
            alex.ShowParameters("Alex");
            Maria maria = new Maria();
            Console.WriteLine();
            Console.WriteLine();
            maria.ShowParameters("Maria");
            Console.WriteLine();
            Console.WriteLine();
            alex.ShowParameters("Alex");
            alex.Eat("Alex");
            Console.WriteLine();
            Console.WriteLine();
            alex.ShowParameters("Alex");
            Console.WriteLine();
            alex.Drink("Alex");
            vasya.Eat("Vasya");
            vasya.ShowParameters("Vasya");
            vasya.Eat("Vasya");
            vasya.ShowParameters("Vasya");
            petro.Buy("water", 200, vasya);



        }
    }
}
