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
    public partial class EditResultForm : Form
    {
        private static ILog _log = LogManager.GetLogger(typeof(EditResultForm));

        private PonyCompetition _result;
        private bool _isDirty;
        private bool _isLoading;

        public EditResultForm()
        {
            InitializeComponent();
        }

        public EditResultForm(PonyCompetition result, string competitionCaption)
            : this()
        {
            _isLoading = true;
            _result = result;

            _titleLable.Text = string.Format(_titleLable.Text, competitionCaption);
            _starterInfo.Text = string.Format("{0} {1}", result.FirstName, result.LastName);
            _ponyInfo.Text = result.Pony;

            _assessment.Text = result.Assessment.ToString();

            _comment.Text = result.Comment;
            _isLoading = false;
        }

        private void Save()
        {
            if (_isDirty)
            {
                // update the values from the textboxes
                _result.Assessment = _assessment.GetTextAsDecimal();
                _result.Comment = _comment.Text;

                _result.Save();
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

        private void Control_Changed(object sender, EventArgs e)
        {
            if (!_isLoading)
                _isDirty = true;
        }

        private void EditResultForm_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
