using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool shouldQuit = false;
            while (!shouldQuit)
            {
                Console.WriteLine("Welcome to the Calculator!\n" +
                    "1. Addition\n" +
                    "2. Subtraction\n" +
                    "3. Multiplication\n" +
                    "4. Division\n" +
                    "\n" +
                    "5. Roots\n" +
                    "6. Exponentiation\n" +
                    "7. Logs\n" +
                    "8. Pythagoras\n" +
                    "\n" +
                    "9. Sine\n" +
                    "10. Cosine\n" +
                    "11. Tangent\n" +
                    "12. Arcsine\n" +
                    "13. Arccosine\n" +
                    "14. Arctangent\n" +
                    "\n" +
                    "15. Denary to Binary\n" +
                    "16. Binary to Denary\n" +
                    "17. Binary to Hex\n" +
                    "18. Hex to Binary\n" +
                    "19. Denary to Hex\n" +
                    "20. Hex to Denary\n" +
                    "\n" +
                    "21. Quit");


                int choice;
                bool validChoice = false;
                do
                {
                    Console.Write("Enter your choice: ");
                    if (Int32.TryParse(Console.ReadLine(), out choice))
                    {
                        if (1 <= choice && choice <= 21)
                        {
                            validChoice = true;
                        }
                    }
                }
                while (!validChoice);


                switch (choice)
                {
                    case 1:
                        {
                            // addition
                            float num1 = UserInputFloat("Enter first addend: ");
                            float num2 = UserInputFloat("Enter second addend: ");
                            Console.WriteLine("Sum: " + (num1 + num2));
                            break;
                        }
                    case 2:
                        {
                            // subtraction
                            float num1 = UserInputFloat("Enter minuend: ");
                            float num2 = UserInputFloat("Enter subtrahend: ");
                            Console.WriteLine("Difference: " + (num1 - num2));
                            break;
                        }
                    case 3:
                        {
                            // multiplication
                            float num1 = UserInputFloat("Enter multiplicand: ");
                            float num2 = UserInputFloat("Enter multiplier: ");
                            Console.WriteLine("Product: " + (num1 * num2));
                            break;
                        }
                    case 4:
                        {
                            // division
                            float num1 = UserInputFloat("Enter dividend: ");
                            float num2 = UserInputFloat("Enter divisor: ");
                            Console.WriteLine("Quotient: " + (num1 / num2));
                            break;
                        }
                    case 5:
                        {
                            // roots
                            float num1 = UserInputFloat("Enter radicand: ");
                            float num2 = UserInputFloat("Enter index: ");
                            Console.WriteLine("Root: " + Math.Pow(num1, 1 / num2));
                            break;
                        }
                    case 6:
                        {
                            // exponentiation
                            float num1 = UserInputFloat("Enter base: ");
                            float num2 = UserInputFloat("Enter exponent: ");
                            Console.WriteLine("Power: " + Math.Pow(num1, num2));
                            break;
                        }
                    case 7:
                        {
                            // logarithm
                            float num1 = UserInputFloat("Enter value: ");
                            float num2 = UserInputFloat("Enter base: ");
                            Console.WriteLine("Exponent: " + Math.Log(num1, num2));
                            break;
                        }
                    case 8:
                        {
                            // pythagoras
                            float num1 = UserInputFloat("Enter first length: ");
                            float num2 = UserInputFloat("Enter second length: ");
                            Console.WriteLine("Hypotenuse: " + Math.Sqrt(num1 * num1 + num2 * num2));
                            break;
                        }
                    case 9:
                        {
                            // sin
                            float num = UserInputFloat("Enter value:");
                            Console.WriteLine("Result: " + Math.Sin(num));
                            break;
                        }
                    case 10:
                        {
                            // cos
                            float num = UserInputFloat("Enter value:");
                            Console.WriteLine("Result: " + Math.Cos(num));
                            break;
                        }
                    case 11:
                        {
                            // tan
                            float num = UserInputFloat("Enter value:");
                            Console.WriteLine("Result: " + Math.Tan(num));
                            break;
                        }
                    case 12:
                        {
                            // arcsin
                            float num = UserInputFloat("Enter value:");
                            Console.WriteLine("Result: " + Math.Asin(num));
                            break;
                        }
                    case 13:
                        {
                            // arccos
                            float num = UserInputFloat("Enter value:");
                            Console.WriteLine("Result: " + Math.Acos(num));
                            break;
                        }
                    case 14:
                        {
                            // arctan
                            float num = UserInputFloat("Enter value:");
                            Console.WriteLine("Result: " + Math.Atan(num));
                            break;
                        }
                    case 15:
                        {
                            // den -> bin
                            int denary = UserInputInt("Enter denary value: ");
                            Console.WriteLine("Binary: " + Convert.ToString(denary, 2));
                            break;
                        }
                    case 16:
                    // bin -> den
                    case 17:
                    // bin -> hex
                    case 18:
                    // hex -> bin
                    case 19:
                    // den -> hex
                    case 20:
                    // hex -> den
                    case 21:
                        // quit
                        shouldQuit = true;
                        Console.WriteLine("Goodbye!");
                        break;
                }
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }
        }

        static float UserInputFloat(string prompt)
        {
            float output;
            do
            {
                Console.Write(prompt);
            }
            while (!Single.TryParse(Console.ReadLine(), out output));
            return output;
        }

        static int UserInputInt(string prompt)
        {
            int output;
            do
            {
                Console.Write(prompt);
            }
            while (!Int32.TryParse(Console.ReadLine(), out output));
            return output;
        }
    }
}
