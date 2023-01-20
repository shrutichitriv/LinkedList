using System.Collections.Generic;

namespace LinkedList_244
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Project For LinkedList Program");

            LinkedList myLinkedList = new LinkedList();
            myLinkedList.Add(56);
            myLinkedList.Add(30);
            myLinkedList.Add(70);

            myLinkedList.AddAfter(30, 40);

            Console.WriteLine("Befour Remove");
            myLinkedList.DiaplayLnkLst();


            myLinkedList.RemoveAElement(40);
            Console.WriteLine();
            Console.WriteLine("After Remove");
            myLinkedList.DiaplayLnkLst();
            Console.WriteLine();
            Console.WriteLine("Size of the linledlist is : " + myLinkedList.Size());
        }
    }
}

