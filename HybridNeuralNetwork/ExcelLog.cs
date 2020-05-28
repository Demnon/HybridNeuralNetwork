using System;
using OfficeOpenXml;
using System.IO;

namespace HybridNeuralNetwork
{
	// Работа с журналом
    public class ExcelLog:IDisposable
    {
		//книга
		ExcelPackage w_Book;
		//лист
		ExcelWorksheet w_Sheet;
		// Путь к журналу
		string s_Path = AppDomain.CurrentDomain.BaseDirectory + "Log.xlsx";
		// Текущая строка для записи
		int i_CurrentRow;

		public ExcelLog()
		{
			//отрытие файла Excel
			FileInfo f_Book = new FileInfo(s_Path);
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
			w_Book = new ExcelPackage(f_Book);

			// Создание файла, если нет
			if (!File.Exists(s_Path))
			{
				w_Sheet = w_Book.Workbook.Worksheets.Add("1");
				w_Book.SaveAs(f_Book);
			}
			else
			{
				w_Sheet = w_Book.Workbook.Worksheets[0];
			}
			w_Book.Workbook.CalcMode = ExcelCalcMode.Automatic;

			// Установка текущей строки для записи
			i_CurrentRow = 1;

		}

		//очистка
		public void Dispose()
		{
			w_Book.Save();
			w_Book.Dispose();
		}

		// Очистка журнала
		public void ClearLog()
		{
			w_Sheet.Cells.Clear();
		}

		// Добавление записи в журнал
		public void AddEntryInLog(string[] s_NameParameters,string s_Time,double[] d_Values,string s_StatusNetwork)
		{
			for (int i = 0; i < s_NameParameters.Length; i++, i_CurrentRow++)
			{
				w_Sheet.Cells[i_CurrentRow, 1].Value = s_NameParameters[i];
				w_Sheet.Cells[i_CurrentRow, 2].Value = s_Time;
				w_Sheet.Cells[i_CurrentRow, 3].Value = d_Values[i];
				w_Sheet.Cells[i_CurrentRow, 4].Value = s_StatusNetwork;
			}
		}
	}
}
