using System;

namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ==========================");
            Console.WriteLine(" | Two Numbers Calculator |");
            Console.WriteLine(" ==========================");
            

            double num1 = 0.0;
            double num2 = 0.0;
            string operatorSign = "";
            double result = 0.0;
            bool again = true;
            int choice = 0;
            while (again)
            {
                Console.WriteLine();
                Console.Write("Insert First Number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Insert Operator: ");
                operatorSign = Console.ReadLine();
                if(operatorSign != "+" && operatorSign != "-" && operatorSign != "*" && operatorSign != "/" && operatorSign != "%" && operatorSign != "^")
                {
                    throw new Exception("Invalid Operator!");
                }
                Console.Write("Insert Second Number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                switch (operatorSign)
                {
                    case "+":
                        result = addition(num1, num2);
                        break;
                    case "-":
                        result = subtract(num1, num2);
                        break;
                    case "*":
                        result = multiply(num1, num2);
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            throw new DivideByZeroException("Cannot divide by zero!!!");
                        }
                        else
                        {
                            result = divide(num1, num2);
                        }
                        break;
                    case "%":
                        result = remainder(num1, num2);
                        break;
                    case "^":
                        result = power(num1, num2);
                        break;
                }
                Console.WriteLine($"Answer: {num1} {operatorSign} {num2} = {result}");
                Console.WriteLine("\nDo you want to try again?\n1.Yes\n2.No");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        again = true;
                        break;
                    case 2:
                        again = false;
                        break;
                    default :
                        Console.WriteLine("Error!");
                        again = false;
                        break;
                }
            } 
            Console.WriteLine("\nThank you for using the calculator!");
        }
        static double addition(double x, double y)
        {
            return x + y;
        }
        static double subtract(double x, double y)
        {
            return x - y;
        }
        static double multiply(double x, double y)
        {
            return x * y;
        }
        static double divide(double x, double y)
        {
                return x / y;       
        }
        static double remainder(double x, double y)
        {
            return x % y;
        }
        static double power(double x, double y)
        {
            return Math.Pow(x,y);
        }
    }
}
