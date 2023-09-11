using Day5;

public class Program
{
	static void Main()
	{
		//Var
		Laptop Acer = new Laptop("Acer");
		Acer.price = 3000000;
		float discount = 0.35f;
		float v = Acer.price * discount;
		var priceAfterDiscount = v;	//Become float DataTypes
		Console.WriteLine(priceAfterDiscount);
		
		Console.WriteLine("======"); 
		
		var Asus = new Laptop("Asus"); //Become New Instances for Class Laptop
		Asus.merk = "Asus";
		Asus.price = 2500000;
		Console.Write(Asus.merk + " ");
		Console.WriteLine(Asus.price);
		
		Console.WriteLine("======"); 
		
		var tes = "tes";
		Console.WriteLine(tes);
		Console.WriteLine(tes.GetType()); //Get the DataType
		
		//
		Console.WriteLine("");
		//
		
		//Reference Type 
		Laptop Dell = new Laptop("Dell"); //Create new instance Dell 
		AddLaptop.Add(Dell); //Call Method from Class AddLaptop.Add(Using the Instance want to copy)
		Console.WriteLine(Dell.merk); //Output : Lenovo | Because the reference is same and reference to Lenovo.Merk
		
		Console.WriteLine("======"); 
		
		//Ref : Assigned Variable 
		Dell.price = 4500000; //Value Type | Assign Value for the Variable Dell.Price
		AddLaptop.Add(ref Dell.price); //Call Method AddLaptop.Add(Ref to Dell.Price as the value for Param)
		Console.WriteLine(Dell.price); //Output : 2500000 | Because it copy the Address/Reference (Dell.Price Reference to priceRef value)
		
		Console.WriteLine("======"); 
		
		//Ref Out : Variable can be UnAssigned, but in the Method must be assigned
		Laptop HP = new Laptop("HP"); //Create new Instance HP 
		//HP.price; not assign the value 
		AddLaptop.AddOut(out HP.price); //Parsing the HP.price, but the value not assigned first 
		Console.WriteLine(HP.price); //Get the Address from priceRef and get the same value as it 
		
		Console.WriteLine("======"); 
		
		//Ref In : ReadOnly 
		//For optimization, because not allocate new memory 
		Laptop Huawei = new Laptop("Huawei"); //Create new Instance Huawei 
		Huawei.price = 7800000;
		AddLaptop.AddIn(Huawei.price); //Can be UnAssigned first, but the value will be default : 0
		Console.WriteLine(Huawei.price); //Get the value same as the Reference/Address (newPriceRef & priceRef)
		
		//
		Console.WriteLine(""); 
		//
		
		//Parsing (Parse & TryParse)
		//Parsing = Change the Datatypes (String to Int)
		//Not Safety 
		Huawei.benchmarkScore = "567000"; //String 
		Console.WriteLine(Huawei.benchmarkScore.GetType());
		int antutuScore = int.Parse(Huawei.benchmarkScore); //Parse into Int 
		Console.WriteLine(antutuScore); 
		Console.WriteLine(antutuScore.GetType()); //Get the DataType 
		
		Console.WriteLine("======"); 
		
		//Safety 
		//Check if the string can be parse to int or not 
		Huawei.benchmarkScore = "700000"; //String 
		bool status = int.TryParse(Huawei.benchmarkScore, out int result); //Try Parsing, but return the value with true or false 
		Console.WriteLine(result); //Will result 700000 but in int DataType, because can parse to int 
		Console.WriteLine(status); //Will result True, because can be parse into int 
		Console.WriteLine(antutuScore.GetType()); //Get the DataType
		
		Console.WriteLine("======"); 
		
		Huawei.benchmarkScore = "8500aa"; //String 
		bool status1 = int.TryParse(Huawei.benchmarkScore, out int result1); //Try Parsing, but return the value with true or false 
		Console.WriteLine(result1); //Will result 0 (Default Value), because it cannot parse to int (String bencmarkScore contan 'aa')
		Console.WriteLine(status1);	//Will result False, because cannot be parse into int 
		Console.WriteLine(antutuScore.GetType()); //Get the DataType 
		
		//
		Console.WriteLine(""); 
		//
		
		//Object (Box & Unbox)
		Laptop Advan = new Laptop("Advan");
		Advan.price = 2500000;
		Console.WriteLine(Advan.price.GetType());
		object newPrice = Advan.price; //Boxing 
		Console.WriteLine(newPrice);
		Console.WriteLine(newPrice.GetType()); 
		int oldPrice = (int)newPrice; //Unboxing 
		
		Console.WriteLine("======"); 
		
		Advan.benchmarkScore = "2500000";
		Console.WriteLine(Advan.benchmarkScore.GetType());
		object newPrice1 = Advan.benchmarkScore; //Boxing 
		Console.WriteLine(newPrice1);
		Console.WriteLine(newPrice1.GetType()); 
		int oldPrice1 = (int)newPrice1;
		
		Console.WriteLine("======");  
		
		
			
	}
}