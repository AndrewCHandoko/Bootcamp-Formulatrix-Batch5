using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recap2
{	
	public class Save
	{
		public Dictionary<int, string?> savedData = new Dictionary<int, string?>(1);
		
		public void AddData(object? sender, EventData eventData)
		{
			savedData.Add(eventData.uID, eventData.uName);
			/*try
			{
				int x = savedData.Count;
				Console.WriteLine("x = " + x);
				int y;
				if (x == 0)
				{
					y = 1;
					savedData.Add(y, eventData.uName);					
				}
				else if (x >= 1)									//Perulangan untuk cek dan tambah user
				{
					for (int i = x; i <= x; i++)
					{
						i++;
						savedData.Add(i, eventData.uName);	
					}
				}
				else
				{
					Console.WriteLine("Error");
				}
			}
			
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}*/
		}
		
		public void ShowData()
		{
			foreach (KeyValuePair<int, string?> x in savedData)
			{
				Console.WriteLine(x.Key + " " + x.Value);
			}
		}
	}
}