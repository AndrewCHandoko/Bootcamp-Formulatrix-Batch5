namespace Recap.Hero
{
	//Parent Class
	public class Character
	{
		//Variable|Property
	 	//Acces Modifier : Protected (Just for Parent and Child)
		protected string? _name; 
		
		//Call Weapon Class as a Weapon DataTypes
		public Weapon? weapon;
		
		//Constructor 
		public Character(string? name, Weapon? weapon) 
		{
			_name = name;
			this.weapon = weapon;
		}
		
		//Method
		public string? GetName()
		{
			return _name;
		}
		
		public void StandBy()
		{ 
			//Interpolation : Substitutes value of variable into placeholders {} in a string
			Console.WriteLine($"{GetName()} is StandBy");
		}
	}
}