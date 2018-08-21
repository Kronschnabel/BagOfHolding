namespace BagOfHolding
{
    partial class CharacterWindow
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
            this.health_bar = new BagOfHolding.PanelBar();
            this.exp_box = new System.Windows.Forms.TextBox();
            this.max_exp_box = new System.Windows.Forms.TextBox();
            this.exp_slash = new System.Windows.Forms.Label();
            this.exp_bar = new BagOfHolding.PanelBar();
            this.bab_panel = new System.Windows.Forms.Panel();
            this.bab_box = new System.Windows.Forms.TextBox();
            this.melee_box = new System.Windows.Forms.TextBox();
            this.ranged_box = new System.Windows.Forms.TextBox();
            this.ranged_label = new System.Windows.Forms.Label();
            this.bab_label = new System.Windows.Forms.Label();
            this.melee_label = new System.Windows.Forms.Label();
            this.menu_strip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCharacterAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSkillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPathfinderSkillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spell_butt = new System.Windows.Forms.Button();
            this.inv_butt = new System.Windows.Forms.Button();
            this.hp_text_panel = new System.Windows.Forms.Panel();
            this.max_hp_box = new System.Windows.Forms.TextBox();
            this.hp_box = new System.Windows.Forms.TextBox();
            this.hp_slash_label = new System.Windows.Forms.Label();
            this.char_notes_box = new System.Windows.Forms.RichTextBox();
            this.skill_panel_back = new System.Windows.Forms.Panel();
            this.skill_clear_butt = new System.Windows.Forms.Button();
            this.skills_label = new System.Windows.Forms.Label();
            this.skill_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.touch_ac_label = new System.Windows.Forms.Label();
            this.ff_ac_label = new System.Windows.Forms.Label();
            this.speed_box = new System.Windows.Forms.TextBox();
            this.speed_label = new System.Windows.Forms.Label();
            this.saves_table_1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.saves_label = new System.Windows.Forms.Label();
            this.saves_table_2 = new System.Windows.Forms.TableLayoutPanel();
            this.fort_save_box = new System.Windows.Forms.TextBox();
            this.will_save_box = new System.Windows.Forms.TextBox();
            this.ref_save_box = new System.Windows.Forms.TextBox();
            this.ability_table = new System.Windows.Forms.TableLayoutPanel();
            this.str_box = new System.Windows.Forms.TextBox();
            this.str_label = new System.Windows.Forms.Label();
            this.dex_label = new System.Windows.Forms.Label();
            this.con_label = new System.Windows.Forms.Label();
            this.int_label = new System.Windows.Forms.Label();
            this.wis_label = new System.Windows.Forms.Label();
            this.cha_label = new System.Windows.Forms.Label();
            this.dex_box = new System.Windows.Forms.TextBox();
            this.con_box = new System.Windows.Forms.TextBox();
            this.int_box = new System.Windows.Forms.TextBox();
            this.wis_box = new System.Windows.Forms.TextBox();
            this.cha_box = new System.Windows.Forms.TextBox();
            this.str_mod_label = new System.Windows.Forms.TextBox();
            this.dex_mod_label = new System.Windows.Forms.TextBox();
            this.con_mod_label = new System.Windows.Forms.TextBox();
            this.int_mod_label = new System.Windows.Forms.TextBox();
            this.wis_mod_label = new System.Windows.Forms.TextBox();
            this.cha_mod_label = new System.Windows.Forms.TextBox();
            this.ac_table = new System.Windows.Forms.TableLayoutPanel();
            this.ff_ac_box = new System.Windows.Forms.TextBox();
            this.touch_ac_box = new System.Windows.Forms.TextBox();
            this.init_panel = new System.Windows.Forms.Panel();
            this.init_label = new System.Windows.Forms.Label();
            this.ac_label = new System.Windows.Forms.Label();
            this.init_box = new System.Windows.Forms.TextBox();
            this.ac_box = new System.Windows.Forms.TextBox();
            this.classes_table = new System.Windows.Forms.TableLayoutPanel();
            this.class_table_1 = new System.Windows.Forms.TableLayoutPanel();
            this.f_class_1 = new System.Windows.Forms.CheckBox();
            this.class_level_box_1 = new System.Windows.Forms.TextBox();
            this.class_hd_box_1 = new System.Windows.Forms.TextBox();
            this.class_name_box_1 = new System.Windows.Forms.TextBox();
            this.class_skill_box_1 = new System.Windows.Forms.TextBox();
            this.class_table_2 = new System.Windows.Forms.TableLayoutPanel();
            this.f_class_2 = new System.Windows.Forms.CheckBox();
            this.class_level_box_2 = new System.Windows.Forms.TextBox();
            this.class_hd_box_2 = new System.Windows.Forms.TextBox();
            this.class_name_box_2 = new System.Windows.Forms.TextBox();
            this.class_skill_box_2 = new System.Windows.Forms.TextBox();
            this.class_table_3 = new System.Windows.Forms.TableLayoutPanel();
            this.f_class_3 = new System.Windows.Forms.CheckBox();
            this.class_level_box_3 = new System.Windows.Forms.TextBox();
            this.class_hd_box_3 = new System.Windows.Forms.TextBox();
            this.class_name_box_3 = new System.Windows.Forms.TextBox();
            this.class_skill_box_3 = new System.Windows.Forms.TextBox();
            this.class_table_4 = new System.Windows.Forms.TableLayoutPanel();
            this.f_class_4 = new System.Windows.Forms.CheckBox();
            this.class_level_box_4 = new System.Windows.Forms.TextBox();
            this.class_hd_box_4 = new System.Windows.Forms.TextBox();
            this.class_name_box_4 = new System.Windows.Forms.TextBox();
            this.class_skill_box_4 = new System.Windows.Forms.TextBox();
            this.class_table_5 = new System.Windows.Forms.TableLayoutPanel();
            this.f_class_5 = new System.Windows.Forms.CheckBox();
            this.class_level_box_5 = new System.Windows.Forms.TextBox();
            this.class_hd_box_5 = new System.Windows.Forms.TextBox();
            this.class_name_box_5 = new System.Windows.Forms.TextBox();
            this.class_skill_box_5 = new System.Windows.Forms.TextBox();
            this.classes_label = new System.Windows.Forms.Label();
            this.char_panel = new System.Windows.Forms.Panel();
            this.subtitle_box = new System.Windows.Forms.TextBox();
            this.char_name_box = new System.Windows.Forms.TextBox();
            this.char_info_table = new System.Windows.Forms.TableLayoutPanel();
            this.rsg_table = new System.Windows.Forms.TableLayoutPanel();
            this.gender_box = new System.Windows.Forms.TextBox();
            this.size_box = new System.Windows.Forms.TextBox();
            this.race_box = new System.Windows.Forms.TextBox();
            this.lvl_ali_table = new System.Windows.Forms.TableLayoutPanel();
            this.alignment_box = new System.Windows.Forms.TextBox();
            this.char_level_table = new System.Windows.Forms.TableLayoutPanel();
            this.char_level_label = new System.Windows.Forms.Label();
            this.char_level_box = new System.Windows.Forms.TextBox();
            this.avatar_panel = new System.Windows.Forms.Panel();
            this.char_image = new System.Windows.Forms.PictureBox();
            this.main_panel.SuspendLayout();
            this.bab_panel.SuspendLayout();
            this.menu_strip.SuspendLayout();
            this.hp_text_panel.SuspendLayout();
            this.skill_panel_back.SuspendLayout();
            this.saves_table_1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.saves_table_2.SuspendLayout();
            this.ability_table.SuspendLayout();
            this.ac_table.SuspendLayout();
            this.init_panel.SuspendLayout();
            this.classes_table.SuspendLayout();
            this.class_table_1.SuspendLayout();
            this.class_table_2.SuspendLayout();
            this.class_table_3.SuspendLayout();
            this.class_table_4.SuspendLayout();
            this.class_table_5.SuspendLayout();
            this.char_panel.SuspendLayout();
            this.char_info_table.SuspendLayout();
            this.rsg_table.SuspendLayout();
            this.lvl_ali_table.SuspendLayout();
            this.char_level_table.SuspendLayout();
            this.avatar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.char_image)).BeginInit();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.AutoSize = true;
            this.main_panel.BackColor = System.Drawing.Color.Gainsboro;
            this.main_panel.Controls.Add(this.health_bar);
            this.main_panel.Controls.Add(this.exp_box);
            this.main_panel.Controls.Add(this.max_exp_box);
            this.main_panel.Controls.Add(this.exp_slash);
            this.main_panel.Controls.Add(this.exp_bar);
            this.main_panel.Controls.Add(this.bab_panel);
            this.main_panel.Controls.Add(this.menu_strip);
            this.main_panel.Controls.Add(this.spell_butt);
            this.main_panel.Controls.Add(this.inv_butt);
            this.main_panel.Controls.Add(this.hp_text_panel);
            this.main_panel.Controls.Add(this.char_notes_box);
            this.main_panel.Controls.Add(this.skill_panel_back);
            this.main_panel.Controls.Add(this.touch_ac_label);
            this.main_panel.Controls.Add(this.ff_ac_label);
            this.main_panel.Controls.Add(this.speed_box);
            this.main_panel.Controls.Add(this.speed_label);
            this.main_panel.Controls.Add(this.saves_table_1);
            this.main_panel.Controls.Add(this.ability_table);
            this.main_panel.Controls.Add(this.ac_table);
            this.main_panel.Controls.Add(this.init_panel);
            this.main_panel.Controls.Add(this.classes_table);
            this.main_panel.Controls.Add(this.char_panel);
            this.main_panel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.ForeColor = System.Drawing.Color.Gainsboro;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(822, 540);
            this.main_panel.TabIndex = 1;
            // 
            // health_bar
            // 
            this.health_bar.Location = new System.Drawing.Point(15, 169);
            this.health_bar.Name = "health_bar";
            this.health_bar.Size = new System.Drawing.Size(117, 22);
            this.health_bar.TabIndex = 30;
            // 
            // exp_box
            // 
            this.exp_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exp_box.BackColor = System.Drawing.Color.DarkOrchid;
            this.exp_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exp_box.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_box.ForeColor = System.Drawing.Color.White;
            this.exp_box.Location = new System.Drawing.Point(0, 525);
            this.exp_box.Name = "exp_box";
            this.exp_box.Size = new System.Drawing.Size(58, 15);
            this.exp_box.TabIndex = 29;
            this.exp_box.Text = "1000";
            this.exp_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.exp_box.TextChanged += new System.EventHandler(this.exp_box_TextChanged);
            // 
            // max_exp_box
            // 
            this.max_exp_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.max_exp_box.BackColor = System.Drawing.Color.DarkOrchid;
            this.max_exp_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.max_exp_box.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_exp_box.ForeColor = System.Drawing.Color.White;
            this.max_exp_box.Location = new System.Drawing.Point(78, 525);
            this.max_exp_box.Name = "max_exp_box";
            this.max_exp_box.Size = new System.Drawing.Size(58, 15);
            this.max_exp_box.TabIndex = 28;
            this.max_exp_box.Text = "1000";
            this.max_exp_box.TextChanged += new System.EventHandler(this.max_exp_box_TextChanged);
            // 
            // exp_slash
            // 
            this.exp_slash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exp_slash.AutoSize = true;
            this.exp_slash.BackColor = System.Drawing.Color.DarkOrchid;
            this.exp_slash.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_slash.Location = new System.Drawing.Point(62, 525);
            this.exp_slash.Name = "exp_slash";
            this.exp_slash.Size = new System.Drawing.Size(11, 13);
            this.exp_slash.TabIndex = 27;
            this.exp_slash.Text = "/";
            // 
            // exp_bar
            // 
            this.exp_bar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exp_bar.Location = new System.Drawing.Point(0, 525);
            this.exp_bar.Name = "exp_bar";
            this.exp_bar.Size = new System.Drawing.Size(822, 15);
            this.exp_bar.TabIndex = 26;
            // 
            // bab_panel
            // 
            this.bab_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.bab_panel.Controls.Add(this.bab_box);
            this.bab_panel.Controls.Add(this.melee_box);
            this.bab_panel.Controls.Add(this.ranged_box);
            this.bab_panel.Controls.Add(this.ranged_label);
            this.bab_panel.Controls.Add(this.bab_label);
            this.bab_panel.Controls.Add(this.melee_label);
            this.bab_panel.Location = new System.Drawing.Point(204, 458);
            this.bab_panel.Name = "bab_panel";
            this.bab_panel.Size = new System.Drawing.Size(177, 59);
            this.bab_panel.TabIndex = 25;
            // 
            // bab_box
            // 
            this.bab_box.BackColor = System.Drawing.Color.Gainsboro;
            this.bab_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bab_box.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bab_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.bab_box.Location = new System.Drawing.Point(4, 25);
            this.bab_box.Margin = new System.Windows.Forms.Padding(4);
            this.bab_box.Name = "bab_box";
            this.bab_box.Size = new System.Drawing.Size(60, 30);
            this.bab_box.TabIndex = 29;
            this.bab_box.Text = "+0";
            this.bab_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bab_box.TextChanged += new System.EventHandler(this.bab_box_TextChanged);
            // 
            // melee_box
            // 
            this.melee_box.BackColor = System.Drawing.Color.Gainsboro;
            this.melee_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.melee_box.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.melee_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.melee_box.Location = new System.Drawing.Point(125, 7);
            this.melee_box.Margin = new System.Windows.Forms.Padding(4);
            this.melee_box.Name = "melee_box";
            this.melee_box.Size = new System.Drawing.Size(48, 21);
            this.melee_box.TabIndex = 30;
            this.melee_box.Text = "+0";
            this.melee_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.melee_box.TextChanged += new System.EventHandler(this.melee_box_TextChanged);
            // 
            // ranged_box
            // 
            this.ranged_box.BackColor = System.Drawing.Color.Gainsboro;
            this.ranged_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ranged_box.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ranged_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ranged_box.Location = new System.Drawing.Point(125, 33);
            this.ranged_box.Margin = new System.Windows.Forms.Padding(4);
            this.ranged_box.Name = "ranged_box";
            this.ranged_box.Size = new System.Drawing.Size(48, 21);
            this.ranged_box.TabIndex = 31;
            this.ranged_box.Text = "+0";
            this.ranged_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ranged_box.TextChanged += new System.EventHandler(this.ranged_box_TextChanged);
            // 
            // ranged_label
            // 
            this.ranged_label.AutoSize = true;
            this.ranged_label.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ranged_label.Location = new System.Drawing.Point(71, 33);
            this.ranged_label.Name = "ranged_label";
            this.ranged_label.Size = new System.Drawing.Size(51, 16);
            this.ranged_label.TabIndex = 10;
            this.ranged_label.Text = "Ranged";
            // 
            // bab_label
            // 
            this.bab_label.AutoSize = true;
            this.bab_label.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bab_label.Location = new System.Drawing.Point(13, 3);
            this.bab_label.Name = "bab_label";
            this.bab_label.Size = new System.Drawing.Size(39, 19);
            this.bab_label.TabIndex = 9;
            this.bab_label.Text = "BAB";
            // 
            // melee_label
            // 
            this.melee_label.AutoSize = true;
            this.melee_label.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.melee_label.Location = new System.Drawing.Point(70, 10);
            this.melee_label.Name = "melee_label";
            this.melee_label.Size = new System.Drawing.Size(43, 16);
            this.melee_label.TabIndex = 8;
            this.melee_label.Text = "Melee";
            // 
            // menu_strip
            // 
            this.menu_strip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(140)))));
            this.menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.skillsToolStripMenuItem});
            this.menu_strip.Location = new System.Drawing.Point(0, 0);
            this.menu_strip.Margin = new System.Windows.Forms.Padding(3);
            this.menu_strip.Name = "menu_strip";
            this.menu_strip.Size = new System.Drawing.Size(822, 24);
            this.menu_strip.Stretch = false;
            this.menu_strip.TabIndex = 24;
            this.menu_strip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCharacterToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // newCharacterToolStripMenuItem
            // 
            this.newCharacterToolStripMenuItem.Name = "newCharacterToolStripMenuItem";
            this.newCharacterToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.newCharacterToolStripMenuItem.Text = "New Character...";
            this.newCharacterToolStripMenuItem.Click += new System.EventHandler(this.newCharacterToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCharacterToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // loadCharacterToolStripMenuItem
            // 
            this.loadCharacterToolStripMenuItem.Name = "loadCharacterToolStripMenuItem";
            this.loadCharacterToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.loadCharacterToolStripMenuItem.Text = "Load Character...";
            this.loadCharacterToolStripMenuItem.Click += new System.EventHandler(this.loadCharacterToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCharacterAsToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save As";
            // 
            // saveCharacterAsToolStripMenuItem
            // 
            this.saveCharacterAsToolStripMenuItem.Name = "saveCharacterAsToolStripMenuItem";
            this.saveCharacterAsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.saveCharacterAsToolStripMenuItem.Text = "Save Character as...";
            this.saveCharacterAsToolStripMenuItem.Click += new System.EventHandler(this.saveCharacterAsToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCharacterToolStripMenuItem});
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem1.Text = "Save";
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
            // skillsToolStripMenuItem
            // 
            this.skillsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSkillToolStripMenuItem,
            this.addPathfinderSkillsToolStripMenuItem});
            this.skillsToolStripMenuItem.Name = "skillsToolStripMenuItem";
            this.skillsToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.skillsToolStripMenuItem.Text = "&Skills";
            // 
            // newSkillToolStripMenuItem
            // 
            this.newSkillToolStripMenuItem.Name = "newSkillToolStripMenuItem";
            this.newSkillToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.newSkillToolStripMenuItem.Text = "New Skill...";
            this.newSkillToolStripMenuItem.Click += new System.EventHandler(this.newSkillToolStripMenuItem_Click);
            // 
            // addPathfinderSkillsToolStripMenuItem
            // 
            this.addPathfinderSkillsToolStripMenuItem.Name = "addPathfinderSkillsToolStripMenuItem";
            this.addPathfinderSkillsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.addPathfinderSkillsToolStripMenuItem.Text = "Add Pathfinder skills...";
            this.addPathfinderSkillsToolStripMenuItem.Click += new System.EventHandler(this.addPathfinderSkillsToolStripMenuItem_Click);
            // 
            // spell_butt
            // 
            this.spell_butt.BackColor = System.Drawing.Color.DarkGray;
            this.spell_butt.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spell_butt.ForeColor = System.Drawing.Color.Black;
            this.spell_butt.Location = new System.Drawing.Point(107, 458);
            this.spell_butt.Name = "spell_butt";
            this.spell_butt.Size = new System.Drawing.Size(95, 61);
            this.spell_butt.TabIndex = 23;
            this.spell_butt.Text = "Spellbook";
            this.spell_butt.UseVisualStyleBackColor = false;
            this.spell_butt.Click += new System.EventHandler(this.spell_butt_Click);
            // 
            // inv_butt
            // 
            this.inv_butt.BackColor = System.Drawing.Color.Silver;
            this.inv_butt.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inv_butt.ForeColor = System.Drawing.Color.Black;
            this.inv_butt.Location = new System.Drawing.Point(7, 458);
            this.inv_butt.Name = "inv_butt";
            this.inv_butt.Size = new System.Drawing.Size(95, 61);
            this.inv_butt.TabIndex = 23;
            this.inv_butt.Text = "Inventory";
            this.inv_butt.UseVisualStyleBackColor = false;
            this.inv_butt.Click += new System.EventHandler(this.inv_butt_Click);
            // 
            // hp_text_panel
            // 
            this.hp_text_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hp_text_panel.Controls.Add(this.max_hp_box);
            this.hp_text_panel.Controls.Add(this.hp_box);
            this.hp_text_panel.Controls.Add(this.hp_slash_label);
            this.hp_text_panel.Location = new System.Drawing.Point(25, 190);
            this.hp_text_panel.Name = "hp_text_panel";
            this.hp_text_panel.Size = new System.Drawing.Size(94, 18);
            this.hp_text_panel.TabIndex = 22;
            // 
            // max_hp_box
            // 
            this.max_hp_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.max_hp_box.BackColor = System.Drawing.Color.Gainsboro;
            this.max_hp_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.max_hp_box.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_hp_box.Location = new System.Drawing.Point(52, 1);
            this.max_hp_box.Name = "max_hp_box";
            this.max_hp_box.Size = new System.Drawing.Size(41, 16);
            this.max_hp_box.TabIndex = 9;
            this.max_hp_box.Text = "0";
            this.max_hp_box.TextChanged += new System.EventHandler(this.max_hp_box_TextChanged);
            // 
            // hp_box
            // 
            this.hp_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hp_box.BackColor = System.Drawing.Color.Gainsboro;
            this.hp_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hp_box.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hp_box.Location = new System.Drawing.Point(-1, 1);
            this.hp_box.Name = "hp_box";
            this.hp_box.Size = new System.Drawing.Size(42, 16);
            this.hp_box.TabIndex = 8;
            this.hp_box.Text = "0";
            this.hp_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hp_box.TextChanged += new System.EventHandler(this.hp_box_TextChanged);
            // 
            // hp_slash_label
            // 
            this.hp_slash_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hp_slash_label.AutoSize = true;
            this.hp_slash_label.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hp_slash_label.ForeColor = System.Drawing.Color.Black;
            this.hp_slash_label.Location = new System.Drawing.Point(42, 0);
            this.hp_slash_label.Name = "hp_slash_label";
            this.hp_slash_label.Size = new System.Drawing.Size(11, 16);
            this.hp_slash_label.TabIndex = 0;
            this.hp_slash_label.Text = "/";
            // 
            // char_notes_box
            // 
            this.char_notes_box.BackColor = System.Drawing.Color.Gainsboro;
            this.char_notes_box.Location = new System.Drawing.Point(385, 29);
            this.char_notes_box.Name = "char_notes_box";
            this.char_notes_box.Size = new System.Drawing.Size(433, 141);
            this.char_notes_box.TabIndex = 32;
            this.char_notes_box.Text = "";
            this.char_notes_box.TextChanged += new System.EventHandler(this.char_notes_box_TextChanged);
            // 
            // skill_panel_back
            // 
            this.skill_panel_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.skill_panel_back.Controls.Add(this.skill_clear_butt);
            this.skill_panel_back.Controls.Add(this.skills_label);
            this.skill_panel_back.Controls.Add(this.skill_panel);
            this.skill_panel_back.Location = new System.Drawing.Point(385, 176);
            this.skill_panel_back.Name = "skill_panel_back";
            this.skill_panel_back.Size = new System.Drawing.Size(433, 341);
            this.skill_panel_back.TabIndex = 14;
            this.skill_panel_back.MouseMove += new System.Windows.Forms.MouseEventHandler(this.skill_panel_back_MouseMove);
            // 
            // skill_clear_butt
            // 
            this.skill_clear_butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skill_clear_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skill_clear_butt.ForeColor = System.Drawing.Color.White;
            this.skill_clear_butt.Location = new System.Drawing.Point(362, 3);
            this.skill_clear_butt.Name = "skill_clear_butt";
            this.skill_clear_butt.Size = new System.Drawing.Size(68, 22);
            this.skill_clear_butt.TabIndex = 14;
            this.skill_clear_butt.Text = "Clear...";
            this.skill_clear_butt.UseVisualStyleBackColor = false;
            this.skill_clear_butt.Visible = false;
            this.skill_clear_butt.Click += new System.EventHandler(this.skill_clear_butt_Click);
            // 
            // skills_label
            // 
            this.skills_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skills_label.AutoSize = true;
            this.skills_label.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skills_label.Location = new System.Drawing.Point(190, 1);
            this.skills_label.Name = "skills_label";
            this.skills_label.Size = new System.Drawing.Size(59, 23);
            this.skills_label.TabIndex = 8;
            this.skills_label.Text = "Skills";
            // 
            // skill_panel
            // 
            this.skill_panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skill_panel.AutoScroll = true;
            this.skill_panel.BackColor = System.Drawing.Color.Gainsboro;
            this.skill_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skill_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.skill_panel.Location = new System.Drawing.Point(3, 27);
            this.skill_panel.Name = "skill_panel";
            this.skill_panel.Size = new System.Drawing.Size(427, 311);
            this.skill_panel.TabIndex = 13;
            this.skill_panel.WrapContents = false;
            // 
            // touch_ac_label
            // 
            this.touch_ac_label.AutoSize = true;
            this.touch_ac_label.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.touch_ac_label.ForeColor = System.Drawing.Color.Gray;
            this.touch_ac_label.Location = new System.Drawing.Point(291, 371);
            this.touch_ac_label.Name = "touch_ac_label";
            this.touch_ac_label.Size = new System.Drawing.Size(34, 13);
            this.touch_ac_label.TabIndex = 12;
            this.touch_ac_label.Text = "Touch";
            // 
            // ff_ac_label
            // 
            this.ff_ac_label.AutoSize = true;
            this.ff_ac_label.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ff_ac_label.ForeColor = System.Drawing.Color.Gray;
            this.ff_ac_label.Location = new System.Drawing.Point(223, 371);
            this.ff_ac_label.Name = "ff_ac_label";
            this.ff_ac_label.Size = new System.Drawing.Size(65, 13);
            this.ff_ac_label.TabIndex = 12;
            this.ff_ac_label.Text = "Flat-Footed";
            // 
            // speed_box
            // 
            this.speed_box.BackColor = System.Drawing.Color.Gainsboro;
            this.speed_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.speed_box.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed_box.Location = new System.Drawing.Point(267, 353);
            this.speed_box.Name = "speed_box";
            this.speed_box.Size = new System.Drawing.Size(49, 16);
            this.speed_box.TabIndex = 22;
            this.speed_box.Text = "20ft";
            this.speed_box.TextChanged += new System.EventHandler(this.speed_box_TextChanged);
            // 
            // speed_label
            // 
            this.speed_label.AutoSize = true;
            this.speed_label.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed_label.ForeColor = System.Drawing.Color.Black;
            this.speed_label.Location = new System.Drawing.Point(223, 353);
            this.speed_label.Name = "speed_label";
            this.speed_label.Size = new System.Drawing.Size(47, 16);
            this.speed_label.TabIndex = 99;
            this.speed_label.Text = "Speed:";
            // 
            // saves_table_1
            // 
            this.saves_table_1.ColumnCount = 1;
            this.saves_table_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.1157F));
            this.saves_table_1.Controls.Add(this.panel4, 0, 0);
            this.saves_table_1.Controls.Add(this.saves_table_2, 0, 1);
            this.saves_table_1.Location = new System.Drawing.Point(143, 412);
            this.saves_table_1.Name = "saves_table_1";
            this.saves_table_1.RowCount = 2;
            this.saves_table_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.76271F));
            this.saves_table_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.saves_table_1.Size = new System.Drawing.Size(236, 38);
            this.saves_table_1.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.saves_label);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 19);
            this.panel4.TabIndex = 0;
            // 
            // saves_label
            // 
            this.saves_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.saves_label.AutoSize = true;
            this.saves_label.Font = new System.Drawing.Font("Bahnschrift", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saves_label.ForeColor = System.Drawing.Color.Black;
            this.saves_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saves_label.Location = new System.Drawing.Point(0, 1);
            this.saves_label.Margin = new System.Windows.Forms.Padding(0);
            this.saves_label.Name = "saves_label";
            this.saves_label.Size = new System.Drawing.Size(240, 16);
            this.saves_label.TabIndex = 0;
            this.saves_label.Text = " SAVES                            Fort              Ref              Will       ";
            this.saves_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saves_table_2
            // 
            this.saves_table_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saves_table_2.ColumnCount = 3;
            this.saves_table_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.saves_table_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.saves_table_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.saves_table_2.Controls.Add(this.fort_save_box, 0, 0);
            this.saves_table_2.Controls.Add(this.will_save_box, 2, 0);
            this.saves_table_2.Controls.Add(this.ref_save_box, 1, 0);
            this.saves_table_2.Location = new System.Drawing.Point(91, 19);
            this.saves_table_2.Margin = new System.Windows.Forms.Padding(0);
            this.saves_table_2.Name = "saves_table_2";
            this.saves_table_2.RowCount = 1;
            this.saves_table_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.saves_table_2.Size = new System.Drawing.Size(145, 15);
            this.saves_table_2.TabIndex = 1;
            // 
            // fort_save_box
            // 
            this.fort_save_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fort_save_box.BackColor = System.Drawing.Color.Gainsboro;
            this.fort_save_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fort_save_box.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fort_save_box.Location = new System.Drawing.Point(12, 0);
            this.fort_save_box.Margin = new System.Windows.Forms.Padding(0);
            this.fort_save_box.Name = "fort_save_box";
            this.fort_save_box.Size = new System.Drawing.Size(23, 16);
            this.fort_save_box.TabIndex = 26;
            this.fort_save_box.Text = "0";
            this.fort_save_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fort_save_box.TextChanged += new System.EventHandler(this.fort_save_box_TextChanged);
            // 
            // will_save_box
            // 
            this.will_save_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.will_save_box.BackColor = System.Drawing.Color.Gainsboro;
            this.will_save_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.will_save_box.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.will_save_box.Location = new System.Drawing.Point(109, 0);
            this.will_save_box.Margin = new System.Windows.Forms.Padding(0);
            this.will_save_box.Name = "will_save_box";
            this.will_save_box.Size = new System.Drawing.Size(23, 16);
            this.will_save_box.TabIndex = 28;
            this.will_save_box.Text = "0";
            this.will_save_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.will_save_box.TextChanged += new System.EventHandler(this.will_save_box_TextChanged);
            // 
            // ref_save_box
            // 
            this.ref_save_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ref_save_box.BackColor = System.Drawing.Color.Gainsboro;
            this.ref_save_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ref_save_box.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ref_save_box.Location = new System.Drawing.Point(60, 0);
            this.ref_save_box.Margin = new System.Windows.Forms.Padding(0);
            this.ref_save_box.Name = "ref_save_box";
            this.ref_save_box.Size = new System.Drawing.Size(23, 16);
            this.ref_save_box.TabIndex = 27;
            this.ref_save_box.Text = "0";
            this.ref_save_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ref_save_box.TextChanged += new System.EventHandler(this.ref_save_box_TextChanged);
            // 
            // ability_table
            // 
            this.ability_table.BackColor = System.Drawing.Color.Gainsboro;
            this.ability_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.ability_table.ColumnCount = 3;
            this.ability_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ability_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ability_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ability_table.Controls.Add(this.str_box, 1, 0);
            this.ability_table.Controls.Add(this.str_label, 0, 0);
            this.ability_table.Controls.Add(this.dex_label, 0, 1);
            this.ability_table.Controls.Add(this.con_label, 0, 2);
            this.ability_table.Controls.Add(this.int_label, 0, 3);
            this.ability_table.Controls.Add(this.wis_label, 0, 4);
            this.ability_table.Controls.Add(this.cha_label, 0, 5);
            this.ability_table.Controls.Add(this.dex_box, 1, 1);
            this.ability_table.Controls.Add(this.con_box, 1, 2);
            this.ability_table.Controls.Add(this.int_box, 1, 3);
            this.ability_table.Controls.Add(this.wis_box, 1, 4);
            this.ability_table.Controls.Add(this.cha_box, 1, 5);
            this.ability_table.Controls.Add(this.str_mod_label, 2, 0);
            this.ability_table.Controls.Add(this.dex_mod_label, 2, 1);
            this.ability_table.Controls.Add(this.con_mod_label, 2, 2);
            this.ability_table.Controls.Add(this.int_mod_label, 2, 3);
            this.ability_table.Controls.Add(this.wis_mod_label, 2, 4);
            this.ability_table.Controls.Add(this.cha_mod_label, 2, 5);
            this.ability_table.Location = new System.Drawing.Point(7, 225);
            this.ability_table.Name = "ability_table";
            this.ability_table.RowCount = 6;
            this.ability_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ability_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ability_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ability_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ability_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ability_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ability_table.Size = new System.Drawing.Size(130, 227);
            this.ability_table.TabIndex = 3;
            this.ability_table.Leave += new System.EventHandler(this.ability_table_Leave);
            // 
            // str_box
            // 
            this.str_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.str_box.BackColor = System.Drawing.Color.Gainsboro;
            this.str_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.str_box.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.str_box.ForeColor = System.Drawing.SystemColors.WindowText;
            this.str_box.Location = new System.Drawing.Point(47, 11);
            this.str_box.Margin = new System.Windows.Forms.Padding(0);
            this.str_box.Name = "str_box";
            this.str_box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.str_box.Size = new System.Drawing.Size(35, 16);
            this.str_box.TabIndex = 10;
            this.str_box.Text = "0";
            this.str_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.str_box.TextChanged += new System.EventHandler(this.str_box_TextChanged);
            // 
            // str_label
            // 
            this.str_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.str_label.AutoSize = true;
            this.str_label.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.str_label.ForeColor = System.Drawing.Color.Black;
            this.str_label.Location = new System.Drawing.Point(7, 11);
            this.str_label.Name = "str_label";
            this.str_label.Size = new System.Drawing.Size(30, 16);
            this.str_label.TabIndex = 0;
            this.str_label.Text = "STR";
            // 
            // dex_label
            // 
            this.dex_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dex_label.AutoSize = true;
            this.dex_label.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dex_label.ForeColor = System.Drawing.Color.Black;
            this.dex_label.Location = new System.Drawing.Point(6, 48);
            this.dex_label.Name = "dex_label";
            this.dex_label.Size = new System.Drawing.Size(32, 16);
            this.dex_label.TabIndex = 0;
            this.dex_label.Text = "DEX";
            // 
            // con_label
            // 
            this.con_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.con_label.AutoSize = true;
            this.con_label.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_label.ForeColor = System.Drawing.Color.Black;
            this.con_label.Location = new System.Drawing.Point(5, 85);
            this.con_label.Name = "con_label";
            this.con_label.Size = new System.Drawing.Size(33, 16);
            this.con_label.TabIndex = 0;
            this.con_label.Text = "CON";
            // 
            // int_label
            // 
            this.int_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.int_label.AutoSize = true;
            this.int_label.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.int_label.ForeColor = System.Drawing.Color.Black;
            this.int_label.Location = new System.Drawing.Point(8, 122);
            this.int_label.Name = "int_label";
            this.int_label.Size = new System.Drawing.Size(27, 16);
            this.int_label.TabIndex = 0;
            this.int_label.Text = "INT";
            // 
            // wis_label
            // 
            this.wis_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wis_label.AutoSize = true;
            this.wis_label.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wis_label.ForeColor = System.Drawing.Color.Black;
            this.wis_label.Location = new System.Drawing.Point(6, 159);
            this.wis_label.Name = "wis_label";
            this.wis_label.Size = new System.Drawing.Size(31, 16);
            this.wis_label.TabIndex = 0;
            this.wis_label.Text = "WIS";
            // 
            // cha_label
            // 
            this.cha_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cha_label.AutoSize = true;
            this.cha_label.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cha_label.ForeColor = System.Drawing.Color.Black;
            this.cha_label.Location = new System.Drawing.Point(5, 198);
            this.cha_label.Name = "cha_label";
            this.cha_label.Size = new System.Drawing.Size(33, 16);
            this.cha_label.TabIndex = 0;
            this.cha_label.Text = "CHA";
            // 
            // dex_box
            // 
            this.dex_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dex_box.BackColor = System.Drawing.Color.Gainsboro;
            this.dex_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dex_box.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dex_box.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dex_box.Location = new System.Drawing.Point(47, 48);
            this.dex_box.Margin = new System.Windows.Forms.Padding(0);
            this.dex_box.Name = "dex_box";
            this.dex_box.Size = new System.Drawing.Size(35, 16);
            this.dex_box.TabIndex = 11;
            this.dex_box.Text = "0";
            this.dex_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dex_box.TextChanged += new System.EventHandler(this.dex_box_TextChanged);
            // 
            // con_box
            // 
            this.con_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.con_box.BackColor = System.Drawing.Color.Gainsboro;
            this.con_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.con_box.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_box.ForeColor = System.Drawing.SystemColors.WindowText;
            this.con_box.Location = new System.Drawing.Point(47, 85);
            this.con_box.Margin = new System.Windows.Forms.Padding(0);
            this.con_box.Name = "con_box";
            this.con_box.Size = new System.Drawing.Size(35, 16);
            this.con_box.TabIndex = 12;
            this.con_box.Text = "0";
            this.con_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.con_box.TextChanged += new System.EventHandler(this.con_box_TextChanged);
            // 
            // int_box
            // 
            this.int_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.int_box.BackColor = System.Drawing.Color.Gainsboro;
            this.int_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.int_box.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.int_box.ForeColor = System.Drawing.SystemColors.WindowText;
            this.int_box.Location = new System.Drawing.Point(47, 122);
            this.int_box.Margin = new System.Windows.Forms.Padding(0);
            this.int_box.Name = "int_box";
            this.int_box.Size = new System.Drawing.Size(35, 16);
            this.int_box.TabIndex = 13;
            this.int_box.Text = "0";
            this.int_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.int_box.TextChanged += new System.EventHandler(this.int_box_TextChanged);
            // 
            // wis_box
            // 
            this.wis_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wis_box.BackColor = System.Drawing.Color.Gainsboro;
            this.wis_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wis_box.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wis_box.ForeColor = System.Drawing.SystemColors.WindowText;
            this.wis_box.Location = new System.Drawing.Point(47, 159);
            this.wis_box.Margin = new System.Windows.Forms.Padding(0);
            this.wis_box.Name = "wis_box";
            this.wis_box.Size = new System.Drawing.Size(35, 16);
            this.wis_box.TabIndex = 15;
            this.wis_box.Text = "0";
            this.wis_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wis_box.TextChanged += new System.EventHandler(this.wis_box_TextChanged);
            // 
            // cha_box
            // 
            this.cha_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cha_box.BackColor = System.Drawing.Color.Gainsboro;
            this.cha_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cha_box.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cha_box.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cha_box.Location = new System.Drawing.Point(47, 198);
            this.cha_box.Margin = new System.Windows.Forms.Padding(0);
            this.cha_box.Name = "cha_box";
            this.cha_box.Size = new System.Drawing.Size(35, 16);
            this.cha_box.TabIndex = 16;
            this.cha_box.Text = "0";
            this.cha_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cha_box.TextChanged += new System.EventHandler(this.cha_box_TextChanged);
            // 
            // str_mod_label
            // 
            this.str_mod_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.str_mod_label.BackColor = System.Drawing.Color.Gainsboro;
            this.str_mod_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.str_mod_label.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.str_mod_label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.str_mod_label.Location = new System.Drawing.Point(90, 11);
            this.str_mod_label.Margin = new System.Windows.Forms.Padding(0);
            this.str_mod_label.Name = "str_mod_label";
            this.str_mod_label.ReadOnly = true;
            this.str_mod_label.Size = new System.Drawing.Size(35, 16);
            this.str_mod_label.TabIndex = 8;
            this.str_mod_label.TabStop = false;
            this.str_mod_label.Text = "+0";
            this.str_mod_label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dex_mod_label
            // 
            this.dex_mod_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dex_mod_label.BackColor = System.Drawing.Color.Gainsboro;
            this.dex_mod_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dex_mod_label.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dex_mod_label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dex_mod_label.Location = new System.Drawing.Point(90, 48);
            this.dex_mod_label.Margin = new System.Windows.Forms.Padding(0);
            this.dex_mod_label.Name = "dex_mod_label";
            this.dex_mod_label.ReadOnly = true;
            this.dex_mod_label.Size = new System.Drawing.Size(35, 16);
            this.dex_mod_label.TabIndex = 8;
            this.dex_mod_label.TabStop = false;
            this.dex_mod_label.Text = "+0";
            this.dex_mod_label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // con_mod_label
            // 
            this.con_mod_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.con_mod_label.BackColor = System.Drawing.Color.Gainsboro;
            this.con_mod_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.con_mod_label.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_mod_label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.con_mod_label.Location = new System.Drawing.Point(90, 85);
            this.con_mod_label.Margin = new System.Windows.Forms.Padding(0);
            this.con_mod_label.Name = "con_mod_label";
            this.con_mod_label.ReadOnly = true;
            this.con_mod_label.Size = new System.Drawing.Size(35, 16);
            this.con_mod_label.TabIndex = 8;
            this.con_mod_label.TabStop = false;
            this.con_mod_label.Text = "+0";
            this.con_mod_label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // int_mod_label
            // 
            this.int_mod_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.int_mod_label.BackColor = System.Drawing.Color.Gainsboro;
            this.int_mod_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.int_mod_label.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.int_mod_label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.int_mod_label.Location = new System.Drawing.Point(90, 122);
            this.int_mod_label.Margin = new System.Windows.Forms.Padding(0);
            this.int_mod_label.Name = "int_mod_label";
            this.int_mod_label.ReadOnly = true;
            this.int_mod_label.Size = new System.Drawing.Size(35, 16);
            this.int_mod_label.TabIndex = 8;
            this.int_mod_label.TabStop = false;
            this.int_mod_label.Text = "+0";
            this.int_mod_label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wis_mod_label
            // 
            this.wis_mod_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wis_mod_label.BackColor = System.Drawing.Color.Gainsboro;
            this.wis_mod_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wis_mod_label.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wis_mod_label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.wis_mod_label.Location = new System.Drawing.Point(90, 159);
            this.wis_mod_label.Margin = new System.Windows.Forms.Padding(0);
            this.wis_mod_label.Name = "wis_mod_label";
            this.wis_mod_label.ReadOnly = true;
            this.wis_mod_label.Size = new System.Drawing.Size(35, 16);
            this.wis_mod_label.TabIndex = 8;
            this.wis_mod_label.TabStop = false;
            this.wis_mod_label.Text = "+0";
            this.wis_mod_label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cha_mod_label
            // 
            this.cha_mod_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cha_mod_label.BackColor = System.Drawing.Color.Gainsboro;
            this.cha_mod_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cha_mod_label.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cha_mod_label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cha_mod_label.Location = new System.Drawing.Point(90, 198);
            this.cha_mod_label.Margin = new System.Windows.Forms.Padding(0);
            this.cha_mod_label.Name = "cha_mod_label";
            this.cha_mod_label.ReadOnly = true;
            this.cha_mod_label.Size = new System.Drawing.Size(35, 16);
            this.cha_mod_label.TabIndex = 8;
            this.cha_mod_label.TabStop = false;
            this.cha_mod_label.Text = "+0";
            this.cha_mod_label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ac_table
            // 
            this.ac_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.ac_table.ColumnCount = 2;
            this.ac_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.59155F));
            this.ac_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.40845F));
            this.ac_table.Controls.Add(this.ff_ac_box, 0, 0);
            this.ac_table.Controls.Add(this.touch_ac_box, 1, 0);
            this.ac_table.Location = new System.Drawing.Point(226, 384);
            this.ac_table.Name = "ac_table";
            this.ac_table.RowCount = 1;
            this.ac_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ac_table.Size = new System.Drawing.Size(142, 23);
            this.ac_table.TabIndex = 8;
            // 
            // ff_ac_box
            // 
            this.ff_ac_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ff_ac_box.BackColor = System.Drawing.Color.Gainsboro;
            this.ff_ac_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ff_ac_box.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ff_ac_box.Location = new System.Drawing.Point(4, 4);
            this.ff_ac_box.Name = "ff_ac_box";
            this.ff_ac_box.Size = new System.Drawing.Size(61, 15);
            this.ff_ac_box.TabIndex = 24;
            this.ff_ac_box.Text = "0";
            this.ff_ac_box.TextChanged += new System.EventHandler(this.ff_ac_box_TextChanged);
            // 
            // touch_ac_box
            // 
            this.touch_ac_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.touch_ac_box.BackColor = System.Drawing.Color.Gainsboro;
            this.touch_ac_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.touch_ac_box.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.touch_ac_box.Location = new System.Drawing.Point(72, 4);
            this.touch_ac_box.Name = "touch_ac_box";
            this.touch_ac_box.Size = new System.Drawing.Size(66, 15);
            this.touch_ac_box.TabIndex = 25;
            this.touch_ac_box.Text = "0";
            this.touch_ac_box.TextChanged += new System.EventHandler(this.touch_ac_box_TextChanged);
            // 
            // init_panel
            // 
            this.init_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.init_panel.Controls.Add(this.init_label);
            this.init_panel.Controls.Add(this.ac_label);
            this.init_panel.Controls.Add(this.init_box);
            this.init_panel.Controls.Add(this.ac_box);
            this.init_panel.Location = new System.Drawing.Point(143, 351);
            this.init_panel.Name = "init_panel";
            this.init_panel.Size = new System.Drawing.Size(78, 56);
            this.init_panel.TabIndex = 7;
            // 
            // init_label
            // 
            this.init_label.AutoSize = true;
            this.init_label.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.init_label.Location = new System.Drawing.Point(6, 4);
            this.init_label.Name = "init_label";
            this.init_label.Size = new System.Drawing.Size(31, 16);
            this.init_label.TabIndex = 7;
            this.init_label.Text = "INIT";
            // 
            // ac_label
            // 
            this.ac_label.AutoSize = true;
            this.ac_label.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ac_label.Location = new System.Drawing.Point(5, 27);
            this.ac_label.Name = "ac_label";
            this.ac_label.Size = new System.Drawing.Size(34, 23);
            this.ac_label.TabIndex = 7;
            this.ac_label.Text = "AC";
            // 
            // init_box
            // 
            this.init_box.BackColor = System.Drawing.Color.Gainsboro;
            this.init_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.init_box.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.init_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.init_box.Location = new System.Drawing.Point(41, 2);
            this.init_box.Margin = new System.Windows.Forms.Padding(4);
            this.init_box.Name = "init_box";
            this.init_box.Size = new System.Drawing.Size(35, 21);
            this.init_box.TabIndex = 21;
            this.init_box.Text = "+0";
            this.init_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.init_box.TextChanged += new System.EventHandler(this.init_box_TextChanged);
            // 
            // ac_box
            // 
            this.ac_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ac_box.BackColor = System.Drawing.Color.Gainsboro;
            this.ac_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ac_box.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ac_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ac_box.Location = new System.Drawing.Point(41, 24);
            this.ac_box.Margin = new System.Windows.Forms.Padding(4);
            this.ac_box.Name = "ac_box";
            this.ac_box.Size = new System.Drawing.Size(35, 30);
            this.ac_box.TabIndex = 23;
            this.ac_box.Text = "10";
            this.ac_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ac_box.TextChanged += new System.EventHandler(this.ac_box_TextChanged);
            // 
            // classes_table
            // 
            this.classes_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.classes_table.ColumnCount = 1;
            this.classes_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.classes_table.Controls.Add(this.class_table_1, 0, 1);
            this.classes_table.Controls.Add(this.class_table_2, 0, 2);
            this.classes_table.Controls.Add(this.class_table_3, 0, 3);
            this.classes_table.Controls.Add(this.class_table_4, 0, 4);
            this.classes_table.Controls.Add(this.class_table_5, 0, 5);
            this.classes_table.Controls.Add(this.classes_label, 0, 0);
            this.classes_table.Location = new System.Drawing.Point(143, 164);
            this.classes_table.Name = "classes_table";
            this.classes_table.RowCount = 6;
            this.classes_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.44444F));
            this.classes_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.77778F));
            this.classes_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.classes_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.classes_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.classes_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.classes_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.classes_table.Size = new System.Drawing.Size(236, 181);
            this.classes_table.TabIndex = 5;
            // 
            // class_table_1
            // 
            this.class_table_1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.class_table_1.ColumnCount = 5;
            this.class_table_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.class_table_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.class_table_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.class_table_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.class_table_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.class_table_1.Controls.Add(this.f_class_1, 0, 0);
            this.class_table_1.Controls.Add(this.class_level_box_1, 2, 0);
            this.class_table_1.Controls.Add(this.class_hd_box_1, 3, 0);
            this.class_table_1.Controls.Add(this.class_name_box_1, 1, 0);
            this.class_table_1.Controls.Add(this.class_skill_box_1, 4, 0);
            this.class_table_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.class_table_1.Location = new System.Drawing.Point(3, 29);
            this.class_table_1.Margin = new System.Windows.Forms.Padding(2);
            this.class_table_1.Name = "class_table_1";
            this.class_table_1.RowCount = 1;
            this.class_table_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.class_table_1.Size = new System.Drawing.Size(230, 27);
            this.class_table_1.TabIndex = 7;
            // 
            // f_class_1
            // 
            this.f_class_1.AutoSize = true;
            this.f_class_1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.f_class_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f_class_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f_class_1.ForeColor = System.Drawing.Color.Black;
            this.f_class_1.Location = new System.Drawing.Point(4, 4);
            this.f_class_1.Name = "f_class_1";
            this.f_class_1.Size = new System.Drawing.Size(14, 19);
            this.f_class_1.TabIndex = 0;
            this.f_class_1.UseVisualStyleBackColor = true;
            this.f_class_1.CheckedChanged += new System.EventHandler(this.f_class_1_CheckedChanged);
            // 
            // class_level_box_1
            // 
            this.class_level_box_1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.class_level_box_1.BackColor = System.Drawing.Color.Gainsboro;
            this.class_level_box_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.class_level_box_1.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_level_box_1.Location = new System.Drawing.Point(126, 6);
            this.class_level_box_1.Name = "class_level_box_1";
            this.class_level_box_1.Size = new System.Drawing.Size(19, 14);
            this.class_level_box_1.TabIndex = 18;
            this.class_level_box_1.Text = "0";
            this.class_level_box_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.class_level_box_1.TextChanged += new System.EventHandler(this.class_level_box_1_TextChanged);
            // 
            // class_hd_box_1
            // 
            this.class_hd_box_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.class_hd_box_1.BackColor = System.Drawing.Color.Gainsboro;
            this.class_hd_box_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.class_hd_box_1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_hd_box_1.Location = new System.Drawing.Point(152, 6);
            this.class_hd_box_1.Name = "class_hd_box_1";
            this.class_hd_box_1.Size = new System.Drawing.Size(43, 14);
            this.class_hd_box_1.TabIndex = 19;
            this.class_hd_box_1.Text = "hitDie1";
            this.class_hd_box_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.class_hd_box_1.TextChanged += new System.EventHandler(this.class_hd_box_1_TextChanged);
            // 
            // class_name_box_1
            // 
            this.class_name_box_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.class_name_box_1.BackColor = System.Drawing.Color.Gainsboro;
            this.class_name_box_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.class_name_box_1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_name_box_1.Location = new System.Drawing.Point(29, 6);
            this.class_name_box_1.Name = "class_name_box_1";
            this.class_name_box_1.Size = new System.Drawing.Size(85, 15);
            this.class_name_box_1.TabIndex = 17;
            this.class_name_box_1.Text = "className1";
            this.class_name_box_1.TextChanged += new System.EventHandler(this.class_name_box_1_TextChanged);
            // 
            // class_skill_box_1
            // 
            this.class_skill_box_1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.class_skill_box_1.BackColor = System.Drawing.Color.Gainsboro;
            this.class_skill_box_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.class_skill_box_1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_skill_box_1.Location = new System.Drawing.Point(202, 6);
            this.class_skill_box_1.Name = "class_skill_box_1";
            this.class_skill_box_1.Size = new System.Drawing.Size(24, 14);
            this.class_skill_box_1.TabIndex = 20;
            this.class_skill_box_1.Text = "0";
            this.class_skill_box_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.class_skill_box_1.TextChanged += new System.EventHandler(this.class_skill_box_1_TextChanged);
            // 
            // class_table_2
            // 
            this.class_table_2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.class_table_2.ColumnCount = 5;
            this.class_table_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.class_table_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.class_table_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.class_table_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.class_table_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.class_table_2.Controls.Add(this.f_class_2, 0, 0);
            this.class_table_2.Controls.Add(this.class_level_box_2, 2, 0);
            this.class_table_2.Controls.Add(this.class_hd_box_2, 3, 0);
            this.class_table_2.Controls.Add(this.class_name_box_2, 1, 0);
            this.class_table_2.Controls.Add(this.class_skill_box_2, 4, 0);
            this.class_table_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.class_table_2.Location = new System.Drawing.Point(3, 61);
            this.class_table_2.Margin = new System.Windows.Forms.Padding(2);
            this.class_table_2.Name = "class_table_2";
            this.class_table_2.RowCount = 1;
            this.class_table_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.class_table_2.Size = new System.Drawing.Size(230, 25);
            this.class_table_2.TabIndex = 7;
            // 
            // f_class_2
            // 
            this.f_class_2.AutoSize = true;
            this.f_class_2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.f_class_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f_class_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f_class_2.ForeColor = System.Drawing.Color.Black;
            this.f_class_2.Location = new System.Drawing.Point(4, 4);
            this.f_class_2.Name = "f_class_2";
            this.f_class_2.Size = new System.Drawing.Size(14, 17);
            this.f_class_2.TabIndex = 0;
            this.f_class_2.UseVisualStyleBackColor = true;
            this.f_class_2.CheckedChanged += new System.EventHandler(this.f_class_2_CheckedChanged);
            // 
            // class_level_box_2
            // 
            this.class_level_box_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.class_level_box_2.BackColor = System.Drawing.Color.Gainsboro;
            this.class_level_box_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.class_level_box_2.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_level_box_2.Location = new System.Drawing.Point(126, 5);
            this.class_level_box_2.Name = "class_level_box_2";
            this.class_level_box_2.Size = new System.Drawing.Size(19, 14);
            this.class_level_box_2.TabIndex = 5;
            this.class_level_box_2.Text = "0";
            this.class_level_box_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.class_level_box_2.TextChanged += new System.EventHandler(this.class_level_box_2_TextChanged);
            // 
            // class_hd_box_2
            // 
            this.class_hd_box_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.class_hd_box_2.BackColor = System.Drawing.Color.Gainsboro;
            this.class_hd_box_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.class_hd_box_2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_hd_box_2.Location = new System.Drawing.Point(152, 5);
            this.class_hd_box_2.Name = "class_hd_box_2";
            this.class_hd_box_2.Size = new System.Drawing.Size(43, 14);
            this.class_hd_box_2.TabIndex = 5;
            this.class_hd_box_2.Text = "hitDie2";
            this.class_hd_box_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.class_hd_box_2.TextChanged += new System.EventHandler(this.class_hd_box_2_TextChanged);
            // 
            // class_name_box_2
            // 
            this.class_name_box_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.class_name_box_2.BackColor = System.Drawing.Color.Gainsboro;
            this.class_name_box_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.class_name_box_2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_name_box_2.Location = new System.Drawing.Point(29, 5);
            this.class_name_box_2.Name = "class_name_box_2";
            this.class_name_box_2.Size = new System.Drawing.Size(85, 15);
            this.class_name_box_2.TabIndex = 5;
            this.class_name_box_2.Text = "className2";
            this.class_name_box_2.TextChanged += new System.EventHandler(this.class_name_box_2_TextChanged);
            // 
            // class_skill_box_2
            // 
            this.class_skill_box_2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.class_skill_box_2.BackColor = System.Drawing.Color.Gainsboro;
            this.class_skill_box_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.class_skill_box_2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_skill_box_2.Location = new System.Drawing.Point(202, 5);
            this.class_skill_box_2.Name = "class_skill_box_2";
            this.class_skill_box_2.Size = new System.Drawing.Size(24, 14);
            this.class_skill_box_2.TabIndex = 5;
            this.class_skill_box_2.Text = "0";
            this.class_skill_box_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.class_skill_box_2.TextChanged += new System.EventHandler(this.class_skill_box_2_TextChanged);
            // 
            // class_table_3
            // 
            this.class_table_3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.class_table_3.ColumnCount = 5;
            this.class_table_3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.class_table_3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.class_table_3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.class_table_3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.class_table_3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.class_table_3.Controls.Add(this.f_class_3, 0, 0);
            this.class_table_3.Controls.Add(this.class_level_box_3, 2, 0);
            this.class_table_3.Controls.Add(this.class_hd_box_3, 3, 0);
            this.class_table_3.Controls.Add(this.class_name_box_3, 1, 0);
            this.class_table_3.Controls.Add(this.class_skill_box_3, 4, 0);
            this.class_table_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.class_table_3.Location = new System.Drawing.Point(3, 91);
            this.class_table_3.Margin = new System.Windows.Forms.Padding(2);
            this.class_table_3.Name = "class_table_3";
            this.class_table_3.RowCount = 1;
            this.class_table_3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.class_table_3.Size = new System.Drawing.Size(230, 25);
            this.class_table_3.TabIndex = 7;
            // 
            // f_class_3
            // 
            this.f_class_3.AutoSize = true;
            this.f_class_3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.f_class_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f_class_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f_class_3.ForeColor = System.Drawing.Color.Black;
            this.f_class_3.Location = new System.Drawing.Point(4, 4);
            this.f_class_3.Name = "f_class_3";
            this.f_class_3.Size = new System.Drawing.Size(14, 17);
            this.f_class_3.TabIndex = 0;
            this.f_class_3.UseVisualStyleBackColor = true;
            this.f_class_3.CheckedChanged += new System.EventHandler(this.f_class_3_CheckedChanged);
            // 
            // class_level_box_3
            // 
            this.class_level_box_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.class_level_box_3.BackColor = System.Drawing.Color.Gainsboro;
            this.class_level_box_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.class_level_box_3.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_level_box_3.Location = new System.Drawing.Point(126, 5);
            this.class_level_box_3.Name = "class_level_box_3";
            this.class_level_box_3.Size = new System.Drawing.Size(19, 14);
            this.class_level_box_3.TabIndex = 5;
            this.class_level_box_3.Text = "0";
            this.class_level_box_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.class_level_box_3.TextChanged += new System.EventHandler(this.class_level_box_3_TextChanged);
            // 
            // class_hd_box_3
            // 
            this.class_hd_box_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.class_hd_box_3.BackColor = System.Drawing.Color.Gainsboro;
            this.class_hd_box_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.class_hd_box_3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_hd_box_3.Location = new System.Drawing.Point(152, 5);
            this.class_hd_box_3.Name = "class_hd_box_3";
            this.class_hd_box_3.Size = new System.Drawing.Size(43, 14);
            this.class_hd_box_3.TabIndex = 5;
            this.class_hd_box_3.Text = "hitDie3";
            this.class_hd_box_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.class_hd_box_3.TextChanged += new System.EventHandler(this.class_hd_box_3_TextChanged);
            // 
            // class_name_box_3
            // 
            this.class_name_box_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.class_name_box_3.BackColor = System.Drawing.Color.Gainsboro;
            this.class_name_box_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.class_name_box_3.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_name_box_3.Location = new System.Drawing.Point(29, 5);
            this.class_name_box_3.Name = "class_name_box_3";
            this.class_name_box_3.Size = new System.Drawing.Size(85, 15);
            this.class_name_box_3.TabIndex = 5;
            this.class_name_box_3.Text = "className3";
            this.class_name_box_3.TextChanged += new System.EventHandler(this.class_name_box_3_TextChanged);
            // 
            // class_skill_box_3
            // 
            this.class_skill_box_3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.class_skill_box_3.BackColor = System.Drawing.Color.Gainsboro;
            this.class_skill_box_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.class_skill_box_3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_skill_box_3.Location = new System.Drawing.Point(202, 5);
            this.class_skill_box_3.Name = "class_skill_box_3";
            this.class_skill_box_3.Size = new System.Drawing.Size(24, 14);
            this.class_skill_box_3.TabIndex = 5;
            this.class_skill_box_3.Text = "0";
            this.class_skill_box_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.class_skill_box_3.TextChanged += new System.EventHandler(this.class_skill_box_3_TextChanged);
            // 
            // class_table_4
            // 
            this.class_table_4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.class_table_4.ColumnCount = 5;
            this.class_table_4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.class_table_4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.class_table_4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.class_table_4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.class_table_4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.class_table_4.Controls.Add(this.f_class_4, 0, 0);
            this.class_table_4.Controls.Add(this.class_level_box_4, 2, 0);
            this.class_table_4.Controls.Add(this.class_hd_box_4, 3, 0);
            this.class_table_4.Controls.Add(this.class_name_box_4, 1, 0);
            this.class_table_4.Controls.Add(this.class_skill_box_4, 4, 0);
            this.class_table_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.class_table_4.Location = new System.Drawing.Point(3, 121);
            this.class_table_4.Margin = new System.Windows.Forms.Padding(2);
            this.class_table_4.Name = "class_table_4";
            this.class_table_4.RowCount = 1;
            this.class_table_4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.class_table_4.Size = new System.Drawing.Size(230, 25);
            this.class_table_4.TabIndex = 7;
            // 
            // f_class_4
            // 
            this.f_class_4.AutoSize = true;
            this.f_class_4.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.f_class_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f_class_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f_class_4.ForeColor = System.Drawing.Color.Black;
            this.f_class_4.Location = new System.Drawing.Point(4, 4);
            this.f_class_4.Name = "f_class_4";
            this.f_class_4.Size = new System.Drawing.Size(14, 17);
            this.f_class_4.TabIndex = 0;
            this.f_class_4.UseVisualStyleBackColor = true;
            this.f_class_4.CheckedChanged += new System.EventHandler(this.f_class_4_CheckedChanged);
            // 
            // class_level_box_4
            // 
            this.class_level_box_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.class_level_box_4.BackColor = System.Drawing.Color.Gainsboro;
            this.class_level_box_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.class_level_box_4.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_level_box_4.Location = new System.Drawing.Point(126, 5);
            this.class_level_box_4.Name = "class_level_box_4";
            this.class_level_box_4.Size = new System.Drawing.Size(19, 14);
            this.class_level_box_4.TabIndex = 5;
            this.class_level_box_4.Text = "0";
            this.class_level_box_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.class_level_box_4.TextChanged += new System.EventHandler(this.class_level_box_4_TextChanged);
            // 
            // class_hd_box_4
            // 
            this.class_hd_box_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.class_hd_box_4.BackColor = System.Drawing.Color.Gainsboro;
            this.class_hd_box_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.class_hd_box_4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_hd_box_4.Location = new System.Drawing.Point(152, 5);
            this.class_hd_box_4.Name = "class_hd_box_4";
            this.class_hd_box_4.Size = new System.Drawing.Size(43, 14);
            this.class_hd_box_4.TabIndex = 5;
            this.class_hd_box_4.Text = "hitDie4";
            this.class_hd_box_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.class_hd_box_4.TextChanged += new System.EventHandler(this.class_hd_box_4_TextChanged);
            // 
            // class_name_box_4
            // 
            this.class_name_box_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.class_name_box_4.BackColor = System.Drawing.Color.Gainsboro;
            this.class_name_box_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.class_name_box_4.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_name_box_4.Location = new System.Drawing.Point(29, 5);
            this.class_name_box_4.Name = "class_name_box_4";
            this.class_name_box_4.Size = new System.Drawing.Size(85, 15);
            this.class_name_box_4.TabIndex = 5;
            this.class_name_box_4.Text = "className4";
            this.class_name_box_4.TextChanged += new System.EventHandler(this.class_name_box_4_TextChanged);
            // 
            // class_skill_box_4
            // 
            this.class_skill_box_4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.class_skill_box_4.BackColor = System.Drawing.Color.Gainsboro;
            this.class_skill_box_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.class_skill_box_4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_skill_box_4.Location = new System.Drawing.Point(202, 5);
            this.class_skill_box_4.Name = "class_skill_box_4";
            this.class_skill_box_4.Size = new System.Drawing.Size(24, 14);
            this.class_skill_box_4.TabIndex = 5;
            this.class_skill_box_4.Text = "0";
            this.class_skill_box_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.class_skill_box_4.TextChanged += new System.EventHandler(this.class_skill_box_4_TextChanged);
            // 
            // class_table_5
            // 
            this.class_table_5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.class_table_5.ColumnCount = 5;
            this.class_table_5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.class_table_5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.class_table_5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.class_table_5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.class_table_5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.class_table_5.Controls.Add(this.f_class_5, 0, 0);
            this.class_table_5.Controls.Add(this.class_level_box_5, 2, 0);
            this.class_table_5.Controls.Add(this.class_hd_box_5, 3, 0);
            this.class_table_5.Controls.Add(this.class_name_box_5, 1, 0);
            this.class_table_5.Controls.Add(this.class_skill_box_5, 4, 0);
            this.class_table_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.class_table_5.Location = new System.Drawing.Point(3, 151);
            this.class_table_5.Margin = new System.Windows.Forms.Padding(2);
            this.class_table_5.Name = "class_table_5";
            this.class_table_5.RowCount = 1;
            this.class_table_5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.class_table_5.Size = new System.Drawing.Size(230, 27);
            this.class_table_5.TabIndex = 7;
            // 
            // f_class_5
            // 
            this.f_class_5.AutoSize = true;
            this.f_class_5.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.f_class_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f_class_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f_class_5.ForeColor = System.Drawing.Color.Black;
            this.f_class_5.Location = new System.Drawing.Point(4, 4);
            this.f_class_5.Name = "f_class_5";
            this.f_class_5.Size = new System.Drawing.Size(14, 19);
            this.f_class_5.TabIndex = 0;
            this.f_class_5.UseVisualStyleBackColor = true;
            this.f_class_5.CheckedChanged += new System.EventHandler(this.f_class_5_CheckedChanged);
            // 
            // class_level_box_5
            // 
            this.class_level_box_5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.class_level_box_5.BackColor = System.Drawing.Color.Gainsboro;
            this.class_level_box_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.class_level_box_5.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_level_box_5.Location = new System.Drawing.Point(126, 6);
            this.class_level_box_5.Name = "class_level_box_5";
            this.class_level_box_5.Size = new System.Drawing.Size(19, 14);
            this.class_level_box_5.TabIndex = 5;
            this.class_level_box_5.Text = "0";
            this.class_level_box_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.class_level_box_5.TextChanged += new System.EventHandler(this.class_level_box_5_TextChanged);
            // 
            // class_hd_box_5
            // 
            this.class_hd_box_5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.class_hd_box_5.BackColor = System.Drawing.Color.Gainsboro;
            this.class_hd_box_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.class_hd_box_5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_hd_box_5.Location = new System.Drawing.Point(152, 6);
            this.class_hd_box_5.Name = "class_hd_box_5";
            this.class_hd_box_5.Size = new System.Drawing.Size(43, 14);
            this.class_hd_box_5.TabIndex = 5;
            this.class_hd_box_5.Text = "hitDie5";
            this.class_hd_box_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.class_hd_box_5.TextChanged += new System.EventHandler(this.class_hd_box_5_TextChanged);
            // 
            // class_name_box_5
            // 
            this.class_name_box_5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.class_name_box_5.BackColor = System.Drawing.Color.Gainsboro;
            this.class_name_box_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.class_name_box_5.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_name_box_5.Location = new System.Drawing.Point(29, 6);
            this.class_name_box_5.Name = "class_name_box_5";
            this.class_name_box_5.Size = new System.Drawing.Size(85, 15);
            this.class_name_box_5.TabIndex = 5;
            this.class_name_box_5.Text = "className5";
            this.class_name_box_5.TextChanged += new System.EventHandler(this.class_name_box_5_TextChanged);
            // 
            // class_skill_box_5
            // 
            this.class_skill_box_5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.class_skill_box_5.BackColor = System.Drawing.Color.Gainsboro;
            this.class_skill_box_5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.class_skill_box_5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_skill_box_5.Location = new System.Drawing.Point(202, 6);
            this.class_skill_box_5.Name = "class_skill_box_5";
            this.class_skill_box_5.Size = new System.Drawing.Size(24, 14);
            this.class_skill_box_5.TabIndex = 5;
            this.class_skill_box_5.Text = "0";
            this.class_skill_box_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.class_skill_box_5.TextChanged += new System.EventHandler(this.class_skill_box_5_TextChanged);
            // 
            // classes_label
            // 
            this.classes_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.classes_label.AutoSize = true;
            this.classes_label.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classes_label.ForeColor = System.Drawing.Color.Black;
            this.classes_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.classes_label.Location = new System.Drawing.Point(2, 12);
            this.classes_label.Margin = new System.Windows.Forms.Padding(1);
            this.classes_label.Name = "classes_label";
            this.classes_label.Size = new System.Drawing.Size(232, 13);
            this.classes_label.TabIndex = 0;
            this.classes_label.Text = "Classes                                           Lvl           HD             Sk" +
    "ill";
            this.classes_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // char_panel
            // 
            this.char_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.char_panel.Controls.Add(this.subtitle_box);
            this.char_panel.Controls.Add(this.char_name_box);
            this.char_panel.Controls.Add(this.char_info_table);
            this.char_panel.Controls.Add(this.avatar_panel);
            this.char_panel.Location = new System.Drawing.Point(3, 25);
            this.char_panel.Name = "char_panel";
            this.char_panel.Size = new System.Drawing.Size(376, 132);
            this.char_panel.TabIndex = 0;
            // 
            // subtitle_box
            // 
            this.subtitle_box.BackColor = System.Drawing.Color.Gainsboro;
            this.subtitle_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subtitle_box.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitle_box.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.subtitle_box.Location = new System.Drawing.Point(139, 35);
            this.subtitle_box.Name = "subtitle_box";
            this.subtitle_box.Size = new System.Drawing.Size(225, 14);
            this.subtitle_box.TabIndex = 2;
            this.subtitle_box.Text = "subtitle";
            this.subtitle_box.TextChanged += new System.EventHandler(this.subtitle_box_TextChanged);
            // 
            // char_name_box
            // 
            this.char_name_box.BackColor = System.Drawing.Color.Gainsboro;
            this.char_name_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.char_name_box.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.char_name_box.Location = new System.Drawing.Point(139, 11);
            this.char_name_box.Name = "char_name_box";
            this.char_name_box.Size = new System.Drawing.Size(225, 23);
            this.char_name_box.TabIndex = 1;
            this.char_name_box.Text = "CharacterName";
            this.char_name_box.TextChanged += new System.EventHandler(this.char_name_box_TextChanged);
            // 
            // char_info_table
            // 
            this.char_info_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.char_info_table.ColumnCount = 1;
            this.char_info_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.char_info_table.Controls.Add(this.rsg_table, 0, 0);
            this.char_info_table.Controls.Add(this.lvl_ali_table, 0, 1);
            this.char_info_table.Location = new System.Drawing.Point(131, 59);
            this.char_info_table.Name = "char_info_table";
            this.char_info_table.RowCount = 2;
            this.char_info_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.char_info_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.char_info_table.Size = new System.Drawing.Size(244, 74);
            this.char_info_table.TabIndex = 3;
            // 
            // rsg_table
            // 
            this.rsg_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.rsg_table.ColumnCount = 3;
            this.rsg_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.rsg_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.rsg_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.rsg_table.Controls.Add(this.gender_box, 0, 0);
            this.rsg_table.Controls.Add(this.size_box, 0, 0);
            this.rsg_table.Controls.Add(this.race_box, 0, 0);
            this.rsg_table.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rsg_table.Location = new System.Drawing.Point(5, 5);
            this.rsg_table.Name = "rsg_table";
            this.rsg_table.RowCount = 1;
            this.rsg_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rsg_table.Size = new System.Drawing.Size(234, 20);
            this.rsg_table.TabIndex = 0;
            // 
            // gender_box
            // 
            this.gender_box.BackColor = System.Drawing.Color.Gainsboro;
            this.gender_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gender_box.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_box.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.gender_box.Location = new System.Drawing.Point(156, 2);
            this.gender_box.Margin = new System.Windows.Forms.Padding(0);
            this.gender_box.Name = "gender_box";
            this.gender_box.Size = new System.Drawing.Size(72, 14);
            this.gender_box.TabIndex = 5;
            this.gender_box.Text = "gender";
            this.gender_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gender_box.TextChanged += new System.EventHandler(this.gender_box_TextChanged);
            // 
            // size_box
            // 
            this.size_box.BackColor = System.Drawing.Color.Gainsboro;
            this.size_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.size_box.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size_box.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.size_box.Location = new System.Drawing.Point(79, 2);
            this.size_box.Margin = new System.Windows.Forms.Padding(0);
            this.size_box.Name = "size_box";
            this.size_box.Size = new System.Drawing.Size(72, 14);
            this.size_box.TabIndex = 4;
            this.size_box.Text = "size";
            this.size_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.size_box.TextChanged += new System.EventHandler(this.size_box_TextChanged);
            // 
            // race_box
            // 
            this.race_box.BackColor = System.Drawing.Color.Gainsboro;
            this.race_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.race_box.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race_box.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.race_box.Location = new System.Drawing.Point(2, 2);
            this.race_box.Margin = new System.Windows.Forms.Padding(0);
            this.race_box.Name = "race_box";
            this.race_box.Size = new System.Drawing.Size(75, 14);
            this.race_box.TabIndex = 3;
            this.race_box.Text = "race";
            this.race_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.race_box.TextChanged += new System.EventHandler(this.race_box_TextChanged);
            // 
            // lvl_ali_table
            // 
            this.lvl_ali_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.lvl_ali_table.ColumnCount = 2;
            this.lvl_ali_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.36207F));
            this.lvl_ali_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.63793F));
            this.lvl_ali_table.Controls.Add(this.alignment_box, 1, 0);
            this.lvl_ali_table.Controls.Add(this.char_level_table, 0, 0);
            this.lvl_ali_table.Location = new System.Drawing.Point(5, 34);
            this.lvl_ali_table.Name = "lvl_ali_table";
            this.lvl_ali_table.RowCount = 1;
            this.lvl_ali_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lvl_ali_table.Size = new System.Drawing.Size(234, 34);
            this.lvl_ali_table.TabIndex = 1;
            // 
            // alignment_box
            // 
            this.alignment_box.BackColor = System.Drawing.Color.Gainsboro;
            this.alignment_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alignment_box.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alignment_box.Location = new System.Drawing.Point(94, 5);
            this.alignment_box.Name = "alignment_box";
            this.alignment_box.Size = new System.Drawing.Size(122, 20);
            this.alignment_box.TabIndex = 7;
            this.alignment_box.Text = "Alignment";
            this.alignment_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.alignment_box.TextChanged += new System.EventHandler(this.alignment_box_TextChanged);
            // 
            // char_level_table
            // 
            this.char_level_table.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.char_level_table.ColumnCount = 2;
            this.char_level_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.02299F));
            this.char_level_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.97701F));
            this.char_level_table.Controls.Add(this.char_level_label, 0, 0);
            this.char_level_table.Controls.Add(this.char_level_box, 1, 0);
            this.char_level_table.Location = new System.Drawing.Point(2, 2);
            this.char_level_table.Margin = new System.Windows.Forms.Padding(0);
            this.char_level_table.Name = "char_level_table";
            this.char_level_table.RowCount = 1;
            this.char_level_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.char_level_table.Size = new System.Drawing.Size(87, 30);
            this.char_level_table.TabIndex = 2;
            // 
            // char_level_label
            // 
            this.char_level_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.char_level_label.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.char_level_label.ForeColor = System.Drawing.Color.Black;
            this.char_level_label.Location = new System.Drawing.Point(0, 1);
            this.char_level_label.Margin = new System.Windows.Forms.Padding(0);
            this.char_level_label.Name = "char_level_label";
            this.char_level_label.Size = new System.Drawing.Size(46, 27);
            this.char_level_label.TabIndex = 6;
            this.char_level_label.Text = "Lvl:";
            this.char_level_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // char_level_box
            // 
            this.char_level_box.BackColor = System.Drawing.Color.Gainsboro;
            this.char_level_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.char_level_box.Dock = System.Windows.Forms.DockStyle.Left;
            this.char_level_box.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.char_level_box.Location = new System.Drawing.Point(47, 2);
            this.char_level_box.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.char_level_box.Name = "char_level_box";
            this.char_level_box.Size = new System.Drawing.Size(40, 26);
            this.char_level_box.TabIndex = 6;
            this.char_level_box.Text = "0";
            this.char_level_box.TextChanged += new System.EventHandler(this.char_level_box_TextChanged);
            // 
            // avatar_panel
            // 
            this.avatar_panel.BackColor = System.Drawing.Color.YellowGreen;
            this.avatar_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avatar_panel.Controls.Add(this.char_image);
            this.avatar_panel.Location = new System.Drawing.Point(0, 0);
            this.avatar_panel.Name = "avatar_panel";
            this.avatar_panel.Size = new System.Drawing.Size(132, 132);
            this.avatar_panel.TabIndex = 0;
            this.avatar_panel.DoubleClick += new System.EventHandler(this.avatar_panel_Click);
            // 
            // char_image
            // 
            this.char_image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.char_image.Location = new System.Drawing.Point(10, 10);
            this.char_image.Name = "char_image";
            this.char_image.Size = new System.Drawing.Size(110, 110);
            this.char_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.char_image.TabIndex = 0;
            this.char_image.TabStop = false;
            this.char_image.Click += new System.EventHandler(this.char_image_Click);
            // 
            // CharacterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.main_panel);
            this.Name = "CharacterWindow";
            this.Size = new System.Drawing.Size(822, 540);
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.bab_panel.ResumeLayout(false);
            this.bab_panel.PerformLayout();
            this.menu_strip.ResumeLayout(false);
            this.menu_strip.PerformLayout();
            this.hp_text_panel.ResumeLayout(false);
            this.hp_text_panel.PerformLayout();
            this.skill_panel_back.ResumeLayout(false);
            this.skill_panel_back.PerformLayout();
            this.saves_table_1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.saves_table_2.ResumeLayout(false);
            this.saves_table_2.PerformLayout();
            this.ability_table.ResumeLayout(false);
            this.ability_table.PerformLayout();
            this.ac_table.ResumeLayout(false);
            this.ac_table.PerformLayout();
            this.init_panel.ResumeLayout(false);
            this.init_panel.PerformLayout();
            this.classes_table.ResumeLayout(false);
            this.classes_table.PerformLayout();
            this.class_table_1.ResumeLayout(false);
            this.class_table_1.PerformLayout();
            this.class_table_2.ResumeLayout(false);
            this.class_table_2.PerformLayout();
            this.class_table_3.ResumeLayout(false);
            this.class_table_3.PerformLayout();
            this.class_table_4.ResumeLayout(false);
            this.class_table_4.PerformLayout();
            this.class_table_5.ResumeLayout(false);
            this.class_table_5.PerformLayout();
            this.char_panel.ResumeLayout(false);
            this.char_panel.PerformLayout();
            this.char_info_table.ResumeLayout(false);
            this.rsg_table.ResumeLayout(false);
            this.rsg_table.PerformLayout();
            this.lvl_ali_table.ResumeLayout(false);
            this.lvl_ali_table.PerformLayout();
            this.char_level_table.ResumeLayout(false);
            this.char_level_table.PerformLayout();
            this.avatar_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.char_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Button spell_butt;
        private System.Windows.Forms.Button inv_butt;
        private System.Windows.Forms.Panel hp_text_panel;
        private System.Windows.Forms.TextBox max_hp_box;
        private System.Windows.Forms.TextBox hp_box;
        private System.Windows.Forms.Label hp_slash_label;
        private System.Windows.Forms.RichTextBox char_notes_box;
        private System.Windows.Forms.Panel skill_panel_back;
        private System.Windows.Forms.Label skills_label;
        private System.Windows.Forms.FlowLayoutPanel skill_panel;
        private System.Windows.Forms.Label touch_ac_label;
        private System.Windows.Forms.Label ff_ac_label;
        private System.Windows.Forms.TextBox speed_box;
        private System.Windows.Forms.Label speed_label;
        private System.Windows.Forms.TableLayoutPanel saves_table_1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label saves_label;
        private System.Windows.Forms.TableLayoutPanel saves_table_2;
        private System.Windows.Forms.TextBox fort_save_box;
        private System.Windows.Forms.TextBox will_save_box;
        private System.Windows.Forms.TextBox ref_save_box;
        private System.Windows.Forms.TableLayoutPanel ability_table;
        private System.Windows.Forms.TextBox str_box;
        private System.Windows.Forms.Label str_label;
        private System.Windows.Forms.Label dex_label;
        private System.Windows.Forms.Label con_label;
        private System.Windows.Forms.Label int_label;
        private System.Windows.Forms.Label wis_label;
        private System.Windows.Forms.Label cha_label;
        private System.Windows.Forms.TextBox dex_box;
        private System.Windows.Forms.TextBox con_box;
        private System.Windows.Forms.TextBox int_box;
        private System.Windows.Forms.TextBox wis_box;
        private System.Windows.Forms.TextBox cha_box;
        private System.Windows.Forms.TextBox str_mod_label;
        private System.Windows.Forms.TextBox dex_mod_label;
        private System.Windows.Forms.TextBox con_mod_label;
        private System.Windows.Forms.TextBox int_mod_label;
        private System.Windows.Forms.TextBox wis_mod_label;
        private System.Windows.Forms.TextBox cha_mod_label;
        private System.Windows.Forms.TableLayoutPanel ac_table;
        private System.Windows.Forms.TextBox ff_ac_box;
        private System.Windows.Forms.TextBox touch_ac_box;
        private System.Windows.Forms.Panel init_panel;
        private System.Windows.Forms.Label init_label;
        private System.Windows.Forms.Label ac_label;
        private System.Windows.Forms.TextBox init_box;
        private System.Windows.Forms.TextBox ac_box;
        private System.Windows.Forms.TableLayoutPanel classes_table;
        private System.Windows.Forms.TableLayoutPanel class_table_1;
        private System.Windows.Forms.CheckBox f_class_1;
        private System.Windows.Forms.TextBox class_level_box_1;
        private System.Windows.Forms.TextBox class_hd_box_1;
        private System.Windows.Forms.TextBox class_name_box_1;
        private System.Windows.Forms.TextBox class_skill_box_1;
        private System.Windows.Forms.TableLayoutPanel class_table_2;
        private System.Windows.Forms.CheckBox f_class_2;
        private System.Windows.Forms.TextBox class_level_box_2;
        private System.Windows.Forms.TextBox class_hd_box_2;
        private System.Windows.Forms.TextBox class_name_box_2;
        private System.Windows.Forms.TextBox class_skill_box_2;
        private System.Windows.Forms.TableLayoutPanel class_table_3;
        private System.Windows.Forms.CheckBox f_class_3;
        private System.Windows.Forms.TextBox class_level_box_3;
        private System.Windows.Forms.TextBox class_hd_box_3;
        private System.Windows.Forms.TextBox class_name_box_3;
        private System.Windows.Forms.TextBox class_skill_box_3;
        private System.Windows.Forms.TableLayoutPanel class_table_4;
        private System.Windows.Forms.CheckBox f_class_4;
        private System.Windows.Forms.TextBox class_level_box_4;
        private System.Windows.Forms.TextBox class_hd_box_4;
        private System.Windows.Forms.TextBox class_name_box_4;
        private System.Windows.Forms.TextBox class_skill_box_4;
        private System.Windows.Forms.TableLayoutPanel class_table_5;
        private System.Windows.Forms.CheckBox f_class_5;
        private System.Windows.Forms.TextBox class_level_box_5;
        private System.Windows.Forms.TextBox class_hd_box_5;
        private System.Windows.Forms.TextBox class_name_box_5;
        private System.Windows.Forms.TextBox class_skill_box_5;
        private System.Windows.Forms.Panel char_panel;
        private System.Windows.Forms.TextBox subtitle_box;
        private System.Windows.Forms.TextBox char_name_box;
        private System.Windows.Forms.TableLayoutPanel char_info_table;
        private System.Windows.Forms.TableLayoutPanel rsg_table;
        private System.Windows.Forms.TextBox gender_box;
        private System.Windows.Forms.TextBox size_box;
        private System.Windows.Forms.TextBox race_box;
        private System.Windows.Forms.TableLayoutPanel lvl_ali_table;
        private System.Windows.Forms.TextBox alignment_box;
        private System.Windows.Forms.TableLayoutPanel char_level_table;
        private System.Windows.Forms.Label char_level_label;
        private System.Windows.Forms.TextBox char_level_box;
        private System.Windows.Forms.Panel avatar_panel;
        private System.Windows.Forms.PictureBox char_image;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCharacterAsToolStripMenuItem;
        private System.Windows.Forms.Panel bab_panel;
        private System.Windows.Forms.TextBox bab_box;
        private System.Windows.Forms.TextBox melee_box;
        private System.Windows.Forms.TextBox ranged_box;
        private System.Windows.Forms.Label ranged_label;
        private System.Windows.Forms.Label bab_label;
        private System.Windows.Forms.Label melee_label;
        private PanelBar exp_bar;
        private System.Windows.Forms.TextBox exp_box;
        private System.Windows.Forms.TextBox max_exp_box;
        private System.Windows.Forms.Label exp_slash;
        private PanelBar health_bar;
        private System.Windows.Forms.ToolStripMenuItem skillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPathfinderSkillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSkillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCharacterToolStripMenuItem;
        private System.Windows.Forms.Label classes_label;
        private System.Windows.Forms.Button skill_clear_butt;
        private System.Windows.Forms.MenuStrip menu_strip;
    }
}
