using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PonydayManager
{
    public partial class Results_One : Form
    {
        public Results_One()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            MessageBox.Show("Daten wurden erfolgreich gespeichert!");
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void notes_TextChanged(object sender, EventArgs e)
        {

        }

        private void Starter_One_Load(object sender, EventArgs e)
        {

        }
    }
}
