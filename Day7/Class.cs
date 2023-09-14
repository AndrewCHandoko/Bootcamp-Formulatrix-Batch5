namespace Day7
{
	public class Hero 
	{
		public int _health;
		
		public static int Attacked(int health, int power)
		{
			int leftHealth = health - power;
			Console.WriteLine("Attacked : " + leftHealth);
			Console.WriteLine("====");
			return leftHealth;
		}
		
		public static int RestoreHP(int health, int power)
		{
			for (int i = health; i < health; i++)
			{
				health = health + 50;	
				Console.WriteLine("HP : " + health);
			}
			Console.WriteLine("==");
			Console.WriteLine("Health : " + health);
			return health;
		}
		
		public int Attacked1(int health, int power)
		{
			int leftHealth = health - power;
			Console.WriteLine(leftHealth);
			Console.WriteLine("====");
			return leftHealth;
			//Console.WriteLine(leftHealth);
		}
		
		public int RestoreHP1(int health, int power)
		{
			for (int i = health; health < 500; i++)
			{
				health = health + 100;	
				Console.WriteLine(health);
			}
			Console.WriteLine("====");
			Console.WriteLine(health);
			return health;
		}
	}
}