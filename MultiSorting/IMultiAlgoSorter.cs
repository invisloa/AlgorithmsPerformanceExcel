using AlgoTestProjHomeWork.Alghorithms;

namespace AlgoTestProjHomeWork.MultiSorting
{
	public interface IMultipleAlgorithmsSorter
	{
		List<IAlgorithmScoresCounter> AllUsedAlgoritms { get; }
		void SortMultipleArrays(int[][] arraysToSort);
		public int NumberOfArraysToSort { get; }
		public int NumberOfValuesInArray { get; }

	}
}