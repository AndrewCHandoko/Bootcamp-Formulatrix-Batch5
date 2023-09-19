using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recap2
{
	public class Type
	{
		protected string? _name;
		
		protected int _health;
		
		protected int _attack;
		
		protected int _accuration;
		
		protected int _defense;
		
		protected int _speed; 
		
		public Type(string? name, int health, int attack, int accuration, int defense, int speed)
		{
			_name = name;
			_health = health;
			_attack = attack;
			_accuration = accuration;
			_defense = defense;
			_speed = speed;	
		}
		
		public string? Name()
		{
			return _name;
		}
		
		public void Choosen(string name)
		{
			Console.WriteLine($"{name} have been choose by you!!!");
		}
		
		public void Attack()
		{
			Console.WriteLine("Attack...");
		}
		
		public void Defense()
		{
			Console.WriteLine("Defense...");
		}
		
		public void Dodge()
		{
			Console.WriteLine("Dodge...");
		}
		
		public void Eat()
		{
			Console.WriteLine("Eat...");
		}
		
		public void Rest()
		{
			Console.WriteLine("Rest...");
		}
	}
	
	public class TypeDragon : Type
	{
		protected int _ragePower;
		
		public TypeDragon(string? name, int health, int attack, int accuration, int defense, int speed, int ragePower) : base(name, health, attack, accuration, defense, speed)
		{
			_name = name;
			_health = health;
			_attack = attack;
			_accuration = accuration;
			_defense = defense;
			_speed = speed;	
			_ragePower = ragePower;
		}
		
		public void DragonRage()
		{
			Console.WriteLine("Initiate Dragon Rage...");
		}
	}
	
	public class TypeFairy : Type 
	{
		protected int _blessingPower; 
		
		public TypeFairy(string? name, int health, int attack, int accuration, int defense, int speed, int blessingPower) : base(name, health, attack, accuration, defense, speed)
		{
			_name = name;
			_health = health;
			_attack = attack;
			_accuration = accuration;
			_defense = defense;
			_speed = speed;	
			_blessingPower = blessingPower;
		}		
		
		public void FairyBlessing()
		{
			Console.WriteLine("Get a Blessing...");
		}
	}
	
	public class TypeBug : Type
	{
		protected int _exoSkeletonPower;
		
		public TypeBug(string? name, int health, int attack, int accuration, int defense, int speed, int exoSkeletonPower) : base(name, health, attack, accuration, defense, speed)
		{
			_name = name;
			_health = health;
			_attack = attack;
			_accuration = accuration;
			_defense = defense;
			_speed = speed;	
			_exoSkeletonPower = exoSkeletonPower;
		}	
		
		public void StrenghthenExoSkeleton()
		{
			Console.WriteLine("Hardening the ExoSkeleton...");
		}		
	}
	
	public class TypeFighting : Type 
	{
		protected int _martialArtPower; 
		
		public TypeFighting(string? name, int health, int attack, int accuration, int defense, int speed, int martialArtPower) : base(name, health, attack, accuration, defense, speed)
		{
			_name = name;
			_health = health;
			_attack = attack;
			_accuration = accuration;
			_defense = defense;
			_speed = speed;	
			_martialArtPower = martialArtPower;
		}		
		
		public void MasteringTheMartialArt()
		{
			Console.WriteLine("Inspired by the Master...");
		}
	}
}