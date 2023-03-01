using System.Diagnostics;

namespace AlgoTestProjHomeWork.Alghorithms
{
	public abstract class AbstractSortingAlgorithm : IAlgoTally
	{

		protected long actionsTaken = 0;
		protected Stopwatch stopwatch = new Stopwatch();
		public long ActionsCounted { get => actionsTaken; }
		public Stopwatch Stopwatch { get => stopwatch; }

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