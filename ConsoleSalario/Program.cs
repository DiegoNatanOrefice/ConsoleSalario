using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a forma de contratação (A - Assalariado, C - Comissionado, H - Horista): ");
            string contratacao = Console.ReadLine();

            double salarioliq = 0;

            switch (contratacao)
            {
                case "A":
                    Console.Write("Insira o salário bruto: ");
                    double asalariob = double.Parse(Console.ReadLine());
                    Console.Write("Insira o valor do desconto: ");
                    double adesconto = double.Parse(Console.ReadLine());
                    salarioliq = asalariob - adesconto;
                    break;

                case "C":
                    Console.Write("Insira a quantidade de peças vendidas: ");
                    int cvendas = int.Parse(Console.ReadLine());
                    Console.Write("Insira a comissão por peça vendida: ");
                    double ccomissao = int.Parse(Console.ReadLine());
                    salarioliq = cvendas * ccomissao;
                    break;

                case "H":
                    Console.Write("Insira a quantidade de horas trabalhadas: ");
                    int hhoras = int.Parse(Console.ReadLine());
                    Console.Write("Insira o valor da hora: ");
                    double hvalor = int.Parse(Console.ReadLine());
                    salarioliq = hhoras * hvalor;
                    break;
            }
            if (salarioliq <= 2000) 
            {
                salarioliq = salarioliq * 0.925;
                Console.Write("O salário líquido é: " + salarioliq);
                Console.ReadKey();
            }
            else if (salarioliq <= 4000)
            {
                salarioliq = salarioliq * 0.88;
                Console.Write("O salário líquido é: " + salarioliq);
                Console.ReadKey();
            }
            else if (salarioliq > 4000)
            {
                salarioliq = salarioliq * 0.85;
                Console.Write("O salário líquido é: " + salarioliq);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro");
            }
        }
    }
}
