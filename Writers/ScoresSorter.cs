using AlgoTestProjHomeWork.Alghorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTestProjHomeWork.Writers
{
	internal class ScoresSorter : ISortAlgorithmsScores
	{
		public void SortScoresBeforeWrite(List<IAlgoScoresCounter> allAlgorithms)
		{
			int n = allAlgorithms.Count;
			for (int i = 0; i < n - 1; i++)
			{
				for (int j = 0; j < n - i - 1; j++)
				{
					if (allAlgorithms[j].Stopwatch.Elapsed.TotalMilliseconds > allAlgorithms[j + 1].Stopwatch.Elapsed.TotalMilliseconds)
					{
						IAlgoScoresCounter temp = allAlgorithms[j];
						allAlgorithms[j] = allAlgorithms[j + 1];
						allAlgorithms[j + 1] = temp;
					}
				}
			}
		}

	}
}
