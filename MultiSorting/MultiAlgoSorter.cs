using AlgoTestProjHomeWork.Alghorithms;
using System;
using System.Collections.Generic;
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


		List<IAlgorithmScoresCounter> sortingAlgorithms = Factory.AllSortingAlgorithmsList;
		public List<IAlgorithmScoresCounter> AllUsedAlgoritms => sortingAlgorithms;


		public void SortMultipleArrays(int[][] arraysToSort)
		{
			numberOfArrays = arraysToSort.Length;
			numberOfValuesInArray = arraysToSort[0].Length;
			foreach (IAlgorithmScoresCounter item in sortingAlgorithms)
			{
				foreach (int[] array in arraysToSort)
				{
					item.SortArray(array);
				}
			}
		}
	}
}
