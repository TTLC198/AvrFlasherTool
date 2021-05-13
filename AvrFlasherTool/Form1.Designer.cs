namespace AvrFlasherTool
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MCU = new System.Windows.Forms.TabPage();
            this.filesSelectGroup = new System.Windows.Forms.GroupBox();
            this.SearchReadFileButton = new System.Windows.Forms.Button();
            this.SearchWriteFileButton = new System.Windows.Forms.Button();
            this.SaveSelect = new System.Windows.Forms.ComboBox();
            this.fileSaveLabel = new System.Windows.Forms.Label();
            this.FileSelect = new System.Windows.Forms.ComboBox();
            this.fileWriteLabel = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.consoleGroup = new System.Windows.Forms.GroupBox();
            this.ReadButton = new System.Windows.Forms.Button();
            this.ConsoleTextBox = new System.Windows.Forms.RichTextBox();
            this.FlashButton = new System.Windows.Forms.Button();
            this.programmerSelectGroup = new System.Windows.Forms.GroupBox();
            this.checkPortBox = new System.Windows.Forms.CheckBox();
            this.RefreshPortsButton = new System.Windows.Forms.Button();
            this.portProgLabel = new System.Windows.Forms.Label();
            this.typeProgLabel = new System.Windows.Forms.Label();
            this.PortSelect = new System.Windows.Forms.ComboBox();
            this.ProgSelect = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mcuSelectGroup = new System.Windows.Forms.GroupBox();
            this.checkEraseBox = new System.Windows.Forms.CheckBox();
            this.eraseChipLabel = new System.Windows.Forms.Label();
            this.checkForceBox = new System.Windows.Forms.CheckBox();
            this.forceLabel = new System.Windows.Forms.Label();
            this.checkVerboseBox = new System.Windows.Forms.CheckBox();
            this.verboseLogging = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MCUSelect = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FUSES = new System.Windows.Forms.TabPage();
            this.manualSettingsGroup = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ExByteText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.HighByteText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LowByteText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.manualSettingsCheck = new System.Windows.Forms.CheckBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.readFuseSettings = new System.Windows.Forms.Button();
            this.ConsoleFuseTextBox = new System.Windows.Forms.RichTextBox();
            this.flashFuseButton = new System.Windows.Forms.Button();
            this.autoSettingsGroup = new System.Windows.Forms.GroupBox();
            this.eesaveCheck = new System.Windows.Forms.CheckBox();
            this.spiCheck = new System.Windows.Forms.CheckBox();
            this.wdCheck = new System.Windows.Forms.CheckBox();
            this.autoSettingsCheck = new System.Windows.Forms.CheckBox();
            this.eesaveEnableLabel = new System.Windows.Forms.Label();
            this.spiEnableLabel = new System.Windows.Forms.Label();
            this.watchdogTimerLabel = new System.Windows.Forms.Label();
            this.resetIOCheck = new System.Windows.Forms.CheckBox();
            this.bootCheck = new System.Windows.Forms.CheckBox();
            this.bodenCheck = new System.Windows.Forms.CheckBox();
            this.bootSizeBox = new System.Windows.Forms.ComboBox();
            this.bootSizeLabel = new System.Windows.Forms.Label();
            this.bodLvlLabel = new System.Windows.Forms.Label();
            this.freqLabel = new System.Windows.Forms.Label();
            this.bodLevelBox = new System.Windows.Forms.ComboBox();
            this.freqComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.SETTINGS = new System.Windows.Forms.TabPage();
            this.invertFusesCheck = new System.Windows.Forms.CheckBox();
            this.invertFusesLabel = new System.Windows.Forms.Label();
            this.debugModeCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.INFO = new System.Windows.Forms.TabPage();
            this.googlePlayIco = new System.Windows.Forms.PictureBox();
            this.yotubeIco = new System.Windows.Forms.PictureBox();
            this.vkIco = new System.Windows.Forms.PictureBox();
            this.githubIco = new System.Windows.Forms.PictureBox();
            this.instIco = new System.Windows.Forms.PictureBox();
            this.infoTextBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.AppsLightCompanyIco = new System.Windows.Forms.PictureBox();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButtons = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.deployAvrdude = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.confSearchButton = new System.Windows.Forms.Button();
            this.avrdudeSearchButton = new System.Windows.Forms.Button();
            this.confBox = new System.Windows.Forms.ComboBox();
            this.confLabel = new System.Windows.Forms.Label();
            this.avrdudeBox = new System.Windows.Forms.ComboBox();
            this.avrdudeLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.generalSettingsGroup = new System.Windows.Forms.GroupBox();
            this.chipsSearchButton = new System.Windows.Forms.Button();
            this.chipsBox = new System.Windows.Forms.ComboBox();
            this.chipsLabel = new System.Windows.Forms.Label();
            this.progsSearchButton = new System.Windows.Forms.Button();
            this.progsBox = new System.Windows.Forms.ComboBox();
            this.progsLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.MCU.SuspendLayout();
            this.filesSelectGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.consoleGroup.SuspendLayout();
            this.programmerSelectGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.mcuSelectGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.FUSES.SuspendLayout();
            this.manualSettingsGroup.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.autoSettingsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SETTINGS.SuspendLayout();
            this.INFO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.googlePlayIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yotubeIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vkIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.githubIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppsLightCompanyIco)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.generalSettingsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.MCU);
            this.tabControl1.Controls.Add(this.FUSES);
            this.tabControl1.Controls.Add(this.SETTINGS);
            this.tabControl1.Controls.Add(this.INFO);
            this.tabControl1.ImageList = this.icons;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 100);
            this.tabControl1.Location = new System.Drawing.Point(-3, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(865, 506);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // MCU
            // 
            this.MCU.BackColor = System.Drawing.Color.Transparent;
            this.MCU.Controls.Add(this.filesSelectGroup);
            this.MCU.Controls.Add(this.consoleGroup);
            this.MCU.Controls.Add(this.programmerSelectGroup);
            this.MCU.Controls.Add(this.mcuSelectGroup);
            this.MCU.ImageIndex = 1;
            this.MCU.Location = new System.Drawing.Point(104, 4);
            this.MCU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MCU.Name = "MCU";
            this.MCU.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MCU.Size = new System.Drawing.Size(757, 498);
            this.MCU.TabIndex = 0;
            this.MCU.ToolTipText = "MCU Flash &&& Settings";
            // 
            // filesSelectGroup
            // 
            this.filesSelectGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.filesSelectGroup.Controls.Add(this.SearchReadFileButton);
            this.filesSelectGroup.Controls.Add(this.SearchWriteFileButton);
            this.filesSelectGroup.Controls.Add(this.SaveSelect);
            this.filesSelectGroup.Controls.Add(this.fileSaveLabel);
            this.filesSelectGroup.Controls.Add(this.FileSelect);
            this.filesSelectGroup.Controls.Add(this.fileWriteLabel);
            this.filesSelectGroup.Controls.Add(this.Search);
            this.filesSelectGroup.Controls.Add(this.pictureBox4);
            this.filesSelectGroup.Location = new System.Drawing.Point(5, 219);
            this.filesSelectGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filesSelectGroup.Name = "filesSelectGroup";
            this.filesSelectGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filesSelectGroup.Size = new System.Drawing.Size(712, 100);
            this.filesSelectGroup.TabIndex = 5;
            this.filesSelectGroup.TabStop = false;
            this.filesSelectGroup.Text = "Files";
            // 
            // SearchReadFileButton
            // 
            this.SearchReadFileButton.BackgroundImage = global::AvrFlasherTool.Properties.Resources.Search;
            this.SearchReadFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchReadFileButton.FlatAppearance.BorderSize = 0;
            this.SearchReadFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchReadFileButton.Location = new System.Drawing.Point(680, 55);
            this.SearchReadFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchReadFileButton.Name = "SearchReadFileButton";
            this.SearchReadFileButton.Size = new System.Drawing.Size(19, 17);
            this.SearchReadFileButton.TabIndex = 9;
            this.SearchReadFileButton.UseVisualStyleBackColor = true;
            this.SearchReadFileButton.Click += new System.EventHandler(this.SearchReadFileButton_Click);
            // 
            // SearchWriteFileButton
            // 
            this.SearchWriteFileButton.BackgroundImage = global::AvrFlasherTool.Properties.Resources.Search;
            this.SearchWriteFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchWriteFileButton.FlatAppearance.BorderSize = 0;
            this.SearchWriteFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchWriteFileButton.Location = new System.Drawing.Point(680, 25);
            this.SearchWriteFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchWriteFileButton.Name = "SearchWriteFileButton";
            this.SearchWriteFileButton.Size = new System.Drawing.Size(19, 17);
            this.SearchWriteFileButton.TabIndex = 8;
            this.SearchWriteFileButton.UseVisualStyleBackColor = true;
            this.SearchWriteFileButton.Click += new System.EventHandler(this.SearchWriteFileButton_Click);
            // 
            // SaveSelect
            // 
            this.SaveSelect.AllowDrop = true;
            this.SaveSelect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SaveSelect.Cursor = System.Windows.Forms.Cursors.Default;
            this.SaveSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSelect.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SaveSelect.FormattingEnabled = true;
            this.SaveSelect.IntegralHeight = false;
            this.SaveSelect.ItemHeight = 16;
            this.SaveSelect.Location = new System.Drawing.Point(147, 52);
            this.SaveSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveSelect.Name = "SaveSelect";
            this.SaveSelect.Size = new System.Drawing.Size(528, 24);
            this.SaveSelect.TabIndex = 12;
            this.SaveSelect.Text = "Please select a file...";
            this.SaveSelect.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SaveSelect_MouseDown);
            // 
            // fileSaveLabel
            // 
            this.fileSaveLabel.AutoSize = true;
            this.fileSaveLabel.BackColor = System.Drawing.Color.Transparent;
            this.fileSaveLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fileSaveLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.fileSaveLabel.Location = new System.Drawing.Point(87, 52);
            this.fileSaveLabel.Name = "fileSaveLabel";
            this.fileSaveLabel.Size = new System.Drawing.Size(50, 23);
            this.fileSaveLabel.TabIndex = 11;
            this.fileSaveLabel.Text = "Save:";
            // 
            // FileSelect
            // 
            this.FileSelect.AllowDrop = true;
            this.FileSelect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FileSelect.Cursor = System.Windows.Forms.Cursors.Default;
            this.FileSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileSelect.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FileSelect.FormattingEnabled = true;
            this.FileSelect.IntegralHeight = false;
            this.FileSelect.ItemHeight = 16;
            this.FileSelect.Location = new System.Drawing.Point(147, 21);
            this.FileSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FileSelect.Name = "FileSelect";
            this.FileSelect.Size = new System.Drawing.Size(528, 24);
            this.FileSelect.TabIndex = 10;
            this.FileSelect.Text = "Please select a file...";
            this.FileSelect.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FileSelect_MouseDown);
            // 
            // fileWriteLabel
            // 
            this.fileWriteLabel.AutoSize = true;
            this.fileWriteLabel.BackColor = System.Drawing.Color.Transparent;
            this.fileWriteLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fileWriteLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.fileWriteLabel.Location = new System.Drawing.Point(87, 22);
            this.fileWriteLabel.Name = "fileWriteLabel";
            this.fileWriteLabel.Size = new System.Drawing.Size(55, 23);
            this.fileWriteLabel.TabIndex = 9;
            this.fileWriteLabel.Text = "Write:";
            // 
            // Search
            // 
            this.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Location = new System.Drawing.Point(680, 59);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(27, 26);
            this.Search.TabIndex = 7;
            this.Search.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AvrFlasherTool.Properties.Resources.FileIco;
            this.pictureBox4.Location = new System.Drawing.Point(0, 20);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(85, 80);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // consoleGroup
            // 
            this.consoleGroup.Controls.Add(this.ReadButton);
            this.consoleGroup.Controls.Add(this.ConsoleTextBox);
            this.consoleGroup.Controls.Add(this.FlashButton);
            this.consoleGroup.Location = new System.Drawing.Point(5, 325);
            this.consoleGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.consoleGroup.Name = "consoleGroup";
            this.consoleGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.consoleGroup.Size = new System.Drawing.Size(712, 158);
            this.consoleGroup.TabIndex = 4;
            this.consoleGroup.TabStop = false;
            this.consoleGroup.Text = "Console";
            // 
            // ReadButton
            // 
            this.ReadButton.BackColor = System.Drawing.Color.Transparent;
            this.ReadButton.BackgroundImage = global::AvrFlasherTool.Properties.Resources.Read;
            this.ReadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReadButton.FlatAppearance.BorderSize = 0;
            this.ReadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadButton.ImageIndex = 5;
            this.ReadButton.Location = new System.Drawing.Point(641, 92);
            this.ReadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(65, 65);
            this.ReadButton.TabIndex = 6;
            this.ReadButton.UseVisualStyleBackColor = false;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // ConsoleTextBox
            // 
            this.ConsoleTextBox.Location = new System.Drawing.Point(5, 23);
            this.ConsoleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConsoleTextBox.Name = "ConsoleTextBox";
            this.ConsoleTextBox.ReadOnly = true;
            this.ConsoleTextBox.Size = new System.Drawing.Size(629, 128);
            this.ConsoleTextBox.TabIndex = 1;
            this.ConsoleTextBox.Text = "";
            // 
            // FlashButton
            // 
            this.FlashButton.BackColor = System.Drawing.Color.Transparent;
            this.FlashButton.BackgroundImage = global::AvrFlasherTool.Properties.Resources.MCU_Flash;
            this.FlashButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FlashButton.FlatAppearance.BorderSize = 0;
            this.FlashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlashButton.Location = new System.Drawing.Point(641, 21);
            this.FlashButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FlashButton.Name = "FlashButton";
            this.FlashButton.Size = new System.Drawing.Size(65, 65);
            this.FlashButton.TabIndex = 0;
            this.FlashButton.UseVisualStyleBackColor = false;
            this.FlashButton.Click += new System.EventHandler(this.FlashButton_Click);
            // 
            // programmerSelectGroup
            // 
            this.programmerSelectGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.programmerSelectGroup.Controls.Add(this.checkPortBox);
            this.programmerSelectGroup.Controls.Add(this.RefreshPortsButton);
            this.programmerSelectGroup.Controls.Add(this.portProgLabel);
            this.programmerSelectGroup.Controls.Add(this.typeProgLabel);
            this.programmerSelectGroup.Controls.Add(this.PortSelect);
            this.programmerSelectGroup.Controls.Add(this.ProgSelect);
            this.programmerSelectGroup.Controls.Add(this.pictureBox2);
            this.programmerSelectGroup.Location = new System.Drawing.Point(5, 113);
            this.programmerSelectGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.programmerSelectGroup.Name = "programmerSelectGroup";
            this.programmerSelectGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.programmerSelectGroup.Size = new System.Drawing.Size(712, 100);
            this.programmerSelectGroup.TabIndex = 3;
            this.programmerSelectGroup.TabStop = false;
            this.programmerSelectGroup.Text = "Programmer";
            // 
            // checkPortBox
            // 
            this.checkPortBox.AutoSize = true;
            this.checkPortBox.Location = new System.Drawing.Point(680, 63);
            this.checkPortBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkPortBox.Name = "checkPortBox";
            this.checkPortBox.Size = new System.Drawing.Size(18, 17);
            this.checkPortBox.TabIndex = 6;
            this.toolTipButtons.SetToolTip(this.checkPortBox, "Enables checking for port availability");
            this.checkPortBox.UseVisualStyleBackColor = true;
            this.checkPortBox.CheckedChanged += new System.EventHandler(this.checkPortBox_CheckedChanged);
            // 
            // RefreshPortsButton
            // 
            this.RefreshPortsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshPortsButton.BackgroundImage")));
            this.RefreshPortsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshPortsButton.FlatAppearance.BorderSize = 0;
            this.RefreshPortsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshPortsButton.Location = new System.Drawing.Point(680, 30);
            this.RefreshPortsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefreshPortsButton.Name = "RefreshPortsButton";
            this.RefreshPortsButton.Size = new System.Drawing.Size(19, 17);
            this.RefreshPortsButton.TabIndex = 7;
            this.toolTipButtons.SetToolTip(this.RefreshPortsButton, "Refresh ports.");
            this.RefreshPortsButton.UseVisualStyleBackColor = true;
            this.RefreshPortsButton.Click += new System.EventHandler(this.RefreshPortsButton_Click);
            // 
            // portProgLabel
            // 
            this.portProgLabel.AutoSize = true;
            this.portProgLabel.BackColor = System.Drawing.Color.Transparent;
            this.portProgLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.portProgLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.portProgLabel.Location = new System.Drawing.Point(87, 57);
            this.portProgLabel.Name = "portProgLabel";
            this.portProgLabel.Size = new System.Drawing.Size(46, 23);
            this.portProgLabel.TabIndex = 6;
            this.portProgLabel.Text = "Port:";
            // 
            // typeProgLabel
            // 
            this.typeProgLabel.AutoSize = true;
            this.typeProgLabel.BackColor = System.Drawing.Color.Transparent;
            this.typeProgLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.typeProgLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.typeProgLabel.Location = new System.Drawing.Point(87, 23);
            this.typeProgLabel.Name = "typeProgLabel";
            this.typeProgLabel.Size = new System.Drawing.Size(49, 23);
            this.typeProgLabel.TabIndex = 5;
            this.typeProgLabel.Text = "Type:";
            // 
            // PortSelect
            // 
            this.PortSelect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PortSelect.Enabled = false;
            this.PortSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PortSelect.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PortSelect.FormattingEnabled = true;
            this.PortSelect.IntegralHeight = false;
            this.PortSelect.ItemHeight = 16;
            this.PortSelect.Location = new System.Drawing.Point(147, 59);
            this.PortSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PortSelect.Name = "PortSelect";
            this.PortSelect.Size = new System.Drawing.Size(528, 24);
            this.PortSelect.TabIndex = 4;
            this.PortSelect.Text = "No connected devices...";
            // 
            // ProgSelect
            // 
            this.ProgSelect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ProgSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProgSelect.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ProgSelect.FormattingEnabled = true;
            this.ProgSelect.IntegralHeight = false;
            this.ProgSelect.ItemHeight = 16;
            this.ProgSelect.Location = new System.Drawing.Point(147, 26);
            this.ProgSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProgSelect.Name = "ProgSelect";
            this.ProgSelect.Size = new System.Drawing.Size(528, 24);
            this.ProgSelect.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AvrFlasherTool.Properties.Resources.Programmer;
            this.pictureBox2.Location = new System.Drawing.Point(0, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // mcuSelectGroup
            // 
            this.mcuSelectGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mcuSelectGroup.Controls.Add(this.checkEraseBox);
            this.mcuSelectGroup.Controls.Add(this.eraseChipLabel);
            this.mcuSelectGroup.Controls.Add(this.checkForceBox);
            this.mcuSelectGroup.Controls.Add(this.forceLabel);
            this.mcuSelectGroup.Controls.Add(this.checkVerboseBox);
            this.mcuSelectGroup.Controls.Add(this.verboseLogging);
            this.mcuSelectGroup.Controls.Add(this.label3);
            this.mcuSelectGroup.Controls.Add(this.MCUSelect);
            this.mcuSelectGroup.Controls.Add(this.pictureBox1);
            this.mcuSelectGroup.Location = new System.Drawing.Point(5, 7);
            this.mcuSelectGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mcuSelectGroup.Name = "mcuSelectGroup";
            this.mcuSelectGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mcuSelectGroup.Size = new System.Drawing.Size(712, 106);
            this.mcuSelectGroup.TabIndex = 2;
            this.mcuSelectGroup.TabStop = false;
            this.mcuSelectGroup.Text = "MCU";
            // 
            // checkEraseBox
            // 
            this.checkEraseBox.AutoSize = true;
            this.checkEraseBox.Checked = true;
            this.checkEraseBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEraseBox.Location = new System.Drawing.Point(680, 62);
            this.checkEraseBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkEraseBox.Name = "checkEraseBox";
            this.checkEraseBox.Size = new System.Drawing.Size(18, 17);
            this.checkEraseBox.TabIndex = 11;
            this.toolTipButtons.SetToolTip(this.checkEraseBox, "Enables extended logging.");
            this.checkEraseBox.UseVisualStyleBackColor = true;
            // 
            // eraseChipLabel
            // 
            this.eraseChipLabel.AutoSize = true;
            this.eraseChipLabel.BackColor = System.Drawing.Color.Transparent;
            this.eraseChipLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eraseChipLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.eraseChipLabel.Location = new System.Drawing.Point(451, 55);
            this.eraseChipLabel.Name = "eraseChipLabel";
            this.eraseChipLabel.Size = new System.Drawing.Size(214, 23);
            this.eraseChipLabel.TabIndex = 10;
            this.eraseChipLabel.Text = "Erase chip(recommended):";
            this.toolTipButtons.SetToolTip(this.eraseChipLabel, "Recommended!");
            // 
            // checkForceBox
            // 
            this.checkForceBox.AutoSize = true;
            this.checkForceBox.Location = new System.Drawing.Point(319, 62);
            this.checkForceBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkForceBox.Name = "checkForceBox";
            this.checkForceBox.Size = new System.Drawing.Size(18, 17);
            this.checkForceBox.TabIndex = 9;
            this.toolTipButtons.SetToolTip(this.checkForceBox, "Enables extended logging.");
            this.checkForceBox.UseVisualStyleBackColor = true;
            // 
            // forceLabel
            // 
            this.forceLabel.AutoSize = true;
            this.forceLabel.BackColor = System.Drawing.Color.Transparent;
            this.forceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.forceLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.forceLabel.Location = new System.Drawing.Point(225, 55);
            this.forceLabel.Name = "forceLabel";
            this.forceLabel.Size = new System.Drawing.Size(88, 23);
            this.forceLabel.TabIndex = 8;
            this.forceLabel.Text = "Force (-F):";
            this.toolTipButtons.SetToolTip(this.forceLabel, "Removes chip signature check");
            // 
            // checkVerboseBox
            // 
            this.checkVerboseBox.AutoSize = true;
            this.checkVerboseBox.Checked = true;
            this.checkVerboseBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkVerboseBox.Location = new System.Drawing.Point(201, 62);
            this.checkVerboseBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkVerboseBox.Name = "checkVerboseBox";
            this.checkVerboseBox.Size = new System.Drawing.Size(18, 17);
            this.checkVerboseBox.TabIndex = 7;
            this.toolTipButtons.SetToolTip(this.checkVerboseBox, "Enables extended logging.");
            this.checkVerboseBox.UseVisualStyleBackColor = true;
            // 
            // verboseLogging
            // 
            this.verboseLogging.AutoSize = true;
            this.verboseLogging.BackColor = System.Drawing.Color.Transparent;
            this.verboseLogging.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.verboseLogging.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.verboseLogging.Location = new System.Drawing.Point(87, 55);
            this.verboseLogging.Name = "verboseLogging";
            this.verboseLogging.Size = new System.Drawing.Size(108, 23);
            this.verboseLogging.TabIndex = 7;
            this.verboseLogging.Text = "Verbose (-v):";
            this.toolTipButtons.SetToolTip(this.verboseLogging, "Enable extended logging");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(87, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "MCU:";
            // 
            // MCUSelect
            // 
            this.MCUSelect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MCUSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MCUSelect.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MCUSelect.FormattingEnabled = true;
            this.MCUSelect.IntegralHeight = false;
            this.MCUSelect.ItemHeight = 16;
            this.MCUSelect.Location = new System.Drawing.Point(147, 18);
            this.MCUSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MCUSelect.Name = "MCUSelect";
            this.MCUSelect.Size = new System.Drawing.Size(548, 24);
            this.MCUSelect.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AvrFlasherTool.Properties.Resources.MCU_info;
            this.pictureBox1.Location = new System.Drawing.Point(0, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FUSES
            // 
            this.FUSES.Controls.Add(this.manualSettingsGroup);
            this.FUSES.Controls.Add(this.groupBox4);
            this.FUSES.Controls.Add(this.autoSettingsGroup);
            this.FUSES.ImageIndex = 0;
            this.FUSES.Location = new System.Drawing.Point(104, 4);
            this.FUSES.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FUSES.Name = "FUSES";
            this.FUSES.Size = new System.Drawing.Size(757, 498);
            this.FUSES.TabIndex = 3;
            this.FUSES.ToolTipText = "Fuses &&& Lock bites";
            this.FUSES.UseVisualStyleBackColor = true;
            // 
            // manualSettingsGroup
            // 
            this.manualSettingsGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.manualSettingsGroup.Controls.Add(this.label8);
            this.manualSettingsGroup.Controls.Add(this.panel4);
            this.manualSettingsGroup.Controls.Add(this.label10);
            this.manualSettingsGroup.Controls.Add(this.panel5);
            this.manualSettingsGroup.Controls.Add(this.panel6);
            this.manualSettingsGroup.Controls.Add(this.label13);
            this.manualSettingsGroup.Controls.Add(this.manualSettingsCheck);
            this.manualSettingsGroup.Controls.Add(this.pictureBox6);
            this.manualSettingsGroup.Enabled = false;
            this.manualSettingsGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.manualSettingsGroup.Location = new System.Drawing.Point(8, 223);
            this.manualSettingsGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manualSettingsGroup.Name = "manualSettingsGroup";
            this.manualSettingsGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manualSettingsGroup.Size = new System.Drawing.Size(712, 100);
            this.manualSettingsGroup.TabIndex = 13;
            this.manualSettingsGroup.TabStop = false;
            this.manualSettingsGroup.Text = "Manual Settings";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(344, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ext Byte:";
            this.toolTipButtons.SetToolTip(this.label8, "Enable extended logging");
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.ExByteText);
            this.panel4.Controls.Add(this.label9);
            this.panel4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel4.Location = new System.Drawing.Point(343, 50);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(58, 24);
            this.panel4.TabIndex = 14;
            // 
            // ExByteText
            // 
            this.ExByteText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExByteText.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F);
            this.ExByteText.Location = new System.Drawing.Point(25, -1);
            this.ExByteText.Margin = new System.Windows.Forms.Padding(4);
            this.ExByteText.MaxLength = 2;
            this.ExByteText.Name = "ExByteText";
            this.ExByteText.Size = new System.Drawing.Size(32, 25);
            this.ExByteText.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F);
            this.label9.Location = new System.Drawing.Point(0, -1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "0x";
            this.toolTipButtons.SetToolTip(this.label9, "Enable extended logging");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(215, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "High Byte:";
            this.toolTipButtons.SetToolTip(this.label10, "Enable extended logging");
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.HighByteText);
            this.panel5.Controls.Add(this.label11);
            this.panel5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel5.Location = new System.Drawing.Point(220, 50);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(58, 24);
            this.panel5.TabIndex = 12;
            // 
            // HighByteText
            // 
            this.HighByteText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HighByteText.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F);
            this.HighByteText.Location = new System.Drawing.Point(25, -1);
            this.HighByteText.Margin = new System.Windows.Forms.Padding(4);
            this.HighByteText.MaxLength = 2;
            this.HighByteText.Name = "HighByteText";
            this.HighByteText.Size = new System.Drawing.Size(32, 25);
            this.HighByteText.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F);
            this.label11.Location = new System.Drawing.Point(0, -1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 25);
            this.label11.TabIndex = 8;
            this.label11.Text = "0x";
            this.toolTipButtons.SetToolTip(this.label11, "Enable extended logging");
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.LowByteText);
            this.panel6.Controls.Add(this.label12);
            this.panel6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel6.Location = new System.Drawing.Point(101, 50);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(58, 24);
            this.panel6.TabIndex = 11;
            // 
            // LowByteText
            // 
            this.LowByteText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LowByteText.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F);
            this.LowByteText.Location = new System.Drawing.Point(25, -1);
            this.LowByteText.Margin = new System.Windows.Forms.Padding(4);
            this.LowByteText.MaxLength = 2;
            this.LowByteText.Name = "LowByteText";
            this.LowByteText.Size = new System.Drawing.Size(32, 25);
            this.LowByteText.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F);
            this.label12.Location = new System.Drawing.Point(0, -1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 25);
            this.label12.TabIndex = 8;
            this.label12.Text = "0x";
            this.toolTipButtons.SetToolTip(this.label12, "Enable extended logging");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(96, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 25);
            this.label13.TabIndex = 10;
            this.label13.Text = "Low Byte:";
            this.toolTipButtons.SetToolTip(this.label13, "Enable extended logging");
            // 
            // manualSettingsCheck
            // 
            this.manualSettingsCheck.AutoSize = true;
            this.manualSettingsCheck.Location = new System.Drawing.Point(116, 0);
            this.manualSettingsCheck.Margin = new System.Windows.Forms.Padding(4);
            this.manualSettingsCheck.Name = "manualSettingsCheck";
            this.manualSettingsCheck.Size = new System.Drawing.Size(18, 17);
            this.manualSettingsCheck.TabIndex = 5;
            this.manualSettingsCheck.UseVisualStyleBackColor = true;
            this.manualSettingsCheck.CheckedChanged += new System.EventHandler(this.manualSettingsCheck_CheckedChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::AvrFlasherTool.Properties.Resources.MCU_settings;
            this.pictureBox6.Location = new System.Drawing.Point(5, 21);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(85, 80);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.readFuseSettings);
            this.groupBox4.Controls.Add(this.ConsoleFuseTextBox);
            this.groupBox4.Controls.Add(this.flashFuseButton);
            this.groupBox4.Location = new System.Drawing.Point(8, 327);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(712, 158);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Console";
            // 
            // readFuseSettings
            // 
            this.readFuseSettings.BackColor = System.Drawing.Color.Transparent;
            this.readFuseSettings.BackgroundImage = global::AvrFlasherTool.Properties.Resources.Read;
            this.readFuseSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.readFuseSettings.FlatAppearance.BorderSize = 0;
            this.readFuseSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readFuseSettings.ImageIndex = 5;
            this.readFuseSettings.Location = new System.Drawing.Point(641, 92);
            this.readFuseSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readFuseSettings.Name = "readFuseSettings";
            this.readFuseSettings.Size = new System.Drawing.Size(65, 65);
            this.readFuseSettings.TabIndex = 6;
            this.readFuseSettings.UseVisualStyleBackColor = false;
            this.readFuseSettings.Click += new System.EventHandler(this.readFuseSettings_Click);
            // 
            // ConsoleFuseTextBox
            // 
            this.ConsoleFuseTextBox.Location = new System.Drawing.Point(5, 23);
            this.ConsoleFuseTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConsoleFuseTextBox.Name = "ConsoleFuseTextBox";
            this.ConsoleFuseTextBox.ReadOnly = true;
            this.ConsoleFuseTextBox.Size = new System.Drawing.Size(629, 128);
            this.ConsoleFuseTextBox.TabIndex = 1;
            this.ConsoleFuseTextBox.Text = "";
            // 
            // flashFuseButton
            // 
            this.flashFuseButton.BackColor = System.Drawing.Color.Transparent;
            this.flashFuseButton.BackgroundImage = global::AvrFlasherTool.Properties.Resources.MCU_Flash;
            this.flashFuseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flashFuseButton.FlatAppearance.BorderSize = 0;
            this.flashFuseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flashFuseButton.Location = new System.Drawing.Point(641, 21);
            this.flashFuseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flashFuseButton.Name = "flashFuseButton";
            this.flashFuseButton.Size = new System.Drawing.Size(65, 65);
            this.flashFuseButton.TabIndex = 0;
            this.flashFuseButton.UseVisualStyleBackColor = false;
            this.flashFuseButton.Click += new System.EventHandler(this.flashFuseButton_Click);
            // 
            // autoSettingsGroup
            // 
            this.autoSettingsGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.autoSettingsGroup.Controls.Add(this.eesaveCheck);
            this.autoSettingsGroup.Controls.Add(this.spiCheck);
            this.autoSettingsGroup.Controls.Add(this.wdCheck);
            this.autoSettingsGroup.Controls.Add(this.autoSettingsCheck);
            this.autoSettingsGroup.Controls.Add(this.eesaveEnableLabel);
            this.autoSettingsGroup.Controls.Add(this.spiEnableLabel);
            this.autoSettingsGroup.Controls.Add(this.watchdogTimerLabel);
            this.autoSettingsGroup.Controls.Add(this.resetIOCheck);
            this.autoSettingsGroup.Controls.Add(this.bootCheck);
            this.autoSettingsGroup.Controls.Add(this.bodenCheck);
            this.autoSettingsGroup.Controls.Add(this.bootSizeBox);
            this.autoSettingsGroup.Controls.Add(this.bootSizeLabel);
            this.autoSettingsGroup.Controls.Add(this.bodLvlLabel);
            this.autoSettingsGroup.Controls.Add(this.freqLabel);
            this.autoSettingsGroup.Controls.Add(this.bodLevelBox);
            this.autoSettingsGroup.Controls.Add(this.freqComboBox);
            this.autoSettingsGroup.Controls.Add(this.pictureBox3);
            this.autoSettingsGroup.Location = new System.Drawing.Point(8, 7);
            this.autoSettingsGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoSettingsGroup.Name = "autoSettingsGroup";
            this.autoSettingsGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoSettingsGroup.Size = new System.Drawing.Size(712, 210);
            this.autoSettingsGroup.TabIndex = 10;
            this.autoSettingsGroup.TabStop = false;
            this.autoSettingsGroup.Text = "Auto Settings(beta!)";
            // 
            // eesaveCheck
            // 
            this.eesaveCheck.AutoSize = true;
            this.eesaveCheck.Location = new System.Drawing.Point(12, 179);
            this.eesaveCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eesaveCheck.Name = "eesaveCheck";
            this.eesaveCheck.Size = new System.Drawing.Size(18, 17);
            this.eesaveCheck.TabIndex = 19;
            this.eesaveCheck.UseVisualStyleBackColor = true;
            this.eesaveCheck.CheckedChanged += new System.EventHandler(this.eesaveCheck_CheckedChanged);
            // 
            // spiCheck
            // 
            this.spiCheck.AutoSize = true;
            this.spiCheck.Checked = true;
            this.spiCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.spiCheck.Location = new System.Drawing.Point(12, 152);
            this.spiCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spiCheck.Name = "spiCheck";
            this.spiCheck.Size = new System.Drawing.Size(18, 17);
            this.spiCheck.TabIndex = 18;
            this.spiCheck.UseVisualStyleBackColor = true;
            this.spiCheck.CheckedChanged += new System.EventHandler(this.spiCheck_CheckedChanged);
            // 
            // wdCheck
            // 
            this.wdCheck.AutoSize = true;
            this.wdCheck.Location = new System.Drawing.Point(12, 125);
            this.wdCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wdCheck.Name = "wdCheck";
            this.wdCheck.Size = new System.Drawing.Size(18, 17);
            this.wdCheck.TabIndex = 17;
            this.wdCheck.UseVisualStyleBackColor = true;
            this.wdCheck.CheckedChanged += new System.EventHandler(this.wdCheck_CheckedChanged);
            // 
            // autoSettingsCheck
            // 
            this.autoSettingsCheck.AutoSize = true;
            this.autoSettingsCheck.Checked = true;
            this.autoSettingsCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoSettingsCheck.Location = new System.Drawing.Point(140, 0);
            this.autoSettingsCheck.Margin = new System.Windows.Forms.Padding(4);
            this.autoSettingsCheck.Name = "autoSettingsCheck";
            this.autoSettingsCheck.Size = new System.Drawing.Size(18, 17);
            this.autoSettingsCheck.TabIndex = 8;
            this.autoSettingsCheck.UseVisualStyleBackColor = true;
            this.autoSettingsCheck.CheckedChanged += new System.EventHandler(this.autoSettingsCheck_CheckedChanged);
            // 
            // eesaveEnableLabel
            // 
            this.eesaveEnableLabel.AutoSize = true;
            this.eesaveEnableLabel.BackColor = System.Drawing.Color.Transparent;
            this.eesaveEnableLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eesaveEnableLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.eesaveEnableLabel.Location = new System.Drawing.Point(36, 173);
            this.eesaveEnableLabel.Name = "eesaveEnableLabel";
            this.eesaveEnableLabel.Size = new System.Drawing.Size(453, 23);
            this.eesaveEnableLabel.TabIndex = 16;
            this.eesaveEnableLabel.Text = "Save EEPROM contents when erasing a chip [EESAVE = 0]";
            // 
            // spiEnableLabel
            // 
            this.spiEnableLabel.AutoSize = true;
            this.spiEnableLabel.BackColor = System.Drawing.Color.Transparent;
            this.spiEnableLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.spiEnableLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.spiEnableLabel.Location = new System.Drawing.Point(36, 146);
            this.spiEnableLabel.Name = "spiEnableLabel";
            this.spiEnableLabel.Size = new System.Drawing.Size(380, 23);
            this.spiEnableLabel.TabIndex = 15;
            this.spiEnableLabel.Text = "Enable In-Circuit Programming (SPI) [SPIEN = 1]";
            // 
            // watchdogTimerLabel
            // 
            this.watchdogTimerLabel.AutoSize = true;
            this.watchdogTimerLabel.BackColor = System.Drawing.Color.Transparent;
            this.watchdogTimerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.watchdogTimerLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.watchdogTimerLabel.Location = new System.Drawing.Point(36, 119);
            this.watchdogTimerLabel.Name = "watchdogTimerLabel";
            this.watchdogTimerLabel.Size = new System.Drawing.Size(339, 23);
            this.watchdogTimerLabel.TabIndex = 14;
            this.watchdogTimerLabel.Text = "Watchdog timer is always on [WDTON = 1]";
            // 
            // resetIOCheck
            // 
            this.resetIOCheck.AutoSize = true;
            this.resetIOCheck.Location = new System.Drawing.Point(683, 30);
            this.resetIOCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetIOCheck.Name = "resetIOCheck";
            this.resetIOCheck.Size = new System.Drawing.Size(18, 17);
            this.resetIOCheck.TabIndex = 13;
            this.toolTipButtons.SetToolTip(this.resetIOCheck, "External reset enable (PC6 used for I / O) [RSTDISBL=0]");
            this.resetIOCheck.UseVisualStyleBackColor = true;
            this.resetIOCheck.CheckedChanged += new System.EventHandler(this.resetIOCheck_CheckedChanged);
            // 
            // bootCheck
            // 
            this.bootCheck.AutoSize = true;
            this.bootCheck.Location = new System.Drawing.Point(683, 95);
            this.bootCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bootCheck.Name = "bootCheck";
            this.bootCheck.Size = new System.Drawing.Size(18, 17);
            this.bootCheck.TabIndex = 12;
            this.toolTipButtons.SetToolTip(this.bootCheck, "Go to bootloader after reset [BOOTRST=0]");
            this.bootCheck.UseVisualStyleBackColor = true;
            this.bootCheck.CheckedChanged += new System.EventHandler(this.bootCheck_CheckedChanged);
            // 
            // bodenCheck
            // 
            this.bodenCheck.AutoSize = true;
            this.bodenCheck.Location = new System.Drawing.Point(683, 63);
            this.bodenCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bodenCheck.Name = "bodenCheck";
            this.bodenCheck.Size = new System.Drawing.Size(18, 17);
            this.bodenCheck.TabIndex = 11;
            this.toolTipButtons.SetToolTip(this.bodenCheck, "Power monitor is on[BODEN = 1]");
            this.bodenCheck.UseVisualStyleBackColor = true;
            this.bodenCheck.CheckedChanged += new System.EventHandler(this.bodenCheck_CheckedChanged);
            // 
            // bootSizeBox
            // 
            this.bootSizeBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.bootSizeBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.bootSizeBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bootSizeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bootSizeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bootSizeBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bootSizeBox.FormattingEnabled = true;
            this.bootSizeBox.IntegralHeight = false;
            this.bootSizeBox.ItemHeight = 16;
            this.bootSizeBox.Items.AddRange(new object[] {
            "Bootloader size = 1024 words, Bootloader address = $0C00; [BOOTSZ = 00]",
            "Bootloader size = 512 words, Bootloader address = $0E00; [BOOTSZ = 01]",
            "Bootloader size = 256 words, Bootloader address = $0F00; [BOOTSZ = 10]",
            "Bootloader size = 128 words, Bootloader address = $0F80; [BOOTSZ = 11]"});
            this.bootSizeBox.Location = new System.Drawing.Point(172, 91);
            this.bootSizeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bootSizeBox.Name = "bootSizeBox";
            this.bootSizeBox.Size = new System.Drawing.Size(505, 24);
            this.bootSizeBox.TabIndex = 10;
            // 
            // bootSizeLabel
            // 
            this.bootSizeLabel.AutoSize = true;
            this.bootSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.bootSizeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bootSizeLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.bootSizeLabel.Location = new System.Drawing.Point(87, 92);
            this.bootSizeLabel.Name = "bootSizeLabel";
            this.bootSizeLabel.Size = new System.Drawing.Size(83, 23);
            this.bootSizeLabel.TabIndex = 9;
            this.bootSizeLabel.Text = "Boot size:";
            // 
            // bodLvlLabel
            // 
            this.bodLvlLabel.AutoSize = true;
            this.bodLvlLabel.BackColor = System.Drawing.Color.Transparent;
            this.bodLvlLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bodLvlLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.bodLvlLabel.Location = new System.Drawing.Point(87, 59);
            this.bodLvlLabel.Name = "bodLvlLabel";
            this.bodLvlLabel.Size = new System.Drawing.Size(71, 23);
            this.bodLvlLabel.TabIndex = 6;
            this.bodLvlLabel.Text = "BOD lvl:";
            // 
            // freqLabel
            // 
            this.freqLabel.AutoSize = true;
            this.freqLabel.BackColor = System.Drawing.Color.Transparent;
            this.freqLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.freqLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.freqLabel.Location = new System.Drawing.Point(87, 26);
            this.freqLabel.Name = "freqLabel";
            this.freqLabel.Size = new System.Drawing.Size(47, 23);
            this.freqLabel.TabIndex = 5;
            this.freqLabel.Text = "Freq:";
            // 
            // bodLevelBox
            // 
            this.bodLevelBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.bodLevelBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.bodLevelBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bodLevelBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.bodLevelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bodLevelBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bodLevelBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bodLevelBox.IntegralHeight = false;
            this.bodLevelBox.ItemHeight = 16;
            this.bodLevelBox.Items.AddRange(new object[] {
            "Power Monitor threshold=4.0 V;·[BODLEVEL = 0]",
            "Power Monitor threshold=2.7 V;·[BODLEVEL = 1]"});
            this.bodLevelBox.Location = new System.Drawing.Point(172, 59);
            this.bodLevelBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bodLevelBox.Name = "bodLevelBox";
            this.bodLevelBox.Size = new System.Drawing.Size(505, 24);
            this.bodLevelBox.TabIndex = 4;
            // 
            // freqComboBox
            // 
            this.freqComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Internal RC oscillator 1MHz; Trigger: 6 CK + 64 ms; [CKSEL = 0001 SUT = 10]",
            "Internal RC generator 2MHz; Trigger: 6 CK + 64 ms; [CKSEL = 0010 SUT = 10]",
            "Internal RC oscillator 4MHz; Trigger: 6 CK + 64 ms; [CKSEL = 0011 SUT = 10]",
            "Internal RC oscillator 8MHz; Trigger: 6 CK + 64 ms; [CKSEL = 0100 SUT = 10]",
            "External clock signal; Trigger: 6 CK + 64 ms; [CKSEL = 0000 SUT = 10]",
            "External RC circuit 8.0 MHz - 12.0 MHz; [CKSEL = 1000 SUT = 11]"});
            this.freqComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.freqComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.freqComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.freqComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.freqComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.freqComboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.freqComboBox.FormattingEnabled = true;
            this.freqComboBox.IntegralHeight = false;
            this.freqComboBox.ItemHeight = 16;
            this.freqComboBox.Items.AddRange(new object[] {
            "Internal RC oscillator 1MHz; Trigger: 6 CK + 0 ms; [CKSEL = 0001 SUT = 00]",
            "Internal RC oscillator 1MHz; Trigger: 6 CK + 64 ms; [CKSEL = 0001 SUT = 10]",
            "Internal RC generator 2MHz; Trigger: 6 CK + 0 ms; [CKSEL = 0010 SUT = 00]",
            "Internal RC generator 2MHz; Trigger: 6 CK + 64 ms; [CKSEL = 0010 SUT = 10]",
            "Internal RC generator 4MHz; Trigger: 6 CK + 0 ms; [CKSEL = 0011 SUT = 00]",
            "Internal RC oscillator 4MHz; Trigger: 6 CK + 64 ms; [CKSEL = 0011 SUT = 10]",
            "Internal RC oscillator 8MHz; Trigger: 6 CK + 0 ms; [CKSEL = 0100 SUT = 00]",
            "Internal RC oscillator 8MHz; Trigger: 6 CK + 64 ms; [CKSEL = 0100 SUT = 10]",
            "External clock signal; Trigger: 6 CK + 64 ms; [CKSEL = 0000 SUT = 10]",
            "External RC circuit 8.0 MHz - 12.0 MHz; [CKSEL = 1000 SUT = 11]"});
            this.freqComboBox.Location = new System.Drawing.Point(147, 26);
            this.freqComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.freqComboBox.Name = "freqComboBox";
            this.freqComboBox.Size = new System.Drawing.Size(530, 24);
            this.freqComboBox.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AvrFlasherTool.Properties.Resources.MCU_Auto;
            this.pictureBox3.Location = new System.Drawing.Point(0, 15);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(91, 85);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // SETTINGS
            // 
            this.SETTINGS.Controls.Add(this.generalSettingsGroup);
            this.SETTINGS.Controls.Add(this.groupBox1);
            this.SETTINGS.ImageIndex = 2;
            this.SETTINGS.Location = new System.Drawing.Point(104, 4);
            this.SETTINGS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SETTINGS.Name = "SETTINGS";
            this.SETTINGS.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SETTINGS.Size = new System.Drawing.Size(757, 498);
            this.SETTINGS.TabIndex = 1;
            this.SETTINGS.ToolTipText = "App Settings";
            this.SETTINGS.UseVisualStyleBackColor = true;
            // 
            // invertFusesCheck
            // 
            this.invertFusesCheck.AutoSize = true;
            this.invertFusesCheck.Checked = true;
            this.invertFusesCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.invertFusesCheck.Location = new System.Drawing.Point(370, 65);
            this.invertFusesCheck.Name = "invertFusesCheck";
            this.invertFusesCheck.Size = new System.Drawing.Size(18, 17);
            this.invertFusesCheck.TabIndex = 20;
            this.invertFusesCheck.UseVisualStyleBackColor = true;
            // 
            // invertFusesLabel
            // 
            this.invertFusesLabel.AutoSize = true;
            this.invertFusesLabel.BackColor = System.Drawing.Color.Transparent;
            this.invertFusesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.invertFusesLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.invertFusesLabel.Location = new System.Drawing.Point(87, 61);
            this.invertFusesLabel.Name = "invertFusesLabel";
            this.invertFusesLabel.Size = new System.Drawing.Size(261, 23);
            this.invertFusesLabel.TabIndex = 19;
            this.invertFusesLabel.Text = "Invert Fuse bits(used by default):";
            // 
            // debugModeCheck
            // 
            this.debugModeCheck.AutoSize = true;
            this.debugModeCheck.Checked = true;
            this.debugModeCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.debugModeCheck.Location = new System.Drawing.Point(210, 35);
            this.debugModeCheck.Name = "debugModeCheck";
            this.debugModeCheck.Size = new System.Drawing.Size(18, 17);
            this.debugModeCheck.TabIndex = 18;
            this.debugModeCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(87, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Debug mode:";
            // 
            // INFO
            // 
            this.INFO.Controls.Add(this.googlePlayIco);
            this.INFO.Controls.Add(this.yotubeIco);
            this.INFO.Controls.Add(this.vkIco);
            this.INFO.Controls.Add(this.githubIco);
            this.INFO.Controls.Add(this.instIco);
            this.INFO.Controls.Add(this.infoTextBox);
            this.INFO.Controls.Add(this.pictureBox7);
            this.INFO.Controls.Add(this.AppsLightCompanyIco);
            this.INFO.ImageIndex = 3;
            this.INFO.Location = new System.Drawing.Point(104, 4);
            this.INFO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.INFO.Name = "INFO";
            this.INFO.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.INFO.Size = new System.Drawing.Size(757, 498);
            this.INFO.TabIndex = 2;
            this.INFO.ToolTipText = "App Info";
            this.INFO.UseVisualStyleBackColor = true;
            // 
            // googlePlayIco
            // 
            this.googlePlayIco.Image = global::AvrFlasherTool.Properties.Resources.googlePlayIco;
            this.googlePlayIco.Location = new System.Drawing.Point(325, 416);
            this.googlePlayIco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.googlePlayIco.Name = "googlePlayIco";
            this.googlePlayIco.Size = new System.Drawing.Size(60, 62);
            this.googlePlayIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.googlePlayIco.TabIndex = 11;
            this.googlePlayIco.TabStop = false;
            this.toolTipButtons.SetToolTip(this.googlePlayIco, "Go to page in Google Play!");
            this.googlePlayIco.Click += new System.EventHandler(this.googlePlayIco_Click);
            // 
            // yotubeIco
            // 
            this.yotubeIco.Image = global::AvrFlasherTool.Properties.Resources.yotubeico;
            this.yotubeIco.Location = new System.Drawing.Point(158, 416);
            this.yotubeIco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yotubeIco.Name = "yotubeIco";
            this.yotubeIco.Size = new System.Drawing.Size(85, 62);
            this.yotubeIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yotubeIco.TabIndex = 10;
            this.yotubeIco.TabStop = false;
            this.toolTipButtons.SetToolTip(this.yotubeIco, "Go to YouTube channel!");
            this.yotubeIco.Click += new System.EventHandler(this.yotubeIco_Click);
            // 
            // vkIco
            // 
            this.vkIco.Image = global::AvrFlasherTool.Properties.Resources.vkIco;
            this.vkIco.Location = new System.Drawing.Point(249, 416);
            this.vkIco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vkIco.Name = "vkIco";
            this.vkIco.Size = new System.Drawing.Size(70, 62);
            this.vkIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vkIco.TabIndex = 9;
            this.vkIco.TabStop = false;
            this.toolTipButtons.SetToolTip(this.vkIco, "Go to VK account!");
            this.vkIco.Click += new System.EventHandler(this.vkIco_Click);
            // 
            // githubIco
            // 
            this.githubIco.Image = global::AvrFlasherTool.Properties.Resources.githubIco;
            this.githubIco.Location = new System.Drawing.Point(82, 416);
            this.githubIco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.githubIco.Name = "githubIco";
            this.githubIco.Size = new System.Drawing.Size(70, 62);
            this.githubIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.githubIco.TabIndex = 8;
            this.githubIco.TabStop = false;
            this.toolTipButtons.SetToolTip(this.githubIco, "Go to the project page!");
            this.githubIco.Click += new System.EventHandler(this.githubIco_Click);
            // 
            // instIco
            // 
            this.instIco.Image = global::AvrFlasherTool.Properties.Resources.instIco;
            this.instIco.Location = new System.Drawing.Point(6, 416);
            this.instIco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.instIco.Name = "instIco";
            this.instIco.Size = new System.Drawing.Size(70, 62);
            this.instIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.instIco.TabIndex = 7;
            this.instIco.TabStop = false;
            this.toolTipButtons.SetToolTip(this.instIco, "Go to Instagram account!");
            this.instIco.Click += new System.EventHandler(this.instIco_Click);
            // 
            // infoTextBox
            // 
            this.infoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.infoTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.infoTextBox.Location = new System.Drawing.Point(137, 7);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(611, 404);
            this.infoTextBox.TabIndex = 6;
            this.infoTextBox.Text = resources.GetString("infoTextBox.Text");
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::AvrFlasherTool.Properties.Resources.progIco;
            this.pictureBox7.Location = new System.Drawing.Point(6, 122);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(125, 116);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            // 
            // AppsLightCompanyIco
            // 
            this.AppsLightCompanyIco.Image = global::AvrFlasherTool.Properties.Resources.splashScreen;
            this.AppsLightCompanyIco.Location = new System.Drawing.Point(6, 6);
            this.AppsLightCompanyIco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AppsLightCompanyIco.Name = "AppsLightCompanyIco";
            this.AppsLightCompanyIco.Size = new System.Drawing.Size(125, 112);
            this.AppsLightCompanyIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AppsLightCompanyIco.TabIndex = 4;
            this.AppsLightCompanyIco.TabStop = false;
            // 
            // icons
            // 
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "Fuse.png");
            this.icons.Images.SetKeyName(1, "Icon.png");
            this.icons.Images.SetKeyName(2, "Settings.png");
            this.icons.Images.SetKeyName(3, "Info.png");
            this.icons.Images.SetKeyName(4, "Programmer.png");
            this.icons.Images.SetKeyName(5, "MCU Flash.png");
            this.icons.Images.SetKeyName(6, "MCU info.png");
            this.icons.Images.SetKeyName(7, "MCU settings.png");
            this.icons.Images.SetKeyName(8, "Refresh.png");
            this.icons.Images.SetKeyName(9, "MCU Auto.png");
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "*.hex";
            this.openFileDialog.Filter = "Firmware files(*.hex)|*.hex|All files(*.*)|*.*";
            this.openFileDialog.Title = "Open Firmware files...";
            // 
            // toolTipButtons
            // 
            this.toolTipButtons.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButtons.ToolTipTitle = "Write";
            // 
            // deployAvrdude
            // 
            this.deployAvrdude.DoWork += new System.ComponentModel.DoWorkEventHandler(this.deployAvrdude_DoWork);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.progsSearchButton);
            this.groupBox1.Controls.Add(this.progsBox);
            this.groupBox1.Controls.Add(this.progsLabel);
            this.groupBox1.Controls.Add(this.chipsSearchButton);
            this.groupBox1.Controls.Add(this.chipsBox);
            this.groupBox1.Controls.Add(this.chipsLabel);
            this.groupBox1.Controls.Add(this.confSearchButton);
            this.groupBox1.Controls.Add(this.avrdudeSearchButton);
            this.groupBox1.Controls.Add(this.confBox);
            this.groupBox1.Controls.Add(this.confLabel);
            this.groupBox1.Controls.Add(this.avrdudeBox);
            this.groupBox1.Controls.Add(this.avrdudeLabel);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Location = new System.Drawing.Point(10, 111);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(712, 147);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // confSearchButton
            // 
            this.confSearchButton.BackgroundImage = global::AvrFlasherTool.Properties.Resources.Search;
            this.confSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.confSearchButton.FlatAppearance.BorderSize = 0;
            this.confSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confSearchButton.Location = new System.Drawing.Point(680, 55);
            this.confSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confSearchButton.Name = "confSearchButton";
            this.confSearchButton.Size = new System.Drawing.Size(19, 17);
            this.confSearchButton.TabIndex = 9;
            this.confSearchButton.UseVisualStyleBackColor = true;
            this.confSearchButton.Click += new System.EventHandler(this.confSearchButton_Click);
            // 
            // avrdudeSearchButton
            // 
            this.avrdudeSearchButton.BackgroundImage = global::AvrFlasherTool.Properties.Resources.Search;
            this.avrdudeSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.avrdudeSearchButton.FlatAppearance.BorderSize = 0;
            this.avrdudeSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avrdudeSearchButton.Location = new System.Drawing.Point(680, 25);
            this.avrdudeSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avrdudeSearchButton.Name = "avrdudeSearchButton";
            this.avrdudeSearchButton.Size = new System.Drawing.Size(19, 17);
            this.avrdudeSearchButton.TabIndex = 8;
            this.avrdudeSearchButton.UseVisualStyleBackColor = true;
            this.avrdudeSearchButton.Click += new System.EventHandler(this.avrdudeSearchButton_Click);
            // 
            // confBox
            // 
            this.confBox.AllowDrop = true;
            this.confBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.confBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.confBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.confBox.FormattingEnabled = true;
            this.confBox.IntegralHeight = false;
            this.confBox.ItemHeight = 16;
            this.confBox.Location = new System.Drawing.Point(178, 52);
            this.confBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confBox.Name = "confBox";
            this.confBox.Size = new System.Drawing.Size(497, 24);
            this.confBox.TabIndex = 12;
            this.confBox.Text = "Please select a file...";
            this.confBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.confBox_MouseDown);
            // 
            // confLabel
            // 
            this.confLabel.AutoSize = true;
            this.confLabel.BackColor = System.Drawing.Color.Transparent;
            this.confLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.confLabel.Location = new System.Drawing.Point(87, 52);
            this.confLabel.Name = "confLabel";
            this.confLabel.Size = new System.Drawing.Size(79, 23);
            this.confLabel.TabIndex = 11;
            this.confLabel.Text = "Avr conf:";
            // 
            // avrdudeBox
            // 
            this.avrdudeBox.AllowDrop = true;
            this.avrdudeBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.avrdudeBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.avrdudeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avrdudeBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.avrdudeBox.FormattingEnabled = true;
            this.avrdudeBox.IntegralHeight = false;
            this.avrdudeBox.ItemHeight = 16;
            this.avrdudeBox.Location = new System.Drawing.Point(178, 21);
            this.avrdudeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avrdudeBox.Name = "avrdudeBox";
            this.avrdudeBox.Size = new System.Drawing.Size(497, 24);
            this.avrdudeBox.TabIndex = 10;
            this.avrdudeBox.Text = "Please select a file...";
            this.avrdudeBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.avrdudeBox_MouseDown);
            // 
            // avrdudeLabel
            // 
            this.avrdudeLabel.AutoSize = true;
            this.avrdudeLabel.BackColor = System.Drawing.Color.Transparent;
            this.avrdudeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.avrdudeLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.avrdudeLabel.Location = new System.Drawing.Point(87, 22);
            this.avrdudeLabel.Name = "avrdudeLabel";
            this.avrdudeLabel.Size = new System.Drawing.Size(85, 23);
            this.avrdudeLabel.TabIndex = 9;
            this.avrdudeLabel.Text = "AVRdude:";
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(680, 59);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 26);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::AvrFlasherTool.Properties.Resources.FileIco;
            this.pictureBox5.Location = new System.Drawing.Point(0, 20);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(85, 80);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::AvrFlasherTool.Properties.Resources.MCU_settings;
            this.pictureBox8.Location = new System.Drawing.Point(5, 21);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(85, 80);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 4;
            this.pictureBox8.TabStop = false;
            // 
            // generalSettingsGroup
            // 
            this.generalSettingsGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.generalSettingsGroup.Controls.Add(this.pictureBox8);
            this.generalSettingsGroup.Controls.Add(this.label1);
            this.generalSettingsGroup.Controls.Add(this.invertFusesCheck);
            this.generalSettingsGroup.Controls.Add(this.debugModeCheck);
            this.generalSettingsGroup.Controls.Add(this.invertFusesLabel);
            this.generalSettingsGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.generalSettingsGroup.Location = new System.Drawing.Point(10, 6);
            this.generalSettingsGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generalSettingsGroup.Name = "generalSettingsGroup";
            this.generalSettingsGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generalSettingsGroup.Size = new System.Drawing.Size(712, 100);
            this.generalSettingsGroup.TabIndex = 22;
            this.generalSettingsGroup.TabStop = false;
            this.generalSettingsGroup.Text = "General Settings";
            // 
            // chipsSearchButton
            // 
            this.chipsSearchButton.BackgroundImage = global::AvrFlasherTool.Properties.Resources.Search;
            this.chipsSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chipsSearchButton.FlatAppearance.BorderSize = 0;
            this.chipsSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chipsSearchButton.Location = new System.Drawing.Point(680, 86);
            this.chipsSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chipsSearchButton.Name = "chipsSearchButton";
            this.chipsSearchButton.Size = new System.Drawing.Size(19, 17);
            this.chipsSearchButton.TabIndex = 13;
            this.chipsSearchButton.UseVisualStyleBackColor = true;
            this.chipsSearchButton.Click += new System.EventHandler(this.chipsSearchButton_Click);
            // 
            // chipsBox
            // 
            this.chipsBox.AllowDrop = true;
            this.chipsBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.chipsBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.chipsBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chipsBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.chipsBox.FormattingEnabled = true;
            this.chipsBox.IntegralHeight = false;
            this.chipsBox.ItemHeight = 16;
            this.chipsBox.Location = new System.Drawing.Point(178, 83);
            this.chipsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chipsBox.Name = "chipsBox";
            this.chipsBox.Size = new System.Drawing.Size(497, 24);
            this.chipsBox.TabIndex = 15;
            this.chipsBox.Text = "Please select a file...";
            this.chipsBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chipsBox_MouseDown);
            // 
            // chipsLabel
            // 
            this.chipsLabel.AutoSize = true;
            this.chipsLabel.BackColor = System.Drawing.Color.Transparent;
            this.chipsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chipsLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.chipsLabel.Location = new System.Drawing.Point(87, 84);
            this.chipsLabel.Name = "chipsLabel";
            this.chipsLabel.Size = new System.Drawing.Size(85, 23);
            this.chipsLabel.TabIndex = 14;
            this.chipsLabel.Text = "Chips file:";
            // 
            // progsSearchButton
            // 
            this.progsSearchButton.BackgroundImage = global::AvrFlasherTool.Properties.Resources.Search;
            this.progsSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.progsSearchButton.FlatAppearance.BorderSize = 0;
            this.progsSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.progsSearchButton.Location = new System.Drawing.Point(681, 117);
            this.progsSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progsSearchButton.Name = "progsSearchButton";
            this.progsSearchButton.Size = new System.Drawing.Size(19, 17);
            this.progsSearchButton.TabIndex = 16;
            this.progsSearchButton.UseVisualStyleBackColor = true;
            this.progsSearchButton.Click += new System.EventHandler(this.progsSearchButton_Click);
            // 
            // progsBox
            // 
            this.progsBox.AllowDrop = true;
            this.progsBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.progsBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.progsBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.progsBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.progsBox.FormattingEnabled = true;
            this.progsBox.IntegralHeight = false;
            this.progsBox.ItemHeight = 16;
            this.progsBox.Location = new System.Drawing.Point(178, 114);
            this.progsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progsBox.Name = "progsBox";
            this.progsBox.Size = new System.Drawing.Size(497, 24);
            this.progsBox.TabIndex = 18;
            this.progsBox.Text = "Please select a file...";
            this.progsBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progsBox_MouseDown);
            // 
            // progsLabel
            // 
            this.progsLabel.AutoSize = true;
            this.progsLabel.BackColor = System.Drawing.Color.Transparent;
            this.progsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.progsLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.progsLabel.Location = new System.Drawing.Point(87, 115);
            this.progsLabel.Name = "progsLabel";
            this.progsLabel.Size = new System.Drawing.Size(86, 23);
            this.progsLabel.TabIndex = 17;
            this.progsLabel.Text = "Progs file:";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 491);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Welcome!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.MCU.ResumeLayout(false);
            this.filesSelectGroup.ResumeLayout(false);
            this.filesSelectGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.consoleGroup.ResumeLayout(false);
            this.programmerSelectGroup.ResumeLayout(false);
            this.programmerSelectGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.mcuSelectGroup.ResumeLayout(false);
            this.mcuSelectGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.FUSES.ResumeLayout(false);
            this.manualSettingsGroup.ResumeLayout(false);
            this.manualSettingsGroup.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.autoSettingsGroup.ResumeLayout(false);
            this.autoSettingsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.SETTINGS.ResumeLayout(false);
            this.INFO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.googlePlayIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yotubeIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vkIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.githubIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppsLightCompanyIco)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.generalSettingsGroup.ResumeLayout(false);
            this.generalSettingsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MCU;
        private System.Windows.Forms.TabPage SETTINGS;
        private System.Windows.Forms.ImageList icons;
        private System.Windows.Forms.TabPage INFO;
        private System.Windows.Forms.ComboBox MCUSelect;
        private System.Windows.Forms.GroupBox mcuSelectGroup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox programmerSelectGroup;
        private System.Windows.Forms.ComboBox ProgSelect;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox PortSelect;
        private System.Windows.Forms.GroupBox consoleGroup;
        private System.Windows.Forms.Label typeProgLabel;
        private System.Windows.Forms.Label portProgLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button FlashButton;
        private System.Windows.Forms.Button RefreshPortsButton;
        private System.Windows.Forms.RichTextBox ConsoleTextBox;
        private System.Windows.Forms.TabPage FUSES;
        private System.Windows.Forms.GroupBox filesSelectGroup;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label fileWriteLabel;
        private System.Windows.Forms.ComboBox SaveSelect;
        private System.Windows.Forms.Label fileSaveLabel;
        private System.Windows.Forms.ComboBox FileSelect;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.ToolTip toolTipButtons;
        private System.Windows.Forms.CheckBox checkPortBox;
        private System.Windows.Forms.Button SearchWriteFileButton;
        private System.Windows.Forms.Button SearchReadFileButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.ComponentModel.BackgroundWorker deployAvrdude;
        private System.Windows.Forms.CheckBox checkVerboseBox;
        private System.Windows.Forms.Label verboseLogging;
        private System.Windows.Forms.Label forceLabel;
        private System.Windows.Forms.CheckBox checkForceBox;
        private System.Windows.Forms.CheckBox checkEraseBox;
        private System.Windows.Forms.Label eraseChipLabel;
        private System.Windows.Forms.GroupBox manualSettingsGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox ExByteText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox HighByteText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox LowByteText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button readFuseSettings;
        private System.Windows.Forms.RichTextBox ConsoleFuseTextBox;
        private System.Windows.Forms.Button flashFuseButton;
        private System.Windows.Forms.GroupBox autoSettingsGroup;
        private System.Windows.Forms.Label bodLvlLabel;
        private System.Windows.Forms.Label freqLabel;
        private System.Windows.Forms.ComboBox bodLevelBox;
        private System.Windows.Forms.ComboBox freqComboBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox manualSettingsCheck;
        private System.Windows.Forms.ComboBox bootSizeBox;
        private System.Windows.Forms.Label bootSizeLabel;
        private System.Windows.Forms.CheckBox bootCheck;
        private System.Windows.Forms.CheckBox bodenCheck;
        private System.Windows.Forms.CheckBox resetIOCheck;
        private System.Windows.Forms.Label watchdogTimerLabel;
        private System.Windows.Forms.Label spiEnableLabel;
        private System.Windows.Forms.CheckBox eesaveCheck;
        private System.Windows.Forms.CheckBox spiCheck;
        private System.Windows.Forms.CheckBox wdCheck;
        private System.Windows.Forms.Label eesaveEnableLabel;
        public System.Windows.Forms.CheckBox autoSettingsCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox AppsLightCompanyIco;
        private System.Windows.Forms.RichTextBox infoTextBox;
        private System.Windows.Forms.PictureBox googlePlayIco;
        private System.Windows.Forms.PictureBox yotubeIco;
        private System.Windows.Forms.PictureBox vkIco;
        private System.Windows.Forms.PictureBox githubIco;
        private System.Windows.Forms.PictureBox instIco;
        private System.Windows.Forms.CheckBox debugModeCheck;
        private System.Windows.Forms.CheckBox invertFusesCheck;
        private System.Windows.Forms.Label invertFusesLabel;
        private System.Windows.Forms.GroupBox generalSettingsGroup;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button chipsSearchButton;
        private System.Windows.Forms.ComboBox chipsBox;
        private System.Windows.Forms.Label chipsLabel;
        private System.Windows.Forms.Button confSearchButton;
        private System.Windows.Forms.Button avrdudeSearchButton;
        private System.Windows.Forms.ComboBox confBox;
        private System.Windows.Forms.Label confLabel;
        private System.Windows.Forms.ComboBox avrdudeBox;
        private System.Windows.Forms.Label avrdudeLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button progsSearchButton;
        private System.Windows.Forms.ComboBox progsBox;
        private System.Windows.Forms.Label progsLabel;
    }
}

