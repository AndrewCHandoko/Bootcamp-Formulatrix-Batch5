using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectIndividual.AutoChess.Interfaces
{

	public interface IPlayer
	{
		public int GetID();

		public bool SetID(int id);

		public string? GetName();

		public bool SetName(string name);
	}
}