using AlgoTestProjHomeWork.Alghorithms;
using AlgoTestProjHomeWork.MultiSorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTestProjHomeWork.Writers
{
	internal class AlgorithmsScoresSorter : ISortAlgorithmsScores
	{
		public void SortScoresBeforeWrite(IMultipleAlgorithmsSorter allAlgorithms)
		{
			int n = allAlgorithms.AllUsedAlgoritms.Count;
			for (int i = 0; i < n - 1; i++)
			{
				for (int j = 0; j < n - i - 1; j++)
				{
					if (allAlgorithms.AllUsedAlgoritms[j].Stopwatch.Elapsed.TotalMilliseconds > allAlgorithms.AllUsedAlgoritms[j + 1].Stopwatch.Elapsed.TotalMilliseconds)
					{
						IAlgorithmScoresCounter temp = allAlgorithms.AllUsedAlgoritms[j];
						allAlgorithms.AllUsedAlgoritms[j] = allAlgorithms.AllUsedAlgoritms[j + 1];
						allAlgorithms.AllUsedAlgoritms[j + 1] = temp;
					}
				}
			}
		}
	}
}
