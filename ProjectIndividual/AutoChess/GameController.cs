using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectIndividual.AutoChess.Boards; 
using ProjectIndividual.AutoChess.Interfaces; 
using ProjectIndividual.AutoChess.Enums; 


namespace ProjectIndividual.AutoChess
{ 
	public class GameController
	{
		private Board _board = new(8,8);
		//Make a new Type Board 
		
		private IPlayer? _currentPlayer; 
		
		public void DisplayBoard()
		{
			int x = _board.GetSizeX();
			int y = _board.GetSizeY();
			//Explicitly convert to int 
			
			char[,] board = new char[x,y]; 
			//Make a new Board with Char Array 2D, size of int x & y 
			
			for (int rows = 1; rows <= x; rows++)
			{
				Console.Write("");
				for (int columns = 1; columns <= y; columns++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			//To Iterate the size Board 
		}
		//To Display Board 
		
		public bool AddPLayer(IPlayer player)
		{
			if (player != null)
			{
				return true;
			}
			else 
			{
				return false; 
			}
		}
		//To check if the Instances Player is already exist or not 
		
		public void GetPlayers() 
		{
			List<string> playerName = new(); 
			
			
		}
	}
}