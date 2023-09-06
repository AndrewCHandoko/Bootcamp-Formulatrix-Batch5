using Animals;

namespace Elephants
{
	public class Elephant : Animal
	{
		public string race = "Siam";
		public override void MakeSound() 
		{
			Console.WriteLine("Wooooo");
		}
		public void Run() 
		{
			Console.WriteLine("Run..");
		}
		//Method Hiding 
		public new void Eat() //recommended using : new, kalau ga ya gapapa, untuk mempermudah baca code 
		{
			Console.WriteLine("Eating Fruit");
		}	
	}
}