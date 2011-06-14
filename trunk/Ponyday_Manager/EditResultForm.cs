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
        private StarterResult _starter;
        private bool _isDirty;
        private bool _isLoading;

        public EditResultForm()
        {
            InitializeComponent();
        }

        public EditResultForm(StarterResult starter)
            : this()
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
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

                // update the values from the textboxes
                _starter.FirstName = _firstName.Text;
                _starter.LastName = _lastName.Text;
                _starter.Pony = _ponyOne.Text;
                _starter.Birthdate = _birthdate.Value;

                //_starter.Save();
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
