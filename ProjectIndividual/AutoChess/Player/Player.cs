using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectIndividual.AutoChess.Interfaces; 

namespace ProjectIndividual.AutoChess.Players
{
	public class Player : IPlayer
	{
		private int _playerID; 
		
		private string? _playerName; 
		
		public Player(int playerID, string? playerName)
		{
			_playerID = playerID; 
			_playerName = playerName; 
		}
		
		public int GetID()
		{
			return _playerID; 
		}

		public bool SetID(int id)
		{
			if (id != 0)
			{
				return true; 
			}
			else 
			{
				return false; 
			}
		}

		public string? GetName()
		{
			return _playerName; 
		}
		public bool SetName(string name)
		{
			if (name != null)
			{
				return true; 
			}
			else 
			{
				return false; 
			}
		}
	}
}