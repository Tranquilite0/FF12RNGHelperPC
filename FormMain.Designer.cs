namespace FF12RNGHelperPC
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.timerReadMemory = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewDisp = new System.Windows.Forms.DataGridView();
            this.ColumnPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSteal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStealCuffs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnChest1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnChest2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRaw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelSync = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxGeneralSettings = new System.Windows.Forms.GroupBox();
            this.textBoxDisplayCount = new System.Windows.Forms.TextBox();
            this.labelDisplayCount = new System.Windows.Forms.Label();
            this.labelMilliSeconds = new System.Windows.Forms.Label();
            this.textBoxRefreshInterval = new System.Windows.Forms.TextBox();
            this.labelRefreshInterval = new System.Windows.Forms.Label();
            this.groupBoxDisplay = new System.Windows.Forms.GroupBox();
            this.checkBoxDisplayChest2 = new System.Windows.Forms.CheckBox();
            this.checkBoxDisplayChest1 = new System.Windows.Forms.CheckBox();
            this.checkBoxDisplayRawRNG = new System.Windows.Forms.CheckBox();
            this.checkBoxDisplayStealCuff = new System.Windows.Forms.CheckBox();
            this.checkBoxDisplaySteal = new System.Windows.Forms.CheckBox();
            this.checkBoxDisplayPercent = new System.Windows.Forms.CheckBox();
            this.groupBoxSteal = new System.Windows.Forms.GroupBox();
            this.labelAdvanceNormal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonRare = new System.Windows.Forms.RadioButton();
            this.radioButtonUncommon = new System.Windows.Forms.RadioButton();
            this.radioButtonCommon = new System.Windows.Forms.RadioButton();
            this.groupBoxWithCuffs = new System.Windows.Forms.GroupBox();
            this.labelAdvanceCuffs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxRare = new System.Windows.Forms.CheckBox();
            this.checkBoxUncommon = new System.Windows.Forms.CheckBox();
            this.checkBoxCommon = new System.Windows.Forms.CheckBox();
            this.groupBoxChest1 = new System.Windows.Forms.GroupBox();
            this.labelAdvanceChestReward1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelAdvanceSpawnChest1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonDR1Gil = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSpawnChance1 = new System.Windows.Forms.TextBox();
            this.textBoxMaxGil1 = new System.Windows.Forms.TextBox();
            this.radioButtonDR1Item2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSpawnPosition1 = new System.Windows.Forms.TextBox();
            this.textBoxItemChance1 = new System.Windows.Forms.TextBox();
            this.radioButtonDR1Item1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxGilChance1 = new System.Windows.Forms.TextBox();
            this.groupBoxChest2 = new System.Windows.Forms.GroupBox();
            this.labelAdvanceChestReward2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.labelAdvanceSpawnChest2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.radioButtonDR2Gil = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSpawnChance2 = new System.Windows.Forms.TextBox();
            this.textBoxMaxGil2 = new System.Windows.Forms.TextBox();
            this.radioButtonDR2Item2 = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxSpawnPosition2 = new System.Windows.Forms.TextBox();
            this.textBoxItemChance2 = new System.Windows.Forms.TextBox();
            this.radioButtonDR2Item1 = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxGilChance2 = new System.Windows.Forms.TextBox();
            this.groupBoxCombo = new System.Windows.Forms.GroupBox();
            this.labelCombo = new System.Windows.Forms.Label();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisp)).BeginInit();
            this.statusStripMain.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.groupBoxGeneralSettings.SuspendLayout();
            this.groupBoxDisplay.SuspendLayout();
            this.groupBoxSteal.SuspendLayout();
            this.groupBoxWithCuffs.SuspendLayout();
            this.groupBoxChest1.SuspendLayout();
            this.groupBoxChest2.SuspendLayout();
            this.groupBoxCombo.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerReadMemory
            // 
            this.timerReadMemory.Enabled = true;
            this.timerReadMemory.Interval = 120;
            this.timerReadMemory.Tick += new System.EventHandler(this.TimerReadMemory_Tick);
            // 
            // dataGridViewDisp
            // 
            this.dataGridViewDisp.AllowUserToAddRows = false;
            this.dataGridViewDisp.AllowUserToDeleteRows = false;
            this.dataGridViewDisp.AllowUserToOrderColumns = true;
            this.dataGridViewDisp.AllowUserToResizeRows = false;
            this.dataGridViewDisp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewDisp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPercent,
            this.ColumnSteal,
            this.ColumnStealCuffs,
            this.ColumnChest1,
            this.ColumnChest2,
            this.ColumnRaw});
            this.dataGridViewDisp.Location = new System.Drawing.Point(370, 27);
            this.dataGridViewDisp.Name = "dataGridViewDisp";
            this.dataGridViewDisp.ReadOnly = true;
            this.dataGridViewDisp.Size = new System.Drawing.Size(562, 421);
            this.dataGridViewDisp.TabIndex = 8;
            this.dataGridViewDisp.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridViewDisp_CellFormatting);
            // 
            // ColumnPercent
            // 
            this.ColumnPercent.DataPropertyName = "Percent";
            this.ColumnPercent.HeaderText = "%";
            this.ColumnPercent.Name = "ColumnPercent";
            this.ColumnPercent.ReadOnly = true;
            this.ColumnPercent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnPercent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnPercent.ToolTipText = "00-99 representing a %-chance occurance.";
            this.ColumnPercent.Width = 30;
            // 
            // ColumnSteal
            // 
            this.ColumnSteal.DataPropertyName = "StealNormal";
            this.ColumnSteal.HeaderText = "Steal";
            this.ColumnSteal.Name = "ColumnSteal";
            this.ColumnSteal.ReadOnly = true;
            this.ColumnSteal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnSteal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnSteal.ToolTipText = "What you would steal without thiefs cuffs.";
            this.ColumnSteal.Width = 90;
            // 
            // ColumnStealCuffs
            // 
            this.ColumnStealCuffs.DataPropertyName = "StealWithCuffs";
            this.ColumnStealCuffs.HeaderText = "Steal /w Cuffs";
            this.ColumnStealCuffs.Name = "ColumnStealCuffs";
            this.ColumnStealCuffs.ReadOnly = true;
            this.ColumnStealCuffs.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnStealCuffs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnStealCuffs.ToolTipText = "What you would steal with thiefs cuffs.";
            this.ColumnStealCuffs.Width = 150;
            // 
            // ColumnChest1
            // 
            this.ColumnChest1.DataPropertyName = "Chest1";
            this.ColumnChest1.HeaderText = "Contents 1";
            this.ColumnChest1.Name = "ColumnChest1";
            this.ColumnChest1.ReadOnly = true;
            this.ColumnChest1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnChest1.Width = 80;
            // 
            // ColumnChest2
            // 
            this.ColumnChest2.DataPropertyName = "Chest2";
            this.ColumnChest2.HeaderText = "Contents 2";
            this.ColumnChest2.Name = "ColumnChest2";
            this.ColumnChest2.ReadOnly = true;
            this.ColumnChest2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnChest2.Width = 80;
            // 
            // ColumnRaw
            // 
            this.ColumnRaw.DataPropertyName = "RawRNG";
            this.ColumnRaw.HeaderText = "Raw RNG";
            this.ColumnRaw.Name = "ColumnRaw";
            this.ColumnRaw.ReadOnly = true;
            this.ColumnRaw.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnRaw.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnRaw.ToolTipText = "Raw number produced by RNG.";
            this.ColumnRaw.Width = 70;
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelSync});
            this.statusStripMain.Location = new System.Drawing.Point(0, 451);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(944, 22);
            this.statusStripMain.TabIndex = 9;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabelSync
            // 
            this.toolStripStatusLabelSync.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabelSync.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripStatusLabelSync.Name = "toolStripStatusLabelSync";
            this.toolStripStatusLabelSync.Size = new System.Drawing.Size(149, 22);
            this.toolStripStatusLabelSync.Text = "Waiting for Game to load...";
            this.toolStripStatusLabelSync.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(944, 24);
            this.menuStripMain.TabIndex = 10;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // groupBoxGeneralSettings
            // 
            this.groupBoxGeneralSettings.Controls.Add(this.textBoxDisplayCount);
            this.groupBoxGeneralSettings.Controls.Add(this.labelDisplayCount);
            this.groupBoxGeneralSettings.Controls.Add(this.labelMilliSeconds);
            this.groupBoxGeneralSettings.Controls.Add(this.textBoxRefreshInterval);
            this.groupBoxGeneralSettings.Controls.Add(this.labelRefreshInterval);
            this.groupBoxGeneralSettings.Location = new System.Drawing.Point(13, 28);
            this.groupBoxGeneralSettings.Name = "groupBoxGeneralSettings";
            this.groupBoxGeneralSettings.Size = new System.Drawing.Size(169, 74);
            this.groupBoxGeneralSettings.TabIndex = 11;
            this.groupBoxGeneralSettings.TabStop = false;
            this.groupBoxGeneralSettings.Text = "General Settings";
            // 
            // textBoxDisplayCount
            // 
            this.textBoxDisplayCount.Location = new System.Drawing.Point(89, 46);
            this.textBoxDisplayCount.MaxLength = 6;
            this.textBoxDisplayCount.Name = "textBoxDisplayCount";
            this.textBoxDisplayCount.Size = new System.Drawing.Size(69, 20);
            this.textBoxDisplayCount.TabIndex = 4;
            this.textBoxDisplayCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDisplayCount.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxDisplayCount_Validating);
            // 
            // labelDisplayCount
            // 
            this.labelDisplayCount.AutoSize = true;
            this.labelDisplayCount.Location = new System.Drawing.Point(6, 49);
            this.labelDisplayCount.Name = "labelDisplayCount";
            this.labelDisplayCount.Size = new System.Drawing.Size(78, 13);
            this.labelDisplayCount.TabIndex = 3;
            this.labelDisplayCount.Text = "Num to Display";
            // 
            // labelMilliSeconds
            // 
            this.labelMilliSeconds.AutoSize = true;
            this.labelMilliSeconds.Location = new System.Drawing.Point(138, 22);
            this.labelMilliSeconds.Name = "labelMilliSeconds";
            this.labelMilliSeconds.Size = new System.Drawing.Size(20, 13);
            this.labelMilliSeconds.TabIndex = 2;
            this.labelMilliSeconds.Text = "ms";
            // 
            // textBoxRefreshInterval
            // 
            this.textBoxRefreshInterval.Location = new System.Drawing.Point(89, 19);
            this.textBoxRefreshInterval.MaxLength = 5;
            this.textBoxRefreshInterval.Name = "textBoxRefreshInterval";
            this.textBoxRefreshInterval.Size = new System.Drawing.Size(43, 20);
            this.textBoxRefreshInterval.TabIndex = 1;
            this.textBoxRefreshInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxRefreshInterval.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxRefreshInterval_Validating);
            // 
            // labelRefreshInterval
            // 
            this.labelRefreshInterval.AutoSize = true;
            this.labelRefreshInterval.Location = new System.Drawing.Point(6, 22);
            this.labelRefreshInterval.Name = "labelRefreshInterval";
            this.labelRefreshInterval.Size = new System.Drawing.Size(82, 13);
            this.labelRefreshInterval.TabIndex = 0;
            this.labelRefreshInterval.Text = "Refresh Interval";
            // 
            // groupBoxDisplay
            // 
            this.groupBoxDisplay.Controls.Add(this.checkBoxDisplayChest2);
            this.groupBoxDisplay.Controls.Add(this.checkBoxDisplayChest1);
            this.groupBoxDisplay.Controls.Add(this.checkBoxDisplayRawRNG);
            this.groupBoxDisplay.Controls.Add(this.checkBoxDisplayStealCuff);
            this.groupBoxDisplay.Controls.Add(this.checkBoxDisplaySteal);
            this.groupBoxDisplay.Controls.Add(this.checkBoxDisplayPercent);
            this.groupBoxDisplay.Location = new System.Drawing.Point(12, 108);
            this.groupBoxDisplay.Name = "groupBoxDisplay";
            this.groupBoxDisplay.Size = new System.Drawing.Size(170, 92);
            this.groupBoxDisplay.TabIndex = 12;
            this.groupBoxDisplay.TabStop = false;
            this.groupBoxDisplay.Text = "Display";
            // 
            // checkBoxDisplayChest2
            // 
            this.checkBoxDisplayChest2.AutoSize = true;
            this.checkBoxDisplayChest2.Checked = true;
            this.checkBoxDisplayChest2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDisplayChest2.Location = new System.Drawing.Point(77, 66);
            this.checkBoxDisplayChest2.Name = "checkBoxDisplayChest2";
            this.checkBoxDisplayChest2.Size = new System.Drawing.Size(62, 17);
            this.checkBoxDisplayChest2.TabIndex = 5;
            this.checkBoxDisplayChest2.Text = "Chest 2";
            this.checkBoxDisplayChest2.UseVisualStyleBackColor = true;
            this.checkBoxDisplayChest2.CheckedChanged += new System.EventHandler(this.CheckBoxDisplay_CheckedChanged);
            // 
            // checkBoxDisplayChest1
            // 
            this.checkBoxDisplayChest1.AutoSize = true;
            this.checkBoxDisplayChest1.Checked = true;
            this.checkBoxDisplayChest1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDisplayChest1.Location = new System.Drawing.Point(9, 66);
            this.checkBoxDisplayChest1.Name = "checkBoxDisplayChest1";
            this.checkBoxDisplayChest1.Size = new System.Drawing.Size(62, 17);
            this.checkBoxDisplayChest1.TabIndex = 4;
            this.checkBoxDisplayChest1.Text = "Chest 1";
            this.checkBoxDisplayChest1.UseVisualStyleBackColor = true;
            this.checkBoxDisplayChest1.CheckedChanged += new System.EventHandler(this.CheckBoxDisplay_CheckedChanged);
            // 
            // checkBoxDisplayRawRNG
            // 
            this.checkBoxDisplayRawRNG.AutoSize = true;
            this.checkBoxDisplayRawRNG.Checked = true;
            this.checkBoxDisplayRawRNG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDisplayRawRNG.Location = new System.Drawing.Point(77, 19);
            this.checkBoxDisplayRawRNG.Name = "checkBoxDisplayRawRNG";
            this.checkBoxDisplayRawRNG.Size = new System.Drawing.Size(75, 17);
            this.checkBoxDisplayRawRNG.TabIndex = 3;
            this.checkBoxDisplayRawRNG.Text = "Raw RNG";
            this.checkBoxDisplayRawRNG.UseVisualStyleBackColor = true;
            this.checkBoxDisplayRawRNG.CheckedChanged += new System.EventHandler(this.CheckBoxDisplay_CheckedChanged);
            // 
            // checkBoxDisplayStealCuff
            // 
            this.checkBoxDisplayStealCuff.AutoSize = true;
            this.checkBoxDisplayStealCuff.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDisplayStealCuff.Checked = true;
            this.checkBoxDisplayStealCuff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDisplayStealCuff.Location = new System.Drawing.Point(77, 43);
            this.checkBoxDisplayStealCuff.Name = "checkBoxDisplayStealCuff";
            this.checkBoxDisplayStealCuff.Size = new System.Drawing.Size(93, 17);
            this.checkBoxDisplayStealCuff.TabIndex = 2;
            this.checkBoxDisplayStealCuff.Text = "Steal /w Cuffs";
            this.checkBoxDisplayStealCuff.UseVisualStyleBackColor = false;
            this.checkBoxDisplayStealCuff.CheckedChanged += new System.EventHandler(this.CheckBoxDisplay_CheckedChanged);
            // 
            // checkBoxDisplaySteal
            // 
            this.checkBoxDisplaySteal.AutoSize = true;
            this.checkBoxDisplaySteal.Checked = true;
            this.checkBoxDisplaySteal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDisplaySteal.Location = new System.Drawing.Point(9, 43);
            this.checkBoxDisplaySteal.Name = "checkBoxDisplaySteal";
            this.checkBoxDisplaySteal.Size = new System.Drawing.Size(50, 17);
            this.checkBoxDisplaySteal.TabIndex = 1;
            this.checkBoxDisplaySteal.Text = "Steal";
            this.checkBoxDisplaySteal.UseVisualStyleBackColor = true;
            this.checkBoxDisplaySteal.CheckedChanged += new System.EventHandler(this.CheckBoxDisplay_CheckedChanged);
            // 
            // checkBoxDisplayPercent
            // 
            this.checkBoxDisplayPercent.AutoSize = true;
            this.checkBoxDisplayPercent.Checked = true;
            this.checkBoxDisplayPercent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDisplayPercent.Location = new System.Drawing.Point(9, 20);
            this.checkBoxDisplayPercent.Name = "checkBoxDisplayPercent";
            this.checkBoxDisplayPercent.Size = new System.Drawing.Size(34, 17);
            this.checkBoxDisplayPercent.TabIndex = 0;
            this.checkBoxDisplayPercent.Text = "%";
            this.checkBoxDisplayPercent.UseVisualStyleBackColor = true;
            this.checkBoxDisplayPercent.CheckedChanged += new System.EventHandler(this.CheckBoxDisplay_CheckedChanged);
            // 
            // groupBoxSteal
            // 
            this.groupBoxSteal.Controls.Add(this.labelAdvanceNormal);
            this.groupBoxSteal.Controls.Add(this.label1);
            this.groupBoxSteal.Controls.Add(this.radioButtonRare);
            this.groupBoxSteal.Controls.Add(this.radioButtonUncommon);
            this.groupBoxSteal.Controls.Add(this.radioButtonCommon);
            this.groupBoxSteal.Location = new System.Drawing.Point(188, 28);
            this.groupBoxSteal.Name = "groupBoxSteal";
            this.groupBoxSteal.Size = new System.Drawing.Size(86, 129);
            this.groupBoxSteal.TabIndex = 13;
            this.groupBoxSteal.TabStop = false;
            this.groupBoxSteal.Text = "Normal";
            // 
            // labelAdvanceNormal
            // 
            this.labelAdvanceNormal.AutoSize = true;
            this.labelAdvanceNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdvanceNormal.Location = new System.Drawing.Point(6, 105);
            this.labelAdvanceNormal.Name = "labelAdvanceNormal";
            this.labelAdvanceNormal.Size = new System.Drawing.Size(66, 15);
            this.labelAdvanceNormal.TabIndex = 4;
            this.labelAdvanceNormal.Text = "Unknown";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(0, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Advance to Get:";
            // 
            // radioButtonRare
            // 
            this.radioButtonRare.AutoSize = true;
            this.radioButtonRare.Checked = true;
            this.radioButtonRare.Location = new System.Drawing.Point(7, 68);
            this.radioButtonRare.Name = "radioButtonRare";
            this.radioButtonRare.Size = new System.Drawing.Size(48, 17);
            this.radioButtonRare.TabIndex = 2;
            this.radioButtonRare.TabStop = true;
            this.radioButtonRare.Text = "Rare";
            this.radioButtonRare.UseVisualStyleBackColor = true;
            this.radioButtonRare.CheckedChanged += new System.EventHandler(this.RadioButtonSteal_CheckedChanged);
            // 
            // radioButtonUncommon
            // 
            this.radioButtonUncommon.AutoSize = true;
            this.radioButtonUncommon.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonUncommon.Location = new System.Drawing.Point(7, 44);
            this.radioButtonUncommon.Name = "radioButtonUncommon";
            this.radioButtonUncommon.Size = new System.Drawing.Size(79, 17);
            this.radioButtonUncommon.TabIndex = 1;
            this.radioButtonUncommon.Text = "Uncommon";
            this.radioButtonUncommon.UseVisualStyleBackColor = false;
            this.radioButtonUncommon.CheckedChanged += new System.EventHandler(this.RadioButtonSteal_CheckedChanged);
            // 
            // radioButtonCommon
            // 
            this.radioButtonCommon.AutoSize = true;
            this.radioButtonCommon.Location = new System.Drawing.Point(7, 20);
            this.radioButtonCommon.Name = "radioButtonCommon";
            this.radioButtonCommon.Size = new System.Drawing.Size(66, 17);
            this.radioButtonCommon.TabIndex = 0;
            this.radioButtonCommon.Text = "Common";
            this.radioButtonCommon.UseVisualStyleBackColor = true;
            this.radioButtonCommon.CheckedChanged += new System.EventHandler(this.RadioButtonSteal_CheckedChanged);
            // 
            // groupBoxWithCuffs
            // 
            this.groupBoxWithCuffs.Controls.Add(this.labelAdvanceCuffs);
            this.groupBoxWithCuffs.Controls.Add(this.label2);
            this.groupBoxWithCuffs.Controls.Add(this.checkBoxRare);
            this.groupBoxWithCuffs.Controls.Add(this.checkBoxUncommon);
            this.groupBoxWithCuffs.Controls.Add(this.checkBoxCommon);
            this.groupBoxWithCuffs.Location = new System.Drawing.Point(279, 28);
            this.groupBoxWithCuffs.Name = "groupBoxWithCuffs";
            this.groupBoxWithCuffs.Size = new System.Drawing.Size(86, 129);
            this.groupBoxWithCuffs.TabIndex = 14;
            this.groupBoxWithCuffs.TabStop = false;
            this.groupBoxWithCuffs.Text = "With Cuffs";
            // 
            // labelAdvanceCuffs
            // 
            this.labelAdvanceCuffs.AutoSize = true;
            this.labelAdvanceCuffs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdvanceCuffs.Location = new System.Drawing.Point(6, 105);
            this.labelAdvanceCuffs.Name = "labelAdvanceCuffs";
            this.labelAdvanceCuffs.Size = new System.Drawing.Size(66, 15);
            this.labelAdvanceCuffs.TabIndex = 5;
            this.labelAdvanceCuffs.Text = "Unknown";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(0, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Advance to Get:";
            // 
            // checkBoxRare
            // 
            this.checkBoxRare.AutoSize = true;
            this.checkBoxRare.Checked = true;
            this.checkBoxRare.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRare.Location = new System.Drawing.Point(7, 68);
            this.checkBoxRare.Name = "checkBoxRare";
            this.checkBoxRare.Size = new System.Drawing.Size(49, 17);
            this.checkBoxRare.TabIndex = 2;
            this.checkBoxRare.Text = "Rare";
            this.checkBoxRare.UseVisualStyleBackColor = true;
            this.checkBoxRare.CheckedChanged += new System.EventHandler(this.CheckBoxStealCuffs_CheckedChanged);
            // 
            // checkBoxUncommon
            // 
            this.checkBoxUncommon.AutoSize = true;
            this.checkBoxUncommon.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxUncommon.Location = new System.Drawing.Point(7, 44);
            this.checkBoxUncommon.Name = "checkBoxUncommon";
            this.checkBoxUncommon.Size = new System.Drawing.Size(80, 17);
            this.checkBoxUncommon.TabIndex = 1;
            this.checkBoxUncommon.Text = "Uncommon";
            this.checkBoxUncommon.UseVisualStyleBackColor = false;
            this.checkBoxUncommon.CheckedChanged += new System.EventHandler(this.CheckBoxStealCuffs_CheckedChanged);
            // 
            // checkBoxCommon
            // 
            this.checkBoxCommon.AutoSize = true;
            this.checkBoxCommon.Location = new System.Drawing.Point(7, 20);
            this.checkBoxCommon.Name = "checkBoxCommon";
            this.checkBoxCommon.Size = new System.Drawing.Size(67, 17);
            this.checkBoxCommon.TabIndex = 0;
            this.checkBoxCommon.Text = "Common";
            this.checkBoxCommon.UseVisualStyleBackColor = true;
            this.checkBoxCommon.CheckedChanged += new System.EventHandler(this.CheckBoxStealCuffs_CheckedChanged);
            // 
            // groupBoxChest1
            // 
            this.groupBoxChest1.Controls.Add(this.labelAdvanceChestReward1);
            this.groupBoxChest1.Controls.Add(this.label16);
            this.groupBoxChest1.Controls.Add(this.label15);
            this.groupBoxChest1.Controls.Add(this.labelAdvanceSpawnChest1);
            this.groupBoxChest1.Controls.Add(this.label8);
            this.groupBoxChest1.Controls.Add(this.label3);
            this.groupBoxChest1.Controls.Add(this.label4);
            this.groupBoxChest1.Controls.Add(this.radioButtonDR1Gil);
            this.groupBoxChest1.Controls.Add(this.label5);
            this.groupBoxChest1.Controls.Add(this.textBoxSpawnChance1);
            this.groupBoxChest1.Controls.Add(this.textBoxMaxGil1);
            this.groupBoxChest1.Controls.Add(this.radioButtonDR1Item2);
            this.groupBoxChest1.Controls.Add(this.label6);
            this.groupBoxChest1.Controls.Add(this.textBoxSpawnPosition1);
            this.groupBoxChest1.Controls.Add(this.textBoxItemChance1);
            this.groupBoxChest1.Controls.Add(this.radioButtonDR1Item1);
            this.groupBoxChest1.Controls.Add(this.label7);
            this.groupBoxChest1.Controls.Add(this.textBoxGilChance1);
            this.groupBoxChest1.Location = new System.Drawing.Point(13, 206);
            this.groupBoxChest1.Name = "groupBoxChest1";
            this.groupBoxChest1.Size = new System.Drawing.Size(169, 239);
            this.groupBoxChest1.TabIndex = 15;
            this.groupBoxChest1.TabStop = false;
            this.groupBoxChest1.Text = "Chest 1";
            // 
            // labelAdvanceChestReward1
            // 
            this.labelAdvanceChestReward1.AutoSize = true;
            this.labelAdvanceChestReward1.BackColor = System.Drawing.Color.Transparent;
            this.labelAdvanceChestReward1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdvanceChestReward1.Location = new System.Drawing.Point(108, 216);
            this.labelAdvanceChestReward1.Name = "labelAdvanceChestReward1";
            this.labelAdvanceChestReward1.Size = new System.Drawing.Size(60, 13);
            this.labelAdvanceChestReward1.TabIndex = 17;
            this.labelAdvanceChestReward1.Text = "Unknown";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(4, 216);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Advance for Result: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(4, 194);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Advance to Spawn: ";
            // 
            // labelAdvanceSpawnChest1
            // 
            this.labelAdvanceSpawnChest1.AutoSize = true;
            this.labelAdvanceSpawnChest1.BackColor = System.Drawing.Color.Transparent;
            this.labelAdvanceSpawnChest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdvanceSpawnChest1.Location = new System.Drawing.Point(108, 194);
            this.labelAdvanceSpawnChest1.Name = "labelAdvanceSpawnChest1";
            this.labelAdvanceSpawnChest1.Size = new System.Drawing.Size(60, 13);
            this.labelAdvanceSpawnChest1.TabIndex = 14;
            this.labelAdvanceSpawnChest1.Text = "Unknown";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Desired Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Spawn Chance";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Spawn Position";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // radioButtonDR1Gil
            // 
            this.radioButtonDR1Gil.AutoSize = true;
            this.radioButtonDR1Gil.Location = new System.Drawing.Point(119, 170);
            this.radioButtonDR1Gil.Name = "radioButtonDR1Gil";
            this.radioButtonDR1Gil.Size = new System.Drawing.Size(37, 17);
            this.radioButtonDR1Gil.TabIndex = 12;
            this.radioButtonDR1Gil.TabStop = true;
            this.radioButtonDR1Gil.Text = "Gil";
            this.radioButtonDR1Gil.UseVisualStyleBackColor = true;
            this.radioButtonDR1Gil.CheckedChanged += new System.EventHandler(this.RadioButtonDR1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gil Chance";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxSpawnChance1
            // 
            this.textBoxSpawnChance1.Location = new System.Drawing.Point(93, 13);
            this.textBoxSpawnChance1.Name = "textBoxSpawnChance1";
            this.textBoxSpawnChance1.Size = new System.Drawing.Size(58, 20);
            this.textBoxSpawnChance1.TabIndex = 1;
            this.textBoxSpawnChance1.Text = "50";
            this.textBoxSpawnChance1.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxSpawnChance1_Validating);
            // 
            // textBoxMaxGil1
            // 
            this.textBoxMaxGil1.Location = new System.Drawing.Point(93, 117);
            this.textBoxMaxGil1.Name = "textBoxMaxGil1";
            this.textBoxMaxGil1.Size = new System.Drawing.Size(58, 20);
            this.textBoxMaxGil1.TabIndex = 5;
            this.textBoxMaxGil1.Text = "100";
            this.textBoxMaxGil1.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxMaxGil1_Validating);
            // 
            // radioButtonDR1Item2
            // 
            this.radioButtonDR1Item2.AutoSize = true;
            this.radioButtonDR1Item2.Checked = true;
            this.radioButtonDR1Item2.Location = new System.Drawing.Point(63, 170);
            this.radioButtonDR1Item2.Name = "radioButtonDR1Item2";
            this.radioButtonDR1Item2.Size = new System.Drawing.Size(54, 17);
            this.radioButtonDR1Item2.TabIndex = 11;
            this.radioButtonDR1Item2.TabStop = true;
            this.radioButtonDR1Item2.Text = "Item 2";
            this.radioButtonDR1Item2.UseVisualStyleBackColor = true;
            this.radioButtonDR1Item2.CheckedChanged += new System.EventHandler(this.RadioButtonDR1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Item 1 Chance";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxSpawnPosition1
            // 
            this.textBoxSpawnPosition1.Location = new System.Drawing.Point(93, 39);
            this.textBoxSpawnPosition1.Name = "textBoxSpawnPosition1";
            this.textBoxSpawnPosition1.Size = new System.Drawing.Size(58, 20);
            this.textBoxSpawnPosition1.TabIndex = 2;
            this.textBoxSpawnPosition1.Text = "1";
            this.textBoxSpawnPosition1.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxSpawnPosition1_Validating);
            // 
            // textBoxItemChance1
            // 
            this.textBoxItemChance1.Location = new System.Drawing.Point(93, 91);
            this.textBoxItemChance1.Name = "textBoxItemChance1";
            this.textBoxItemChance1.Size = new System.Drawing.Size(58, 20);
            this.textBoxItemChance1.TabIndex = 4;
            this.textBoxItemChance1.Text = "50";
            this.textBoxItemChance1.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxItemChance1_Validating);
            // 
            // radioButtonDR1Item1
            // 
            this.radioButtonDR1Item1.AutoSize = true;
            this.radioButtonDR1Item1.Location = new System.Drawing.Point(7, 170);
            this.radioButtonDR1Item1.Name = "radioButtonDR1Item1";
            this.radioButtonDR1Item1.Size = new System.Drawing.Size(54, 17);
            this.radioButtonDR1Item1.TabIndex = 10;
            this.radioButtonDR1Item1.TabStop = true;
            this.radioButtonDR1Item1.Text = "Item 1";
            this.radioButtonDR1Item1.UseVisualStyleBackColor = true;
            this.radioButtonDR1Item1.CheckedChanged += new System.EventHandler(this.RadioButtonDR1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Max Gil Amount";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxGilChance1
            // 
            this.textBoxGilChance1.Location = new System.Drawing.Point(93, 65);
            this.textBoxGilChance1.Name = "textBoxGilChance1";
            this.textBoxGilChance1.Size = new System.Drawing.Size(58, 20);
            this.textBoxGilChance1.TabIndex = 3;
            this.textBoxGilChance1.Text = "50";
            this.textBoxGilChance1.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxGilChance1_Validating);
            // 
            // groupBoxChest2
            // 
            this.groupBoxChest2.Controls.Add(this.labelAdvanceChestReward2);
            this.groupBoxChest2.Controls.Add(this.label9);
            this.groupBoxChest2.Controls.Add(this.label18);
            this.groupBoxChest2.Controls.Add(this.label10);
            this.groupBoxChest2.Controls.Add(this.label19);
            this.groupBoxChest2.Controls.Add(this.labelAdvanceSpawnChest2);
            this.groupBoxChest2.Controls.Add(this.label11);
            this.groupBoxChest2.Controls.Add(this.radioButtonDR2Gil);
            this.groupBoxChest2.Controls.Add(this.label12);
            this.groupBoxChest2.Controls.Add(this.textBoxSpawnChance2);
            this.groupBoxChest2.Controls.Add(this.textBoxMaxGil2);
            this.groupBoxChest2.Controls.Add(this.radioButtonDR2Item2);
            this.groupBoxChest2.Controls.Add(this.label13);
            this.groupBoxChest2.Controls.Add(this.textBoxSpawnPosition2);
            this.groupBoxChest2.Controls.Add(this.textBoxItemChance2);
            this.groupBoxChest2.Controls.Add(this.radioButtonDR2Item1);
            this.groupBoxChest2.Controls.Add(this.label14);
            this.groupBoxChest2.Controls.Add(this.textBoxGilChance2);
            this.groupBoxChest2.Location = new System.Drawing.Point(188, 206);
            this.groupBoxChest2.Name = "groupBoxChest2";
            this.groupBoxChest2.Size = new System.Drawing.Size(175, 239);
            this.groupBoxChest2.TabIndex = 16;
            this.groupBoxChest2.TabStop = false;
            this.groupBoxChest2.Text = "Chest 2";
            // 
            // labelAdvanceChestReward2
            // 
            this.labelAdvanceChestReward2.AutoSize = true;
            this.labelAdvanceChestReward2.BackColor = System.Drawing.Color.Transparent;
            this.labelAdvanceChestReward2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdvanceChestReward2.Location = new System.Drawing.Point(108, 216);
            this.labelAdvanceChestReward2.Name = "labelAdvanceChestReward2";
            this.labelAdvanceChestReward2.Size = new System.Drawing.Size(60, 13);
            this.labelAdvanceChestReward2.TabIndex = 21;
            this.labelAdvanceChestReward2.Text = "Unknown";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Desired Result";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(6, 216);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "Advance for Result: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Spawn Chance";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(6, 194);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "Advance to Spawn: ";
            // 
            // labelAdvanceSpawnChest2
            // 
            this.labelAdvanceSpawnChest2.AutoSize = true;
            this.labelAdvanceSpawnChest2.BackColor = System.Drawing.Color.Transparent;
            this.labelAdvanceSpawnChest2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdvanceSpawnChest2.Location = new System.Drawing.Point(108, 194);
            this.labelAdvanceSpawnChest2.Name = "labelAdvanceSpawnChest2";
            this.labelAdvanceSpawnChest2.Size = new System.Drawing.Size(60, 13);
            this.labelAdvanceSpawnChest2.TabIndex = 18;
            this.labelAdvanceSpawnChest2.Text = "Unknown";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Spawn Position";
            // 
            // radioButtonDR2Gil
            // 
            this.radioButtonDR2Gil.AutoSize = true;
            this.radioButtonDR2Gil.Location = new System.Drawing.Point(118, 170);
            this.radioButtonDR2Gil.Name = "radioButtonDR2Gil";
            this.radioButtonDR2Gil.Size = new System.Drawing.Size(37, 17);
            this.radioButtonDR2Gil.TabIndex = 12;
            this.radioButtonDR2Gil.TabStop = true;
            this.radioButtonDR2Gil.Text = "Gil";
            this.radioButtonDR2Gil.UseVisualStyleBackColor = true;
            this.radioButtonDR2Gil.CheckedChanged += new System.EventHandler(this.RadioButtonDR2_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Gil Chance";
            // 
            // textBoxSpawnChance2
            // 
            this.textBoxSpawnChance2.Location = new System.Drawing.Point(91, 13);
            this.textBoxSpawnChance2.Name = "textBoxSpawnChance2";
            this.textBoxSpawnChance2.Size = new System.Drawing.Size(58, 20);
            this.textBoxSpawnChance2.TabIndex = 1;
            this.textBoxSpawnChance2.Text = "50";
            this.textBoxSpawnChance2.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxSpawnChance2_Validating);
            // 
            // textBoxMaxGil2
            // 
            this.textBoxMaxGil2.Location = new System.Drawing.Point(91, 117);
            this.textBoxMaxGil2.Name = "textBoxMaxGil2";
            this.textBoxMaxGil2.Size = new System.Drawing.Size(58, 20);
            this.textBoxMaxGil2.TabIndex = 5;
            this.textBoxMaxGil2.Text = "100";
            this.textBoxMaxGil2.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxMaxGil2_Validating);
            // 
            // radioButtonDR2Item2
            // 
            this.radioButtonDR2Item2.AutoSize = true;
            this.radioButtonDR2Item2.Checked = true;
            this.radioButtonDR2Item2.Location = new System.Drawing.Point(62, 170);
            this.radioButtonDR2Item2.Name = "radioButtonDR2Item2";
            this.radioButtonDR2Item2.Size = new System.Drawing.Size(54, 17);
            this.radioButtonDR2Item2.TabIndex = 11;
            this.radioButtonDR2Item2.TabStop = true;
            this.radioButtonDR2Item2.Text = "Item 2";
            this.radioButtonDR2Item2.UseVisualStyleBackColor = true;
            this.radioButtonDR2Item2.CheckedChanged += new System.EventHandler(this.RadioButtonDR2_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Item 1 Chance";
            // 
            // textBoxSpawnPosition2
            // 
            this.textBoxSpawnPosition2.Location = new System.Drawing.Point(91, 39);
            this.textBoxSpawnPosition2.Name = "textBoxSpawnPosition2";
            this.textBoxSpawnPosition2.Size = new System.Drawing.Size(58, 20);
            this.textBoxSpawnPosition2.TabIndex = 2;
            this.textBoxSpawnPosition2.Text = "1";
            this.textBoxSpawnPosition2.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxSpawnPosition2_Validating);
            // 
            // textBoxItemChance2
            // 
            this.textBoxItemChance2.Location = new System.Drawing.Point(91, 91);
            this.textBoxItemChance2.Name = "textBoxItemChance2";
            this.textBoxItemChance2.Size = new System.Drawing.Size(58, 20);
            this.textBoxItemChance2.TabIndex = 4;
            this.textBoxItemChance2.Text = "50";
            this.textBoxItemChance2.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxItemChance2_Validating);
            // 
            // radioButtonDR2Item1
            // 
            this.radioButtonDR2Item1.AutoSize = true;
            this.radioButtonDR2Item1.Location = new System.Drawing.Point(6, 170);
            this.radioButtonDR2Item1.Name = "radioButtonDR2Item1";
            this.radioButtonDR2Item1.Size = new System.Drawing.Size(54, 17);
            this.radioButtonDR2Item1.TabIndex = 10;
            this.radioButtonDR2Item1.TabStop = true;
            this.radioButtonDR2Item1.Text = "Item 1";
            this.radioButtonDR2Item1.UseVisualStyleBackColor = true;
            this.radioButtonDR2Item1.CheckedChanged += new System.EventHandler(this.RadioButtonDR2_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Max Gil Amount";
            // 
            // textBoxGilChance2
            // 
            this.textBoxGilChance2.Location = new System.Drawing.Point(91, 65);
            this.textBoxGilChance2.Name = "textBoxGilChance2";
            this.textBoxGilChance2.Size = new System.Drawing.Size(58, 20);
            this.textBoxGilChance2.TabIndex = 3;
            this.textBoxGilChance2.Text = "50";
            this.textBoxGilChance2.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxGilChance2_Validating);
            // 
            // groupBoxCombo
            // 
            this.groupBoxCombo.Controls.Add(this.labelCombo);
            this.groupBoxCombo.Location = new System.Drawing.Point(188, 163);
            this.groupBoxCombo.Name = "groupBoxCombo";
            this.groupBoxCombo.Size = new System.Drawing.Size(110, 36);
            this.groupBoxCombo.TabIndex = 17;
            this.groupBoxCombo.TabStop = false;
            this.groupBoxCombo.Text = "Unarmed Combo";
            // 
            // labelCombo
            // 
            this.labelCombo.AutoSize = true;
            this.labelCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCombo.Location = new System.Drawing.Point(7, 17);
            this.labelCombo.Name = "labelCombo";
            this.labelCombo.Size = new System.Drawing.Size(23, 13);
            this.labelCombo.TabIndex = 0;
            this.labelCombo.Text = "No";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 473);
            this.Controls.Add(this.groupBoxCombo);
            this.Controls.Add(this.groupBoxChest2);
            this.Controls.Add(this.groupBoxChest1);
            this.Controls.Add(this.groupBoxWithCuffs);
            this.Controls.Add(this.groupBoxSteal);
            this.Controls.Add(this.groupBoxDisplay);
            this.Controls.Add(this.groupBoxGeneralSettings);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.dataGridViewDisp);
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(640, 39);
            this.Name = "FormMain";
            this.Text = "FF12 PC RNG Helper";
            this.ResizeBegin += new System.EventHandler(this.FormMain_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.FormMain_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisp)).EndInit();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.groupBoxGeneralSettings.ResumeLayout(false);
            this.groupBoxGeneralSettings.PerformLayout();
            this.groupBoxDisplay.ResumeLayout(false);
            this.groupBoxDisplay.PerformLayout();
            this.groupBoxSteal.ResumeLayout(false);
            this.groupBoxSteal.PerformLayout();
            this.groupBoxWithCuffs.ResumeLayout(false);
            this.groupBoxWithCuffs.PerformLayout();
            this.groupBoxChest1.ResumeLayout(false);
            this.groupBoxChest1.PerformLayout();
            this.groupBoxChest2.ResumeLayout(false);
            this.groupBoxChest2.PerformLayout();
            this.groupBoxCombo.ResumeLayout(false);
            this.groupBoxCombo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerReadMemory;
        private System.Windows.Forms.DataGridView dataGridViewDisp;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSync;
        private System.Windows.Forms.GroupBox groupBoxGeneralSettings;
        private System.Windows.Forms.Label labelMilliSeconds;
        private System.Windows.Forms.TextBox textBoxRefreshInterval;
        private System.Windows.Forms.Label labelRefreshInterval;
        private System.Windows.Forms.GroupBox groupBoxDisplay;
        private System.Windows.Forms.CheckBox checkBoxDisplayRawRNG;
        private System.Windows.Forms.CheckBox checkBoxDisplayStealCuff;
        private System.Windows.Forms.CheckBox checkBoxDisplaySteal;
        private System.Windows.Forms.CheckBox checkBoxDisplayPercent;
        private System.Windows.Forms.Label labelDisplayCount;
        private System.Windows.Forms.TextBox textBoxDisplayCount;
        private System.Windows.Forms.GroupBox groupBoxSteal;
        private System.Windows.Forms.RadioButton radioButtonRare;
        private System.Windows.Forms.RadioButton radioButtonUncommon;
        private System.Windows.Forms.RadioButton radioButtonCommon;
        private System.Windows.Forms.GroupBox groupBoxWithCuffs;
        private System.Windows.Forms.CheckBox checkBoxRare;
        private System.Windows.Forms.CheckBox checkBoxUncommon;
        private System.Windows.Forms.CheckBox checkBoxCommon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAdvanceNormal;
        private System.Windows.Forms.Label labelAdvanceCuffs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxChest1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonDR1Gil;
        private System.Windows.Forms.RadioButton radioButtonDR1Item2;
        private System.Windows.Forms.RadioButton radioButtonDR1Item1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMaxGil1;
        private System.Windows.Forms.TextBox textBoxItemChance1;
        private System.Windows.Forms.TextBox textBoxGilChance1;
        private System.Windows.Forms.TextBox textBoxSpawnPosition1;
        private System.Windows.Forms.TextBox textBoxSpawnChance1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxDisplayChest2;
        private System.Windows.Forms.CheckBox checkBoxDisplayChest1;
        private System.Windows.Forms.GroupBox groupBoxChest2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radioButtonDR2Gil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSpawnChance2;
        private System.Windows.Forms.TextBox textBoxMaxGil2;
        private System.Windows.Forms.RadioButton radioButtonDR2Item2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxSpawnPosition2;
        private System.Windows.Forms.TextBox textBoxItemChance2;
        private System.Windows.Forms.RadioButton radioButtonDR2Item1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxGilChance2;
        private System.Windows.Forms.Label labelAdvanceSpawnChest1;
        private System.Windows.Forms.GroupBox groupBoxCombo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelAdvanceChestReward1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelAdvanceChestReward2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelAdvanceSpawnChest2;
        private System.Windows.Forms.Label labelCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSteal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStealCuffs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnChest1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnChest2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRaw;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

