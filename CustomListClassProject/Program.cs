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
            CustomList<int> odd = new CustomList<int>() { 1, 3, 5, 6, 10, 9, 10 };
        
            

            odd.PrintArray();
            

            Console.WriteLine("count: " + odd.Count);
            Console.ReadLine();
        }
    }
}
