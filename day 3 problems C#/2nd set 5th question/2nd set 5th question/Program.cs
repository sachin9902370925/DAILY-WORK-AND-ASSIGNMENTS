/*Writeaprogramthatremovesfromagivensequenceallnumbersthatappearanoddcountoftimes.*/

using System;

class odd
{
	
	static int getOddOccurrence(int[] arr, int arr_size)
	{
		for (int i = 0; i < arr_size; i++)
		{
			int count = 0;

			for (int j = 0; j < arr_size; j++)
			{
				if (arr[i] == arr[j])
					count++;
			}
			if (count % 2 != 0)
				return arr[i];
		}
		return 0;
	}

	
	public static void Main()
	{
		int[] arr = { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
		int n = arr.Length;
		Console.Write(getOddOccurrence(arr, n));
	}
}


