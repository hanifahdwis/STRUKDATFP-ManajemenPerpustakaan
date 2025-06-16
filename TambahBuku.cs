using System;

public class TambahBuku
{
    public static void Tambah(LinkedListBuku daftar, string judul)
    {
        var baru = new LinkedListBuku.Node(judul);

        if (daftar.Head == null)
        {
            daftar.Head = baru;
        }
        else
        {
            var current = daftar.Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = baru;
        }

        Console.WriteLine($"Buku \"{judul}\" berhasil ditambahkan.");
    }
}
