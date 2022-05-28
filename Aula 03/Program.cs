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

                    switch (escolherOpe)
                    {
                        case "A":
                            Console.WriteLine("Qual numero de X");
                            int x = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Qual numero de Y");
                            int y = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(x == y);
                            break;

                        case "B":
                            Console.WriteLine("Qual numero de X");
                            int n1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Qual numero de Y");
                            int n2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(n1 != n2);
                            break;
                        case "C":
                            Console.WriteLine("Qual numero de X");
                            int n3 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Qual numero de Y");
                            int n4 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(n3 == n4);
                            break;
                        case "D":
                            Console.WriteLine("Qual numero de X");
                            int n5 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Qual numero de Y");
                            int n6 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(n5 == n6);
                            break;
                        case "E":
                            Console.WriteLine("Qual numero de X");
                            int n7 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Qual numero de Y");
                            int n8 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(n7 == n8);
                            break;
                        case "F":
                            Console.WriteLine("Qual numero de X");
                            int n9 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Qual numero de Y");
                            int n10 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(n9 == n10);
                            break;
                        default:
                            return;
                    }

                    break;

                case 2:
                    Console.WriteLine("Qual seu horario?");
                    int time = Convert.ToInt32(Console.ReadLine());
                    if (time < 12)
                    {
                        Console.WriteLine("Bom dia");
                    }
                    if (time <= 17)
                    {
                        Console.WriteLine("Boa Tarde");
                    }
                    if (time <= 18)
                    {
                        Console.WriteLine("Boa Noite");
                    }
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
