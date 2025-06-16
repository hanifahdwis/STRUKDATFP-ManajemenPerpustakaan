using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenPerpustakaan
{
    public class Node
    {
        public string nama;
        public string judul;
        public Node next;

        public Node(string nama, string judul)
        {
            this.nama = nama;
            this.judul = judul;
            this.next = null;
        }
    }
    
    public class HistoriBacaan
    {
        private Node top;

        public HistoriBacaan()
        {
            this.top = null;
        }

        public void Push(string nama, string judul)
        {
            Node newNode = new Node(nama, judul);
            newNode.next = top;
            top = newNode;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public void TampilkanHistori()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Histori Bacaan Kosong.");
                return;
            }

            Console.WriteLine("Histori Bacaan: ");
            Node current = top;
            while (current != null)
            {
                Console.WriteLine("- " + current.nama + " membaca " + current.judul);
                current = current.next;
            }
        }
    }
}