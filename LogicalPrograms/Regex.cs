using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LogicalPrograms
{
    class Regexpattern
        
    {
        string pattern = "^[M-Z]{1,2}[a-z]{5,15}$";
        string[] inputs= { "ameeja", "zzzz","MNghgjs", "zfhg","Rani","Shallu" ,"agfhf","Zghfgghf" };
        public void validating()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("verifying the first letter start with capital M ");
            iterationloop(inputs,regex);
        }

        public static void iterationloop(string[] array ,Regex regex)
        {
            
                for (int i = 0; i < array.Length; i++)
                {
                    bool result = regex.IsMatch(array[i]);
                    if (result)
                    {
                        Console.WriteLine(array[i] + " It is --->" + "Valid");
                    }
                    else
                    {
                        Console.WriteLine(array[i] + " It is --->" + "Invalid");
                    }
                }
        }
        // Spilt a string on alphabetic character  
        public  void Replacingwhitesapce()
        {
            string pattern = "[A-Za-z]+";

            string str = "Asd 2323 b 0900 c 1234 Def 5678 Ghi 9012 Jklm";

            String result = Regex.Replace(str, pattern, "");
            Console.WriteLine("" + result);


            /* string[] result = Regex.Split(str, pattern,

             RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(500));

             for (int i = 0; i < result.Length; i++)

             {

                 Console.Write("'{0}'", result[i]);

                 if (i < result.Length - 1)

                     Console.Write(",");

             }*/

        }

    }
}
