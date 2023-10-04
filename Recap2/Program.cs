using Recap2;

public class Program
{
	public static void Main()
	{
		Save save = new();
		Process process = new(); 
		Charmander charmanders = new("Charmander", 15000, 600, 200, 400, 210, 770);
		Exeggcute exeggcute = new("Exeggcute", 8000, 500, 290, 1000, 300, 500);
		Igglybuff igglybuff = new("Igglybuff", 3000, 300, 750, 250, 1020, 700);
		MimeJr mimeJr = new("MimeJr", 6500, 500, 450, 600, 500, 200);
		Caterpie caterpie = new("Caterpie", 4500, 390, 800, 650, 500, 350);
		Scyther scyther = new("Scyther", 5000, 400, 550, 600, 430, 500);  
		Machop machop = new("Machop", 12000, 590, 700, 800, 350, 1000);  
		Throh throh = new("Throh", 15000, 850, 200, 600, 170, 1500);
		
		//tes1 :
		Console.Write("Username : ");
		Input_UserName : 
		var userName = Console.ReadLine();
		Console.WriteLine(userName);
		process.SavingProcess += save.AddData;	
		
		Console.Clear();
		 
		if (userName is not null)
		{
			User player = Player.GetName;
			player.Invoke(userName);
			Console.WriteLine($"Welcome to the World {userName}");
			process.SavingData(1, userName);	
			/*int cek = save.savedData.Count;
			if (cek == 0)
			{
				cek = 1; 
				Console.WriteLine($"cek if = {cek}");
				process.SavingData(cek, userName);
			}
			else 											//Perulangan untuk cek dan tambah user
			{
				for (int i = cek; i <= cek; i++)
				{
					cek = i++;
					Console.WriteLine($"cek else = {cek}");
					process.SavingData(cek, userName);
				}
			}*/
			//Pake invocation List, di cek terus kalo sama -=
		}
		else 
		{
			Console.Write("Please enter your Username : "); 
			goto Input_UserName; 
		}
		
		Console.WriteLine();
		
		Console.WriteLine("1. Charmander");
		Console.WriteLine("2. Exeggcute");
		Console.WriteLine("3. Igglybuff");
		Console.WriteLine("4. MimeJr");
		Console.WriteLine("5. Caterpie");
		Console.WriteLine("6. Scyther");
		Console.WriteLine("7. Machop");
		Console.WriteLine("8. Throh");
		Console.Write("Choose Your Starter Pokemon : "); 
		string? pokeStarter = Console.ReadLine(); 
		bool checkStarter = int.TryParse(pokeStarter, out int starter);
		if(starter == 1)
		{
			charmanders.Choosen(charmanders.Name());
		}
		else if(starter == 2)
		{
			exeggcute.Choosen(exeggcute.Name());
		}
		else if(starter == 3)
		{
			igglybuff.Choosen(igglybuff.Name());
		}
		else if(starter == 4)
		{
			mimeJr.Choosen(mimeJr.Name());
		}
		else if(starter == 5)
		{
			caterpie.Choosen(caterpie.Name());
		}
		else if(starter == 6)
		{
			scyther.Choosen(scyther.Name());
		}
		else if(starter == 7)
		{
			machop.Choosen(machop.Name());
		}
		else if(starter == 8)
		{
			throh.Choosen(throh.Name());
		}														
		else 
		{
			Console.WriteLine("Choose Your Starter : ");
		}	
		
		save.ShowData();
		
		//goto tes1; 
	}
}