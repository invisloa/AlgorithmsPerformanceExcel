using AlgoTestProjHomeWork;
using AlgoTestProjHomeWork.Alghorithms;
using AlgoTestProjHomeWork.ArrayInitialize;
using AlgoTestProjHomeWork.Writers;
using System;

class Program
{
	static void Main(string[] args)
	{
		IArrayInitializer arrayInitializer = Factory.CreateArrayInitializer;
		IAlgoSorter quickSorter = Factory.CreateQuicksort;
		IPerformanceWriter performanceWriter = Factory.CreatePerformanceWriter;
		int [] someArray = arrayInitializer.InitializeArray();

		quickSorter.SortArray(someArray);
		performanceWriter.WritePerformance(quickSorter);

		foreach (int i in someArray) { Console.WriteLine(i); }


	}
}