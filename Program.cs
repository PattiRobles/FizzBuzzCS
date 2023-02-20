using System.Text.RegularExpressions;
using System.Collections.Generic;
internal class FizzBuzzProgram
{
	public static string CallFizzBuzz(int number) 
	{
		string answer = "";
		
		if (number % 3 == 0)
		{
			answer += "Fizz";
		}
		if (number % 5 == 0)
		{
			answer += "Buzz";
		}
		if (number % 7 == 0) 
		{
			answer += "Bang";	
		}

		if (number % 11 == 0) 
		{
			answer = "Bong";
		}
		if (number % 13 == 0)
		{
			if (!answer.Contains('B')) 
			{
				answer += "Fezz";
			}
			else 
			{
				answer = answer.Insert(answer.IndexOf("B"), "Fezz");
			} 
		}
		if (number % 17 == 0)
		{
			String[] individualAnswers = Regex.Split(answer, "(?=[A-Z]+)");
			answer = string.Join("", individualAnswers.Reverse());
			//(?=...) patter in Regex called POSITIVE LOOKAHEAD ASSERTION
			//allows you to match a regex pattern without consuming it - i.e. without the char matched desappearing
			
		}
		return answer;	
	}

	public static void Main(string[] args)
	{
		
		int i = 1;
		for (i = 1; i <= 255; i++)
		{
			string answer = CallFizzBuzz(i);

			if (answer.Length > 0)
			{
				Console.WriteLine(answer);
			}
			else
			{
				Console.WriteLine(i);
			}
		}
	}
}

//Dictionary<string, bool> fizzBuzzApplied = new Dictionary<string, bool>(); - use it to let the user 
//have a choice over which rules they wish to implement

	// public static int AskUserInput(string input) {

	// 	Console.WriteLine("Please enter a maximum iteration");
	// 	string userInput = Console.ReadLine().Trim();

	// 	while (userInput == "")  
	// 	{
	// 		Console.WriteLine("Please enter a valid numerical input");
	// 		userInput = Console.ReadLine().Trim();
	// 	} 

		
	// 	bool canParse = int.TryParse(userInput, out int maxIteration); 
	// 	if (!canParse) 
	// 	{
	// 		Console.WriteLine("Please enter a valid numerical input");
	// 	}
	// 	else 
	// 	{
	// 		return maxIteration;
	// 	}
		
	// }

	//Dictionary
	// Dictionary<int, string> fizzBuzzLogic = new Dictionary<int, string>()
	// 	{
	// 		{3, "Fizz"},
	// 		{5, "Fizz"},
	// 		{7, "Fizz"},
	// 		{11, "Fizz"},
	// 	};

	// 	string answer = "";
		
	// 	foreach(int key in fizzBuzzLogic.Keys) 
	// 	{
	// 		if (number % key == 0) 
	// 		{
	// 			answer += fizzBuzzLogic.Values;
	// 		}

	// 	}
