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
    public partial class EditStarterForm : Form
    {
        private static ILog _log = LogManager.GetLogger(typeof(EditStarterForm));

        private Starter _starter;
        private bool _isDirty;
        private bool _isLoading;
        private bool _isDataSourceChanging;

        public EditStarterForm()
        {
            InitializeComponent();

            _ponyDataGridView.AutoGenerateColumns = false;
            _competitionDataGridView.AutoGenerateColumns = false;

            _isLoading = true;
        }

        public EditStarterForm(Starter starter)
            : this()
        {
            _starter = starter;
            
            // load the textboxes
            _firstName.Text = _starter.FirstName;
            _lastName.Text = _starter.LastName;
            _club.Text = _starter.Club;
            _comment.Text = _starter.Comment;
            _birthdate.Value = _starter.Birthdate ?? DateTime.Now.Date;
            _costs.Text = string.Format("{0:#,##0.00}", _starter.Costs);
            _paied.Checked = _starter.Paied;

            // load the competition-combo in the grid-column
            DataGridViewComboBoxColumn comboColumn = (DataGridViewComboBoxColumn)_competitionDataGridView.Columns[0];
            comboColumn.DataSource = Competition.Select();
            comboColumn.DisplayMember = "Caption";
            comboColumn.ValueMember = "Id";

            _ponyDataGridView.DataSource = _starter.Ponys;
        }

        private void EditStarterForm_Load(object sender, EventArgs e)
        {
            // is needed, because the datagridview-events occours to often
            _isLoading = false;
        }

        private void Save()
        {
            // update the values from the textboxes
            _starter.FirstName = _firstName.Text;
            _starter.LastName = _lastName.Text;
            _starter.Club = _club.Text;
            _starter.Comment = _comment.Text;
            _starter.Birthdate = _birthdate.Value;
            _starter.Costs = _costs.GetTextAsDecimal();
            _starter.Paied = _paied.Checked;

            _starter.Save();
            _isDirty = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_isDirty)
                {
                    if (string.IsNullOrEmpty(_firstName.Text) || string.IsNullOrEmpty(_lastName.Text))
                    {
                        MessageBox.Show(this,
                                        "Es müssen ein Vor- und ein Nachname eingegeben werden!",
                                        "Speichern",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        return;
                    }

                    Save();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                _log.Error("Failed to save starter!", ex);
                MessageBox.Show(this,
                                "Beim Speichern der Meldedaten ist ein Fehler aufgetreten.",
                                "Speichern",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }

        private void Control_Changed(object sender, EventArgs e)
        {
            if (!_isLoading)
                _isDirty = true;
        }

        private void EditStarterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isDirty)
            {
                DialogResult dlg = MessageBox.Show(this,
                                   "Wollen Sie die Meldedaten speichern?",
                                   "Schließen",
                                   MessageBoxButtons.YesNoCancel,
                                   MessageBoxIcon.Question);

                if (dlg == DialogResult.Yes)
                    Save();
                else if (dlg == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void Competitions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!_isLoading)
                _isDirty = true;
        }

        private void Paied_CheckedChanged(object sender, EventArgs e)
        {
            if (!_isLoading)
                _isDirty = true;
        }

        private void Costs_Leave(object sender, EventArgs e)
        {
            _costs.Text = string.Format("{0:#,##0.00}", _costs.GetTextAsDecimal());
        }

        private void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!_isDataSourceChanging && !_isLoading && e.RowIndex > -1 && e.ColumnIndex > -1)
                _isDirty = true;
        }

        private void PonyDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (!_isLoading && e.RowIndex > -1)
            {
                _isDirty = true;
                
                Pony p = (Pony)_ponyDataGridView.CurrentRow.DataBoundItem;
                _competitionDataGridView.DataSource = p.Competitions;
            }
        }

        private void CompetitionDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (!_isDataSourceChanging && !_isLoading && e.RowIndex > -1)
                _isDirty = true;
        }

        private void DataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (!_isDataSourceChanging && !_isLoading && e.RowIndex > -1)
                _isDirty = true;
        }

        private void PonyDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (_ponyDataGridView.CurrentRow != null && _ponyDataGridView.CurrentRow.DataBoundItem is Pony)
            {
                _isDataSourceChanging = true;

                Pony p = (Pony)_ponyDataGridView.CurrentRow.DataBoundItem;
                _competitionDataGridView.DataSource = p.Competitions;

                _isDataSourceChanging = false;
            }
        }
    }
}
