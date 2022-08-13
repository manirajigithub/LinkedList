namespace LinkedListUC7
{
    class Program
    {
        static void Main(string[] args)
        {
            linkedlist linklist4 = new linkedlist();
            linklist4.Add(56);
            linklist4.Add(30);
            linklist4.Add(70);
            linklist4.Display();
            linklist4.Find(30);
        }
    }
}
