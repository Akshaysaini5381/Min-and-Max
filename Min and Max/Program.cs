using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_and_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array size :");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            int ctr = 0;
            int max, min;
            max = arr[0];
           

            while (ctr < size)
            {
                Console.Write("Enter the value :");
                arr[ctr] = int.Parse(Console.ReadLine());
                ctr++;
                
            }
            Console.Write("My array :");
            int ptr = 0;
            while (ptr<size)
            {
                Console.Write(arr[ptr]+"  ");
                ptr++;
            }
            for (int i = 0; i <size; i++)
            {
                if (max<arr[i])
                {
                    max = arr[i];
                }
               
            }
            Console.WriteLine();
            Console.WriteLine("my max numbar :" + max);
            min = arr[0];
            for (int i = 0; i < size; i++)
            {
                if (min>arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("my min numbar :" + min);
            Console.ReadLine();
        }
    }
}
