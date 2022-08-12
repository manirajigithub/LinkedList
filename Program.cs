namespace LinkedListUC2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList");
            linkedlist linklist = new linkedlist();
            linklist.Add(70);
            linklist.Add(30);
            linklist.Add(56);
            linklist.Display();
        }
    }
}

