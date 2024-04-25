using System;
namespace Calculator
{
    public class program{
        static void Main(string[] args) { 
            bool exitCalculator = true;
            static void selectOption()
            {
                Console.WriteLine("\n--------------------Calculator--------------------");
                Console.WriteLine("Enter the Selection you want Todo\n\n");
                Console.WriteLine("Press 1 for Addition");
                Console.WriteLine("Press 2 for Subtraction");
                Console.WriteLine("Press 3 for Multiplication");
                Console.WriteLine("Press 4 for Division\n");
                Console.WriteLine("Press 9 for Exit the calculator\n");
                
            }
            while(exitCalculator){
                selectOption();
                try
                {
                    int option = Convert.ToInt32(Console.ReadLine());
                    if (option == 1)
                        add();
                    else if (option == 2)
                        subtract();
                    else if (option == 3)
                        multiply();
                    else if (option == 4)
                        divide();
                    else if (option == 9)
                        exitCalculator = false;
                    else
                    {
                        Console.WriteLine("Invalid Selection!\n");
                        Console.WriteLine("Please! Select from the given options.\n\n");
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }

            static void add()
            {
                Console.WriteLine("Enter first number : ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nEnter second number : ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                double sum = num1+num2;
                Console.WriteLine("The sum is "+ sum);
            }

            static void subtract()
            {
                Console.WriteLine("Enter first number : ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter second number : ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                double difference = num1 - num2;
                Console.WriteLine("The difference is " + difference);
            }

            static void multiply()
            {
                Console.WriteLine("Enter first number : ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter second number : ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                double result = num1 * num2;
                Console.WriteLine("The result is " + result);
            }

            static void divide()
            {
                try
                {
                    Console.WriteLine("Enter first number : ");
                    double dividend = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter second number : ");
                    double divisor = Convert.ToDouble(Console.ReadLine());
                    double quotient = dividend / divisor;
                    Console.WriteLine("The result is " + quotient);
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}

