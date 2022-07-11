using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Wolfhope_Unit1
{
    internal class IT213_Wolfhope_Unit1
    {
        // IT213 Unit 1 Assignment - Software Basics
        // Written by Chuck Wolfhope
        static void Main(string[] args)
        {
            // Create the variables and store the values
            // String Variables
            String name = "John Smith";
            String address = "101 N. Main Street";
            String city = "AnyTown";
            String state = "TX";
            String zip = "11111";
            String unitsTaken = "19";

            // Numeric Variables
            const double pricePerUnit = 100.50;
            const int twentyUnitHourDisc = 150;
            int intUnitsTaken = int.Parse(unitsTaken);              // Convert the string unitsTaken into the int variable intUnitsTaken

            // Perform calculations on the number variables
            intUnitsTaken++;                                        // Add 1 to intUnitsTaken using post increment operator
            double tuition = pricePerUnit * intUnitsTaken;          // calculates the tuition - multiply units taken by the price per unit
            double afterDiscount = tuition - twentyUnitHourDisc;    // calculates the tuition after the discount - subtract the unit discount from the tuition
            double monthlyPayment = afterDiscount / 12;             // calculates the monthly payment - divide the discounted tuition by 12

            // Display the output
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"City: {city}");
            Console.WriteLine($"State: {state}");
            Console.WriteLine($"Zip Code: {zip}");
            Console.WriteLine($"The number of units taken is: {intUnitsTaken}");
            Console.WriteLine($"The tuition before discount is {tuition:C2}");                  // Output is formated to show currency
            Console.WriteLine($"The tuition after twenty-unit discount is {afterDiscount:C2}"); // Output is formated to show currency
            Console.WriteLine($"Your monthly payment is {monthlyPayment:C2}");                  // Output is formated to show currency
            Console.WriteLine("");
            Console.WriteLine("Press ENTER to Continue");
            Console.ReadLine();
        }
    }
}