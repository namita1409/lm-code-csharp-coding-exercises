using System;
namespace Exercises
{
    public class Exercise002
    {
        public bool IsFromManchester(Models.Person person )
        {     
           return (person.city == "Manchester"||person.city.Equals("Manchester")); 
        }

        public bool CanWatchFilm(Models.Person person, int ageLimit)
        {           
           return (person.age>ageLimit);
        }
    }
}
