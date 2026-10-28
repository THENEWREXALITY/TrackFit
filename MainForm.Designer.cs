namespace TrackFit
{
    partial class MainForm
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
            this.z80_Navigation1 = new Z80NavBarControl.Z80_Navigation();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ProfilePicIcon = new System.Windows.Forms.PictureBox();
            this.SignoutButton = new System.Windows.Forms.Button();
            this.GoalButton = new System.Windows.Forms.Button();
            this.ActivityButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // z80_Navigation1
            // 
            this.z80_Navigation1.AutoVerticalScrollBar = false;
            this.z80_Navigation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(126)))), ((int)(((byte)(228)))));
            this.z80_Navigation1.IconLocation = new System.Drawing.Point(8, 8);
            this.z80_Navigation1.Location = new System.Drawing.Point(2, 84);
            this.z80_Navigation1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.z80_Navigation1.Name = "z80_Navigation1";
            this.z80_Navigation1.ShowItemsBorder = false;
            this.z80_Navigation1.ShowSelectedGlyph = true;
            this.z80_Navigation1.Size = new System.Drawing.Size(25, 554);
            this.z80_Navigation1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.ProfilePicIcon);
            this.panel4.Controls.Add(this.SignoutButton);
            this.panel4.Controls.Add(this.GoalButton);
            this.panel4.Controls.Add(this.ActivityButton);
            this.panel4.Controls.Add(this.HomeButton);
            this.panel4.Location = new System.Drawing.Point(27, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(103, 542);
            this.panel4.TabIndex = 12;
            // 
            // ProfilePicIcon
            // 
            this.ProfilePicIcon.Image = global::TrackFit.Properties.Resources.user_interface__2_;
            this.ProfilePicIcon.Location = new System.Drawing.Point(17, 7);
            this.ProfilePicIcon.Name = "ProfilePicIcon";
            this.ProfilePicIcon.Size = new System.Drawing.Size(65, 56);
            this.ProfilePicIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePicIcon.TabIndex = 0;
            this.ProfilePicIcon.TabStop = false;
            // 
            // SignoutButton
            // 
            this.SignoutButton.Image = global::TrackFit.Icons.logout__3_;
            this.SignoutButton.Location = new System.Drawing.Point(0, 382);
            this.SignoutButton.Name = "SignoutButton";
            this.SignoutButton.Size = new System.Drawing.Size(103, 73);
            this.SignoutButton.TabIndex = 4;
            this.SignoutButton.UseVisualStyleBackColor = true;
            this.SignoutButton.Click += new System.EventHandler(this.SignoutButton_Click);
            // 
            // GoalButton
            // 
            this.GoalButton.Image = global::TrackFit.Icons.goal;
            this.GoalButton.Location = new System.Drawing.Point(0, 277);
            this.GoalButton.Name = "GoalButton";
            this.GoalButton.Size = new System.Drawing.Size(103, 73);
            this.GoalButton.TabIndex = 3;
            this.GoalButton.UseVisualStyleBackColor = true;
            this.GoalButton.Click += new System.EventHandler(this.GoalButton_Click);
            // 
            // ActivityButton
            // 
            this.ActivityButton.Image = global::TrackFit.Icons.gym;
            this.ActivityButton.Location = new System.Drawing.Point(0, 169);
            this.ActivityButton.Name = "ActivityButton";
            this.ActivityButton.Size = new System.Drawing.Size(103, 71);
            this.ActivityButton.TabIndex = 1;
            this.ActivityButton.UseVisualStyleBackColor = true;
            this.ActivityButton.Click += new System.EventHandler(this.ActivityButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Image = global::TrackFit.Icons.house__1_;
            this.HomeButton.Location = new System.Drawing.Point(0, 69);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(103, 67);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // HomePanel
            // 
            this.HomePanel.Location = new System.Drawing.Point(136, 1);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(1000, 637);
            this.HomePanel.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::TrackFit.Properties.Resources.logo_color;
            this.pictureBox1.Location = new System.Drawing.Point(2, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1135, 643);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.z80_Navigation1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrackFit";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Z80NavBarControl.Z80_Navigation z80_Navigation1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Button GoalButton;
        private System.Windows.Forms.Button ActivityButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button SignoutButton;
        private System.Windows.Forms.PictureBox ProfilePicIcon;
    }
}