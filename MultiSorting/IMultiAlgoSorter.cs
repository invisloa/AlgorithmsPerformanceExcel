using AlgoTestProjHomeWork.Alghorithms;

namespace AlgoTestProjHomeWork.MultiSorting
{
	public interface IMultiAlgoSorter
	{
		List<IAlgoTally> AllSortingAlgoritms { get; }
		void SortMultipleArrays(int[][] arraysToSort);
	}
}