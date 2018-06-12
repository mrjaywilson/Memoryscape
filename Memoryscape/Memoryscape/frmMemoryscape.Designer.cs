namespace Project_2
{
    partial class frmMemoryscape
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
            this.btnFour = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.lstSpeed = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbColors = new System.Windows.Forms.ComboBox();
            this.chkColorBlind = new System.Windows.Forms.CheckBox();
            this.chkAudio = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlDifficulty = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rbInsane = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScoreTitle = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblGameStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.pnlDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFour.Enabled = false;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.Location = new System.Drawing.Point(494, 193);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(175, 175);
            this.btnFour.TabIndex = 0;
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnOne.Enabled = false;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.Location = new System.Drawing.Point(313, 12);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(175, 175);
            this.btnOne.TabIndex = 1;
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.IndianRed;
            this.btnTwo.Enabled = false;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.Location = new System.Drawing.Point(494, 12);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(175, 175);
            this.btnTwo.TabIndex = 2;
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnThree.Enabled = false;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.Location = new System.Drawing.Point(313, 193);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(175, 175);
            this.btnThree.TabIndex = 3;
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.pnlOptions);
            this.panel1.Controls.Add(this.pnlDifficulty);
            this.panel1.Controls.Add(this.btnQuit);
            this.panel1.Controls.Add(this.btnStartGame);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 356);
            this.panel1.TabIndex = 4;
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.Silver;
            this.pnlOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOptions.Controls.Add(this.lstSpeed);
            this.pnlOptions.Controls.Add(this.label5);
            this.pnlOptions.Controls.Add(this.label2);
            this.pnlOptions.Controls.Add(this.cmbColors);
            this.pnlOptions.Controls.Add(this.chkColorBlind);
            this.pnlOptions.Controls.Add(this.chkAudio);
            this.pnlOptions.Controls.Add(this.label4);
            this.pnlOptions.Location = new System.Drawing.Point(15, 164);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(265, 180);
            this.pnlOptions.TabIndex = 9;
            // 
            // lstSpeed
            // 
            this.lstSpeed.FormattingEnabled = true;
            this.lstSpeed.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.lstSpeed.Location = new System.Drawing.Point(147, 55);
            this.lstSpeed.Name = "lstSpeed";
            this.lstSpeed.Size = new System.Drawing.Size(106, 82);
            this.lstSpeed.TabIndex = 12;
            this.lstSpeed.SelectedIndexChanged += new System.EventHandler(this.lstSpeed_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(126, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 148);
            this.label5.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(142, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "GAME SPEED";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbColors
            // 
            this.cmbColors.Enabled = false;
            this.cmbColors.FormattingEnabled = true;
            this.cmbColors.Items.AddRange(new object[] {
            "None",
            "Protanopia",
            "Deuteranopia",
            "Tritanopia"});
            this.cmbColors.Location = new System.Drawing.Point(14, 74);
            this.cmbColors.Name = "cmbColors";
            this.cmbColors.Size = new System.Drawing.Size(103, 21);
            this.cmbColors.TabIndex = 10;
            this.cmbColors.SelectedIndexChanged += new System.EventHandler(this.cmbColors_SelectedIndexChanged);
            // 
            // chkColorBlind
            // 
            this.chkColorBlind.AutoSize = true;
            this.chkColorBlind.Location = new System.Drawing.Point(15, 51);
            this.chkColorBlind.Name = "chkColorBlind";
            this.chkColorBlind.Size = new System.Drawing.Size(106, 17);
            this.chkColorBlind.TabIndex = 9;
            this.chkColorBlind.Text = "Color Blind Mode";
            this.chkColorBlind.UseVisualStyleBackColor = true;
            this.chkColorBlind.CheckedChanged += new System.EventHandler(this.chkColorBlind_CheckedChanged);
            // 
            // chkAudio
            // 
            this.chkAudio.AutoSize = true;
            this.chkAudio.Checked = true;
            this.chkAudio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAudio.Location = new System.Drawing.Point(15, 28);
            this.chkAudio.Name = "chkAudio";
            this.chkAudio.Size = new System.Drawing.Size(89, 17);
            this.chkAudio.TabIndex = 8;
            this.chkAudio.Text = "Toggle Audio";
            this.chkAudio.UseVisualStyleBackColor = true;
            this.chkAudio.CheckedChanged += new System.EventHandler(this.chkAudio_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "OPTIONS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDifficulty
            // 
            this.pnlDifficulty.BackColor = System.Drawing.Color.Silver;
            this.pnlDifficulty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDifficulty.Controls.Add(this.label3);
            this.pnlDifficulty.Controls.Add(this.rbInsane);
            this.pnlDifficulty.Controls.Add(this.rbNormal);
            this.pnlDifficulty.Controls.Add(this.rbHard);
            this.pnlDifficulty.Controls.Add(this.rbEasy);
            this.pnlDifficulty.Location = new System.Drawing.Point(15, 87);
            this.pnlDifficulty.Name = "pnlDifficulty";
            this.pnlDifficulty.Size = new System.Drawing.Size(265, 71);
            this.pnlDifficulty.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(-1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "SET DIFFICULTY";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbInsane
            // 
            this.rbInsane.AutoSize = true;
            this.rbInsane.Location = new System.Drawing.Point(156, 45);
            this.rbInsane.Name = "rbInsane";
            this.rbInsane.Size = new System.Drawing.Size(68, 17);
            this.rbInsane.TabIndex = 3;
            this.rbInsane.Text = "INSANE!";
            this.rbInsane.UseVisualStyleBackColor = true;
            this.rbInsane.CheckedChanged += new System.EventHandler(this.rbInsane_CheckedChanged);
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.Location = new System.Drawing.Point(41, 45);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(58, 17);
            this.rbNormal.TabIndex = 1;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.rbNormal_CheckedChanged);
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.Location = new System.Drawing.Point(156, 23);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(48, 17);
            this.rbHard.TabIndex = 2;
            this.rbHard.Text = "Hard";
            this.rbHard.UseVisualStyleBackColor = true;
            this.rbHard.CheckedChanged += new System.EventHandler(this.rbHard_CheckedChanged);
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Location = new System.Drawing.Point(41, 22);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(48, 17);
            this.rbEasy.TabIndex = 0;
            this.rbEasy.Text = "Easy";
            this.rbEasy.UseVisualStyleBackColor = true;
            this.rbEasy.CheckedChanged += new System.EventHandler(this.rbEasy_CheckedChanged);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Silver;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Location = new System.Drawing.Point(205, 49);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 33);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Silver;
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.Location = new System.Drawing.Point(15, 49);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(75, 33);
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "M E M O R Y S C A P E";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreTitle
            // 
            this.lblScoreTitle.BackColor = System.Drawing.Color.Silver;
            this.lblScoreTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScoreTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTitle.Location = new System.Drawing.Point(12, 371);
            this.lblScoreTitle.Name = "lblScoreTitle";
            this.lblScoreTitle.Size = new System.Drawing.Size(295, 52);
            this.lblScoreTitle.TabIndex = 5;
            this.lblScoreTitle.Text = "SCORE:";
            this.lblScoreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Silver;
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(313, 371);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(356, 52);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGameStatus
            // 
            this.lblGameStatus.BackColor = System.Drawing.Color.Black;
            this.lblGameStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGameStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGameStatus.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGameStatus.Location = new System.Drawing.Point(418, 122);
            this.lblGameStatus.Name = "lblGameStatus";
            this.lblGameStatus.Size = new System.Drawing.Size(153, 132);
            this.lblGameStatus.TabIndex = 7;
            this.lblGameStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGameStatus.Visible = false;
            // 
            // frmMemoryscape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(679, 431);
            this.Controls.Add(this.lblGameStatus);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblScoreTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnFour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMemoryscape";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.pnlDifficulty.ResumeLayout(false);
            this.pnlDifficulty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnFour;
        public System.Windows.Forms.Button btnOne;
        public System.Windows.Forms.Button btnTwo;
        public System.Windows.Forms.Button btnThree;
        public System.Windows.Forms.Label lblScore;
        public System.Windows.Forms.Panel pnlDifficulty;
        public System.Windows.Forms.CheckBox chkAudio;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbColors;
        private System.Windows.Forms.CheckBox chkColorBlind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbInsane;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblScoreTitle;
        private System.Windows.Forms.ListBox lstSpeed;
        private System.Windows.Forms.Label lblGameStatus;
    }
}

