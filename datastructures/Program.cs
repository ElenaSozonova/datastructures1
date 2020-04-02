using System;

namespace datastructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList L = new LinkedList();
            L.AddToEnd(1);
            Vivod(L.ReturnArray());
            L.AddToEnd(2);
            Vivod(L.ReturnArray());
            L.AddToEnd(3);
            Vivod(L.ReturnArray());
            L.AddToStart(0);
            Vivod(L.ReturnArray());
            L.AddToIndex(9, 1);
            Vivod(L.ReturnArray());
        }

        static void Vivod(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
