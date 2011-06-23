using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using log4net;

using PonydayManager.Entities;

namespace PonydayManager
{
    public partial class CompetitionForm : Form
    {
        private static ILog _log = LogManager.GetLogger(typeof(EditResultForm));

        private PonyCompetition _result;
        private bool _isDirty;
        private bool _isLoading;

        public CompetitionForm()
        {
            InitializeComponent();

            // load the grid data
            _competitionDataGridView.AutoGenerateColumns = false;
            _competitionDataGridView.DataSource = Competition.Select();
        }

        private void Save()
        {
            if (_isDirty)
            {
                EntityList<Competition> list = (EntityList<Competition>)_competitionDataGridView.DataSource;
                foreach (var item in list)
                    item.Save();
                
                foreach (var item in list.RemovedEntities)
                    item.Save();
                
                _isDirty = false;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Save();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                _log.Error("Failed to save starter!", ex);
                MessageBox.Show(this,
                                "Beim Speichern der Wertungsdaten ist ein Fehler aufgetreten.",
                                "Speichern",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }

        private void CompetitionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isDirty)
            {
                DialogResult dlg = MessageBox.Show(this,
                                   "Wollen Sie die Wertungsdaten speichern?",
                                   "Schließen",
                                   MessageBoxButtons.YesNoCancel,
                                   MessageBoxIcon.Question);

                if (dlg == DialogResult.Yes)
                    Save();
                else if (dlg == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void CompetitionDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!_isLoading && !_isLoading && e.RowIndex > -1 && e.ColumnIndex > -1)
                _isDirty = true;
        }

        private void CompetitionDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (!_isLoading && e.RowIndex > -1)
                _isDirty = true;
        }

        private void CompetitionDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (!_isLoading && e.RowIndex > -1)
                _isDirty = true;
        }

        private void CompetitionDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row != null && e.Row.DataBoundItem is Competition)
            {
                Competition c = (Competition)e.Row.DataBoundItem;
                int count = PonyCompetition.SelectInUseCount(c.Id);
                if (count > 0)
                {
                    MessageBox.Show(this, 
                                    string.Format("Der Bewerb kann nicht gelöscht werden, da er bereits {0} Starter zugeordnet wurde.", count),
                                    "Bewerb löschen", 
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);

                    e.Cancel = true;
                }
            }
        }
    }
}
