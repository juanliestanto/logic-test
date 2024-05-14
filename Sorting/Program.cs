namespace Sorting
{
    class Program
    {
        public static void Main()
        {
            int[] numbers = [3, 1, 5, 2, 4];
            try
            {
                Sort(numbers);
                PrintArray(numbers);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static int[] Sort(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty");
            }

            int n = numbers.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                    }
                }
            }
            return numbers;
        }

        static void PrintArray(int[] numbers)
        {
            Console.WriteLine("Sorted Array : ");
            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }
    }
}
