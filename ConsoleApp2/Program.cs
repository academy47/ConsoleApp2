using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question 1
            string[] stringArray = new string[] { "String 1", "String 2", "String 3", "String 4" };
            Console.WriteLine("Select an index of the string array.");
            int idx = Convert.ToInt32(Console.ReadLine());
            //Question 3
            if (idx < 0 || idx >= stringArray.Length)
            {
                Console.WriteLine("The index does not exist in the string array");
            }
            else
            {
                //Question 2
                Console.WriteLine("The string at index " + idx + " is " + stringArray[idx]);
            }

            //Question 2
            int[] intArray = new int[] { 1, 2, 3, 4 };
            Console.WriteLine("Select an index of the int array.");
            idx = Convert.ToInt32(Console.ReadLine());
            //Question 3
            if (idx < 0 || idx >= intArray.Length)
            {
                Console.WriteLine("The index does not exist in the int array");
            }
            else
            {
                Console.WriteLine("The int at index " + idx + " is " + intArray[idx]);
            }

            //Question 4
            List<string> stringList = new List<string> { "List string 1", "List string 2", "List string 3", "List string 4" };
            Console.WriteLine("Select an index of the string list.");
            idx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The string at index " + idx + " of the string list is " + stringList[idx]);
        }
    }
}
