using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListUC7
{
    public class linkedlist
    {
        public Node head;

        public void Add(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Inserted in Linkedlist", node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("the list is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine("-------------------------------------------------------------------");
        }

        public Node Insert(int pos, int data)
        {
            Node newNode = new Node(data);
            Node temp = head;
            if (pos < 1)
            {
                Console.WriteLine("invalid ");
            }
            else if (pos == 1)
            {
                Node node = newNode;
                node.next = temp;
                head = node;
                Console.WriteLine("The New data is : " + node.data + "Inserted");
            }
            else
            {
                int p = 1;
                while (p != pos - 1)
                {
                    temp = temp.next;
                    pos++;
                }
                Node node = newNode;
                node.next = temp.next;
                temp.next = node;
                Console.WriteLine("The New data  " + node.data + "is Inserted");
            }
            return head;

        }
        internal void Pop()
        {
            if (head == null)
            {
                Console.WriteLine("Empty , Nothing to delete");
                return;
            }
            else
            {
                Console.WriteLine("Popped Item is {0}", head.data);


                Node temp = head;
                head = head.next;
                temp = head.next;
                //head=temp.next; 
            }
        }
        public Node DeleteLast()
        {

            Node node = head;

            if (head == null)
            {
                Console.WriteLine("Empty");
            }
            else if (head.next == null)
            {
                Console.WriteLine("The Last Data is :{0} ", node.data + "and its Deleted");
                head = null;
            }
            else
            {
                while (node.next.next != null)
                {
                    node = node.next;
                }
                Console.WriteLine("The Last Data is :{0} ", node.next.data + "and its Deleted");
                node.next = null;
            }
            return node;
        }
        public int Find(int val)
        {

            Node node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data == val)
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }
    }
}


