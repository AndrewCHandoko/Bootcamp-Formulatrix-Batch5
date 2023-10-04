using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recap2
{
	public class Process
	{
		public event EventHandler<EventData>? SavingProcess;
		
		Save saver = new();  
		
		public void SavingData(int uID, string? uName)
		{	
			int savedID = uID;
			string? savedName = uName; 
			
			SavingProcess?.Invoke(this, new EventData{uID = savedID, uName = savedName});			
			/*EventData eventData = new();
			
			int x = saver.savedData.Count; 
			Console.WriteLine($"x = {x}");
			if (x == 0 && SavingProcess is null)
			{
				x = 1;
			}
			else 								//Perulangan untuk cek dan tambah user
			{
				x++; 
			}
			
			eventData.uID = x;
			eventData.uName = uName;*/
		}
	}
}