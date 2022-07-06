using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2Prova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RA: 6322036
            //Nome : Vinícius Hernandes Pinheiro

            Console.WriteLine("Exercicio 2");

            Console.WriteLine("Lista de cidades e seus respectivos códigos ");
            Console.WriteLine("1 – Atibaia");
            Console.WriteLine("2 – Bragança Paulista");
            Console.WriteLine("3 – Mairiporã");
            Console.WriteLine("4 – Nazaré");
            Console.WriteLine("5 – Terra Preta");
            Console.WriteLine("6 – Extrema");
            Console.WriteLine("7 – Vargem");

            Console.Write("Digite o código da cidade se sua escolha: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            if (codigo >= 1 && codigo <= 7)
            {
                String codigoExtenso = null;

                switch (codigo)
                {
                    case 1:
                        codigoExtenso = "Atibaia";
                        break;

                    case 2:
                        codigoExtenso = "Bragança Paulista";
                        break;

                    case 3:
                        codigoExtenso = "Mairiporã";
                        break;

                    case 4:
                        codigoExtenso = "Nazaré";
                        break;

                    case 5:
                        codigoExtenso = "Terra Preta";
                        break;

                    case 6:
                        codigoExtenso = "Extrema";
                        break;

                    case 7:
                        codigoExtenso = "Vargem";
                        break;

                }

                Console.Write("\nDigite uma data de sua escolha(dd/mm/aaaa): ");

                var DataEscolhida = Convert.ToDateTime(Console.ReadLine());

                int dia = DataEscolhida.Day;

                int mes = DataEscolhida.Month;

                int ano = DataEscolhida.Year;

                String MesExtenso = null;

                switch (mes)
                {
                    case 1:
                        MesExtenso = "Janeiro";
                        break;

                    case 2:
                        MesExtenso = "Fevereiro";
                        break;

                    case 3:
                        MesExtenso = "Março";
                        break;

                    case 4:
                        MesExtenso = "Abril";
                        break;

                    case 5:
                        MesExtenso = "Maio";
                        break;

                    case 6:
                        MesExtenso = "junho";
                        break;

                    case 7:
                        MesExtenso = "Julho";
                        break;

                    case 8:
                        MesExtenso = "Agosto";
                        break;

                    case 9:
                        MesExtenso = "Setembro";
                        break;

                    case 10:
                        MesExtenso = "Outubro";
                        break;

                    case 11:
                        MesExtenso = "Novembro";
                        break;

                    case 12:
                        MesExtenso = "Dezembro";
                        break;
                }

                Console.WriteLine("\n" + codigoExtenso + ", " + dia + " de " + MesExtenso + " de " + ano);
            }

            else
            {
                Console.WriteLine("Digito invalido ");
            }

        }
    }
}
