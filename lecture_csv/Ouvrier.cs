using System;

namespace GestionChantier{
	public class Ouvrier
	{
		private int numero;
		private string nom;
		private double tauxHoraire;
		private int experience;

		public Ouvrier()
		{
		}
		public Ouvrier(string nom, int numero, double tauxHoraire, int experience)
			: this()
		{
			this.nom = nom;
			this.numero = numero;
			this.tauxHoraire = tauxHoraire;
			this.experience = experience;
		}


		public int getNumero()
		{
			return numero;
		}

		public void setNumero(int numero)
		{
			this.numero = numero;
		}

		public string getNom()
		{
			return nom;
		}

		public void setNom(string nom)
		{
			this.nom = nom;
		}

		public void setTauxHoraire(double tauxHoraire)
		{
			if (tauxHoraire > 0)
			{
				this.tauxHoraire = tauxHoraire;
			}
		}

		public double getTauxHoraire()
		{
			return tauxHoraire;
		}

		public void setExperience(int experience)
		{
			if (experience >= 0)
			{
				this.experience = experience;
			}
		}

		public int getExperience()
		{
			return experience;
		}
		public override string ToString(){
			return "Numéro : " + numero + ", Nom : " + nom + ", Taux horaire : " + tauxHoraire + "$, Expérience : " + experience;
		}
	}
}
