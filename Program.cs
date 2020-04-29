using System;

namespace PRG2_20192_P1_4_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //double alas;
            //double tinggi;
            //double Luas;
            //double Keliling;
            //double Hipotenusa;

            Console.WriteLine("MENU SEGITIGA SIKU-SIKU");
            Console.WriteLine("a. Hitung Luas");
            Console.WriteLine("b. Hitung Hipotenusa");
            Console.WriteLine("c. Hitung Keliling");
            Console.WriteLine("d. Keluar");
            Console.Write("Menu pilihan :");
            int pil = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            switch (pil)
            {
                case 1 : Console.Write("Masukkan alas : ");
                           double alas = Convert.ToDouble(Console.ReadLine());
                           Console.Write("Masukkan tinggi : ");
                           double tinggi = Convert.ToDouble(Console.ReadLine());
                           double Luas = (alas * tinggi)/2;
                           Console.Write("Luas segitiga dengan alas {0:0.00} dan tinggi {1:0.00} adalah : {2:0.00} ", alas, tinggi, Luas);
                           break;
                case 2 : Console.Write("Masukkan alas : ");
                           alas = Convert.ToDouble(Console.ReadLine());
                           Console.Write("Masukkan tinggi : ");
                           tinggi = Convert.ToDouble(Console.ReadLine());
                           double Hipotenusa = Math.Sqrt((alas * alas) + (tinggi * tinggi));
                           Console.Write("\nHipotenusa segitiga dengan alas {0:0.00} dan tinggi {1:0.00} adalah : {2:0.00} ", alas, tinggi, Hipotenusa);
                           break;
                case 3 : Console.Write("Masukkan alas : ");
                           alas = Convert.ToDouble(Console.ReadLine());
                           Console.Write("Masukkan tinggi : ");
                           tinggi = Convert.ToDouble(Console.ReadLine());
                           Console.Write("Masukkan hipotenusa : ");
                           Hipotenusa = Convert.ToDouble(Console.ReadLine());
                           Hipotenusa = Math.Sqrt((alas * alas) + (tinggi * tinggi));
                           double Keliling = alas + tinggi + Hipotenusa;
                           Console.Write("\nHipotenusa segitiga dengan alas {0:0.00} dan tinggi {1:0.00} adalah : {2:0.00} ", alas, tinggi, Keliling); ;
                           break;
                case 4 : Environment.Exit(0);
                          break;
            }
        }
    }
}
