using System;
namespace Exercicio_elevador.Classes
{
    public class ElevadorServico : Elevador
    {
        int NumCaixas = 0;
        int andarAtual = 0;
        int totalAndar = 10;
        int CapacidadeCaixa = 4;

        public void Adicionar()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($@"Você escolheu a opção Elevador de serviço
|=========================|            
| Número de caixas: {NumCaixas}     |
| Capacidade de caixas: 4 |
|=========================|
");
            Console.ResetColor();

            if (NumCaixas < CapacidadeCaixa)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Caso for entrar caixas para transportar no elevador digite a quantidade (EX: 1): ");
                Console.ResetColor();
                NumCaixas = int.Parse(Console.ReadLine());

                if (NumCaixas <= CapacidadeCaixa)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"\nEntraram caixas, agora o elevador possui {NumCaixas} caixas.\n");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nO elevador não suporta essa quantidade de caixa.\n");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não há capacidade para entrar mais caixas agora, espere ele retornar ao seu andar");
                Console.ResetColor();
            }
        }
        public void retirarCaixa()
        {
            int caixasSair;
            if (NumCaixas > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"Insira a quantidade de caixas que vão sair do elevador no {andarAtual}º andar: ");
                Console.ResetColor();
                caixasSair = int.Parse(Console.ReadLine());

                if (caixasSair <= NumCaixas)
                {
                    NumCaixas = NumCaixas - caixasSair;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"\n{caixasSair} caixas saíram do elevador no {andarAtual}º andar, restam {NumCaixas} caixas no elevador.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O elevador não possui essa quantidade de caixas no momento");
                    Console.ResetColor();
                }
            }

        }
        public void SubirCaixa()
        {

            if (andarAtual < totalAndar)
            {
                andarAtual = andarAtual + 1;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"O elevador foi para o {andarAtual}º andar com {NumCaixas} caixas.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O elevador já está no ultimo andar");
                Console.ResetColor();
            }

        }

    }
}