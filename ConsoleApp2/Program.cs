using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            int num2 = num[num.Count - 1];
            
            while (num.Contains(num2))
            {
                num.Remove(num2);
            }
            Console.WriteLine(string.Join(" ",num));
        }
    }
}
