using System;
class PileEntiers{
	private int[] elements;
	private int taille;
	
	public PileEntiers(){
		elements = new int[100];
		taille = 0;
	}
	
	public bool estVide(){
		return taille == 0;
	}
	
	public bool estPleine(){
		return taille == 100;
	}
	
	public int peek(){
		return elements[taille - 1];
	}
	
	public void push(int valeur){
		elements[taille++] = valeur;
		}
	
	public int pop(){
		return elements[--taille];
	}
	
	public int getTaille(){
		return taille;
	}
}

class Test{
	public static void Main(string[] argv){
		PileEntiers pile = new PileEntiers();
		for(int i = 0; i < 10; i++)
			pile.push(i);
		
		Console.WriteLine("Sommet de la pile : " + pile.peek());
	}
}