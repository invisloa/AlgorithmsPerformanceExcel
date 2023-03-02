﻿using AlgoTestProjHomeWork;
using AlgoTestProjHomeWork.Alghorithms;
using AlgoTestProjHomeWork.ArrayInitialize;
using AlgoTestProjHomeWork.MultiSorting;
using AlgoTestProjHomeWork.Writers;
using System;

class Program
{
	static void Main(string[] args)
	{
		IPerformanceWriter performanceWriter = Factory.CreatePerformanceWriter;
		IArrayInitializer arrayInitializer = Factory.CreateArrayInitializer;
		int[][] multipleArrays = arrayInitializer.MultiArrayInitializer();
		IMultiAlgoSorter multiAlgoSorter = Factory.CreateMultiAlgoSorter;
		multiAlgoSorter.SortMultipleArrays(multipleArrays);
		performanceWriter.AllAlgorithmsPerformances(multiAlgoSorter.AllSortingAlgoritms);
	}
}

/*
 * 		List<IAlgoTally> AllSortingAlgorithms = Factory.AllSortingAlgorithms;

		// int[] someArray = arrayInitializer.SingleArrayInitializer();

IAlgoTally quickSorter = Factory.CreateQuicksort;
IAlgoTally boubleSorter = Factory.CreateBoubleSorter;
IAlgoTally mergeSorter = Factory.CreateMergeSorter;

boubleSorter.SortArray(someArray);
quickSorter.SortArray(someArray);
mergeSorter.SortArray(someArray);

 		performanceWriter.WritePerformance(boubleSorter);
		performanceWriter.WritePerformance(quickSorter);
		performanceWriter.WritePerformance(mergeSorter);
 
 */