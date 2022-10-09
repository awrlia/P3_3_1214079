using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_3_1214079
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var start = true;
            while (start)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Menu Persegi Panjang");
                Console.WriteLine("1. Menghitung Luas Persegi Panjang");
                Console.WriteLine("2. Menghitung Keliling Persegi Panjang");
                Console.WriteLine(" ");

                string a = Console.ReadLine();

                switch (a)
                {
                    case "Luas":
                        Console.WriteLine("Hitunglah Luas Persegi Panjang ");
                        Console.Write("Masukkan panjang: ");
                        var p = int.Parse(Console.ReadLine());
                        Console.Write("Masukkan lebar: ");
                        var lb = int.Parse(Console.ReadLine());
                        var ls = p * lb;
                        Console.WriteLine("Hasil Perhitungan Luas Persegi Panjang " + ls);
                        break;

                    case "luas":
                        Console.WriteLine("Hitunglah Luas Persegi Panjang ");
                        Console.Write("Masukkan panjang: ");
                        var p1 = int.Parse(Console.ReadLine());
                        Console.Write("Masukkan lebar: ");
                        var lb1 = int.Parse(Console.ReadLine());
                        var ls1 = p1 * lb1;
                        Console.WriteLine("Hasil Perhitungan Luas Persegi Panjang " + ls1);
                        break;

                    case "Keliling":
                        Console.WriteLine("Hitunglah Keliling Persegi Panjang ");
                        Console.Write("Masukkan panjang: ");
                        var p2 = int.Parse(Console.ReadLine());
                        Console.Write("Masukkan lebar: ");
                        var lb2 = int.Parse(Console.ReadLine());
                        int k = (p2 * 2) + (lb2 * 2);
                        Console.WriteLine("Hasil Perhitungan Keliling Persegi Panjang" + k);
                        break;

                    case "keliling":
                        Console.WriteLine("Hitunglah Keliling Persegi Panjang");
                        Console.Write("Masukkan panjang: ");
                        var p3 = int.Parse(Console.ReadLine());
                        Console.Write("Masukkan lebar: ");
                        var lb3 = int.Parse(Console.ReadLine());
                        int k1 = (p3 * 2) + (lb3 * 2);
                        Console.WriteLine("Hasil Perhitungan Keliling Persegi Panjang" + k1);
                        break;

                    default: Console.WriteLine("ERROR!!"); break;
                }
                Console.Write("Ulang Berhitung (Y/T): ");
                var input = Console.ReadLine();
                if (input == "T" || input == "t")
                {
                    Console.WriteLine("TERIMA KASIH !!");
                    start = false;
                } else
                {
                    start = true;
                }
            }
        }
    }
}
