using System;
using System.Collections.Generic;

namespace CalculoDeDieta
{
	public class Alimento
	{
		public enum ForcaEn {
			P, C, L, M
		};

		private const float CALORIA_PROTEINA = 4f;
		private const float CALORIA_CARBOIDRATO = 4f;
		private const float CALORIA_GORDURA = 9f;

		public string	Nome 		{ get; set; }
		public float 	Proteina 	{ get; set; }
		public float 	Carboidrato { get; set; }
		public float 	Gordura 	{ get; set; }
		public float 	Caloria 	{ get; set; }
		public float 	Qtde 		{ get; set; }
		public ForcaEn	Forca		{ get; set; }

		public void CalcularCaloria()
		{
			Qtde = Qtde == 0 ? 100f : Qtde;

			if (Qtde == 100f){
				Caloria = (Proteina * CALORIA_PROTEINA) +
					(Carboidrato * CALORIA_CARBOIDRATO) +
					(Gordura * CALORIA_GORDURA);
			} else {
				Caloria = RegraDeTres (Proteina * CALORIA_PROTEINA) +
					RegraDeTres (Carboidrato * CALORIA_CARBOIDRATO) +
					RegraDeTres (Gordura * CALORIA_GORDURA);
			}
		}

		public override string ToString(){
			return Nome + "\nProteina: " + Proteina + "\nCarboidrato: " + Carboidrato + "\nGordura: " + Gordura + "\nCaloria: " + Caloria;
		}

		private float RegraDeTres(float _valor){
			return (_valor * Qtde) / 100;
		}
	}
}
