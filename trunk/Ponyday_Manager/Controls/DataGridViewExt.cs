using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PonydayManager.Controls
{
    public class DataGridViewExt : DataGridView
    {
        List<int> _selectedRows;

        public void StoreRowSelection()
        {
            _selectedRows = new List<int>();
            foreach (DataGridViewRow row in this.SelectedRows)
            {
                _selectedRows.Add(row.Index);
            }
        }

        public void RestoreRowSelection()
        {
            if (_selectedRows != null)
            {
                foreach (DataGridViewRow row in this.SelectedRows)
                {
                    row.Selected = false;
                }

                foreach (var index in _selectedRows)
                {
                    if (index > -1 && index < this.RowCount)
                        this.Rows[index].Selected = true;
                }

                if (_selectedRows.Count > 0)
                    SetCurrentRow(_selectedRows[0]);
            }
        }

        public void SetCurrentRow(int rowIndex)
        {
            this.Rows[rowIndex].Selected = false;
            this.Rows[rowIndex].Selected = true;
            this.CurrentCell = this[0, rowIndex];
        }
    }
}
