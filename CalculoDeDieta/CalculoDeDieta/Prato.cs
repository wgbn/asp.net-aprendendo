using System;
using System.Collections.Generic;

namespace CalculoDeDieta
{
	public class Prato
	{
		private List<Alimento> Alimentos;
		public float	Calorias 	{ get; set; }
		public float	Proteinas	{ get; set; }
		public float	Carboidratos{ get; set; }
		public float	Gorduras	{ get; set; }
		public bool		Proporcao	{ get; set; }

		public void AddAlimento(Alimento _alimento)
		{
			Alimentos.Add (_alimento);
		}

		public void RemoveAlimento(Alimento _alimento)
		{
			Alimentos.Remove (_alimento);
		}

		public List<Alimento> GetAlimentos()
		{
			return Alimentos;
		}
	}
}
