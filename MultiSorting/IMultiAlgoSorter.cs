using AlgoTestProjHomeWork.Alghorithms;

namespace AlgoTestProjHomeWork.MultiSorting
{
	public interface IMultiAlgoSorter
	{
		List<IAlgoScoresCounter> AllSortingAlgoritms { get; }
		void SortMultipleArrays(int[][] arraysToSort);
	}
}