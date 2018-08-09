namespace BagOfHolding
{
    partial class SpellbookWindow
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.main_panel = new System.Windows.Forms.Panel();
            this.menu_strip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appendSpellbookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overwriteSpellbookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCharacterAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSpellbookAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spell_counter_table = new System.Windows.Forms.TableLayoutPanel();
            this.lvl0_box = new System.Windows.Forms.NumericUpDown();
            this.lvl1_box = new System.Windows.Forms.NumericUpDown();
            this.lvl2_box = new System.Windows.Forms.NumericUpDown();
            this.lvl3_box = new System.Windows.Forms.NumericUpDown();
            this.lvl4_box = new System.Windows.Forms.NumericUpDown();
            this.lvl5_box = new System.Windows.Forms.NumericUpDown();
            this.lvl6_box = new System.Windows.Forms.NumericUpDown();
            this.lvl7_box = new System.Windows.Forms.NumericUpDown();
            this.lvl8_box = new System.Windows.Forms.NumericUpDown();
            this.lvl0_label = new System.Windows.Forms.Label();
            this.lvl1_label = new System.Windows.Forms.Label();
            this.lvl2_label = new System.Windows.Forms.Label();
            this.lvl3_label = new System.Windows.Forms.Label();
            this.lvl4_label = new System.Windows.Forms.Label();
            this.lvl5_label = new System.Windows.Forms.Label();
            this.lvl6_label = new System.Windows.Forms.Label();
            this.lvl7_label = new System.Windows.Forms.Label();
            this.lvl8_label = new System.Windows.Forms.Label();
            this.lvl9_label = new System.Windows.Forms.Label();
            this.lvl9_box = new System.Windows.Forms.NumericUpDown();
            this.spell_book_label = new System.Windows.Forms.Label();
            this.spell_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.main_panel.SuspendLayout();
            this.menu_strip.SuspendLayout();
            this.spell_counter_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvl0_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl1_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl2_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl3_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl4_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl5_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl6_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl7_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl8_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl9_box)).BeginInit();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.main_panel.Controls.Add(this.menu_strip);
            this.main_panel.Controls.Add(this.spell_counter_table);
            this.main_panel.Controls.Add(this.spell_book_label);
            this.main_panel.Controls.Add(this.spell_panel);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(876, 468);
            this.main_panel.TabIndex = 1;
            // 
            // menu_strip
            // 
            this.menu_strip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(140)))));
            this.menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menu_strip.Location = new System.Drawing.Point(0, 0);
            this.menu_strip.Margin = new System.Windows.Forms.Padding(3);
            this.menu_strip.Name = "menu_strip";
            this.menu_strip.Size = new System.Drawing.Size(876, 24);
            this.menu_strip.TabIndex = 26;
            this.menu_strip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newItemToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // newItemToolStripMenuItem
            // 
            this.newItemToolStripMenuItem.Name = "newItemToolStripMenuItem";
            this.newItemToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.newItemToolStripMenuItem.Text = "New Spell...";
            this.newItemToolStripMenuItem.Click += new System.EventHandler(this.newItemToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCharacterToolStripMenuItem,
            this.appendSpellbookToolStripMenuItem,
            this.overwriteSpellbookToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // loadCharacterToolStripMenuItem
            // 
            this.loadCharacterToolStripMenuItem.Name = "loadCharacterToolStripMenuItem";
            this.loadCharacterToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.loadCharacterToolStripMenuItem.Text = "Load Character...";
            // 
            // appendSpellbookToolStripMenuItem
            // 
            this.appendSpellbookToolStripMenuItem.Name = "appendSpellbookToolStripMenuItem";
            this.appendSpellbookToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.appendSpellbookToolStripMenuItem.Text = "Append Spellbook...";
            this.appendSpellbookToolStripMenuItem.Click += new System.EventHandler(this.appendSpellbookToolStripMenuItem_Click);
            // 
            // overwriteSpellbookToolStripMenuItem
            // 
            this.overwriteSpellbookToolStripMenuItem.Name = "overwriteSpellbookToolStripMenuItem";
            this.overwriteSpellbookToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.overwriteSpellbookToolStripMenuItem.Text = "Overwrite Spellbook...";
            this.overwriteSpellbookToolStripMenuItem.Click += new System.EventHandler(this.overwriteSpellbookToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCharacterAsToolStripMenuItem,
            this.saveSpellbookAsToolStripMenuItem});
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // saveCharacterAsToolStripMenuItem
            // 
            this.saveCharacterAsToolStripMenuItem.Name = "saveCharacterAsToolStripMenuItem";
            this.saveCharacterAsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.saveCharacterAsToolStripMenuItem.Text = "Save Character as...";
            this.saveCharacterAsToolStripMenuItem.Click += new System.EventHandler(this.saveCharacterAsToolStripMenuItem_Click);
            // 
            // saveSpellbookAsToolStripMenuItem
            // 
            this.saveSpellbookAsToolStripMenuItem.Name = "saveSpellbookAsToolStripMenuItem";
            this.saveSpellbookAsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.saveSpellbookAsToolStripMenuItem.Text = "Save Spellbook as...";
            this.saveSpellbookAsToolStripMenuItem.Click += new System.EventHandler(this.saveSpellbookAsToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCharacterToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveCharacterToolStripMenuItem
            // 
            this.saveCharacterToolStripMenuItem.Name = "saveCharacterToolStripMenuItem";
            this.saveCharacterToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.saveCharacterToolStripMenuItem.Text = "Save Character...";
            this.saveCharacterToolStripMenuItem.Click += new System.EventHandler(this.saveCharacterToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // spell_counter_table
            // 
            this.spell_counter_table.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spell_counter_table.BackColor = System.Drawing.Color.Gainsboro;
            this.spell_counter_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.spell_counter_table.ColumnCount = 10;
            this.spell_counter_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.spell_counter_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.spell_counter_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.spell_counter_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.spell_counter_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.spell_counter_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.spell_counter_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.spell_counter_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.spell_counter_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.spell_counter_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.spell_counter_table.Controls.Add(this.lvl0_box, 0, 1);
            this.spell_counter_table.Controls.Add(this.lvl1_box, 1, 1);
            this.spell_counter_table.Controls.Add(this.lvl2_box, 2, 1);
            this.spell_counter_table.Controls.Add(this.lvl3_box, 3, 1);
            this.spell_counter_table.Controls.Add(this.lvl4_box, 4, 1);
            this.spell_counter_table.Controls.Add(this.lvl5_box, 5, 1);
            this.spell_counter_table.Controls.Add(this.lvl6_box, 6, 1);
            this.spell_counter_table.Controls.Add(this.lvl7_box, 7, 1);
            this.spell_counter_table.Controls.Add(this.lvl8_box, 8, 1);
            this.spell_counter_table.Controls.Add(this.lvl0_label, 0, 0);
            this.spell_counter_table.Controls.Add(this.lvl1_label, 1, 0);
            this.spell_counter_table.Controls.Add(this.lvl2_label, 2, 0);
            this.spell_counter_table.Controls.Add(this.lvl3_label, 3, 0);
            this.spell_counter_table.Controls.Add(this.lvl4_label, 4, 0);
            this.spell_counter_table.Controls.Add(this.lvl5_label, 5, 0);
            this.spell_counter_table.Controls.Add(this.lvl6_label, 6, 0);
            this.spell_counter_table.Controls.Add(this.lvl7_label, 7, 0);
            this.spell_counter_table.Controls.Add(this.lvl8_label, 8, 0);
            this.spell_counter_table.Controls.Add(this.lvl9_label, 9, 0);
            this.spell_counter_table.Controls.Add(this.lvl9_box, 9, 1);
            this.spell_counter_table.Location = new System.Drawing.Point(438, 31);
            this.spell_counter_table.Name = "spell_counter_table";
            this.spell_counter_table.RowCount = 2;
            this.spell_counter_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.spell_counter_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.spell_counter_table.Size = new System.Drawing.Size(431, 64);
            this.spell_counter_table.TabIndex = 10;
            // 
            // lvl0_box
            // 
            this.lvl0_box.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lvl0_box.BackColor = System.Drawing.Color.Gainsboro;
            this.lvl0_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvl0_box.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl0_box.ForeColor = System.Drawing.Color.Black;
            this.lvl0_box.Location = new System.Drawing.Point(6, 36);
            this.lvl0_box.Name = "lvl0_box";
            this.lvl0_box.Size = new System.Drawing.Size(32, 26);
            this.lvl0_box.TabIndex = 9;
            this.lvl0_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvl0_box.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.lvl0_box.ValueChanged += new System.EventHandler(this.spells_left_ValueChanged);
            // 
            // lvl1_box
            // 
            this.lvl1_box.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lvl1_box.BackColor = System.Drawing.Color.Gainsboro;
            this.lvl1_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvl1_box.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl1_box.ForeColor = System.Drawing.Color.Black;
            this.lvl1_box.Location = new System.Drawing.Point(48, 36);
            this.lvl1_box.Name = "lvl1_box";
            this.lvl1_box.Size = new System.Drawing.Size(32, 26);
            this.lvl1_box.TabIndex = 9;
            this.lvl1_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvl1_box.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.lvl1_box.ValueChanged += new System.EventHandler(this.spells_left_ValueChanged);
            // 
            // lvl2_box
            // 
            this.lvl2_box.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lvl2_box.BackColor = System.Drawing.Color.Gainsboro;
            this.lvl2_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvl2_box.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl2_box.ForeColor = System.Drawing.Color.Black;
            this.lvl2_box.Location = new System.Drawing.Point(90, 36);
            this.lvl2_box.Name = "lvl2_box";
            this.lvl2_box.Size = new System.Drawing.Size(32, 26);
            this.lvl2_box.TabIndex = 9;
            this.lvl2_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvl2_box.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.lvl2_box.ValueChanged += new System.EventHandler(this.spells_left_ValueChanged);
            // 
            // lvl3_box
            // 
            this.lvl3_box.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lvl3_box.BackColor = System.Drawing.Color.Gainsboro;
            this.lvl3_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvl3_box.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl3_box.ForeColor = System.Drawing.Color.Black;
            this.lvl3_box.Location = new System.Drawing.Point(132, 36);
            this.lvl3_box.Name = "lvl3_box";
            this.lvl3_box.Size = new System.Drawing.Size(32, 26);
            this.lvl3_box.TabIndex = 9;
            this.lvl3_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvl3_box.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.lvl3_box.ValueChanged += new System.EventHandler(this.spells_left_ValueChanged);
            // 
            // lvl4_box
            // 
            this.lvl4_box.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lvl4_box.BackColor = System.Drawing.Color.Gainsboro;
            this.lvl4_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvl4_box.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl4_box.ForeColor = System.Drawing.Color.Black;
            this.lvl4_box.Location = new System.Drawing.Point(174, 36);
            this.lvl4_box.Name = "lvl4_box";
            this.lvl4_box.Size = new System.Drawing.Size(32, 26);
            this.lvl4_box.TabIndex = 9;
            this.lvl4_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvl4_box.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.lvl4_box.ValueChanged += new System.EventHandler(this.spells_left_ValueChanged);
            // 
            // lvl5_box
            // 
            this.lvl5_box.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lvl5_box.BackColor = System.Drawing.Color.Gainsboro;
            this.lvl5_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvl5_box.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl5_box.ForeColor = System.Drawing.Color.Black;
            this.lvl5_box.Location = new System.Drawing.Point(216, 36);
            this.lvl5_box.Name = "lvl5_box";
            this.lvl5_box.Size = new System.Drawing.Size(32, 26);
            this.lvl5_box.TabIndex = 9;
            this.lvl5_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvl5_box.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.lvl5_box.ValueChanged += new System.EventHandler(this.spells_left_ValueChanged);
            // 
            // lvl6_box
            // 
            this.lvl6_box.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lvl6_box.BackColor = System.Drawing.Color.Gainsboro;
            this.lvl6_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvl6_box.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl6_box.ForeColor = System.Drawing.Color.Black;
            this.lvl6_box.Location = new System.Drawing.Point(258, 36);
            this.lvl6_box.Name = "lvl6_box";
            this.lvl6_box.Size = new System.Drawing.Size(32, 26);
            this.lvl6_box.TabIndex = 9;
            this.lvl6_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvl6_box.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.lvl6_box.ValueChanged += new System.EventHandler(this.spells_left_ValueChanged);
            // 
            // lvl7_box
            // 
            this.lvl7_box.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lvl7_box.BackColor = System.Drawing.Color.Gainsboro;
            this.lvl7_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvl7_box.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl7_box.ForeColor = System.Drawing.Color.Black;
            this.lvl7_box.Location = new System.Drawing.Point(300, 36);
            this.lvl7_box.Name = "lvl7_box";
            this.lvl7_box.Size = new System.Drawing.Size(32, 26);
            this.lvl7_box.TabIndex = 9;
            this.lvl7_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvl7_box.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.lvl7_box.ValueChanged += new System.EventHandler(this.spells_left_ValueChanged);
            // 
            // lvl8_box
            // 
            this.lvl8_box.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lvl8_box.BackColor = System.Drawing.Color.Gainsboro;
            this.lvl8_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvl8_box.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl8_box.ForeColor = System.Drawing.Color.Black;
            this.lvl8_box.Location = new System.Drawing.Point(342, 36);
            this.lvl8_box.Name = "lvl8_box";
            this.lvl8_box.Size = new System.Drawing.Size(32, 26);
            this.lvl8_box.TabIndex = 9;
            this.lvl8_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvl8_box.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.lvl8_box.ValueChanged += new System.EventHandler(this.spells_left_ValueChanged);
            // 
            // lvl0_label
            // 
            this.lvl0_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvl0_label.AutoSize = true;
            this.lvl0_label.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl0_label.Location = new System.Drawing.Point(5, 7);
            this.lvl0_label.Name = "lvl0_label";
            this.lvl0_label.Size = new System.Drawing.Size(34, 19);
            this.lvl0_label.TabIndex = 10;
            this.lvl0_label.Text = "Lvl 0";
            // 
            // lvl1_label
            // 
            this.lvl1_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvl1_label.AutoSize = true;
            this.lvl1_label.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl1_label.Location = new System.Drawing.Point(48, 7);
            this.lvl1_label.Name = "lvl1_label";
            this.lvl1_label.Size = new System.Drawing.Size(31, 19);
            this.lvl1_label.TabIndex = 10;
            this.lvl1_label.Text = "Lvl 1";
            // 
            // lvl2_label
            // 
            this.lvl2_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvl2_label.AutoSize = true;
            this.lvl2_label.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl2_label.Location = new System.Drawing.Point(89, 7);
            this.lvl2_label.Name = "lvl2_label";
            this.lvl2_label.Size = new System.Drawing.Size(33, 19);
            this.lvl2_label.TabIndex = 10;
            this.lvl2_label.Text = "Lvl 2";
            // 
            // lvl3_label
            // 
            this.lvl3_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvl3_label.AutoSize = true;
            this.lvl3_label.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl3_label.Location = new System.Drawing.Point(131, 7);
            this.lvl3_label.Name = "lvl3_label";
            this.lvl3_label.Size = new System.Drawing.Size(33, 19);
            this.lvl3_label.TabIndex = 10;
            this.lvl3_label.Text = "Lvl 3";
            // 
            // lvl4_label
            // 
            this.lvl4_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvl4_label.AutoSize = true;
            this.lvl4_label.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl4_label.Location = new System.Drawing.Point(173, 7);
            this.lvl4_label.Name = "lvl4_label";
            this.lvl4_label.Size = new System.Drawing.Size(34, 19);
            this.lvl4_label.TabIndex = 10;
            this.lvl4_label.Text = "Lvl 4";
            // 
            // lvl5_label
            // 
            this.lvl5_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvl5_label.AutoSize = true;
            this.lvl5_label.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl5_label.Location = new System.Drawing.Point(215, 7);
            this.lvl5_label.Name = "lvl5_label";
            this.lvl5_label.Size = new System.Drawing.Size(34, 19);
            this.lvl5_label.TabIndex = 10;
            this.lvl5_label.Text = "Lvl 5";
            // 
            // lvl6_label
            // 
            this.lvl6_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvl6_label.AutoSize = true;
            this.lvl6_label.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl6_label.Location = new System.Drawing.Point(257, 7);
            this.lvl6_label.Name = "lvl6_label";
            this.lvl6_label.Size = new System.Drawing.Size(33, 19);
            this.lvl6_label.TabIndex = 10;
            this.lvl6_label.Text = "Lvl 6";
            // 
            // lvl7_label
            // 
            this.lvl7_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvl7_label.AutoSize = true;
            this.lvl7_label.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl7_label.Location = new System.Drawing.Point(299, 7);
            this.lvl7_label.Name = "lvl7_label";
            this.lvl7_label.Size = new System.Drawing.Size(33, 19);
            this.lvl7_label.TabIndex = 10;
            this.lvl7_label.Text = "Lvl 7";
            // 
            // lvl8_label
            // 
            this.lvl8_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvl8_label.AutoSize = true;
            this.lvl8_label.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl8_label.Location = new System.Drawing.Point(341, 7);
            this.lvl8_label.Name = "lvl8_label";
            this.lvl8_label.Size = new System.Drawing.Size(34, 19);
            this.lvl8_label.TabIndex = 10;
            this.lvl8_label.Text = "Lvl 8";
            // 
            // lvl9_label
            // 
            this.lvl9_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvl9_label.AutoSize = true;
            this.lvl9_label.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl9_label.Location = new System.Drawing.Point(388, 7);
            this.lvl9_label.Name = "lvl9_label";
            this.lvl9_label.Size = new System.Drawing.Size(33, 19);
            this.lvl9_label.TabIndex = 10;
            this.lvl9_label.Text = "Lvl 9";
            // 
            // lvl9_box
            // 
            this.lvl9_box.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lvl9_box.BackColor = System.Drawing.Color.Gainsboro;
            this.lvl9_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvl9_box.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl9_box.ForeColor = System.Drawing.Color.Black;
            this.lvl9_box.Location = new System.Drawing.Point(388, 36);
            this.lvl9_box.Name = "lvl9_box";
            this.lvl9_box.Size = new System.Drawing.Size(32, 26);
            this.lvl9_box.TabIndex = 9;
            this.lvl9_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvl9_box.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.lvl9_box.ValueChanged += new System.EventHandler(this.spells_left_ValueChanged);
            // 
            // spell_book_label
            // 
            this.spell_book_label.AutoSize = true;
            this.spell_book_label.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spell_book_label.ForeColor = System.Drawing.Color.Gainsboro;
            this.spell_book_label.Location = new System.Drawing.Point(40, 50);
            this.spell_book_label.Name = "spell_book_label";
            this.spell_book_label.Size = new System.Drawing.Size(197, 23);
            this.spell_book_label.TabIndex = 1;
            this.spell_book_label.Text = "charName\'s Spellbook";
            // 
            // spell_panel
            // 
            this.spell_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spell_panel.AutoScroll = true;
            this.spell_panel.BackColor = System.Drawing.Color.Gainsboro;
            this.spell_panel.Location = new System.Drawing.Point(0, 102);
            this.spell_panel.Name = "spell_panel";
            this.spell_panel.Size = new System.Drawing.Size(876, 366);
            this.spell_panel.TabIndex = 0;
            // 
            // SpellbookWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.main_panel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SpellbookWindow";
            this.Size = new System.Drawing.Size(876, 468);
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.menu_strip.ResumeLayout(false);
            this.menu_strip.PerformLayout();
            this.spell_counter_table.ResumeLayout(false);
            this.spell_counter_table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvl0_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl1_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl2_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl3_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl4_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl5_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl6_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl7_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl8_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl9_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.TableLayoutPanel spell_counter_table;
        private System.Windows.Forms.NumericUpDown lvl0_box;
        private System.Windows.Forms.NumericUpDown lvl1_box;
        private System.Windows.Forms.NumericUpDown lvl2_box;
        private System.Windows.Forms.NumericUpDown lvl3_box;
        private System.Windows.Forms.NumericUpDown lvl4_box;
        private System.Windows.Forms.NumericUpDown lvl5_box;
        private System.Windows.Forms.NumericUpDown lvl6_box;
        private System.Windows.Forms.NumericUpDown lvl7_box;
        private System.Windows.Forms.NumericUpDown lvl8_box;
        private System.Windows.Forms.Label lvl0_label;
        private System.Windows.Forms.Label lvl1_label;
        private System.Windows.Forms.Label lvl2_label;
        private System.Windows.Forms.Label lvl3_label;
        private System.Windows.Forms.Label lvl4_label;
        private System.Windows.Forms.Label lvl5_label;
        private System.Windows.Forms.Label lvl6_label;
        private System.Windows.Forms.Label lvl7_label;
        private System.Windows.Forms.Label lvl8_label;
        private System.Windows.Forms.Label lvl9_label;
        private System.Windows.Forms.NumericUpDown lvl9_box;
        private System.Windows.Forms.Label spell_book_label;
        private System.Windows.Forms.FlowLayoutPanel spell_panel;
        private System.Windows.Forms.MenuStrip menu_strip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appendSpellbookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overwriteSpellbookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSpellbookAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCharacterAsToolStripMenuItem;
    }
}
