using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

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
                    "21. Freeform Expression\n" +
                    "\n" +
                    "22. Quit");


                int choice;
                bool validChoice = false;
                do
                {
                    Console.Write("Enter your choice: ");
                    if (Int32.TryParse(Console.ReadLine(), out choice))
                    {
                        if (1 <= choice && choice <= 22)
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
                        {
                            // bin -> den
                            string binary = UserInputBin("Enter binary value: 0b");
                            Console.WriteLine("Denary: " + Convert.ToInt32(binary, 2));
                            break;
                        }
                    case 17:
                        {
                            // bin -> hex
                            string binary = UserInputBin("Enter binary value: 0b");
                            Console.WriteLine("Hexadecimal: 0x" + Convert.ToInt32(binary, 2).ToString("X"));
                            break;
                        }
                    case 18:
                        {
                            // hex -> bin
                            string binary = UserInputHex("Enter hexadecimal value: 0x");
                            Console.WriteLine("Binary: 0b" + Convert.ToString(Convert.ToInt32(binary, 16),2));
                            break;
                        }
                    case 19:
                        {
                            // den -> hex
                            int denary = UserInputInt("Enter denary value: ");
                            Console.WriteLine("Hexadecimal: 0x" + denary.ToString("X"));
                            break;
                        }
                    case 20:
                        {
                            // hex -> dec
                            string binary = UserInputHex("Enter hexadecimal value: 0x");
                            Console.WriteLine("Denary: " + Convert.ToInt32(binary, 16));
                            break;
                        }
                    case 21:
                        {
                            // freeform expression

                            FreeformCalculator calc = new FreeformCalculator();

                            while (!calc.isValidExpression)
                            {
                                Console.Write("Enter expression: ");
                                string expression = Console.ReadLine();
                                calc.Input = expression;
                            }

                            break;
                        }
                    case 22:
                        {
                            // quit
                            shouldQuit = true;
                            Console.WriteLine("Goodbye!");
                            break;
                        }
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

        static string UserInputBin(string prompt)
        {
            string output;
            bool validBinary;
            do
            {
                validBinary = true;
                Console.Write(prompt);

                output = Console.ReadLine();
                foreach (char character in output)
                {
                    if (character != '1' && character != '0')
                    {
                        validBinary = false;
                    }
                }
            }
            while (!validBinary);

            return output;
        }

        static string UserInputHex(string prompt)
        {
            string output;
            bool validHex;
            do
            {
                validHex = true;
                Console.Write(prompt);

                output = Console.ReadLine();
                foreach (char character in output)
                {
                    if (!('0' <= character && character <= '9' || 'A' <= character && character <= 'F' || 'a' <= character && character <= 'f'))
                    {
                        validHex = false;
                    }
                }

            }
            while (!validHex);

            return output;
        }
    }

    public class FreeformCalculator
    {
        private string input;
        public string Input
        {
            get { return input; }
            set
            {
                input = value;
                Tokenise();
                ShuntingYard();
            }
        }
        private Token[] tokenisedInput;
        private Stack<Token> expression;
        private HashSet<char> operators;
        public bool isValidExpression;

        public FreeformCalculator()
        {
            input = "";
            expression = new Stack<Token>();
            tokenisedInput = new Token[0];
            isValidExpression = false;
            operators = new HashSet<char> {'+', '-', '*', '/', '^', '(', ')'};
        }

        private void Tokenise()
        {
            List<Token> tokenList = new List<Token>();

            int tokenStart = 0;
            int tokenEnd = 0;
            bool hasDecimal = false;

            for (int index = 0; index < input.Length; index++)
            {
                if (operators.Contains(input[index]))
                {
                    // if the character is an operator
                    tokenEnd = index;

                    // tokenise
                    switch (input[index])
                    {
                        case '+':
                            tokenList.Add(new AdditionToken()); break;
                        case '-':
                            tokenList.Add(new SubtractionToken()); break;
                        case '*':
                            tokenList.Add(new MultiplicationToken()); break;
                        case '/':
                            tokenList.Add(new DivisionToken()); break;
                        case '^':
                            tokenList.Add(new ExponentiationToken()); break;
                        case '(':
                            tokenList.Add(new OpenBracketToken()); break;
                        case ')':
                            tokenList.Add(new CloseBracketToken()); break;
                        default:
                            isValidExpression = false;
                            Console.WriteLine("ERROR | No token for operator: \"" + input[index] + "\"");
                            return;
                    }

                    // start the next token
                    tokenStart = index + 1;
                }
                else if (input[index] == '.')
                {
                    // if the character is a decimal point
                    if (hasDecimal)
                    {
                        // ERROR
                        isValidExpression = false;
                        return;
                    }
                    else
                    {
                        hasDecimal = true;
                    }
                }
                if (Char.IsDigit(input[index]) || input[index] == '.')
                {
                    // if the character is a decimal point or a digit
                    if (index == input.Length - 1 || !(Char.IsDigit(input[index + 1]) || (input[index + 1] == '.')))
                    {
                        // end of the number
                        // numbers cant end with a decimal point
                        if (input[index] == '.')
                        {
                            isValidExpression = false;
                            return;
                        }
                        tokenEnd = index;

                        // tokenise
                        string inputSubstring = input.Substring(tokenStart, tokenEnd - tokenStart + 1);
                        if (!Single.TryParse(inputSubstring, out float inputFloat))
                        {
                            Console.WriteLine("ERROR | Could not parse \"" + inputSubstring + "\" as a float.");
                            isValidExpression = false;
                            return;
                        }
                        tokenList.Add(new FloatToken(inputFloat));

                        // start the next token
                        tokenStart = index + 1; 
                        hasDecimal = false;
                    }
                }
            }

            // tokenised now
            // convert to an array
            tokenisedInput = new Token[tokenList.Count];
            for (int index = 0; index < tokenList.Count; index++)
            {
                tokenisedInput[index] = tokenList[index];
            }
        }

        private void ShuntingYard()
        {

        }
    }

    public class Token
    {

    }

    public class FloatToken : Token
    {
        public float value;

        public FloatToken(float newValue)
        {
            value = newValue;
        }
    }

    public class OperatorToken : Token
    {
        public float Operate(float value1, float value2)
        {
            return 0f;
        }
    }

    public class AdditionToken : OperatorToken
    {
        new public float Operate(float value1, float value2)
        {
            return value1 + value2;
        }
    }

    public class SubtractionToken : OperatorToken
    {
        new public float Operate(float value1, float value2)
        {
            return value1 - value2;
        }
    }

    public class MultiplicationToken : OperatorToken
    {
        new public float Operate(float value1, float value2)
        {
            return value1 * value2;
        }
    }

    public class DivisionToken : OperatorToken
    {
        new public float Operate(float value1, float value2)
        {
            return value1 / value2;
        }
    }

    public class ExponentiationToken : OperatorToken
    {
        new public float Operate(float value1, float value2)
        {
            return (float)Math.Pow(value1,value2);
        }
    }

    public class OpenBracketToken : OperatorToken
    {

    }

    public class CloseBracketToken : OperatorToken
    {

    }
}
