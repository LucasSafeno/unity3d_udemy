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
            string nome = "";
            string entrada = "";
            string nomeDono = "";    

            float alimentado = 100;
            float limpo = 100;
            float feliz = 100;

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

            Console.WriteLine("Oi, qual nome do meu dono ?");
            nomeDono = Console.ReadLine();

            Console.WriteLine("Legal, estava com muita saudade de você {0}", nomeDono);

            // Coletar os dados do animal no arquivo de texto
            entrada = "sim";
            while(entrada.ToLower() != "nada")
            {
                // ? Alterar status do animal
                // 0 - perder alimento 1 - perder limpeza 2 - feliz
                caracteristica = rand.Next(3);
                switch(caracteristica)
                {
                    case 0: 
                        alimentado -= rand.Next(20); 
                        break;

                    case 1:
                        limpo -= rand.Next(20);
                        break;
                    
                    case 2:
                        feliz -= rand.Next(20);
                        break;

                }

                Console.Clear();
                Console.WriteLine("Olá, {0} ", nomeDono);
                Console.WriteLine("Alimentado : {0}", alimentado);
                Console.WriteLine("Limpo : {0}", limpo);
                Console.WriteLine("Feliz : {0}", feliz);
                if(alimentado > 40 && alimentado < 60)
                {
                    Console.WriteLine("Eu estou faminto");
                    Console.WriteLine("Nada melhor que uma comidinha");
                }
                   if(limpo > 40 && limpo < 60)
                {
                    Console.WriteLine("Nossa, estou sujo");
                    Console.WriteLine("Preciso de um Banho");
                }
                   if(feliz > 40 && feliz < 60)
                {
                    Console.WriteLine("Fiquei em casa o dia todo");
                    Console.WriteLine("Vamos brincar hoje!");
                }

                Console.WriteLine("{0} O que vamos fazer hoje ?", nomeDono);
                Console.WriteLine("Brincar - Comer - Banho - NADA");
                entrada = Console.ReadLine().ToLower();

                switch(entrada)
                {
                    case "Brincar":
                        feliz += rand.Next(30);
                        break;
                    case "Comer":
                        alimentado += rand.Next(30);
                        break;
                    case "Banho":
                        limpo += rand.Next(30);
                        break;

                }
                
                if (feliz > 100) feliz = 100;
                if (alimentado > 100) alimentado = 100;
                if (limpo > 100) limpo = 100;

            }

            Console.WriteLine("Obrigado por cuidar do seu bichinho");
            Console.WriteLine("Até outro dia!!");
            Console.ReadKey();
            

        }
    }
}