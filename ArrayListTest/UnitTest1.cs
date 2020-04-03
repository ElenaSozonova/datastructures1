using NUnit.Framework;
using datastructures;

namespace datastructures.test

{
    public class ArrayListTest
    {

        [TestCase(new int[] { 1, 2, 3 }, 4, ExpectedResult = new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { }, 1, ExpectedResult = new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3 }, 5, ExpectedResult = new int[] { 1, 2, 3, 5 })]

        public int[] AddToEndTest(int[] array, int a) // ���� ��� � ����� 1 ����� + 
        {
            ArrayList actual = new ArrayList(array);
            actual.AddToEnd(a);
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5 }, ExpectedResult = new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { }, new int[] { 4, 5 }, ExpectedResult = new int[] { 4, 5 })]
        [TestCase(new int[] { 1 }, new int[] { 1 }, ExpectedResult = new int[] { 1, 1 })]
        public int[] AddToEndTest(int[] array, int[] a)//���� ��� � ����� ������� + 
        {
            ArrayList actual = new ArrayList(array);
            actual.AddToEnd(a);
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3 }, 4, ExpectedResult = new int[] { 4, 1, 2, 3 })]
        [TestCase(new int[] { }, 1, ExpectedResult = new int[] { 1 })]
        [TestCase(new int[] { 1 }, 1, ExpectedResult = new int[] { 1, 1 })]
        public int[] AddToStartTest(int[] array, int a) // ���� ��� � ������ 1 �����  + 
        {
            ArrayList actual = new ArrayList(array);
            actual.AddToStart(a);
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4 }, ExpectedResult = new int[] { 4, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5 }, ExpectedResult = new int[] { 4, 5, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6, 7 }, ExpectedResult = new int[] { 4, 5, 6, 7, 1, 2, 3 })]

        public int[] AddToStartTest(int[] array, int[] a) //���� ��� � ������ ������ + 
        {
            ArrayList actual = new ArrayList(array);
            actual.AddToStart(a);
            return actual.ReturnArray();

        }

        [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = new int[] { 2, 3 })]
        [TestCase(new int[] { 1 }, ExpectedResult = new int[] { })]
        [TestCase(new int[] { 1, 9 }, ExpectedResult = new int[] { 9 })]

        public int[] DeleteFromStartTest(int[] array) // ���� �������� ����� �� ������  + 
        {
            ArrayList actual = new ArrayList(array);
            actual.DeleteFromStart();
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = new int[] { 1, 2 })]
        [TestCase(new int[] { 1 }, ExpectedResult = new int[] { })]
        [TestCase(new int[] { 1, 5 }, ExpectedResult = new int[] { 1 })]

        public int[] DeleteFromEndTest(int[] array) // ���� �������� ����� �� �����
        {
            ArrayList actual = new ArrayList(array);
            actual.DeleteFromEnd();
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 1, ExpectedResult = new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 2, ExpectedResult = new int[] { 1, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 4, ExpectedResult = new int[] { })]
        public int[] DeleteFromEndTest(int[] array, int a) //�������� N ����� �� �����
        {
            ArrayList actual = new ArrayList(array);
            actual.DeleteFromEnd(a);
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 1, ExpectedResult = new int[] { 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 2, ExpectedResult = new int[] { 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 4, ExpectedResult = new int[] { })]
        public int[] DeleteFromStartTest(int[] array, int a) //�������� N ����� �� ������
        {
            ArrayList actual = new ArrayList(array);
            actual.DeleteFromStart(a);
            return actual.ReturnArray();
        }


        [TestCase(new int[] { 4, 2, 8 }, ExpectedResult = new int[] { 2, 4, 8 })]
        [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 3, 2, 1 }, ExpectedResult = new int[] { 1, 2, 3, })]
        [TestCase(new int[] { 0, 0, 0 }, ExpectedResult = new int[] { 0, 0, 0 })]
        public int[] SortUpTest(int[] array) // ���� ���������� �� �����������
        {
            ArrayList actual = new ArrayList(array);
            actual.SortUp();
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 4, 2, 8 }, ExpectedResult = new int[] { 8, 4, 2 })]
        [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = new int[] { 3, 2, 1 })]
        [TestCase(new int[] { 3, 2, 1 }, ExpectedResult = new int[] { 3, 2, 1 })]
        [TestCase(new int[] { 0, 0, 0 }, ExpectedResult = new int[] { 0, 0, 0 })]
        public int[] SortDownTest(int[] array) // ���� ���������� �� ��������
        {
            ArrayList actual = new ArrayList(array);
            actual.SortDown();
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 4, 2, 8 }, ExpectedResult = new int[] { 8, 2, 4 })]
        [TestCase(new int[] { 4, 2, 8, 5, 6 }, ExpectedResult = new int[] { 6, 5, 8, 2, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, ExpectedResult = new int[] { 4, 3, 2, 1 })]
        [TestCase(new int[] { 0, 0, 0 }, ExpectedResult = new int[] { 0, 0, 0 })]
        [TestCase(new int[] { }, ExpectedResult = new int[] { })]
        public int[] ReversTest(int[] array) // ���� ������
        {
            ArrayList actual = new ArrayList(array);
            actual.Revers();
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, 2, ExpectedResult = new int[] { 1, 2, 0, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, 0, ExpectedResult = new int[] { 0, 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, 4, ExpectedResult = new int[] { 1, 2, 3, 4, 0, 5 })]

        public int[] AddByIndexTest(int[] array, int a, int index) //���� ��� �� ������� 1 ��������
        {
            ArrayList actual = new ArrayList(array);
            actual.AddByIndex(a, index);
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, ExpectedResult = new int[] { 1, 2, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, ExpectedResult = new int[] { 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, ExpectedResult = new int[] { 1, 2, 3, 4 })]

        public int[] DeleteByIndexTest(int[] array, int index) //���� �������� �� ������� 1 ��-�� 
        {
            ArrayList actual = new ArrayList(array);
            actual.DeleteByIndex(index);
            return actual.ReturnArray();
        }


        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5, 0, ExpectedResult = new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 1, 4, ExpectedResult = new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, 0, ExpectedResult = new int[] { 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, 2, ExpectedResult = new int[] { 1, 2, 5 })]

        public int[] DeleteByIndexTest(int[] array, int n, int index) //���� �������� �� ������� N ���������
        {
            ArrayList actual = new ArrayList(array);
            actual.DeleteByIndex(n, index);
            return actual.ReturnArray();
        }


        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 0, 0 }, 4, ExpectedResult = new int[] { 1, 2, 3, 4, 0, 0, 5, 6, 7 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 0, 0 }, 0, ExpectedResult = new int[] { 0, 0, 1, 2, 3, 4, 5, 6, 7 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 0, 0 }, 6, ExpectedResult = new int[] { 1, 2, 3, 4, 5, 6, 0, 0, 7 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 0, 0 }, 7, ExpectedResult = new int[] { 1, 2, 3, 4, 5, 6, 7, 0, 0 })]

        public int[] AddByIndexTest(int[] array, int[] a, int index) //���� ���������� ������� �� �������
        {
            ArrayList actual = new ArrayList(array);
            actual.AddByIndex(a, index);
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 1, ExpectedResult = new int[] { 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5, ExpectedResult = new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, ExpectedResult = new int[] { 1, 2, 4, 5 })]

        [TestCase(new int[] { 1, 1, 2, 3, 4, 5 }, 1, ExpectedResult = new int[] { 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 3, 4, 5 }, 3, ExpectedResult = new int[] { 1, 2, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 5 }, 5, ExpectedResult = new int[] { 1, 2, 3, 4 })]

        [TestCase(new int[] { 1, 2, 3, 4, 5, 1 }, 1, ExpectedResult = new int[] { 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 1, 4, 5 }, 1, ExpectedResult = new int[] { 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 3 }, 3, ExpectedResult = new int[] { 1, 2, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 2, 5 }, 2, ExpectedResult = new int[] { 1, 3, 4, 5 })]

        public int[] DeleteFromNumberTest(int[] array, int a) // ���� �������� �� �������� 
        {
            ArrayList actual = new ArrayList(array);
            actual.DeleteFromNumber(a);
            return actual.ReturnArray();
        }


        [TestCase(new int[] { 2, 7, 1 }, ExpectedResult = 7)]
        [TestCase(new int[] { 2, 1, 0 }, ExpectedResult = 2)]
        [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = 3)]
        public int SearchMaxTest(int[] array) // ���� ����� ��������� 
        {
            ArrayList a = new ArrayList(array);
            return a.SearchMax();
        }


        [TestCase(new int[] { 2, 7, 1 }, ExpectedResult = 1)]
        [TestCase(new int[] { 0, 1, 5 }, ExpectedResult = 0)]
        [TestCase(new int[] { 7, 2, 3 }, ExpectedResult = 2)]
        public int SearchMinTest(int[] array) //���� ����� ��������
        {
            ArrayList a = new ArrayList(array);
            return a.SearchMin();
        }

        [TestCase(new int[] { 2, 7, 1 }, ExpectedResult = 3)]
        [TestCase(new int[] { 0, 1, 5, 6, 7 }, ExpectedResult = 5)]
        [TestCase(new int[] { 0 }, ExpectedResult = 1)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        public int ReturnLengthTest(int[] array)  //���� ����������� ����� 
        {
            ArrayList a = new ArrayList(array);
            return a.ReturnLength();
        }

        [TestCase(new int[] { 2, 7, 1 }, ExpectedResult = 2)]
        [TestCase(new int[] { 0, 1, 5 }, ExpectedResult = 0)]
        [TestCase(new int[] { 9, 5, 7 }, ExpectedResult = 1)]
        public int IndexMinTest(int[] array) //���� ����� ������� ��������
        {
            ArrayList a = new ArrayList(array);
            return a.IndexMin();
        }

        [TestCase(new int[] { 2, 7, 1 }, ExpectedResult = 1)]
        [TestCase(new int[] { 0, 1, 5 }, ExpectedResult = 2)]
        [TestCase(new int[] { 9, 5, 7 }, ExpectedResult = 0)]
        public int IndexMaxTest(int[] array) //���� ����� ������� ���������
        {
            ArrayList a = new ArrayList(array);
            return a.IndexMax();
        }


        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, ExpectedResult = 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5, ExpectedResult = 4)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, ExpectedResult = 2)]
        //[TestCase(new int[] { 1, 2, 3, 4, 5 }, 7, ExpectedResult = null)]  ��� �������? 
        public int IndexByNumberTest(int[] array, int number) //���� ������ �� �������� 
        {
            ArrayList a = new ArrayList(array);
            return a.IndexByNumber(number);
        }

        [TestCase(new int[] { 1, 2, 3 }, 0, 9, ExpectedResult = new int[] { 9, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 1, 9, ExpectedResult = new int[] { 1, 9, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 2, 9, ExpectedResult = new int[] { 1, 2, 9 })]
        public int[] ChangeByIndexTest(int[] array, int index, int number) //��� �� ������� �����
        {
            ArrayList actual = new ArrayList(array);
            actual.�hangeByIndex(index, number);
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3 }, 0, ExpectedResult = 1)]
        [TestCase(new int[] { 1, 2, 3 }, 1, ExpectedResult = 2)]
        [TestCase(new int[] { 1, 2, 3 }, 2, ExpectedResult = 3)]

        public int IndexAccessTest(int[] array, int index) //���� ������ �� �������
        {
            ArrayList a = new ArrayList(array);
            return a.IndexAccess(index);
        }


        [TestCase(new int[] { 1, 2, 3 }, 0, 9, ExpectedResult = new int[] { 9, 2, 3 })]
        public int[] SetIndexTest(int[] array, int i, int a) //��� �� ������� get/set
        {
            ArrayList actual = new ArrayList(array);
            actual[i] = a;
            return actual.ReturnArray();
        }


    }
}