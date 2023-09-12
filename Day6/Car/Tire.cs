namespace Day6.Car
{
	public class Tire : ICar, ITire
	{
		public string? tire;
		
		// public Tire(string? tire) {		//Constructor dengan Parameter 
		// 	this.tire = tire;
		// }
		
		public void CarEngineRun()
		{
			Console.WriteLine("Tire Engine Run");
		}      
		
		public void CheckTire()
		{
			Console.WriteLine("Tire Checking");
		}
	}
}