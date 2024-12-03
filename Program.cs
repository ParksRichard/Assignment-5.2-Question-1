/*
Given a string of words and spaces, return the length of
the last word in the string. A word is a maximal substring
consisting of non-space characters only
*/


//array input, split elements and null spaces, periods and such
//word.length - 1? || - " " 
//verify word?

namespace Assignment_5._2_Question_1
{
    public class word
    {
        public int wordlength(string s)
        {
            int length = 0;
            int i = s.Length - 1;
            //string[] words = s.Trim() dunno

            while (i >= 0 && s[i] == ' ')
            {
                i--;
            }
            //punctuation?
            while (i >= 0 && s[i] != ' ')
            {
                length++;
                i--;
            }
            return length;
        }
    }
    class Program
    {
        static void Main()
        {
            word solution = new word();

            //user input
            Console.WriteLine("Please enter a sentance: ");
            Console.WriteLine("Example: The quick brown fox jumps over the lazy dog.");
            Console.WriteLine("");

            string input = Console.ReadLine();

            int result = solution.wordlength(input);

            Console.WriteLine($"The length of the last word is: {result}");
            
        }
    }
}
