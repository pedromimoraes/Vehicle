using System;
using System.Text;

namespace Vehicle.Entities.Services
{
public class GeneratePlateService
{
	private static readonly Random random = new Random();
	public static string Plate()
	{
		
		StringBuilder builder = new StringBuilder(7);
		
		for(int i = 0; i < 7; i++)
		{
			if(i == 3 || i == 5 || i == 6)
			{
				builder.Append(random.Next(0, 10));
			}
			else
			{
				builder.Append((char)random.Next('A', 'Z' + 1));
			}
		}
		return builder.ToString();
	}
}
}