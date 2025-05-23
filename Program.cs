﻿//See https://aka.ms/new-console-template for more information
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
        Console.WriteLine("----------------------------------------------------------------------------------------------------");  
// 15) Crie um programa que leia o número de dias trabalhados em um mês e mostre o 
// salário de um funcionário, sabendo que ele trabalha 8 horas por dia e ganha R$25 
// por hora trabalhada. 
        Console.WriteLine($"quantos dias você trabalhou nesse mês?");
        int diasTrabalhado = int.Parse(Console.ReadLine());
        double salarioFuncionario =  8 * 25 * diasTrabalhado;

        Console.WriteLine($"O salário do funcionairo é R$ {salarioFuncionario:F2}");
        Console.WriteLine("----------------------------------------------------------------------------------------------------");  
// 16) [DESAFIO] Escreva um programa para calcular a redução do tempo de vida de um 
// fumante. Pergunte a quantidade de cigarros fumados por dias e quantos anos ele 
// já fumou. Considere que um fumante perde 10 min de vida a cada cigarro. Calcule 
// quantos dias de vida um fumante perderá e exiba o total em dias.
        Console.WriteLine("Quantos cigarros você fuma por dias?");
        int cigarroFumado = int.Parse(Console.ReadLine());
        Console.WriteLine("Quantos anos você já fuma cigarro?");
        int anos = int.Parse(Console.ReadLine());

        int DiasPerdidos = (cigarroFumado * 365 * anos *10) / 60 / 24 ;

        Console.WriteLine($"Seus dias perdidos é: {DiasPerdidos}");
        Console.WriteLine("----------------------------------------------------------------------------------------------------");
//PASSO 02 - CONDIÇÕES BÁSICAS 

// 17) Escreva um programa que pergunte a velocidade de um carro. Caso ultrapasse 
// 80Km/h, exiba uma mensagem dizendo que o usuário foi multado. Nesse caso, exiba 
// o valor da multa, cobrando R$5 por cada Km acima da velocidade permitida.
Console.WriteLine("Parabéns por Ter chegado até aqui, Vamos Seguir em frete!!!!!!!!!!!");
        Console.WriteLine("\nQual é velocidade do carro: ");
        double velocidadeCarro = double.Parse(Console.ReadLine());
        double kmUltrapassado = (velocidadeCarro - 80); 
        double valorDaMulta = kmUltrapassado  * 5;

if (velocidadeCarro >= 80)
{
    Console.WriteLine($"Você ultrapassou {kmUltrapassado}km/h, sua multa é de R$: {valorDaMulta} infelizmente você foi multado!");
}
else
{
    Console.WriteLine("Você está em conformidade, Parabéns!");
}


Console.WriteLine("----------------------------------------------------------------------------------------------------");  
// 18) Faça um programa que leia o ano de nascimento de uma pessoa, calcule a idade 
// dela e depois mostre se ela pode ou não votar. 
Console.WriteLine("----------------------------------------------------------------------------------------------------");
Console.WriteLine("Qual é o ano do seu nascimento: ");
int anoNascimento = int.Parse(Console.ReadLine());
int qualIdade = 2025 - anoNascimento ;

if (qualIdade >= 18)
{
    Console.WriteLine("Você pode votar!");
}
else
{
    Console.WriteLine("Você é de menor, não pode votar");
}

Console.WriteLine("----------------------------------------------------------------------------------------------------");
// // 19) Crie um algoritmo que leia o nome e as duas notas de um aluno, calcule a sua 
// média e mostre na tela. No final, analise a média e mostre se o aluno teve ou 
// não um bom aproveitamento (se ficou acima da média 7.0). 

Console.WriteLine("Qual é o seu nome:");
string nomeAluno = Console.ReadLine();
Console.WriteLine("Qual é a sua primeira nota:");
int notaPrimeira = int.Parse(Console.ReadLine());

Console.WriteLine("Qual é a sua segunda nota:");
int notaSegunda = int.Parse(Console.ReadLine());

int mediaAluno = (notaPrimeira + notaSegunda) / 2;
Console.WriteLine($"Sua primeira nota é: {notaPrimeira}. Sua segunda nota é: {notaSegunda}\nSua média é: {mediaAluno}");
if (mediaAluno > 7)
{
    Console.WriteLine("Parabéns! Você teve um bom aproveitamento");
}
else
{
    Console.WriteLine("Infelizmente, Você não teve um bom aproveitamento");
}



 Console.WriteLine("----------------------------------------------------------------------------------------------------");  
// 20) Desenvolva um programa que leia um número inteiro e mostre se ele é PAR ou 
// ÍMPAR. 
Console.WriteLine("Informe um número inteiro:");
int numeroInteiro = int.Parse(Console.ReadLine());

if (numeroInteiro % 2 == 0)
{
    Console.WriteLine("é Par");
}
else
{
    Console.WriteLine("é Impar");
}


 Console.WriteLine("----------------------------------------------------------------------------------------------------");
// 21) Faça um algoritmo que leia um determinado ano e mostre se ele é ou não 
// BISSEXTO. 
Console.WriteLine("Informe o seu ano: ");
int anoBissexto = int.Parse(Console.ReadLine());
if (anoBissexto % 4 ==0) {

    Console.WriteLine("é ano bissexto ");
}
else
{
    Console.WriteLine("Nõ ");
}


 Console.WriteLine("----------------------------------------------------------------------------------------------------");  
// 22) Escreva um programa que leia o ano de nascimento de um rapaz e mostre a sua 
// situação em relação ao alistamento militar. 
//    - Se estiver antes dos 18 anos, mostre em quantos anos faltam para o 
// alistamento. 
//    - Se já tiver depois dos 18 anos, mostre quantos anos já se passaram do 
// alistamento. 

Console.WriteLine("Informe o ano de nascimento: ");
int anoDeNascimentoRapaz = int.Parse(Console.ReadLine());
int calcularIdadeRapaz = 2025 - anoDeNascimentoRapaz;
int temporestante = 18 - calcularIdadeRapaz ;
if (calcularIdadeRapaz == 18)
{
    Console.WriteLine($"Sua idade é {calcularIdadeRapaz}, então você deve se Alistar!");
}
else if (calcularIdadeRapaz > 18)
{
    Console.WriteLine($"Sua idade é {calcularIdadeRapaz}, então você utrapassou o tempo de se Alistar, deve se aprensentar no quartel!");
}
else
{
    Console.WriteLine($"Sua idade é {calcularIdadeRapaz}, então você tem que esperar mais {temporestante} anos.");
}
 Console.WriteLine("----------------------------------------------------------------------------------------------------");  
// 23) Numa promoção exclusiva para o Dia da Mulher, uma loja quer dar descontos 
// para todos, mas especialmente para mulheres. Faça um programa que leia nome, 
// sexo e o valor das compras do cliente e calcule o preço com desconto. Sabendo 
// que: - Homens ganham 5% de desconto - Mulheres ganham 13% de desconto 
 Console.WriteLine("Informe o seu nome:");
string nomeCliente = Console.ReadLine();
Console.WriteLine($"Informe o seu Sexo: 'F' para feminino ou 'M' para masculino");
char sexo = char.Parse(Console.ReadLine());
Console.WriteLine($"Informe o valor total das suas compras:");
double ValorTotalCompras = double.Parse(Console.ReadLine());
double descontoDiaDaMulher = ValorTotalCompras * 0.13;
double descontoDiaDaMulherParaHomens = ValorTotalCompras * 0.05;
double ResultadoDoDescontoMulheres = ValorTotalCompras - descontoDiaDaMulher;
double ResultadoDoDescontoHomens = ValorTotalCompras - descontoDiaDaMulherParaHomens;
if (sexo == 'M' || sexo == 'm')
{
    Console.WriteLine($"Você Ganhou uma promoção dos dias da Mulher!\nNo valor de 5%. O seu valor total é R$ {ValorTotalCompras} o valor do desconto é de R${descontoDiaDaMulherParaHomens} \ncom o desconto o valor fica R${ResultadoDoDescontoHomens}");
}
else if (sexo == 'F' || sexo == 'f')
{

    Console.WriteLine($"Você Ganhou uma promoção dos dias da Mulher!\nNo valor de 13%. O seu valor total é R$ {ValorTotalCompras} o valor do desconto é de R${descontoDiaDaMulher} \ncom o desconto o valor fica R${ResultadoDoDescontoMulheres}");
}
else
{
    Console.WriteLine("Infelizmente você digitou algo errado");
}

// Console.WriteLine("----------------------------------------------------------------------------------------------------");
// 24) Faça um algoritmo que pergunte a distância que um passageiro deseja 
// percorrer em Km. Calcule o preço da passagem, cobrando R$0.50 por Km para 
// viagens até 200Km e R$0.45 para viagens mais longas. 
Console.WriteLine($"Qual é a distância que o você deseja percorrer?");
double distanciaPassageiro = double.Parse(Console.ReadLine());
double calcPercurso = 0;
if (distanciaPassageiro == 200)
{
   calcPercurso = distanciaPassageiro * 0.50;
    Console.WriteLine($"Sua passagem ficou no valor de R${calcPercurso} ");

}
else
{
    calcPercurso = distanciaPassageiro * 0.45;
    Console.WriteLine($"Sua passagem ficou no valor de R${calcPercurso} ");

}
 Console.WriteLine("----------------------------------------------------------------------------------------------------");
// 25) 




//[DESAFIO] Crie um programa que leia o tamanho de três segmentos de reta. 
// Analise seus comprimentos e diga se é possível formar um triângulo com essas 
// retas. Matematicamente, para três segmentos formarem um triângulo, o comprimento 
// de cada lado deve ser menor que a soma dos outros dois.
Console.WriteLine("----------------------------------------------------------------------------------------------------");
// 26) Escreva um algoritmo que leia dois números inteiros e compare-os, mostrando 
// na tela uma das mensagens abaixo: 
//    - O primeiro valor é o maior 
//    - O segundo valor é o maior 
//    - Não existe valor maior, os dois são iguais 
Console.WriteLine($"informe qual é suas duas notas");
int avaliacaoUM = int.Parse(Console.ReadLine());
int avaliacaoDois = int.Parse(Console.ReadLine());
if (avaliacaoUM > avaliacaoDois)
{
    Console.WriteLine($"A primeira avaliação foi maior que a segunda avaliação.");
}
else if (avaliacaoDois > avaliacaoUM)
{
    Console.WriteLine($"A segunda avaliação foi maior que a primeira avaliação.");
}
else
{
    Console.WriteLine($"As duas avaliações tem o mesmo valor.");
}

Console.WriteLine("----------------------------------------------------------------------------------------------------");
// 27) Crie um programa que leia duas notas de um aluno e calcule a sua média, 
// mostrando uma mensagem no final, de acordo com a média atingida: 
//    - Média até 4.9: REPROVADO 
//    - Média entre 5.0 e 6.9: RECUPERAÇÃO 
//    - Média 7.0 ou superior: APROVADO 
 Console.WriteLine("----------------------------------------------------------------------------------------------------");
// 28) Faça um programa que leia a largura e o comprimento de um terreno 
// retangular, calculando e mostrando a sua área em m². O programa também 
// devemostrar a classificação desse terreno, de acordo com a lista abaixo: 
//    - Abaixo de 100m² = TERRENO POPULAR 
//    - Entre 100m² e 500m² = TERRENO MASTER 
//    - Acima de 500m² = TERRENO VIP 
 Console.WriteLine("----------------------------------------------------------------------------------------------------");
// 29) Desenvolva um programa que leia o nome de um funcionário, seu salário, 
// quantos anos ele trabalha na empresa e mostre seu novo salário, reajustado de 
// acordo com a tabela a seguir: 
//    - Até 3 anos de empresa: aumento de 3% 
//    - entre 3 e 10 anos: aumento de 12.5% 
//    - 10 anos ou mais: aumento de 20% 
 Console.WriteLine("----------------------------------------------------------------------------------------------------");
// 30) [DESAFIO] Refaça o algoritmo 25, acrescentando o recurso de mostrar que tipo 
// de triângulo será formado:  
//    - EQUILÁTERO: todos os lados iguais 
//    - ISÓSCELES: dois lados iguais 
//    - ESCALENO: todos os lados diferentes 
 Console.WriteLine("----------------------------------------------------------------------------------------------------");
// 31) [DESAFIO] Crie um jogo de JoKenPo (Pedra-Papel-Tesoura) 
Console.WriteLine("----------------------------------------------------------------------------------------------------"); 
// 32) [DESAFIO] Crie um jogo onde o computador vai sortear um número entre 1 e 5 o 
// jogador vai tentar descobrir qual foi o valor sorteado. 
 
  
