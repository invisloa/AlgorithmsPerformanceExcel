using AlgoTestProjHomeWork.Alghorithms;
using AlgoTestProjHomeWork.ArrayInitialize;
using AlgoTestProjHomeWork.MultiSorting;
using AlgoTestProjHomeWork.Writers;

namespace AlgoTestProjHomeWork
{
	public static class Factory
	{
		public static List<IAlgoTally> AllSortingAlgorithms = new List<IAlgoTally>()
		{
			CreateMergeSorter,
			CreateBubleSorter,
			CreateQuicksort,
		};
		public static IArrayInitializer CreateArrayInitializer { get => new ArrayInitializer(); }
		public static IPerformanceWriter CreatePerformanceWriter { get => new PerformanceWriter(); }
		public static IAlgoTally CreateQuicksort { get => new Quicksort(); }
		public static IAlgoTally CreateBubleSorter { get => new BubleSort(); }
		public static IAlgoTally CreateMergeSorter { get => new MergeSort(); }
		public static IMultiAlgoSorter CreateMultiAlgoSorter { get => new MultiAlgoSorter(); }
	}
}
	