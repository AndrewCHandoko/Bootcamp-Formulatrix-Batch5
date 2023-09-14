using Day7;

public class Program
{
	public static void Main()
	{
		MyDelegate DelMiya = Hero.Attacked;
		// DelMiya += Hero.RestoreHP;
		int x = DelMiya.Invoke(500, 200);
		Console.WriteLine("===========");
		DelMiya += Hero.RestoreHP;
		DelMiya.Invoke(x, 100);
		
		Console.WriteLine("===========");
		
		Hero miya = new Hero();
		MyDelegate DelMiya2 = miya.Attacked1;
		DelMiya2 += miya.RestoreHP1;
		Invoked.Invoker(DelMiya2, 300, 100);
		
	}
}