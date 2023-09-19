using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recap2
{	
	public class Save
	{
		Dictionary<string, int> savedData = new Dictionary<string, int>(5);
		
		public void Add(string? uName)
		{
			int i = 0; 
			i = i + 1; 
			savedData.Add(uName, i);
		}
		
		public void ShowData()
		{
			foreach (KeyValuePair<string, int> x in savedData)
			{
				Console.WriteLine(x.Value + " " + x.Key);
			}
		}
	}
}