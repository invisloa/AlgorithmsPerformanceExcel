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
		List<IAlgoTally> sortingAlgorithms = Factory.AllSortingAlgorithms;
		public List<IAlgoTally> AllSortingAlgoritms => sortingAlgorithms;

		public void SortMultipleArrays(int[][] arraysToSort)
		{
			foreach (IAlgoTally item in sortingAlgorithms)
			{
				foreach (int[] array in arraysToSort)
				{
					item.SortArray(array);
				}
			}
		}
	}
}
