using System;
using System.Collections.Generic;
using System.Text;

namespace datastructures
{
    interface Interface1
    {
        public int[] ReturnArray(); //метод возвращает массива
        public void AddToEnd(int a); //метод добавления в конец 1 числа
        public void AddToEnd(int[] a); //метод добавления в конец массива чисел 
        public void AddToStart(int a); //метод добавления в начало 1 числа
        public void AddToStart(int[] a); //метод добавления в начало массива чисел 
        public void AddByIndex(int[] a, int index); //метод добавления массива по индексу  
        public void AddByIndex(int a, int index); //метод добавления по индексу 
        public void DeleteByIndex(int index); //метод удаления по индексу 
        public void DeleteByIndex(int n, int index); //метод удаления по индексу N эл-в
        public void DeleteFromStart(); //метод удаления из начала 1 элемента
        public void DeleteFromStart(int a); //метод удаления из начала N элементов
        public void DeleteFromEnd(); //метод удаления из конца 1 элемента
        public void DeleteFromEnd(int a); //метод удаления из конца N элементов
        public void DeleteFromNumber(int a); //удаление по значению  второй вариант 
        public void SortUp(); // сортировка вставками по возрастанию
        public void SortDown(); // сортировка вставками по убыванию
        public void Revers(); //реверс
        public int IndexAccess(int index);  //доступ по индексу
        public void СhangeByIndex(int index, int number);  //изменить по индексу
        public int SearchMax(); //поиск максимума
        public int SearchMin(); //поиск минимума
        public int ReturnLength();//возвращение длины 
        public int IndexMin(); //поиск индекса мин элемента 
        public int IndexMax(); //поиск индекса макс элемента 
        public int IndexByNumber(int number);//индекс по значению. 
    }
}
