/*Writeaprogramthatreadsfromtheconsoleasequenceofpositiveintegernumbers.
 * Thesequenceendswhenanemptylineisentered.Printthesequencesortedinascendingorder.*/

using System;
public class problem3
{
    public static void Main()
    {
        int[] arr = new int[8];
        int i, j, tmp, n;


        Console.Write("\n\nascending sorting\n");

        Console.Write("enter size of sequence : ");
        n = Convert.ToInt32(Console.ReadLine());


        for (i = 0; i < n; i++)
        {
            Console.Write("number  {0} : ", i);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < n; i++)
        {
            for (j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[i])
                {
                    tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                }
            }
        }
        Console.Write("\nsorted array\n");
        for (i = 0; i < n; i++)
        {
            Console.Write("{0}  ", arr[i]);
        }
        Console.Write("\n\n");
    }
}