using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv2_Practise1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            var myArray = new MyArray<int>(n);
           
            Random rnd = new Random();

            for (int i = 0; i < myArray.Array.Length; i++)
            {
                myArray.Array[i] = rnd.Next(0, 100);
            }
         
            Console.WriteLine($"{myArray.Array.Length}");
            Console.WriteLine("---");

            var myNewArray = myArray.Append( 4);

            var myNewArray1 = myArray.AppendArr(myArray.Array);

            var myNewArray2 = myArray.Remove(myArray.Array[2]);

            var myNewArray3 = myArray.RemoveIndex(0);

            Console.WriteLine($"{myNewArray.Length}");
            Console.WriteLine($"{myNewArray1.Length}");
            Console.WriteLine($"{myNewArray2.Length}");

            IComparer<int> comparer = new SortNumbers();
            myArray.Sort(comparer);

            Console.WriteLine("---");
            foreach (var item in myArray.Array)
            {
                Console.WriteLine($"{item}");
            }
           
            Console.ReadKey();
        }
    }

   
}
