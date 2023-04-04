using System.Runtime.ConstrainedExecution;

namespace Aula02Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 11) Escreva um algoritmo para ler o número de eleitores de um município,
            // o número de votos brancos, nulos e válidos. 
            // Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.

            int numEleitores, votosBrancos, votosNulos, votosValidos; // Declaração das variáveis do tipo inteiro
            double percBrancos, percNulos, percValidos; // Declaração das variáveis do tipo double

            Console.Write("Digite o número de eleitores do município: "); // Exibe a mensagem na tela para que o usuário informe o número de eleitores
            numEleitores = int.Parse(Console.ReadLine()); // Lê o valor informado pelo usuário e atribui à variável numEleitores

            Console.Write("Digite o número de votos brancos: "); // Exibe a mensagem na tela para que o usuário informe o número de votos brancos
            votosBrancos = int.Parse(Console.ReadLine()); // Lê o valor informado pelo usuário e atribui à variável votosBrancos

            Console.Write("Digite o número de votos nulos: "); // Exibe a mensagem na tela para que o usuário informe o número de votos nulos
            votosNulos = int.Parse(Console.ReadLine()); // Lê o valor informado pelo usuário e atribui à variável votosNulos

            Console.Write("Digite o número de votos válidos: "); // Exibe a mensagem na tela para que o usuário informe o número de votos válidos
            votosValidos = int.Parse(Console.ReadLine()); // Lê o valor informado pelo usuário e atribui à variável votosValidos

            percBrancos = (double)votosBrancos / numEleitores * 100; // Calcula o percentual de votos brancos
            percNulos = (double)votosNulos / numEleitores * 100; // Calcula o percentual de votos nulos
            percValidos = (double)votosValidos / numEleitores * 100; // Calcula o percentual de votos válidos

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Percentual de votos brancos: {0:F2}%", percBrancos); // Exibe o percentual de votos brancos com duas casas decimais
            Console.WriteLine("Percentual de votos nulos: {0:F2}%", percNulos); // Exibe o percentual de votos nulos com duas casas decimais
            Console.WriteLine("Percentual de votos válidos: {0:F2}%", percValidos); // Exibe o percentual de votos válidos com duas casas decimais
        }
    }
}