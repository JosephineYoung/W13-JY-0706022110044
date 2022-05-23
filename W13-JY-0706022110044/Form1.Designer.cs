namespace W13_JY_0706022110044
{
    partial class Player
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
            this.cBoxTeam = new System.Windows.Forms.ComboBox();
            this.cbBoxNationality = new System.Windows.Forms.ComboBox();
            this.numUpDownTeamNumber = new System.Windows.Forms.NumericUpDown();
            this.dtPickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtBoxPlayerName = new System.Windows.Forms.TextBox();
            this.txtBoxPlayerID = new System.Windows.Forms.TextBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblTeamNumber = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblPlayerID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTeamNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxTeam
            // 
            this.cBoxTeam.FormattingEnabled = true;
            this.cBoxTeam.Location = new System.Drawing.Point(161, 281);
            this.cBoxTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxTeam.Name = "cBoxTeam";
            this.cBoxTeam.Size = new System.Drawing.Size(320, 24);
            this.cBoxTeam.TabIndex = 39;
            // 
            // cbBoxNationality
            // 
            this.cbBoxNationality.FormattingEnabled = true;
            this.cbBoxNationality.Location = new System.Drawing.Point(161, 247);
            this.cbBoxNationality.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBoxNationality.Name = "cbBoxNationality";
            this.cbBoxNationality.Size = new System.Drawing.Size(320, 24);
            this.cbBoxNationality.TabIndex = 38;
            // 
            // numUpDownTeamNumber
            // 
            this.numUpDownTeamNumber.Location = new System.Drawing.Point(161, 315);
            this.numUpDownTeamNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numUpDownTeamNumber.Name = "numUpDownTeamNumber";
            this.numUpDownTeamNumber.Size = new System.Drawing.Size(135, 22);
            this.numUpDownTeamNumber.TabIndex = 37;
            // 
            // dtPickerBirthDate
            // 
            this.dtPickerBirthDate.CustomFormat = "dddd, MMMM dd,  yyyy";
            this.dtPickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerBirthDate.Location = new System.Drawing.Point(161, 208);
            this.dtPickerBirthDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtPickerBirthDate.Name = "dtPickerBirthDate";
            this.dtPickerBirthDate.Size = new System.Drawing.Size(320, 22);
            this.dtPickerBirthDate.TabIndex = 36;
            // 
            // txtBoxPlayerName
            // 
            this.txtBoxPlayerName.Location = new System.Drawing.Point(161, 168);
            this.txtBoxPlayerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxPlayerName.Name = "txtBoxPlayerName";
            this.txtBoxPlayerName.Size = new System.Drawing.Size(320, 22);
            this.txtBoxPlayerName.TabIndex = 35;
            // 
            // txtBoxPlayerID
            // 
            this.txtBoxPlayerID.Location = new System.Drawing.Point(161, 127);
            this.txtBoxPlayerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxPlayerID.Name = "txtBoxPlayerID";
            this.txtBoxPlayerID.Size = new System.Drawing.Size(200, 22);
            this.txtBoxPlayerID.TabIndex = 34;
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(335, 319);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(16, 16);
            this.lblAvailable.TabIndex = 33;
            this.lblAvailable.Text = "...";
            // 
            // lblTeamNumber
            // 
            this.lblTeamNumber.AutoSize = true;
            this.lblTeamNumber.Location = new System.Drawing.Point(42, 319);
            this.lblTeamNumber.Name = "lblTeamNumber";
            this.lblTeamNumber.Size = new System.Drawing.Size(94, 16);
            this.lblTeamNumber.TabIndex = 32;
            this.lblTeamNumber.Text = "Team Number";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(43, 283);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(43, 16);
            this.lblTeam.TabIndex = 31;
            this.lblTeam.Text = "Team";
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(43, 247);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(70, 16);
            this.lblNationality.TabIndex = 30;
            this.lblNationality.Text = "Nationality";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(42, 208);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(62, 16);
            this.lblBirthDate.TabIndex = 29;
            this.lblBirthDate.Text = "BirthDate";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(42, 168);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(86, 16);
            this.lblPlayerName.TabIndex = 28;
            this.lblPlayerName.Text = "Player Name";
            // 
            // lblPlayerID
            // 
            this.lblPlayerID.AutoSize = true;
            this.lblPlayerID.Location = new System.Drawing.Point(42, 127);
            this.lblPlayerID.Name = "lblPlayerID";
            this.lblPlayerID.Size = new System.Drawing.Size(62, 16);
            this.lblPlayerID.TabIndex = 27;
            this.lblPlayerID.Text = "Player ID";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(259, 370);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(220, 31);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 370);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(220, 31);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(406, 48);
            this.btnLast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(68, 39);
            this.btnLast.TabIndex = 24;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(280, 48);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(68, 39);
            this.btnNext.TabIndex = 23;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(157, 48);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(68, 39);
            this.btnPrev.TabIndex = 22;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(37, 48);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(68, 39);
            this.btnFirst.TabIndex = 21;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.cBoxTeam);
            this.Controls.Add(this.cbBoxNationality);
            this.Controls.Add(this.numUpDownTeamNumber);
            this.Controls.Add(this.dtPickerBirthDate);
            this.Controls.Add(this.txtBoxPlayerName);
            this.Controls.Add(this.txtBoxPlayerID);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.lblTeamNumber);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblPlayerID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Name = "Player";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.Player_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTeamNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxTeam;
        private System.Windows.Forms.ComboBox cbBoxNationality;
        private System.Windows.Forms.NumericUpDown numUpDownTeamNumber;
        private System.Windows.Forms.DateTimePicker dtPickerBirthDate;
        private System.Windows.Forms.TextBox txtBoxPlayerName;
        private System.Windows.Forms.TextBox txtBoxPlayerID;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblTeamNumber;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblPlayerID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnFirst;
    }
}

