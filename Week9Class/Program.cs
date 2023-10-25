using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.IO;

namespace Week9Class
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome To My Ice Cream Shop");
            WriteLine("We are going to give you a menu of toppings and flavors");
            WriteLine("You will be able to pick 1 of each");

            char moreItems = 'y';
            int counter = 0;
            List<Orders> orders = new List<Orders>();

            while(moreItems == 'y')
            {
                WriteLine("Lets get some items for {0}", counter + 1);

                collectOrder(ref orders);
                counter++;
                WriteLine("Would you like to continue");
                moreItems = Convert.ToChar(ReadLine());
            }

            WriteLine("{0,20}{1,20}{2,20}", "name", "Flavor", "Toppings");

            foreach(Orders o in orders)
            {
                WriteLine("{0,20}{1,20}{2,20}", o.OrderName, o.OrderFlavor, o.OrderTopping);
            }

            ReadKey();

        }

        public static void collectOrder(ref List<Orders> o)
        {
            var listOfFlavors = File.ReadLines("Flavors.csv").Select(line => new Flavors(line)).ToList();
            var ListOfToppings = File.ReadLines("Toppings.csv").Select(line => new Toppings(line)).ToList();

            Write("Please name You Order Item ");
            string name = ReadLine();

            WriteLine("Which Flavor would you like? ");

            foreach (Flavors f in listOfFlavors)
            {
                WriteLine(f.FlavorID + " " + f.FlavorName);
            }

            int a = Convert.ToInt32(ReadLine());

            string flavor = listOfFlavors[a - 1].FlavorName;

            WriteLine(flavor);

            foreach(Toppings t in ListOfToppings)
            {
                WriteLine(t.ToppingID + " " + t.ToppingName);
            }

            WriteLine("Which Topping would you like? ");
            int b = Convert.ToInt32(ReadLine());

            string topping = ListOfToppings[b - 1].ToppingName;

            WriteLine(topping);

            o.Add(new Orders(name, flavor, topping));

        }

    }
}
