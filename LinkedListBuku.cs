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
}

