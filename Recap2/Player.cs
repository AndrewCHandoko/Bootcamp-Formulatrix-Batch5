using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recap2
{
	public delegate string User(string uName);
	
	public class Player
	{	
		public static string GetName(string name)
		{
			return name;
		}	
	}
}