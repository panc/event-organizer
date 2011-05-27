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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            _starterDataGridView.AutoGenerateColumns = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _starterDataGridView.DataSource = Starter.Select("");      
        }

        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StarterDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_starterDataGridView.CurrentRow != null && _starterDataGridView.CurrentRow.DataBoundItem is Starter)
            {
                using (StarterForm starter = new StarterForm((Starter)_starterDataGridView.CurrentRow.DataBoundItem))
                {
                    if (starter.ShowDialog() == DialogResult.OK)
                        _starterDataGridView.DataSource = Starter.Select("");
                }
            }
        }

        private void AddStarterButton_Click(object sender, EventArgs e)
        {
            using (StarterForm starter = new StarterForm(new Starter()))
            {
                if (starter.ShowDialog() == DialogResult.OK)
                    _starterDataGridView.DataSource = Starter.Select("");
            }
        }
    }
}
