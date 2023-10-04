using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectIndividual.AutoChess;
using ProjectIndividual.AutoChess.Players;

namespace ProjectIndividual;

public class Program
{
	public static void Main()
	{
		GameController gameController = new();

		Console.Write("Player 1 Name : "); 
		string? p1 = Console.ReadLine();
		Console.WriteLine();
		Console.Write("Player 2 Name : ");
		string? p2 = Console.ReadLine();
		
		Player player1 = new(1111, p1); 
		Player player2 = new(1112, p2); 
		
		Console.WriteLine();
		
		Console.WriteLine($"{player1.GetName()} Joined The Game");
		Console.WriteLine($"{player2.GetName()} Joined The Game");
		gameController.DisplayBoard();
	}
}