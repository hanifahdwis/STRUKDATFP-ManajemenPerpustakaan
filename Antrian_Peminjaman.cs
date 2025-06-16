using System;

namespace STRUKDATFP_ManajemenPerpustakaan
{
    public class Peminjaman
    {
        public string Nama { get; set; }
        public string Judul { get; set; }

        public Peminjaman(string nama, string judul)
        {
            this.Nama = nama;
            this.Judul = judul;
        }
        public override string ToString()
        {
            return $"{Nama} - \"{Judul}\"";
        }

    }

    public class LinkedListQueue<T>
    {
        private class Node
        {
            public T Data;
            public Node Next;

            public Node(T data)
            {
                this.Data = data;
                this.Next = null;
            }
        }

        private Node head;
        private Node tail;

        public LinkedListQueue()
        {
            head = null;
            tail = null;
        }

        public void Enqueue(T item)
        {
            Node newNode = new Node(item);
            if (tail != null)
            {
                tail.Next = newNode;
            }
            tail = newNode;
            if (head == null)
            {
                head = newNode;
            }
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            T item = head.Data;
            head = head.Next;
            if (head == null)
            {
                tail = null;
            }
            return item;
        }

        public bool IsEmpty()
        {
            return head == null;
        }
        public void PrintAll()
        {
            Node current = head;
            int nomor = 1;
            while (current != null)
            {
                Console.WriteLine($"{nomor++}. {current.Data}");
                current = current.Next;
            }
        }
    }

    public class AntrianPeminjaman
    {
        private LinkedListQueue<Peminjaman> antrian = new LinkedListQueue<Peminjaman>();

        public void TambahAntrian()
        {
            Console.Write("Masukkan nama peminjam: ");
            string nama = Console.ReadLine();
            Console.Write("Masukkan judul buku yang ingin dipinjam: ");
            string judul = Console.ReadLine();

            Peminjaman peminjaman = new Peminjaman(nama, judul);
            antrian.Enqueue(peminjaman);
            Console.WriteLine($"{nama} telah masuk ke antrian untuk meminjam buku \"{judul}\".");
        }

        public void ProsesAntrian()
        {
            if (antrian.IsEmpty())
            {
                Console.WriteLine("Tidak ada antrian peminjaman saat ini.");
                return;
            }

            Peminjaman diproses = antrian.Dequeue();
            Console.WriteLine($"Memproses peminjaman: {diproses.Nama} meminjam buku \"{diproses.Judul}\".");
        }

        public void LihatAntrian()
        {
            if (antrian.IsEmpty())
            {
                Console.WriteLine("Antrian kosong.");
                return;
            }

            Console.WriteLine("Daftar antrian peminjaman:");
            antrian.PrintAll();
        }
    }
}
