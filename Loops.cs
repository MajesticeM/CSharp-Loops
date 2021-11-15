using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Conditional_Statements
{
    class Loops
    {

        public static void Question1()
        {
            Console.WriteLine(" Write a program in C# Sharp to display the first 10 natural numbers.");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        public static void Question2()
        {
            Console.WriteLine("Write a C# Sharp program to find the sum of first 10 natural numbers.");
            int sum;
            for (int i = 0; i < 10; i++)
            {
                sum = i++;
                Console.WriteLine(i);
                Console.WriteLine("The first 10 natural number is:" + sum);
            }
            Console.ReadLine();
        }

        public static void Question3()
        {
            Console.WriteLine("Write a program in C# Sharp to display n terms of natural number and their sum.");
            int numbersToDisplay;
            Console.WriteLine("Please enter the amount of numbers that you want to sum");
            numbersToDisplay = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numbersToDisplay; i++)
            {
                int final=i++;
                Console.WriteLine("The Sum of Natural Number up to"+ numbersToDisplay + "terms : "+ final );
            }
            Console.ReadLine();
        }

        public static void Question4() 
        {
            Console.WriteLine("Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.");
            int questions = 10;
            int numbersRequired = 10;
            for (int i = 0; i < questions; i++)
            {
                for (int k = 0; k < numbersRequired; k++)
                {
                    Console.WriteLine(" ");
                }
              
            }
        }

    }
}
