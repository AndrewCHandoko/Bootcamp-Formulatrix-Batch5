namespace Recap.Hero
{
	//New Class to make a Weapon DataType, assign to Class Character to get Weapon Data 
	public class Weapon
	{
		protected string? _wpName;
		
		protected string? _wpType;
		
		public Weapon(string? wpName, string? wpType)
		{
			_wpName = wpName;
			_wpType = wpType;
		}
		
		public string? getWPName()
		{
			return _wpName;
		}
		
		public string? getWPType()
		{
			return _wpType;
		}
		
		public void Attack()
		{
			//Concatenate : Combine string
			Console.WriteLine("Attack using " + getWPName());
		}
	}
}