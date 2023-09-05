namespace Tires
{
	public class Tire
	{
		public string? merk;
		public string? type;

		public Tire(string merk, string type)
		{
			this.merk = merk;
			this.type = type;
		}
		
		public void isGood()
		{
			Console.WriteLine("Tires in Good Condition");
		}
	}
}