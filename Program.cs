namespace LinkedListUC5
{
    class Program
    {
        static void Main(string[] args)
        {
            // To DeleteFirst
            linkedlist linklist1 = new linkedlist();
            linklist1.Add(56);
            linklist1.Add(30);
            linklist1.Add(70);
            linklist1.Pop();
            linklist1.Display();
        }
    }
}
