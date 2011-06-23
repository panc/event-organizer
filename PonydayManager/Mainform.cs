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
            _starterCompetitionDataGridView.AutoGenerateColumns = false;
            _resultDataGridView.AutoGenerateColumns = false;
        }

        private void EditStarter(Starter starter)
        {
            try
            {
                using (EditStarterForm frm = new EditStarterForm(starter))
                {
                    frm.ShowDialog();
                    _starterDataGridView.StoreRowSelection();
                    _starterDataGridView.DataSource = Starter.Select("");
                    _starterDataGridView.RestoreRowSelection();

                    ReloadStarterCompetitionList();
                    ReloadResultList();
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

        private void EditResult(PonyCompetition result)
        {
            try
            {
                using (EditResultForm frm = new EditResultForm(result, _competitionTabTwoComboBox.Text))
                {
                    frm.ShowDialog();
                    ReloadResultList();
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

        private void ReloadStarterCompetitionList()
        {
            if (_competitionTabOneComboBox.SelectedValue is int)
            {
                _starterCompetitionDataGridView.StoreRowSelection();
                _starterCompetitionDataGridView.DataSource = PonyCompetition.SelectForCompetition(
                                                    (int)_competitionTabOneComboBox.SelectedValue,
                                                    false);
                _starterCompetitionDataGridView.RestoreRowSelection();
            }
        }


        private void ReloadResultList()
        {
            if (_competitionTabTwoComboBox.SelectedValue is int)
            {
                _resultDataGridView.StoreRowSelection();
                _resultDataGridView.DataSource = PonyCompetition.SelectForCompetition(
                                                    (int)_competitionTabTwoComboBox.SelectedValue,
                                                    true);
                _resultDataGridView.RestoreRowSelection();
            }
        }

        private void SetUpDownEnabled()
        {
            if (_starterCompetitionDataGridView.CurrentRow != null && _starterCompetitionDataGridView.CurrentRow.DataBoundItem is PonyCompetition)
            {
                int selectedIndex = _starterCompetitionDataGridView.CurrentRow.Index;
                if (selectedIndex == 0)
                    _resultUpButton.Enabled = false;
                else
                    _resultUpButton.Enabled = true;

                if (selectedIndex == ((IList<PonyCompetition>)_starterCompetitionDataGridView.DataSource).Count - 1)
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

                IList<Competition> list = Competition.Select("");
                _competitionTabOneComboBox.DisplayMember = "Caption";
                _competitionTabOneComboBox.ValueMember = "Id";
                _competitionTabOneComboBox.DataSource = list;

                _competitionTabTwoComboBox.DisplayMember = "Caption";
                _competitionTabTwoComboBox.ValueMember = "Id";
                _competitionTabTwoComboBox.DataSource = list.ToList();

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

        private void StarterCompetitionDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            SetUpDownEnabled();
        }

        private void ResultDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 &&
                _resultDataGridView.RowCount > e.RowIndex &&
                _resultDataGridView.Rows[e.RowIndex].DataBoundItem is PonyCompetition)
            {
                EditResult((PonyCompetition)_resultDataGridView.Rows[e.RowIndex].DataBoundItem);
            }
        }

        private void CompetitionTabOneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadStarterCompetitionList();
        }

        private void CompetitionTabTwoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadResultList();
        }

        private void EditResultButton_Click(object sender, EventArgs e)
        {
            if (_starterCompetitionDataGridView.CurrentRow.DataBoundItem is PonyCompetition)
                EditResult((PonyCompetition)_starterCompetitionDataGridView.CurrentRow.DataBoundItem);
        }

        private void StarterListButton_Click(object sender, EventArgs e)
        {
            try
            {
                string caption = string.Empty;
                if (_competitionTabOneComboBox.SelectedItem is Competition)
                    caption = ((Competition)_competitionTabOneComboBox.SelectedItem).Caption;

                ExcelExporter exporter = new ExcelExporter();
                exporter.ExportStarterList((IList<PonyCompetition>)_starterCompetitionDataGridView.DataSource, caption);
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
                if (_competitionTabOneComboBox.SelectedItem is Competition)
                    caption = ((Competition)_competitionTabOneComboBox.SelectedItem).Caption;

                ExcelExporter exporter = new ExcelExporter();
                exporter.ExportResultList((IList<PonyCompetition>)_resultDataGridView.DataSource, caption);
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
            if (_starterCompetitionDataGridView.CurrentRow.DataBoundItem is PonyCompetition)
            {
                int rowIndex = _starterCompetitionDataGridView.CurrentRow.Index;
                if (rowIndex > 0)
                {
                    PonyCompetition current = (PonyCompetition)_starterCompetitionDataGridView.CurrentRow.DataBoundItem;
                    PonyCompetition prev = (PonyCompetition)_starterCompetitionDataGridView.Rows[rowIndex - 1].DataBoundItem;

                    int sortIndex = current.SortIndex;
                    current.SortIndex = prev.SortIndex;
                    prev.SortIndex = sortIndex;

                    if (current.SortIndex == prev.SortIndex)
                        prev.SortIndex++;

                    current.Save();
                    prev.Save();

                    ReloadStarterCompetitionList();
                    _starterCompetitionDataGridView.SetCurrentRow(rowIndex - 1);
                }
            }
        }

        private void ResultDownButton_Click(object sender, EventArgs e)
        {
            if (_starterCompetitionDataGridView.CurrentRow.DataBoundItem is PonyCompetition)
            {
                int rowIndex = _starterCompetitionDataGridView.CurrentRow.Index;
                if (rowIndex < _starterCompetitionDataGridView.RowCount - 1)
                {
                    PonyCompetition current = (PonyCompetition)_starterCompetitionDataGridView.CurrentRow.DataBoundItem;
                    PonyCompetition next = (PonyCompetition)_starterCompetitionDataGridView.Rows[rowIndex + 1].DataBoundItem;

                    int sortIndex = current.SortIndex;
                    current.SortIndex = next.SortIndex;
                    next.SortIndex = sortIndex;

                    if (current.SortIndex == next.SortIndex)
                        next.SortIndex--;

                    current.Save();
                    next.Save();

                    ReloadStarterCompetitionList();
                    _starterCompetitionDataGridView.SetCurrentRow(rowIndex + 1);
                }
            }
        }

        #endregion
    }
}
