namespace Day6.Car
{
	public class Toyota : ICar
	{
		public void CarEngineRun()
		{
			Console.WriteLine("Toyota Engine Run");
		}
	}
	
	public class Honda : ICar 
	{
		public void CarEngineRun()
		{
			Console.WriteLine("Honda Engine Run");
		}
	}
	
	public class Yamaha 
	{
		public string? name;	
	}
	
	public class Daihatsu
	{
		public string name1 = "Car1";
	}
}