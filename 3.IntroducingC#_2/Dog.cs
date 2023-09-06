using Animals;

namespace Dogs
{
	//Interface
	public interface IStrong
	{
		void AttackingOthers();
	}
	
	public interface IFast
	{
		void SpeedRun();
	}
	
	//Child Class : Dog with -> Inherit Parent Class (Animal) & Contract/Syarat/Interface (Strong & Fast) 
	public class Dog : Animal, IStrong, IFast
	{
		public string? dogTag;
		
		public void AttackingOthers() //Syarat Strong
		{
			Console.WriteLine("Bite Them...");
		}
		
		public void SpeedRun() //Syarat Fast 
		{
			Console.WriteLine("Chase Them...");
		}
		
		public override void MakeSound()
		{
			Console.WriteLine("Bark...");
		}
	}
}