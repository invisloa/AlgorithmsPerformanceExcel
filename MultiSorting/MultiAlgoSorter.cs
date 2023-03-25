using AlgoTestProjHomeWork.Alghorithms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTestProjHomeWork.MultiSorting
{
	public class MultipleAlgorithmsSorter : IMultipleAlgorithmsSorter
	{
		int numberOfArrays;
		int numberOfValuesInArray;
		public int NumberOfArraysToSort => numberOfArrays;
		public int NumberOfValuesInArray => numberOfValuesInArray;

		public MultipleAlgorithmsSorter(List<IAlgorithmScoresCounter> sortingAlgorithmsList)
		{
			this.sortingAlgorithmsList = sortingAlgorithmsList;

		}
		List<IAlgorithmScoresCounter> sortingAlgorithmsList;
		public List<IAlgorithmScoresCounter> AllUsedAlgoritms => sortingAlgorithmsList;


		public void SortMultipleArrays(int[][] arraysToSort)
		{
			numberOfArrays = arraysToSort.Length;
			numberOfValuesInArray = arraysToSort[0].Length;
			foreach (IAlgorithmScoresCounter item in sortingAlgorithmsList)
			{
				foreach (int[] array in arraysToSort)
				{
					item.ResetPerformance();
					item.SortArray(array);
				}
			}
		}
	}
}
