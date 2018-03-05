using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class CustomList<T>

    {
        //member variables
        private int count;
        private T[] array;
        private int capacity;
        //constructor
        public CustomList()
        {
            count = 0;
            capacity = 5;
            array = new T[capacity];
        }

        //member methods

        public int Capacity
        {
            get
            { return capacity; }
            set
            {
                capacity = value;
            }
        }

        public void PrintArray()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public bool CheckIfCountIsLessThanCapacity()
        {
            if (count > (capacity / 2))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public void ExpandCapacity()
        {
         if (CheckIfCountIsLessThanCapacity() == false){
                capacity = capacity * 2;
                T[] newArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    newArray[i] = (array[i]);
                }
                array = newArray;

            }


           
           }


    

        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }

        public void Add (T element)
        {
            ExpandCapacity();
            array[count] = element;
            count++;
        }

        public void Remove (T element)
        {
            
        }

        

       

       

       

        public int Count
        {
            get
            {
                return count;
            }
        }

        //indexer
        //public T this[int elementIndex]
        //{
        //    get
        //    {
        //        return
        //    }
        //}

        //public int GetLength (T[]array)
        //{
        //    int length = 0;
        //    for (int i = 0, i< )
        //}

        //public int Length
        //{
        //    get
        //    {
        //        if (array == null)
        //            throw new ArgumentNullException("array");

        //    }
        //}

        



        public static CustomList<T> operator + (CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> newList = new CustomList<T>();
            //newList.capacity = list1.capacity + list2.capacity;
            //newList.count = list1.count + list2.count;
            
            for(int i = 0; i<list1.count; i++)
            {
                newList.Add(list1[i]);
             
            }
            for (int i = 0; i < list2.count; i++)
            {
                newList.Add(list2[i]);
            }
            return newList;
        }


        // number of elements actually in array
        //public int Count
        //{
        //    get
        //    {
        //        return count;
        //    }
        //}

        //number of elements the list can store before resizing is required
        //    public int Capacity
        //    {
        //        get;
        //        set;
        //    }
    }
}
