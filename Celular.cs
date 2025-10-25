namespace SistemaCelular.Models
{
    // Classe abstrata: define o modelo de um celular
    public abstract class Celular
    {
        public string Modelo { get; set; }
        public string Cor { get; set; }

        public Celular(string modelo, string cor)
        {
            Modelo = modelo;
            Cor = cor;
        }

        // Método abstrato: cada celular pode ligar de forma diferente
        public abstract void Ligar();

        // Método abstrato: cada celular pode desligar de forma diferente
        public abstract void Desligar();

        // Método concreto: todos os celulares podem enviar mensagem
        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"Mensagem enviada: {mensagem}");
        }
    }
}
