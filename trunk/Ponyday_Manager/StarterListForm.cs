using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PonydayManager.Entities;

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
            //SpreadsheetGear.Factory.GetWorkbook(
        }
    }
}
