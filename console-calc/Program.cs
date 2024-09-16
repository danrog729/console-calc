using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
                            string hex = UserInputHex("Enter hexadecimal value: 0x");
                            Console.WriteLine("Binary: 0b" + Convert.ToString(Convert.ToInt32(hex, 16),2));
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
                            // hex -> den
                            string hex = UserInputHex("Enter hexadecimal value: 0x");
                            Console.WriteLine("Denary: " + Convert.ToInt32(hex, 16));
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
                            Console.WriteLine("Result: " + calc.Evaluate());

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
        private string _input;
        public string Input
        {
            get { return _input; }
            set
            {
                _input = value;
                Tokenise();
                CorrectTokens();
                ShuntingYard();
            }
        }
        private List<Token> tokenList;
        private Queue<Token> expression;
        private HashSet<char> operators;
        public bool isValidExpression;

        public FreeformCalculator()
        {
            _input = "";
            expression = new Queue<Token>();
            tokenList = new List<Token>();
            isValidExpression = false;
            operators = new HashSet<char> {'+', '-', '*', '/', '^', '(', ')'};
        }

        private void Tokenise()
        {
            tokenList = new List<Token>();

            _input = _input.Replace(" ", "");
            _input = _input.Replace(",", "");

            int tokenStart = 0;
            int tokenEnd = 0;
            bool hasDecimal = false;

            for (int index = 0; index < _input.Length; index++)
            {
                if (operators.Contains(_input[index]))
                {
                    // if the character is an operator
                    tokenEnd = index;

                    // tokenise
                    switch (_input[index])
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
                            Console.WriteLine("ERROR | No token for operator: \"" + _input[index] + "\"");
                            return;
                    }

                    // start the next token
                    tokenStart = index + 1;
                }
                else if (_input[index] == '.')
                {
                    // if the character is a decimal point
                    if (hasDecimal)
                    {
                        // ERROR
                        isValidExpression = false;
                        Console.WriteLine("ERROR | A number cannot have two decimal points!");
                        return;
                    }
                    else
                    {
                        hasDecimal = true;
                    }
                }
                if (Char.IsDigit(_input[index]) || _input[index] == '.')
                {
                    // if the character is a decimal point or a digit
                    if (index == _input.Length - 1 || !(Char.IsDigit(_input[index + 1]) || (_input[index + 1] == '.')))
                    {
                        // end of the number
                        // numbers cant end with a decimal point
                        if (_input[index] == '.')
                        {
                            isValidExpression = false;
                            return;
                        }
                        tokenEnd = index;

                        // tokenise
                        string inputSubstring = _input.Substring(tokenStart, tokenEnd - tokenStart + 1);
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
        }

        private void CorrectTokens()
        {
            int index = 0;
            while (index < tokenList.Count)
            {
                if (tokenList[index] is SubtractionToken)
                {
                    if (index == 0 || tokenList[index-1] is OperatorToken & !(tokenList[index-1] is CloseBracketToken))
                    {
                        tokenList.Remove(tokenList[index]);
                        if (tokenList[index] is FloatToken)
                        {
                            ((FloatToken)tokenList[index]).value *= -1;
                        }
                    }
                }
                else if (tokenList[index] is OpenBracketToken)
                {
                    if (index != 0)
                    {
                        if (tokenList[index - 1] is CloseBracketToken || !(tokenList[index - 1] is OperatorToken))
                        {
                            // insert a mult token before the open bracket
                            tokenList.Insert(index++, new MultiplicationToken());
                        }
                    }
                }
                else if (tokenList[index] is CloseBracketToken)
                {
                    if (index != tokenList.Count - 1)
                    {
                        if (tokenList[index + 1] is OpenBracketToken || !(tokenList[index + 1] is OperatorToken))
                        {
                            // insert a mult token after the close bracket
                            tokenList.Insert(++index, new MultiplicationToken());
                        }
                    }
                }

                index++;
            }
        }

        private void ShuntingYard()
        {
            expression = new Queue<Token>();
            Stack<Token> operatorStack = new Stack<Token>();

            foreach (Token token in tokenList)
            {
                if (!(token is OperatorToken))
                {
                    // enqueue any floats to the queue
                    expression.Enqueue(token);
                }
                else if (token is CloseBracketToken)
                {
                    // enqueue operators from the stack to the queue until an open bracket is reached
                    bool reachedOpenBracket = false;
                    while (!reachedOpenBracket)
                    {
                        Token opToken = operatorStack.Pop();
                        if (opToken is OpenBracketToken)
                        {
                            reachedOpenBracket = true;
                        }
                        else
                        {
                            expression.Enqueue(opToken);
                        }
                    }
                }
                else if (!(token is OpenBracketToken))
                {
                    // enqueue operators from the stack to the queue until the stack's precedence is equal
                    bool shouldPop = true;
                    while (operatorStack.Count > 0 && shouldPop)
                    {
                        if (((OperatorToken)(operatorStack.Peek())).precedence <= ((OperatorToken)token).precedence)
                        {
                            expression.Enqueue(operatorStack.Pop());
                        }
                        else
                        {
                            shouldPop = false;
                        }
                    }
                    operatorStack.Push(token);
                }
                else
                {
                    operatorStack.Push(token);
                }
            }

            // clear the remains of the operator stack
            while (operatorStack.Count > 0)
            {
                expression.Enqueue(operatorStack.Pop());
            }

            isValidExpression = true;
        }

        public float Evaluate()
        {
            Stack<FloatToken> workingStack = new Stack<FloatToken>();
            while (expression.Count > 0)
            {
                if (expression.Peek() is OperatorToken)
                {
                    OperatorToken opToken = (OperatorToken)expression.Dequeue();
                    if (workingStack.Count < 2)
                    {
                        Console.WriteLine("ERROR | Invalid expression.");
                        return 0f;
                    }
                    float secondArg = workingStack.Pop().value;
                    float firstArg = workingStack.Pop().value;
                    workingStack.Push(new FloatToken(opToken.Operate(firstArg, secondArg)));
                }
                else
                {
                    workingStack.Push((FloatToken)expression.Dequeue());
                }
            }
            return workingStack.Peek().value;
        }
    }

    public abstract class Token
    {

    }

    public class FloatToken : Token
    {
        public float value;

        public FloatToken(float newValue)
        {
            value = newValue;
        }

        public override string ToString()
        {
            return "<" + value.ToString() + ">";
        }
    }

    public abstract class OperatorToken : Token
    {
        public int precedence;
        public abstract float Operate(float value1, float value2);
    }

    public class AdditionToken : OperatorToken
    {
        public AdditionToken()
        {
            precedence = 3;
        }
        public override float Operate(float value1, float value2)
        {
            return value1 + value2;
        }

        public override string ToString()
        {
            return "<+>";
        }
    }

    public class SubtractionToken : OperatorToken
    {
        public SubtractionToken()
        {
            precedence = 3;
        }
        public override float Operate(float value1, float value2)
        {
            return value1 - value2;
        }

        public override string ToString()
        {
            return "<->";
        }
    }

    public class MultiplicationToken : OperatorToken
    {
        public MultiplicationToken()
        {
            precedence = 2;
        }
        public override float Operate(float value1, float value2)
        {
            return value1 * value2;
        }

        public override string ToString()
        {
            return "<*>";
        }
    }

    public class DivisionToken : OperatorToken
    {
        public DivisionToken()
        {
            precedence = 2;
        }
        public override float Operate(float value1, float value2)
        {
            return value1 / value2;
        }

        public override string ToString()
        {
            return "</>";
        }
    }

    public class ExponentiationToken : OperatorToken
    {
        public ExponentiationToken()
        {
            precedence = 1;
        }
        public override float Operate(float value1, float value2)
        {
            return (float)Math.Pow(value1,value2);
        }

        public override string ToString()
        {
            return "<^>";
        }
    }

    public class OpenBracketToken : OperatorToken
    {
        public OpenBracketToken()
        {
            precedence = 999;
        }

        public override float Operate(float value1, float value2)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "<(>";
        }
    }

    public class CloseBracketToken : OperatorToken
    {
        public CloseBracketToken()
        {
            precedence = 999;
        }

        public override float Operate(float value1, float value2)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "<)>";
        }
    }
}
