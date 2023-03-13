using AlgoTestProjHomeWork;
using AlgoTestProjHomeWork.ArrayInitialize;
using AlgoTestProjHomeWork.MultiSorting;
using AlgoTestProjHomeWork.Writers;

class Program
{
	static void Main(string[] args)
	{
		IPerformanceWriter excelPerformanceWriter = Factory.CreatePerformanceWriter;
		IPerformanceWriter consolePerformanceWriter = Factory.CreateConsolePerformanceWriter;
		IArrayInitializer arrayInitializer = Factory.CreateArrayInitializer;
		IMultipleAlgorithmsSorter multiAlgorithmsSorter = Factory.CreateMultiAlgorithmsSorter;
		
		int[][] multipleArrays = arrayInitializer.InitializeMultipleArrays();

		multiAlgorithmsSorter.SortMultipleArrays(multipleArrays);

		consolePerformanceWriter.WriteAllAlgorithmsPerformances(multiAlgorithmsSorter);
		excelPerformanceWriter.WriteAllAlgorithmsPerformances(multiAlgorithmsSorter);
	}
}
