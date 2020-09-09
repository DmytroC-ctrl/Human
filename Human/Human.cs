using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
   public class Human
    {
        public int Hunger;
        public int Thirst;
        public int Apples;
        public int ApplesCost=4;
        public int Water;
        public int WaterCost=2;
        public int EatApple;
        public int DrinkWater;
        public int Money;

        public void ShowParameters(string name)
        {
            Console.WriteLine("Parameters "+name);
            Console.WriteLine("Hunger "+ Hunger);
            Console.WriteLine("Thirst "+ Thirst);
            Console.WriteLine("Apples "+ Apples);
            Console.WriteLine("ApplesCost "+ ApplesCost);
            Console.WriteLine("Water "+ Water);
            Console.WriteLine("WaterCost " + WaterCost);
            Console.WriteLine("EatApple "+ EatApple);
            Console.WriteLine("DrinkWater "+ DrinkWater);
            Console.WriteLine("Money " + Money);
        }

        public void Eat(string name)
        {
            if (Hunger == 0)
            {
                Console.WriteLine("I'm not hungry!");
            }
            else if (Hunger - EatApple < 0)
            {
                int tmp = (Hunger - EatApple) * -1;
                Hunger = 0;
                Apples += tmp;
            }
            else if (Hunger + Apples > 10)
            {
                int tmp = (Hunger + Apples) - 10;
                Hunger = 10;
                Apples -= tmp;
            }
            else
            {
                Hunger -= EatApple;
                Apples -= EatApple;
            }
            Console.WriteLine($"\n{name} eate!\n");
        }
        public void Drink(string name)
        {
            if (this.Thirst == 0)
            {
                Console.WriteLine("I'm not thirsty!");
            }
            else if (this.Water < this.DrinkWater)
            {
                Console.WriteLine("I don't have enough water!");
            }
            else
            {
                if (this.Thirst - this.DrinkWater < 0)
                {
                    int tmp = (Thirst - DrinkWater) * -1;
                    this.Thirst = 0;
                    this.DrinkWater -= tmp;
                }
                else if (Thirst + DrinkWater > 10)
                {
                    int tmp = (Thirst + DrinkWater) - 10;
                    this.Thirst = 0;
                    this.Water -= tmp;
                }
                else
                {
                    Thirst -= DrinkWater;
                    Water -= DrinkWater;
                }
                Console.WriteLine($"\n{name} drank water!\n");
            }
           
        }
        public void Buy(string what,int amount)
        {
            if (Money < ApplesCost * amount)
            {
                Console.WriteLine("Sorry, but amount of your money is not enough!");
            }
            else if (what == "apples")
            {
                Apples += amount;
                Money -= ApplesCost * amount;
            }
            else if (what == "water")
            {
                Water += amount;
                Money -= WaterCost * amount;
            }
            else
            {
                Console.WriteLine("Not apple, not water");
            }
        }
        public void Sell(string what, int amount)
        {
            if (what == "apples")
            {
                Apples -= amount;
                Money += ApplesCost * amount;
            }
            else if (what == "water")
            {
                Water -= amount;
                Money += WaterCost * amount;
            }
            else
            {
                Console.WriteLine("Not apple, not water");
            }

        }
        public void Buy(string what, int amount,Human name)
        {
            if (Money < ApplesCost * amount)
            {
                Console.WriteLine("Sorry, but amount of your money is not enough!");
            }
            else if (what == "apples")
            {
                if (name.Apples < amount)
                {
                    Console.WriteLine("Sorry, but amount of apples in your partner is not enough!");
                }
                else
                {
                    Apples += amount;
                    Money -= ApplesCost * amount;
                    name.Apples -= amount;
                    name.Money += ApplesCost * amount;
                }
            }
            else if (what == "water")
            {
                if (name.Water < amount)
                {
                    Console.WriteLine("Sorry, but amount of water in your partner is not enough!");
                }
                else
                {
                    Water += amount;
                    Money -= WaterCost * amount;
                    name.Water -= amount;
                    name.Money += WaterCost * amount;
                }
            }
            else
            {
                Console.WriteLine("Not apple, not water");
            }
        }
        public void Sell(string what, int amount, Human name)
        {
            if (name.Money < ApplesCost * amount)
            {
                Console.WriteLine("Sorry, but amount of money in your buyer is not enough!");
            }
            else if (what == "apples")
            {
                if (name.ApplesCost < amount)
                {
                    Console.WriteLine("Sorry, but amount of apples in your partner is not enough!");
                }
                else
                {
                    Apples -= amount;
                    Money += ApplesCost * amount;
                    name.Apples += amount;
                    name.Money -= ApplesCost * amount;
                }
            }
            else if (what == "water")
            {
                if (name.WaterCost < amount)
                {
                    Console.WriteLine("Sorry, but amount of water in your partner is not enough!");
                }
                else
                {
                    Water -= amount;
                    Money += WaterCost * amount;
                    name.Water += amount;
                    name.Money -= WaterCost * amount;
                }
            }
            else
            {
                Console.WriteLine("Not apple, not water");
            }

        }

    }
}
