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
            Console.WriteLine($"{node.data} Add in to LinkedList");
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
        public void SearchAValue(int value)
        {
            Node temp = this.head;
            int find = 0;
            int i = 0;
            while (temp != null)
            {
                i++;
                if (temp.data == value)
                {
                    find++;
                    break;
                }
                temp = temp.next;
            }
            if (find == 1)
            {
                Console.WriteLine($"The position of value {value} is {i}");
            }
            else
            {
                Console.WriteLine("The value {0} not present in LinkedList", value);
            }
        }



        public void DisplayLnkLst()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("The LinkedList is Empty");
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
