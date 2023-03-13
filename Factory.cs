using AlgoTestProjHomeWork.Alghorithms;
using AlgoTestProjHomeWork.ArrayInitialize;
using AlgoTestProjHomeWork.MultiSorting;
using AlgoTestProjHomeWork.Writers;

namespace AlgoTestProjHomeWork
{
	public static class Factory
	{
		// List of sorting algorithms to be used in calculations
		public static List<IAlgorithmScoresCounter> AllSortingAlgorithmsList = new List<IAlgorithmScoresCounter>()
		{
			CreateMergeSorter,
			CreateQuicksort,
			//CreateBubleSorter,
			//CreateInsertionSorter,
			CreateHeapSorter,
			CreateLinqSort

		};
		public static IArrayInitializer CreateArrayInitializer => new ArrayInitializer();
		public static IPerformanceWriter CreatePerformanceWriter => new ExcelScoresWriter();
		public static IPerformanceWriter CreateConsolePerformanceWriter => new ConsolePerformanceWriter();


		//Creators for all available algorithms
		#region Sorting algorithms
		public static IAlgorithmScoresCounter CreateQuicksort => new Quicksort();
		public static IAlgorithmScoresCounter CreateBubleSorter => new BubleSort();
		public static IAlgorithmScoresCounter CreateMergeSorter => new MergeSort();
		public static IAlgorithmScoresCounter CreateInsertionSorter => new InsertionSort();
		public static IAlgorithmScoresCounter CreateHeapSorter => new Heapsort();
		public static IAlgorithmScoresCounter CreateLinqSort => new LinqSort();


		#endregion

		public static IMultipleAlgorithmsSorter CreateMultiAlgorithmsSorter => new MultipleAlgorithmsSorter();
		public static ISortAlgorithmsScores CreateSortScoresBeforeWrite => new AlgorithmsScoresSorter();
	}
}
