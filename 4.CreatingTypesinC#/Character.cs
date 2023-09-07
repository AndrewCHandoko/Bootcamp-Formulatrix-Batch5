using Tankerr;

namespace Characterr
{
	public abstract class Character
	{
		public string? name;
		public int health;
		public int attack;
		public int defense;
		
		public abstract void Fly();
		
		public void Forward()
		{
			Console.WriteLine("Move to Forward");
		}
		
		public void Backward()
		{
			Console.WriteLine("Move to Backward");
		}
		
		public void Right()
		{
			Console.WriteLine("Move to the Right Side");
		}
		
		public void Left()
		{
			Console.WriteLine("Move to the Left Side");
		}
	}
}