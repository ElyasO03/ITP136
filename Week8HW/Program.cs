using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Week8HW
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("How many parts do you want to enter?");
            int numParts = Convert.ToInt32(ReadLine());

            Parts[] partsArray = new Parts[numParts];

            for (int i = 0; i < partsArray.Length; i++)
            {
                partsArray[i] = PopulateParts();
            }

            WriteLine("Parts List:");
            for (int i = 0; i < partsArray.Length; i++)
            {
                WriteLine($"{i + 1}. {partsArray[i].PartNum}, {partsArray[i].PartName}, {partsArray[i].PartDescription}, {partsArray[i].Cost}");
            }

            WriteLine("Which part do you want to view?");
            int selectedPartIndex = Convert.ToInt32(ReadLine()) - 1;

            if (selectedPartIndex >= 0 && selectedPartIndex < partsArray.Length)
            {
                DisplayPartDetails(partsArray[selectedPartIndex]);
            }
            else
            {
                WriteLine("Invalid selection.");
            }
        }

        static Parts PopulateParts()
        {
            WriteLine("Please enter Part Number:");
            int partNum = Convert.ToInt32(ReadLine());

            WriteLine("Please enter Part Name:");
            string partName = ReadLine();

            WriteLine("Please enter Part Description:");
            string partDesc = ReadLine();

            WriteLine("Please enter Cost:");
            double cost = Convert.ToDouble(ReadLine());

            return new Parts(partNum, partName, partDesc, cost);
        }

        static void DisplayPartDetails(Parts part)
        {
            WriteLine($"Part Number: {part.PartNum}");
            WriteLine($"Part Name: {part.PartName}");
            WriteLine($"Part Description: {part.PartDescription}");
            WriteLine($"Cost: {part.Cost}");

            ReadKey();
        }
    }
}
