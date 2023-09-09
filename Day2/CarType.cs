//INHERITANCE
namespace CarTypee
{
	public class CarType //Parent Class
	{
		public string? TypeCar;
		public string? TransmissionType;
	}
	
	public class RaceCar : CarType //Child Class 1
	{
		public bool isAerodynamic;
		
		public void UseTurbo()
		{
			Console.WriteLine("Turbo Activated");
		}
	}
	
	public class MuscleCar : CarType //Child Class 2
	{
		public bool isResilient;
		
		public void HitTheCar()
		{
			Console.WriteLine("Hit Other Car");
		}
	}
}