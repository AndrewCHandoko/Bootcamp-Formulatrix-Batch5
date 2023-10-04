using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectIndividual.AutoChess.Boards
{
	public class Board
	{
		private readonly int _sizeX; 
		//Just to read size X in Board
		
		private readonly int _sizeY; 
		//Just to read size Y in Board
		
		public Board(int sizeX, int sizeY)
		{
			_sizeX = sizeX;
			_sizeY = sizeY; 
		}
		//Constructor for Board with Parameters Size of X and Y 
		
		public int GetSizeX()
		{
			return _sizeX;	
		}
		//To get size X 
		
		public int GetSizeY()
		{
			return _sizeY;	
		}	
		//To get size Y 	
		
		public bool SetPiecesChar()
		{
			throw new NotImplementedException();
		}
	}
}