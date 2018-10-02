namespace BagOfHolding
{
    partial class ItemBox
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
            this.item_table = new System.Windows.Forms.TableLayoutPanel();
            this.del_butt = new System.Windows.Forms.Button();
            this.item_info_table = new System.Windows.Forms.TableLayoutPanel();
            this.weight_box = new System.Windows.Forms.TextBox();
            this.cost_box = new System.Windows.Forms.TextBox();
            this.item_name_box = new System.Windows.Forms.TextBox();
            this.notes_box = new System.Windows.Forms.RichTextBox();
            this.equipped_box = new System.Windows.Forms.CheckBox();
            this.item_table.SuspendLayout();
            this.item_info_table.SuspendLayout();
            this.SuspendLayout();
            // 
            // item_table
            // 
            this.item_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.item_table.ColumnCount = 2;
            this.item_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.item_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 424F));
            this.item_table.Controls.Add(this.del_butt, 0, 0);
            this.item_table.Controls.Add(this.item_info_table, 1, 0);
            this.item_table.Controls.Add(this.notes_box, 1, 1);
            this.item_table.Controls.Add(this.equipped_box, 0, 1);
            this.item_table.Location = new System.Drawing.Point(0, 0);
            this.item_table.Name = "item_table";
            this.item_table.RowCount = 2;
            this.item_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.item_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.item_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.item_table.Size = new System.Drawing.Size(451, 119);
            this.item_table.TabIndex = 1;
            this.item_table.DoubleClick += new System.EventHandler(this.item_table_DoubleClick);
            this.item_table.MouseMove += new System.Windows.Forms.MouseEventHandler(this.item_table_MouseMove);
            // 
            // del_butt
            // 
            this.del_butt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.del_butt.BackColor = System.Drawing.Color.DarkGray;
            this.del_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_butt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.del_butt.Image = global::BagOfHolding.Properties.Resources.close_icon;
            this.del_butt.Location = new System.Drawing.Point(4, 7);
            this.del_butt.Name = "del_butt";
            this.del_butt.Size = new System.Drawing.Size(18, 20);
            this.del_butt.TabIndex = 8;
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
            this.item_info_table.Location = new System.Drawing.Point(29, 4);
            this.item_info_table.Name = "item_info_table";
            this.item_info_table.RowCount = 1;
            this.item_info_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.item_info_table.Size = new System.Drawing.Size(414, 27);
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
            this.weight_box.Size = new System.Drawing.Size(91, 20);
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
            this.cost_box.Location = new System.Drawing.Point(311, 4);
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
            this.item_name_box.Size = new System.Drawing.Size(202, 20);
            this.item_name_box.TabIndex = 0;
            this.item_name_box.Text = "itemName";
            this.item_name_box.TextChanged += new System.EventHandler(this.item_name_box_TextChanged);
            this.item_name_box.DoubleClick += new System.EventHandler(this.item_name_box_DoubleClick);
            // 
            // notes_box
            // 
            this.notes_box.BackColor = System.Drawing.Color.Gainsboro;
            this.notes_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notes_box.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes_box.Location = new System.Drawing.Point(29, 38);
            this.notes_box.Name = "notes_box";
            this.notes_box.Size = new System.Drawing.Size(414, 77);
            this.notes_box.TabIndex = 2;
            this.notes_box.Text = "";
            this.notes_box.TextChanged += new System.EventHandler(this.notes_box_TextChanged);
            // 
            // equipped_box
            // 
            this.equipped_box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.equipped_box.AutoSize = true;
            this.equipped_box.Location = new System.Drawing.Point(4, 68);
            this.equipped_box.Name = "equipped_box";
            this.equipped_box.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.equipped_box.Size = new System.Drawing.Size(17, 16);
            this.equipped_box.TabIndex = 3;
            this.equipped_box.UseVisualStyleBackColor = true;
            this.equipped_box.CheckedChanged += new System.EventHandler(this.equipped_box_CheckedChanged);
            // 
            // ItemBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.item_table);
            this.Name = "ItemBox";
            this.Size = new System.Drawing.Size(451, 119);
            this.item_table.ResumeLayout(false);
            this.item_table.PerformLayout();
            this.item_info_table.ResumeLayout(false);
            this.item_info_table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel item_table;
        private System.Windows.Forms.TableLayoutPanel item_info_table;
        private System.Windows.Forms.TextBox weight_box;
        private System.Windows.Forms.TextBox cost_box;
        private System.Windows.Forms.TextBox item_name_box;
        private System.Windows.Forms.RichTextBox notes_box;
        private System.Windows.Forms.CheckBox equipped_box;
        private System.Windows.Forms.Button del_butt;
    }
}
