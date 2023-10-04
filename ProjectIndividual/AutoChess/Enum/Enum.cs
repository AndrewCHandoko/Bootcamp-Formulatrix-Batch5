using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectIndividual.AutoChess.Enums
{
	public class Enum
	{
		public enum GameStatus
		{
			NOT_STARTED = 0,
			PLAYER_REGISTER = 1,
			PLACE_PIECES = 2,
			ROUND_STARTED = 3,
			ROUND_ONGOING = 4,
			ROUND_FINISHED = 5,
			GAME_FINISHED = 6
		}
		
		public enum PieceStatus
		{
			INITIALIZED = 1,
			MOVING = 2,
			ARMOR_UPGRADE = 3,
			ATTACKING = 4,
			DAMAGED = 5,
			DEAD = 6			
		}
		
		public enum ClassType
		{
			ASSASSIN = 1, 
			MECH = 2, 
			WARRIOR	= 3				
		}
		
		public enum SpeciesType
		{
			DEMON = 1, 
			GOBLIN = 2, 
			ORC	= 3 
		}
	}
}