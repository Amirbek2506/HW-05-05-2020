using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_05_05_20
{
    class MyList<T>
    {
        private T[] myList = null;
        private int newIndex = 0;
        private int CountItems=0;

        public T this[int index]
        {
            get { 
                if(index>0 && index<myList.Length)
                return myList[index];
                else
                {
                    Console.WriteLine(new ArgumentOutOfRangeException().Message);
                    return myList[0];
                }
            }
            set { myList[index] = value; }
        }

        public MyList()
        {
            this.myList = new T[1];
        }

        public MyList(int count)
        {
            this.myList = new T[count];
        }

        public void Add(T item)
        {
            myList[newIndex] = item;
            newIndex++;
            CountItems++;
        }

        public int Capacity
        {
            get { return myList.Length; }

        }
        public int Count
        {
            get{return CountItems;}
        }
        public IEnumerator GetEnumerator()
        {
            return myList.GetEnumerator();
        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> CityOfTajikistanList = new MyList<string>(22);
            CityOfTajikistanList.Add("Душанбе");
            CityOfTajikistanList.Add("Худжанд");
            CityOfTajikistanList.Add("Куляб");
            CityOfTajikistanList.Add("Хоруг");
            CityOfTajikistanList.Add("Вахдат");
            CityOfTajikistanList.Add("Хисор");
            CityOfTajikistanList.Add("Вандж");
            Console.WriteLine("--------------- GetItemOfIndex --------------------\n");
            Console.WriteLine("CityOfTajikistanList[2] : {0}",CityOfTajikistanList[2]);
            Console.WriteLine("--------------- GetItems ----------------------\n");
            foreach (var City in CityOfTajikistanList)
            Console.Write("{0}  ",City);
            Console.WriteLine("\n\nЕмкость списка: {0} элемент", CityOfTajikistanList.Capacity);
            Console.WriteLine("Список фактически содержит: {0} элемент", CityOfTajikistanList.Count);
            Console.ReadKey();
        }
    }
}