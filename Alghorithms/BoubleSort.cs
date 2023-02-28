using System;
using System.Diagnostics;

namespace AlgoTestProjHomeWork.Alghorithms
{
	internal class BoubleSort : IAlgoTally
	{
		long actionsTaken = 0;
		Stopwatch stopwatch = new Stopwatch();

		public long ActionsCounted{get => actionsTaken;}
		public Stopwatch Stopwatch { get => stopwatch; }

		public int[] SortArray(int[] array)
		{
			int[] copyArrayToSort = new int[array.Length];
			Array.Copy(array, copyArrayToSort, array.Length);

			stopwatch.Start();
			{
				int n = copyArrayToSort.Length;
				for (int i = 0; i < n - 1; i++)
				{
					for (int j = 0; j < n - i - 1; j++)
					{
						actionsTaken++;

						if (copyArrayToSort[j] > copyArrayToSort[j + 1])
						{
							int temp = copyArrayToSort[j];
							copyArrayToSort[j] = copyArrayToSort[j + 1];
							copyArrayToSort[j + 1] = temp;
						}
					}
				}
			}
			stopwatch.Stop();
			return copyArrayToSort;
		}
	}
}
