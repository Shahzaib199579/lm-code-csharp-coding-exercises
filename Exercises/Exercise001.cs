﻿using System;
using System.Collections.Generic;
using System.Linq;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            // Replace the exception statement below with your code!
            if (String.Equals(word, null) || String.Equals(word, String.Empty) || String.Equals(word, " "))
                return word;

            return word[0].ToString().ToUpper() + word.Substring(1);
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            // Replace the exception statement below with your code!
            return firstName.Substring(0, 1) + "." + lastName.Substring(0, 1);
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            // Replace the exception statement below with your code!
            if (originalPrice < 0)
                throw new ArgumentException("Price cannot be negative. Please enter a valid price.");
            else if (vatRate < 0)
                throw new ArgumentException("VAT cannot be negative. Please enter a valid VAT.");
            else if (vatRate == 0)
                return originalPrice;

            // NB: Look in Exercise001Tests.cs
            //     There is a test with commented out assertions.
            //     For an extra challenge, uncomment those assertions and make that test pass too.
            return Math.Round(originalPrice + (originalPrice * (vatRate / 100)), 2);
        }

        public string Reverse(string sentence)
        {
            // Replace the exception statement below with your code!
            if (String.Equals(sentence, " ") || String.Equals(sentence, null))
                return sentence;

            List<char> charactersList = new List<char>();
            charactersList.AddRange(sentence);
            charactersList.Reverse();

            return String.Join("", charactersList);
        }

        public int CountLinuxUsers(List<User> users)
        {
            if (users == null)
                return 0;
            else if (users.Count() == 0)
                return 0;

            // Replace the exception statement below with your code!
            return users.Where(x => String.Equals(x.Type, "Linux")).Count();
        }
    }
}
