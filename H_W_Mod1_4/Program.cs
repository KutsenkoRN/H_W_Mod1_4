namespace HWMod14
{
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

            int[] evenNumbers = GetEvenNumbersArray(inputArray);
            int[] oddNumbers = GetOddNumbersArray(inputArray);
        }

        private static int[] GetOddNumbersArray(int[] inputArray)
        {
            int[] result = new int[0];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] % 2 != 0)
                {
                    result[i] += inputArray[i];
                }
            }

            return result;
        }

        private static int[] GetEvenNumbersArray(int[] inputArray)
        {
            int[] result = new int[0];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] % 2 == 0)
                {
                    result[i] += inputArray[i];
                }
            }

            return result;
        }
    }
}