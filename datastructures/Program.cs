using System;

namespace datastructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList L = new LinkedList();
            L.AddToEnd(7);
            Vivod(L.ReturnArray());
            L.AddToEnd(6);
            Vivod(L.ReturnArray());
            L.AddToEnd(12);
            Vivod(L.ReturnArray());
            L.AddToStart(5);
            Vivod(L.ReturnArray());
            L.AddByIndex(1, 3);
            Vivod(L.ReturnArray());
            //L.DeleteFromStart();
            //Vivod(L.ReturnArray());
            //L.DeleteFromEnd();
            //Vivod(L.ReturnArray());
            //L.DeleteByIndex(2);
            //Vivod(L.ReturnArray());
            //L.Reverse();
            //Vivod(L.ReturnArray());
            //L.SortUp();
            //Vivod(L.ReturnArray());
            //L.SortDown();
            //Vivod(L.ReturnArray());
            //Console.WriteLine(L.SearchMax());
            //Console.WriteLine(L.MaxIndex());
            //Console.WriteLine(L.SearchMin());
            //Console.WriteLine(L.MinIndex());
            //Console.WriteLine(L.IndexByNumber(5));
            //L.СhangeByIndex(4, 11);
            //Vivod(L.ReturnArray());
            //L.DeleteFromNumber(5);
            //Vivod(L.ReturnArray());
            //Console.WriteLine(L.ReturnLength());
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
