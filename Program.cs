using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08ListaseRepeticao
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();

            nomes.Add("Kennedy");
            nomes.Add("Natália");
            nomes.Add("Eduardo");

            int contador = 0;
            while (contador < 3 )
            {
                Console.WriteLine("Nome: " + nomes[contador] );
                contador++; 
            }



            Console.ReadKey();
        }
        void Loop()
        {

            //Laço de repetição (LOOP)

            int contador = 0;

            while (contador < 5)
            {
                Console.WriteLine("Hey bitch");
                contador = contador + 1;
            }



            Console.ReadKey();
        }
        void Listas()
        {
            // Listas -> Mesmo que o array, poém com tamanho automático
            List<string> nomes = new List<string>();

            nomes.Add("Jonatas");
            nomes.Add("Natanael");
            nomes.Add("Bruno");

            Console.WriteLine("O primeiro é " + nomes[0]);
            Console.WriteLine("O segundo é " + nomes[1]);
            Console.WriteLine("O terceiro é " + nomes[2]);

            Console.WriteLine("Digite o seu nome: ");
            nomes.Add(Console.ReadLine());

            nomes.Remove("Natanael");

            int quantidade = nomes.Count;
            Console.WriteLine($"Existem {quantidade} usuarios cadastrados!");



            Console.ReadKey();
        }
        void Arrays()
        {

            //Array -> Conjunto de dados (vetor)

            string[] nomes = new string[3];

            nomes[0] = "Kennedy";
            nomes[1] = "Eduardo";
            nomes[2] = "Natalia";

            Console.WriteLine("nome da primeira posição é" + nomes[0]);
            Console.WriteLine("nome da segunda posição é" + nomes[1]);
            Console.WriteLine("nome da terceira posição é" + nomes[2]);


            Console.ReadKey();

        }
    }
}
