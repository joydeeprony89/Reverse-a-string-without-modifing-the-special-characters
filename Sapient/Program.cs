using System;
using System.Collections.Generic;

namespace Sapient
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Today, I, am! very, happy!";
            Console.WriteLine(Reverse(input));
            Console.WriteLine("Hello World!");
        }

        public static string Reverse(string str)
        {
            var strArr = str.Split(" ");
            int length = strArr.Length;
            HashSet<char> chaArr = new HashSet<char> { ',', '!' };
            for(int i = 0 , j = length - 1; i < length/2; i++)
            {
                // SWAP
                string temp1 = strArr[i];
                string temp2 = strArr[j];
                char temp1Char = temp1[temp1.Length - 1];
                char temp2Char = temp2[temp2.Length - 1];

                if(chaArr.Contains(temp1Char))
                {
                    temp2 = chaArr.Contains(temp2Char) ? temp2.Substring(0,temp2.Length - 1) + temp1Char : temp2 + temp1Char;
                }
                else
                {
                    temp2 = temp2.Substring(0, temp2.Length - 1);
                }

                if (chaArr.Contains(temp2Char))
                {
                    temp1 = chaArr.Contains(temp1Char) ? temp1.Substring(0, temp1.Length - 1) + temp2Char : temp1 + temp2Char;
                }
                else
                {
                    temp1 = temp1.Substring(0, temp1.Length - 1);
                    temp1 = temp1.Substring(0, temp1.Length - 1);
                }

                strArr[i] = temp2;
                strArr[j] = temp1;

                j--;
            }

            return string.Join(" ", strArr);
        }
    }
}
