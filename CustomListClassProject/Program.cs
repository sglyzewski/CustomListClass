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
            CustomList<int> odd = new CustomList<int>();
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            CustomList<int> even = new CustomList<int>();
            even.Add(2);
            even.Add(4);
            even.Add(6);
            even.Add(8);
            even.Add(10);

            odd.Zipper(odd, even).PrintArray();
            


            Console.ReadLine();
        }
    }
}
