/*Writeaprogramthatreadsfromtheconsoleasequenceofpositiveintegernumbers. 
 * Thesequenceendswhenemptylineisentered.Calculateandprintthesumandtheaverageofthesequence.KeepthesequenceinList<int>..*/

using System;
using System.Collections.Generic;
using System.Linq;

public class sumandaverage
{
    public static void Main()
    {

        List<int> sequence = ReadIntegers();
        Console.WriteLine("sum of the numbers is= " + sequence.Sum());
        Console.WriteLine("average of the numbers is= " + sequence.Average());
    }

    private static List<int> ReadIntegers()
    {
        Console.WriteLine(" enter as many positive integer numbers as you want and give an empty line input to end");
        List<int> sequence = new List<int>();
        string input = Console.ReadLine();
        while (input != string.Empty)
        {
            int num = -1;
            try
            {
                num = int.Parse(input);
                if (num < 0)
                {
                    Console.WriteLine("please enter positive numbers only");
                }
                else
                {
                    sequence.Add(num);
                    Console.WriteLine(input + " enter next number");
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }


            input = Console.ReadLine();
        }

        Console.WriteLine("The numbers entered were: " + string.Join(", ", sequence));
        return sequence;
    }
}