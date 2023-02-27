using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTestProjHomeWork.ArrayInitialize
{
    public class ArrayInitializer : IArrayInitializer
    {
        public int[] InitializeArray()
        {
            Console.Write("Enter the maximum length of the array: ");
            int maxLength = int.Parse(Console.ReadLine());

            int[] array = new int[maxLength];
            Random random = new Random();

            for (int i = 0; i < maxLength; i++)
            {
                array[i] = random.Next(1, 1001);
            }

            Console.WriteLine("Generated array:");
            Console.WriteLine(string.Join(", ", array));
            return array;
        }
    }
}
