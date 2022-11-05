using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sr,sum = 0;           
            int[] array = new int[7];
            for (int i = 0; i < 7; i++)
            {
                array[i]= Convert.ToInt32(Console.ReadLine());
                sum += array[i];
            }
            sr = sum / 7;
            Console.WriteLine(" Среднее арифметическое = {0} ",sr);
            Console.ReadKey();
        }
    }
}
