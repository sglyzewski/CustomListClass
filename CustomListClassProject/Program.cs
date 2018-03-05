using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> customList1 = new CustomList<int>();
            customList1.Add(1);
            CustomList<int> customList2 = new CustomList<int>();
            customList2.Add(2);
            customList2.Add(6);
            customList2.Add(4);
            customList2.Add(5);
            customList2.Add(6);
            customList2.Add(7);
            customList2.PrintArray();
            CustomList<int> customList3 = (customList1 + customList2);
            customList2.Remove(6);
            customList2.Remove(6);
            customList2.PrintArray();
           
            Console.ReadLine();
        }
    }
}
