// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace ManajemenPerpustakaan
{
    class Program
    {
        static HistoriBacaan histori = new HistoriBacaan();

        static void Main()
        {
            int pilihan;
            do
            {
                Console.Clear();
                Console.WriteLine("=== MENU HISTORI PEMINJAMAN ===");
                Console.WriteLine("1. Tambah Bacaan Baru");
                Console.WriteLine("2. Tampilkan Semua Histori");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilih menu: ");
                bool valid = int.TryParse(Console.ReadLine(), out pilihan);
                Console.Clear();

                if (!valid)
                {
                    Console.WriteLine("Input tidak valid. Tekan Enter untuk kembali.");
                    Console.ReadLine();
                    continue;
                }

                switch (pilihan)
                {
                    case 1:
                        Console.Write("Masukkan nama pembaca: ");
                        string nama = Console.ReadLine();
                        Console.Write("Masukkan judul bacaan: ");
                        string judul = Console.ReadLine();
                        histori.Push(nama, judul);
                        Console.WriteLine("Bacaan berhasil ditambahkan ke histori.");
                        break;

                    case 2:
                        histori.TampilkanHistori();
                        break;

                    case 3:
                        Console.WriteLine("Keluar dari program. Sampai jumpa!");
                        break;

                    default:
                        Console.WriteLine("Menu tidak tersedia.");
                        break;
                }

                Console.WriteLine("\nTekan Enter untuk selesai.");
                Console.ReadLine();

            } while (pilihan != 3);
        }
    }
}