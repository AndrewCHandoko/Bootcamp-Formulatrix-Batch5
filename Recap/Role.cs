namespace Recap.Hero
{
	//Child Class
	//Inherit from Parent (Character)
	public class Role : Character
	{
		public string? role;
		
		public Role(string? name, Weapon? weapon, string? role) : base(name, weapon)
		{
			this.role = role;
		}
		
		public void getRole()
		{
			Console.WriteLine(role);
		}
	}
}