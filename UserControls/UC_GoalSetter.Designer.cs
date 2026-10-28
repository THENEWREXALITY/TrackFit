namespace TrackFit.UserControls
{
    partial class UC_GoalSetter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtInfo2 = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtInfo1 = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.LblUserGoal = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblCalorieGoal = new System.Windows.Forms.Label();
            this.cmbGoals = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(31, 39);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(96, 22);
            this.TitleLabel.TabIndex = 53;
            this.TitleLabel.Text = "User Goal";
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(126)))), ((int)(((byte)(228)))));
            this.btnUpdateInfo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInfo.ForeColor = System.Drawing.Color.White;
            this.btnUpdateInfo.Location = new System.Drawing.Point(215, 237);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(338, 39);
            this.btnUpdateInfo.TabIndex = 52;
            this.btnUpdateInfo.Text = "NEXT";
            this.btnUpdateInfo.UseVisualStyleBackColor = false;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(126)))), ((int)(((byte)(228)))));
            this.panel10.Location = new System.Drawing.Point(433, 196);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(323, 1);
            this.panel10.TabIndex = 50;
            // 
            // txtInfo2
            // 
            this.txtInfo2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(126)))), ((int)(((byte)(228)))));
            this.txtInfo2.Location = new System.Drawing.Point(437, 127);
            this.txtInfo2.Multiline = true;
            this.txtInfo2.Name = "txtInfo2";
            this.txtInfo2.Size = new System.Drawing.Size(323, 24);
            this.txtInfo2.TabIndex = 49;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(126)))), ((int)(((byte)(228)))));
            this.panel9.Location = new System.Drawing.Point(433, 159);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(323, 1);
            this.panel9.TabIndex = 48;
            // 
            // txtInfo1
            // 
            this.txtInfo1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(126)))), ((int)(((byte)(228)))));
            this.txtInfo1.Location = new System.Drawing.Point(437, 94);
            this.txtInfo1.Multiline = true;
            this.txtInfo1.Name = "txtInfo1";
            this.txtInfo1.Size = new System.Drawing.Size(323, 24);
            this.txtInfo1.TabIndex = 47;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(126)))), ((int)(((byte)(228)))));
            this.panel8.Location = new System.Drawing.Point(433, 120);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(323, 1);
            this.panel8.TabIndex = 46;
            // 
            // LblUserGoal
            // 
            this.LblUserGoal.AutoSize = true;
            this.LblUserGoal.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserGoal.Location = new System.Drawing.Point(31, 176);
            this.LblUserGoal.Name = "LblUserGoal";
            this.LblUserGoal.Size = new System.Drawing.Size(139, 21);
            this.LblUserGoal.TabIndex = 45;
            this.LblUserGoal.Text = "Personal Goal:";
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.Location = new System.Drawing.Point(31, 139);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(196, 21);
            this.LblTime.TabIndex = 44;
            this.LblTime.Text = "Time Period (Months):";
            // 
            // LblCalorieGoal
            // 
            this.LblCalorieGoal.AutoSize = true;
            this.LblCalorieGoal.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCalorieGoal.Location = new System.Drawing.Point(31, 100);
            this.LblCalorieGoal.Name = "LblCalorieGoal";
            this.LblCalorieGoal.Size = new System.Drawing.Size(214, 21);
            this.LblCalorieGoal.TabIndex = 43;
            this.LblCalorieGoal.Text = "Calorie Goal (Calories):";
            // 
            // cmbGoals
            // 
            this.cmbGoals.BackColor = System.Drawing.Color.White;
            this.cmbGoals.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGoals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(126)))), ((int)(((byte)(228)))));
            this.cmbGoals.FormattingEnabled = true;
            this.cmbGoals.Items.AddRange(new object[] {
            " WeightLoss",
            " Strength",
            " Endurance",
            " Cardio",
            " Flexibility",
            " General"});
            this.cmbGoals.Location = new System.Drawing.Point(437, 166);
            this.cmbGoals.Name = "cmbGoals";
            this.cmbGoals.Size = new System.Drawing.Size(319, 28);
            this.cmbGoals.TabIndex = 54;
            // 
            // UC_GoalSetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmbGoals);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.btnUpdateInfo);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.txtInfo2);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.txtInfo1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.LblUserGoal);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.LblCalorieGoal);
            this.Location = new System.Drawing.Point(3, 1);
            this.Name = "UC_GoalSetter";
            this.Size = new System.Drawing.Size(787, 309);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtInfo2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtInfo1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label LblUserGoal;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblCalorieGoal;
        private System.Windows.Forms.ComboBox cmbGoals;
    }
}
