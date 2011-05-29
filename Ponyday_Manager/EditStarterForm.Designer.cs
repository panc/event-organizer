namespace PonydayManager
{
    partial class EditStarterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStarterForm));
            this._firstName = new System.Windows.Forms.TextBox();
            this._lastName = new System.Windows.Forms.TextBox();
            this._club = new System.Windows.Forms.TextBox();
            this._ponyOne = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._ponyTwo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this._ponyThree = new System.Windows.Forms.TextBox();
            this._comment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this._paied = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._birthdate = new System.Windows.Forms.DateTimePicker();
            this._saveButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this._costs = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this._competitions = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _firstName
            // 
            this._firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._firstName.Location = new System.Drawing.Point(113, 73);
            this._firstName.Name = "_firstName";
            this._firstName.Size = new System.Drawing.Size(215, 26);
            this._firstName.TabIndex = 0;
            this._firstName.TextChanged += new System.EventHandler(this.Control_Changed);
            // 
            // _lastName
            // 
            this._lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lastName.Location = new System.Drawing.Point(113, 105);
            this._lastName.Name = "_lastName";
            this._lastName.Size = new System.Drawing.Size(215, 26);
            this._lastName.TabIndex = 1;
            this._lastName.TextChanged += new System.EventHandler(this.Control_Changed);
            // 
            // _club
            // 
            this._club.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._club.Location = new System.Drawing.Point(113, 137);
            this._club.Name = "_club";
            this._club.Size = new System.Drawing.Size(214, 26);
            this._club.TabIndex = 2;
            this._club.TextChanged += new System.EventHandler(this.Control_Changed);
            // 
            // _ponyOne
            // 
            this._ponyOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ponyOne.Location = new System.Drawing.Point(113, 186);
            this._ponyOne.Name = "_ponyOne";
            this._ponyOne.Size = new System.Drawing.Size(214, 26);
            this._ponyOne.TabIndex = 3;
            this._ponyOne.TextChanged += new System.EventHandler(this.Control_Changed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Pony 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Verein/Ort:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Geburtsdatum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nachname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vorname:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Pony 2:";
            // 
            // _ponyTwo
            // 
            this._ponyTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ponyTwo.Location = new System.Drawing.Point(114, 218);
            this._ponyTwo.Name = "_ponyTwo";
            this._ponyTwo.Size = new System.Drawing.Size(214, 26);
            this._ponyTwo.TabIndex = 4;
            this._ponyTwo.TextChanged += new System.EventHandler(this.Control_Changed);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Pony 3:";
            // 
            // _ponyThree
            // 
            this._ponyThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ponyThree.Location = new System.Drawing.Point(114, 250);
            this._ponyThree.Name = "_ponyThree";
            this._ponyThree.Size = new System.Drawing.Size(214, 26);
            this._ponyThree.TabIndex = 5;
            this._ponyThree.TextChanged += new System.EventHandler(this.Control_Changed);
            // 
            // _comment
            // 
            this._comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._comment.Location = new System.Drawing.Point(20, 393);
            this._comment.Multiline = true;
            this._comment.Name = "_comment";
            this._comment.Size = new System.Drawing.Size(622, 111);
            this._comment.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Zu bezahlen:";
            // 
            // _paied
            // 
            this._paied.AutoSize = true;
            this._paied.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._paied.Location = new System.Drawing.Point(246, 300);
            this._paied.Name = "_paied";
            this._paied.Size = new System.Drawing.Size(82, 24);
            this._paied.TabIndex = 7;
            this._paied.Text = "Bezahlt";
            this._paied.UseVisualStyleBackColor = true;
            this._paied.CheckedChanged += new System.EventHandler(this.Paied_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(571, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 40);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(5, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 1);
            this.panel1.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Meldung erfassen / bearbeiten";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = "Notizen:";
            // 
            // _birthdate
            // 
            this._birthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._birthdate.Location = new System.Drawing.Point(497, 73);
            this._birthdate.Name = "_birthdate";
            this._birthdate.Size = new System.Drawing.Size(145, 26);
            this._birthdate.TabIndex = 8;
            this._birthdate.ValueChanged += new System.EventHandler(this.Control_Changed);
            // 
            // _saveButton
            // 
            this._saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._saveButton.Location = new System.Drawing.Point(436, 523);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(101, 30);
            this._saveButton.TabIndex = 11;
            this._saveButton.Text = "Speichern";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cancelButton.Location = new System.Drawing.Point(543, 523);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(101, 30);
            this._cancelButton.TabIndex = 12;
            this._cancelButton.Text = "Abbrechen";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(218, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 20);
            this.label11.TabIndex = 45;
            this.label11.Text = "€";
            // 
            // _costs
            // 
            this._costs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._costs.Location = new System.Drawing.Point(123, 299);
            this._costs.Name = "_costs";
            this._costs.Size = new System.Drawing.Size(95, 26);
            this._costs.TabIndex = 6;
            this._costs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._costs.TextChanged += new System.EventHandler(this.Control_Changed);
            this._costs.Leave += new System.EventHandler(this.Costs_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(375, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 20);
            this.label12.TabIndex = 47;
            this.label12.Text = "Bewerbe:";
            // 
            // _competitions
            // 
            this._competitions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._competitions.FormattingEnabled = true;
            this._competitions.Location = new System.Drawing.Point(379, 130);
            this._competitions.Name = "_competitions";
            this._competitions.Size = new System.Drawing.Size(263, 193);
            this._competitions.TabIndex = 9;
            this._competitions.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Competitions_ItemCheck);
            // 
            // EditStarterForm
            // 
            this.AcceptButton = this._saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(656, 565);
            this.Controls.Add(this._competitions);
            this.Controls.Add(this.label12);
            this.Controls.Add(this._costs);
            this.Controls.Add(this.label11);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._saveButton);
            this.Controls.Add(this._birthdate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._paied);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._comment);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._ponyThree);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._ponyTwo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._ponyOne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._club);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._lastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._firstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditStarterForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Meldesystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StarterForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _firstName;
        private System.Windows.Forms.TextBox _lastName;
        private System.Windows.Forms.TextBox _club;
        private System.Windows.Forms.TextBox _ponyOne;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _ponyTwo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _ponyThree;
        private System.Windows.Forms.TextBox _comment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox _paied;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker _birthdate;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox _costs;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckedListBox _competitions;
    }
}