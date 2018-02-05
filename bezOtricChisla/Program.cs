using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bezOtricChisla
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> num2 = new List<int>();
            int n = 0;
            for (int i = 0; i < num1.Count; i++)
            {
                if (num1[i] > 0)
                {
                    num2.Add(num1[i]);
                    //        num2 = num[i];
                    //        while (num.Contains(num2))
                    //        {
                    //            num.RemoveAt(i);
                    //            i--;
                    //        }
                    //    }

                    //}
                    //Console.WriteLine(num2);
                    //

                }
            }
            if (num2.Contains(num1[0]))
            {
                
                num2.Reverse();
                Console.WriteLine(string.Join(" ", num2));

            }
            else
            {
                Console.WriteLine("Empty");
            }

        }
    }
}

