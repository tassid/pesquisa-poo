// Classe base (superclasse)
public class Animal {
    public string Nome { get; set; }
    public int Idade { get; set; }

    public void EmitirSom() {
        Console.WriteLine("O animal emite um som.");
    }
}

// Classes derivadas (subclasses)
public class Cachorro : Animal{
    public void Latir(){
        Console.WriteLine("O cachorro late.");
    }
}

public class BeijaFlor : Animal {
    public void Voar(){
        Console.WriteLine("O beija-flor voa rapidamente.");
    }
}

class Program{
    static void Main() {
        Cachorro cachorro = new Cachorro();
        cachorro.Nome = "Rex";
        cachorro.Idade = 3;

        BeijaFlor beijaFlor = new BeijaFlor();
        beijaFlor.Nome = "Zumbido";
        beijaFlor.Idade = 1;

        cachorro.EmitirSom();
        cachorro.Latir();

        beijaFlor.EmitirSom();
        beijaFlor.Voar();
    }
}
