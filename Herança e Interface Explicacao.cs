/*
Herança é um principio fundamental da programação orientada a objetos (OOP) que permite
que uma classe adquira as propriedads e metodos de outra classe.
Em C#, a herança é indicada pela palavra-chave:.

a classe que é herdada é chamada de "classe base" ou "classe pai", 
e a classe que herda é chamada "classe derivada"  ou "Classe filha".
*/

public class Animal // Classe base
{
    public void Comer(){
        Console.WriteLine("o animal está comendo...");
    }
}

public class Gato : Animal // Classe derivada
{

    public void Miar(){
        Console.WriteLine("O gato está miando...");
    }
}

public class programação{

    public static void Main(){

        Gato gato = new Gato();

        gato.Comer();//Metodo herdado da classe Animal
        gato.Miar(); //metodo herdado da propria classe
    }
}


/* Herança Mutipla: Na herança mutipla, uma classe pode herdar de varias classes.
Ou seja, uma classe derivada pode ter varias classes base. embora a herança 
multipla possa parecer util a primeira vista, ela tambem levar a uma grande 
quantidade de confusão quando duas classes base tem propriedades
ou metodos com o mesmo nome.

Em C#, a herança multipla de classes nao é suportada devido a ambiguidade que ela pode causar. No entento,
C# suporta henraça mutipla de interfaces. uma classe pode implementar varias interfaces,
o que pode ser visto como uma forma de herança mutipla.
*/

public interface Icaminhante{

    void Caminhar();

}

public interface Icacador{

    void Cacar();

}

public class Gato : Icaminhante, Icacador{
    
    public void Caminhar(){


        Console.WriteLine("O gato está caminhando.");

    }

    public void Cacar(){
        
        Console.WriteLine("O gato esta caçando.");

    }
}

/*
1- Crie três interfaces, ITocadorGuitarra, ITocadorBaixo e ITocadorBateria, 
cada uma com um método TocarGuitarra, TocarBaíxo e TocarBateria respectivamente
Crie uma classe Musico que implemente as três interfaces.
cada método deve imprimir uma mensagem apropriada,
como “Tocando guitarra...”, “Tocando baixo. ..” e “Tocando bateria...”. 
Crie um objeto da classe Musico e chame todos os três métodos.
*/

/*
2- Crie duas interfaces, IVoador e ICorredor, cada uma com um metodo, Voar e Correr respectivamente. 
Crie uma classe SuperHeroi que implementa ambas as interfaces. O mÃ©todo Voar deve imprimir "Voando alto
no ceu..." e o metodo Correr deve imprimir "Correndo muito rapido...". Crie um objeto da classe Superheroi e chame ambos os metodos.
*/

/*
3- Crie duas interfaces, Ileitor e IEscritor, 
cada uma com um mÃ©todo, ler e escrever respectivamente.
Crie uma classe usuario que implementa ambas as interfaces.]
o metodo ler deve imprimir "lendo..." e o metodo Escrever deve imprimir "Escrevendo..."
crie um Objeto da classe e chama ambos os metodos.
*/
