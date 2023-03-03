using AlgoTestProjHomeWork.Alghorithms;

namespace AlgoTestProjHomeWork.Writers
{
	public interface IPerformanceWriter
	{
		public void WritePerformance(IAlgoScoresCounter algoToShowScores);
		public void WriteAllAlgorithmsPerformances(List<IAlgoScoresCounter> allAlgorithms);


	}
}