using System;
using System.Collections.Generic;
using System.Text;

namespace datastructures
{
    public class LinkedList
    {
        private Node root; // хр ссылка на первый элемент 

        public int Lenght { get; private set; }

        public LinkedList()
        {
            root = null;
            Lenght = 0;
        }

        public LinkedList(int a)
        {
            root = new Node(a);
            Lenght = 1;
        }

        public void AddToEnd(int a) //доб в конец 
        {
            if (Lenght == 0)//(root==null)
            {
                root = new Node(a);
                Lenght = 1;
            }
            else if (Lenght == 1)//(root!=null&&root.Next==null) сам root сущ но никуда не ссылается 
            {
                root.Next = new Node(a);
                Lenght++;
            }
            else
            {
                Node tmp = root;  // доп переменная = первому элементу 
                while (tmp.Next != null)
                {
                    tmp = tmp.Next;   // tmp.Next внутри лежит ссылка на след объект     
                }
                tmp.Next = new Node(a); 
                Lenght++;
            }
        }

        public int[] ReturnArray() //пробр список в массив и возвр его 
        {
            int[] array = new int[Lenght]; //созд массив, кот будем возвращать 
            if (Lenght != 0)
            {
                int i = 0;
                Node tmp = root; //первый элемент 
                do
                {
                    array[i] = tmp.Value;
                    i++;
                    tmp = tmp.Next;
                } while (tmp != null);
            }
            return array;
        }

        public void AddToStart(int a) //доб в начало 
        {
            Node tmp = new Node(a); //созд новую ноду 
            tmp.Next = root; // она ссылается на знач, кот лежит в root 
            root = tmp; //root теперь ссылается на новую ноду 
            Lenght++; //увел длину 
        }

        public void AddToIndex(int a, int index)
        {
            
        }
    }
}
