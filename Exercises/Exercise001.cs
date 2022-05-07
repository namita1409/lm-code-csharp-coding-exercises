using System;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            
            if (word.Length == 0)
                System.Console.WriteLine("Empty String");

            else if(word.Length==1)               
               word = word[0].ToString().ToUpper();

            else
                word = word[0].ToString().ToUpper() + word.Substring(1);
            
            return word;
        }

        public string GenerateInitials(string firstName, string lastName)
        {            
            char first_name_initial = '\0';
            char last_name_initial='\0';

            if (firstName.Length == 0 || lastName.Length == 0)
                System.Console.WriteLine("empty string");

            else {
                first_name_initial = firstName[0];
                last_name_initial = lastName[0]; 
            }
            return first_name_initial.ToString() + "." + last_name_initial.ToString();
        }


        public double AddVat(double originalPrice, double vatRate)
        {            
            double price = (1 + vatRate / 100) * originalPrice;
            return Math.Round(price,2);
        }

        public string Reverse(string sentence)
        {           
            char[] chars = sentence.ToCharArray();
            Array.Reverse(chars);
            return new string (chars);
        }

        public int CountLinuxUsers(List<User> users)
        {            
            int count = 0;
            
           foreach (User userFind in users){
                if (userFind.Type=="Linux"||userFind.Type.Equals("Linux")) { 
                    count++;
                }
            } 
            return count;           
            
        }
    }
}
