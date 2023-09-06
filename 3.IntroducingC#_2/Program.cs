//Override & Method Hiding 
//Interface & Casting Datatype 
//Interface Segregation Principle -> Memecah Interface/Syarat/Contract/Abstract yang lebih besar menjadi yang lebih spesifik
//Upcast & Downcast with Explicit & Implicit Way

using Animals;
using Cats;
using Ants;
using Elephants;
using Dogs;
using Fishes;

class Program
{
	static void Main()
	{
		Animal animal = new(); //new instance animal
		animal.MakeSound(); //call method makesound from parent class : animal 

		//Overriding 
		Cat cat = new(); //new instance cat 
		cat.MakeSound(); //override the method makesound from parent class : animal to method makesound from child class : cat 

		Ant ant = new(); //new instances ant 
		ant.MakeSound(); //call method from parent class : animal and not override the method from parent class : animal 

		//Method Hiding
		Elephant elephant = new();
		elephant.Eat(); //hiding the parent method, without override or changes the method value from parent class 
		animal.Eat(); //call method from parent class, to see the method is just hide and not being override 
		
		Dog dog = new();
		dog.MakeSound();
		dog.SpeedRun();
		dog.AttackingOthers();
		
		//Casting 
		IStrong doggy = dog; //from instance 'dog', make a new instance 'doggy' and cast them with the 'dog' datatype
		doggy.AttackingOthers();
		
		IFast doggo = dog; //from instance 'dog', make a new instance 'doggo' and cast them with 'dog' datatype
		doggo.SpeedRun();
		
		//Interface Segregation Principle 
		Fish Magicarp = new();
		Magicarp.BigBone();
		
		Shark Sharky = new();
		Sharky.BigBone();
		Sharky.StrongFin();
		
		//Upcast & Downcast
		//Upcast = Small Size Type -> Big Size Type 
		Cat Orange = new();
		Orange.age = 25;
		double catAge = Orange.age; //Implicit 
		Console.WriteLine(catAge);
		
		Orange.catSize = 25.3;
		int size = (int) Orange.catSize; //Explicit
		Console.WriteLine(size);
		
		//Why Dont Use Double 
		
	}
}



// void Main()
// {
// 	int a = 1; //a + b = 3
// 	int b = 2;
// 	bool resultab = 3==(a+b); //true
// 	resultab.Dump();
	
// 	float c = 0.1f; //c+d = 0.3f 
// 	float d = 0.2f;
// 	bool resultcd  = 0.3f==(c+d); // false true
// 	resultcd.Dump();
	
// 	double e = 0.1; //e+f = 0.300000000004 
// 	double f = 0.2;
// 	bool resultef  = 0.3==(e+f); // false
// 	resultef.Dump();
// }

// // You can define other methods, fields, classes and namespaces here