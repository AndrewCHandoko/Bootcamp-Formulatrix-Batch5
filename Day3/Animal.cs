using Cats;
using Ants;
using Elephants;
using Dogs;
using Fishes;

namespace Animals
{
	public class Animal
	{
		public string? name;
		public int age;

		//Override 
		public virtual void MakeSound() //in parent class, use "virtual" in the method 
		{
			Console.WriteLine("Animal Makesound");
		}

		public void Eat()
		{
			Console.WriteLine("Animal Eat");
		}
	}
}
