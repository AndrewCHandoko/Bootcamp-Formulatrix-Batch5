using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recap2.Progress
{
	public class Process
	{
		public event EventHandler<string?> SavingProcess;
		
		public void SavingData(string? uName)
		{
			EventData eventData = new();
			
			eventData.uName = uName; //baru sampe sini eventhandler
		}
	}
}