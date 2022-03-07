
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nxn matrisin boyutunu giriniz");
            int boyut = Convert.ToInt32(Console.ReadLine());
            int boyuttutucu = 0;

            int[,] matris = new int[boyut, boyut];
            int[,] matris2 = new int[boyut, boyut];
            int[,] fark = new int[boyut, boyut];
            int[,] transpoz = new int[boyut, boyut];
            int[,] bolum = new int[boyut, boyut];


            for (int i = 0; i < boyut; i++)
            {
                for (int k = 0; k < boyut; k++)
                {
                    Console.WriteLine("Lütfen matris 1'  in  {0}x{1} elemanını giriniz", i + 1, k + 1);
                    matris[i, k] = Convert.ToInt32(Console.ReadLine());

                    boyuttutucu++;

                }


            }
            if (boyuttutucu == boyut * boyut)
            {
                for (int i = 0; i < boyut; i++)
                {
                    for (int k = 0; k < boyut; k++)
                    {
                        Console.WriteLine("Lütfen matris 2'nin {0}x{1} elemanını giriniz", i + 1, k + 1);
                        matris2[i, k] = Convert.ToInt32(Console.ReadLine());



                    }


                }

                Console.WriteLine();
                Console.WriteLine("iki matrisin farkı: ");

                for (int i = 0; i < boyut; i++)
                {

                    for (int k = 0; k < boyut; k++)
                    {

                        fark[i, k] = matris[i, k] - matris2[i, k];

                        Console.Write("{0}\t", fark[i, k]);
                    }

                    Console.WriteLine();
                }

                for (int j = 0; j <= boyut - 1; j++)
                {
                    for (int i = 0; i <= boyut - 1; i++)
                    {
                        transpoz[i, j] = matris2[j, i];
                    }
                    Console.WriteLine();







                }
                Console.WriteLine("iki matrisin bolumu: ");

                for (int i = 0; i < boyut; i++)
                {
                    for (int j = 0; j < boyut ; j++)
                    {
                        for (int k = 0; k < boyut; k++)
                        {
                            bolum[i, j] += matris[i, k] * transpoz[k, j];
                        }
                        Console.Write("{0}\t", bolum[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();


            }


        }

    }
    
 
} 


