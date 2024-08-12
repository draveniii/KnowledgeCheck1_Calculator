using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    public class Calculator
    {
        private int firstNumber;
        private int secondNumber;
        public int Add()
        {
            return firstNumber + secondNumber;
        }

        public int Subtract()
        {
            return firstNumber - secondNumber;
        }

        public int Multiply()
        {
            return firstNumber * secondNumber;
        }

        public double Divide()
        {
            return firstNumber / secondNumber;
        }

        public int GetFirstNumber()
        {
            return firstNumber;
        }

        public int GetSecondNumber()
        {  
            return secondNumber;
        }
        public bool GetNumbers()
        {
            var tempFirstNumber = Console.ReadLine();
            var tempSecondNumber = Console.ReadLine();
            if (int.TryParse(tempFirstNumber, out firstNumber) && int.TryParse(tempSecondNumber, out secondNumber))
            {
                return true;
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
                return false;
            }
        }
    }
}
