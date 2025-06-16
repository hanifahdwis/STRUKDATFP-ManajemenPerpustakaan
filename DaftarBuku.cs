using System;

public class DaftarBuku
{
    public static void Tampilkan(LinkedListBuku daftar)
    {
        if (daftar.Head == null)
        {
            Console.WriteLine("Belum ada buku dalam daftar.");
            return;
        }

        Console.WriteLine("Daftar Buku:");
        int no = 1;
        var current = daftar.Head;
        while (current != null)
        {
            Console.WriteLine($"{no}. {current.Judul}");
            current = current.Next;
            no++;
        }
    }
}
