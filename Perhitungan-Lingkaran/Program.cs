using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Program Menghitung Luas Lingkaran");
        Console.WriteLine(new string('-', 35));

        // Meminta pengguna memasukkan jari-jari lingkaran dalam sentimeter
        Console.Write("   Masukkan panjang jari-jari dalam sentimeter: ");
        double jariJariCm = Convert.ToDouble(Console.ReadLine());

        // Menghitung luas lingkaran dalam sentimeter
        double luasLingkaranCm = HitungLuasLingkaran(jariJariCm);

        // Menampilkan hasil
        Console.WriteLine("\n   Luas Lingkaran dengan jari-jari {0} cm adalah {1:F2} cm^2", jariJariCm, luasLingkaranCm);
    }

    // Fungsi untuk menghitung luas lingkaran dalam sentimeter
    static double HitungLuasLingkaran(double jariJariCm)
    {
        // Rumus luas lingkaran: π * r^2
        double luas = Math.PI * Math.Pow(jariJariCm, 2);
        return luas;
    }
}
