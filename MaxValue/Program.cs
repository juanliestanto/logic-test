namespace MaxValue
{
    class Program
    {
        public static void Main()
        {
            int[] numbers = [1, 5, 3, 7, 2];
            try
            {
                int result = MaxValue(numbers);
                Console.WriteLine("The maximum value of the array is " + result);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static int MaxValue(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty");
            }

            int max = 0;

            foreach (int value in numbers)
            {
                if (max < value)
                {
                    max = value;
                }
            }

            return max;
        }
    }
}
