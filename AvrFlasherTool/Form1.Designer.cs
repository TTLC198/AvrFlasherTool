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
            this.SETTINGS = new System.Windows.Forms.TabPage();
            this.INFO = new System.Windows.Forms.TabPage();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButtons = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.deployAvrdude = new System.ComponentModel.BackgroundWorker();
            this.mcuSettingsIcon = new System.Windows.Forms.PictureBox();
            this.consoleFuseGroup = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fuseFlashButton = new System.Windows.Forms.Button();
            this.manualSettingsCheck = new System.Windows.Forms.CheckBox();
            this.autoSettingsGroup = new System.Windows.Forms.GroupBox();
            this.autoSettingsCheck = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.fuseReadButton = new System.Windows.Forms.Button();
            this.lowByteFuseLabel = new System.Windows.Forms.Label();
            this.lowByteText = new System.Windows.Forms.TextBox();
            this.lowByteLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.highByteText = new System.Windows.Forms.TextBox();
            this.highLabelFuseLabel = new System.Windows.Forms.Label();
            this.highByteLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.extByteText = new System.Windows.Forms.TextBox();
            this.extByteFuseLabel = new System.Windows.Forms.Label();
            this.extByteLabel = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.mcuSettingsIcon)).BeginInit();
            this.consoleFuseGroup.SuspendLayout();
            this.autoSettingsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(-2, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(649, 411);
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
            this.MCU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MCU.Name = "MCU";
            this.MCU.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MCU.Size = new System.Drawing.Size(541, 403);
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
            this.filesSelectGroup.Location = new System.Drawing.Point(4, 178);
            this.filesSelectGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filesSelectGroup.Name = "filesSelectGroup";
            this.filesSelectGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filesSelectGroup.Size = new System.Drawing.Size(534, 81);
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
            this.SearchReadFileButton.Location = new System.Drawing.Point(510, 45);
            this.SearchReadFileButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchReadFileButton.Name = "SearchReadFileButton";
            this.SearchReadFileButton.Size = new System.Drawing.Size(14, 14);
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
            this.SearchWriteFileButton.Location = new System.Drawing.Point(510, 20);
            this.SearchWriteFileButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchWriteFileButton.Name = "SearchWriteFileButton";
            this.SearchWriteFileButton.Size = new System.Drawing.Size(14, 14);
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
            this.SaveSelect.ItemHeight = 13;
            this.SaveSelect.Location = new System.Drawing.Point(110, 42);
            this.SaveSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveSelect.Name = "SaveSelect";
            this.SaveSelect.Size = new System.Drawing.Size(397, 21);
            this.SaveSelect.TabIndex = 12;
            this.SaveSelect.Text = "Please select a file...";
            this.SaveSelect.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SaveSelect_MouseDown);
            // 
            // fileSaveLabel
            // 
            this.fileSaveLabel.AutoSize = true;
            this.fileSaveLabel.BackColor = System.Drawing.Color.Transparent;
            this.fileSaveLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fileSaveLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileSaveLabel.Location = new System.Drawing.Point(65, 42);
            this.fileSaveLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileSaveLabel.Name = "fileSaveLabel";
            this.fileSaveLabel.Size = new System.Drawing.Size(41, 19);
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
            this.FileSelect.ItemHeight = 13;
            this.FileSelect.Location = new System.Drawing.Point(110, 17);
            this.FileSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FileSelect.Name = "FileSelect";
            this.FileSelect.Size = new System.Drawing.Size(397, 21);
            this.FileSelect.TabIndex = 10;
            this.FileSelect.Text = "Please select a file...";
            this.FileSelect.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FileSelect_MouseDown);
            // 
            // fileWriteLabel
            // 
            this.fileWriteLabel.AutoSize = true;
            this.fileWriteLabel.BackColor = System.Drawing.Color.Transparent;
            this.fileWriteLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fileWriteLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileWriteLabel.Location = new System.Drawing.Point(65, 18);
            this.fileWriteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileWriteLabel.Name = "fileWriteLabel";
            this.fileWriteLabel.Size = new System.Drawing.Size(47, 19);
            this.fileWriteLabel.TabIndex = 9;
            this.fileWriteLabel.Text = "Write:";
            // 
            // Search
            // 
            this.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Location = new System.Drawing.Point(510, 48);
            this.Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(20, 21);
            this.Search.TabIndex = 7;
            this.Search.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AvrFlasherTool.Properties.Resources.FileIco;
            this.pictureBox4.Location = new System.Drawing.Point(0, 16);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 65);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // consoleGroup
            // 
            this.consoleGroup.Controls.Add(this.ReadButton);
            this.consoleGroup.Controls.Add(this.ConsoleTextBox);
            this.consoleGroup.Controls.Add(this.FlashButton);
            this.consoleGroup.Location = new System.Drawing.Point(4, 264);
            this.consoleGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.consoleGroup.Name = "consoleGroup";
            this.consoleGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.consoleGroup.Size = new System.Drawing.Size(534, 128);
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
            this.ReadButton.Location = new System.Drawing.Point(481, 75);
            this.ReadButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(49, 53);
            this.ReadButton.TabIndex = 6;
            this.ReadButton.UseVisualStyleBackColor = false;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // ConsoleTextBox
            // 
            this.ConsoleTextBox.Location = new System.Drawing.Point(4, 19);
            this.ConsoleTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConsoleTextBox.Name = "ConsoleTextBox";
            this.ConsoleTextBox.ReadOnly = true;
            this.ConsoleTextBox.Size = new System.Drawing.Size(473, 105);
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
            this.FlashButton.ImageIndex = 5;
            this.FlashButton.Location = new System.Drawing.Point(481, 17);
            this.FlashButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FlashButton.Name = "FlashButton";
            this.FlashButton.Size = new System.Drawing.Size(49, 53);
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
            this.programmerSelectGroup.Location = new System.Drawing.Point(4, 92);
            this.programmerSelectGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.programmerSelectGroup.Name = "programmerSelectGroup";
            this.programmerSelectGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.programmerSelectGroup.Size = new System.Drawing.Size(534, 81);
            this.programmerSelectGroup.TabIndex = 3;
            this.programmerSelectGroup.TabStop = false;
            this.programmerSelectGroup.Text = "Programmer";
            // 
            // checkPortBox
            // 
            this.checkPortBox.AutoSize = true;
            this.checkPortBox.Location = new System.Drawing.Point(510, 51);
            this.checkPortBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkPortBox.Name = "checkPortBox";
            this.checkPortBox.Size = new System.Drawing.Size(15, 14);
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
            this.RefreshPortsButton.Location = new System.Drawing.Point(510, 24);
            this.RefreshPortsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RefreshPortsButton.Name = "RefreshPortsButton";
            this.RefreshPortsButton.Size = new System.Drawing.Size(14, 14);
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
            this.portProgLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portProgLabel.Location = new System.Drawing.Point(65, 46);
            this.portProgLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.portProgLabel.Name = "portProgLabel";
            this.portProgLabel.Size = new System.Drawing.Size(38, 19);
            this.portProgLabel.TabIndex = 6;
            this.portProgLabel.Text = "Port:";
            // 
            // typeProgLabel
            // 
            this.typeProgLabel.AutoSize = true;
            this.typeProgLabel.BackColor = System.Drawing.Color.Transparent;
            this.typeProgLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.typeProgLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeProgLabel.Location = new System.Drawing.Point(65, 19);
            this.typeProgLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeProgLabel.Name = "typeProgLabel";
            this.typeProgLabel.Size = new System.Drawing.Size(41, 19);
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
            this.PortSelect.ItemHeight = 13;
            this.PortSelect.Location = new System.Drawing.Point(110, 48);
            this.PortSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PortSelect.Name = "PortSelect";
            this.PortSelect.Size = new System.Drawing.Size(397, 21);
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
            this.ProgSelect.ItemHeight = 13;
            this.ProgSelect.Location = new System.Drawing.Point(110, 21);
            this.ProgSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProgSelect.Name = "ProgSelect";
            this.ProgSelect.Size = new System.Drawing.Size(397, 21);
            this.ProgSelect.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AvrFlasherTool.Properties.Resources.Programmer;
            this.pictureBox2.Location = new System.Drawing.Point(0, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 69);
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
            this.mcuSelectGroup.Location = new System.Drawing.Point(4, 6);
            this.mcuSelectGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mcuSelectGroup.Name = "mcuSelectGroup";
            this.mcuSelectGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mcuSelectGroup.Size = new System.Drawing.Size(534, 86);
            this.mcuSelectGroup.TabIndex = 2;
            this.mcuSelectGroup.TabStop = false;
            this.mcuSelectGroup.Text = "MCU";
            // 
            // checkEraseBox
            // 
            this.checkEraseBox.AutoSize = true;
            this.checkEraseBox.Checked = true;
            this.checkEraseBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEraseBox.Location = new System.Drawing.Point(510, 50);
            this.checkEraseBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkEraseBox.Name = "checkEraseBox";
            this.checkEraseBox.Size = new System.Drawing.Size(15, 14);
            this.checkEraseBox.TabIndex = 11;
            this.toolTipButtons.SetToolTip(this.checkEraseBox, "Enables extended logging.");
            this.checkEraseBox.UseVisualStyleBackColor = true;
            // 
            // eraseChipLabel
            // 
            this.eraseChipLabel.AutoSize = true;
            this.eraseChipLabel.BackColor = System.Drawing.Color.Transparent;
            this.eraseChipLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eraseChipLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eraseChipLabel.Location = new System.Drawing.Point(338, 45);
            this.eraseChipLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eraseChipLabel.Name = "eraseChipLabel";
            this.eraseChipLabel.Size = new System.Drawing.Size(174, 19);
            this.eraseChipLabel.TabIndex = 10;
            this.eraseChipLabel.Text = "Erase chip(recommended):";
            this.toolTipButtons.SetToolTip(this.eraseChipLabel, "Recommended!");
            // 
            // checkForceBox
            // 
            this.checkForceBox.AutoSize = true;
            this.checkForceBox.Location = new System.Drawing.Point(239, 50);
            this.checkForceBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkForceBox.Name = "checkForceBox";
            this.checkForceBox.Size = new System.Drawing.Size(15, 14);
            this.checkForceBox.TabIndex = 9;
            this.toolTipButtons.SetToolTip(this.checkForceBox, "Enables extended logging.");
            this.checkForceBox.UseVisualStyleBackColor = true;
            // 
            // forceLabel
            // 
            this.forceLabel.AutoSize = true;
            this.forceLabel.BackColor = System.Drawing.Color.Transparent;
            this.forceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.forceLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forceLabel.Location = new System.Drawing.Point(169, 45);
            this.forceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.forceLabel.Name = "forceLabel";
            this.forceLabel.Size = new System.Drawing.Size(72, 19);
            this.forceLabel.TabIndex = 8;
            this.forceLabel.Text = "Force (-F):";
            this.toolTipButtons.SetToolTip(this.forceLabel, "Removes chip signature check");
            // 
            // checkVerboseBox
            // 
            this.checkVerboseBox.AutoSize = true;
            this.checkVerboseBox.Checked = true;
            this.checkVerboseBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkVerboseBox.Location = new System.Drawing.Point(151, 50);
            this.checkVerboseBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkVerboseBox.Name = "checkVerboseBox";
            this.checkVerboseBox.Size = new System.Drawing.Size(15, 14);
            this.checkVerboseBox.TabIndex = 7;
            this.toolTipButtons.SetToolTip(this.checkVerboseBox, "Enables extended logging.");
            this.checkVerboseBox.UseVisualStyleBackColor = true;
            // 
            // verboseLogging
            // 
            this.verboseLogging.AutoSize = true;
            this.verboseLogging.BackColor = System.Drawing.Color.Transparent;
            this.verboseLogging.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.verboseLogging.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.verboseLogging.Location = new System.Drawing.Point(65, 45);
            this.verboseLogging.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.verboseLogging.Name = "verboseLogging";
            this.verboseLogging.Size = new System.Drawing.Size(88, 19);
            this.verboseLogging.TabIndex = 7;
            this.verboseLogging.Text = "Verbose (-v):";
            this.toolTipButtons.SetToolTip(this.verboseLogging, "Enable extended logging");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(65, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
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
            this.MCUSelect.ItemHeight = 13;
            this.MCUSelect.Location = new System.Drawing.Point(110, 15);
            this.MCUSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MCUSelect.Name = "MCUSelect";
            this.MCUSelect.Size = new System.Drawing.Size(412, 21);
            this.MCUSelect.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AvrFlasherTool.Properties.Resources.MCU_info;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FUSES
            // 
            this.FUSES.Controls.Add(this.autoSettingsGroup);
            this.FUSES.Controls.Add(this.consoleFuseGroup);
            this.FUSES.Controls.Add(this.manualSettingsGroup);
            this.FUSES.ImageIndex = 0;
            this.FUSES.Location = new System.Drawing.Point(104, 4);
            this.FUSES.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FUSES.Name = "FUSES";
            this.FUSES.Size = new System.Drawing.Size(541, 403);
            this.FUSES.TabIndex = 3;
            this.FUSES.ToolTipText = "Fuses &&& Lock bites";
            this.FUSES.UseVisualStyleBackColor = true;
            // 
            // manualSettingsGroup
            // 
            this.manualSettingsGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.manualSettingsGroup.Controls.Add(this.extByteLabel);
            this.manualSettingsGroup.Controls.Add(this.panel3);
            this.manualSettingsGroup.Controls.Add(this.highByteLabel);
            this.manualSettingsGroup.Controls.Add(this.panel2);
            this.manualSettingsGroup.Controls.Add(this.panel1);
            this.manualSettingsGroup.Controls.Add(this.lowByteLabel);
            this.manualSettingsGroup.Controls.Add(this.manualSettingsCheck);
            this.manualSettingsGroup.Controls.Add(this.mcuSettingsIcon);
            this.manualSettingsGroup.Location = new System.Drawing.Point(4, 170);
            this.manualSettingsGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manualSettingsGroup.Name = "manualSettingsGroup";
            this.manualSettingsGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manualSettingsGroup.Size = new System.Drawing.Size(534, 90);
            this.manualSettingsGroup.TabIndex = 6;
            this.manualSettingsGroup.TabStop = false;
            this.manualSettingsGroup.Text = "Manual Settings";
            // 
            // SETTINGS
            // 
            this.SETTINGS.ImageIndex = 2;
            this.SETTINGS.Location = new System.Drawing.Point(104, 4);
            this.SETTINGS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SETTINGS.Name = "SETTINGS";
            this.SETTINGS.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SETTINGS.Size = new System.Drawing.Size(541, 403);
            this.SETTINGS.TabIndex = 1;
            this.SETTINGS.ToolTipText = "App Settings";
            this.SETTINGS.UseVisualStyleBackColor = true;
            // 
            // INFO
            // 
            this.INFO.ImageIndex = 3;
            this.INFO.Location = new System.Drawing.Point(104, 4);
            this.INFO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.INFO.Name = "INFO";
            this.INFO.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.INFO.Size = new System.Drawing.Size(541, 403);
            this.INFO.TabIndex = 2;
            this.INFO.ToolTipText = "App Info";
            this.INFO.UseVisualStyleBackColor = true;
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
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.hex";
            this.openFileDialog1.Filter = "Firmware files(*.hex)|*.hex|All files(*.*)|*.*";
            this.openFileDialog1.Title = "Open Firmware files...";
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
            // mcuSettingsIcon
            // 
            this.mcuSettingsIcon.Image = global::AvrFlasherTool.Properties.Resources.MCU_info;
            this.mcuSettingsIcon.Location = new System.Drawing.Point(4, 17);
            this.mcuSettingsIcon.Margin = new System.Windows.Forms.Padding(2);
            this.mcuSettingsIcon.Name = "mcuSettingsIcon";
            this.mcuSettingsIcon.Size = new System.Drawing.Size(64, 65);
            this.mcuSettingsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mcuSettingsIcon.TabIndex = 4;
            this.mcuSettingsIcon.TabStop = false;
            // 
            // consoleFuseGroup
            // 
            this.consoleFuseGroup.Controls.Add(this.fuseReadButton);
            this.consoleFuseGroup.Controls.Add(this.richTextBox1);
            this.consoleFuseGroup.Controls.Add(this.fuseFlashButton);
            this.consoleFuseGroup.Location = new System.Drawing.Point(4, 264);
            this.consoleFuseGroup.Margin = new System.Windows.Forms.Padding(2);
            this.consoleFuseGroup.Name = "consoleFuseGroup";
            this.consoleFuseGroup.Padding = new System.Windows.Forms.Padding(2);
            this.consoleFuseGroup.Size = new System.Drawing.Size(534, 128);
            this.consoleFuseGroup.TabIndex = 7;
            this.consoleFuseGroup.TabStop = false;
            this.consoleFuseGroup.Text = "Console";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(4, 19);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(473, 105);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // fuseFlashButton
            // 
            this.fuseFlashButton.BackColor = System.Drawing.Color.Transparent;
            this.fuseFlashButton.BackgroundImage = global::AvrFlasherTool.Properties.Resources.MCU_Flash;
            this.fuseFlashButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fuseFlashButton.FlatAppearance.BorderSize = 0;
            this.fuseFlashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fuseFlashButton.ImageIndex = 5;
            this.fuseFlashButton.Location = new System.Drawing.Point(481, 17);
            this.fuseFlashButton.Margin = new System.Windows.Forms.Padding(2);
            this.fuseFlashButton.Name = "fuseFlashButton";
            this.fuseFlashButton.Size = new System.Drawing.Size(49, 53);
            this.fuseFlashButton.TabIndex = 0;
            this.fuseFlashButton.UseVisualStyleBackColor = false;
            // 
            // manualSettingsCheck
            // 
            this.manualSettingsCheck.AutoSize = true;
            this.manualSettingsCheck.Location = new System.Drawing.Point(88, 1);
            this.manualSettingsCheck.Name = "manualSettingsCheck";
            this.manualSettingsCheck.Size = new System.Drawing.Size(15, 14);
            this.manualSettingsCheck.TabIndex = 5;
            this.manualSettingsCheck.UseVisualStyleBackColor = true;
            this.manualSettingsCheck.CheckedChanged += new System.EventHandler(this.manualSettingsCheck_CheckedChanged);
            // 
            // autoSettingsGroup
            // 
            this.autoSettingsGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.autoSettingsGroup.Controls.Add(this.autoSettingsCheck);
            this.autoSettingsGroup.Controls.Add(this.pictureBox3);
            this.autoSettingsGroup.Location = new System.Drawing.Point(2, 76);
            this.autoSettingsGroup.Margin = new System.Windows.Forms.Padding(2);
            this.autoSettingsGroup.Name = "autoSettingsGroup";
            this.autoSettingsGroup.Padding = new System.Windows.Forms.Padding(2);
            this.autoSettingsGroup.Size = new System.Drawing.Size(534, 90);
            this.autoSettingsGroup.TabIndex = 8;
            this.autoSettingsGroup.TabStop = false;
            this.autoSettingsGroup.Text = "Auto Settings";
            // 
            // autoSettingsCheck
            // 
            this.autoSettingsCheck.AutoSize = true;
            this.autoSettingsCheck.Location = new System.Drawing.Point(76, 0);
            this.autoSettingsCheck.Name = "autoSettingsCheck";
            this.autoSettingsCheck.Size = new System.Drawing.Size(15, 14);
            this.autoSettingsCheck.TabIndex = 5;
            this.autoSettingsCheck.UseVisualStyleBackColor = true;
            this.autoSettingsCheck.CheckedChanged += new System.EventHandler(this.autoSettingsCheck_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AvrFlasherTool.Properties.Resources.MCU_settings;
            this.pictureBox3.Location = new System.Drawing.Point(4, 17);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // fuseReadButton
            // 
            this.fuseReadButton.BackColor = System.Drawing.Color.Transparent;
            this.fuseReadButton.BackgroundImage = global::AvrFlasherTool.Properties.Resources.Read;
            this.fuseReadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fuseReadButton.FlatAppearance.BorderSize = 0;
            this.fuseReadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fuseReadButton.ImageIndex = 5;
            this.fuseReadButton.Location = new System.Drawing.Point(481, 75);
            this.fuseReadButton.Margin = new System.Windows.Forms.Padding(2);
            this.fuseReadButton.Name = "fuseReadButton";
            this.fuseReadButton.Size = new System.Drawing.Size(49, 53);
            this.fuseReadButton.TabIndex = 6;
            this.fuseReadButton.UseVisualStyleBackColor = false;
            // 
            // lowByteFuseLabel
            // 
            this.lowByteFuseLabel.AutoSize = true;
            this.lowByteFuseLabel.BackColor = System.Drawing.Color.Transparent;
            this.lowByteFuseLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lowByteFuseLabel.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lowByteFuseLabel.Location = new System.Drawing.Point(0, -1);
            this.lowByteFuseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lowByteFuseLabel.Name = "lowByteFuseLabel";
            this.lowByteFuseLabel.Size = new System.Drawing.Size(24, 20);
            this.lowByteFuseLabel.TabIndex = 8;
            this.lowByteFuseLabel.Text = "0x";
            this.toolTipButtons.SetToolTip(this.lowByteFuseLabel, "Enable extended logging");
            // 
            // lowByteText
            // 
            this.lowByteText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lowByteText.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lowByteText.Location = new System.Drawing.Point(19, -1);
            this.lowByteText.Name = "lowByteText";
            this.lowByteText.Size = new System.Drawing.Size(24, 20);
            this.lowByteText.TabIndex = 9;
            // 
            // lowByteLabel
            // 
            this.lowByteLabel.AutoSize = true;
            this.lowByteLabel.BackColor = System.Drawing.Color.Transparent;
            this.lowByteLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lowByteLabel.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lowByteLabel.Location = new System.Drawing.Point(72, 18);
            this.lowByteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lowByteLabel.Name = "lowByteLabel";
            this.lowByteLabel.Size = new System.Drawing.Size(74, 20);
            this.lowByteLabel.TabIndex = 10;
            this.lowByteLabel.Text = "Low Byte:";
            this.toolTipButtons.SetToolTip(this.lowByteLabel, "Enable extended logging");
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lowByteText);
            this.panel1.Controls.Add(this.lowByteFuseLabel);
            this.panel1.Location = new System.Drawing.Point(76, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(44, 20);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.highByteText);
            this.panel2.Controls.Add(this.highLabelFuseLabel);
            this.panel2.Location = new System.Drawing.Point(165, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(44, 20);
            this.panel2.TabIndex = 12;
            // 
            // highByteText
            // 
            this.highByteText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.highByteText.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.highByteText.Location = new System.Drawing.Point(19, -1);
            this.highByteText.Name = "highByteText";
            this.highByteText.Size = new System.Drawing.Size(24, 20);
            this.highByteText.TabIndex = 9;
            // 
            // highLabelFuseLabel
            // 
            this.highLabelFuseLabel.AutoSize = true;
            this.highLabelFuseLabel.BackColor = System.Drawing.Color.Transparent;
            this.highLabelFuseLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.highLabelFuseLabel.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.highLabelFuseLabel.Location = new System.Drawing.Point(0, -1);
            this.highLabelFuseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.highLabelFuseLabel.Name = "highLabelFuseLabel";
            this.highLabelFuseLabel.Size = new System.Drawing.Size(24, 20);
            this.highLabelFuseLabel.TabIndex = 8;
            this.highLabelFuseLabel.Text = "0x";
            this.toolTipButtons.SetToolTip(this.highLabelFuseLabel, "Enable extended logging");
            // 
            // highByteLabel
            // 
            this.highByteLabel.AutoSize = true;
            this.highByteLabel.BackColor = System.Drawing.Color.Transparent;
            this.highByteLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.highByteLabel.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.highByteLabel.Location = new System.Drawing.Point(161, 18);
            this.highByteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.highByteLabel.Name = "highByteLabel";
            this.highByteLabel.Size = new System.Drawing.Size(80, 20);
            this.highByteLabel.TabIndex = 13;
            this.highByteLabel.Text = "High Byte:";
            this.toolTipButtons.SetToolTip(this.highByteLabel, "Enable extended logging");
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.extByteText);
            this.panel3.Controls.Add(this.extByteFuseLabel);
            this.panel3.Location = new System.Drawing.Point(257, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(44, 20);
            this.panel3.TabIndex = 14;
            // 
            // extByteText
            // 
            this.extByteText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.extByteText.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.extByteText.Location = new System.Drawing.Point(19, -1);
            this.extByteText.Name = "extByteText";
            this.extByteText.Size = new System.Drawing.Size(24, 20);
            this.extByteText.TabIndex = 9;
            // 
            // extByteFuseLabel
            // 
            this.extByteFuseLabel.AutoSize = true;
            this.extByteFuseLabel.BackColor = System.Drawing.Color.Transparent;
            this.extByteFuseLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.extByteFuseLabel.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.extByteFuseLabel.Location = new System.Drawing.Point(0, -1);
            this.extByteFuseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.extByteFuseLabel.Name = "extByteFuseLabel";
            this.extByteFuseLabel.Size = new System.Drawing.Size(24, 20);
            this.extByteFuseLabel.TabIndex = 8;
            this.extByteFuseLabel.Text = "0x";
            this.toolTipButtons.SetToolTip(this.extByteFuseLabel, "Enable extended logging");
            // 
            // extByteLabel
            // 
            this.extByteLabel.AutoSize = true;
            this.extByteLabel.BackColor = System.Drawing.Color.Transparent;
            this.extByteLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.extByteLabel.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.extByteLabel.Location = new System.Drawing.Point(258, 18);
            this.extByteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.extByteLabel.Name = "extByteLabel";
            this.extByteLabel.Size = new System.Drawing.Size(68, 20);
            this.extByteLabel.TabIndex = 15;
            this.extByteLabel.Text = "Ext Byte:";
            this.toolTipButtons.SetToolTip(this.extByteLabel, "Enable extended logging");
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 399);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            ((System.ComponentModel.ISupportInitialize)(this.mcuSettingsIcon)).EndInit();
            this.consoleFuseGroup.ResumeLayout(false);
            this.autoSettingsGroup.ResumeLayout(false);
            this.autoSettingsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button FlashButton;
        private System.Windows.Forms.Button RefreshPortsButton;
        private System.Windows.Forms.RichTextBox ConsoleTextBox;
        private System.Windows.Forms.TabPage FUSES;
        private System.Windows.Forms.GroupBox manualSettingsGroup;
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
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.ComponentModel.BackgroundWorker deployAvrdude;
        private System.Windows.Forms.CheckBox checkVerboseBox;
        private System.Windows.Forms.Label verboseLogging;
        private System.Windows.Forms.Label forceLabel;
        private System.Windows.Forms.CheckBox checkForceBox;
        private System.Windows.Forms.CheckBox checkEraseBox;
        private System.Windows.Forms.Label eraseChipLabel;
        private System.Windows.Forms.GroupBox consoleFuseGroup;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button fuseFlashButton;
        private System.Windows.Forms.PictureBox mcuSettingsIcon;
        private System.Windows.Forms.GroupBox autoSettingsGroup;
        private System.Windows.Forms.CheckBox autoSettingsCheck;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox manualSettingsCheck;
        private System.Windows.Forms.Button fuseReadButton;
        private System.Windows.Forms.Label lowByteLabel;
        private System.Windows.Forms.TextBox lowByteText;
        private System.Windows.Forms.Label lowByteFuseLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label highByteLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox highByteText;
        private System.Windows.Forms.Label highLabelFuseLabel;
        private System.Windows.Forms.Label extByteLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox extByteText;
        private System.Windows.Forms.Label extByteFuseLabel;
    }
}

