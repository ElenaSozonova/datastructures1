using System;
using System.Collections.Generic;
using System.Text;

namespace datastructures
{
    public class ArrayList : Interface1
    {
        private int[] array;
        private int length;

        public int this[int a] // ArrayList a=new....  a[6]=  РАЗОБРАТЬСЯ!
        {
            get { return array[a]; }
            set { array[a] = value; }
        }


        public int[] ReturnArray() //метод возвращает массив 
        {
            int[] arrayToReturn = new int[length];
            for (int i = 0; i < length; i++)
            {
                arrayToReturn[i] = array[i];
            }

            return arrayToReturn;
        }

        public ArrayList() //созд пустой массив
        {
            array = new int[0];
            length = 0;
        }

        public ArrayList(int a) //созд пустой массив для доб 1 элемента
        {
            array = new int[1] { a };
            length = 1;
        }

        public ArrayList(int[] a) //созд пустой массив для доб нескольких элементов 
        {
            array = a;
            length = a.Length;
        }

        private void UpArraySize() // метод расширения массива 
        {
            int newL = Convert.ToInt32(array.Length * 1.3d + 1);
            int[] newArray = new int[newL];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }

        public void AddToEnd(int a) //метод добавления в конец 1 числа
        {
            if (length >= array.Length) // проверяем, хватает ли длины 
            {
                UpArraySize();
            }

            array[length] = a; //на последнее место ставим а
            length++; // увеличиваем дл на 1 
        }

        public void AddToEnd(int[] a) //метод добавления в конец массива чисел 
        {
            while (length + a.Length > array.Length)
            {
                UpArraySize();
            }

            for (int i = 0; i < a.Length; i++)
            {
                array[length + i] = a[i];
            }

            length += a.Length; //увеличиваем на ??? 
        }

        public void AddToStart(int a) //метод добавления в начало 1 числа
        {
            if (length >= array.Length) // проверяем, хватает ли длины 
            {
                UpArraySize();
            }

            for (int i = length; i > 0; i--) // идем с конца
            {
                array[i] = array[i - 1]; //сдвигаем на 1. 
            }
            array[0] = a; //на первое место ставим а
            length++; // увеличиваем дл на 1 
        }

        public void AddToStart(int[] a) //метод добавления в начало массива чисел 
        {
            while (length + a.Length > array.Length) // пока дл старого массива + дл встраиваемого массива
            {
                UpArraySize();
            }

            for (int i = array.Length - a.Length; i > 0; i--)
            {
                array[i + a.Length - 1] = array[i - 1];
            }
            for (int i = 0; i < a.Length; i++)
            {
                array[i] = a[i];
            }
            length += a.Length; //увеличиваем на количество эл-в нового массива 
            //увеличиваем на количество эл-в нового массива 
        }

        public void AddByIndex(int a, int index) //метод добавления по индексу 
        {
            if (length >= array.Length) // проверяем, хватает ли длины 
            {
                UpArraySize();
            }

            for (int i = length; i > index; i--) // идем с конца до индекса
            {
                array[i] = array[i - 1]; //сдвигаем на 1. 
            }
            array[index] = a; //на место индекса ставим а
            length++; // увеличиваем дл на 1 
        }

        public void DeleteByIndex(int index) //метод удаления по индексу 
        {

            for (int i = index; i < length - 1; i++)
            {
                array[i] = array[i + 1]; //сдвигаем на 1. 
            }
            length--; // уменьшаем длину на 1 
        }


        public void DeleteFromStart() //метод удаления из начала 1 элемента
        {
            for (int i = 1; i < length; i++) // идем с начала
            {
                array[i - 1] = array[i]; //сдвигаем на 1. 
            }
            length--; // уменьшаем на 1
        }

        public void DeleteFromEnd() //метод удаления из конца 1 элемента
        {
            length--; // уменьшаем на 1
        }

        public void SortUp() // сортировка вставками по возрастанию
        {
            int q;
            int j;

            for (int i = 1; i < length; i++)
            {
                j = i;

                while ((j >= 1 && array[j] < array[j - 1]))
                {
                    q = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = q;
                    j--;
                }
            }
        }

        public void SortDown() // сортировка вставками по убыванию
        {
            int q;
            int j;

            for (int i = 1; i < length; i++)
            {
                j = i;
                while ((j >= 1 && array[j] > array[j - 1]))
                {
                    q = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = q;
                    j--;
                }
            }
        }

        public void Revers() //реверс
        {
            int q;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    q = array[i];
                    array[i] = array[j];
                    array[j] = q;
                }
            }
        }

        public void DeleteFromEnd(int a) //метод удаления из конца N элементов
        {
            length = length - a;
        }

        public void DeleteFromStart(int a) //метод удаления из начала N элементов
        {

            for (int i = 0; i < length - a; i++)
            {
                array[i] = array[i + a];
            }

            length = length - a;
        }


        public void DeleteByIndex(int n, int index) //метод удаления по индексу N эл-в
        {

            for (int i = index; i < length - n; i++)
            {
                array[i] = array[i + n];
            }
            length = length - n;
        }



        public void AddByIndex(int[] a, int index) //метод добавления массива по индексу  
        {
            while (length + a.Length > array.Length)
            {
                UpArraySize();
            }

            for (int i = length + a.Length - 1; i >= index + a.Length; i--)
            {
                array[i] = array[i - a.Length];

            }

            for (int i = index; i < index + a.Length; i++)
            {
                array[i] = a[i - index];
            }

            length = length + a.Length;
        }

        //public void DeleteFromNumber(int a) //удаление по значению  первый вариант
        //{

        //    for (int i = length - 1; i >= 0; i--)
        //    {
        //        if (array[i] == a)
        //        {
        //            for (int j = i + 1; j < length; j++)
        //            {
        //                array[j - 1] = array[j];
        //            }
        //            --length;
        //        }
        //    }
        //}

        public void DeleteFromNumber(int a) //удаление по значению  второй вариант 
        {
            int k = 0;
            int i = 0;

            while (i < length - k)
            {
                if (array[i] == a)
                {
                    for (int j = i; j < length - k - 1; ++j)
                        array[j] = array[j + 1];

                    ++k;
                }
                else
                    ++i;
            }

            length = length - k;

        }

        public int IndexAccess(int index)  //доступ по индексу
        {
            int number;
            number = array[index];
            return number;
        }

        public void СhangeByIndex(int index, int number)  //изменить по индексу
        {
            array[index] = number;
        }

        public int SearchMax() //поиск максимума
        {
            int max = array[0];

            for (int i = 0; i < length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public int SearchMin() //поиск минимума
        {
            int min = array[0];

            for (int i = 0; i < length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public int ReturnLength() //возвращение длины 
        {
            return length;
        }

        public int IndexMin() //поиск индекса мин элемента 
        {
            int min = array[0];
            int minIndex = 0;

            for (int i = 0; i < length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }

            }
            return minIndex;
        }
        public int IndexMax() //поиск индекса макс элемента 
        {
            int max = array[0];
            int maxIndex = 0;

            for (int i = 0; i < length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        public int IndexByNumber(int number)  //индекс по значению. Как сделать, чтобы вместо -1 был null, если такого значения нет? 
        {
            int index = -1;

            for (int i = 0; i < length; i++)
            {
                if (array[i] == number)
                {
                    index = i;
                }
            }
            return index;
        }
    }
}
