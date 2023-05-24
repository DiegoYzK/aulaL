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
