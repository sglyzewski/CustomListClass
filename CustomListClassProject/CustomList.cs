using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class CustomList<T> : IEnumerable


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
            if (CheckIfCountIsLessThanCapacity() == false) {
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

        public void Add(T element)
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


        public int GetIndexOfFirstInstanceOfElement(T element)
        {
            int elementIndex;
            CustomList<int> elementLocation = new CustomList<int>();
            for (int i = 0; i < count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(array[i], element))
                {
                    elementLocation.Add(i);
                }

            }
            elementIndex = elementLocation[0];
            return elementIndex;
        }

        public bool Remove(T element)
        {
            if (CheckForElementInList(element) == true)
            {
                int elementIndex;
                elementIndex = GetIndexOfFirstInstanceOfElement(element);
                MoveElementsLeftInArray(elementIndex);
                count--;
                return true;
            }
            else
            {

                return false;
            }
        }

        public void MoveElementsLeftInArray(int elementIndex)
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

        public CustomList<T> Zipper(CustomList<T> list2)
        {
            CustomList<T> newList = new CustomList<T>();
            if (count > list2.Count)
            {
                for (int i = 0; i < list2.Count; i++)
                {
                    newList.Add(array[i]);
                    newList.Add(list2[i]);
                }
                for (int i = list2.Count; i < count; i++)
                {
                    newList.Add(array[i]);
                }
            }

            if (count < list2.Count)
            {
                for (int i = 0; i < count; i++)
                {
                    newList.Add(array[i]);
                    newList.Add(list2[i]);
                }
                for (int i = count; i < list2.Count; i++)
                {
                    newList.Add(list2[i]);
                }
            }

            else
            {
                for (int i = 0; i < count; i++)
                {
                    newList.Add(array[i]);
                    newList.Add(list2[i]);
                }
            }
            return newList;
        }





        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> newList = new CustomList<T>();

            for (int i = 0; i < list1.count; i++)
            {
                newList.Add(list1[i]);

            }
            for (int i = 0; i < list2.count; i++)
            {
                newList.Add(list2[i]);
            }
            return newList;
        }

       static CustomList<double> ConvertArrayToDouble(CustomList<int> intList)
        {
           
            CustomList<double> doubleList = new CustomList<double>();

            for (int i = 0; i < intList.Count; i++)
            { doubleList.Add((float) intList[i]);
            }
            return doubleList;

        }


        public void PrintArray()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(array[i]);
            }
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            {
                for (int index = 0; index < count; index++)
                {
                    yield return array[index];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int index = 0; index < count; index++)
            {
                yield return array[index];
            }
        }

        static CustomList<T> SubtractArrays(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> newList = new CustomList<T>();
            //if (list2.Count < list1.Count)
            //{
            //    int newListCount = list1.Count - list2.Count;
            //    for (int i = 0; i < newListCount; i++)
            //    {
            //        newList.Add(list1[i]);


            //    }

            //}
            //return newList;

            for (int i = 0; i < list2.Count; i++)
            {
                if (list1.CheckForElementInList(list2[i]) == true)
                {
                    list1.Remove(list2[i]);
                }
            }
            return list1;


           

        }


        static CustomList<int> ConvertTypeTToInt(CustomList<T> list)
        {
            CustomList<int> newList = new CustomList<int>();
            foreach (var element in list)
            {
                int m = Convert.ToInt32(element);
                newList.Add(m);
            }
            return newList;
        }

        static CustomList<double> SubtractDoubleArrays(CustomList<double> list1, CustomList<double> list2)
        {
            CustomList<double> newList = new CustomList<double>();
            if (list1.Count < list2.Count)
            {
                int countdifference = list2.Count - list1.Count;
                for (int i = list1.Count; i < list2.Count; i++)
                {
                    list1.Add(0);
                }
            }
            if (list2.Count < list1.Count)
            {
                int countdifference = list1.Count - list2.Count;
                for (int i = list2.Count; i < list1.Count; i++)
                {
                    list2.Add(0);
                }
            }

            for (int i = 0; i < list1.Count; i++)
            {
                newList.Add((list1[i] - list2[i]));
            }

            return newList;
        }

       static CustomList<string> SubtractStringArrays(CustomList<string> list1, CustomList<string> list2)
        {

            for (int i = 0; i < list2.Count; i++)
            {
                if (list1.CheckForElementInList(list2[i]) == true)
                {
                    list1.Remove(list2[i]);
                }
            }
            return list1;
        }

       

        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> newList = new CustomList<T>();
            newList = SubtractArrays(list1, list2);
            return newList;
            //string type = (list1[0]).GetType().ToString();

            //switch (type)
            //{
            //    case "Int32":
            //        CustomList<int> intList1;
            //        CustomList<int> intList2;

            //        intList1 = ConvertTypeTToInt(list1);
            //        intList2 =  ConvertTypeTToInt(list2);
            //        CustomList<double> holdingList;
            //        CustomList<double> doubleList1;
            //        CustomList<double> doubleList2;
            //        doubleList1 = ConvertArrayToDouble(intList1);
            //        doubleList2= ConvertArrayToDouble(intList2);
            //        holdingList = SubtractDoubleArrays(doubleList1, doubleList2);

            //        foreach (double element in holdingList)
            //        {
            //            Convert.ChangeType(element, typeof(T));
            //            newList.Add(element);
            //        }
            //        return newList;

            //    //case Double:
            //    //    CustomList<double> newList;
            //    //    newList = SubtractFloatArrays(list1, list2);
            //    //    return newList;

            //    //case String:
            //    //    CustomList<string> newList;
            //    //    newList = SubtractStringArrays(list1, list2);
            //    //    return newList;


            //    default:

            //        newList = SubtractArrays(list1, list2);
            //        return newList;


            //}


        }

        //public override string ToString()
        //{
        //    //for(int i = 0; i < count; i++)
        //    //{
        //    //    return array[0] + "";
        //    //}
        //}

        




    }
}


