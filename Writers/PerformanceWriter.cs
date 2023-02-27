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
		
		public void WritePerformance(IAlgoSorter sorter)
		{
			Console.WriteLine($"Elapsed time: {sorter.Stopwatch.Elapsed.TotalMilliseconds} milliseconds");
			Console.WriteLine($"Number of actions taken:{sorter.ActionsCounted} \n \n");
			sorter.Stopwatch.Reset();
		}
	}
}
