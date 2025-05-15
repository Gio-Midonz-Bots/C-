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
Console.WriteLine("----------------------------------------------------------------------------------------------------");  

 //12) Crie um programa que leia o preço de um produto, calcule e mostre o seu 
//PREÇO PROMOCIONAL, com 5% de desconto.
        Console.WriteLine("Digite o preço do produto desejado:\n ");
        double precoOriginal = double.Parse(Console.ReadLine());
        double Promocao = precoOriginal * 0.95;

        Console.WriteLine($"O preço a ser pago com o desconto é: {Promocao}\nObrigado pela preferência volte sempre");
        Console.WriteLine("----------------------------------------------------------------------------------------------------");  
//13) Faça um algoritmo que leia o salário de um funcionário, calcule e mostre o 
//seu novo salário, com 15% de aumento.
        Console.WriteLine($"Informe qual é o seu salário {nome}");
        salario = double.Parse(Console.ReadLine());
        double aumentoSalarial = salario * 0.15;
        double novoSalario = aumentoSalarial + salario;

        Console.WriteLine($"Seu novo salario é: {novoSalario}");
        Console.WriteLine("----------------------------------------------------------------------------------------------------");  
// 14) A locadora de carros precisa da sua ajuda para cobrar seus serviços. Escreva 
// um programa que pergunte a quantidade de Km percorridos por um carro alugado e a 
// quantidade de dias pelos quais ele foi alugado. Calcule o preço total a pagar, 
// sabendo que o carro custa R$90 por dia e R$0,20 por Km rodado. 
        Console.WriteLine("Quantos Km foi pecorrido pelo seu carro alugado? ");
        double KmPecorrido = double.Parse(Console.ReadLine());
        Console.WriteLine("Quantos dias foi alugado o carro? ");
        int dias = int.Parse(Console.ReadLine());

        double PrecoTotal = dias * 90 + KmPecorrido *0.20;

        Console.WriteLine($"O valor total a ser pago pelo carro alugado é: R$ {PrecoTotal:F2}");
        
// 15) Crie um programa que leia o número de dias trabalhados em um mês e mostre o 
// salário de um funcionário, sabendo que ele trabalha 8 horas por dia e ganha R$25 
// por hora trabalhada. 
        Console.WriteLine($"quantos dias você trabalhou nesse mês?");
        int diasTrabalhado = int.Parse(Console.ReadLine());
        double salarioFuncionario =  8 * 25 * diasTrabalhado;

        Console.WriteLine($"O salário do funcionairo é R$ {salarioFuncionario:F2}");

// 16) [DESAFIO] Escreva um programa para calcular a redução do tempo de vida de um 
// fumante. Pergunte a quantidade de cigarros fumados por dias e quantos anos ele 
// já fumou. Considere que um fumante perde 10 min de vida a cada cigarro. Calcule 
// quantos dias de vida um fumante perderá e exiba o total em dias.
        Console.WriteLine("Quantos cigarros você fuma por dias?");
        int cigarroFumado = int.Parse(Console.ReadLine());
        Console.WriteLine("Quantos anos você já fuma cigarro?");
        int anos = int.Parse(Console.ReadLine());

        int calculoVida = 0 ;



//PASSO 02 - CONDIÇÕES BÁSICAS 

// 17) Escreva um programa que pergunte a velocidade de um carro. Caso ultrapasse 
// 80Km/h, exiba uma mensagem dizendo que o usuário foi multado. Nesse caso, exiba 
// o valor da multa, cobrando R$5 por cada Km acima da velocidade permitida.