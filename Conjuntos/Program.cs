using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria um conjunto de objetos
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            // Adiciona alementos
            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            // Exibe na tela
            Console.WriteLine("Conjunto A: ");
            foreach (int item in A)
            {                
                Console.Write($"{item} ");               
            }

            Console.WriteLine();

            Console.WriteLine("Conjunto B: ");
            foreach (int item in B)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            // Diferença entre conjunto ( A - B)
            A.ExceptWith(B);

            // União entre A e B (A + B)
            A.UnionWith(B);
            // Intersecção de A em B
            A.IntersectWith(B);

            Console.WriteLine("Intersecção de A em B: ");
            foreach (int item in A)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();            
            Console.WriteLine();

            Console.WriteLine("Aprendo sobre o git e o github");
            
            Console.Write("Digite um valor inteiro: ");
            int N = int.Parse(Console.ReadLine());

            if(B.Contains(N))
            {
                Console.WriteLine($"{N} petence ao conjunto B.");
            } else
            {
                Console.WriteLine($"{N} não pertence ao conjunto B.");
            } 
        }
    }
}
