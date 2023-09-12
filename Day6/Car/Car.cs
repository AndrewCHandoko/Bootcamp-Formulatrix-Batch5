namespace Day6.Car
{
	public class Car : ICar
	{
		public string? carName;
		
		public void CarEngineRun()
		{
			Console.WriteLine("Car Engine Run");        //Default Compiler
		}
	}
	
	public class CarRun
	{
		public string? tes;
		
		// public CarRun(string tes)
		// {
		// 	this.tes = tes;
		// }
		
		public void CarRunning()
		{
			Console.WriteLine("Car Running");
		}
	}
	
	public class CarCar<T, T2> 
	where T : ITire 
	where T2 : struct
	{
		public T? name;
		
		public T2 year;		
		
		public CarCar(T a, T2 b)
		{
			name = a;
			year = b;
		}	
		
		public void Check()
		{
			name?.CheckTire();
		}
		
		public T2 CheckYear()
		{
			return year;
		}
	}
}