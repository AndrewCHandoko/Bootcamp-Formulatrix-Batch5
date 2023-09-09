using Cars;
using Enginee;
using EType;
using Tires;

public class Program
{
	static void Main()
	{
		DieselEngine dieselEngine1 = new();
		Engine E1 = new Engine(dieselEngine1, "Gasoline", 5, 200);
		Tire T1 = new Tire("Michellin", "Rain");
		Car Racer1 = new Car(E1, T1 ,"Honda", 3, 7, 2);
		
		ElectricEngine electricEngine2 = new();
		Engine E2 = new Engine(electricEngine2, "Solar", 10, 198);
		Tire T2 = new Tire("Bridgestones", "Dry");
		Car Racer2 = new Car(E2, T2 ,"Audi", 10, 15, 7);
		
		Console.WriteLine("Racer1 Use");
		E1.Heating();
		E1.EngineCheck(dieselEngine1, "Gasoline", 5, 200);
		
		Console.WriteLine("Racer2 Use");
		E2.Heating();
		E2.EngineCheck(electricEngine2, "Solar", 10, 198);
		
		Racer1.Ready();
		Racer1.start();
		
		Racer2.Ready();
		Racer2.start();
		
		if (Racer1.engine.speed > Racer2.engine.speed)
		{
			Console.WriteLine("Racer1 is WINNER");
		}
		else
		{
			Racer2.win();
		}
		
		
	}
}