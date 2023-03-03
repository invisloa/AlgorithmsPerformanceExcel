using AlgoTestProjHomeWork.Alghorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTestProjHomeWork.MultiSorting
{
	public class MultiAlgoSorter : IMultiAlgoSorter
	{
		List<IAlgoScoresCounter> sortingAlgorithms = Factory.AllSortingAlgorithms;
		public List<IAlgoScoresCounter> AllSortingAlgoritms => sortingAlgorithms;

		public void SortMultipleArrays(int[][] arraysToSort)
		{
			foreach (IAlgoScoresCounter item in sortingAlgorithms)
			{
				foreach (int[] array in arraysToSort)
				{
					item.SortArray(array);
				}
			}
		}
	}
}
