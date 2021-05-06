using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Diagnostics;

namespace AvrFlasherTool
{
    public partial class Form1 : Form
    {
        String dudeLocation = "avrdude.exe";
        String confLocation = "avrdude.conf";
        string[] chips = new String[100];
        string[] programmers = new string[100];

        delegate void FinishedProcessDelegate(string dataReceived);

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            String line;

            toolTipButtons.SetToolTip(FlashButton, "Flash!");
            toolTipButtons.SetToolTip(ReadButton, "Read!");

            foreach (string str in SerialPort.GetPortNames())
            {
                PortSelect.Items.Add(str);
                PortSelect.SelectedIndex = 0;
                PortSelect.Text = "No connected device...";
            }

            try
            {
                using (StreamReader sr = new StreamReader("cfg\\chips.txt"))
                {
                    String[] chipData;
                    for (int i = 0; (line = sr.ReadLine()) != null; i++)
                    {
                        chipData = line.Split(',');
                        chips[i] = chipData[0];
                        MCUSelect.Items.Add(chipData[1].Trim());
                    }
                }

                using (StreamReader sr = new StreamReader("cfg\\programmers.txt"))
                {
                    String[] programmerData;
                    for (int i = 0; (line = sr.ReadLine()) != null; i++)
                    {
                        programmerData = line.Split(',');
                        programmers[i] = programmerData[0];
                        ProgSelect.Items.Add(programmerData[1].Trim());
                    }
                }
                MCUSelect.SelectedIndex = 0;
                ProgSelect.SelectedIndex = 0;

                MCUSelect.Text = Properties.Settings.Default.mcuSelected;
                ProgSelect.Text = Properties.Settings.Default.progSelected;
                FileSelect.Text = Properties.Settings.Default.fileSelected;
                SaveSelect.Text = Properties.Settings.Default.saveSelected;

            }
            catch (Exception exc)
            {
                MessageBox.Show("There was a problem reading a configuration file.\r\n\r\n" + exc.Message + "\r\n\r\n" + "Avr Flasher Tool" +
                " will now close.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                Application.Exit();
            }
        }

        private void deployAvrdude_DoWork(object sender, DoWorkEventArgs e)
        {
            string arg = (string)e.Argument;
            string textBuffer;
            try
            {
                Process avrdude = new Process();
                StreamReader dudeout, dudeerror;
                StreamWriter dudein;

                ProcessStartInfo avrdudeinfo = new ProcessStartInfo("cmd.exe");
                avrdudeinfo.UseShellExecute = false;
                avrdudeinfo.RedirectStandardInput = true;
                avrdudeinfo.RedirectStandardOutput = true;
                avrdudeinfo.RedirectStandardError = true;
                avrdudeinfo.CreateNoWindow = true;

                avrdude.StartInfo = avrdudeinfo;
                avrdude.Start();
                dudein = avrdude.StandardInput;
                dudeerror = avrdude.StandardError;
                dudeout = avrdude.StandardOutput;
                dudein.AutoFlush = true;
                dudein.WriteLine(arg);
                dudein.Close();

                textBuffer = dudeout.ReadToEnd();
                textBuffer += dudeerror.ReadToEnd();
                Invoke(new FinishedProcessDelegate(FinishedProcess), textBuffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred. Check settings and correct connection. \r\n\r\n" +
                                "(" + ex.Message + ")",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
            }
        }

        private void FinishedProcess(string dataReceived)
        {
            if (dataReceived.Contains("error"))
                dataReceived = dataReceived.Substring(dataReceived.IndexOf("error"));
            else
                dataReceived = dataReceived.Substring(dataReceived.IndexOf("avrdude.exe"));
            ConsoleTextBox.Text += dataReceived;

            ConsoleTextBox.SelectionStart = ConsoleTextBox.Text.Length;
            ConsoleTextBox.ScrollToCaret();

            Form1.ActiveForm.Cursor = Cursors.Arrow;
            ConsoleTextBox.Cursor = Cursors.IBeam;
            Form1.ActiveForm.Text = "Avr Flasher Tool";
        }

        private void FlashButton_Click(object sender, EventArgs e)
        {
            string argument =
                dudeLocation +
                " -c " + programmers[ProgSelect.SelectedIndex] +
                " -p " + chips[MCUSelect.SelectedIndex] +
                " -C " + confLocation +
                " -U flash:w:" + FileSelect.Text + ":i ";

            if (checkEraseBox.Checked)
                argument += " -e ";
            if (checkForceBox.Checked)
                argument += " -F ";
            if (checkVerboseBox.Checked)
                argument += " -v ";

            if (checkPortBox.Checked == true && PortSelect.Text != "")
                argument += " -P " + PortSelect.SelectedItem;
            else if (checkPortBox.Checked == true && PortSelect.Text == "")
                MessageBox.Show("Please select COM-Port.\r\n" +
                                "If you don't need it, then turn off the checkbox on the right.",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                                );
            if (FileSelect.Text == "")
                MessageBox.Show("Please select a file.\r\n" +
                                "Please select a location to write the firmware file.",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                                );
            Form1.ActiveForm.Cursor = Cursors.WaitCursor;
            ConsoleTextBox.Cursor = Cursors.WaitCursor;
            Form1.ActiveForm.Text = "Uploading...";

            deployAvrdude.RunWorkerAsync(argument);

            Properties.Settings.Default.mcuSelected = MCUSelect.Text;
            Properties.Settings.Default.progSelected = ProgSelect.Text;
            Properties.Settings.Default.fileSelected = FileSelect.Text;
            Properties.Settings.Default.saveSelected = SaveSelect.Text;
            Properties.Settings.Default.Save();
        }
        private void ReadButton_Click(object sender, EventArgs e)
        {
            string argument =
                dudeLocation +
                " -c " + programmers[ProgSelect.SelectedIndex] +
                " -p " + chips[MCUSelect.SelectedIndex] +
                " -C " + confLocation +
                " -U flash:r:" + SaveSelect.Text + ":i ";

            if (checkVerboseBox.Checked)
                argument += " -v ";

            if (checkPortBox.Checked == true && PortSelect.Text != "")
                argument += " -P " + PortSelect.SelectedItem;
            else if (checkPortBox.Checked == true && PortSelect.Text == "")
                MessageBox.Show("Please select COM-Port.\r\n" +
                                "If you don't need it, then turn off the checkbox on the right.",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                                );
            if (SaveSelect.Text == "")
                MessageBox.Show("Please select a file.\r\n" +
                                "Please select a location to save the firmware file.",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                                );
            Form1.ActiveForm.Cursor = Cursors.WaitCursor;
            ConsoleTextBox.Cursor = Cursors.WaitCursor;
            Form1.ActiveForm.Text = "Reading...";

            deployAvrdude.RunWorkerAsync(argument);

            Properties.Settings.Default.mcuSelected = MCUSelect.Text;
            Properties.Settings.Default.progSelected = ProgSelect.Text;
            Properties.Settings.Default.fileSelected = FileSelect.Text;
            Properties.Settings.Default.saveSelected = SaveSelect.Text;
            Properties.Settings.Default.Save();
        }
        private void RefreshPortsButton_Click(object sender, EventArgs e)
        {
            foreach (string str in SerialPort.GetPortNames())
            {
                PortSelect.Items.Add(str);
                PortSelect.SelectedIndex = 0;
            }
            PortSelect.Text = "No connected devices...";
        }

        private void FileSelect_MouseDown(object sender, MouseEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            openFileDialog1.Multiselect = false;
            FileSelect.Text = openFileDialog1.FileName;
        }

        private void SearchWriteFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            openFileDialog1.Multiselect = false;
            FileSelect.Text = openFileDialog1.FileName;
        }

        private void SaveSelect_MouseDown(object sender, MouseEventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            SaveSelect.Text = saveFileDialog1.FileName;
        }

        private void SearchReadFileButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            SaveSelect.Text = saveFileDialog1.FileName;
        }
        private void checkPortBox_CheckedChanged(object sender, EventArgs e)
        {
            PortSelect.Enabled = checkPortBox.Checked;
        }

        private void manualSettingsCheck_CheckedChanged(object sender, EventArgs e)
        {
            autoSettingsCheck.Checked = false;
        }

        private void autoSettingsCheck_CheckedChanged(object sender, EventArgs e)
        {
            manualSettingsCheck.Checked = false;
        }
    }
}
