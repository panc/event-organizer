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

        private Result _result;
        private bool _isDirty;
        private bool _isLoading;

        public EditResultForm()
        {
            InitializeComponent();
        }

        public EditResultForm(Result result, string competitionCaption)
            : this()
        {
            _isLoading = true;
            _result = result;

            _titleLable.Text = string.Format(_titleLable.Text, competitionCaption);
            _starterInfo.Text = string.Format("{0} {1}", result.FirstName, result.LastName);
            _ponyInfo.Text = result.Pony;

            _assessmentOne.Text = result.AssessmentOne.ToString();
            _assessmentTwo.Text = result.AssessmentTwo.ToString();
            _assessmentThree.Text = result.AssessmentThree.ToString();
            _assessmentFour.Text = result.AssessmentFour.ToString();
            _assessmentFive.Text = result.AssessmentFive.ToString();
            _assessmentSum.Text = result.AssessmentSum.ToString();

            _comment.Text = result.Comment;
            _isLoading = false;
        }

        private void Save()
        {
            if (_isDirty)
            {
                // update the values from the textboxes
                _result.AssessmentOne = _assessmentOne.GetTextAsInt32();
                _result.AssessmentTwo = _assessmentTwo.GetTextAsInt32();
                _result.AssessmentThree = _assessmentThree.GetTextAsInt32();
                _result.AssessmentFour = _assessmentFour.GetTextAsInt32();
                _result.AssessmentFive = _assessmentFive.GetTextAsInt32();
                _result.AssessmentSum = _assessmentSum.GetTextAsInt32();

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

        private void StarterForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void AssessmentTextBox_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
                tb.Text = tb.GetTextAsInt32().ToString();

            if (tb != _assessmentSum)
            {
                
            }
        }
    }
}
