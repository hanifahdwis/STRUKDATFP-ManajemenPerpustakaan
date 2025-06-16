using System;

public class DaftarBuku
{
    public void Tampilkan(LinkedListBuku daftar)
    {
        if (daftar.Head == null)
        {
            Console.WriteLine("Belum ada buku dalam daftar.");
            return;
        }

        Console.WriteLine("Daftar Buku:");
        int no = 1;
        LinkedListBuku.Node current = daftar.Head;
        while (current != null)
        {
            Console.WriteLine($"{no}. {current.Judul}");
            current = current.Next;
            no++;
        }
    }
}

