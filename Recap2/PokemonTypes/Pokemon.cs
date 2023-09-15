using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recap2
{
	public class Charmander : TypeDragon
	{
		public Charmander(string? name, int health, int attack, int accuration, int defense, int speed, int ragePower) : base(name, health, attack, accuration, defense, speed, ragePower)
		{
			_name = name;
			_health = health;
			_attack = attack;
			_accuration = accuration;
			_defense = defense;
			_speed = speed;	
			_ragePower = ragePower;
		}		
	}
	
	public class Exeggcute : TypeDragon 
	{
		public Exeggcute(string? name, int health, int attack, int accuration, int defense, int speed, int ragePower) : base(name, health, attack, accuration, defense, speed, ragePower)
		{
			_name = name;
			_health = health;
			_attack = attack;
			_accuration = accuration;
			_defense = defense;
			_speed = speed;	
			_ragePower = ragePower;
		}		
	}
	public class Igglybuff : TypeFairy
	{
		public Igglybuff(string? name, int health, int attack, int accuration, int defense, int speed, int blessingPower) : base(name, health, attack, accuration, defense, speed, blessingPower)
		{
			_name = name;
			_health = health;
			_attack = attack;
			_accuration = accuration;
			_defense = defense;
			_speed = speed;	
			_blessingPower = blessingPower;
		}		
	}
	
	public class MimeJr : TypeFairy
	{
		public MimeJr(string? name, int health, int attack, int accuration, int defense, int speed, int blessingPower) : base(name, health, attack, accuration, defense, speed, blessingPower)
		{
			_name = name;
			_health = health;
			_attack = attack;
			_accuration = accuration;
			_defense = defense;
			_speed = speed;	
			_blessingPower = blessingPower;
		}		
	}
	
	public class Caterpie : TypeBug
	{
		public Caterpie(string? name, int health, int attack, int accuration, int defense, int speed, int exoSkeletonPower) : base(name, health, attack, accuration, defense, speed, exoSkeletonPower)
		{
			_name = name;
			_health = health;
			_attack = attack;
			_accuration = accuration;
			_defense = defense;
			_speed = speed;	
			_exoSkeletonPower = exoSkeletonPower;
		}		
	}
	
	public class Scyther : TypeBug
	{
		public Scyther(string? name, int health, int attack, int accuration, int defense, int speed, int exoSkeletonPower) : base(name, health, attack, accuration, defense, speed, exoSkeletonPower)
		{
			_name = name;
			_health = health;
			_attack = attack;
			_accuration = accuration;
			_defense = defense;
			_speed = speed;	
			_exoSkeletonPower = exoSkeletonPower;
		}		
	}
	
	public class Machop : TypeFighting
	{
		public Machop(string? name, int health, int attack, int accuration, int defense, int speed, int martialArtPower) : base(name, health, attack, accuration, defense, speed, martialArtPower)
		{
			_name = name;
			_health = health;
			_attack = attack;
			_accuration = accuration;
			_defense = defense;
			_speed = speed;	
			_martialArtPower = martialArtPower;
		}		
	}
	
	public class Throh : TypeFighting
	{
		public Throh(string? name, int health, int attack, int accuration, int defense, int speed, int martialArtPower) : base(name, health, attack, accuration, defense, speed, martialArtPower)
		{
			_name = name;
			_health = health;
			_attack = attack;
			_accuration = accuration;
			_defense = defense;
			_speed = speed;	
			_martialArtPower = martialArtPower;
		}		
	}
}