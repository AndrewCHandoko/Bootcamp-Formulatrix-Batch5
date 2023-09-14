using Day8;

public class Program
{
	public static void Main()
	{
		//Delegate using Func, Action & Lambda Expressions (Anonymous)
		//Delegate without Explicitly Declare "public delegate <datatypes> <delegate_name> = <(parameter)>"
		
		//Func
		Func<int, int, int> Example1 = Operand.Adder;
		int exOut1 = Example1.Invoke(4, 5);
		Console.WriteLine("Result is : " + exOut1);
		//Func with Input : int, int and Output : int 
		//Invoke to get the return from the method called Adder in class Operand
		
		Func<string, string> Example2 = Operand.Printer;
		string? exOut2 = (string?)Example2.Invoke("Tes Delegate Func"); 
		Console.WriteLine(exOut2);
		//Func with Input : string and Output : string 
		//Invoke to get the return from the method called Printer in class Operand
		//Func cannot be use witout parameter???
		
		Func<string, string> Example3 = Operand.Printer;
		string in3 = "Tes String Func Delegate";
		string exOut3 = Example3.Invoke(in3);
		Console.WriteLine(exOut3);
		//Func with Input : string and Output : string 
		//Invoke to get the return from the method called Printer in class Operand		
		
		//Action
		Action<string> Example4 = Operand.Print;
		Example4 += Operand.Printing;
		Example4.Invoke("Tes Delegate Using Action");
		//Action with just Input : String 
		//Add the method with += 
		//Invoke the Delegate using Action "Example4" and Give the parameter to fill in the results in Method
		
		
		//Lambda Expression (Anonymous)
			//Using "=>" operand 
			//Still use "Func" & "Action" Keyword 
			//Without Declare Method 
		Func<int, int, string> Example5 = (int a, int b) => (a + b).ToString();
		int result5 = int.Parse(Example5.Invoke(20, 10));
		Console.WriteLine("Result : " + result5);
		bool out5 = (result5 == 30);
		//Using Lambda Expression using "Func" Keyword 
		//Input : int, int and Output : int 
		//Make the Result to Bool 
		
		Func<bool, bool, string> Example6 = (bool a, bool b) => (a == b).ToString();
		Console.WriteLine("Is True??? " + (Example6.Invoke(true, out5)));
		//Input : bool, bool and Output : bool 
		//Invoke to see the Result is true or false 
		
		//Func<string> Example7 = () => Example5 + Example6;
			//Cannot be use, because the Func is using '+' operand among the Func with other datatype
			//Func(int, int, string) + Func(bool, bool, string) == Cannot doing that
			//But, if you want to '+' it, must '+' the Func with same DataTypes 
		
		Func<int> Example8 = () => 5;
		Func<int> Example9 = () => 20;
		Func<int> Example10 = Example8 + Example9;
		Console.WriteLine(Example10.Invoke());
		//Add the "Func" Function 
		
		Delegate[] dels10 = Example10.GetInvocationList();
		int get10 = Example10.GetInvocationList().ToList().Count();
		Console.WriteLine(get10);
		//Get the InvocationList from "Func" Example10 
		//Count the list of Example10, and store to int get10 

		for (int i = 1; i <= get10; i = (i + 1))
		{
			foreach(Func<int> Iteration10 in dels10)
			{
				Console.WriteLine("Iteration " + i + " " + Iteration10.Invoke());	
			}
		}
		//Get the list of the "Func" Example10 
		
		// Example10 = Example10 - Example9;
		// dels10 = Example10.GetInvocationList();
	
		// foreach (Func<string> x in dels10)
		// {
		// 	Console.WriteLine(x.Invoke());
		// }
		
		Action<string> Example11 = (string x) => Console.WriteLine(x);
		Example11.Invoke("Tes Action Anonymous");
		//With Parameter Input : String 

		Action Example12 = () => Console.WriteLine("Success");
		Example12.Invoke();		
		//Without Parameter Input 
		
		
		
		
		
	}
}






// Buat Class Save : 
// 	Dictionary<string, int> simpan = new Dictionary<string, int>();
// 	public void SaveDB(object sender, DataArgs e)
// 	{
// 		simpan.Add(e.name, e.age);
// 	}

// 	public void ShowData()
// 	{
// 		Console.WriteLine("\n Show Data...");
// 		IEnumerator iterator = simpan.GetEnumerator();
// 		while (iterator.MoveNext())
// 		{
// 			Console.WriteLine(iterator.Current);
// 		}
// 		foreach (KeyValuePair<string, int> x in simpan)
// 		{
// 			Console.WriteLine($"Name: {x.Key} , Age: {x.Value} ");
// 		}
// 	}