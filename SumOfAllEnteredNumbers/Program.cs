using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfAllEnteredNumbers
{
    class Program
    {
        //Write a program and continuously ask the user to enter a number or "ok" to exit. 
        //Calculate the sum of all the previously entered numbers and display it on the console.
        static void Main(string[] args)
        {
                var sum = 0;
                while (true)
                {
                    Console.Write("Enter a number (or 'ok' to exit): ");
                    var input = Console.ReadLine();

                    if (input.ToLower() == "ok")
                        break;

                    sum += int.Parse(input);
                }
            Console.WriteLine("Sum of all number is: " + sum);

        }
    }
}
/*
Enter a number (or 'ok' to exit): 5
Enter a number (or 'ok' to exit): 6
Enter a number (or 'ok' to exit): 3
Enter a number (or 'ok' to exit): 4
Enter a number (or 'ok' to exit): ok
Sum of all number is: 18
Press any key to continue . . .
*/
