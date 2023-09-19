using System;
using static System.Console;

namespace Week4HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Food food1 = new Food();
            Food food2 = new Food();

            food1.FoodID = 1;
            food1.fname = "Pizza";
            food1.fdescription = "Pizza is a flat, open-faced baked pie that originated in Italy.";
            food1.fcost = 11.00;

            food2.FoodID = 2;
            food2.fname = "Tacos";
            food2.fdescription = "a Mexican food that consists of a folded and usually fried piece of thin bread that is filled with meat, cheese, lettuce, etc.";
            food2.fcost = 5.00;

            WriteLine("{0,5} {1,5} {2,10}", food1.FoodID, food1.fname, food1.fdescription, food1.fcost);
            WriteLine("{0,5} {1,5} {2,10}", food2.FoodID, food2.fname, food2.fdescription, food2.fcost);

            ReadKey();
        }
    }
}
