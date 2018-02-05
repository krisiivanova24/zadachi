using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slivane
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i <num1.Count; i++)
            {
                for (int j = 0; j < num1.Count-1; j++)
                {
                    if (num1[j]>num1[j+1])
                    {
                        int x = num1[j];
                        num1[j] = num1[j+1];
                        num1[j+1] = x;
                    }
                }
            }
            Console.WriteLine(string.Join(" <= ",num1));
        }
    }
}
