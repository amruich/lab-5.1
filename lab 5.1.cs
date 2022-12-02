using System;

namespace Task1
{
    public static class Program
    {
        public static void Main()
        {
            double previousInput = 0;
            while (true)
            {
                Console.Write("Введите число: ");
                string input = Console.ReadLine();

                bool isInt = int.TryParse(input, out int intNumber);
                bool isDouble = double.TryParse(input, out double doubleNumber);
                if (isInt)
                {
                    Console.WriteLine((char)intNumber);
                    previousInput = intNumber;
                    break;
                }
                else if (isDouble)
                {
                    if (doubleNumber == previousInput)
                    {
                        Console.WriteLine("Введенное число равно предыдущему");
                        break;
                    }
                    previousInput = doubleNumber;
                }
                else if (input == "q")
                    break;

            }

        }
    }
}

