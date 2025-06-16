using System;

public class HapusBuku
{
    public void Hapus(LinkedListBuku daftar, string judul)
    {
        if (daftar.Head == null)
        {
            Console.WriteLine("Daftar buku kosong.");
            return;
        }

        if (daftar.Head.Judul == judul)
        {
            daftar.Head = daftar.Head.Next;
            Console.WriteLine($"Buku \"{judul}\" berhasil dihapus.");
            return;
        }

        LinkedListBuku.Node current = daftar.Head;
        while (current.Next != null && current.Next.Judul != judul)
        {
            current = current.Next;
        }

        if (current.Next == null)
        {
            Console.WriteLine($"Buku \"{judul}\" tidak ditemukan.");
        }
        else
        {
            current.Next = current.Next.Next;
            Console.WriteLine($"Buku \"{judul}\" berhasil dihapus.");
        }
    }
}
