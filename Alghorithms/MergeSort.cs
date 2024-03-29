﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTestProjHomeWork.Alghorithms
{
	internal class MergeSort : AbstractSortingAlgorithm
	{
		public override string ToString() { return "Merge Sort"; }
		public override int[] SortArray(int[] array)
		{
			int[] copyArrayToSort = new int[array.Length];
			Array.Copy(array, copyArrayToSort, array.Length);
			stopwatch.Start();
			MSort(copyArrayToSort);
			stopwatch.Stop();
			return copyArrayToSort;
		}
		void MSort(int[] arr)
		{
			actionsTaken++;                        // calling self is a meaningfull operation
			if (arr.Length < 2)
			{
				return;
			}

			int mid = arr.Length / 2;
			int[] left = new int[mid];
			int[] right = new int[arr.Length - mid];

			Array.Copy(arr, 0, left, 0, mid);
			Array.Copy(arr, mid, right, 0, arr.Length - mid);

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

	}
}
