using System;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
			//Console.Title = "Aplikasi Calculator"
            
			double a, b ;
			int pilihan;

			Console.WriteLine("Pilih Menu Calculator :");
			Console.WriteLine();
			Console.WriteLine("1. Penjumlahan");
			Console.WriteLine("2. Pengurangan");
			Console.WriteLine("3. Perkalian");
			Console.WriteLine("4. Pembagian");
			Console.WriteLine();
			Console.WriteLine("Input nomor menu[1-4]:");
			pilihan = int.Parse(Console.ReadLine());
			Console.WriteLine();
		
			if (pilihan == 1)
			{
				Console.WriteLine("Inputkan nilai a = ");
				a = double.Parse(Console.ReadLine());
				Console.WriteLine("Inputkan nilai b = ");
				b = double.Parse(Console.ReadLine());
				Console.WriteLine();
				Console.WriteLine("Hasil Penajumlahan {0} + {1} = {2}", a, b, penambahan(a, b));
			}

            else if (pilihan == 2)
			{
				Console.WriteLine("Inputkan nilai a = ");
				a = double.Parse(Console.ReadLine());
				Console.WriteLine("Inputkan nilai b = ");
				b = double.Parse(Console.ReadLine());
				Console.WriteLine();
				Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
            }

            else if (pilihan == 3)
            {
                Console.WriteLine("Inputkan nilai a = ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan nilai b = ");
                b = double.Parse(Console.ReadLine());
				Console.WriteLine();
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
            }

            else if (pilihan == 4)
            {
                Console.WriteLine("Inputkan nilai a = ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan nilai b = ");
                b = double.Parse(Console.ReadLine());
				Console.WriteLine();
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, pembagian(a, b));
            }
            else
            {
				Console.WriteLine();
                Console.WriteLine("Maaf, menu yang Anda pilih tidak tersedia");
				
            }
        }

        static double penambahan(double a, double b)
        {
            return a + b;
        }

        static double pengurangan(double a, double b)
        {
            return a - b;
        }

        static double perkalian(double a, double b)
        {
            return a * b;
        }

        static double pembagian(double a, double b)
        {
            return a / b;
        }        
    }
}