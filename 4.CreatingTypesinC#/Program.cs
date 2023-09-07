//Abstract Class 
//Stack & Heap Memory Type 
using Characterr;
using Tankerr;
using SharpShoterr;

public class Program
{
	static void Main()
	{
		Tanker Luhk = new();
		Luhk.name = "Luhk";
		Luhk.health = 7000;
		Luhk.attack = 120;
		Luhk.defense = 790;
		Console.WriteLine(Luhk.name + "Join the Game");
		Luhk.ReadytoDefense();
		Luhk.Backward();
		Luhk.ActivateShield();		

		SharpShooter Widow = new();
		Widow.name = "Widow";
		Widow.health = 2500;
		Widow.attack = 550;
		Widow.defense = 120;
		Console.WriteLine(Widow + "Join the Game");
		Widow.ReadytoShoot();
		Widow.Fly();
		Widow.Left();
		Widow.Forward();
		
		Widow.ShotThem();
		if (Widow.attack == 550)
		{
			Luhk.health = Luhk.health - Widow.attack; //Memory Type -> Stack -> Change the Value 
		}
		else
		{
			Console.WriteLine("Attack Missed");
		}
		Console.WriteLine(Luhk.name + " Health is " + Luhk.health + " Left");
		
		//Memory Type Stack & Heap 
		Tanker Think = new(); //Create new Instance "Think"
		Think.name = "Think"; //Define the Name, Stack 1 with Address (Ex: 0x123) and value "Think" in Heap 1
		
		Tanker Nhasto = Think; //Create new Instance by Copying the Instance "Think" 
		Nhasto.name = "Nhasto"; //Define the new Name, Stack 2 and copy the Address (Ex: 0x123), the new value "Nhasto" in Heap 2 (New Memory Heap)
		//value "Think" in Heap 1 is deallocate by garbage collector from Heap Memory 
		Console.WriteLine(Nhasto.name); //Stack 3 and copy the address (Ex: 0x23), get the value in Heap 2 with Address (Ex: 0x123), Heap 2 = "Nhasto" 
		Console.WriteLine(Think.name); //Stack 4 and copy the address (Ex: 0x23), get the value in Heap 2 with Address (Ex: 0x123), Heap 2 = "Nhasto"
	}
}

