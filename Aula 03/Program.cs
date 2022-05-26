using System;

namespace Aula_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
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
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
