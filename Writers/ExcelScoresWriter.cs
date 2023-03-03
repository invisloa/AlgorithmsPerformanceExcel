using AlgoTestProjHomeWork.Alghorithms;
using AlgoTestProjHomeWork.MultiSorting;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;

namespace AlgoTestProjHomeWork.Writers
{
	public class ExcelScoresWriter : IDisposable, IPerformanceWriter
	{
		private readonly IXLWorkbook workbook = new XLWorkbook();
		private readonly IXLWorksheet worksheet;
		private string fileSaveName = "SortedAlgorithms.xlsx";
		private ISortAlgorithmsScores _scoreSorter;
		private ISortAlgorithmsScores ScoreSorter => _scoreSorter ??= Factory.CreateSortScoresBeforeWrite;
		public IXLWorkbook Workbook => workbook;
		public IXLWorksheet Worksheet => worksheet;
		public string FileSaveName => fileSaveName;
		public ExcelScoresWriter()
		{
			worksheet = workbook.Worksheets.Add("Algoritms performances");
			// Initialize the worksheet headers
			Worksheet.Cell(1, 1).Value = "Algorithm type";
			Worksheet.Cell(1, 2).Value = "Operating time";
			Worksheet.Cell(1, 3).Value = "Actions";
		}

		public void WriteToExcel(IAlgorithmScoresCounter algoToShowScores)
		{
			singleAlgorithmWrite(algoToShowScores);
			using (var workbook = Worksheet.Workbook)
			{
				workbook.SaveAs(FileSaveName);
			}
			Console.WriteLine($"File has been saved as {FileSaveName}");
		}
		void singleAlgorithmWrite(IAlgorithmScoresCounter algoToShowScores)
		{           // Write the algorithm scores to the next row in the worksheet
			int currentRow = Worksheet.LastRowUsed().RowNumber() + 1;
			Worksheet.Cell(currentRow, 1).Value = algoToShowScores.ToString();
			Worksheet.Cell(currentRow, 2).Value = $"{algoToShowScores.Stopwatch.Elapsed.TotalMilliseconds}ms";
			Worksheet.Cell(currentRow, 3).Value = algoToShowScores.ActionsCounted;
		}

		public void WriteAllAlgorithmsPerformances(IMultipleAlgorithmsSorter allAlgorithms)
		{
			// Sort the algorithms by score before writing them to the worksheet
			ScoreSorter.SortScoresBeforeWrite(allAlgorithms);

			foreach (var algorithm in allAlgorithms.AllUsedAlgoritms)
			{
				singleAlgorithmWrite(algorithm);
				algorithm.Stopwatch.Reset();
			}
			WriteArraysInfo(allAlgorithms);
			// Save the workbook to a file and dispose of the workbook object
			using (var workbook = Worksheet.Workbook)
			{
				workbook.SaveAs(FileSaveName);
			}
			Console.WriteLine($"File has been saved as {FileSaveName}");
		}
		public void Dispose()
		{
			Workbook.Dispose();
		}
		public void WriteAlgorithmPerformance(IAlgorithmScoresCounter algoToShowScores)
		{
			singleAlgorithmWrite(algoToShowScores);
			algoToShowScores.Stopwatch.Reset();
		}

		public void WriteArraysInfo(IMultipleAlgorithmsSorter algoToShowScores)
		{
			int currentRow = Worksheet.LastRowUsed().RowNumber() + 1;
			Worksheet.Cell(currentRow, 1).Value = "Arrays size:";
			Worksheet.Cell(currentRow, 2).Value = $"{algoToShowScores.NumberOfArraysToSort} X {algoToShowScores.NumberOfValuesInArray}";
		}
	}
}