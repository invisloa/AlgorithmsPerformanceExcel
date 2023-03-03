using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTestProjHomeWork.Alghorithms
{
	public interface IAlgoScoresCounter
	{
		void SortMultipleArrays(int[][] array);
		int[] SortArray(int[] array);
		Stopwatch Stopwatch { get; }
		public long ActionsCounted {  get; }
		public void resetPerformance();
	}
}
