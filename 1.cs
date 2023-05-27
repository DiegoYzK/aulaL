/*
crie duas interfaces, Ileitor e IEscritor, 
cada uma com um método, ler e escrever respectivamente.
Crie uma classe usuario que implementa ambas as interfaces.]
o metodo ler deve imprimir "lendo..." e o metodo Escrever deve imprimir "Escrevendo..."
crie um Objeto da classe e chama ambos os metodos.
*/
using System;
					
public class Program
{
	public static void Main(string[] args)
	{
        Usuario usuario = new Usuario();
        usuario.Ler();
        usuario.Escrever();
	}
	
	public interface ILeitor{
		
		void Ler();
	}

	public interface IEscritor{
		
		void Escrever();
	}

    public class Usuario : ILeitor, IEscritor{
        
        public void Ler(){

            Console.WriteLine("Lendo...");
            
        }
		
        public void Escrever(){

            Console.WriteLine("Escrevendo...");
            
        }		
    }
	
}