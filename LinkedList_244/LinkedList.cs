using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_244
{
    internal class LinkedList
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

                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine($"{node.data} Added in to LinkedList");
        }
        //public Node InserttoLnkLst(int position, int data)
        //{
        //    if (position < 0)
        //    {
        //        Console.WriteLine("Invalid position : Write a valid position");
        //    }
        //    if (position == 1)
        //    {
        //        Node newNode = new Node(data);
        //        newNode.next = this.head;
        //        head = newNode;

        //    }
        //    else
        //    {
        //        Node temp = this.head;
        //        while (position-- != 0)
        //        {
        //            if (position == 1)
        //            {
        //                Node node = new Node(data);
        //                node.next = this.head.next;
        //                head.next = node;
        //                break;
        //            }
        //            temp = temp.next;
        //        }
        //        if (position != 1)
        //        {
        //            Console.WriteLine("position Out Of Range");
        //        }
        //    }
        //    return head;

        //}
        public void InsertMethod(int newElement, int position)

        {

            Node newNode = new Node(newElement);
            newNode.data = newElement;
            newNode.next = null;

            if (position < 1)

            {

                Console.Write("\nposition should be >= 1.");

            }
            else if (position == 1)

            {

                newNode.next = head;

                head = newNode;

            }
            else

            {

                Node temp = new Node(newElement);
                temp = head;

                for (int i = 1; i < position - 1; i++)

                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }

                if (temp != null)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
                else
                {
                    Console.Write("\nThe previous node is null.");
                }
            }

        }
        public Node DeleteFirstElemt()
        {
            if (this.head == null)
            {
                Console.WriteLine("The LinkedList is Empty"); ;
            }
            this.head = head.next;
            return this.head;
        }
        public Node DeleteLastElement()
        {
            if (this.head == null)
            {
                return null;
            }
            if (this.head.next == null)
            {
                return null;
            }
            Node temp = this.head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;
            return head;

        }
        public void AddAfter(int exValue, int addValue)
        {
            int posi = SearchAValue(exValue);
            InsertMethod(addValue, posi + 1);
            Console.WriteLine($"Adding the value {addValue} after {exValue}");
        }
        public Node RemoveAElement(int value)
        {
            int position = SearchAValue(value);
            if (position == 1)
            {
                this.head = this.head.next;
            }
            else
            {
                Node temp = this.head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }
                if (temp != null)
                {
                    temp.next = temp.next.next;
                }
            }
            return this.head;
        }
        public int Size()
        {
            int count = 0;
            Node temp = this.head;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
        public int SearchAValue(int value)
        {
            Node temp = this.head;
            int position = 0, i = 0;
            while (temp != null)
            {
                i++;
                if (temp.data == value)
                {
                    position++;
                    break;
                }
                temp = temp.next;
            }
            return i;
        }

        public void SortedInsert(int data)

        {

            Node current;

            Node new_node = new Node(data);




            /* Special case for head node */

            if (head == null || (head.data.CompareTo(new_node.data) >= 0))

            {

                new_node.next = head;

                head = new_node;

            }
            else
            {
                current = head;
                while (current.next != null && (current.next.data.CompareTo(new_node.data)) < 0)
                {
                    current = current.next;
                }
                new_node.next = current.next;
                current.next = new_node;

            }

        }

        public void DisplayLnkLst()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("The LinkedList is Emptay");
                return;
            }
            else
            {

                while (temp != null)
                {
                    Console.Write(temp.data + "  ");
                    temp = temp.next;
                }

            }
        }
    }
}
