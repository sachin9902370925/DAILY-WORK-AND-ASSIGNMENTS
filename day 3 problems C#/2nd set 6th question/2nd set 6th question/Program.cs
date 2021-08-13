/*Writeaprogramthatfindsinagivenarrayofintegers(intherange[0...1000])
 * howmanytimeseachofthemoccurs.Example:array={3,4,4,2,3,3,4,3,2}22times34times43times*/

using System;
public class problem
{
    public static void Main()
    {
        int[] arr = new int[50];
        int[] fr = new int[50];
        int x, i, j, counter;


        Console.Write("Input the number of elements  in the array -");
        x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input {0} elements  -\n", x);
        for (i = 0; i < x; i++)
        {
            Console.Write("element - {0} : ", i);
            arr[i] = Convert.ToInt32(Console.ReadLine());
            fr[i] = -1;
        }
        for (i = 0; i < x; i++)
        {
            counter = 1;
            for (j = i + 1; j < x; j++)
            {
                if (arr[i] == arr[j])
                {
                    counter++;
                    fr[j] = 0;
                }
            }

            if (fr[i] != 0)
            {
                fr[i] = counter;
            }
        }
        Console.Write("\noccurance of each element of array \n");
        for (i = 0; i < x; i++)
        {
            if (fr[i] != 0)
            {
                Console.Write("{0} occurs {1} times\n", arr[i], fr[i]);
            }
        }
    }
}
