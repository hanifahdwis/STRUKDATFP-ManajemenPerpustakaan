using System;

class Program
{
    static void Main()
    {
        LinkedListBuku daftar = new LinkedListBuku();
        int pilihan;

        do
        {
            Console.WriteLine("\n=== Sistem Perpustakaan ===");
            Console.WriteLine("1. Tambah Buku");
            Console.WriteLine("2. Hapus Buku");
            Console.WriteLine("3. Daftar Buku");
            Console.WriteLine("4. Keluar");
            Console.Write("Pilih menu: ");
            bool valid = int.TryParse(Console.ReadLine(), out pilihan);

            if (!valid)
            {
                Console.WriteLine("Input tidak valid.");
                continue;
            }

            switch (pilihan)
            {
                case 1:
                    Console.Write("Masukkan judul buku: ");
                    string judulTambah = Console.ReadLine();
                    TambahBuku.Tambah(daftar, judulTambah);
                    break;

                case 2:
                    Console.Write("Masukkan judul buku yang ingin dihapus: ");
                    string judulHapus = Console.ReadLine();
                    HapusBuku.Hapus(daftar, judulHapus);
                    break;

                case 3:
                    DaftarBuku.Tampilkan(daftar);
                    break;

                case 4:
                    Console.WriteLine("Program selesai.");
                    break;

                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }

        } while (pilihan != 4);
    }
}
