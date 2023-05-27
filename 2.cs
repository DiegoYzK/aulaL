/*
Crie duas interfaces, IVoador e ICorredor, cada uma com um metodo, Voar e Correr respectivamente. 
Crie uma classe SuperHeroi que implementa ambas as interfaces. O método Voar deve imprimir "Voando alto
no ceu..." e o metodo Correr deve imprimir "Correndo muito rapido...". Crie um objeto da classe Superheroi e chame ambos os metodos.
*/

using System;
					
public class Program
{
	public static void Main(string[] args)
	{
        SuperHeroi sh = new SuperHeroi();
        sh.Voar();
        sh.Escrever();
	}
	
	public interface IVoador{
		
		void Voar();
	}

	public interface ICorredor{
		
		void Correr();
	}
    
    public class SuperHeroi : IVoador, ICorredor{
        
        public void Voar(){

            Console.WriteLine("Voando alto...");
        }
		
        public void Correr(){

            Console.WriteLine("Correndo muito rapido...");
        }		
    }  
	
}      