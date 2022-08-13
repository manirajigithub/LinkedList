using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class linkedlist
    {
        internal Node head;

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
        }

        public Node Insert(int pos, int data)
        {
            Node newNode = new Node(data);
            Node temp = head;
            if (pos < 1)
            {
                Console.WriteLine("invalid position");
            }
            else if (pos == 1)
            {
                Node node = newNode;
                node.next = temp;
                head = node;
                Console.WriteLine("incert new node : " + node.data);
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
                Console.WriteLine("inserted new node : " + node.data);
            }
            return head;

        }
    }

}
