using Characterr;
using Roles;

namespace SharpShoterr
{
	public class SharpShooter : Character, ISharpShoter
	{
		public void ReadytoShoot()
		{
			Console.WriteLine("Ready for the Battle");
		}
		
		public override void Fly()
		{
			Console.WriteLine("Character Flying");
		}
		
		public void ShotThem()
		{
			Console.WriteLine("Shot the Enemy");
		}
	}
}