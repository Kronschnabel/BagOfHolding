namespace BagOfHolding
{
    partial class SpellBox
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
            this.spell_table = new System.Windows.Forms.TableLayoutPanel();
            this.del_butt = new System.Windows.Forms.Button();
            this.spell_info_table = new System.Windows.Forms.TableLayoutPanel();
            this.school_box = new System.Windows.Forms.TextBox();
            this.level_box = new System.Windows.Forms.TextBox();
            this.spell_name_box = new System.Windows.Forms.TextBox();
            this.notes_box = new System.Windows.Forms.RichTextBox();
            this.prepared_box = new System.Windows.Forms.CheckBox();
            this.spell_table.SuspendLayout();
            this.spell_info_table.SuspendLayout();
            this.SuspendLayout();
            // 
            // spell_table
            // 
            this.spell_table.BackColor = System.Drawing.Color.Gainsboro;
            this.spell_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.spell_table.ColumnCount = 2;
            this.spell_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.spell_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 395F));
            this.spell_table.Controls.Add(this.del_butt, 0, 1);
            this.spell_table.Controls.Add(this.spell_info_table, 1, 0);
            this.spell_table.Controls.Add(this.notes_box, 1, 1);
            this.spell_table.Controls.Add(this.prepared_box, 0, 0);
            this.spell_table.Location = new System.Drawing.Point(0, 0);
            this.spell_table.Name = "spell_table";
            this.spell_table.RowCount = 2;
            this.spell_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.spell_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.spell_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.spell_table.Size = new System.Drawing.Size(452, 261);
            this.spell_table.TabIndex = 3;
            this.spell_table.DoubleClick += new System.EventHandler(this.spell_table_DoubleClick);
            this.spell_table.MouseMove += new System.Windows.Forms.MouseEventHandler(this.spell_table_MouseMove);
            // 
            // del_butt
            // 
            this.del_butt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.del_butt.BackColor = System.Drawing.Color.DarkGray;
            this.del_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_butt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.del_butt.Image = global::BagOfHolding.Properties.Resources.close_icon;
            this.del_butt.Location = new System.Drawing.Point(17, 153);
            this.del_butt.Name = "del_butt";
            this.del_butt.Size = new System.Drawing.Size(21, 21);
            this.del_butt.TabIndex = 7;
            this.del_butt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.del_butt.UseVisualStyleBackColor = false;
            this.del_butt.Visible = false;
            this.del_butt.Click += new System.EventHandler(this.del_butt_Click);
            // 
            // spell_info_table
            // 
            this.spell_info_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.spell_info_table.ColumnCount = 2;
            this.spell_info_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.40058F));
            this.spell_info_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.59942F));
            this.spell_info_table.Controls.Add(this.school_box, 0, 1);
            this.spell_info_table.Controls.Add(this.level_box, 1, 1);
            this.spell_info_table.Controls.Add(this.spell_name_box, 0, 0);
            this.spell_info_table.Location = new System.Drawing.Point(59, 4);
            this.spell_info_table.Name = "spell_info_table";
            this.spell_info_table.RowCount = 2;
            this.spell_info_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.spell_info_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.spell_info_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.spell_info_table.Size = new System.Drawing.Size(383, 60);
            this.spell_info_table.TabIndex = 1;
            // 
            // school_box
            // 
            this.school_box.BackColor = System.Drawing.Color.Gainsboro;
            this.school_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.school_box.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.school_box.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.school_box.Location = new System.Drawing.Point(4, 38);
            this.school_box.Name = "school_box";
            this.school_box.Size = new System.Drawing.Size(234, 20);
            this.school_box.TabIndex = 2;
            this.school_box.Text = "school";
            this.school_box.TextChanged += new System.EventHandler(this.school_box_TextChanged);
            // 
            // level_box
            // 
            this.level_box.BackColor = System.Drawing.Color.Gainsboro;
            this.level_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.level_box.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.level_box.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level_box.Location = new System.Drawing.Point(245, 38);
            this.level_box.Name = "level_box";
            this.level_box.Size = new System.Drawing.Size(134, 20);
            this.level_box.TabIndex = 1;
            this.level_box.Text = "level";
            this.level_box.TextChanged += new System.EventHandler(this.level_box_TextChanged);
            // 
            // spell_name_box
            // 
            this.spell_name_box.BackColor = System.Drawing.Color.Gainsboro;
            this.spell_name_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.spell_name_box.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.spell_name_box.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spell_name_box.Location = new System.Drawing.Point(4, 11);
            this.spell_name_box.Name = "spell_name_box";
            this.spell_name_box.Size = new System.Drawing.Size(234, 20);
            this.spell_name_box.TabIndex = 0;
            this.spell_name_box.Text = "spellName";
            this.spell_name_box.TextChanged += new System.EventHandler(this.spell_name_box_TextChanged);
            this.spell_name_box.DoubleClick += new System.EventHandler(this.spell_name_box_DoubleClick);
            // 
            // notes_box
            // 
            this.notes_box.BackColor = System.Drawing.Color.Gainsboro;
            this.notes_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notes_box.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes_box.Location = new System.Drawing.Point(59, 71);
            this.notes_box.Name = "notes_box";
            this.notes_box.Size = new System.Drawing.Size(383, 186);
            this.notes_box.TabIndex = 5;
            this.notes_box.Text = "";
            this.notes_box.TextChanged += new System.EventHandler(this.notes_box_TextChanged);
            // 
            // prepared_box
            // 
            this.prepared_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prepared_box.AutoSize = true;
            this.prepared_box.Location = new System.Drawing.Point(17, 22);
            this.prepared_box.Name = "prepared_box";
            this.prepared_box.Padding = new System.Windows.Forms.Padding(4, 7, 3, 3);
            this.prepared_box.Size = new System.Drawing.Size(22, 24);
            this.prepared_box.TabIndex = 4;
            this.prepared_box.UseVisualStyleBackColor = true;
            this.prepared_box.CheckedChanged += new System.EventHandler(this.prepared_box_CheckedChanged);
            // 
            // SpellBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spell_table);
            this.Name = "SpellBox";
            this.Size = new System.Drawing.Size(452, 261);
            this.spell_table.ResumeLayout(false);
            this.spell_table.PerformLayout();
            this.spell_info_table.ResumeLayout(false);
            this.spell_info_table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel spell_table;
        private System.Windows.Forms.TableLayoutPanel spell_info_table;
        private System.Windows.Forms.TextBox school_box;
        private System.Windows.Forms.TextBox level_box;
        private System.Windows.Forms.TextBox spell_name_box;
        private System.Windows.Forms.RichTextBox notes_box;
        private System.Windows.Forms.CheckBox prepared_box;
        private System.Windows.Forms.Button del_butt;
    }
}
