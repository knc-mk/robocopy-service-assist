namespace RoboCopy_Assistant
{
    partial class Form1
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
            this.createButton = new System.Windows.Forms.Button();
            this.srcTextBox = new System.Windows.Forms.TextBox();
            this.destTextBox = new System.Windows.Forms.TextBox();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.srcLabel = new System.Windows.Forms.Label();
            this.destLabel = new System.Windows.Forms.Label();
            this.logLabel = new System.Windows.Forms.Label();
            this.srcBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.destBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.srcBrowseButton = new System.Windows.Forms.Button();
            this.destBrowseButton = new System.Windows.Forms.Button();
            this.logBrowseButton = new System.Windows.Forms.Button();
            this.logBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.recursiveCheckBox = new System.Windows.Forms.CheckBox();
            this.recursiveWithEmptyCheckBox = new System.Windows.Forms.CheckBox();
            this.logAppendCheckBox = new System.Windows.Forms.CheckBox();
            this.purgeCheckBox = new System.Windows.Forms.CheckBox();
            this.moveCheckBox = new System.Windows.Forms.CheckBox();
            this.mirrorCheckBox = new System.Windows.Forms.CheckBox();
            this.monCheckBox = new System.Windows.Forms.CheckBox();
            this.motCheckBox = new System.Windows.Forms.CheckBox();
            this.monValTextBox = new System.Windows.Forms.TextBox();
            this.motValTextBox = new System.Windows.Forms.TextBox();
            this.roboString = new System.Windows.Forms.Label();
            this.roboStringButton = new System.Windows.Forms.Button();
            this.excludeNTCheckBox = new System.Windows.Forms.CheckBox();
            this.serviceNameTextBox = new System.Windows.Forms.TextBox();
            this.serviceNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(506, 295);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(101, 23);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Create Service";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // srcTextBox
            // 
            this.srcTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcTextBox.Location = new System.Drawing.Point(150, 26);
            this.srcTextBox.Name = "srcTextBox";
            this.srcTextBox.Size = new System.Drawing.Size(340, 24);
            this.srcTextBox.TabIndex = 1;
            // 
            // destTextBox
            // 
            this.destTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destTextBox.Location = new System.Drawing.Point(150, 61);
            this.destTextBox.Name = "destTextBox";
            this.destTextBox.Size = new System.Drawing.Size(340, 24);
            this.destTextBox.TabIndex = 2;
            // 
            // logTextBox
            // 
            this.logTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTextBox.Location = new System.Drawing.Point(150, 214);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(340, 24);
            this.logTextBox.TabIndex = 3;
            // 
            // srcLabel
            // 
            this.srcLabel.AutoSize = true;
            this.srcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcLabel.Location = new System.Drawing.Point(49, 26);
            this.srcLabel.Name = "srcLabel";
            this.srcLabel.Size = new System.Drawing.Size(95, 18);
            this.srcLabel.TabIndex = 4;
            this.srcLabel.Text = "Source-Path:";
            // 
            // destLabel
            // 
            this.destLabel.AutoSize = true;
            this.destLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destLabel.Location = new System.Drawing.Point(23, 61);
            this.destLabel.Name = "destLabel";
            this.destLabel.Size = new System.Drawing.Size(121, 18);
            this.destLabel.TabIndex = 5;
            this.destLabel.Text = "Destination-Path:";
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logLabel.Location = new System.Drawing.Point(72, 217);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(72, 18);
            this.logLabel.TabIndex = 6;
            this.logLabel.Text = "Log-Path:";
            // 
            // srcBrowseButton
            // 
            this.srcBrowseButton.Location = new System.Drawing.Point(496, 26);
            this.srcBrowseButton.Name = "srcBrowseButton";
            this.srcBrowseButton.Size = new System.Drawing.Size(75, 24);
            this.srcBrowseButton.TabIndex = 7;
            this.srcBrowseButton.Text = "Browse";
            this.srcBrowseButton.UseVisualStyleBackColor = true;
            this.srcBrowseButton.Click += new System.EventHandler(this.srcBrowseButton_Click);
            // 
            // destBrowseButton
            // 
            this.destBrowseButton.Location = new System.Drawing.Point(496, 61);
            this.destBrowseButton.Name = "destBrowseButton";
            this.destBrowseButton.Size = new System.Drawing.Size(75, 24);
            this.destBrowseButton.TabIndex = 8;
            this.destBrowseButton.Text = "Browse";
            this.destBrowseButton.UseVisualStyleBackColor = true;
            this.destBrowseButton.Click += new System.EventHandler(this.destBrowseButton_Click);
            // 
            // logBrowseButton
            // 
            this.logBrowseButton.Location = new System.Drawing.Point(496, 213);
            this.logBrowseButton.Name = "logBrowseButton";
            this.logBrowseButton.Size = new System.Drawing.Size(75, 25);
            this.logBrowseButton.TabIndex = 9;
            this.logBrowseButton.Text = "Browse";
            this.logBrowseButton.UseVisualStyleBackColor = true;
            this.logBrowseButton.Click += new System.EventHandler(this.logBrowseButton_Click);
            // 
            // recursiveCheckBox
            // 
            this.recursiveCheckBox.AutoSize = true;
            this.recursiveCheckBox.Location = new System.Drawing.Point(150, 91);
            this.recursiveCheckBox.Name = "recursiveCheckBox";
            this.recursiveCheckBox.Size = new System.Drawing.Size(148, 17);
            this.recursiveCheckBox.TabIndex = 10;
            this.recursiveCheckBox.Text = "recursive (with subfolders)\r\n";
            this.recursiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // recursiveWithEmptyCheckBox
            // 
            this.recursiveWithEmptyCheckBox.AutoSize = true;
            this.recursiveWithEmptyCheckBox.Location = new System.Drawing.Point(361, 91);
            this.recursiveWithEmptyCheckBox.Name = "recursiveWithEmptyCheckBox";
            this.recursiveWithEmptyCheckBox.Size = new System.Drawing.Size(210, 17);
            this.recursiveWithEmptyCheckBox.TabIndex = 11;
            this.recursiveWithEmptyCheckBox.Text = "recursive-empty (with empty subfolders)";
            this.recursiveWithEmptyCheckBox.UseVisualStyleBackColor = true;
            // 
            // logAppendCheckBox
            // 
            this.logAppendCheckBox.AutoSize = true;
            this.logAppendCheckBox.Location = new System.Drawing.Point(150, 245);
            this.logAppendCheckBox.Name = "logAppendCheckBox";
            this.logAppendCheckBox.Size = new System.Drawing.Size(104, 17);
            this.logAppendCheckBox.TabIndex = 12;
            this.logAppendCheckBox.Text = "append to logfile";
            this.logAppendCheckBox.UseVisualStyleBackColor = true;
            // 
            // purgeCheckBox
            // 
            this.purgeCheckBox.AutoSize = true;
            this.purgeCheckBox.Location = new System.Drawing.Point(150, 114);
            this.purgeCheckBox.Name = "purgeCheckBox";
            this.purgeCheckBox.Size = new System.Drawing.Size(181, 17);
            this.purgeCheckBox.TabIndex = 13;
            this.purgeCheckBox.Text = "allow purging (delete files in dest)";
            this.purgeCheckBox.UseVisualStyleBackColor = true;
            // 
            // moveCheckBox
            // 
            this.moveCheckBox.AutoSize = true;
            this.moveCheckBox.Location = new System.Drawing.Point(150, 137);
            this.moveCheckBox.Name = "moveCheckBox";
            this.moveCheckBox.Size = new System.Drawing.Size(212, 17);
            this.moveCheckBox.TabIndex = 14;
            this.moveCheckBox.Text = "move (delete files and folders in source)";
            this.moveCheckBox.UseVisualStyleBackColor = true;
            // 
            // mirrorCheckBox
            // 
            this.mirrorCheckBox.AutoSize = true;
            this.mirrorCheckBox.Location = new System.Drawing.Point(361, 114);
            this.mirrorCheckBox.Name = "mirrorCheckBox";
            this.mirrorCheckBox.Size = new System.Drawing.Size(207, 17);
            this.mirrorCheckBox.TabIndex = 15;
            this.mirrorCheckBox.Text = "mirroring (recursive-empty and purging)";
            this.mirrorCheckBox.UseVisualStyleBackColor = true;
            // 
            // monCheckBox
            // 
            this.monCheckBox.AutoSize = true;
            this.monCheckBox.Location = new System.Drawing.Point(150, 161);
            this.monCheckBox.Name = "monCheckBox";
            this.monCheckBox.Size = new System.Drawing.Size(119, 17);
            this.monCheckBox.TabIndex = 16;
            this.monCheckBox.Text = "monitor for changes";
            this.monCheckBox.UseVisualStyleBackColor = true;
            // 
            // motCheckBox
            // 
            this.motCheckBox.AutoSize = true;
            this.motCheckBox.Location = new System.Drawing.Point(361, 161);
            this.motCheckBox.Name = "motCheckBox";
            this.motCheckBox.Size = new System.Drawing.Size(147, 17);
            this.motCheckBox.TabIndex = 17;
            this.motCheckBox.Text = "monitor for change in time";
            this.motCheckBox.UseVisualStyleBackColor = true;
            // 
            // monValTextBox
            // 
            this.monValTextBox.Location = new System.Drawing.Point(275, 160);
            this.monValTextBox.Name = "monValTextBox";
            this.monValTextBox.Size = new System.Drawing.Size(44, 20);
            this.monValTextBox.TabIndex = 18;
            this.monValTextBox.Text = "2";
            // 
            // motValTextBox
            // 
            this.motValTextBox.Location = new System.Drawing.Point(514, 159);
            this.motValTextBox.Name = "motValTextBox";
            this.motValTextBox.Size = new System.Drawing.Size(44, 20);
            this.motValTextBox.TabIndex = 19;
            this.motValTextBox.Text = "5";
            // 
            // roboString
            // 
            this.roboString.AutoSize = true;
            this.roboString.Location = new System.Drawing.Point(12, 281);
            this.roboString.Name = "roboString";
            this.roboString.Size = new System.Drawing.Size(79, 13);
            this.roboString.TabIndex = 20;
            this.roboString.Text = "robocopy-string";
            // 
            // roboStringButton
            // 
            this.roboStringButton.Location = new System.Drawing.Point(425, 295);
            this.roboStringButton.Name = "roboStringButton";
            this.roboStringButton.Size = new System.Drawing.Size(75, 23);
            this.roboStringButton.TabIndex = 21;
            this.roboStringButton.Text = "Build String";
            this.roboStringButton.UseVisualStyleBackColor = true;
            this.roboStringButton.Click += new System.EventHandler(this.roboStringButton_Click);
            // 
            // excludeNTCheckBox
            // 
            this.excludeNTCheckBox.AutoSize = true;
            this.excludeNTCheckBox.Location = new System.Drawing.Point(361, 138);
            this.excludeNTCheckBox.Name = "excludeNTCheckBox";
            this.excludeNTCheckBox.Size = new System.Drawing.Size(136, 17);
            this.excludeNTCheckBox.TabIndex = 22;
            this.excludeNTCheckBox.Text = "exclude NTUSER.DAT";
            this.excludeNTCheckBox.UseVisualStyleBackColor = true;
            // 
            // serviceNameTextBox
            // 
            this.serviceNameTextBox.Location = new System.Drawing.Point(275, 297);
            this.serviceNameTextBox.Name = "serviceNameTextBox";
            this.serviceNameTextBox.Size = new System.Drawing.Size(144, 20);
            this.serviceNameTextBox.TabIndex = 23;
            // 
            // serviceNameLabel
            // 
            this.serviceNameLabel.AutoSize = true;
            this.serviceNameLabel.Location = new System.Drawing.Point(197, 300);
            this.serviceNameLabel.Name = "serviceNameLabel";
            this.serviceNameLabel.Size = new System.Drawing.Size(72, 13);
            this.serviceNameLabel.TabIndex = 24;
            this.serviceNameLabel.Text = "Servicename:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 330);
            this.Controls.Add(this.serviceNameLabel);
            this.Controls.Add(this.serviceNameTextBox);
            this.Controls.Add(this.excludeNTCheckBox);
            this.Controls.Add(this.roboStringButton);
            this.Controls.Add(this.roboString);
            this.Controls.Add(this.motValTextBox);
            this.Controls.Add(this.monValTextBox);
            this.Controls.Add(this.motCheckBox);
            this.Controls.Add(this.monCheckBox);
            this.Controls.Add(this.mirrorCheckBox);
            this.Controls.Add(this.moveCheckBox);
            this.Controls.Add(this.purgeCheckBox);
            this.Controls.Add(this.logAppendCheckBox);
            this.Controls.Add(this.recursiveWithEmptyCheckBox);
            this.Controls.Add(this.recursiveCheckBox);
            this.Controls.Add(this.logBrowseButton);
            this.Controls.Add(this.destBrowseButton);
            this.Controls.Add(this.srcBrowseButton);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.destLabel);
            this.Controls.Add(this.srcLabel);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.destTextBox);
            this.Controls.Add(this.srcTextBox);
            this.Controls.Add(this.createButton);
            this.Name = "Form1";
            this.Text = "RoboCopy-Assistant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox srcTextBox;
        private System.Windows.Forms.TextBox destTextBox;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Label srcLabel;
        private System.Windows.Forms.Label destLabel;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.FolderBrowserDialog srcBrowser;
        private System.Windows.Forms.FolderBrowserDialog destBrowser;
        private System.Windows.Forms.Button srcBrowseButton;
        private System.Windows.Forms.Button destBrowseButton;
        private System.Windows.Forms.Button logBrowseButton;
        private System.Windows.Forms.FolderBrowserDialog logBrowser;
        private System.Windows.Forms.CheckBox recursiveCheckBox;
        private System.Windows.Forms.CheckBox recursiveWithEmptyCheckBox;
        private System.Windows.Forms.CheckBox logAppendCheckBox;
        private System.Windows.Forms.CheckBox purgeCheckBox;
        private System.Windows.Forms.CheckBox moveCheckBox;
        private System.Windows.Forms.CheckBox mirrorCheckBox;
        private System.Windows.Forms.CheckBox monCheckBox;
        private System.Windows.Forms.CheckBox motCheckBox;
        private System.Windows.Forms.TextBox monValTextBox;
        private System.Windows.Forms.TextBox motValTextBox;
        private System.Windows.Forms.Label roboString;
        private System.Windows.Forms.Button roboStringButton;
        private System.Windows.Forms.CheckBox excludeNTCheckBox;
        private System.Windows.Forms.TextBox serviceNameTextBox;
        private System.Windows.Forms.Label serviceNameLabel;
    }
}

