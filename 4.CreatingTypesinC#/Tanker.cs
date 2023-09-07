using Characterr;
using Roles;

namespace Tankerr
{
	public class Tanker : Character, ITanker
	{
		public void ReadytoDefense()
		{
			Console.WriteLine("Ready for the Battle");
		}
		
		public override void Fly()
		{
			//throw new NotImplementedException(); //Jika belum ada implementasi
			Console.WriteLine("Tanker Cannot Fly");
		}
		
		public void ActivateShield()
		{
			Console.WriteLine("Using Shield");
		}
	}
}