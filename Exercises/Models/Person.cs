using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Models
{
    public class Person
    {
        public String firstName;
        public String lastName;
        public String city;
        public int age;

        public Person(String firstName, String lastName, String city, int age) { 
            this.firstName = firstName;
            this.lastName = lastName;
            this.city = city;
            this.age = age;
        }
    }
}
