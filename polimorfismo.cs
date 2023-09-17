using System;

public class Veiculo{
    protected int velocidadeMaxima;
    protected int pesoMaximo;

    public virtual void Acelerar(){
        Console.WriteLine("Acelerando.");
    }
}

public class Carro : Veiculo{
    private int numeroDePortas;

    public void AbrirPorta(int numero) {
        Console.WriteLine("Abrindo porta " + numero);
    }

    public override void Acelerar() {
        Console.WriteLine("Acelerando carro.");
    }
}

class Program {
    static void Main() {
        Carro carro = new Carro();
        carro.velocidadeMaxima = 200;
        carro.pesoMaximo = 2000;
        carro.Acelerar(); // Output: Acelerando carro.
        Console.ReadKey();
    }
}
