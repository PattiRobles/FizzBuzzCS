Console.WriteLine("Please enter a maximum number.");
int maxNumber = int.Parse(Console.ReadLine()!); 

Console.WriteLine("Please state which FizzBuzz logic you would like to apply. \nChoose from fizz, buzz, bang, fezz and bong. Type as many as you want to apply");
string logicSelection = Console.ReadLine()!.Trim().ToLower();

Dictionary<string, bool> fizzBuzzRules = new Dictionary<string, bool>()
{
	{"fizz", false},
	{"buzz", false},
	{"bang", false},
	{"bong", false},
	{"fezz", false},
	{"reverse", false}
	
};

foreach(KeyValuePair <string, bool> rule in fizzBuzzRules ) 
{
	fizzBuzzRules[rule.Key] = logicSelection.Contains(rule.Key);
}

for (int i = 1; i <= maxNumber; i++) 
{
	List<string> answer = new List<string>();
		
		if (i % 3 == 0 && fizzBuzzRules["fizz"])
		{
			answer.Add("Fizz");
		}
		if (i % 5 == 0 && fizzBuzzRules["buzz"])
		{
			answer.Add("Buzz");
		}
		if (i % 7 == 0 && fizzBuzzRules["bang"])
		{
			answer.Add("Bang");
		}
		if (i % 11 == 0 && fizzBuzzRules["bong"])
		{
			 answer.Clear();
			 answer.Add("Bong");
		}
		if (i % 13 == 0 && fizzBuzzRules["fezz"])
		{
			if (!string.Join("", answer).Contains('B')) 
			{
				answer.Add("Fezz");
			}
			else 
			{
				string joinedAnswer = string.Join("", answer);
				int indexOfB = joinedAnswer.IndexOf('B');
				string updatedFezzString = joinedAnswer.Insert(indexOfB, "Fezz"); // NOT WORKING
			} 
		}
		if (i % 17 == 0 && fizzBuzzRules["reverse"])
		{
			answer.Reverse();
		}

		Console.WriteLine(answer.Count > 0 ? string.Join("",answer) : i);
}

