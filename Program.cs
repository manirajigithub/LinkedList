namespace LinkedListUC6
{
    class Program
    {


        static void Main(string[] args)
        {
            //To DeleteLast
            linkedlist linklist3 = new linkedlist();
            linklist3.Add(56);
            linklist3.Add(30);
            linklist3.Add(70);
            linklist3.DeleteLast();
            linklist3.Display();
        }
    }
}


