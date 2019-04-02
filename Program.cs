using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letihanMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int hasil;

            Calculator calc = new Calculator();

            hasil = calc.Penjumlah(10, 2);
            CetakHasil("Hasil Penjumlahan : " + hasil);

            hasil = calc.Penjumlah(10, 2, 3);
            CetakHasil("Hasil Penjumlahan : " + hasil);

            hasil = calc.Pengurang(7, 2);
            CetakHasil("Hasil Pengurangan : " + hasil);

            hasil = Calculator.Perkalian(5, 2);
            CetakHasil("Hasil Perkalian : " + hasil);

            Console.ReadKey();
        }

        static void CetakHasil(string hasil)
        {
            Console.WriteLine(hasil);
        }
    }

    
}
