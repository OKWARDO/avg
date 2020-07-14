using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks;
            int input = 1, counter = 0, total = 0;
            float average = 0.0f;
            String grade = "A";

            marks = new int[100];
            Console.WriteLine("Enter the student's grade:  ");

            while (input >= 0)
            {
                input = Convert.ToInt32(Console.ReadLine());
                if (input >= 0)
                {
                    marks[counter++] = input;
                    total += input;
                    Console.WriteLine("Enter the next grade or a negative value to get the average:");
                }
            }
            average = (float)total / (float)counter;
            Console.WriteLine("Average Grade %:  " + average.ToString());
            if (average < 60)
            {
                grade = "F";
            }
            else if (average < 70)
            {
                grade = "D";
            }
            else if (average < 80)
            {
                grade = "C";
            }
            else if (average < 90)
            {
                grade = "B";
            }
            else 
            {
                grade = "A";
            }

            Console.WriteLine("Letter grade average is: " + grade);
            Console.ReadKey();

        }
    }
}
