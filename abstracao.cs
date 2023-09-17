using System;

public abstract class Veiculo {
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }

    public abstract void Acelerar();
    public abstract void Frear();
    public abstract void Abastecer();
}

public class Carro : Veiculo
{
    public override void Acelerar() {
        Console.WriteLine("Carro acelerando...");
    }

    public override void Frear()  {
        Console.WriteLine("Carro freando...");
    }

    public override void Abastecer() {
        Console.WriteLine("Carro abastecendo com gasolina...");
    }
}

public class Moto : Veiculo {
    public override void Acelerar() {
        Console.WriteLine("Moto acelerando...");
    }

    public override void Frear() {
        Console.WriteLine("Moto freando...");
    }

    public override void Abastecer()  {
        Console.WriteLine("Moto abastecendo com gasolina...");
    }
}
