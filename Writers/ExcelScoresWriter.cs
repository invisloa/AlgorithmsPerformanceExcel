using AlgoTestProjHomeWork.Alghorithms;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;

namespace AlgoTestProjHomeWork.Writers
{
	public class ExcelScoresWriter : IDisposable, IPerformanceWriter
	{
		private ISortAlgorithmsScores _scoreSorter;
		private readonly IXLWorkbook workbook;
		private readonly IXLWorksheet worksheet;

		private ISortAlgorithmsScores ScoreSorter => _scoreSorter ??= Factory.CreateSortScoresBeforeWrite;

		public IXLWorkbook Workbook => workbook;
		public IXLWorksheet Worksheet => worksheet;

		public ExcelScoresWriter()
		{
			workbook = new XLWorkbook();
			worksheet = workbook.Worksheets.Add("Algoritms performances");

			// Initialize the worksheet headers
			Worksheet.Cell(1, 1).Value = "Algorithm type";
			Worksheet.Cell(1, 2).Value = "Operating time";
			Worksheet.Cell(1, 3).Value = "Actions";
		}

		public void WriteToExcel(IAlgoScoresCounter algoToShowScores)
		{
			// Write the algorithm scores to the next row in the worksheet
			int currentRow = Worksheet.LastRowUsed().RowNumber() + 1;
			Worksheet.Cell(currentRow, 1).Value = algoToShowScores.ToString();
			Worksheet.Cell(currentRow, 2).Value = algoToShowScores.Stopwatch.Elapsed.TotalMilliseconds;
			Worksheet.Cell(currentRow, 3).Value = algoToShowScores.ActionsCounted;
		}

		public void WriteAllAlgorithmsPerformances(List<IAlgoScoresCounter> allAlgorithms)
		{
			// Sort the algorithms by score before writing them to the worksheet
			ScoreSorter.SortScoresBeforeWrite(allAlgorithms);

			foreach (var algorithm in allAlgorithms)
			{
				WriteToExcel(algorithm);
				algorithm.Stopwatch.Reset();
			}

			// Save the workbook to a file and dispose of the workbook object
			using (var workbook = Worksheet.Workbook)
			{
				workbook.SaveAs("SortedAlgorithms.xlsx");
			}
		}

		public void Dispose()
		{
			Workbook.Dispose();
		}

		public void WritePerformance(IAlgoScoresCounter algoToShowScores)
		{
			WriteToExcel(algoToShowScores);
			algoToShowScores.Stopwatch.Reset();
		}
	}
}