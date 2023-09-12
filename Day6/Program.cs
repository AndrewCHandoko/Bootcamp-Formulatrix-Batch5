using System.Collections;
using Day6.Car;

public class Program
{
	public static void Main()
	{
		//Generic & Generic Constraint 
		Checker.Check1(3);					//Type Struct
		Checker.Check("String");			//Type Class
		Checker.Check1(true);				//Type Struct
		Checker.Check1(3.0f);				//Type Struct
		Checker.Check1(3.0M);				//Type Struct
		Checker.Check(new Car());			//Type Class
		Checker.Check(new Tire());			//Type Class
		Checker.Check(new Tire(),3);		//Type Class & Struck
		
		//Generic in Collection 
		List<ICar> list = new List<ICar>();
		list.Add(new Car());
		list.Add(new Toyota());
		list.Add(new Honda());
		
		list[0].CarEngineRun();
		list[1].CarEngineRun();
		list[2].CarEngineRun();
		
		List<Yamaha> list1 = new List<Yamaha>();
		list1.Add(new Yamaha());
		list1[0].name = "Yamaha";
		Console.WriteLine(list1[0].name);

		Dictionary<int, string> dict = new();
		dict.Add(3,"3");
		dict.Add(4,"5");
		//dict.Add(3,"10"); 				//<- exception, same key item added
		
		//Not Generic Collection 
		ArrayList list2 = new ArrayList(); 
		list2.Add(3);
		list2.Add("3");
		list2.Add(true);
		list2.Add(3.0);
		list2.Add(new CarRun());
		
		Console.WriteLine(list2[0]);
		
		((CarRun)list2[4]).CarRunning();
		//((Car)list2[1]).CarEngineRun();
		
		//Generic Class 
		CarCar<Tire, int> car2 = new CarCar<Tire,int>(new Tire(),3);
		car2.Check();
		
		
	}
}