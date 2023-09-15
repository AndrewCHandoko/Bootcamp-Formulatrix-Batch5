using Recap.Hero;

public class Program 
{
	
	
	static void Main()
	{
		Console.WriteLine("Tes");
		
		Weapon GreatSword1 = new Weapon("The Arthur Sword", "Great Sword");
		
		Character Tigreal = new Character("Tigreal", GreatSword1);
		
		Role Tank1 = new	Role(Tigreal.GetName(), GreatSword1, "Tank1");
		
		Console.WriteLine(Tigreal.GetName());
		Tigreal.StandBy();
		Tigreal.weapon?.Attack();
		Console.WriteLine(Tigreal.weapon?.getWPName());
		Console.WriteLine(GreatSword1.getWPName());
		Console.WriteLine(Tigreal.weapon?.getWPType());
		Tank1.getRole();
		
	}
}