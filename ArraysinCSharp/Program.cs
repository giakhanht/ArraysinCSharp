using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysinCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //An integer array
            int[] anArray = { 21, 22, 23, 26, 32, 40 };

            //Print out the length of an array
            Console.WriteLine(anArray.Length);

            //Copy the content of an array to another array
            int[] anotherArray;
            anotherArray = new[] { 1, 2, 3, 4 };
            Array.Copy(anArray, anotherArray, 4);

            //Sort the array numerically
            Array.Sort(anArray);

            //Determine if a certain value exists in an array
            Array.IndexOf(anotherArray, anArray);
        }
    }
}
