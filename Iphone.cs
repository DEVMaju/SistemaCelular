using System;

namespace SistemaCelular.Models
{
    public class Iphone : Celular
    {
        public Iphone(string modelo, string cor) : base(modelo, cor) { }

        public override void Ligar()
        {
            Console.WriteLine($"iPhone {Modelo} ligado com efeito Apple.");
        }

        public override void Desligar()
        {
            Console.WriteLine($"iPhone {Modelo} desligado suavemente.");
        }
    }
}
