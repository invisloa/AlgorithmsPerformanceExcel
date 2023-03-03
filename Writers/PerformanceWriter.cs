using AlgoTestProjHomeWork.Alghorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTestProjHomeWork.Writers
{
	internal class PerformanceWriter : IPerformanceWriter
	{
		public void WritePerformance(IAlgoScoresCounter algoToShowScores)
		{
			Console.WriteLine(algoToShowScores);
			Console.WriteLine($"Elapsed time: {algoToShowScores.Stopwatch.Elapsed.TotalMilliseconds} milliseconds");
			Console.WriteLine($"Number of actions taken:{algoToShowScores.ActionsCounted} \n \n");
			algoToShowScores.Stopwatch.Reset();
		}

		public void WriteAllAlgorithmsPerformances(List<IAlgoScoresCounter> allAlgorithms)
		{
			foreach (IAlgoScoresCounter item in allAlgorithms)
			{
				WritePerformance(item);
			}
		}

	}
}
