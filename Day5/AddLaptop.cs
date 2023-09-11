namespace Day5
{
	public class AddLaptop
	{
		//Reference Type 
		public static void Add(Laptop Lenovo) //Copy the Reference/Address
		{
			Lenovo.merk = "Lenovo"; //Initiate the Value for merk 
			Console.WriteLine(Lenovo.merk); //Output = Lenovo
		}
		
		//Example of 'Ref' 
		public static void Add(ref int priceRef) //Pass by Reference 
		{
			//Ref must be assigned first the value of variable before parsing
			//priceRef is save the assigned value before, priceRef = 4500000
			priceRef = priceRef - 2000000; //Changes the value (Ref can change value and just read the value (ReadOnly))
			Console.WriteLine(priceRef); //Output = 2500000
		}
		
		//Overloading : Same Method (Name) with Different Parameter 
		//Overloading cannot be use in Ref, because cannot define the overload method that differs only in modifiers (out and ref)
		
		//Example of 'Ref Out' 
		public static void AddOut(out int priceRef) //Pass by Reference 
		{
			priceRef = 7500000; //Assign the Value for Variable PriceRef
			Console.WriteLine(priceRef); //Output will be the same as the assigned priceRef
		}
		
		//Example of 'Ref In' 
		public static void AddIn(in int priceRef) //Pass by Reference 
		{
			int newPriceRef = priceRef - 500000; //Can do this, because it change the new variable value, not change the value from priceRef variable
			Console.WriteLine(newPriceRef); //New Variable with new Value 
			Console.WriteLine(priceRef); //Just ReadOnly the value, cannot changed the value
		}
	}
}