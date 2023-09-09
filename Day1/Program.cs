using HewanAir;
using HewanDarat;

public class Program
{
	static void Main()
	{
		//Kucing 1
		Cat cibi = new Cat(); 
		cibi.Meow();
		cibi.name = "cibi";
		String Perintah = "Lets Jump" + " " + cibi.name;
		Console.WriteLine(Perintah);

		//Kucing 2
		Cat burhan = new Cat();
		burhan.name = "burhan";
		Console.WriteLine(burhan.name);
		burhan.Jump();
		
		//Ikan 1
		Fish tongkol = new Fish();
		tongkol.age = 10;
		tongkol.isStripe = true;
		
		if (tongkol.isStripe==true) 
		{
			Console.WriteLine("Ikan Besar");
		}
		else 
		{
			Console.WriteLine("Ikan Kecil");
		}
	}
}