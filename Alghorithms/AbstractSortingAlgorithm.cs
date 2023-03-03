using System.Diagnostics;

namespace AlgoTestProjHomeWork.Alghorithms
{
	public abstract class AbstractSortingAlgorithm : IAlgoScoresCounter
	{

		protected long actionsTaken = 0;
		protected Stopwatch stopwatch = new Stopwatch();
		public long ActionsCounted => actionsTaken; 
		public Stopwatch Stopwatch => stopwatch; 

		public void resetPerformance()
		{
			actionsTaken = 0;
			stopwatch.Reset();
		}

		public abstract int[] SortArray(int[] array);

		public void SortMultipleArrays(int[][] array)
		{
			foreach (int[] arrayToSort in array)
			{
				SortArray(arrayToSort);
			}
		}
		public abstract override string ToString();
	}
}