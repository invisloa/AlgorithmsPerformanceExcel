using AlgoTestProjHomeWork;
using AlgoTestProjHomeWork.ArrayInitialize;
using AlgoTestProjHomeWork.MultiSorting;
using AlgoTestProjHomeWork.Writers;

class Program
{
	static void Main(string[] args)
	{
		IPerformanceWriter performanceWriter = Factory.CreatePerformanceWriter;
		IArrayInitializer arrayInitializer = Factory.CreateArrayInitializer;

		int[][] multipleArrays = arrayInitializer.InitializeMultipleArrays();
		IMultipleAlgorithmsSorter multiAlgorithmsSorter = Factory.CreateMultiAlgorithmsSorter;

		multiAlgorithmsSorter.SortMultipleArrays(multipleArrays);

		performanceWriter.WriteAllAlgorithmsPerformances(multiAlgorithmsSorter);
	}
}
