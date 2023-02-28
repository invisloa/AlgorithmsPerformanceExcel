﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTestProjHomeWork.Alghorithms
{
	internal class MergeSort : IAlgoTally
	{
		long actionsTaken = 0;
		public long ActionsCounted => actionsTaken;
		Stopwatch stopwatch = new Stopwatch();
		public Stopwatch Stopwatch { get => stopwatch; }



		void MSort(int[] arr)
		{
			stopwatch.Start();
			actionsTaken++;                        // calling self is a meaningfull operation
			if (arr.Length < 2)
			{
				return;
			}

			int mid = arr.Length / 2;
			int[] left = new int[mid];
			int[] right = new int[arr.Length - mid];

			Array.Copy(arr, 0, left, 0, mid);
			actionsTaken++;                        // array copying ++
			Array.Copy(arr, mid, right, 0, arr.Length - mid);
			actionsTaken++;                        // array copying ++

			MSort(left);
			MSort(right);

			Merge(arr, left, right);
			stopwatch.Stop();
		}

		void Merge(int[] arr, int[] left, int[] right)
		{
			int i = 0;
			int j = 0;
			int k = 0;

			while (i < left.Length && j < right.Length)
			{

				if (left[i] <= right[j])
				{
					arr[k++] = left[i++];
				}
				else
				{
					arr[k++] = right[j++];
				}
			}

			while (i < left.Length)
			{

				arr[k++] = left[i++];
			}

			while (j < right.Length)
			{

				arr[k++] = right[j++];
			}
		}

		public int[] SortArray(int[] array)
		{
			int[] copyArrayToSort = new int[array.Length];
			Array.Copy(array, copyArrayToSort, array.Length);

			MSort(copyArrayToSort);
			return copyArrayToSort;
		}
	}
}