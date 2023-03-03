using AlgoTestProjHomeWork.Alghorithms;
using AlgoTestProjHomeWork.ArrayInitialize;
using AlgoTestProjHomeWork.MultiSorting;
using AlgoTestProjHomeWork.Writers;

namespace AlgoTestProjHomeWork
{
	public static class Factory
	{
		public static List<IAlgoScoresCounter> AllSortingAlgorithms = new List<IAlgoScoresCounter>()
		{
			CreateMergeSorter,
			CreateBubleSorter,
			CreateQuicksort,
		};  
		public static IArrayInitializer CreateArrayInitializer  => new ArrayInitializer();
		public static IPerformanceWriter CreatePerformanceWriter=> new ExcelScoresWriter(); 
		public static IAlgoScoresCounter CreateQuicksort  => new Quicksort();
		public static IAlgoScoresCounter CreateBubleSorter => new BubleSort();
		public static IAlgoScoresCounter CreateMergeSorter  => new MergeSort(); 
		public static IMultiAlgoSorter CreateMultiAlgoSorter => new MultiAlgoSorter();
		public static ISortAlgorithmsScores CreateSortScoresBeforeWrite => new ScoresSorter();
	}
}
	