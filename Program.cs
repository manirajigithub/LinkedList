namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //To InsertDataInBetween
            LinkedList linked = new LinkedList();
            linked.InsertAtLast(56);
            linked.InsertAtLast(30);
            linked.InsertAtLast(70);
            linked.DisplayList();
            linked.InsertAtSpecifiedposition(30, 40);
            linked.search(30);
            linked.DisplayList();
            
        }
    }
}
