namespace NumberOfWords
{
    class Program
    {
        internal static readonly char[] separator = [' '];
        public static void Main()
        {
            String words = "";
            try
            {
                int result = NumberOfWords(words);
                Console.WriteLine("The Result is " + result);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static int NumberOfWords(String words)
        {
            if (string.IsNullOrEmpty(words))
            {
                throw new ArgumentException("Input string cannot be null or empty");
            }

            String[] word = words.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            return word.Length;
        }
    }
}
