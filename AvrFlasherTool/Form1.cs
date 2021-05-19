using System;
using System.Collections;
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
        String chipsLocation = "cfg\\chips.txt";
        String progLocation = "cfg\\programmers.txt";
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

            bodLevelBox.SelectedIndex = 0;
            bootSizeBox.SelectedIndex = 0;
            freqComboBox.SelectedIndex = 0;

            avrdudeBox.Text = Path.Combine(Application.StartupPath, "avrdude.exe");
            confBox.Text = Path.Combine(Application.StartupPath, "avrdude.conf");
            chipsBox.Text = Path.Combine(Application.StartupPath, "cfg", "chips.txt");
            progsBox.Text = Path.Combine(Application.StartupPath, "cfg", "programmers.txt");

           autoSettingsGroup.Enabled = false;

            try
            {
                using (StreamReader sr = new StreamReader(chipsLocation))
                {
                    String[] chipData;
                    for (int i = 0; (line = sr.ReadLine()) != null; i++)
                    {
                        chipData = line.Split(',');
                        chips[i] = chipData[0];
                        MCUSelect.Items.Add(chipData[1].Trim());
                    }
                }

                using (StreamReader sr = new StreamReader(progLocation))
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

                LowByteText.Text = Properties.Settings.Default.lowByteFuse;
                HighByteText.Text = Properties.Settings.Default.highByteFuse;
                ExByteText.Text = Properties.Settings.Default.exByteFuse;

                freqComboBox.Text = Properties.Settings.Default.freqFuseSettings;
                bodLevelBox.Text = Properties.Settings.Default.bodFuseSettings;
                bootSizeBox.Text = Properties.Settings.Default.bootloaderFuseSettings;

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
            if (tabControl1.SelectedIndex == 0)
            {
                if (dataReceived != "")
                {
                    if (dataReceived.Contains("error"))
                        dataReceived = dataReceived.Substring(dataReceived.IndexOf("error"));
                    else
                        dataReceived = dataReceived.Substring(dataReceived.IndexOf("avrdude.exe"));
                    ConsoleTextBox.Text += dataReceived;

                    ConsoleTextBox.SelectionStart = ConsoleTextBox.Text.Length;
                    ConsoleTextBox.ScrollToCaret();
                    ConsoleTextBox.Cursor = Cursors.IBeam;
                }
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                if (dataReceived != "")
                {
                    ConsoleFuseTextBox.Text += dataReceived;

                    ConsoleFuseTextBox.SelectionStart = ConsoleTextBox.Text.Length;
                    ConsoleFuseTextBox.ScrollToCaret();
                    ConsoleFuseTextBox.Cursor = Cursors.IBeam;
                }
            }

            Form1.ActiveForm.Cursor = Cursors.Arrow;
            Form1.ActiveForm.Text = "Avr Flasher Tool " + Properties.Settings.Default.Version;
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

        private void flashFuseButton_Click(object sender, EventArgs e)
        {
            byte highByteFuse, lowByteFuse;

            if (invertFusesCheck.Checked)
            {
                highByteFuse = (byte)(
                (!resetIOCheck.Checked).CompareTo(false) << 7
              | ((!wdCheck.Checked).CompareTo(false) << 6)
              | ((!spiCheck.Checked).CompareTo(false) << 5)
              | (1 << 4)
              | ((!eesaveCheck.Checked).CompareTo(false) << 3)
              | (Convert.ToInt32(bootSizeBox.Text.Substring(bootSizeBox.Text.IndexOf("BOOTSZ =") + 9, 1)) << 2)  //Да-да, говнокод detected
              | (Convert.ToInt32(bootSizeBox.Text.Substring(bootSizeBox.Text.IndexOf("BOOTSZ =") + 10, 1)) << 1) //Да-да, говнокод detected
              | ((!bootCheck.Checked).CompareTo(false) << 0));

                lowByteFuse = (byte)(
                bodLevelBox.SelectedIndex << 7
              | ((!bodenCheck.Checked).CompareTo(false) << 6)
              | (Convert.ToInt32(freqComboBox.Text.Substring(freqComboBox.Text.IndexOf("SUT =") + 6, 1)) << 5)
              | (Convert.ToInt32(freqComboBox.Text.Substring(freqComboBox.Text.IndexOf("SUT =") + 7, 1)) << 4)
              | (Convert.ToInt32(freqComboBox.Text.Substring(freqComboBox.Text.IndexOf("CKSEL =") + 8, 1)) << 3)
              | (Convert.ToInt32(freqComboBox.Text.Substring(freqComboBox.Text.IndexOf("CKSEL =") + 9, 1)) << 2)  //Да-да, говнокод detected
              | (Convert.ToInt32(freqComboBox.Text.Substring(freqComboBox.Text.IndexOf("CKSEL =") + 10, 1)) << 1) //Да-да, говнокод detected
              | (Convert.ToInt32(freqComboBox.Text.Substring(freqComboBox.Text.IndexOf("CKSEL =") + 11, 1)) << 0));
            }
            else
            {
                highByteFuse = (byte)(
                resetIOCheck.Checked.CompareTo(false) << 7
              | (wdCheck.Checked.CompareTo(false) << 6)
              | (spiCheck.Checked.CompareTo(false) << 5)
              | (0 << 4)
              | (eesaveCheck.Checked.CompareTo(false) << 3)
              | (Convert.ToInt32(bootSizeBox.Text.Substring(bootSizeBox.Text.IndexOf("BOOTSZ =") + 9, 1)) << 2)
              | (Convert.ToInt32(bootSizeBox.Text.Substring(bootSizeBox.Text.IndexOf("BOOTSZ =") + 10, 1)) << 1)
              | (bootCheck.Checked.CompareTo(false) << 0));

                lowByteFuse = (byte)(
                Convert.ToInt32(!Convert.ToBoolean(bodLevelBox.SelectedIndex)) << 7
              | ((!bodenCheck.Checked).CompareTo(false) << 6)
              | (Convert.ToInt32(!Convert.ToBoolean(Convert.ToInt32(freqComboBox.Text.Substring(freqComboBox.Text.IndexOf("SUT =") + 7, 1)))) << 5)
              | (Convert.ToInt32(!Convert.ToBoolean(Convert.ToInt32(freqComboBox.Text.Substring(freqComboBox.Text.IndexOf("SUT =") + 6, 1)))) << 4)
              | (Convert.ToInt32(!Convert.ToBoolean(Convert.ToInt32(freqComboBox.Text.Substring(freqComboBox.Text.IndexOf("CKSEL =") + 11, 1)))) << 3)
              | (Convert.ToInt32(!Convert.ToBoolean(Convert.ToInt32(freqComboBox.Text.Substring(freqComboBox.Text.IndexOf("CKSEL =") + 10, 1)))) << 2)  //Да-да, говнокод detected
              | (Convert.ToInt32(!Convert.ToBoolean(Convert.ToInt32(freqComboBox.Text.Substring(freqComboBox.Text.IndexOf("CKSEL =") + 9, 1)))) << 1) //Да-да, говнокод detected
              | (Convert.ToInt32(!Convert.ToBoolean(Convert.ToInt32(freqComboBox.Text.Substring(freqComboBox.Text.IndexOf("CKSEL =") + 8, 1)))) << 0));
            }

            if (debugModeCheck.Checked)
            {
                ConsoleFuseTextBox.Text = "High byte Fuses:";
                ConsoleFuseTextBox.Text += "\n";
                ConsoleFuseTextBox.Text += "CKSEL =" + freqComboBox.Text.Substring(freqComboBox.Text.IndexOf("CKSEL =") + 8, 5); //CKSEL = 0001 SUT = 10
                ConsoleFuseTextBox.Text += "\n";
                ConsoleFuseTextBox.Text += "SUT =" + freqComboBox.Text.Substring(freqComboBox.Text.IndexOf("SUT =") + 6, 2); //CKSEL = 0001 SUT = 10
                ConsoleFuseTextBox.Text += "\n";
                ConsoleFuseTextBox.Text += "BOD =" + bodLevelBox.SelectedIndex.ToString();
                ConsoleFuseTextBox.Text += "\n";
                ConsoleFuseTextBox.Text += "BOOTSZ =" + bootSizeBox.Text.Substring(bootSizeBox.Text.IndexOf("BOOTSZ =") + 9, 1);
                ConsoleFuseTextBox.Text += "BOOTSZ =" + bootSizeBox.Text.Substring(bootSizeBox.Text.IndexOf("BOOTSZ =") + 10, 1);
                ConsoleFuseTextBox.Text += "\n";
                ConsoleFuseTextBox.Text += "RSTDISBL =" + (!resetIOCheck.Checked).CompareTo(false);
                ConsoleFuseTextBox.Text += "\n";
                ConsoleFuseTextBox.Text += "BODEN =" + bodenCheck.Checked.CompareTo(false);
                ConsoleFuseTextBox.Text += "\n";
                ConsoleFuseTextBox.Text += "BOOTRST =" + bootCheck.Checked.CompareTo(false);
                ConsoleFuseTextBox.Text += "\n";
                ConsoleFuseTextBox.Text += "WDTON =" + wdCheck.Checked.CompareTo(false);
                ConsoleFuseTextBox.Text += "\n";
                ConsoleFuseTextBox.Text += "SPIEN =" + spiCheck.Checked.CompareTo(false);
                ConsoleFuseTextBox.Text += "\n";
                ConsoleFuseTextBox.Text += "EESAVE =" + eesaveCheck.Checked.CompareTo(false);
                ConsoleFuseTextBox.Text += "\n";

                ConsoleFuseTextBox.Text += "low byte fuses =" + lowByteFuse.ToString("x");
                ConsoleFuseTextBox.Text += "\n";
                ConsoleFuseTextBox.Text += "high byte fuses =" + highByteFuse.ToString("x");
                ConsoleFuseTextBox.Text += "\n";
            }

            HighByteText.Text = highByteFuse.ToString("x");
            LowByteText.Text = lowByteFuse.ToString("x");

            string argument =
                dudeLocation +
                " -c " + programmers[ProgSelect.SelectedIndex] +
                " -p " + chips[MCUSelect.SelectedIndex] +
                " -C " + confLocation +
                " -U lfuse:w:0x" +
                LowByteText.Text +
                ":m -U hfuse:w:0x" +
                HighByteText.Text +
                ":m";

            if (checkPortBox.Checked == true && PortSelect.Text != "")
                argument += " -P " + PortSelect.SelectedItem;
            else if (checkPortBox.Checked == true && PortSelect.Text == "")
                MessageBox.Show("Please select COM-Port.\r\n" +
                                "If you don't need it, then turn off the checkbox on the right.",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                                );
            Form1.ActiveForm.Cursor = Cursors.WaitCursor;
            ConsoleFuseTextBox.Cursor = Cursors.WaitCursor;
            Form1.ActiveForm.Text = "Reading...";

            deployAvrdude.RunWorkerAsync(argument);

            Properties.Settings.Default.lowByteFuse = LowByteText.Text;
            Properties.Settings.Default.highByteFuse = HighByteText.Text;
            Properties.Settings.Default.exByteFuse = ExByteText.Text;

            Properties.Settings.Default.freqFuseSettings = freqComboBox.Text;
            Properties.Settings.Default.bodFuseSettings = bodLevelBox.Text;
            Properties.Settings.Default.bootloaderFuseSettings = bootSizeBox.Text;

            Properties.Settings.Default.mcuSelected = MCUSelect.Text;
            Properties.Settings.Default.progSelected = ProgSelect.Text;
            Properties.Settings.Default.fileSelected = FileSelect.Text;
            Properties.Settings.Default.saveSelected = SaveSelect.Text;
            Properties.Settings.Default.Save();
        }

        private void readFuseSettings_Click(object sender, EventArgs e)
        {
            string argument =
                dudeLocation +
                " -c " + programmers[ProgSelect.SelectedIndex] +
                " -p " + chips[MCUSelect.SelectedIndex] +
                " -C " + confLocation +
                " -U lfuse:r:-:h" +
                " -U hfuse:r:-:h" +
                " -U efuse:r:-:h";

            if (checkPortBox.Checked == true && PortSelect.Text != "")
                argument += " -P " + PortSelect.SelectedItem;
            else if (checkPortBox.Checked == true && PortSelect.Text == "")
                MessageBox.Show("Please select COM-Port.\r\n" +
                                "If you don't need it, then turn off the checkbox on the right.",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                                );
            Form1.ActiveForm.Cursor = Cursors.WaitCursor;
            ConsoleFuseTextBox.Cursor = Cursors.WaitCursor;
            Form1.ActiveForm.Text = "Reading...";

            deployAvrdude.RunWorkerAsync(argument);

            Properties.Settings.Default.lowByteFuse = LowByteText.Text;
            Properties.Settings.Default.highByteFuse = HighByteText.Text;
            Properties.Settings.Default.exByteFuse = ExByteText.Text;

            Properties.Settings.Default.freqFuseSettings = freqComboBox.Text;
            Properties.Settings.Default.bodFuseSettings = bodLevelBox.Text;
            Properties.Settings.Default.bootloaderFuseSettings = bootSizeBox.Text;

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
            openFileDialog.FileName = "*.hex";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Open Firmware files...";
            openFileDialog.Filter = "Firmware files(*.hex)|*.hex|All files(*.*)|*.*";
            FileSelect.Text = openFileDialog.FileName;
        }

        private void SearchWriteFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "*.hex";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            openFileDialog.Title = "Open Firmware files...";
            openFileDialog.Filter = "Firmware files(*.hex)|*.hex|All files(*.*)|*.*";
            openFileDialog.Multiselect = false;
            FileSelect.Text = openFileDialog.FileName;
        }

        private void SaveSelect_MouseDown(object sender, MouseEventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            SaveSelect.Text = saveFileDialog.FileName;
        }

        private void SearchReadFileButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            SaveSelect.Text = saveFileDialog.FileName;
        }
        private void avrdudeSearchButton_Click(object sender, EventArgs e)
        {
            //openFileDialog.InitialDirectory = Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()), "cfg");
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Open avrdude.exe...";
            openFileDialog.FileName = "avrdude.exe";
            openFileDialog.Filter = "Avrdude exe file(*.exe)|*.exe";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            avrdudeBox.Text = openFileDialog.FileName;
            dudeLocation = openFileDialog.FileName;
        }
        private void confSearchButton_Click(object sender, EventArgs e)
        {

            openFileDialog.Title = "Open avrdude.conf...";
            openFileDialog.FileName = "avrdude.conf";
            openFileDialog.Filter = "Config files(*.conf)|*.conf";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            confBox.Text = openFileDialog.FileName;
            confLocation = openFileDialog.FileName;
        }
        private void chipsSearchButton_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Path.Combine(Application.StartupPath, "cfg");
            openFileDialog.Title = "Open Chips config file...";
            openFileDialog.FileName = "chips.txt";
            openFileDialog.Filter = "Text files(*.txt)|*.text|All files(*.*)|*.*";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            chipsBox.Text = openFileDialog.FileName;
            chipsLocation = openFileDialog.FileName;
        }
        private void progsSearchButton_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Path.Combine(Application.StartupPath, "cfg");
            openFileDialog.Title = "Open Prog config file...";
            openFileDialog.FileName = "programmers.txt";
            openFileDialog.Filter = "Text files(*.txt)|*.text|All files(*.*)|*.*";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            progsBox.Text = openFileDialog.FileName;
            progLocation = openFileDialog.FileName;
        }
        private void avrdudeBox_MouseDown(object sender, MouseEventArgs e)
        {
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Open avrdude.exe...";
            openFileDialog.FileName = "avrdude.exe";
            openFileDialog.Filter = "Avrdude exe file(*.exe)|*.exe";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            avrdudeBox.Text = openFileDialog.FileName;
            dudeLocation = openFileDialog.FileName;
        }
        private void confBox_MouseDown(object sender, MouseEventArgs e)
        {
            openFileDialog.Title = "Open avrdude.conf...";
            openFileDialog.FileName = "avrdude.conf";
            openFileDialog.Filter = "Config files(*.conf)|*.conf";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            confBox.Text = openFileDialog.FileName;
            confLocation = openFileDialog.FileName;
        }
        private void chipsBox_MouseDown(object sender, MouseEventArgs e)
        {
            openFileDialog.InitialDirectory = Path.Combine(Application.StartupPath, "cfg");
            openFileDialog.Title = "Open Chips config file...";
            openFileDialog.FileName = "chips.txt";
            openFileDialog.Filter = "Text files(*.txt)|*.text|All files(*.*)|*.*";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            chipsBox.Text = openFileDialog.FileName;
            chipsLocation = openFileDialog.FileName;
        }
        private void progsBox_MouseDown(object sender, MouseEventArgs e)
        {
            openFileDialog.InitialDirectory = Path.Combine(Application.StartupPath, "cfg");
            openFileDialog.Title = "Open Prog config file...";
            openFileDialog.FileName = "programmers.txt";
            openFileDialog.Filter = "Text files(*.txt)|*.text|All files(*.*)|*.*";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            progsBox.Text = openFileDialog.FileName;
            progLocation = openFileDialog.FileName;
        }

        private void checkPortBox_CheckedChanged(object sender, EventArgs e)
        {
            PortSelect.Enabled = checkPortBox.Checked;
        }
        private void autoSettingsCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (autoSettingsCheck.Checked)
            {
                manualSettingsCheck.Checked = false;
                manualSettingsGroup.Enabled = false;
                manualSettingsCheck.Enabled = true;
            }
            else
            {
                manualSettingsCheck.Checked = true;
                manualSettingsGroup.Enabled = true;
            }
        }

        private void manualSettingsCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (manualSettingsCheck.Checked)
            {
                autoSettingsCheck.Checked = false;
                autoSettingsGroup.Enabled = false;
                autoSettingsCheck.Enabled = true;
            }
            else
            {
                MessageBox.Show("Caution!\r\n" +
                                "Automatic fuse settings are under testing and may therefore harm your device. Works only with ATmega 8, use with caution!",
                                "Caution!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                                );
                autoSettingsCheck.Checked = true;
                autoSettingsGroup.Enabled = true;
            }
        }

        private void bodenCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (bodenCheck.Checked)
                toolTipButtons.SetToolTip(bodenCheck, "Power monitor is on [BODEN = 1]");
            else
                toolTipButtons.SetToolTip(bodenCheck, "Power monitor is off [BODEN = 0]");
        }

        private void bootCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (bootCheck.Checked)
                toolTipButtons.SetToolTip(bootCheck, "Go to bootloader after reset [BOOTRST=1]");
            else
                toolTipButtons.SetToolTip(bootCheck, "Don't go to bootloader after reset [BOOTRST=0]");
        }

        private void resetIOCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (resetIOCheck.Checked)
            {
                MessageBox.Show("Caution!\r\n" +
                                "After changing that setting, you will not be able to flash the MSU with an ordinary programmer!",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation
                                );
                toolTipButtons.SetToolTip(resetIOCheck, "Inhibit external reset (PC6 used for I / O) [RSTDISBL=1]");
            }
            else
                toolTipButtons.SetToolTip(resetIOCheck, "External reset enable (PC6 used for I / O) [RSTDISBL=0]");
        }

        private void wdCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (wdCheck.Checked)
                watchdogTimerLabel.Text = "Watchdog timer is always on [WDTON = 1]";
            else
                watchdogTimerLabel.Text = "Watchdog timer is always off [WDTON = 0]";
        }

        private void spiCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (spiCheck.Checked)
                spiEnableLabel.Text = "Enable In-Circuit Programming (SPI) [SPIEN = 1]";
            else
            {
                MessageBox.Show("Caution!\r\n" +
                                "After changing that setting, you will not be able to flash the MSU with an ordinary programmer!",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation
                                );
                spiEnableLabel.Text = "Disable In-Circuit Programming (SPI) [SPIEN = 0]";
            }
        }

        private void eesaveCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (eesaveCheck.Checked)
                eesaveEnableLabel.Text = "Save EEPROM contents when erasing a chip [EESAVE = 1]";
            else
                eesaveEnableLabel.Text = "Dont save EEPROM contents when erasing a chip [EESAVE = 0]";
        }
        private void instIco_Click(object sender, EventArgs e)
        {
            Process.Start("https://instagram.com/TTLC198/");
        }

        private void yotubeIco_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCyJwD1mj6EF1pAM1wtNC-pw");
        }

        private void vkIco_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/ttlc198/");
        }

        private void googlePlayIco_Click(object sender, EventArgs e)
        {
            Process.Start("https://play.google.com/store/apps/dev?id=7033011052298585807");
        }

        private void githubIco_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/TTLC198/AvrFlasherTool");
        }
    }
}
