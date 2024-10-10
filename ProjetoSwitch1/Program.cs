using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSwitch1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Trabalhando com controle de fluxo Switch Case
            int diaSemana;

            Console.WriteLine("Informe um numero de 1 a 7: ");
            diaSemana=Convert.ToInt32(Console.ReadLine());

            //Atalho para Switch Case
            //Escrever Switch Case + tab tab
            switch (diaSemana)
            {
                case 1:
                    Console.WriteLine("2ª Feira");
                    break;
                    case 2:
                    Console.WriteLine("3ª Feira");
                    break;
                    case 3:
                    Console.WriteLine("4ª Feira");
                    break;
                    case 4:
                    Console.WriteLine("5ª Feira");
                    break;
                    case 5:
                    Console.WriteLine("6ª Feira");
                    break;
                    case 6:
                    Console.WriteLine("Sabado");
                    break;
                    case 7:
                    Console.WriteLine("Domingo");
                    break;

                    default:
                    Console.WriteLine("Valor Incorreto!");
                    break;

            }


            Console.ReadKey();
        }
    }
}
