using System;
using System.Globalization;

namespace ExerciciosPropostos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeiro Exercicio");
            Console.WriteLine("Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa");
            Console.WriteLine("");
            
            int A, B, soma;
            Console.WriteLine("Digite o primeiro número para somar:");
            A = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo número para somar:");
            B = int.Parse(Console.ReadLine());
            
            soma = A + B;
            
            Console.WriteLine("SOMA = " + soma);
            Console.WriteLine("");
            
            Console.WriteLine("Segundo Exercicio");
            Console.WriteLine("Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais");
            Console.WriteLine("");
            
            double R, C, pi = 3.14159;
            
            Console.WriteLine("Digite o número para calcular o raio");
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            C = pi * R * R;
            
            Console.WriteLine("C=" + C.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("");
            
            
            Console.WriteLine("Terceiro Exercicio");
            Console.WriteLine("Fazer um programa para ler quatro valores inteiros D, E, F e G. A seguir, calcule e mostre a diferença do produto de D e E pelo produto de F e G");
            Console.WriteLine("");
            
            int D, E, F, G, dif;
            
            Console.WriteLine("Digite o primeiro número");
            D = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            E = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número");
            F = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto número");
            G = int.Parse(Console.ReadLine());
            
            dif = D * E - F * G;
            
            Console.WriteLine("DIFERENÇA = " + dif);
            Console.WriteLine("");
            
            int idFuncionario;
            double horas, salario, valorRecebido;
            
            Console.WriteLine("Qual é o seu ID");
            idFuncionario = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Quantas horas trabalhadas?");
            horas = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Valor hora recebido");
            salario = int.Parse(Console.ReadLine());
            
            valorRecebido = horas * salario;
            
            Console.WriteLine("");
            Console.WriteLine("idFuncionario");
            Console.WriteLine("");
            Console.WriteLine("Seu salario foi: " + valorRecebido.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("");


            int quantidadePecaOne, codigoPecaOne, numeroPecaSecond, codigoPecaSecond, quantidadePecaSecond;
            double valorPecaOne, valorPecaSecond, valorTotal, valorTotalPecaOne, valorTotalPecaSecond;

            Console.WriteLine("Por favor, digite o código da primeira peça:");
            codigoPecaOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade da primeria peça:");
            quantidadePecaOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe agora o valor de cada peça primeria:");
            valorPecaOne = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

            valorTotalPecaOne = quantidadePecaOne * valorPecaOne;
            Console.WriteLine("");
            
            Console.WriteLine("Valor total da primeira compra: R$" + valorTotalPecaOne.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("");
            
            Console.WriteLine("Por favor, digite o código da segunda peça:");
            codigoPecaSecond = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade da segunda peça:");
            quantidadePecaSecond = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe agora o valor de cada peça segunda:");
            valorPecaSecond = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

            Console.WriteLine("");
            valorTotalPecaSecond = quantidadePecaSecond * valorPecaSecond;
            Console.WriteLine("");
            
            Console.WriteLine("Valor total da segunda compra: R$" + valorTotalPecaSecond.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("");

            valorTotal = valorTotalPecaOne + valorTotalPecaSecond;

            Console.WriteLine("O valor total das duas compras foi: R$" + valorTotal.ToString("F2", CultureInfo.InvariantCulture) );
            
        }
    }
};

