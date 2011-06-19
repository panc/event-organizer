namespace PonydayManager
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this._competitionComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verwaltungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bewerbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._resultDownButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this._editStarterButton = new System.Windows.Forms.Button();
            this._addStarterButton = new System.Windows.Forms.Button();
            this._resultUpButton = new System.Windows.Forms.Button();
            this._editResultButton = new System.Windows.Forms.Button();
            this._printResultButton = new System.Windows.Forms.Button();
            this._starterListButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._starterDataGridView = new PonydayManager.Controls.DataGridViewExt();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._resultDataGridView = new PonydayManager.Controls.DataGridViewExt();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assessment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._starterDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._resultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _competitionComboBox
            // 
            this._competitionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._competitionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._competitionComboBox.FormattingEnabled = true;
            this._competitionComboBox.Items.AddRange(new object[] {
            "Bewerb 1",
            "Bewerb 2",
            "Bewerb 3",
            "Bewerb 4",
            "Bewerb 5",
            "Bewerb 6"});
            this._competitionComboBox.Location = new System.Drawing.Point(79, 25);
            this._competitionComboBox.Name = "_competitionComboBox";
            this._competitionComboBox.Size = new System.Drawing.Size(204, 28);
            this._competitionComboBox.TabIndex = 0;
            this._competitionComboBox.SelectedIndexChanged += new System.EventHandler(this.CompetitionComboBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.verwaltungToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(870, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._closeMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // _closeMenuItem
            // 
            this._closeMenuItem.Name = "_closeMenuItem";
            this._closeMenuItem.Size = new System.Drawing.Size(120, 22);
            this._closeMenuItem.Text = "Beenden";
            this._closeMenuItem.Click += new System.EventHandler(this.CloseMenuItem_Click);
            // 
            // verwaltungToolStripMenuItem
            // 
            this.verwaltungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bewerbeToolStripMenuItem});
            this.verwaltungToolStripMenuItem.Name = "verwaltungToolStripMenuItem";
            this.verwaltungToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.verwaltungToolStripMenuItem.Text = "Verwaltung";
            // 
            // bewerbeToolStripMenuItem
            // 
            this.bewerbeToolStripMenuItem.Name = "bewerbeToolStripMenuItem";
            this.bewerbeToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.bewerbeToolStripMenuItem.Text = "Bewerbe";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.überToolStripMenuItem.Text = "Über...";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(18, 137);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(840, 415);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this._editStarterButton);
            this.tabPage1.Controls.Add(this._addStarterButton);
            this.tabPage1.Controls.Add(this._starterDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(832, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Meldungen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this._resultDownButton);
            this.tabPage2.Controls.Add(this._resultUpButton);
            this.tabPage2.Controls.Add(this._resultDataGridView);
            this.tabPage2.Controls.Add(this._editResultButton);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this._competitionComboBox);
            this.tabPage2.Controls.Add(this._printResultButton);
            this.tabPage2.Controls.Add(this._starterListButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(832, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Starter- und Ergebnislisten";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _resultDownButton
            // 
            this._resultDownButton.Image = global::PonydayManager.Properties.Resources.navigate_down_icon;
            this._resultDownButton.Location = new System.Drawing.Point(20, 104);
            this._resultDownButton.Name = "_resultDownButton";
            this._resultDownButton.Size = new System.Drawing.Size(39, 33);
            this._resultDownButton.TabIndex = 48;
            this._resultDownButton.UseVisualStyleBackColor = true;
            this._resultDownButton.Click += new System.EventHandler(this.ResultDownButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bewerb:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ponyday Manager";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 82);
            this.panel1.TabIndex = 40;
            // 
            // _editStarterButton
            // 
            this._editStarterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._editStarterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._editStarterButton.Image = ((System.Drawing.Image)(resources.GetObject("_editStarterButton.Image")));
            this._editStarterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._editStarterButton.Location = new System.Drawing.Point(173, 346);
            this._editStarterButton.Name = "_editStarterButton";
            this._editStarterButton.Size = new System.Drawing.Size(175, 30);
            this._editStarterButton.TabIndex = 1;
            this._editStarterButton.Text = "Meldung bearbeiten";
            this._editStarterButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._editStarterButton.UseVisualStyleBackColor = true;
            this._editStarterButton.Click += new System.EventHandler(this.EditStarterButton_Click);
            // 
            // _addStarterButton
            // 
            this._addStarterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._addStarterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._addStarterButton.Image = global::PonydayManager.Properties.Resources.New_16x16;
            this._addStarterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._addStarterButton.Location = new System.Drawing.Point(6, 346);
            this._addStarterButton.Name = "_addStarterButton";
            this._addStarterButton.Size = new System.Drawing.Size(161, 30);
            this._addStarterButton.TabIndex = 0;
            this._addStarterButton.Text = "Meldung erfassen";
            this._addStarterButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._addStarterButton.UseVisualStyleBackColor = true;
            this._addStarterButton.Click += new System.EventHandler(this.AddStarterButton_Click);
            // 
            // _resultUpButton
            // 
            this._resultUpButton.Image = global::PonydayManager.Properties.Resources.navigate_up_icon;
            this._resultUpButton.Location = new System.Drawing.Point(20, 65);
            this._resultUpButton.Name = "_resultUpButton";
            this._resultUpButton.Size = new System.Drawing.Size(39, 33);
            this._resultUpButton.TabIndex = 47;
            this._resultUpButton.UseVisualStyleBackColor = true;
            this._resultUpButton.Click += new System.EventHandler(this.ResultUpButton_Click);
            // 
            // _editResultButton
            // 
            this._editResultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._editResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._editResultButton.Image = ((System.Drawing.Image)(resources.GetObject("_editResultButton.Image")));
            this._editResultButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._editResultButton.Location = new System.Drawing.Point(6, 346);
            this._editResultButton.Name = "_editResultButton";
            this._editResultButton.Size = new System.Drawing.Size(174, 30);
            this._editResultButton.TabIndex = 1;
            this._editResultButton.Text = "Wertung bearbeiten";
            this._editResultButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._editResultButton.UseVisualStyleBackColor = true;
            this._editResultButton.Click += new System.EventHandler(this.EditResultButton_Click);
            // 
            // _printResultButton
            // 
            this._printResultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._printResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._printResultButton.Image = global::PonydayManager.Properties.Resources.Excel_16x16;
            this._printResultButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._printResultButton.Location = new System.Drawing.Point(631, 346);
            this._printResultButton.Name = "_printResultButton";
            this._printResultButton.Size = new System.Drawing.Size(195, 30);
            this._printResultButton.TabIndex = 3;
            this._printResultButton.Text = "Ergebnissliste drucken";
            this._printResultButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._printResultButton.UseVisualStyleBackColor = true;
            this._printResultButton.Click += new System.EventHandler(this.PrintResultButton_Click);
            // 
            // _starterListButton
            // 
            this._starterListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._starterListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._starterListButton.Image = global::PonydayManager.Properties.Resources.Excel_16x16;
            this._starterListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._starterListButton.Location = new System.Drawing.Point(469, 346);
            this._starterListButton.Name = "_starterListButton";
            this._starterListButton.Size = new System.Drawing.Size(156, 30);
            this._starterListButton.TabIndex = 2;
            this._starterListButton.Text = "Startiste drucken";
            this._starterListButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._starterListButton.UseVisualStyleBackColor = true;
            this._starterListButton.Click += new System.EventHandler(this.StarterListButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(705, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // _starterDataGridView
            // 
            this._starterDataGridView.AllowUserToAddRows = false;
            this._starterDataGridView.AllowUserToDeleteRows = false;
            this._starterDataGridView.AllowUserToResizeRows = false;
            this._starterDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._starterDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._starterDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this._starterDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._starterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._starterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.FirstName,
            this.Birthdate,
            this.Club,
            this.Comment});
            this._starterDataGridView.Location = new System.Drawing.Point(6, 6);
            this._starterDataGridView.MultiSelect = false;
            this._starterDataGridView.Name = "_starterDataGridView";
            this._starterDataGridView.ReadOnly = true;
            this._starterDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._starterDataGridView.Size = new System.Drawing.Size(820, 334);
            this._starterDataGridView.TabIndex = 2;
            this._starterDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StarterDataGridView_CellDoubleClick);
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Nachname";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Vorname";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // Birthdate
            // 
            this.Birthdate.DataPropertyName = "Birthdate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Birthdate.DefaultCellStyle = dataGridViewCellStyle1;
            this.Birthdate.HeaderText = "Geburtsdatum";
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.ReadOnly = true;
            // 
            // Club
            // 
            this.Club.DataPropertyName = "Club";
            this.Club.HeaderText = "Verein";
            this.Club.Name = "Club";
            this.Club.ReadOnly = true;
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Kommentar";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            // 
            // _resultDataGridView
            // 
            this._resultDataGridView.AllowUserToAddRows = false;
            this._resultDataGridView.AllowUserToDeleteRows = false;
            this._resultDataGridView.AllowUserToResizeRows = false;
            this._resultDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._resultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._resultDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this._resultDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._resultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.Assessment});
            this._resultDataGridView.Location = new System.Drawing.Point(79, 65);
            this._resultDataGridView.MultiSelect = false;
            this._resultDataGridView.Name = "_resultDataGridView";
            this._resultDataGridView.ReadOnly = true;
            this._resultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._resultDataGridView.Size = new System.Drawing.Size(747, 275);
            this._resultDataGridView.StandardTab = true;
            this._resultDataGridView.TabIndex = 46;
            this._resultDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResultDataGridView_CellDoubleClick);
            this._resultDataGridView.CurrentCellChanged += new System.EventHandler(this.ResultDataGridView_CurrentCellChanged);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nachname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Vorname";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Pony";
            this.dataGridViewTextBoxColumn5.HeaderText = "Pony";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Assessment
            // 
            this.Assessment.DataPropertyName = "AssessmentSum";
            this.Assessment.HeaderText = "Gesamtbewertung";
            this.Assessment.Name = "Assessment";
            this.Assessment.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 564);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Ponyday Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._starterDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._resultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button _printResultButton;
        private System.Windows.Forms.Button _starterListButton;
        private System.Windows.Forms.ComboBox _competitionComboBox;
        private System.Windows.Forms.Button _editResultButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _closeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private PonydayManager.Controls.DataGridViewExt _starterDataGridView;
        private System.Windows.Forms.ToolStripMenuItem verwaltungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bewerbeToolStripMenuItem;
        private System.Windows.Forms.Button _addStarterButton;
        private System.Windows.Forms.Button _editStarterButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private PonydayManager.Controls.DataGridViewExt _resultDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Club;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assessment;
        private System.Windows.Forms.Button _resultDownButton;
        private System.Windows.Forms.Button _resultUpButton;
    }
}

