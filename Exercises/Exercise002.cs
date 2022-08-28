using Exercises.Models;
using System;
namespace Exercises
{
    public class Exercise002
    {
        // 👉 Remember to delete all unnecessary comments (like this one) when you're done! 

        public bool IsFromManchester(Person person)
        {
            // 👉 DON'T FORGET to uncomment the tests in Exercise002Tests.cs 
            // Uncomment the parameter above and delete this comment

            // Replace the exception statement below with your code!
            if (person == null)
                return false;

            return person.City.ToLower().Equals("manchester");
        }

        public bool CanWatchFilm(Person person, int ageLimit)
        {
            // 👉 DON'T FORGET to uncomment the tests in Exercise002Tests.cs 
            // Uncomment the parameters above and delete this comment

            // Replace the exception statement below with your code!
            return person.Age >= ageLimit;
        }
    }
}
