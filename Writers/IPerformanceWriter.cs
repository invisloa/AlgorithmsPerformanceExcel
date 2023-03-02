using AlgoTestProjHomeWork.Alghorithms;

namespace AlgoTestProjHomeWork.Writers
{
	public interface IPerformanceWriter
	{
		public void WritePerformance(IAlgoTally algoToShowScores);
		public void AllAlgorithmsPerformances(List<IAlgoTally> allAlgorithms);


	}
}