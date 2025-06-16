using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenPerpustakaan
{
    public class Node
    {
        public string bacaan;
        public Node next;

        public Node(string bacaan)
        {
            this.bacaan = bacaan;
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

        public void Push(string item)
        {
            Node newNode = new Node(item);
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
                Console.WriteLine("- " + current.bacaan);
                current = current.next;
            }
        }
    }
}