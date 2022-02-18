using System;

namespace Esquerda_volver.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=1;
            char direcao;
            string comandos;
            

           while(n != 0)
            {

                Console.WriteLine("Indique o número de comandos que será efeutado:");
                n = System.Convert.ToInt32(Console.ReadLine());

                if(n == 0)
                {
                    break;
                }

                Console.WriteLine("Digite os comandos que serão passados ao recruta:");
                comandos = Console.ReadLine();

                direcao = 'N';

                char[] instrucoes = comandos.ToCharArray();


                for (int i = 0; i < instrucoes.Length; i++)
                {


                    if (instrucoes[i] == 'E')
                    {
                        switch (direcao)
                        {
                            case 'N':
                                direcao = 'O';
                                break;
                            case 'S':
                                direcao = 'L';
                                break;
                            case 'L':
                                direcao = 'N';
                                break;
                            case 'O':
                                direcao = 'S';
                                break;


                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Comando Inválido, reinicie o sistema..");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                        }
                    }

                    if (instrucoes[i] == 'D')
                    {
                        switch (direcao)
                        {
                            case 'N':
                                direcao = 'L';
                                break;
                            case 'S':
                                direcao = 'O';
                                break;
                            case 'L':
                                direcao = 'S';
                                break;
                            case 'O':
                                direcao = 'N';
                                break;

                        }

                    }
                }
                
                Console.WriteLine(direcao);
                Console.WriteLine("Aperte enter para continuar..");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}