using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATPS
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            int resul = 0, aux;
            
            while (resul != 5)
            {
                aux = 1;
                Console.WriteLine("########### CALCULADORA ##########");
                Console.WriteLine("# Escolha uma das opções abaixo: #");
                Console.WriteLine("#        (1) - Soma              #");
                Console.WriteLine("#        (2) - Subtração         #");
                Console.WriteLine("#        (3) - Multiplicação     #");
                Console.WriteLine("#        (4) - Divisão           #");
                Console.WriteLine("#        (5) - Sair              #");
                Console.WriteLine("##################################");
                Console.Write("Digite sua opção: ");
                resul = int.Parse(Console.ReadLine());
                if (resul == 1)
                { while (aux == 1)
                    {
                        Console.WriteLine("########## SOMA ##########");
                        Console.Write("Digite o primeiro número: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        num2 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Resultado da Soma = " + (num1 + num2));

                        Console.Write("Digite (1) para continuar nessa operação ou (2) para retornar ao Menu: ");
                        aux = int.Parse(Console.ReadLine());
                        Console.Clear();
                    }
                }
                if (resul == 2)
                { while (aux == 1)
                    {
                        Console.WriteLine("########## SUBTRAÇÃO ##########");
                        Console.Write("Digite o primeiro número: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        num2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Resultado da Subtração = " + (num1 - num2));

                        Console.Write("Digite (1) para continuar nessa operação ou (2) para retornar ao Menu: ");
                        aux = int.Parse(Console.ReadLine());
                        Console.Clear();
                    }
                }
                if (resul == 3)
                { while (aux == 1)
                    {
                        Console.WriteLine("########## MULTIPLICAÇÃO ##########");
                        Console.Write("Digite o primeiro número: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        num2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Resultado da Multiplicação = " + (num1 * num2));

                        Console.Write("Digite (1) para continuar nessa operação ou (2) para retornar ao Menu: ");
                        aux = int.Parse(Console.ReadLine());
                        Console.Clear();
                    }
                }
                if (resul == 4)
                { while (aux == 1)
                    {
                        Console.WriteLine("########## DIVISÃO ##########");
                        Console.Write("Digite o dividendo: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o divisor: ");
                        num2 = double.Parse(Console.ReadLine());
                        while (num2 == 0)
                        {
                            Console.WriteLine("Não é possível dividir por Zero!");
                            Console.Write("Digite um novo divisor: ");
                            num2 = double.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Resultado da Divisão = " + (num1 / num2));

                        Console.Write("Digite (1) para continuar nessa operação ou (2) para retornar ao Menu: ");
                        aux = int.Parse(Console.ReadLine());
                        Console.Clear();
                    }
                }
                if (resul == 5)
                {
                    Environment.Exit(0);
                }
                if ((resul <= 0) || (resul >= 6))
                {
                    Console.Write("Opção incorreta! Tecle ENTER para escolher uma nova opção. ");
                    Console.ReadKey();
                }
                
                Console.Clear();
            }
    }
    }
}