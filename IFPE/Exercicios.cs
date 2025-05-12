using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_.IFPE
{
    public class Exercicios
    {
        public static void Main(string[] args){
        Console.WriteLine("Alô Mundo\n Seja bem vindo aos Estudos do IFPE Campus Olinda");
        
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Digite um número:");
        int Numero = int.Parse(Console.ReadLine());
        Console.WriteLine("O número informado foi: " + Numero);

        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Muito bem Agora vamos Fazer uma soma\n Digite dois numeros inteiros");
        int PrimeiroNumero = int.Parse(Console.ReadLine());
        int SegundoNumero = int.Parse(Console.ReadLine());

        int soma = PrimeiroNumero + SegundoNumero;
        Console.WriteLine($"O resultado da soma do numeros {PrimeiroNumero} e {SegundoNumero} foi igual à {soma}");

        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Parabéns ");
        }
    }
}