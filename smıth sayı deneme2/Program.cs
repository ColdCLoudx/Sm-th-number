using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smıth_sayı_deneme2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BASADON:
            // sayının rakam toplamını aldık

            Console.WriteLine("sayı gır");
            Console.WriteLine("*********************");
            int sayı=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*********************");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("*********************");
            Console.WriteLine("rakamlar taranıyor");
            Console.WriteLine("*********************");
            Console.ReadLine() ;
            Console.Clear();


            int rakamtoplam = 0;

            

            string sayı2=sayı.ToString();
           

            for (int i = 0; i < sayı2.Length; i++)
            {
                char x = sayı2[i];
           
                int y = int.Parse(x.ToString());
                rakamtoplam = rakamtoplam + y;
            }
          
            Console.WriteLine("sayının rakam toplamı = "+rakamtoplam);
           


            //////////////////////////////////////////////


            // sımdı sayının asal rakam toplamlarını alıcaz

            int bolen = 2;
            int kalan;

            int tek_hanelı_rakam_toplam = 0;
            int cıft_hanelı_rakam_toplam = 0;
            while (sayı>1)
            {
                if (sayı%bolen!=0)
                {
                    bolen++;
                }
                else
                {
                    if (bolen>=10)
                    {
                        string bolen2=bolen.ToString();

                        for (int i = 0; i < bolen2.Length; i++)
                        {
                            char k = bolen2[i];
                            int l = int.Parse(k.ToString());
                            cıft_hanelı_rakam_toplam += l;
                        }
                        sayı = sayı / bolen;
                    }
                    else
                    {
                        tek_hanelı_rakam_toplam = tek_hanelı_rakam_toplam + bolen;
                        sayı = sayı / bolen;
                    }
                }

            }
            Console.WriteLine("sayının asallarının toplamı = "+(tek_hanelı_rakam_toplam+cıft_hanelı_rakam_toplam));
            Console.WriteLine();

            bool degısken=true;
            if (tek_hanelı_rakam_toplam + cıft_hanelı_rakam_toplam == rakamtoplam)
            {
               degısken = true;
            }
            else
            {
                degısken = false;
            }
           

            Console.WriteLine((tek_hanelı_rakam_toplam + cıft_hanelı_rakam_toplam) + "="+rakamtoplam+"\t"+"===>"+(degısken));
            if (tek_hanelı_rakam_toplam+cıft_hanelı_rakam_toplam==rakamtoplam)
            {
                Console.WriteLine("bu bir smith sayı");
            }
            else
            {
                Console.WriteLine("malesef bu bir smith sayı değil");
            }
            Console.ReadLine();
            Console.Clear();

            goto BASADON;

        }
    }
}
