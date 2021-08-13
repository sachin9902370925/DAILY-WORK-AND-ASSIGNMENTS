/*Writeaprogram,whichremovesallnegativenumbersfromasequence.Example:array={19,-10,12,-6,-3,34,-2,5}{19,12,34,5}*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace problem4
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            int[] arr = new int[8];

            Console.WriteLine("Enter sequence: ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("sequence element" + (i + 1) + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("List of only positive numbers : ");
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}