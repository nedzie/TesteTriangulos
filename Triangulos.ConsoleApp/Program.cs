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
            while (option != "s") // Aqui controla o programa
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
                    ladoZ = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");
                    Console.Clear();

                    if(ladoX > ladoY + ladoZ || ladoY > ladoZ + ladoX || ladoZ > ladoX + ladoY)
                    {
                        Console.WriteLine("Triângulo inválido, algum dos lados é maior que a soma dos outros, tente novamente!\n");
                    } else if(ladoY == ladoZ && ladoZ == ladoX)
                    {
                        Console.WriteLine("É um triângulo equilátero!\n");
                    } else if((ladoY == ladoZ && ladoY != ladoX) || (ladoX == ladoZ && ladoX != ladoY) || (ladoX == ladoY && ladoX != ladoZ)) {
                        Console.WriteLine("É um triângulo isósceles!\n");
                    } else if(ladoX != ladoY && ladoX != ladoZ)
                    {
                        Console.WriteLine("É um triângulo escaleno!\n");
                    }

                } else if(option != "s" && option != "1")
                {
                    Console.WriteLine("\nOpção inválida, tente novamente!\n");
                    continue;
                }
            }      
        }
    }
}