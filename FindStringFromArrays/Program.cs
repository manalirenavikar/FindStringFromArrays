using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindStringFromArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            string[] arr = new string[] { "cat", "dog", "monkey", "human", "elephant" };
            for (int i = 0; i <= str.Length; i++)
            {
                if (str==arr[i])
                {
                    Console.WriteLine("String found" + arr[i]);
                }
                else 
                { Console.WriteLine("String not in list"); 
                }
            }
            Console.ReadLine();


        }
    }
}
