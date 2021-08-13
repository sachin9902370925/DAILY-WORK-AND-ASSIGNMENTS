/*ThemajorantofanarrayofsizeNisavaluethatoccursinitatleastN/2+1times.Writeaprogramthatfindsthemajorantofgivenarrayandprintsit.
 * Ifitdoesnotexist,print"Themajorantdoesnotexist!".Example:{2,2,3,3,2,3,4,3,3}3*/

using System;

class majorant
{
	static bool isMajority(int[] arr,
							int n, int x)
	{
		int i, counter = 0;


		counter = (n % 2 == 0) ? n / 2 :
									n / 2 + 1;

		for (i = 0; i < counter; i++)
		{
			if (arr[i] == x && arr[i + n / 2] == x)
				return true;
		}
		return false;
	}


	public static void Main()
	{
		int[] arr = { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
		int n = arr.Length;
		int x = 3;
		if (isMajority(arr, n, x) == true)
			Console.Write("majorant is = " + x);
		else
			Console.Write("the majorant does not exist");
	}
}


