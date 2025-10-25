using System;

namespace SistemaCelular.Models
{
    public class Samsung : Celular
    {
        public Samsung(string modelo, string cor) : base(modelo, cor) { }

        public override void Ligar()
        {
            Console.WriteLine($"Samsung {Modelo} ligado com animação Samsung!");
        }

        public override void Desligar()
        {
            Console.WriteLine($"Samsung {Modelo} desligado com segurança Samsung.");
        }
    }
}
