using System;
using SistemaCelular.Models;

class Program
{
    static void Main()
    {
        // Criando celulares
        Celular meuSamsung = new Samsung("Galaxy S23", "Preto");
        Celular meuIphone = new Iphone("iPhone 14", "Branco");

        // Ligando celulares
        meuSamsung.Ligar();
        meuIphone.Ligar();

        // Enviando mensagens
        meuSamsung.EnviarMensagem("Olá, Samsung!");
        meuIphone.EnviarMensagem("Olá, iPhone!");

        // Desligando celulares
        meuSamsung.Desligar();
        meuIphone.Desligar();
    }
}
