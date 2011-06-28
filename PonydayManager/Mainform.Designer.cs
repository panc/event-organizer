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
            this._competitionTabOneComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verwaltungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._competitionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this._competitionTabTwoComboBox = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this._versionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._deleteStarterButton = new System.Windows.Forms.Button();
            this._editStarterButton = new System.Windows.Forms.Button();
            this._addStarterButton = new System.Windows.Forms.Button();
            this._resultDownButton = new System.Windows.Forms.Button();
            this._resultUpButton = new System.Windows.Forms.Button();
            this._starterListButton = new System.Windows.Forms.Button();
            this._editResultButton = new System.Windows.Forms.Button();
            this._printResultButton = new System.Windows.Forms.Button();
            this._starterDataGridView = new PonydayManager.Controls.DataGridViewExt();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._starterCompetitionDataGridView = new PonydayManager.Controls.DataGridViewExt();
            this._resultDataGridView = new PonydayManager.Controls.DataGridViewExt();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new PonydayManager.Controls.OutlookPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StarterClub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._starterDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._starterCompetitionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._resultDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _competitionTabOneComboBox
            // 
            this._competitionTabOneComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._competitionTabOneComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._competitionTabOneComboBox.FormattingEnabled = true;
            this._competitionTabOneComboBox.Location = new System.Drawing.Point(120, 17);
            this._competitionTabOneComboBox.Name = "_competitionTabOneComboBox";
            this._competitionTabOneComboBox.Size = new System.Drawing.Size(204, 28);
            this._competitionTabOneComboBox.TabIndex = 0;
            this._competitionTabOneComboBox.SelectedIndexChanged += new System.EventHandler(this.CompetitionTabOneComboBox_SelectedIndexChanged);
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
            this._competitionMenuItem});
            this.verwaltungToolStripMenuItem.Name = "verwaltungToolStripMenuItem";
            this.verwaltungToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.verwaltungToolStripMenuItem.Text = "Verwaltung";
            // 
            // _competitionMenuItem
            // 
            this._competitionMenuItem.Name = "_competitionMenuItem";
            this._competitionMenuItem.Size = new System.Drawing.Size(119, 22);
            this._competitionMenuItem.Text = "Bewerbe";
            this._competitionMenuItem.Click += new System.EventHandler(this.CompetitionMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._aboutMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // _aboutMenuItem
            // 
            this._aboutMenuItem.Name = "_aboutMenuItem";
            this._aboutMenuItem.Size = new System.Drawing.Size(108, 22);
            this._aboutMenuItem.Text = "Über...";
            this._aboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 129);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(846, 410);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this._deleteStarterButton);
            this.tabPage1.Controls.Add(this._editStarterButton);
            this.tabPage1.Controls.Add(this._addStarterButton);
            this.tabPage1.Controls.Add(this._starterDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(838, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Meldungen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this._resultDownButton);
            this.tabPage2.Controls.Add(this._resultUpButton);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this._competitionTabOneComboBox);
            this.tabPage2.Controls.Add(this._starterListButton);
            this.tabPage2.Controls.Add(this._starterCompetitionDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(838, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Startlisten";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bewerb:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this._editResultButton);
            this.tabPage3.Controls.Add(this._printResultButton);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this._competitionTabTwoComboBox);
            this.tabPage3.Controls.Add(this._resultDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(838, 377);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ergebnislisten";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Bewerb:";
            // 
            // _competitionTabTwoComboBox
            // 
            this._competitionTabTwoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._competitionTabTwoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._competitionTabTwoComboBox.FormattingEnabled = true;
            this._competitionTabTwoComboBox.Location = new System.Drawing.Point(76, 17);
            this._competitionTabTwoComboBox.Name = "_competitionTabTwoComboBox";
            this._competitionTabTwoComboBox.Size = new System.Drawing.Size(204, 28);
            this._competitionTabTwoComboBox.TabIndex = 47;
            this._competitionTabTwoComboBox.SelectedIndexChanged += new System.EventHandler(this.CompetitionTabTwoComboBox_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3,
            this._versionStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(870, 24);
            this.statusStrip1.TabIndex = 41;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(214, 19);
            this.toolStripStatusLabel1.Text = "  © Christoph Pangerl, Christian Prein";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(641, 19);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // _versionStatusLabel
            // 
            this._versionStatusLabel.Name = "_versionStatusLabel";
            this._versionStatusLabel.Size = new System.Drawing.Size(0, 19);
            // 
            // _deleteStarterButton
            // 
            this._deleteStarterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._deleteStarterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._deleteStarterButton.Image = global::PonydayManager.Properties.Resources.X_16x16;
            this._deleteStarterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._deleteStarterButton.Location = new System.Drawing.Point(354, 341);
            this._deleteStarterButton.Name = "_deleteStarterButton";
            this._deleteStarterButton.Size = new System.Drawing.Size(156, 30);
            this._deleteStarterButton.TabIndex = 3;
            this._deleteStarterButton.Text = "Meldung löschen";
            this._deleteStarterButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._deleteStarterButton.UseVisualStyleBackColor = true;
            this._deleteStarterButton.Click += new System.EventHandler(this.DeleteStarterButton_Click);
            // 
            // _editStarterButton
            // 
            this._editStarterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._editStarterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._editStarterButton.Image = global::PonydayManager.Properties.Resources.Edit_16x16;
            this._editStarterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._editStarterButton.Location = new System.Drawing.Point(173, 341);
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
            this._addStarterButton.Location = new System.Drawing.Point(6, 341);
            this._addStarterButton.Name = "_addStarterButton";
            this._addStarterButton.Size = new System.Drawing.Size(161, 30);
            this._addStarterButton.TabIndex = 0;
            this._addStarterButton.Text = "Meldung erfassen";
            this._addStarterButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._addStarterButton.UseVisualStyleBackColor = true;
            this._addStarterButton.Click += new System.EventHandler(this.AddStarterButton_Click);
            // 
            // _resultDownButton
            // 
            this._resultDownButton.Image = global::PonydayManager.Properties.Resources.Navigate_down;
            this._resultDownButton.Location = new System.Drawing.Point(6, 117);
            this._resultDownButton.Name = "_resultDownButton";
            this._resultDownButton.Size = new System.Drawing.Size(39, 33);
            this._resultDownButton.TabIndex = 48;
            this._resultDownButton.UseVisualStyleBackColor = true;
            this._resultDownButton.Click += new System.EventHandler(this.ResultDownButton_Click);
            // 
            // _resultUpButton
            // 
            this._resultUpButton.Image = global::PonydayManager.Properties.Resources.Navigate_up;
            this._resultUpButton.Location = new System.Drawing.Point(6, 78);
            this._resultUpButton.Name = "_resultUpButton";
            this._resultUpButton.Size = new System.Drawing.Size(39, 33);
            this._resultUpButton.TabIndex = 47;
            this._resultUpButton.UseVisualStyleBackColor = true;
            this._resultUpButton.Click += new System.EventHandler(this.ResultUpButton_Click);
            // 
            // _starterListButton
            // 
            this._starterListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._starterListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._starterListButton.Image = global::PonydayManager.Properties.Resources.Excel_16x16;
            this._starterListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._starterListButton.Location = new System.Drawing.Point(676, 341);
            this._starterListButton.Name = "_starterListButton";
            this._starterListButton.Size = new System.Drawing.Size(156, 30);
            this._starterListButton.TabIndex = 2;
            this._starterListButton.Text = "Startiste drucken";
            this._starterListButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._starterListButton.UseVisualStyleBackColor = true;
            this._starterListButton.Click += new System.EventHandler(this.StarterListButton_Click);
            // 
            // _editResultButton
            // 
            this._editResultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._editResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._editResultButton.Image = global::PonydayManager.Properties.Resources.Edit_16x16;
            this._editResultButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._editResultButton.Location = new System.Drawing.Point(6, 341);
            this._editResultButton.Name = "_editResultButton";
            this._editResultButton.Size = new System.Drawing.Size(174, 30);
            this._editResultButton.TabIndex = 52;
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
            this._printResultButton.Location = new System.Drawing.Point(637, 341);
            this._printResultButton.Name = "_printResultButton";
            this._printResultButton.Size = new System.Drawing.Size(195, 30);
            this._printResultButton.TabIndex = 51;
            this._printResultButton.Text = "Ergebnissliste drucken";
            this._printResultButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._printResultButton.UseVisualStyleBackColor = true;
            this._printResultButton.Click += new System.EventHandler(this.PrintResultButton_Click);
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
            this.Club,
            this.Comment});
            this._starterDataGridView.Location = new System.Drawing.Point(6, 6);
            this._starterDataGridView.MultiSelect = false;
            this._starterDataGridView.Name = "_starterDataGridView";
            this._starterDataGridView.ReadOnly = true;
            this._starterDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._starterDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._starterDataGridView.Size = new System.Drawing.Size(826, 329);
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
            // _starterCompetitionDataGridView
            // 
            this._starterCompetitionDataGridView.AllowUserToAddRows = false;
            this._starterCompetitionDataGridView.AllowUserToDeleteRows = false;
            this._starterCompetitionDataGridView.AllowUserToResizeRows = false;
            this._starterCompetitionDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._starterCompetitionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._starterCompetitionDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this._starterCompetitionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._starterCompetitionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._starterCompetitionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.StarterClub});
            this._starterCompetitionDataGridView.Location = new System.Drawing.Point(51, 51);
            this._starterCompetitionDataGridView.MultiSelect = false;
            this._starterCompetitionDataGridView.Name = "_starterCompetitionDataGridView";
            this._starterCompetitionDataGridView.ReadOnly = true;
            this._starterCompetitionDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._starterCompetitionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._starterCompetitionDataGridView.Size = new System.Drawing.Size(781, 284);
            this._starterCompetitionDataGridView.StandardTab = true;
            this._starterCompetitionDataGridView.TabIndex = 46;
            this._starterCompetitionDataGridView.CurrentCellChanged += new System.EventHandler(this.StarterCompetitionDataGridView_CurrentCellChanged);
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
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this._resultDataGridView.Location = new System.Drawing.Point(6, 51);
            this._resultDataGridView.MultiSelect = false;
            this._resultDataGridView.Name = "_resultDataGridView";
            this._resultDataGridView.ReadOnly = true;
            this._resultDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._resultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._resultDataGridView.Size = new System.Drawing.Size(826, 284);
            this._resultDataGridView.StandardTab = true;
            this._resultDataGridView.TabIndex = 50;
            this._resultDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResultDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nachname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Vorname";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Pony";
            this.dataGridViewTextBoxColumn6.HeaderText = "Pony";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Assessment";
            this.dataGridViewTextBoxColumn7.HeaderText = "Gesamtbewertung";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 82);
            this.panel1.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ponyday Manager";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PonydayManager.Properties.Resources.Logo_medium;
            this.pictureBox1.Location = new System.Drawing.Point(717, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            // StarterClub
            // 
            this.StarterClub.DataPropertyName = "Club";
            this.StarterClub.HeaderText = "Verein";
            this.StarterClub.Name = "StarterClub";
            this.StarterClub.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 564);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._starterDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._starterCompetitionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._resultDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button _starterListButton;
        private System.Windows.Forms.ComboBox _competitionTabOneComboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _closeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _aboutMenuItem;
        private PonydayManager.Controls.DataGridViewExt _starterDataGridView;
        private System.Windows.Forms.ToolStripMenuItem verwaltungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _competitionMenuItem;
        private System.Windows.Forms.Button _addStarterButton;
        private System.Windows.Forms.Button _editStarterButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private PonydayManager.Controls.DataGridViewExt _starterCompetitionDataGridView;
        private System.Windows.Forms.Label label2;
        private PonydayManager.Controls.OutlookPanel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Club;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.Button _resultDownButton;
        private System.Windows.Forms.Button _resultUpButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel _versionStatusLabel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _competitionTabTwoComboBox;
        private Controls.DataGridViewExt _resultDataGridView;
        private System.Windows.Forms.Button _printResultButton;
        private System.Windows.Forms.Button _editResultButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button _deleteStarterButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn StarterClub;
    }
}

