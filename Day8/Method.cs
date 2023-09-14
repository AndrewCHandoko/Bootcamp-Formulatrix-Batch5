
namespace Day8
{
	public class Operand
	{
		public static int Adder(int a, int b)
		{
			return a+b;
		}//Method for Example1 
		
		public static string Printer()
		{
			throw new NotImplementedException();
		}//Method for Example2, but cannot be use 
		
		public static string Printer(string c)
		{
			return c;
		}//Method for Example3, Overload from the Method Above "Printer()" 
		
		public static void Print(string d)
		{
			Console.WriteLine(d);
		}//Method for Example4
		
		public static void Printing(string f)
		{
			Console.WriteLine("Messeages : " + f);
		}//Method for Example4		
	}
}