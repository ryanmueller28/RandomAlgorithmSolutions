using System;
using System.Collections;
using System.Collections.Generic;

namespace HashString
{
    class Games
    {
        static void Main(string[] args)
        {
            string CheckString = Console.ReadLine();


            string PrintString = ReverseString(CheckString);

            Console.WriteLine(PrintString);
        }

        /**
        * @param - InString, the string to be passed in 
        * takes a string and separates out non-digit and non-alpha characters
        * keeping those indexed in a dictionary
        * And the Alpha/Numeric in an ArrayList (Vector for my cpp mind)
        */
        static string ReverseString(string InString)
        {
            string OutString = "";

            Dictionary<int, char> SpecialIndex = new Dictionary<int, char>();
            
            ArrayList NormalChars = new ArrayList();

            // Set up indexes and dictionary of special characters
            for (int i = 0; i < InString.Length; i++)
            {
                if (!Char.IsLetter(InString[i]) && !Char.IsNumber(InString[i]))
                {
                    SpecialIndex.Add(i, InString[i]);
                }else{
                    NormalChars.Add(InString[i]);
                }
            }

            NormalChars.Reverse();

            

            for (int i = 0; i < InString.Length; i++)
            {
                if (SpecialIndex.ContainsKey(i))
                {
                    OutString += SpecialIndex[i]; // If index is i, add taht
                }else{
                    OutString += NormalChars[0]; // add first element in NormalChars and remove first element.
                    NormalChars.RemoveAt(0);
                }
            }

            return OutString;
        }
    }
}