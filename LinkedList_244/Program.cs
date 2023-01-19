namespace LinkedList_244
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Project For LinkedList Program");

            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(56);
            linkedList.AddLast(30);
            linkedList.AddLast(70);

            foreach (int item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}

