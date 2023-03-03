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
		IMultipleAlgorithmsSorter multiAlgorithmsSorter = Factory.CreateMultiAlgorithmsSorter;
		int[][] multipleArrays = arrayInitializer.InitializeMultipleArrays();

		multiAlgorithmsSorter.SortMultipleArrays(multipleArrays);

		performanceWriter.WriteAllAlgorithmsPerformances(multiAlgorithmsSorter);
	}
}
