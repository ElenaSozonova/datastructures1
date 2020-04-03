using System;
using System.Collections.Generic;
using System.Text;

namespace datastructures
{
    public class LinkedList 
    {
        private Node root; // хр ссылка на первый элемент 

        public int Lenght { get; private set; }

        public LinkedList() // созд пустого объекта
        {
            root = null;
            Lenght = 0;
        }

        public LinkedList(int a) // созд объекта на основе переменной 
        {
            root = new Node(a);
            Lenght = 1;
        }

        public LinkedList(int [] a) // созд объекта на основе массива 
        {
          int[] array = a;
          for (int i = 0; i < array.Length - 1; i++)
            {
                AddToEnd(a[i]);
            }
        }

        public void AddToEnd(int a) //доб в конец  1 элемента 
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

        public void AddToStart(int a) //доб в начало  1 элемента 
        {
            Node tmp = new Node(a); //созд новую ноду 
            tmp.Next = root; // она ссылается на знач, кот лежит в root 
            root = tmp; //root теперь ссылается на новую ноду 
            Lenght++; //увел длину 
        }

        public void AddByIndex(int a, int index) //добавление по индексу 1 элемента
        {
            Node tmp = new Node(a);
            Node following = root; //доп переменная - хранит 1ый элемент списка, потом будем шагать 

            if (Lenght == 0)// если длина = 0
            {
                root = new Node(a); //первый элемент = новой ноде
                Lenght = 1; //длина = 1
            }
            else
            {
                for (int i = 0; i < index - 1; i++) //от 0 до index-1 шагаем
                {

                    following = following.Next; // доп.переменная=ссылке на след.объект

                }
                tmp.Next = following.Next; //приравниваем ссылку на объект с нужным индексом 
                following.Next = tmp;
                Lenght++;
            }
        }

        public void DeleteFromStart() //удаление из начала 1 элемента
        {
            Node tmp = root;
            tmp = tmp.Next;
            root = tmp;
            Lenght--; 
        }

        public void DeleteFromEnd() //удаление из конца
        {
            Node tmp = root;
            for (int i = 0; i < Lenght - 2; i++)
            {
                tmp = tmp.Next;
            }
            tmp.Next = null;
            Lenght--;
        }

        public void DeleteByIndex(int index) //удаление по индексу 
        {
            if (index == 0)
            {
                DeleteFromStart();
            }
            else
            {
                Node following = root;

                for (int i = 0; i < index - 1; i++)
                {
                    following = following.Next;
                }
                following.Next = following.Next.Next; //переставляем ссылки
                Lenght--;
            }
        }

        public void Reverse() //реверс
        {
            Node tmproot = root;
            Node tmp;

            while (tmproot.Next != null) //пока ссылка на след переменную не равна null
            {
                tmp = tmproot.Next; // 'кладем' в tmp след переменную 
                tmproot.Next = tmproot.Next.Next; //'меняем' ссылки: след на через 1
                tmp.Next = root; // ??? 
                root = tmp; //в рут "кладем" запомненную tmp 
            }
        }

        public void SortUp ()
        {
           

        }



    }
}
