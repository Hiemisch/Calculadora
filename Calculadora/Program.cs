using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            Stack<decimal> pilhaResultados = new Stack<decimal>();

            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' });

            Calculadora calculadora = new Calculadora();

            while (filaOperacoes.Count > 0)
            {
                Operacoes operacao = filaOperacoes.Dequeue();
                calculadora.calcular(operacao);
                pilhaResultados.Push(operacao.resultado);

                Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA, operacao.operador, operacao.valorB, operacao.resultado);

                Console.WriteLine("\nOperações restantes:");
                foreach (var op in filaOperacoes)
                {
                    Console.WriteLine("{0} {1} {2}", op.valorA, op.operador, op.valorB);
                }
                Console.WriteLine("----------------------");
                Console.WriteLine();
            }

            Console.WriteLine("Resultados:");
            var listaTemp = new List<decimal>(pilhaResultados);
            listaTemp.Reverse();
            foreach (var resultado in listaTemp)
            {
                Console.WriteLine(resultado);
            }

            // Wait for user input to prevent the program from closing
            Console.WriteLine("Pressione Enter para sair...");
            Console.ReadLine();
        }
    }

}
