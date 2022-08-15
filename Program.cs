namespace LinkedListUC9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //To DeleteDataInBetween
            linkedlist linklist6 = new linkedlist();
            linklist6.Add(56);
            linklist6.Add(30);
            linklist6.Add(40);
            linklist6.Add(70);
            linklist6.DeleteBetween(40);
            linklist6.Display();
        }
    }
}