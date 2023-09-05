using EType;

namespace Enginee
{
	public class Engine //default : Internal 
	{
		public EngineType type; //default : Private //Call Interface EngineType as DataType
		public string? fuelType; 
		public int engineAge; 
		public int speed; 
		
		public Engine(EngineType type, string fuelType, int engineAge, int speed)
		{
			this.type = type; 
			this.fuelType = fuelType; 
			this.engineAge = engineAge; 
			this.speed = speed; 
		}
		
		public void Heating()
		{
			type.engineRun(); //Get the method from Interface EngineType
		}
		
		public void EngineCheck(EngineType type, string fuelType, int engineAge, int speed)
		{
			Console.WriteLine("Starting Engine");
		}
	}	
}