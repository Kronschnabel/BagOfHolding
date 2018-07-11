namespace BagOfHolding
{
    partial class ArmorBox
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
            this.armor_table = new System.Windows.Forms.TableLayoutPanel();
            this.item_info_table = new System.Windows.Forms.TableLayoutPanel();
            this.weight_box = new System.Windows.Forms.TextBox();
            this.cost_box = new System.Windows.Forms.TextBox();
            this.item_name_box = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.weapon_info_table = new System.Windows.Forms.TableLayoutPanel();
            this.speed_box = new System.Windows.Forms.TextBox();
            this.ac_box = new System.Windows.Forms.TextBox();
            this.max_dex_box = new System.Windows.Forms.TextBox();
            this.penalty_box = new System.Windows.Forms.TextBox();
            this.spell_fail_box = new System.Windows.Forms.TextBox();
            this.spell_fail_label = new System.Windows.Forms.Label();
            this.size_label = new System.Windows.Forms.Label();
            this.penalty_label = new System.Windows.Forms.Label();
            this.speed_label = new System.Windows.Forms.Label();
            this.max_dex_label = new System.Windows.Forms.Label();
            this.ac_label = new System.Windows.Forms.Label();
            this.size_box = new System.Windows.Forms.TextBox();
            this.notes_box = new System.Windows.Forms.RichTextBox();
            this.equipped_box = new System.Windows.Forms.CheckBox();
            this.armor_table.SuspendLayout();
            this.item_info_table.SuspendLayout();
            this.panel1.SuspendLayout();
            this.weapon_info_table.SuspendLayout();
            this.SuspendLayout();
            // 
            // armor_table
            // 
            this.armor_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.armor_table.ColumnCount = 2;
            this.armor_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.armor_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 410F));
            this.armor_table.Controls.Add(this.item_info_table, 1, 0);
            this.armor_table.Controls.Add(this.panel1, 1, 1);
            this.armor_table.Controls.Add(this.equipped_box, 0, 0);
            this.armor_table.Location = new System.Drawing.Point(0, 0);
            this.armor_table.Name = "armor_table";
            this.armor_table.RowCount = 2;
            this.armor_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.armor_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.armor_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.armor_table.Size = new System.Drawing.Size(451, 175);
            this.armor_table.TabIndex = 3;
            this.armor_table.DoubleClick += new System.EventHandler(this.armor_table_DoubleClick);
            // 
            // item_info_table
            // 
            this.item_info_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.item_info_table.ColumnCount = 3;
            this.item_info_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.27586F));
            this.item_info_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.72414F));
            this.item_info_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.item_info_table.Controls.Add(this.weight_box, 0, 0);
            this.item_info_table.Controls.Add(this.cost_box, 1, 0);
            this.item_info_table.Controls.Add(this.item_name_box, 0, 0);
            this.item_info_table.Location = new System.Drawing.Point(43, 4);
            this.item_info_table.Name = "item_info_table";
            this.item_info_table.RowCount = 1;
            this.item_info_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.item_info_table.Size = new System.Drawing.Size(403, 27);
            this.item_info_table.TabIndex = 1;
            // 
            // weight_box
            // 
            this.weight_box.BackColor = System.Drawing.Color.Gainsboro;
            this.weight_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.weight_box.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.weight_box.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_box.Location = new System.Drawing.Point(213, 4);
            this.weight_box.Name = "weight_box";
            this.weight_box.Size = new System.Drawing.Size(90, 20);
            this.weight_box.TabIndex = 2;
            this.weight_box.Text = "weight";
            this.weight_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.weight_box.TextChanged += new System.EventHandler(this.weight_box_TextChanged);
            // 
            // cost_box
            // 
            this.cost_box.BackColor = System.Drawing.Color.Gainsboro;
            this.cost_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cost_box.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cost_box.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_box.Location = new System.Drawing.Point(310, 4);
            this.cost_box.Name = "cost_box";
            this.cost_box.Size = new System.Drawing.Size(89, 20);
            this.cost_box.TabIndex = 1;
            this.cost_box.Text = "cost";
            this.cost_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cost_box.TextChanged += new System.EventHandler(this.cost_box_TextChanged);
            // 
            // item_name_box
            // 
            this.item_name_box.BackColor = System.Drawing.Color.Gainsboro;
            this.item_name_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.item_name_box.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.item_name_box.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name_box.Location = new System.Drawing.Point(4, 4);
            this.item_name_box.Name = "item_name_box";
            this.item_name_box.Size = new System.Drawing.Size(202, 20);
            this.item_name_box.TabIndex = 0;
            this.item_name_box.Text = "itemName";
            this.item_name_box.TextChanged += new System.EventHandler(this.item_name_box_TextChanged);
            this.item_name_box.DoubleClick += new System.EventHandler(this.item_name_box_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.weapon_info_table);
            this.panel1.Controls.Add(this.notes_box);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(43, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 132);
            this.panel1.TabIndex = 2;
            // 
            // weapon_info_table
            // 
            this.weapon_info_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.weapon_info_table.ColumnCount = 2;
            this.weapon_info_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.91257F));
            this.weapon_info_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.08743F));
            this.weapon_info_table.Controls.Add(this.speed_box, 1, 1);
            this.weapon_info_table.Controls.Add(this.ac_box, 1, 2);
            this.weapon_info_table.Controls.Add(this.max_dex_box, 1, 3);
            this.weapon_info_table.Controls.Add(this.penalty_box, 1, 4);
            this.weapon_info_table.Controls.Add(this.spell_fail_box, 1, 5);
            this.weapon_info_table.Controls.Add(this.spell_fail_label, 0, 5);
            this.weapon_info_table.Controls.Add(this.size_label, 0, 0);
            this.weapon_info_table.Controls.Add(this.penalty_label, 0, 4);
            this.weapon_info_table.Controls.Add(this.speed_label, 0, 1);
            this.weapon_info_table.Controls.Add(this.max_dex_label, 0, 3);
            this.weapon_info_table.Controls.Add(this.ac_label, 0, 2);
            this.weapon_info_table.Controls.Add(this.size_box, 1, 0);
            this.weapon_info_table.Location = new System.Drawing.Point(0, 0);
            this.weapon_info_table.Name = "weapon_info_table";
            this.weapon_info_table.RowCount = 6;
            this.weapon_info_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.weapon_info_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.55725F));
            this.weapon_info_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.79389F));
            this.weapon_info_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.03053F));
            this.weapon_info_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.03053F));
            this.weapon_info_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.26718F));
            this.weapon_info_table.Size = new System.Drawing.Size(184, 132);
            this.weapon_info_table.TabIndex = 5;
            // 
            // speed_box
            // 
            this.speed_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.speed_box.BackColor = System.Drawing.Color.Gainsboro;
            this.speed_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.speed_box.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed_box.Location = new System.Drawing.Point(98, 28);
            this.speed_box.Name = "speed_box";
            this.speed_box.Size = new System.Drawing.Size(82, 14);
            this.speed_box.TabIndex = 1;
            this.speed_box.TextChanged += new System.EventHandler(this.speed_box_TextChanged);
            // 
            // ac_box
            // 
            this.ac_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ac_box.BackColor = System.Drawing.Color.Gainsboro;
            this.ac_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ac_box.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ac_box.Location = new System.Drawing.Point(98, 50);
            this.ac_box.Name = "ac_box";
            this.ac_box.Size = new System.Drawing.Size(82, 14);
            this.ac_box.TabIndex = 1;
            this.ac_box.TextChanged += new System.EventHandler(this.ac_box_TextChanged);
            // 
            // max_dex_box
            // 
            this.max_dex_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.max_dex_box.BackColor = System.Drawing.Color.Gainsboro;
            this.max_dex_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.max_dex_box.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_dex_box.Location = new System.Drawing.Point(98, 71);
            this.max_dex_box.Name = "max_dex_box";
            this.max_dex_box.Size = new System.Drawing.Size(82, 14);
            this.max_dex_box.TabIndex = 1;
            this.max_dex_box.TextChanged += new System.EventHandler(this.max_dex_box_TextChanged);
            // 
            // penalty_box
            // 
            this.penalty_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.penalty_box.BackColor = System.Drawing.Color.Gainsboro;
            this.penalty_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.penalty_box.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penalty_box.Location = new System.Drawing.Point(98, 92);
            this.penalty_box.Name = "penalty_box";
            this.penalty_box.Size = new System.Drawing.Size(82, 14);
            this.penalty_box.TabIndex = 1;
            this.penalty_box.TextChanged += new System.EventHandler(this.penalty_box_TextChanged);
            // 
            // spell_fail_box
            // 
            this.spell_fail_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spell_fail_box.BackColor = System.Drawing.Color.Gainsboro;
            this.spell_fail_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.spell_fail_box.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spell_fail_box.Location = new System.Drawing.Point(98, 114);
            this.spell_fail_box.Name = "spell_fail_box";
            this.spell_fail_box.Size = new System.Drawing.Size(82, 14);
            this.spell_fail_box.TabIndex = 1;
            this.spell_fail_box.TextChanged += new System.EventHandler(this.spell_fail_box_TextChanged);
            // 
            // spell_fail_label
            // 
            this.spell_fail_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spell_fail_label.AutoSize = true;
            this.spell_fail_label.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spell_fail_label.Location = new System.Drawing.Point(4, 118);
            this.spell_fail_label.Name = "spell_fail_label";
            this.spell_fail_label.Size = new System.Drawing.Size(64, 13);
            this.spell_fail_label.TabIndex = 0;
            this.spell_fail_label.Text = "Spell Fail %:";
            // 
            // size_label
            // 
            this.size_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.size_label.AutoSize = true;
            this.size_label.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size_label.Location = new System.Drawing.Point(4, 9);
            this.size_label.Name = "size_label";
            this.size_label.Size = new System.Drawing.Size(32, 13);
            this.size_label.TabIndex = 0;
            this.size_label.Text = "Size :";
            // 
            // penalty_label
            // 
            this.penalty_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.penalty_label.AutoSize = true;
            this.penalty_label.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penalty_label.Location = new System.Drawing.Point(4, 96);
            this.penalty_label.Name = "penalty_label";
            this.penalty_label.Size = new System.Drawing.Size(80, 13);
            this.penalty_label.TabIndex = 0;
            this.penalty_label.Text = "Check Penalty :";
            // 
            // speed_label
            // 
            this.speed_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.speed_label.AutoSize = true;
            this.speed_label.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed_label.Location = new System.Drawing.Point(4, 32);
            this.speed_label.Name = "speed_label";
            this.speed_label.Size = new System.Drawing.Size(42, 13);
            this.speed_label.TabIndex = 0;
            this.speed_label.Text = "Speed :";
            // 
            // max_dex_label
            // 
            this.max_dex_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.max_dex_label.AutoSize = true;
            this.max_dex_label.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_dex_label.Location = new System.Drawing.Point(4, 75);
            this.max_dex_label.Name = "max_dex_label";
            this.max_dex_label.Size = new System.Drawing.Size(54, 13);
            this.max_dex_label.TabIndex = 0;
            this.max_dex_label.Text = "Max DEX :";
            // 
            // ac_label
            // 
            this.ac_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ac_label.AutoSize = true;
            this.ac_label.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ac_label.Location = new System.Drawing.Point(4, 54);
            this.ac_label.Name = "ac_label";
            this.ac_label.Size = new System.Drawing.Size(58, 13);
            this.ac_label.TabIndex = 0;
            this.ac_label.Text = "AC Bonus :";
            // 
            // size_box
            // 
            this.size_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.size_box.BackColor = System.Drawing.Color.Gainsboro;
            this.size_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.size_box.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size_box.Location = new System.Drawing.Point(98, 5);
            this.size_box.Name = "size_box";
            this.size_box.Size = new System.Drawing.Size(82, 14);
            this.size_box.TabIndex = 1;
            this.size_box.TextChanged += new System.EventHandler(this.size_box_TextChanged);
            // 
            // notes_box
            // 
            this.notes_box.BackColor = System.Drawing.Color.Gainsboro;
            this.notes_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notes_box.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes_box.Location = new System.Drawing.Point(190, 0);
            this.notes_box.Name = "notes_box";
            this.notes_box.Size = new System.Drawing.Size(213, 133);
            this.notes_box.TabIndex = 3;
            this.notes_box.Text = "";
            this.notes_box.TextChanged += new System.EventHandler(this.notes_box_TextChanged);
            // 
            // equipped_box
            // 
            this.equipped_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.equipped_box.AutoSize = true;
            this.equipped_box.Location = new System.Drawing.Point(9, 6);
            this.equipped_box.Name = "equipped_box";
            this.equipped_box.Padding = new System.Windows.Forms.Padding(4, 7, 3, 3);
            this.equipped_box.Size = new System.Drawing.Size(22, 24);
            this.equipped_box.TabIndex = 4;
            this.equipped_box.UseVisualStyleBackColor = true;
            this.equipped_box.CheckedChanged += new System.EventHandler(this.equipped_box_CheckedChanged);
            // 
            // ArmorBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.armor_table);
            this.Name = "ArmorBox";
            this.Size = new System.Drawing.Size(452, 175);
            this.armor_table.ResumeLayout(false);
            this.armor_table.PerformLayout();
            this.item_info_table.ResumeLayout(false);
            this.item_info_table.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.weapon_info_table.ResumeLayout(false);
            this.weapon_info_table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel armor_table;
        private System.Windows.Forms.TableLayoutPanel item_info_table;
        private System.Windows.Forms.TextBox weight_box;
        private System.Windows.Forms.TextBox cost_box;
        private System.Windows.Forms.TextBox item_name_box;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel weapon_info_table;
        private System.Windows.Forms.TextBox speed_box;
        private System.Windows.Forms.TextBox ac_box;
        private System.Windows.Forms.TextBox max_dex_box;
        private System.Windows.Forms.TextBox penalty_box;
        private System.Windows.Forms.TextBox spell_fail_box;
        private System.Windows.Forms.Label spell_fail_label;
        private System.Windows.Forms.Label size_label;
        private System.Windows.Forms.Label penalty_label;
        private System.Windows.Forms.Label speed_label;
        private System.Windows.Forms.Label max_dex_label;
        private System.Windows.Forms.Label ac_label;
        private System.Windows.Forms.TextBox size_box;
        private System.Windows.Forms.RichTextBox notes_box;
        private System.Windows.Forms.CheckBox equipped_box;
    }
}
