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
    public partial class MainForm : Form
    {
        private static ILog _log = LogManager.GetLogger(typeof(MainForm));

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                _starterDataGridView.AutoGenerateColumns = false;
                _starterListDataGridView.AutoGenerateColumns = false;

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

        private void StarterDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (_starterDataGridView.CurrentRow != null && _starterDataGridView.CurrentRow.DataBoundItem is Starter)
                {
                    using (EditStarterForm starter = new EditStarterForm((Starter)_starterDataGridView.CurrentRow.DataBoundItem))
                    {
                        if (starter.ShowDialog() == DialogResult.OK)
                            _starterDataGridView.DataSource = Starter.Select("");
                    }
                }
            }
            catch (Exception ex)
            {
                _log.Error("Failed to open a starter!", ex);
                MessageBox.Show(this,
                                "Beim Öffnen des Starters ist ein Fehler aufgetreten.",
                                "Starter öffnen",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void AddStarterButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (EditStarterForm starter = new EditStarterForm(new Starter()))
                {
                    if (starter.ShowDialog() == DialogResult.OK)
                        _starterDataGridView.DataSource = Starter.Select("");
                }
            }
            catch (Exception ex)
            {
                _log.Error("Failed to open starter-editing form!", ex);
                MessageBox.Show(this,
                                "Beim Hinzufügen eines neuen Starters ist ein Fehler aufgetreten.",
                                "Starter hinzufügen",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void EditStarterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_starterDataGridView.CurrentRow.DataBoundItem is Starter)
                {
                    using (EditStarterForm starter = new EditStarterForm((Starter)_starterDataGridView.CurrentRow.DataBoundItem))
                    {
                        if (starter.ShowDialog() == DialogResult.OK)
                            _starterDataGridView.DataSource = Starter.Select("");
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

        private void StarterListButton_Click(object sender, EventArgs e)
        {
            try
            {
                string caption = string.Empty;
                if (_competitionComboBox.SelectedItem is Competition)
                    caption = ((Competition)_competitionComboBox.SelectedItem).Caption;

                ExcelExporter exporter = new ExcelExporter();
                exporter.ExportStarterList((IList<Starter>)_starterListDataGridView.DataSource, caption);
            }
            catch (Exception ex)
            {
                _log.Error("Failed to open startlist!", ex);
                MessageBox.Show(this,
                                "Beim Laden der Starterliste ist ein Fehler aufgetreten.",
                                "Starterlist",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        

        private void CompetitionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_competitionComboBox.SelectedValue is int)
                _starterListDataGridView.DataSource = Starter.SelectForCompetition((int)_competitionComboBox.SelectedValue);
        }
    }
}
