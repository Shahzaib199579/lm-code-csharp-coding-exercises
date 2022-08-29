using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            // Replace the exception statement below with your code!
            if (String.IsNullOrEmpty(input))
                return false;

            var cleanInput = new List<char>();
            cleanInput = input.ToList().Where(x => !String.Equals(Convert.ToString(x), " ") 
                                                    && !String.Equals(Convert.ToString(x), "_")).Select(x => x).ToList();

            var lettersToCheck = new List<char>();
            for (int i = 65; (i >= 65 && i <= 90) || (i >= 97 && i <= 122); i++)
            {
                lettersToCheck.Add((char)i);

                if (i == 90)
                    i = 96;
                if (i == 122)
                    break;
            }

            var numbersToCheck = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            cleanInput = cleanInput.Where(x => !numbersToCheck.Contains(x)).Select(x => x).ToList();

            var letterDictionary = new Dictionary<char, int>();
            for (int i = 26; i < 52; i++)
            {
                letterDictionary.Add(lettersToCheck[i], 0);
            }
            foreach (var l in cleanInput)
            {
                letterDictionary[Convert.ToChar(Convert.ToString(l).ToLower())]++;
            }

            if (letterDictionary.Values.Where(x => x == 0).Select(x => x).ToList().Count > 0)
                return false;


            return true;
        }
    }
}
