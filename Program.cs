using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, sum;
            int mn, mx;

            Console.WriteLine("Find perfect numbers from N1 to N2 :- ");
            Console.WriteLine("\n\n");
            Console.WriteLine(" Input N1 :- ");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Input N2 :- ");
            mx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The list of perfect numbers from n1 to n2 :- ");
            for (n1 = mn; n1 <= mx; n1++)
            {
                n2 = 1;
                sum = 0;
                while (n2 < n1)
                {
                    if (n1 % n2 == 0)
                        sum = sum + n2;
                    n2++;
                }
                if (sum == n1)
                    Console.Write("{0} ", n1);
            }
            Console.Write("\n");
        }
    }
}
