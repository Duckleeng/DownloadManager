namespace DownloadManager
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopLabel = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.HashInputBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.HashesListBox = new System.Windows.Forms.ListBox();
            this.ClearAllHashesButton = new System.Windows.Forms.Button();
            this.RemoveHashButton = new System.Windows.Forms.Button();
            this.HashesLabel = new System.Windows.Forms.Label();
            this.DirectoryLabel = new System.Windows.Forms.Label();
            this.DirectoryInputBox = new System.Windows.Forms.TextBox();
            this.SaveDirButton = new System.Windows.Forms.Button();
            this.HowToDirLabel = new System.Windows.Forms.Label();
            this.InstallServiceButton = new System.Windows.Forms.Button();
            this.AllDirsCheckbox = new System.Windows.Forms.CheckBox();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(0)))), ((int)(((byte)(185)))));
            this.TopPanel.Controls.Add(this.TopLabel);
            this.TopPanel.Controls.Add(this.MinimizeButton);
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(391, 27);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_dock);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_dock);
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopLabel.Location = new System.Drawing.Point(3, 6);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(228, 15);
            this.TopLabel.TabIndex = 2;
            this.TopLabel.Text = "Download Manager Control Center";
            this.TopLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_dock);
            this.TopLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_dock);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(212)))));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.Location = new System.Drawing.Point(340, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(26, 21);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(212)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(362, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 21);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // HashInputBox
            // 
            this.HashInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.HashInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HashInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashInputBox.Location = new System.Drawing.Point(12, 52);
            this.HashInputBox.Name = "HashInputBox";
            this.HashInputBox.Size = new System.Drawing.Size(367, 22);
            this.HashInputBox.TabIndex = 1;
            this.HashInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter_Press);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(304, 90);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // HashesListBox
            // 
            this.HashesListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.HashesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HashesListBox.FormattingEnabled = true;
            this.HashesListBox.Location = new System.Drawing.Point(12, 127);
            this.HashesListBox.Name = "HashesListBox";
            this.HashesListBox.Size = new System.Drawing.Size(367, 286);
            this.HashesListBox.TabIndex = 3;
            // 
            // ClearAllHashesButton
            // 
            this.ClearAllHashesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.ClearAllHashesButton.FlatAppearance.BorderSize = 0;
            this.ClearAllHashesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.ClearAllHashesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAllHashesButton.Location = new System.Drawing.Point(12, 90);
            this.ClearAllHashesButton.Name = "ClearAllHashesButton";
            this.ClearAllHashesButton.Size = new System.Drawing.Size(75, 23);
            this.ClearAllHashesButton.TabIndex = 4;
            this.ClearAllHashesButton.Text = "Remove All";
            this.ClearAllHashesButton.UseVisualStyleBackColor = false;
            this.ClearAllHashesButton.Click += new System.EventHandler(this.ClearAllHashesButton_Click);
            // 
            // RemoveHashButton
            // 
            this.RemoveHashButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.RemoveHashButton.FlatAppearance.BorderSize = 0;
            this.RemoveHashButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.RemoveHashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveHashButton.Location = new System.Drawing.Point(223, 90);
            this.RemoveHashButton.Name = "RemoveHashButton";
            this.RemoveHashButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveHashButton.TabIndex = 5;
            this.RemoveHashButton.Text = "Remove";
            this.RemoveHashButton.UseVisualStyleBackColor = false;
            this.RemoveHashButton.Click += new System.EventHandler(this.RemoveHash_Click);
            // 
            // HashesLabel
            // 
            this.HashesLabel.AutoSize = true;
            this.HashesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashesLabel.ForeColor = System.Drawing.Color.White;
            this.HashesLabel.Location = new System.Drawing.Point(13, 33);
            this.HashesLabel.Name = "HashesLabel";
            this.HashesLabel.Size = new System.Drawing.Size(175, 15);
            this.HashesLabel.TabIndex = 6;
            this.HashesLabel.Text = "Blocked Hashes (SHA256)";
            // 
            // DirectoryLabel
            // 
            this.DirectoryLabel.AutoSize = true;
            this.DirectoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectoryLabel.ForeColor = System.Drawing.Color.White;
            this.DirectoryLabel.Location = new System.Drawing.Point(13, 416);
            this.DirectoryLabel.Name = "DirectoryLabel";
            this.DirectoryLabel.Size = new System.Drawing.Size(64, 15);
            this.DirectoryLabel.TabIndex = 7;
            this.DirectoryLabel.Text = "Directory";
            // 
            // DirectoryInputBox
            // 
            this.DirectoryInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.DirectoryInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DirectoryInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectoryInputBox.Location = new System.Drawing.Point(12, 434);
            this.DirectoryInputBox.Name = "DirectoryInputBox";
            this.DirectoryInputBox.Size = new System.Drawing.Size(367, 22);
            this.DirectoryInputBox.TabIndex = 8;
            // 
            // SaveDirButton
            // 
            this.SaveDirButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.SaveDirButton.FlatAppearance.BorderSize = 0;
            this.SaveDirButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.SaveDirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveDirButton.Location = new System.Drawing.Point(292, 462);
            this.SaveDirButton.Name = "SaveDirButton";
            this.SaveDirButton.Size = new System.Drawing.Size(87, 23);
            this.SaveDirButton.TabIndex = 9;
            this.SaveDirButton.Text = "Save Directory";
            this.SaveDirButton.UseVisualStyleBackColor = false;
            this.SaveDirButton.Click += new System.EventHandler(this.SaveDirButton_Click);
            // 
            // HowToDirLabel
            // 
            this.HowToDirLabel.AutoSize = true;
            this.HowToDirLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowToDirLabel.Location = new System.Drawing.Point(83, 417);
            this.HowToDirLabel.Name = "HowToDirLabel";
            this.HowToDirLabel.Size = new System.Drawing.Size(213, 30);
            this.HowToDirLabel.TabIndex = 10;
            this.HowToDirLabel.Text = "Seperate directories with a comma (,)\r\n\r\n";
            // 
            // InstallServiceButton
            // 
            this.InstallServiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.InstallServiceButton.FlatAppearance.BorderSize = 0;
            this.InstallServiceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.InstallServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstallServiceButton.Location = new System.Drawing.Point(12, 462);
            this.InstallServiceButton.Name = "InstallServiceButton";
            this.InstallServiceButton.Size = new System.Drawing.Size(99, 23);
            this.InstallServiceButton.TabIndex = 11;
            this.InstallServiceButton.Text = "Install Service";
            this.InstallServiceButton.UseVisualStyleBackColor = false;
            this.InstallServiceButton.Click += new System.EventHandler(this.InstallServiceButton_Click);
            // 
            // AllDirsCheckbox
            // 
            this.AllDirsCheckbox.AutoSize = true;
            this.AllDirsCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllDirsCheckbox.Location = new System.Drawing.Point(302, 417);
            this.AllDirsCheckbox.Name = "AllDirsCheckbox";
            this.AllDirsCheckbox.Size = new System.Drawing.Size(88, 17);
            this.AllDirsCheckbox.TabIndex = 12;
            this.AllDirsCheckbox.Text = "All directories";
            this.AllDirsCheckbox.UseVisualStyleBackColor = true;
            this.AllDirsCheckbox.Click += new System.EventHandler(this.AllDirsCheckChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(391, 494);
            this.Controls.Add(this.AllDirsCheckbox);
            this.Controls.Add(this.DirectoryInputBox);
            this.Controls.Add(this.InstallServiceButton);
            this.Controls.Add(this.HowToDirLabel);
            this.Controls.Add(this.SaveDirButton);
            this.Controls.Add(this.DirectoryLabel);
            this.Controls.Add(this.HashesLabel);
            this.Controls.Add(this.RemoveHashButton);
            this.Controls.Add(this.ClearAllHashesButton);
            this.Controls.Add(this.HashesListBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.HashInputBox);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Download Manager";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.TextBox HashInputBox;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox HashesListBox;
        private System.Windows.Forms.Button ClearAllHashesButton;
        private System.Windows.Forms.Button RemoveHashButton;
        private System.Windows.Forms.Label HashesLabel;
        private System.Windows.Forms.Label DirectoryLabel;
        private System.Windows.Forms.TextBox DirectoryInputBox;
        private System.Windows.Forms.Button SaveDirButton;
        private System.Windows.Forms.Label HowToDirLabel;
        private System.Windows.Forms.Button InstallServiceButton;
        private System.Windows.Forms.CheckBox AllDirsCheckbox;
    }
}

