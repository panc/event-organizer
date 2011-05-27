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
    public partial class StarterForm : Form
    {
        private Starter _starter;
        private bool _isDirty;
        private bool _isLoading;

        public StarterForm(Starter starter)
        {
            InitializeComponent();

            _starter = starter;
            _isLoading = true;

            _firstName.Text = _starter.FirstName;
            _lastName.Text = _starter.LastName;
            _club.Text = _starter.Club;
            _comment.Text = _starter.Comment;

            _birthdate.Value = _starter.Birthdate ?? DateTime.Now.Date;

            _isLoading = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (_isDirty)
            {
                _starter.FirstName = _firstName.Text;
                _starter.LastName = _lastName.Text;
                _starter.Club = _club.Text;
                _starter.Comment = _comment.Text;
                _starter.Birthdate = _birthdate.Value;

                _starter.Save();
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
