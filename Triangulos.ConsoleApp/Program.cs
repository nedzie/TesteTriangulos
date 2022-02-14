using System;

namespace Triangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variáveis
            string option = "";
            double ladoX, ladoY, ladoZ;
            while (option != "s") // Verifique se a opção é válida
            {
                Console.WriteLine("Digite '1' para verificar um triângulo, ou então 's' para sair: ");
                option = Console.ReadLine();
                if(option == "1")
                {
                    Console.Clear();
                    Console.WriteLine("-= Verificador de triangulos =-");
                    Console.WriteLine("Digite o eixo X: ");
                    ladoX = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o eixo Y: ");
                    ladoY = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o eixo Z: ");
                    ladoZ = Convert.ToDouble(Console.ReadLine()); // Receba os valores
                    Console.WriteLine("");
                    Console.Clear();

                    if(ladoX > ladoY + ladoZ || ladoY > ladoZ + ladoX || ladoZ > ladoX + ladoY) // Se algum dos lados for maior que a soma dos outros dois
                    {
                        Console.WriteLine("Triângulo inválido, algum dos lados é maior que a soma dos outros, tente novamente!\n");
                    } 
                    else if(ladoY == ladoZ && ladoZ == ladoX) // Se A == B, e B == C, logo A == B
                    {
                        Console.WriteLine("É um triângulo equilátero!\n");
                    } 
                    else if((ladoY == ladoZ && ladoY != ladoX) || (ladoX == ladoZ && ladoX != ladoY) || (ladoX == ladoY && ladoX != ladoZ)) // Se A == B e != C, A == C & != B, B == C & != A
                    {
                        Console.WriteLine("É um triângulo isósceles!\n");
                    } 
                    else if(ladoX != ladoY && ladoX != ladoZ) // Se todos forem diferentes
                    {
                        Console.WriteLine("É um triângulo escaleno!\n");
                    }

                } else if(option != "s" && option != "1")// Se for escolhida uma opção inválida
                {
                    Console.WriteLine("\nOpção inválida, tente novamente!\n"); // Informe o erro
                    continue; // E continue o laço de repetição
                }
            }      
        }
    }
}