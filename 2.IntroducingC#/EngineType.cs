//INTERFACE
namespace EType
{
	public interface EngineType
	{
		void engineRun();
	}
	
	class DieselEngine : EngineType
	{
		public void engineRun()
		{
			Console.WriteLine("Diesel");
		}
	}
	
	class ElectricEngine : EngineType
	{
		public void engineRun()
		{
			Console.WriteLine("Electric");
		}
	}
}