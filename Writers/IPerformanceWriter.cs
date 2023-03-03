using AlgoTestProjHomeWork.Alghorithms;
using AlgoTestProjHomeWork.MultiSorting;

namespace AlgoTestProjHomeWork.Writers
{
	public interface IPerformanceWriter
	{
		public void WriteAlgorithmPerformance(IAlgorithmScoresCounter algorithmToShowScores);
		public void WriteAllAlgorithmsPerformances(IMultipleAlgorithmsSorter multipleAlgorithmsSorter);
	}
}