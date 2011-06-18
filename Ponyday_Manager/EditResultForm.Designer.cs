namespace PonydayManager
{
    partial class EditResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditResultForm));
            this._starterInfo = new System.Windows.Forms.TextBox();
            this._ponyInfo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._assessmentOne = new System.Windows.Forms.TextBox();
            this._assessmentTwo = new System.Windows.Forms.TextBox();
            this._comment = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this._titleLable = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._saveButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._assessmentFour = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._assessmentThree = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this._assessmentSum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this._assessmentFive = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _starterInfo
            // 
            this._starterInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._starterInfo.Location = new System.Drawing.Point(113, 73);
            this._starterInfo.Name = "_starterInfo";
            this._starterInfo.ReadOnly = true;
            this._starterInfo.Size = new System.Drawing.Size(324, 26);
            this._starterInfo.TabIndex = 0;
            this._starterInfo.TextChanged += new System.EventHandler(this.Control_Changed);
            // 
            // _ponyInfo
            // 
            this._ponyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ponyInfo.Location = new System.Drawing.Point(113, 105);
            this._ponyInfo.Name = "_ponyInfo";
            this._ponyInfo.ReadOnly = true;
            this._ponyInfo.Size = new System.Drawing.Size(324, 26);
            this._ponyInfo.TabIndex = 3;
            this._ponyInfo.TextChanged += new System.EventHandler(this.Control_Changed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Pony:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Teilnehmer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Bewertungsgrundlage 1:";
            // 
            // _assessmentOne
            // 
            this._assessmentOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._assessmentOne.Location = new System.Drawing.Point(281, 163);
            this._assessmentOne.Name = "_assessmentOne";
            this._assessmentOne.Size = new System.Drawing.Size(156, 26);
            this._assessmentOne.TabIndex = 4;
            this._assessmentOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._assessmentOne.TextChanged += new System.EventHandler(this.Control_Changed);
            this._assessmentOne.Leave += new System.EventHandler(this.AssessmentTextBox_Leave);
            // 
            // _assessmentTwo
            // 
            this._assessmentTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._assessmentTwo.Location = new System.Drawing.Point(281, 195);
            this._assessmentTwo.Name = "_assessmentTwo";
            this._assessmentTwo.Size = new System.Drawing.Size(156, 26);
            this._assessmentTwo.TabIndex = 5;
            this._assessmentTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._assessmentTwo.TextChanged += new System.EventHandler(this.Control_Changed);
            this._assessmentTwo.Leave += new System.EventHandler(this.AssessmentTextBox_Leave);
            // 
            // _comment
            // 
            this._comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._comment.Location = new System.Drawing.Point(20, 420);
            this._comment.Multiline = true;
            this._comment.Name = "_comment";
            this._comment.Size = new System.Drawing.Size(417, 111);
            this._comment.TabIndex = 10;
            this._comment.TextChanged += new System.EventHandler(this.Control_Changed);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(372, 6);
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
            this.panel1.Size = new System.Drawing.Size(440, 1);
            this.panel1.TabIndex = 39;
            // 
            // _titleLable
            // 
            this._titleLable.AutoSize = true;
            this._titleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._titleLable.Location = new System.Drawing.Point(8, 16);
            this._titleLable.Name = "_titleLable";
            this._titleLable.Size = new System.Drawing.Size(207, 20);
            this._titleLable.TabIndex = 40;
            this._titleLable.Text = "Wertung bearbeiten ({0})";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = "Notizen:";
            // 
            // _saveButton
            // 
            this._saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._saveButton.Location = new System.Drawing.Point(229, 550);
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
            this._cancelButton.Location = new System.Drawing.Point(336, 550);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(101, 30);
            this._cancelButton.TabIndex = 12;
            this._cancelButton.Text = "Abbrechen";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Bewertungsgrundlage 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Bewertungsgrundlage 4:";
            // 
            // _assessmentFour
            // 
            this._assessmentFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._assessmentFour.Location = new System.Drawing.Point(281, 259);
            this._assessmentFour.Name = "_assessmentFour";
            this._assessmentFour.Size = new System.Drawing.Size(156, 26);
            this._assessmentFour.TabIndex = 44;
            this._assessmentFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._assessmentFour.TextChanged += new System.EventHandler(this.Control_Changed);
            this._assessmentFour.Leave += new System.EventHandler(this.AssessmentTextBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Bewertungsgrundlage 3:";
            // 
            // _assessmentThree
            // 
            this._assessmentThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._assessmentThree.Location = new System.Drawing.Point(281, 227);
            this._assessmentThree.Name = "_assessmentThree";
            this._assessmentThree.Size = new System.Drawing.Size(156, 26);
            this._assessmentThree.TabIndex = 43;
            this._assessmentThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._assessmentThree.TextChanged += new System.EventHandler(this.Control_Changed);
            this._assessmentThree.Leave += new System.EventHandler(this.AssessmentTextBox_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Bewertung gesamt:";
            // 
            // _assessmentSum
            // 
            this._assessmentSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._assessmentSum.Location = new System.Drawing.Point(281, 335);
            this._assessmentSum.Name = "_assessmentSum";
            this._assessmentSum.Size = new System.Drawing.Size(156, 26);
            this._assessmentSum.TabIndex = 48;
            this._assessmentSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._assessmentSum.TextChanged += new System.EventHandler(this.Control_Changed);
            this._assessmentSum.Leave += new System.EventHandler(this.AssessmentTextBox_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Bewertungsgrundlage 5:";
            // 
            // _assessmentFive
            // 
            this._assessmentFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._assessmentFive.Location = new System.Drawing.Point(281, 291);
            this._assessmentFive.Name = "_assessmentFive";
            this._assessmentFive.Size = new System.Drawing.Size(156, 26);
            this._assessmentFive.TabIndex = 47;
            this._assessmentFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._assessmentFive.TextChanged += new System.EventHandler(this.Control_Changed);
            this._assessmentFive.Leave += new System.EventHandler(this.AssessmentTextBox_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Location = new System.Drawing.Point(20, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 1);
            this.panel2.TabIndex = 51;
            // 
            // EditResultForm
            // 
            this.AcceptButton = this._saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(457, 592);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._assessmentSum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._assessmentFive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._assessmentFour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._assessmentThree);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._saveButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this._titleLable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._comment);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._assessmentTwo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._assessmentOne);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._ponyInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._starterInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditResultForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wertung bearbeiten";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StarterForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _starterInfo;
        private System.Windows.Forms.TextBox _ponyInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _assessmentOne;
        private System.Windows.Forms.TextBox _assessmentTwo;
        private System.Windows.Forms.TextBox _comment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label _titleLable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _assessmentFour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _assessmentThree;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _assessmentSum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _assessmentFive;
        private System.Windows.Forms.Panel panel2;
    }
}