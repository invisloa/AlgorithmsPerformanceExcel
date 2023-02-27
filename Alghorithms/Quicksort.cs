using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTestProjHomeWork.Alghorithms
{
	public class Quicksort : IAlgoSorter
	{
		long actionsTaken = 0;
		public long ActionsCounted => actionsTaken;
		
		Stopwatch stopwatch = new Stopwatch();
		public Stopwatch Stopwatch { get => stopwatch; }

		public void QSort(int[] array, int left, int right)
		{
			stopwatch.Start();
			actionsTaken++;

			if (left < right)
			{
				int pivotIndex = Partition(array, left, right);
				QSort(array, left, pivotIndex - 1);
				QSort(array, pivotIndex + 1, right);
			}
			stopwatch.Stop();
		}
		public int[] SortArray(int[] array)
		{
			QSort(array, 0, array.Length-1);
			return array;
		}
		int Partition(int[] array, int left, int right)
		{
			int pivot = array[right];
			int i = left - 1;
			for (int j = left; j < right; j++)
			{
				if (array[j] <= pivot)
				{
					i++;
					Swap(array, i, j);
				}
			}
			Swap(array, i + 1, right);
			return i + 1;
		}
		void Swap(int[] array, int i, int j)
		{
			int temp = array[i];
			array[i] = array[j];
			array[j] = temp;
		}
	}
}
