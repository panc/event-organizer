namespace PonydayManager
{
    partial class CompetitionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompetitionForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this._titleLable = new System.Windows.Forms.Label();
            this._saveButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this._competitionDataGridView = new PonydayManager.Controls.DataGridViewExt();
            this.CompetitionCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._competitionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(5, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 1);
            this.panel1.TabIndex = 39;
            // 
            // _titleLable
            // 
            this._titleLable.AutoSize = true;
            this._titleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._titleLable.Location = new System.Drawing.Point(8, 16);
            this._titleLable.Name = "_titleLable";
            this._titleLable.Size = new System.Drawing.Size(160, 20);
            this._titleLable.TabIndex = 40;
            this._titleLable.Text = "Bewerbe verwalten";
            // 
            // _saveButton
            // 
            this._saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._saveButton.Location = new System.Drawing.Point(312, 483);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(101, 30);
            this._saveButton.TabIndex = 7;
            this._saveButton.Text = "Speichern";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cancelButton.Location = new System.Drawing.Point(419, 483);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(101, 30);
            this._cancelButton.TabIndex = 8;
            this._cancelButton.Text = "Abbrechen";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PonydayManager.Properties.Resources.Logo_small;
            this.pictureBox1.Location = new System.Drawing.Point(454, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this._competitionDataGridView);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 406);
            this.panel2.TabIndex = 42;
            // 
            // _competitionDataGridView
            // 
            this._competitionDataGridView.AllowUserToResizeRows = false;
            this._competitionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._competitionDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this._competitionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._competitionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._competitionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompetitionCaption});
            this._competitionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._competitionDataGridView.Location = new System.Drawing.Point(0, 0);
            this._competitionDataGridView.MultiSelect = false;
            this._competitionDataGridView.Name = "_competitionDataGridView";
            this._competitionDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._competitionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._competitionDataGridView.Size = new System.Drawing.Size(508, 406);
            this._competitionDataGridView.StandardTab = true;
            this._competitionDataGridView.TabIndex = 41;
            this._competitionDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CompetitionDataGridView_CellValueChanged);
            this._competitionDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.CompetitionDataGridView_RowsAdded);
            this._competitionDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.CompetitionDataGridView_RowsRemoved);
            this._competitionDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.CompetitionDataGridView_UserDeletingRow);
            // 
            // CompetitionCaption
            // 
            this.CompetitionCaption.DataPropertyName = "Caption";
            this.CompetitionCaption.HeaderText = "Bewerb";
            this.CompetitionCaption.Name = "CompetitionCaption";
            // 
            // CompetitionForm
            // 
            this.AcceptButton = this._saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(536, 523);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._saveButton);
            this.Controls.Add(this._titleLable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompetitionForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bewerbsverwaltung";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._competitionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label _titleLable;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.Button _cancelButton;
        private Controls.DataGridViewExt _competitionDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompetitionCaption;
    }
}