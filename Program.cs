namespace LinkedListUC4
{
    class Program
    {
        private static object linklist;

        static void Main(string[] args)
        {
            
            linkedlist linklist1 = new linkedlist();
            linklist1.Add(56);
            linklist1.Add(70);
            linklist1.Display();
            linklist1.Insert(2, 30);
        }
    }
}

