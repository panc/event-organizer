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
    public partial class EditResultForm : Form
    {
        private Result _result;
        private bool _isDirty;
        private bool _isLoading;

        public EditResultForm()
        {
            InitializeComponent();
        }

        public EditResultForm(Result result)
            : this()
        {
            _isLoading = true;
            _result = result;

            _starterInfo.Text = string.Format("{0} {1}", result.FirstName, result.LastName);
            _ponyInfo.Text = result.Pony;

            _assessmentOne.Text = result.AssessmentOne;
            _assessmentTwo.Text = result.AssessmentTwo;
            _assessmentThree.Text = result.AssessmentThree;
            _assessmentFour.Text = result.AssessmentFour;
            _assessmentFive.Text = result.AssessmentFive;
            _assessmentSum.Text = result.AssessmentSum;

            _comment.Text = result.Comment;
            _isLoading = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (_isDirty)
            {
                // update the values from the textboxes
                _result.AssessmentOne = _assessmentOne.Text;
                _result.AssessmentTwo = _assessmentTwo.Text;
                _result.AssessmentThree = _assessmentThree.Text ;
                _result.AssessmentFour = _assessmentFour.Text;
                _result.AssessmentFive = _assessmentFive.Text;
                _result.AssessmentSum = _assessmentSum.Text;

                _result.Comment = _comment.Text;

                //_result.Save();
                _isDirty = false;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
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
                if (MessageBox.Show(this,
                                   "Wollen Sie die geänderten Daten verwerfen?",
                                   "Speichern",
                                   MessageBoxButtons.YesNoCancel,
                                   MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
