using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            if (String.IsNullOrEmpty(input))
                return false;

            // removing " " and "_" from the input
            var cleanInput = new List<char>();
            cleanInput = input.ToList().Where(x => !String.Equals(Convert.ToString(x), " ") 
                                                    && !String.Equals(Convert.ToString(x), "_")).Select(x => x).ToList();

            // creating a list with all alphabets from A-Z and a-z
            var lettersToCheck = new List<char>();
            for (int i = 65; (i >= 65 && i <= 90) || (i >= 97 && i <= 122); i++)
            {
                lettersToCheck.Add((char)i);

                if (i == 90)
                    i = 96;
                if (i == 122)
                    break;
            }

            // removing numbers from the input
            var numbersToCheck = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            cleanInput = cleanInput.Where(x => !numbersToCheck.Contains(x)).Select(x => x).ToList();

            var letterDictionary = new Dictionary<char, int>();
            for (int i = 26; i < 52; i++)
            {
                letterDictionary.Add(lettersToCheck[i], 0);
            }

            // incrementing the value againt the key
            foreach (var l in cleanInput)
            {
                letterDictionary[Convert.ToChar(Convert.ToString(l).ToLower())]++;
            }

            // checking whether there is an alphabet missing like "X" or "H" because
            // missing variable will have 0 as a value in the dictionary
            if (letterDictionary.Values.Where(x => x == 0).Select(x => x).ToList().Count > 0)
                return false;


            return true;
        }
    }
}
