namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to LinkedList");
            linkedlist linklist = new linkedlist();
            linklist.Add(50);
            linklist.Add(36);
            linklist.Add(70);
            linklist.Display();
        }
    }
}
