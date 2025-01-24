using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace satranc_notasyon
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int eskisatir = 0;
            int eskiharfSayi = 0;
            bool sinav = true;
            string cevap2 = null;

            sorugetir();

            void sorugetir()
            {
                Console.Clear();
                
                Console.WriteLine(cevap2+" "+ sinav);

                Random random = new Random();
                Random randomsatir = new Random();
                int harfSayi = random.Next(0, 8);
                int satir = random.Next(0, 8);
                int yon = random.Next(0, 2);
                char chr = (char)('a' + harfSayi);
                int[,] tahta = new int[8, 8];



                // ▒▒  ██ ??
                string kare = Convert.ToString(chr) + (8 - satir);//yön=0 için doğru atama
                                                                  //Console.WriteLine(kare);

                if (yon == 0)
                {
                    tahta[satir, harfSayi] = 1;
                    if (sinav == false)
                    {
                        tahta[eskisatir, eskiharfSayi] = 2;
                    }

                }
                else
                {
                    tahta[7 - satir, 7 - harfSayi] = 1;
                }
                for (int i = 0; i < 8; i++)
                {
                    if (yon == 0)
                    {
                        Console.Write(8 - i + " ");
                    }
                    else
                    {
                        Console.Write(i + 1 + " ");
                    }
                    for (int j = 0; j < 8; j++)
                    {

                        if (tahta[i, j] == 1)
                        {
                            Console.Write("??");
                        }
                        else if (tahta[i, j] == 2)
                        {
                            Console.Write("▒▒");
                        }
                        else if ((j + i) % 2 == 0)
                        {
                            Console.Write("██");
                        }
                        else
                        {
                            Console.Write("  ");
                        }

                    }

                    Console.WriteLine();
                }

                string cevap = Console.ReadLine();
                cevap2 = cevap;
                if (cevap == kare)
                {
                    sinav = true;
                }
                else
                {
                    sinav = false;

                }
                eskiharfSayi = harfSayi;
                eskisatir = satir;
                sorugetir();
            }

        }
    }
}
