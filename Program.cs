using System;

namespace ConsoleApp11
{/// <summary>
/// App.
/// </summary>
    internal class Program
    {/// <summary>
     /// Start of app.
     /// </summary>
     /// <param name="args">args addet via console.</param>
        public static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива:\t");
            int elementsCount = int.Parse(Console.ReadLine());
            int[] inputArray = new int[elementsCount];
            Random rand = new Random();

            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = rand.Next(1, 21);
            }

            int[] evenNumbers = new int[elementsCount];
            int[] oddNumbers = new int[elementsCount];

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] % 2 == 0)
                {
                    evenNumbers[i] += inputArray[i];
                }
                else
                {
                    oddNumbers[i] += inputArray[i];
                }
            }
        }
    }
}