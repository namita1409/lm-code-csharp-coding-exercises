using System;
namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {           
            int count = returnCount(input);
            return count == 26;
        }
        public int returnCount(String input) {

            String str = "abcdefghijklmnopqrstuvwxyz";           
            int count = 0;
            foreach (char c in str)
            {
                foreach (char l in input.ToLower())
                {
                    if (c == l)
                    {
                        count++;
                         break;
                    }
                }
            }
            return count;
        }
    }
}
