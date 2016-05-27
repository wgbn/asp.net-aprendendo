using System;

namespace CalculoDeDieta
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Alimento aveia = new Alimento (){ Nome = "Aveia em Flocos", Proteina = 13.9f, Carboidrato = 66.6f, Gordura = 8.5f, Forca = Alimento.ForcaEn.C };
			Alimento banana = new Alimento (){ Nome = "Banana da Terra", Proteina = 1.4f, Carboidrato = 33.7f, Gordura = 0.2f, Forca = Alimento.ForcaEn.C };

			aveia.CalcularCaloria ();
			banana.CalcularCaloria ();

			Console.WriteLine (aveia.ToString ());
			Console.WriteLine ("-------------------------");
			Console.WriteLine (banana.ToString ());
			Console.WriteLine ("-------------------------");
		}
	}
}
