using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoTestProjHomeWork.Alghorithms;
using AlgoTestProjHomeWork.ArrayInitialize;
using AlgoTestProjHomeWork.Writers;

namespace AlgoTestProjHomeWork
{
    public static class Factory
	{
		public static IArrayInitializer CreateArrayInitializer { get => new ArrayInitializer(); }
		public static IPerformanceWriter CreatePerformanceWriter { get => new PerformanceWriter(); }
		public static IAlgoTally CreateQuicksort { get => new Quicksort(); }
		public static IAlgoTally CreateBoubleSorter { get => new BoubleSort(); }
		public static IAlgoTally CreateMergeSorter { get => new MergeSort(); }
	}
}
