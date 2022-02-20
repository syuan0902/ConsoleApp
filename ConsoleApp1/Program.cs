using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            OperatorExamples();
        }

        private static void OperatorExamples()
        {
            int width = 3;

            width++;

            int height = 2 + 4;
            int area = width * height;
            Console.WriteLine(area);

            string result = "The area";
            result = result + " is " + area;
            Console.WriteLine(result);

            bool truthValue = true;
            Console.WriteLine(truthValue);

            int someValue = 10;
            string message;

            if(someValue == 24)
            {
                message = "The value was 24.";
            }
            else
            {
                message = "The value wasn't 24.";
            }
            Console.WriteLine(message);

        }
    }
}
