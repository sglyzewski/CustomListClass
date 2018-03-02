using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
   public class CustomList <T>

    {
        //member variables
        public int count;
        private T[] array;
        //constructor
        public CustomList()
        {
            count = 0;
            array = new T[20];
        }

        //member methods
        public T[] Add(T element)
        {
            
            T[]array2 ={element};
           
            array = array + array2;
            count++;
            return array;

        }

        //indexer
        public T this[int elementIndex]
        {
            get
            {
                return
            }
        }


        public static CustomList<T> operator +(T[]array1, T[]array2)
        {

        }

        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> newList = new CustomList<T>()
            newList
        }


        public int Count
        {
            get
            {
                return count;
            }
        }
    }
    }
