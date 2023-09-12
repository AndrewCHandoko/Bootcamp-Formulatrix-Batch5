namespace Day6.Car
{
	public class Checker
	{
		public static void Check<T>(T a) where T : class		//Generic Method 
		{
			
		}
		
		public static void Check1<T>(T a) where T : struct		//Generic Method 
		{
			
		}
		
		public static void Check<T, T2>(T a, T2 b)				//Generic Method 
		where T : class, new()
		where T2 : struct
		{
			
		}
	}
}