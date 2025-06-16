using System;

public class Node
{
    public string judul;
    public Node next;

    public Node(string judul)
    {
        this.judul = judul;
        this.next = null;
    }
}

public class ManajemenBuku
{
    private Node head;

    public ManajemenBuku()
    {
        head = null;
    }

    public void TambahBuku(string judul)
    {
        Node baru = new Node(judul);

        if (head == null)
        {
            head = baru;
        }
        else
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = baru;
        }

        Console.WriteLine("Buku \"" + judul + "\" berhasil ditambahkan.");
    }

    public void HapusBuku(string judul)
    {
        if (head == null)
        {
            Console.WriteLine("Daftar buku kosong.");
            return;
        }

        if (head.judul == judul)
        {
            Console.WriteLine("Buku \"" + head.judul + "\" dihapus.");
            head = head.next;
            return;
        }

        Node temp = head;
        while (temp.next != null && temp.next.judul != judul)
        {
            temp = temp.next;
        }

        if (temp.next == null)
        {
            Console.WriteLine("Buku \"" + judul + "\" tidak ditemukan.");
        }
        else
        {
            Console.WriteLine("Buku \"" + temp.next.judul + "\" dihapus.");
            temp.next = temp.next.next;
        }
    }

    public void DaftarBuku()
    {
        if (head == null)
        {
            Console.WriteLine("Belum ada buku.");
            return;
        }

        Console.WriteLine("Daftar Buku:");
        Node temp = head;
        int no = 1;
        while (temp != null)
        {
            Console.WriteLine(no + ". " + temp.judul);
            temp = temp.next;
            no++;
        }
    }
}
