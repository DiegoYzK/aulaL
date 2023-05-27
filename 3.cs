/*
Crie três interfaces, ITocadorGuitarra, ITocadorBaixo e ITocadorBateria, 
cada uma com um método TocarGuitarra, TocarBaíxo e TocarBateria respectivamente
Crie uma classe Musico que implemente as três interfaces.
cada método deve imprimir uma mensagem apropriada,
como “Tocando guitarra...”, “Tocando baixo. ..” e “Tocando bateria...”. 
Crie um objeto da classe Musico e chame todos os três métodos.
*/

using System;
					
public class Program
{
	public static void Main(string[] args)
	{
        Musico musico = new Musico();
        musico.guitarra();
        musico.baixo();
        musico.bateria();

	}
public interface ITocadorGuitarra{

    void guitarra();

}

public interface ITocadorBateria{

    void bateria();
    
}

public interface ITocadorBaixo{

    void baixo();
    
}

public class Musico : ITocadorBaixo, ITocadorBateria, ITocadorGuitarra{

    public void guitarra(){

        Console.WriteLine("Tocando guitarra...");

    }
    
    public void bateria(){

        Console.WriteLine("Tocando bateria...");

    }

    public void baixo(){
        
        Console.WriteLine("Tocando baixo...");

    }
}
}