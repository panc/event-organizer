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
        public void ExportStarterList(IList<PonyCompetition> starter, string competitionCaption)
        {
            string tempFileName = string.Empty;

            try
            {
                string template = ConfigurationManager.AppSettings["StarterListTemplate"];
                IWorkbook wb = Factory.GetWorkbook(template);

                int rowIndex = 5;
                int colIndex = 1;

                foreach (var item in starter)
                {
                    colIndex = 1;
                    wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = item.LastName;
                    wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = item.FirstName;
                    wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = item.Pony;
                    wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = item.Club;

                    rowIndex++;
                }

                IRange captionRange = wb.ActiveWorksheet.Cells[1, 0];
                captionRange.Value = string.Format("Startliste für: {0}", competitionCaption);

                tempFileName = CreateTempFileName(template);
                wb.SaveAs(tempFileName, FileFormat.Excel8);

                Process.Start(tempFileName);
            }
            finally
            {
                if (File.Exists(tempFileName))
                    File.Delete(tempFileName);
            }
        }

        private string CreateTempFileName(string template)
        {
            string fileName = DateTime.Now.ToString("yyyyMMddhhmmss") + "_" + Path.GetFileName(template);
            return Path.Combine(ConfigurationManager.AppSettings["TempExcelPath"], fileName);
        }

        public void ExportResultList(IList<PonyCompetition> results, string competitionCaption)
        {
            string tempFileName = string.Empty;

            try
            {
                string template = ConfigurationManager.AppSettings["ResultListTemplate"];
                IWorkbook wb = Factory.GetWorkbook(template);

                int rowIndex = 5;
                int colIndex = 1;
                                
                foreach (var item in results)
                {
                    colIndex = 1;
                    wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = item.LastName;
                    wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = item.FirstName;
                    wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = item.Pony;
                    wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = item.Assessment;

                    rowIndex++;
                }

                IRange captionRange = wb.ActiveWorksheet.Cells[1, 0];
                captionRange.Value = string.Format("Ergebnisliste für: {0}", competitionCaption);
                
                tempFileName = CreateTempFileName(template);
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
