using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
namespace GestionChantier{
  class MainApp{
	public static void Main(string[] argv){
		CultureInfo.CurrentCulture = new CultureInfo("en-CA");
		List<Ouvrier> listeOuvrier = new List<Ouvrier>();
		
		
		if(argv.Length != 1){
			Console.WriteLine("Erreur! Arguments manquant");
			Console.WriteLine("Usage : main chemin/ouvriers.csv");
			System.Environment.Exit(-1);
		}
		if(!File.Exists(@argv[0])){
			Console.WriteLine("Impossible de trouver le fichier " + argv[0]);
			System.Environment.Exit(-2);
		}
		StreamReader input = new StreamReader(@argv[0]);
		string ligne;
		while((ligne = input.ReadLine()) != null){
			if(ligne[0] != '#'){
				string[] data = ligne.Split(',');
				int numero = Convert.ToInt32(data[0]);
				string nom = data[1];
				double tauxHoraire = Convert.ToDouble(data[2]);
				int experience = Convert.ToInt32(data[3]);
				Ouvrier ouvrier = new Ouvrier(nom, numero, tauxHoraire, experience);
				listeOuvrier.Add(ouvrier);
			}
		}
		foreach(Ouvrier ouvrier in listeOuvrier)
			Console.WriteLine(ouvrier);
		input.Close();
	}
  }
}
   