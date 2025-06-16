using System;
using STRUKDATFP_ManajemenPerpustakaan;

namespace PerpustakaanCLI
{
    class Program
    {
        static AntrianPeminjaman antrian = new AntrianPeminjaman(); 

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n=== Sistem Peminjaman Buku (Custom Queue - Linked List) ===");
                Console.WriteLine("1. Tambah Antrian Peminjaman");
                Console.WriteLine("2. Proses Antrian Peminjaman");
                Console.WriteLine("3. Lihat Antrian Saat Ini");
                Console.WriteLine("4. Keluar");
                Console.Write("Pilih menu: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        antrian.TambahAntrian();
                        break;
                    case "2":
                        antrian.ProsesAntrian(); 
                        break;
                    case "3":
                        antrian.LihatAntrian(); 
                        break;
                    case "4":
                        Console.WriteLine("Keluar dari sistem manajemen perpustakaan.");
                        return;
                    default:
                        Console.WriteLine("Pilihan tidak valid.");
                        break;
                }
            }
        }
    }
}
