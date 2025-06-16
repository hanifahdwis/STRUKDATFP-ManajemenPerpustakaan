public class LinkedListBuku
{
    public class Node
    {
        public string Judul;
        public Node Next;

        public Node(string judul)
        {
            Judul = judul;
            Next = null;
        }
    }

    public Node Head;

    public LinkedListBuku()
    {
        Head = null;
    }

    public void TambahDepan(string judul)
    {
        Node newNode = new Node(judul);
        newNode.Next = Head;
        Head = newNode;
    }

    public void TambahSetelah(string setelahJudul, string judulBaru)
    {
        Node current = Head;
        while (current != null && current.Judul != setelahJudul)
        {
            current = current.Next;
        }

        if (current != null)
        {
            Node newNode = new Node(judulBaru);
            newNode.Next = current.Next;
            current.Next = newNode;
        }
        else
        {
            Console.WriteLine($"Buku dengan judul \"{setelahJudul}\" tidak ditemukan.");
        }
    }

    public void TambahAkhir(string judul)
    {
        Node newNode = new Node(judul);
        if (Head == null)
        {
            Head = newNode;
            return;
        }

        Node last = AmbilNodeTerakhir();
        last.Next = newNode;
    }

    private Node AmbilNodeTerakhir()
    {
        Node temp = Head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        return temp;
    }
}
