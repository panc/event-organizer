using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PonydayManager.Entities;
using SpreadsheetGear;
using System.Diagnostics;
using System.Configuration;
using System.IO;

namespace PonydayManager
{
    public partial class StarterListForm : Form
    {
        public StarterListForm(Competition competition)
        {
            InitializeComponent();

            _starterDataGridView.AutoGenerateColumns = false;
            _starterDataGridView.DataSource = Starter.SelectForCompetition(competition.Id);

            _captionLabel.Text = string.Format(_captionLabel.Text, competition.Caption);
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            IWorkbook wb = Factory.GetWorkbook();
            
            int rowIndex = 2;
            int colIndex = 0;

            wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = "Vorname";
            wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = "Nachname";
            wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = "Geburtsdatum";
            wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = "Verein";
            wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = "Kommentar";
            wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = "zu bezahlen";
            wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = "bezahlt";

            wb.ActiveWorksheet.Cells[rowIndex, 0].EntireRow.Font.Bold = true;
            rowIndex++;

            foreach (var item in (IList<Starter>)_starterDataGridView.DataSource)
            {
                colIndex = 0;
                wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = item.FirstName;
                wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = item.LastName;
                wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = item.Birthdate;
                wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = item.Club;
                wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = item.Comment;
                wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = item.Costs;
                wb.ActiveWorksheet.Cells[rowIndex, colIndex++].Value = item.Paied ? "[x]" : "";

                rowIndex++;
            }

            wb.ActiveWorksheet.Cells[0, 0, 0, colIndex].EntireColumn.AutoFit();

            // insert the caption after autofit the columns, 
            // else the first column is fitted to the size of the caption
            IRange captionRange = wb.ActiveWorksheet.Cells[0, 0];
            captionRange.Value = _captionLabel.Text;
            captionRange.Font.Bold = true;
            captionRange.Font.Size = 12;


            //string file = "D:\\Tswte.xls";
            string file = ConfigurationManager.AppSettings["TempExcelPath"];
            file = Path.Combine(file, Path.GetRandomFileName());
            file = Path.ChangeExtension(file, "xlt");

            wb.SaveAs(file, FileFormat.Excel8);
            
            Process.Start(file);
            File.Delete(file);

        }
    }
}
