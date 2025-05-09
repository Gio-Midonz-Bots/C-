//See https://aka.ms/new-console-template for more information
using System;
using System.Formats.Tar;
using System.Globalization;

//PASSO 01 - SEQUÊNCIAS BÁSICAS

//  1) Escreva um programa que mostre na tela a mensagem "Olá, Mundo!"
Console.WriteLine("Hello, World!");

// 2) Faça um programa que leia o nome de uma pessoa e mostre uma mensagem de boasvindas para ela:
Console.WriteLine("Digite o seu nome: ");
    string nome = Console.ReadLine();

Console.WriteLine($"Olá {nome.ToUpper()} Seja - bem vindo(a), ao programa ");
Console.WriteLine("----------------------------------------------------------------------------------------------------");
//3) Crie um programa que leia o nome e o salário de um funcionário, mostrando no 
//final uma mensagem.
Console.WriteLine("Por favor Informe o Seu Salário:");
    double salario = double.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));
Console.WriteLine($"O funcionário {nome.ToUpper()} tem um salário de R${salario.ToString("N2",new CultureInfo("pt-BR"))} em Maio.\n");
Console.WriteLine("----------------------------------------------------------------------------------------------------");
//4) Desenvolva um algoritmo que leia dois números inteiros e mostre o somatório 
//entre eles.

Console.WriteLine($"Olá {nome.ToUpper()}, Agora vamos realizar alguns testes \ndigite DOIS NÚMEROS para realizamos o somatório: ");
    int PrimeiroNumero = int.Parse(Console.ReadLine());
    int SegundoNumero = int.Parse(Console.ReadLine());

    int Somatorio = PrimeiroNumero + SegundoNumero;

Console.WriteLine($"Muito Bem {nome.ToUpper()}\no Resultado das somas dos números {PrimeiroNumero} + {SegundoNumero} = {Somatorio}\n");
Console.WriteLine("----------------------------------------------------------------------------------------------------");
// 5) Faça um programa que leia as duas notas de um aluno em uma matéria e mostre 
//na tela a sua média na disciplina.
Console.WriteLine("Seguiremos para o segundo teste ->  \nditige DUAS NOTAS de avaliação:");
    double NotaUm = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
    double NotaDois = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);

    double media = (NotaUm + NotaDois) / 2;

Console.WriteLine($"A média entre {NotaUm} e {NotaDois} é igual a {media}\n");
Console.WriteLine("----------------------------------------------------------------------------------------------------");
//6) Faça um programa que leia um número inteiro e mostre o seu antecessor e seu 
//sucessor.
Console.WriteLine("parabéns Você chegou até aqui, Continue! \nVamos para a terceira etapa-> ");
Console.WriteLine($"O número é {PrimeiroNumero} \nO seu Antessesor é {PrimeiroNumero-1}\nO seu Sucessor é {PrimeiroNumero+1}\n");
Console.WriteLine("----------------------------------------------------------------------------------------------------");
//Crie um algoritmo que leia um número real e mostre na tela o seu dobro e a 
//sua terça parte.
Console.WriteLine($"Continue! \nVamos para a quarta etapa-> \nSeu número real é {NotaUm} ");
    double Dobro = NotaUm * 2;
    double TercaParte = NotaUm / 3;

Console.WriteLine($"Que legal descobrimos qual é o dobro do número real é igual a {Dobro} \nE a terça parte é igual a = {TercaParte}\n");
Console.WriteLine("----------------------------------------------------------------------------------------------------");

// //8) Desenvolva um programa que leia uma distância em metros e mostre os valores 
// //relativos em outras medidas. 
Console.WriteLine($"Continue! \nVamos para a quinta etapa-> \nDigite uma Distância em metros:");
    double Distancia = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
Console.WriteLine($"A distância de {Distancia.ToString("N2")}m corresponde a:");
    double Km =  Distancia / 1000;
    double Hm =  Distancia / 100;
    double Dam =  Distancia / 10;
    double Dm =  Distancia * 10;
    double Cm =  Distancia * 100;
    double Mm =  Distancia * 1000;
Console.WriteLine($"{Km}km\n{Hm}hm\n{Dam}dam\n{Dm}dm\n{Cm}cm\n{Mm}mm\n");
Console.WriteLine("----------------------------------------------------------------------------------------------------");

// //9) Faça um algoritmo que leia quanto dinheiro uma pessoa tem na carteira (em R$) 
// //e mostre quantos dólares ela pode comprar. Considere US$1,00 = R$3,45.

Console.WriteLine($"Continue! \nQual é valor que você possui na sua carteira:");
    double Carteira = double.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));
    double Dolar = 3.45;
    double ComprarDolar = Carteira / Dolar; 

Console.WriteLine($"Você possui R${Carteira.ToString("N2")} na sua carteira, Quantos Dolares você pode comprar = {ComprarDolar.ToString("N2")} dolares\n");
Console.WriteLine("----------------------------------------------------------------------------------------------------");

//10) Faça um algoritmo que leia a largura e altura de uma parede, calcule e 
//mostre a área a ser pintada e a quantidade de tinta necessária para o serviço, 
//sabendo que cada litro de tinta pinta uma área de 2metros quadrados.
Console.WriteLine($"Parabéns você chegou até aqui,Continue! \nBora pintar a Casa? :");
Console.WriteLine($"Digite, o valor da largura da sua parede:");
    double Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine($"Digite, o valor da altura da sua parede:");
    double Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double Area = Largura * Altura;
    double TintaNecessaria = Area /2;
    double TintaArredondada = Math.Ceiling(TintaNecessaria);
Console.WriteLine($"A área total a ser pintada é {Area:F1}m²,\n Quantos litros você utilizará {TintaNecessaria:F1}l \n");
Console.WriteLine("----------------------------------------------------------------------------------------------------");


// 11) Desenvolva uma lógica que leia os valores de A, B e C de uma equação do 
// segundo grau e mostre o valor de Delta. 

Console.WriteLine("Vamos calcular o Delta de uma equação do segundo grau:");
Console.Write("Digite o valor de A: ");
    double A = double.Parse(Console.ReadLine() );

Console.Write("Digite o valor de B: ");
    double B = double.Parse(Console.ReadLine());

Console.Write("Digite o valor de C: ");
    double C = double.Parse(Console.ReadLine());

    double Delta = Math.Pow(B, 2) - 4 * A * C;

Console.WriteLine($"\nO valor de Delta é: {Delta:F2}");
  
