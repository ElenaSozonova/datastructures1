﻿using System;

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
            L.AddToEnd(5);
            Vivod(L.ReturnArray());
            L.AddToStart(8);
            Vivod(L.ReturnArray());
            L.AddByIndex(9, 3);
            Vivod(L.ReturnArray());
            //L.DeleteFromStart();
            //Vivod(L.ReturnArray());
            //L.DeleteFromEnd();
            //Vivod(L.ReturnArray());
            //L.DeleteByIndex(2);
            //Vivod(L.ReturnArray());
            L.Reverse();
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
