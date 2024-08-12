﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();
            bool validInput;

            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter 2 integers to add");
                    validInput = calculator.getNumbers();

                    if (validInput == true)
                    {
                        Console.Write($"{calculator.getFirstNumber()} + {calculator.getSecondNumber()} = ");
                        Console.Write(calculator.Add());
                    }
                    break;

                case "2":
                    Console.WriteLine("Enter 2 integers to subtract");
                    validInput = calculator.getNumbers();

                    if (validInput == true)
                    {
                        Console.Write($"{calculator.getFirstNumber()} + {calculator.getSecondNumber()} = ");
                        Console.Write(calculator.Subtract());
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter 2 integers to multiply");
                    validInput = calculator.getNumbers();

                    if (validInput == true)
                    {
                        Console.Write($"{calculator.getFirstNumber()} + {calculator.getSecondNumber()} = ");
                        Console.Write(calculator.Multiply());
                    }
                    break;


                case "4":
                    Console.WriteLine("Enter 2 integers to divide");
                    validInput = calculator.getNumbers();

                    if (validInput == true)
                    {
                        Console.Write($"{calculator.getFirstNumber()} + {calculator.getSecondNumber()} = ");
                        Console.Write(calculator.Divide());
                    }
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
    }
}