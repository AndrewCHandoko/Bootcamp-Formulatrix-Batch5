using Tires;
using Enginee;
using CarTypee;

namespace Cars;

public class Car
{
	public Engine? engine;
	public Tire? tire;
	public CarType? carType;
	public string? merk;
	public int carAge; 
	public int repaired; 
	public int raceWon; 

	public Car(Engine engine, Tire tire, string merk, int carAge, int repaired, int raceWon)
	{
		this.engine = engine;
		this.tire = tire; 
		this.merk = merk;
		this.carAge = carAge; 
		this.repaired = repaired; 
		this.raceWon = raceWon; 
	}
	
	public void Ready()
	{
		Console.WriteLine("Ready to Race");
	}
	public void start()
	{
		Console.WriteLine("Race Start"); 
	}
	
	public void race()
	{
		Console.WriteLine("Brak Bruk");
	}
	
	public void win()
	{
		Console.WriteLine("WINNER");
	}
}