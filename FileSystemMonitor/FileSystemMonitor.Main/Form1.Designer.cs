namespace FileSystemMonitor.Main
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.logRichTextBox = new System.Windows.Forms.RichTextBox();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.saveLogButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.monitorModeGroupBox = new System.Windows.Forms.GroupBox();
            this.modeRadioButton2 = new System.Windows.Forms.RadioButton();
            this.modeRadioButton1 = new System.Windows.Forms.RadioButton();
            this.folderChooseGroupBox = new System.Windows.Forms.GroupBox();
            this.folderBrowseButton = new System.Windows.Forms.Button();
            this.folderNameLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.monitorModeGroupBox.SuspendLayout();
            this.folderChooseGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.Controls.Add(this.logRichTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.controlPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(358, 227);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // logRichTextBox
            // 
            this.logRichTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.logRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logRichTextBox.Location = new System.Drawing.Point(3, 3);
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.Size = new System.Drawing.Size(242, 221);
            this.logRichTextBox.TabIndex = 0;
            this.logRichTextBox.Text = "";
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.saveLogButton);
            this.controlPanel.Controls.Add(this.startButton);
            this.controlPanel.Controls.Add(this.monitorModeGroupBox);
            this.controlPanel.Controls.Add(this.folderChooseGroupBox);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(251, 3);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(104, 221);
            this.controlPanel.TabIndex = 1;
            // 
            // saveLogButton
            // 
            this.saveLogButton.Location = new System.Drawing.Point(6, 164);
            this.saveLogButton.Name = "saveLogButton";
            this.saveLogButton.Size = new System.Drawing.Size(89, 23);
            this.saveLogButton.TabIndex = 3;
            this.saveLogButton.Text = "сохранить лог";
            this.saveLogButton.UseVisualStyleBackColor = true;
            this.saveLogButton.Click += new System.EventHandler(this.saveLogButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(6, 135);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(89, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "запуск";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // monitorModeGroupBox
            // 
            this.monitorModeGroupBox.Controls.Add(this.modeRadioButton2);
            this.monitorModeGroupBox.Controls.Add(this.modeRadioButton1);
            this.monitorModeGroupBox.Location = new System.Drawing.Point(0, 69);
            this.monitorModeGroupBox.Name = "monitorModeGroupBox";
            this.monitorModeGroupBox.Size = new System.Drawing.Size(104, 64);
            this.monitorModeGroupBox.TabIndex = 1;
            this.monitorModeGroupBox.TabStop = false;
            this.monitorModeGroupBox.Text = "режим";
            // 
            // modeRadioButton2
            // 
            this.modeRadioButton2.AutoSize = true;
            this.modeRadioButton2.Location = new System.Drawing.Point(10, 43);
            this.modeRadioButton2.Name = "modeRadioButton2";
            this.modeRadioButton2.Size = new System.Drawing.Size(81, 17);
            this.modeRadioButton2.TabIndex = 1;
            this.modeRadioButton2.Text = "оповещать";
            this.modeRadioButton2.UseVisualStyleBackColor = true;
            // 
            // modeRadioButton1
            // 
            this.modeRadioButton1.AutoSize = true;
            this.modeRadioButton1.Checked = true;
            this.modeRadioButton1.Location = new System.Drawing.Point(10, 20);
            this.modeRadioButton1.Name = "modeRadioButton1";
            this.modeRadioButton1.Size = new System.Drawing.Size(81, 17);
            this.modeRadioButton1.TabIndex = 0;
            this.modeRadioButton1.TabStop = true;
            this.modeRadioButton1.Text = "пассивный";
            this.modeRadioButton1.UseVisualStyleBackColor = true;
            // 
            // folderChooseGroupBox
            // 
            this.folderChooseGroupBox.Controls.Add(this.folderBrowseButton);
            this.folderChooseGroupBox.Controls.Add(this.folderNameLabel);
            this.folderChooseGroupBox.Location = new System.Drawing.Point(0, 3);
            this.folderChooseGroupBox.Name = "folderChooseGroupBox";
            this.folderChooseGroupBox.Size = new System.Drawing.Size(101, 63);
            this.folderChooseGroupBox.TabIndex = 0;
            this.folderChooseGroupBox.TabStop = false;
            this.folderChooseGroupBox.Text = "папка";
            // 
            // folderBrowseButton
            // 
            this.folderBrowseButton.Location = new System.Drawing.Point(6, 36);
            this.folderBrowseButton.Name = "folderBrowseButton";
            this.folderBrowseButton.Size = new System.Drawing.Size(89, 23);
            this.folderBrowseButton.TabIndex = 1;
            this.folderBrowseButton.Text = "обзор";
            this.folderBrowseButton.UseVisualStyleBackColor = true;
            this.folderBrowseButton.Click += new System.EventHandler(this.folderBrowseButton_Click);
            // 
            // folderNameLabel
            // 
            this.folderNameLabel.AutoSize = true;
            this.folderNameLabel.Location = new System.Drawing.Point(7, 20);
            this.folderNameLabel.Name = "folderNameLabel";
            this.folderNameLabel.Size = new System.Drawing.Size(0, 13);
            this.folderNameLabel.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 227);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Монитор файловой системы";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.monitorModeGroupBox.ResumeLayout(false);
            this.monitorModeGroupBox.PerformLayout();
            this.folderChooseGroupBox.ResumeLayout(false);
            this.folderChooseGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox logRichTextBox;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button saveLogButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox monitorModeGroupBox;
        private System.Windows.Forms.RadioButton modeRadioButton2;
        private System.Windows.Forms.RadioButton modeRadioButton1;
        private System.Windows.Forms.GroupBox folderChooseGroupBox;
        private System.Windows.Forms.Button folderBrowseButton;
        private System.Windows.Forms.Label folderNameLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

