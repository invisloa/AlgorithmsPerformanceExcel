using AlgoTestProjHomeWork.Alghorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;


namespace AlgoTestProjHomeWork.Writers
{
	public class ExcelScoresWriter
	{
		Excel.Application excelApp;
		Excel.Workbook workbook;
		Excel.Worksheet worksheet;
		int currentRow = 0;
		public ExcelScoresWriter()
		{
			excelApp = new Excel.Application();
			workbook = excelApp.Workbooks.Add();
			worksheet = (Excel.Worksheet)workbook.Worksheets[1];
			worksheet.Cells[currentRow, 1] = $"Algorithm type";
			worksheet.Cells[currentRow, 2] = $"Operating time";
			worksheet.Cells[currentRow, 3] = $"Actions";
			currentRow++;
		}

		public void WriteToExcel(IAlgoTally algoToShowScores)
		{
			worksheet.Cells[currentRow, 1] = $"{algoToShowScores}";
			worksheet.Cells[currentRow, 2] = $"{algoToShowScores.Stopwatch.Elapsed.TotalMilliseconds}";
			worksheet.Cells[currentRow, 3] = $"{algoToShowScores.ActionsCounted}";
			currentRow++;
		}

		public void WriteAllAlgorithmsPerformances(List<IAlgoTally> allAlgorithms)
		{
			foreach (IAlgoTally item in allAlgorithms)
			{
				WriteToExcel(item);
				item.Stopwatch.Reset();
			}
			worksheet.SaveAs($"output.xlsx");
			workbook.Close();
			excelApp.Quit();

		}

	}
}