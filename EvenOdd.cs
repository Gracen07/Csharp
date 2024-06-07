using System;
using Hello;
public class EvenOdd
{
	public EvenOdd()
	{
        Console.WriteLine("Enter a number:");
        int b = int.Parse(Console.ReadLine());
		if (b % 2 == 0)
		{
			Console.WriteLine("Even");
		}
		else
		{
			Console.WriteLine("ODD");
		}

	}
	
}
