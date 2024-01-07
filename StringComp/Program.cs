using System;

namespace StringCompProgramm 
{
	public static class StrComprassionClass
	{
		static void Main()
		{			
			Console.Write("Enter the string: ");
			string inputString = Console.ReadLine();
			
			string compressedString = CompressString(inputString);
			
			Console.WriteLine("Compressed String: " + compressedString);
		}

		public static string CompressString(string input)
		{
			if (string.IsNullOrEmpty(input))
			{
				return ""; 
			}

			int count = 1;
			char currentChar = input[0];
			string result = "";

			for (int i = 1; i < input.Length; i++)
			{
				if (input[i] == currentChar)
				{					
					count++;
				}
				else
				{					
					result += $"({count}, {currentChar}) ";
					
					count = 1;
					currentChar = input[i];
				}
			}
			
			result += $"({count}, {currentChar}) ";

			return result.Trim(); 
		}
	}
}