//Some project while learning C#

using System;

namespace BasicUIMenu
{
    class Basic
    {
        // The method used for the 1st option.

        /// <summary>
        /// Prints the name of the author.
        /// </summary>
        /// <param name="option"></param>
        static void nameOption(int option)
        {
            Console.WriteLine("\nDenislav Mirkov \n");
        }

        // The method for the 2nd option.

        /// <summary>
        /// Calculates the area of a choosen figure between triangle and rectangle.
        /// </summary>
        /// <param name="areaOption"></param>
        static void areaOption(int areaOption)
        {
          
            Console.WriteLine("Choose an area");
            Console.WriteLine("1 - Triangle");
            Console.WriteLine("2 - Rectangle");
            Console.WriteLine("3 - Back");
            areaOption = int.Parse(Console.ReadLine());

            // First option - triangle

            if (areaOption == 1)
            {
                Console.WriteLine("We need one of the side of the triangle" +
                " and it's height");
                Console.WriteLine("S = a+h/2");
                Console.WriteLine("Type side a");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Type the height h");
                double h = double.Parse(Console.ReadLine());
                if (a > 0 && h > 0)
                {
                    areaTriangle(a, h);
                }
                else
                { Console.WriteLine("Type a positive number or not 0, because it's impossible"); }
            }

            // Second option - rectangle
            
            else if (areaOption == 2)
            {
                Console.WriteLine("We need both sides of the rectangle");
                Console.WriteLine("S = a * b");
                Console.WriteLine("Type side a");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Type the side b");
                double b = double.Parse(Console.ReadLine());
                if (a > 0 && b > 0)
                {
                    areaRectangle(a, b);
                }
                else
                {
                    Console.WriteLine("Type a positive number or not 0, because it's impossible");
                }
            }
            else if (areaOption == 3)
            {

            }
            else
            {
                Console.WriteLine("Error - choose from the list");
            }
        }

        /// <summary>
        /// Calculates the area of a triangle.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="h"></param>
        static void areaTriangle (double a, double h)
        {
            Console.WriteLine("The area is " + ((a+h)/2) +"\n");
        }

        /// <summary>
        /// Calculates the area of a Rectangle.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void areaRectangle(double a, double b)
        {
             Console.WriteLine("The area is " + (a*b));
        }

        // The method for the third option

        /// <summary>
        /// The method for the calculator
        /// </summary>
        /// <param name="firstNum"></param>
        /// <param name="secondNum"></param>
        static void Calculator (double firstNum,double secondNum)
        {
            Console.WriteLine("Type the first num");
            firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Type the second num");
            secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Type what you want to do with it" + "Hint: you can only use +,-,*,/");
            string statement = Console.ReadLine();
            if (statement == "*")
            {
                Console.WriteLine($"{firstNum} * {secondNum} = " + firstNum * secondNum);
            }
            else if (statement == "/")
            {
                if (secondNum != 0)
                {
                    Console.WriteLine($"{firstNum} / {secondNum} = " + firstNum / secondNum);
                }
                else
                {
                    Console.WriteLine("You can't divide by 0. Type a valid number");
                }
            }
            else if (statement == "+")
            {
                Console.WriteLine($"{firstNum} + {secondNum} = " + firstNum + secondNum);
            }
            else if (statement == "-")
            {
                Console.WriteLine($"{firstNum} - {secondNum} = " + (firstNum - secondNum));
            }
            else
            {
                Console.WriteLine("Error - use valid statement");
            }

        }

        // Main method
        // Switch case for the options and infinite
        // while loop until you choose 4
        static void Main(string[]args)
        {
            double firstNum = 0;
            double secondNum = 0;
            int option = 0;
            while (option != 4 )
            {
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1 - See the author's name");
            Console.WriteLine("2 - Find a area of a triangle or a rectangle");
            Console.WriteLine("3 - Calculator");
            Console.WriteLine("4 - Exit");
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch(Exception ex) {  }
                switch (option)
                {
                    case 1:
                        nameOption(option);
                        break;
                    case 2:
                        try
                        {
                            areaOption(option);
                        }
                        catch(Exception)
                        {
                            Console.WriteLine("Error - type a number");
                            areaOption(option);
                        }
                        break;

                    case 3:
                        try
                        {
                            Calculator(firstNum, secondNum);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error - type a number");
                            Calculator(firstNum, secondNum);
                        }
                        break;

                    case 4: break;

                    default:
                        
                            Console.WriteLine("Choose from the list above!");
                        break;
                        
                }

            }

        }

    }

}

// Author: Denislav Mirkov
