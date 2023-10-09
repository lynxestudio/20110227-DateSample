using System;

namespace Samples.Dates
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Message msg = new Message("Sistemas de control");
			msg.Description = "Los sistemas de control son de lazo abierto ó lazo cerrado.";
			Console.WriteLine("Mensaje creado en {0:dd-MM-yyyy hh:mm:ss}", msg.DateCreated);
			Console.ReadLine();
		}
	}
}
