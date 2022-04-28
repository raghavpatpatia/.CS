public class Class1
{
	public static void Main(string[] args)
	{
		string a;
		int b, c, e;
		bool d;
		a = System.Console.ReadLine();
		System.Console.WriteLine("Value of a: " + a);
		b = Int16.Parse(System.Console.ReadLine());
		System.Console.WriteLine("Value of b: " + b);
		c = Convert.ToInt32(System.Console.ReadLine());
		System.Console.WriteLine("Value of c: " + c);
		d = Int32.TryParse(System.Console.ReadLine(), out e);
		System.Console.WriteLine("Value of d: " + d);
	}
}
