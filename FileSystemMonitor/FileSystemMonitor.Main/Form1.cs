using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileSystemMonitor.Logic;

namespace FileSystemMonitor.Main
{
    public partial class Form1 : Form
    {
        FSMonitor monitor;
        bool folderSelected = false;

        public Form1()
        {
            InitializeComponent();
            logRichTextBox.Text = "";
        }

        private void Monitor_Error(object sender, System.IO.ErrorEventArgs e)
        {
            startButton_Click(sender, e);
            logRichTextBox.Invoke(new Action(() => logRichTextBox.Text += e.GetException().Message + "\r\n"));
            if (modeRadioButton2.Checked)
                MessageBox.Show(e.GetException().Message);
        }

        private void Monitor_Changed(object sender, FSChangedEventArgs e)
        {
            string messege = e.message + "\n";

            logRichTextBox.Invoke(new Action(() => logRichTextBox.Text += messege));
            if (modeRadioButton2.Checked)
                MessageBox.Show(e.message);
        }

        private void folderBrowseButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string path = folderBrowserDialog1.SelectedPath;
            folderSelected = true;
            try
            {
                monitor = new FSMonitor(path);
                monitor.Changed += Monitor_Changed;
                monitor.Error += Monitor_Error;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            folderNameLabel.Text = path.Substring(path.LastIndexOf('\\') + 1);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (folderSelected)
            {
                try
                {
                    startButton.Invoke(new Action(() => NewMethod()));
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void NewMethod()
        {
            if (startButton.Text == "запуск")
            {
                monitor.Start();
                startButton.Text = "стоп";
            }
            else
            {
                monitor.Stop();
                startButton.Text = "запуск";
            }
        }

        private void saveLogButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            monitor.SaveLogToFile(openFileDialog1.FileName);
        }
    }
}
