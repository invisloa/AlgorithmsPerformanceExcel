using AlgoTestProjHomeWork.Alghorithms;
using AlgoTestProjHomeWork.MultiSorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTestProjHomeWork.Writers
{
	internal class ConsolePerformanceWriter : IPerformanceWriter
	{
		public void WriteAlgorithmPerformance(IAlgorithmScoresCounter algorithmToShowScores)
		{
			Console.WriteLine(algorithmToShowScores);
			Console.WriteLine($"Elapsed time: {algorithmToShowScores.Stopwatch.Elapsed.TotalMilliseconds} milliseconds");
			Console.WriteLine($"Number of actions taken:{algorithmToShowScores.ActionsCounted} \n \n");
		}

		public void WriteAllAlgorithmsPerformances(IMultipleAlgorithmsSorter allAlgorithmsList)
		{
			foreach (IAlgorithmScoresCounter item in allAlgorithmsList.AllUsedAlgoritms)
			{
				WriteAlgorithmPerformance(item);
			}
		}
		

	}
}
