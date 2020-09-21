namespace LOL_Language
{
    partial class LLForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LLForm));
            this.clientButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.playButton = new System.Windows.Forms.Button();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.clientLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.logoLabel = new System.Windows.Forms.Label();
            this.dragAndDropLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clientButton
            // 
            this.clientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.clientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.clientButton.Location = new System.Drawing.Point(64, 111);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(198, 33);
            this.clientButton.TabIndex = 0;
            this.clientButton.Text = "Select LeagueClient.exe\r\n\r\n                 OR\r\n\r\nDrag your LeagueClient\r\nshortcu" +
    "t or .exe file here";
            this.clientButton.UseVisualStyleBackColor = false;
            this.clientButton.Click += new System.EventHandler(this.clientButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.playButton.Location = new System.Drawing.Point(64, 201);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(198, 34);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // languageComboBox
            // 
            this.languageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.languageComboBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.languageComboBox.Location = new System.Drawing.Point(64, 150);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(198, 23);
            this.languageComboBox.TabIndex = 2;
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // clientLabel
            // 
            this.clientLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.Location = new System.Drawing.Point(64, 71);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(198, 27);
            this.clientLabel.TabIndex = 3;
            this.clientLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitLabel
            // 
            this.exitLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitLabel.Image = ((System.Drawing.Image)(resources.GetObject("exitLabel.Image")));
            this.exitLabel.Location = new System.Drawing.Point(311, 0);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(23, 24);
            this.exitLabel.TabIndex = 5;
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // logoLabel
            // 
            this.logoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoLabel.Image = ((System.Drawing.Image)(resources.GetObject("logoLabel.Image")));
            this.logoLabel.Location = new System.Drawing.Point(118, 9);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(89, 62);
            this.logoLabel.TabIndex = 4;
            // 
            // dragAndDropLabel
            // 
            this.dragAndDropLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dragAndDropLabel.Location = new System.Drawing.Point(64, 176);
            this.dragAndDropLabel.Name = "dragAndDropLabel";
            this.dragAndDropLabel.Size = new System.Drawing.Size(198, 59);
            this.dragAndDropLabel.TabIndex = 6;
            this.dragAndDropLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dragAndDropLabel.Visible = false;
            // 
            // LLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.dragAndDropLabel);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.clientButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LLForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOL Language";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.LLForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.LLForm_DragEnter);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LLForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LLForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LLForm_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clientButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label dragAndDropLabel;
    }
}

