using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {

        public double Readnumber(String s)
        {
            double num;
            Console.WriteLine("Enter the {0} number:\n", s);
            double.TryParse(Console.ReadLine(), out num);
            return num;
        }
        static void Main(string[] args)
        {
            int option;
            double num1,num2,result;
            bool Exit = false;
            Program p = new Program();
            do
            {
                Console.WriteLine("Select calculation:\n 1.Add\n 2.Multiply\n 3.Substract\n 4.Divide\n 5.Exit");
                int.TryParse(Console.ReadLine(),out option);               

                switch (option)
                {
                    case 1:
                        num1 = p.Readnumber("first");
                        num2 = p.Readnumber("second");
                        result = num1 + num2;
                        Console.WriteLine("Result is: {0}\n", result);
                        break;
                    case 2:

                        num1 = p.Readnumber("first");
                        num2 = p.Readnumber("second");
                        result = num1 * num2;
                        Console.WriteLine("Result is: {0}\n", result);
                        break;
                    case 3:

                        num1 = p.Readnumber("first");
                        num2 = p.Readnumber("second");
                        result = num1 - num2;
                        Console.WriteLine("Result is: {0}\n", result);
                        break;
                    case 4:

                        num1 = p.Readnumber("first");
                        num2 = p.Readnumber("second");
                        if (num2 == 0.0)
                        {
                            Console.WriteLine("Cannot divide by zero.\n");
                        }else {
                            result = num1/num2;
                            Console.WriteLine("Result is: {0}\n", result);
                        }
                 
                        break;
                    case 5:
                        Exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Select another one\n");
                        break;
                }
                
            } while (!Exit);
        }
    }
}
