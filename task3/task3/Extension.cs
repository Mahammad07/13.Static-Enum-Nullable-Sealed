using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
    public static class Extension
    {




        public static void Check(this string word, char fiqure)
        {
            foreach (var item in word)
            {
                if (fiqure == item)
                {
                    Console.WriteLine("true");
                    break;
                }






                Console.WriteLine("false");

            }
            



        }


    }   
        



    
}
