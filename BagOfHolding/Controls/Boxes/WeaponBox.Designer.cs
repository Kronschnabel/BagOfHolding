namespace BagOfHolding
{
    partial class WeaponBox
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
            this.weapon_table = new System.Windows.Forms.TableLayoutPanel();
            this.del_butt = new System.Windows.Forms.Button();
            this.item_info_table = new System.Windows.Forms.TableLayoutPanel();
            this.weight_box = new System.Windows.Forms.TextBox();
            this.cost_box = new System.Windows.Forms.TextBox();
            this.item_name_box = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.weapon_info_table = new System.Windows.Forms.TableLayoutPanel();
            this.damage_label = new System.Windows.Forms.Label();
            this.crit_range_label = new System.Windows.Forms.Label();
            this.type_label = new System.Windows.Forms.Label();
            this.crit_range_box = new System.Windows.Forms.TextBox();
            this.category_box = new System.Windows.Forms.TextBox();
            this.range_box = new System.Windows.Forms.TextBox();
            this.type_box = new System.Windows.Forms.TextBox();
            this.size_box = new System.Windows.Forms.TextBox();
            this.category_label = new System.Windows.Forms.Label();
            this.size_label = new System.Windows.Forms.Label();
            this.range_label = new System.Windows.Forms.Label();
            this.damage_box = new System.Windows.Forms.TextBox();
            this.notes_box = new System.Windows.Forms.RichTextBox();
            this.equipped_box = new System.Windows.Forms.CheckBox();
            this.weapon_table.SuspendLayout();
            this.item_info_table.SuspendLayout();
            this.panel1.SuspendLayout();
            this.weapon_info_table.SuspendLayout();
            this.SuspendLayout();
            // 
            // weapon_table
            // 
            this.weapon_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.weapon_table.ColumnCount = 2;
            this.weapon_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.weapon_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 414F));
            this.weapon_table.Controls.Add(this.del_butt, 0, 0);
            this.weapon_table.Controls.Add(this.item_info_table, 1, 0);
            this.weapon_table.Controls.Add(this.panel1, 1, 1);
            this.weapon_table.Controls.Add(this.equipped_box, 0, 1);
            this.weapon_table.Location = new System.Drawing.Point(0, 0);
            this.weapon_table.Name = "weapon_table";
            this.weapon_table.RowCount = 2;
            this.weapon_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.weapon_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.weapon_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.weapon_table.Size = new System.Drawing.Size(451, 175);
            this.weapon_table.TabIndex = 2;
            this.weapon_table.DoubleClick += new System.EventHandler(this.weapon_table_DoubleClick);
            this.weapon_table.MouseMove += new System.Windows.Forms.MouseEventHandler(this.weapon_table_MouseMove);
            // 
            // del_butt
            // 
            this.del_butt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.del_butt.BackColor = System.Drawing.Color.DarkGray;
            this.del_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_butt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.del_butt.Image = global::BagOfHolding.Properties.Resources.close_icon;
            this.del_butt.Location = new System.Drawing.Point(7, 7);
            this.del_butt.Name = "del_butt";
            this.del_butt.Size = new System.Drawing.Size(21, 21);
            this.del_butt.TabIndex = 6;
            this.del_butt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.del_butt.UseVisualStyleBackColor = false;
            this.del_butt.Visible = false;
            this.del_butt.Click += new System.EventHandler(this.del_butt_Click);
            // 
            // item_info_table
            // 
            this.item_info_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.item_info_table.ColumnCount = 3;
            this.item_info_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.27586F));
            this.item_info_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.72414F));
            this.item_info_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.item_info_table.Controls.Add(this.weight_box, 0, 0);
            this.item_info_table.Controls.Add(this.cost_box, 1, 0);
            this.item_info_table.Controls.Add(this.item_name_box, 0, 0);
            this.item_info_table.Location = new System.Drawing.Point(39, 4);
            this.item_info_table.Name = "item_info_table";
            this.item_info_table.RowCount = 1;
            this.item_info_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.item_info_table.Size = new System.Drawing.Size(402, 27);
            this.item_info_table.TabIndex = 1;
            // 
            // weight_box
            // 
            this.weight_box.BackColor = System.Drawing.Color.Gainsboro;
            this.weight_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.weight_box.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.weight_box.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_box.Location = new System.Drawing.Point(205, 4);
            this.weight_box.Name = "weight_box";
            this.weight_box.Size = new System.Drawing.Size(87, 20);
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
            this.cost_box.Location = new System.Drawing.Point(299, 4);
            this.cost_box.Name = "cost_box";
            this.cost_box.Size = new System.Drawing.Size(99, 20);
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
            this.item_name_box.Size = new System.Drawing.Size(194, 20);
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
            this.panel1.Location = new System.Drawing.Point(39, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 132);
            this.panel1.TabIndex = 2;
            // 
            // weapon_info_table
            // 
            this.weapon_info_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.weapon_info_table.ColumnCount = 2;
            this.weapon_info_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.42857F));
            this.weapon_info_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.57143F));
            this.weapon_info_table.Controls.Add(this.damage_label, 0, 0);
            this.weapon_info_table.Controls.Add(this.crit_range_label, 0, 1);
            this.weapon_info_table.Controls.Add(this.type_label, 0, 4);
            this.weapon_info_table.Controls.Add(this.crit_range_box, 1, 1);
            this.weapon_info_table.Controls.Add(this.category_box, 1, 2);
            this.weapon_info_table.Controls.Add(this.range_box, 1, 3);
            this.weapon_info_table.Controls.Add(this.type_box, 1, 4);
            this.weapon_info_table.Controls.Add(this.size_box, 1, 5);
            this.weapon_info_table.Controls.Add(this.category_label, 0, 2);
            this.weapon_info_table.Controls.Add(this.size_label, 0, 5);
            this.weapon_info_table.Controls.Add(this.range_label, 0, 3);
            this.weapon_info_table.Controls.Add(this.damage_box, 1, 0);
            this.weapon_info_table.Location = new System.Drawing.Point(0, 0);
            this.weapon_info_table.Name = "weapon_info_table";
            this.weapon_info_table.RowCount = 6;
            this.weapon_info_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.48241F));
            this.weapon_info_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.70352F));
            this.weapon_info_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.70352F));
            this.weapon_info_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.70352F));
            this.weapon_info_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.70352F));
            this.weapon_info_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.70352F));
            this.weapon_info_table.Size = new System.Drawing.Size(184, 129);
            this.weapon_info_table.TabIndex = 4;
            // 
            // damage_label
            // 
            this.damage_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.damage_label.AutoSize = true;
            this.damage_label.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damage_label.Location = new System.Drawing.Point(4, 14);
            this.damage_label.Name = "damage_label";
            this.damage_label.Size = new System.Drawing.Size(51, 13);
            this.damage_label.TabIndex = 0;
            this.damage_label.Text = "Damage :";
            // 
            // crit_range_label
            // 
            this.crit_range_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.crit_range_label.AutoSize = true;
            this.crit_range_label.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crit_range_label.Location = new System.Drawing.Point(4, 34);
            this.crit_range_label.Name = "crit_range_label";
            this.crit_range_label.Size = new System.Drawing.Size(63, 13);
            this.crit_range_label.TabIndex = 0;
            this.crit_range_label.Text = "Crit Range :";
            // 
            // type_label
            // 
            this.type_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.type_label.AutoSize = true;
            this.type_label.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_label.Location = new System.Drawing.Point(4, 94);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(33, 13);
            this.type_label.TabIndex = 0;
            this.type_label.Text = "Type :";
            // 
            // crit_range_box
            // 
            this.crit_range_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.crit_range_box.BackColor = System.Drawing.Color.Gainsboro;
            this.crit_range_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.crit_range_box.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crit_range_box.Location = new System.Drawing.Point(83, 31);
            this.crit_range_box.Name = "crit_range_box";
            this.crit_range_box.Size = new System.Drawing.Size(97, 14);
            this.crit_range_box.TabIndex = 1;
            this.crit_range_box.TextChanged += new System.EventHandler(this.crit_range_box_TextChanged);
            // 
            // category_box
            // 
            this.category_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.category_box.BackColor = System.Drawing.Color.Gainsboro;
            this.category_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.category_box.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_box.Location = new System.Drawing.Point(83, 51);
            this.category_box.Name = "category_box";
            this.category_box.Size = new System.Drawing.Size(97, 14);
            this.category_box.TabIndex = 1;
            this.category_box.TextChanged += new System.EventHandler(this.category_box_TextChanged);
            // 
            // range_box
            // 
            this.range_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.range_box.BackColor = System.Drawing.Color.Gainsboro;
            this.range_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.range_box.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.range_box.Location = new System.Drawing.Point(83, 71);
            this.range_box.Name = "range_box";
            this.range_box.Size = new System.Drawing.Size(97, 14);
            this.range_box.TabIndex = 1;
            this.range_box.TextChanged += new System.EventHandler(this.range_box_TextChanged);
            // 
            // type_box
            // 
            this.type_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.type_box.BackColor = System.Drawing.Color.Gainsboro;
            this.type_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.type_box.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_box.Location = new System.Drawing.Point(83, 91);
            this.type_box.Name = "type_box";
            this.type_box.Size = new System.Drawing.Size(97, 14);
            this.type_box.TabIndex = 1;
            this.type_box.TextChanged += new System.EventHandler(this.type_box_TextChanged);
            // 
            // size_box
            // 
            this.size_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.size_box.BackColor = System.Drawing.Color.Gainsboro;
            this.size_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.size_box.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size_box.Location = new System.Drawing.Point(83, 111);
            this.size_box.Name = "size_box";
            this.size_box.Size = new System.Drawing.Size(97, 14);
            this.size_box.TabIndex = 1;
            this.size_box.TextChanged += new System.EventHandler(this.size_box_TextChanged);
            // 
            // category_label
            // 
            this.category_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.category_label.AutoSize = true;
            this.category_label.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_label.Location = new System.Drawing.Point(4, 54);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(56, 13);
            this.category_label.TabIndex = 0;
            this.category_label.Text = "Category :";
            // 
            // size_label
            // 
            this.size_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.size_label.AutoSize = true;
            this.size_label.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size_label.Location = new System.Drawing.Point(4, 115);
            this.size_label.Name = "size_label";
            this.size_label.Size = new System.Drawing.Size(32, 13);
            this.size_label.TabIndex = 0;
            this.size_label.Text = "Size :";
            // 
            // range_label
            // 
            this.range_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.range_label.AutoSize = true;
            this.range_label.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.range_label.Location = new System.Drawing.Point(4, 74);
            this.range_label.Name = "range_label";
            this.range_label.Size = new System.Drawing.Size(42, 13);
            this.range_label.TabIndex = 0;
            this.range_label.Text = "Range :";
            // 
            // damage_box
            // 
            this.damage_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.damage_box.BackColor = System.Drawing.Color.Gainsboro;
            this.damage_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.damage_box.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damage_box.Location = new System.Drawing.Point(83, 5);
            this.damage_box.Name = "damage_box";
            this.damage_box.Size = new System.Drawing.Size(97, 19);
            this.damage_box.TabIndex = 1;
            this.damage_box.TextChanged += new System.EventHandler(this.damage_box_TextChanged);
            // 
            // notes_box
            // 
            this.notes_box.BackColor = System.Drawing.Color.Gainsboro;
            this.notes_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notes_box.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes_box.Location = new System.Drawing.Point(190, 0);
            this.notes_box.Name = "notes_box";
            this.notes_box.Size = new System.Drawing.Size(212, 133);
            this.notes_box.TabIndex = 3;
            this.notes_box.Text = "";
            this.notes_box.TextChanged += new System.EventHandler(this.notes_box_TextChanged);
            // 
            // equipped_box
            // 
            this.equipped_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.equipped_box.AutoSize = true;
            this.equipped_box.Location = new System.Drawing.Point(7, 93);
            this.equipped_box.Name = "equipped_box";
            this.equipped_box.Padding = new System.Windows.Forms.Padding(4, 7, 3, 3);
            this.equipped_box.Size = new System.Drawing.Size(22, 24);
            this.equipped_box.TabIndex = 4;
            this.equipped_box.UseVisualStyleBackColor = true;
            this.equipped_box.CheckedChanged += new System.EventHandler(this.equipped_box_CheckedChanged);
            // 
            // WeaponBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.weapon_table);
            this.Name = "WeaponBox";
            this.Size = new System.Drawing.Size(451, 175);
            this.weapon_table.ResumeLayout(false);
            this.weapon_table.PerformLayout();
            this.item_info_table.ResumeLayout(false);
            this.item_info_table.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.weapon_info_table.ResumeLayout(false);
            this.weapon_info_table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel weapon_table;
        private System.Windows.Forms.TableLayoutPanel item_info_table;
        private System.Windows.Forms.TextBox weight_box;
        private System.Windows.Forms.TextBox cost_box;
        private System.Windows.Forms.TextBox item_name_box;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel weapon_info_table;
        private System.Windows.Forms.Label damage_label;
        private System.Windows.Forms.Label crit_range_label;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.TextBox crit_range_box;
        private System.Windows.Forms.TextBox category_box;
        private System.Windows.Forms.TextBox range_box;
        private System.Windows.Forms.TextBox type_box;
        private System.Windows.Forms.TextBox size_box;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.Label size_label;
        private System.Windows.Forms.Label range_label;
        private System.Windows.Forms.TextBox damage_box;
        private System.Windows.Forms.RichTextBox notes_box;
        private System.Windows.Forms.CheckBox equipped_box;
        private System.Windows.Forms.Button del_butt;
    }
}
