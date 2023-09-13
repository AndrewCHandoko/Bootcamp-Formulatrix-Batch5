namespace Day7
{
	public delegate int MyDelegate(int health, int power);
	
	public class Invoked
	{
		public static void Invoker(MyDelegate del, int health, int power)
		{
			del.Invoke(health, power);
		}	
	}
}