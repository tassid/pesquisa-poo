using System;
namespace OOPExample
{
    public abstract class Veiculo
    {
        protected bool MotorLigado;
        protected bool MotorPartidaAcinado;
        protected bool InjetadoCombustivel;

        public Veiculo() {
            Console.WriteLine("Eu sou um veículo");
        }

        public abstract void Ligar();
        public abstract void Acelerar();
        public abstract void Freiar();
    }

    public class Carro : Veiculo
    {
        public Carro(){
            Console.WriteLine("Eu sou um carro");
        }

        public override void Acelerar(){
            throw new NotImplementedException();
        }

        public override void Freiar(){
            throw new NotImplementedException();
        }

        public override void Ligar(){
            MotorPartidaAcinado = true;
            InjetadoCombustivel = true;
            MotorLigado = true;
            Console.WriteLine("O carro está ligado");
        }
    }
}
