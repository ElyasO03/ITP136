using System;
using static System.Console;

class FlightReservation
{
    string name;
    string address;
    string dateOfTravel;

    public void CollectUserInformation()
    {
        Write("Enter your name: ");
        name = ReadLine();

        Write("Enter your address: ");
        address = ReadLine();

        Write("Enter the date of travel: ");
        dateOfTravel = ReadLine();
    }

    public int CollectBagData()
    {
        Write("Enter the number of bags to check: ");
        int numberOfBags = GetValidInput();

        int bagTotal = 0;

        if (numberOfBags > 0)
        {
            Write("Do you want to check bags? (yes/no): ");
            string answer = ReadLine().ToLower();

            if (answer == "yes")
            {
                bagTotal = numberOfBags * 25;
            }
        }

        return bagTotal;
    }

    public int CollectSeats()
    {
        Write("Enter the number of seats to reserve: ");
        int numberOfSeats = GetValidInput();

        int seatTotal = numberOfSeats * 30;

        return seatTotal;
    }

    int GetValidInput()
    {
        int input = 0;
        bool isValidInput = false;

        while (!isValidInput)
        {
            try
            {
                input = int.Parse(ReadLine());
                isValidInput = true;
            }
            catch (FormatException)
            {
                WriteLine("Invalid input. Please enter a valid number.");
                Write("Try again: ");
            }
        }

        return input;
    }

    public void CreateReceipt(int subtotal, double taxRate)
    {
        double tax = subtotal * taxRate;
        double grandTotal = subtotal + tax;

        WriteLine("********** Receipt **********");
        WriteLine($"Name: {name}");
        WriteLine($"Address: {address}");
        WriteLine($"Date of Travel: {dateOfTravel}");
        WriteLine($"Baggage Total: ${subtotal}");
        WriteLine($"Seat Total: ${subtotal}");
        WriteLine($"Subtotal: ${subtotal}");
        WriteLine($"Tax (5%): ${tax}");
        WriteLine($"Grand Total: ${grandTotal}");
    }

    public void MakeReservation()
    {
        CollectUserInformation();
        int bagTotal = CollectBagData();
        int seatTotal = CollectSeats();

        int subtotal = bagTotal + seatTotal;
        double taxRate = 0.05;

        CreateReceipt(subtotal, taxRate);
    }

    static void Main()
    {
        FlightReservation reservation = new FlightReservation();
        reservation.MakeReservation();
        ReadKey();
    }
}
