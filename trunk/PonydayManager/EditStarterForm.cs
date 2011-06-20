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

        public EditStarterForm()
        {
            InitializeComponent();

            _ponyDataGridView.AutoGenerateColumns = false;
        }
        
        public EditStarterForm(Starter starter)
            : this()
        {
            _starter = starter;
            _isLoading = true;

            // load the textboxes
            _firstName.Text = _starter.FirstName;
            _lastName.Text = _starter.LastName;
            _club.Text = _starter.Club;
            _comment.Text = _starter.Comment;
            _birthdate.Value = _starter.Birthdate ?? DateTime.Now.Date;
            _costs.Text = string.Format("{0:#,##0.00}", _starter.Costs);
            _paied.Checked = _starter.Paied;

            _ponyDataGridView.DataSource = _starter.Ponys;

            // load the competition-listbox
            foreach (var item in Competition.Select(""))
            {
                if (_starter.Competitions.Where(c => c.CompetitionId == item.Id).Count() == 0)
                    _starter.Competitions.Add(new StarterCompetition
                        {
                            CompetitionId = item.Id,
                            StarterId = _starter.Id
                        });
            }
            
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

            // update the values from the listbox
            //foreach (var item in _competitions.Items)
            //{
            //    if (item is StarterCompetition)
            //        ((StarterCompetition)item).IsChecked = _competitions.CheckedItems.Contains(item);
            //}

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

        private void StarterForm_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
