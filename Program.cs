using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            foreach (var i in tomb)
            {
                sum += i;
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
