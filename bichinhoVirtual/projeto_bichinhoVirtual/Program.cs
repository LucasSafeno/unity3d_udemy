using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuBichinhoVirtual
{
    internal class Program
    {
        static void Main(String[] args)
        {
            
            /*
                O jogo mantem os dados do bichinho mesmo ao finalziar o game
                Iniciar o programa via prompt e coletar nome do bicho
                Coletar dados em um arquivo de texto (alimentado, feliz, limpo)

                de tempos em tempos vamos diminuir o valor de uma caracteritca do animal
            */
            string      nome = "";
            string      entrada = "";
            float       alimentado = 100;
            float       limpo = 100;
            float       feliz = 100;

            // DIminuir valores da caracteristicas do animal
            int caracteristica = 0;
            Random rand = new Random();


            Console.WriteLine("Meu Bichinho Virtual");

            // Coleta de dados
            if(args.Length > 0)
            {
                nome = args[0];
            }
            else
            {
                Console.WriteLine("Qual o nome do seu bichinho: ");
                nome = Console.ReadLine();
            }

            // Coletar os dados do animal no arquivo de texto
            entrada = "sim";
            while(entrada.ToLower() == "sim")
            {

            }

            Console.WriteLine("Obrigado por cuidar do seu bichinho");
            Console.WriteLine("Até outro dia!!");
            Console.ReadKey();
            

        }
    }
}