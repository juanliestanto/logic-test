namespace MostCharacter
{
    class Program
    {
        public static void Main()
        {
            String words = "hello";
            try
            {
                char result = TheMostCharacter(words);
                Console.WriteLine(result);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static char TheMostCharacter(String words)
        {
            if (string.IsNullOrEmpty(words))
            {
                throw new ArgumentException("String cannot be null or empty");
            }

            char[] word = words.ToCharArray();
            Dictionary<char, int> character = [];
            int maxValue = 0;
            char result = word[0];

            foreach (char value in word)
            {
                if (character.TryGetValue(value, out int count))
                {
                    character[value] = ++count;
                }
                else
                {
                    character.Add(value, 1);
                }

                if (count > maxValue)
                {
                    maxValue = count;
                    result = value;
                }
            }

            return result;
        }
    }
}
