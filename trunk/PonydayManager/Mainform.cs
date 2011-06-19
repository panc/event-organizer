using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using log4net;

using PonydayManager.Entities;

namespace PonydayManager
{
    public partial class MainForm : Form
    {
        private static ILog _log = LogManager.GetLogger(typeof(MainForm));

        public MainForm()
        {
            InitializeComponent();

            _starterDataGridView.AutoGenerateColumns = false;
            _resultDataGridView.AutoGenerateColumns = false;
        }

        private void EditStarter(Starter starter)
        {
            try
            {
                using (EditStarterForm frm = new EditStarterForm(starter))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        _starterDataGridView.StoreRowSelection();
                        _starterDataGridView.DataSource = Starter.Select("");
                        _starterDataGridView.RestoreRowSelection();

                        ReloadResultList();
                    }
                }
            }
            catch (Exception ex)
            {
                _log.Error("Failed to open starter-editing form!", ex);
                MessageBox.Show(this,
                                "Beim Bearbeiten eines Starters ist ein Fehler aufgetreten.",
                                "Starter bearbeiten",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void EditResult(Result result)
        {
            try
            {
                using (EditResultForm frm = new EditResultForm(result, _competitionComboBox.Text))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        _resultDataGridView.Invalidate();
                    }
                }
            }
            catch (Exception ex)
            {
                _log.Error("Failed to open starter-editing form!", ex);
                MessageBox.Show(this,
                                "Beim Bearbeiten eines Starters ist ein Fehler aufgetreten.",
                                "Starter bearbeiten",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void ReloadResultList()
        {
            if (_competitionComboBox.SelectedValue is int)
            {
                _resultDataGridView.StoreRowSelection();
                _resultDataGridView.DataSource = Result.SelectForCompetition(
                                                    (int)_competitionComboBox.SelectedValue);
                _resultDataGridView.RestoreRowSelection();
            }
        }

        private void SetUpDownEnabled()
        {
            if (_resultDataGridView.CurrentRow != null && _resultDataGridView.CurrentRow.DataBoundItem is Result)
            {
                int selectedIndex = _resultDataGridView.CurrentRow.Index;
                if (selectedIndex == 0)
                    _resultUpButton.Enabled = false;
                else
                    _resultUpButton.Enabled = true;

                if (selectedIndex == ((IList<Result>)_resultDataGridView.DataSource).Count - 1)
                    _resultDownButton.Enabled = false;
                else
                    _resultDownButton.Enabled = true;
            }
        }

        #region Events

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                _versionStatusLabel.Text = "Version " + Assembly.GetExecutingAssembly().GetName().Version.ToString();

                _competitionComboBox.DisplayMember = "Caption";
                _competitionComboBox.ValueMember = "Id";
                _competitionComboBox.DataSource = Competition.Select("");

                _starterDataGridView.DataSource = Starter.Select("");
            }
            catch (Exception ex)
            {
                _log.Error("Failed to initialize the application.", ex);
                MessageBox.Show("Beim Laden der Einstellungen ist ein Fehler aufgetreten!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBox frm = new AboutBox())
            {
                frm.ShowDialog(this);
            }
        }

        private void AddStarterButton_Click(object sender, EventArgs e)
        {
            EditStarter(new Starter());
        }

        private void EditStarterButton_Click(object sender, EventArgs e)
        {
            if (_starterDataGridView.CurrentRow.DataBoundItem is Starter)
                EditStarter((Starter)_starterDataGridView.CurrentRow.DataBoundItem);
        }

        private void StarterDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 &&
                _starterDataGridView.RowCount > e.RowIndex &&
                _starterDataGridView.Rows[e.RowIndex].DataBoundItem is Starter)
            {
                EditStarter((Starter)_starterDataGridView.Rows[e.RowIndex].DataBoundItem);
            }
        }

        private void CompetitionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadResultList();
        }

        private void EditResultButton_Click(object sender, EventArgs e)
        {
            if (_resultDataGridView.CurrentRow.DataBoundItem is Result)
                EditResult((Result)_resultDataGridView.CurrentRow.DataBoundItem);
        }

        private void ResultDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 &&
                _resultDataGridView.RowCount > e.RowIndex &&
                _resultDataGridView.Rows[e.RowIndex].DataBoundItem is Result)
            {
                EditResult((Result)_resultDataGridView.Rows[e.RowIndex].DataBoundItem);
            }
        }

        private void StarterListButton_Click(object sender, EventArgs e)
        {
            try
            {
                string caption = string.Empty;
                if (_competitionComboBox.SelectedItem is Competition)
                    caption = ((Competition)_competitionComboBox.SelectedItem).Caption;

                ExcelExporter exporter = new ExcelExporter();
                exporter.ExportStarterList((IList<Result>)_resultDataGridView.DataSource, caption);
            }
            catch (Exception ex)
            {
                _log.Error("Failed to print startlist!", ex);
                MessageBox.Show(this,
                                "Beim Drucken der Starterliste ist ein Fehler aufgetreten.",
                                "Starterliste",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void PrintResultButton_Click(object sender, EventArgs e)
        {
            try
            {
                string caption = string.Empty;
                if (_competitionComboBox.SelectedItem is Competition)
                    caption = ((Competition)_competitionComboBox.SelectedItem).Caption;

                ExcelExporter exporter = new ExcelExporter();
                exporter.ExportResultList((IList<Result>)_resultDataGridView.DataSource, caption);
            }
            catch (Exception ex)
            {
                _log.Error("Failed to print resultlist!", ex);
                MessageBox.Show(this,
                                "Beim Drucken der Ergebnisliste ein Fehler aufgetreten.",
                                "Ergebnisliste",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void ResultUpButton_Click(object sender, EventArgs e)
        {
            if (_resultDataGridView.CurrentRow.DataBoundItem is Result)
            {
                int rowIndex = _resultDataGridView.CurrentRow.Index;
                if (rowIndex > 0)
                {
                    Result current = (Result)_resultDataGridView.CurrentRow.DataBoundItem;
                    Result prev = (Result)_resultDataGridView.Rows[rowIndex - 1].DataBoundItem;

                    int sortIndex = current.SortIndex;
                    current.SortIndex = prev.SortIndex;
                    prev.SortIndex = sortIndex;

                    if (current.SortIndex == prev.SortIndex)
                        prev.SortIndex++;

                    current.Save();
                    prev.Save();

                    ReloadResultList();
                    _resultDataGridView.SetCurrentRow(rowIndex - 1);
                }
            }
        }

        private void ResultDownButton_Click(object sender, EventArgs e)
        {
            if (_resultDataGridView.CurrentRow.DataBoundItem is Result)
            {
                int rowIndex = _resultDataGridView.CurrentRow.Index;
                if (rowIndex < _resultDataGridView.RowCount - 1)
                {
                    Result current = (Result)_resultDataGridView.CurrentRow.DataBoundItem;
                    Result next = (Result)_resultDataGridView.Rows[rowIndex + 1].DataBoundItem;

                    int sortIndex = current.SortIndex;
                    current.SortIndex = next.SortIndex;
                    next.SortIndex = sortIndex;

                    if (current.SortIndex == next.SortIndex)
                        next.SortIndex--;

                    current.Save();
                    next.Save();

                    ReloadResultList();
                    _resultDataGridView.SetCurrentRow(rowIndex + 1);
                }
            }
        }

        private void ResultDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            SetUpDownEnabled();
        }

        #endregion
    }
}
