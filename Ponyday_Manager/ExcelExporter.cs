using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Configuration;

using PonydayManager.Entities;
using SpreadsheetGear;

namespace PonydayManager
{
    public class ExcelExporter
    {
        public void ExportStarterList(IList<StarterResult> starter, string competitionCaption)
        {
            string tempFileName = string.Empty;

            try
            {
                IWorkbook wb = Factory.GetWorkbook();

                int rowIndex = 2;
                int colIndex = 0;

                wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = "Vorname";
                wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = "Nachname";
                wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = "Geburtsdatum";
                wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = "Pony";

                wb.ActiveWorksheet.Cells[rowIndex, 0].EntireRow.Font.Bold = true;
                rowIndex++;

                foreach (var item in starter)
                {
                    colIndex = 0;
                    wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = item.FirstName;
                    wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = item.LastName;
                    wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = item.Birthdate;
                    wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = item.Pony;
                    
                    rowIndex++;
                }

                wb.ActiveWorksheet.Cells[0, 0, 0, colIndex].EntireColumn.AutoFit();

                // insert the caption after autofit the columns, 
                // else the first column is fitted to the size of the caption
                IRange captionRange = wb.ActiveWorksheet.Cells[0, 0];
                captionRange.Value = string.Format("Starterliste für: {0}", competitionCaption);
                captionRange.Font.Bold = true;
                captionRange.Font.Size = 12;


                //string file = "D:\\Tswte.xls";
                tempFileName = ConfigurationManager.AppSettings["TempExcelPath"];
                tempFileName = Path.Combine(tempFileName, Path.GetRandomFileName());
                tempFileName = Path.ChangeExtension(tempFileName, "xlt");

                wb.SaveAs(tempFileName, FileFormat.Excel8);

                Process.Start(tempFileName);
            }
            finally
            {
                if (File.Exists(tempFileName))
                    File.Delete(tempFileName);
            }
        }
    }
}
