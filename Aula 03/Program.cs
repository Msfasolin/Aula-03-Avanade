using System;

namespace Aula_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Operadores de Comparação");
            Console.WriteLine("2 - Quais são as horas do dia? ");

            int escolher = Convert.ToInt32(Console.ReadLine());


            switch (escolher)
            {
                case 1:
                    Console.WriteLine("A- ==");
                    Console.WriteLine("B- !=");
                    Console.WriteLine("C- >");
                    Console.WriteLine("D- <");
                    Console.WriteLine("E- >=");
                    Console.WriteLine("F- <=");
                    String escolherOpe = Console.ReadLine();

                    break;


   
                default:
                    Console.WriteLine("Não existe números");
                    break;
            }

            // While Loop
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            // OU
            int f = 0;
            do
            {
                Console.WriteLine(f);
                f++;
            }
            while (f < 5);


            // FOR Loop
            for (int a = 0; a < 5; a++)
            {
                Console.WriteLine(a);
            }

            for (int b = 0; b <= 10; b = b + 2)
            {
                Console.WriteLine(b);
            }


            // foreach loop
            string[] cars = { "Vermelho", "Preto", "Cinza", "Branco" };
            foreach (string c in cars)
            {
                Console.WriteLine(c);
            }
        }
    }
}
