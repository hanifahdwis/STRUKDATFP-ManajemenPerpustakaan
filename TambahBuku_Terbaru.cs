using System;

public class TambahBuku
{
    public void Tambah(LinkedListBuku daftar, string judul)
    {
        LinkedListBuku.Node baru = new LinkedListBuku.Node(judul);

        if (daftar.Head == null)
        {
            daftar.Head = baru;
        }
        else
        {
            LinkedListBuku.Node current = daftar.Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = baru;
        }

        Console.WriteLine($"Buku \"{judul}\" berhasil ditambahkan.");
    }
}



