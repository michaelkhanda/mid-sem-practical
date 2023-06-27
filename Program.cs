using System;

namespace Midsemprac
{
    class Program
    {
        static void Main(string[] args)
        {
            string student;
            int studentID;
            int score;

            Console.WriteLine("Enter student name:");
            student = Console.ReadLine();

            Console.WriteLine("Enter Student ID:");
            studentID = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ENTER A STUDENT SCORE:");
                score = int.Parse(Console.ReadLine());

                if (score > 60 || score <= 100)
                {
                    Console.WriteLine("PASS");

                }
                else if (score < 60)
                {
                    Console.WriteLine("FAIL");
                }


                if (score > 100 || score < 0)
                {
                    Console.WriteLine("INVALID");
                    Console.WriteLine(score + " " + "Is an inavlid score! Please Re-enter");
                    continue;
                }


            }

        }
    }
}
