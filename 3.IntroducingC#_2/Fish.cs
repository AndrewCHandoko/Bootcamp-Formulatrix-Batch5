//Interface Seggregation Principle
using Animals;
using Dogs;

namespace Fishes
{
	// public interface water     //Example Interface with a big abstraction
	// {
		// void BigBone();
		// void LiveinSea();
		// void SmallBone();
		// void LiveinLake();
	// }

	//Then we break it, to become more specific and less abstraction 	
	public interface ISaltWater 
	{
		void BigBone();
		void LiveinSea();
	}
	
	public interface IFreshWater 
	{
		void SmallBone();
		void LiveinLake();
	}	
	
	public class Fish : ISaltWater
	{
		public void BigBone()
		{
			Console.WriteLine("Strong BackBone");
		}
		public void LiveinSea()
		{
			Console.WriteLine("Being Salty");
		}
	}
	
	public class Shark : Fish
	{
		public void StrongFin()
		{
			Console.WriteLine("Scaring Human");
		}
	}
}