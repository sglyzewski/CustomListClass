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
            get {
                if (i > count)
                {
                    throw new Exception("The index has no value");
                }
                else
                {
                    return array[i];
                }
            }
            set { array[i] = value; }
        }

        public void Add (T element)
        {
            ExpandCapacity();
            array[count] = element;
            count++;
            
        }

        public bool CheckForElementInList(T element)
        {
            int elementCount = 0;
            
            for (int i = 0; i < count; i++)
            {
            if (EqualityComparer<T>.Default.Equals(array[i], element))
                {
                    elementCount++;
                }
            }

            if (elementCount > 0)
            {
                return true;
            }

            else 
            {
                return false;
            }

        }


        //public int IndexOf(T element)
        //{
        //    int elementIndex;

        //    CustomList<int> elementLocation = new CustomList<int>();
        //    get {
        //        if (CheckForElementInList(element) == true) {
        //            for (int i = 0; i < count; i++)
        //            {
        //                if (EqualityComparer<T>.Default.Equals(array[i], element))
        //                {
        //                    elementLocation.Add(i);
        //                }

        //            }
        //            elementIndex = elementLocation[0];
        //            return elementIndex;
        //        }
        //        else
        //        {
        //            throw new Exception("The value is not in the list");
        //        }
        //    }

        //}
        public bool Remove (T element)
        {
            int elementIndex;

            if (CheckForElementInList(element) == true)
            {
                CustomList<int> elementLocation = new CustomList<int>();
                for (int i = 0; i < count; i++)
                {
                    if (EqualityComparer<T>.Default.Equals(array[i], element))
                    {
                        elementLocation.Add(i);
                    }

                }
                elementIndex = elementLocation[0];
              
                MoveElementsLeftInArray(elementIndex);
                count--;
                return true;
            }
             
            else
            {

                return false;
            }
        }

        public void MoveElementsLeftInArray (int elementIndex)
        {

            for (int i = elementIndex; i < count; i++)
            {
                array[i] = array[i + 1];
            }
        }
        
       
       public int Count
        {
            get
            {
                return count;
            }
        }





        public static CustomList<T> operator + (CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> newList = new CustomList<T>();
      
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

    }
}
