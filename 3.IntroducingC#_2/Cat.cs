using Animals;

namespace Cats
{
	public class Cat : Animal
	{
		public double catSize;
		//Override 
		public override void MakeSound() //override the same method from parent class : animal, and changes the value | use "override"
		{
			//base.MakeSound(); //for calling the method from parent class with same value and dont override the method with new value 
			Console.WriteLine("Meow"); //override the method with new value 
		}		
	}
}