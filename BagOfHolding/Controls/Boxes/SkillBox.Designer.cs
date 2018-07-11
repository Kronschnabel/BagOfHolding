namespace BagOfHolding
{
    partial class SkillBox
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
            this.skillTable = new System.Windows.Forms.TableLayoutPanel();
            this.class_skill_box = new System.Windows.Forms.CheckBox();
            this.skill_name_box = new System.Windows.Forms.TextBox();
            this.ability_box = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.total_box = new System.Windows.Forms.TextBox();
            this.trained_box = new System.Windows.Forms.TextBox();
            this.miscMod1_box = new System.Windows.Forms.TextBox();
            this.miscMod2_box = new System.Windows.Forms.TextBox();
            this.ranks_box = new System.Windows.Forms.NumericUpDown();
            this.ability_mod_box = new System.Windows.Forms.TextBox();
            this.skillTable.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ranks_box)).BeginInit();
            this.SuspendLayout();
            // 
            // skillTable
            // 
            this.skillTable.BackColor = System.Drawing.Color.Gainsboro;
            this.skillTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.skillTable.ColumnCount = 4;
            this.skillTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.33898F));
            this.skillTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.66102F));
            this.skillTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.skillTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.skillTable.Controls.Add(this.class_skill_box, 0, 0);
            this.skillTable.Controls.Add(this.skill_name_box, 1, 0);
            this.skillTable.Controls.Add(this.ability_box, 2, 0);
            this.skillTable.Controls.Add(this.tableLayoutPanel2, 3, 0);
            this.skillTable.Location = new System.Drawing.Point(0, 0);
            this.skillTable.Margin = new System.Windows.Forms.Padding(0);
            this.skillTable.Name = "skillTable";
            this.skillTable.RowCount = 1;
            this.skillTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.skillTable.Size = new System.Drawing.Size(370, 29);
            this.skillTable.TabIndex = 2;
            // 
            // class_skill_box
            // 
            this.class_skill_box.AutoSize = true;
            this.class_skill_box.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.class_skill_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.class_skill_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.class_skill_box.ForeColor = System.Drawing.Color.Black;
            this.class_skill_box.Location = new System.Drawing.Point(4, 4);
            this.class_skill_box.Name = "class_skill_box";
            this.class_skill_box.Size = new System.Drawing.Size(18, 21);
            this.class_skill_box.TabIndex = 1;
            this.class_skill_box.UseVisualStyleBackColor = true;
            this.class_skill_box.CheckedChanged += new System.EventHandler(this.class_skill_box_CheckedChanged);
            // 
            // skill_name_box
            // 
            this.skill_name_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.skill_name_box.BackColor = System.Drawing.Color.Gainsboro;
            this.skill_name_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skill_name_box.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skill_name_box.Location = new System.Drawing.Point(29, 7);
            this.skill_name_box.Name = "skill_name_box";
            this.skill_name_box.Size = new System.Drawing.Size(90, 15);
            this.skill_name_box.TabIndex = 6;
            this.skill_name_box.Text = "skillName";
            this.skill_name_box.TextChanged += new System.EventHandler(this.skill_name_box_TextChanged);
            // 
            // ability_box
            // 
            this.ability_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ability_box.BackColor = System.Drawing.Color.Gainsboro;
            this.ability_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ability_box.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ability_box.ForeColor = System.Drawing.Color.DarkGray;
            this.ability_box.Location = new System.Drawing.Point(126, 4);
            this.ability_box.Name = "ability_box";
            this.ability_box.Size = new System.Drawing.Size(25, 23);
            this.ability_box.TabIndex = 6;
            this.ability_box.Text = "DEX";
            this.ability_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ability_box.Leave += new System.EventHandler(this.ability_box_Leave);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.total_box, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.trained_box, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.miscMod1_box, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.miscMod2_box, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.ranks_box, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ability_mod_box, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(158, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(208, 21);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // total_box
            // 
            this.total_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.total_box.BackColor = System.Drawing.Color.Gainsboro;
            this.total_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.total_box.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_box.Location = new System.Drawing.Point(4, 4);
            this.total_box.Name = "total_box";
            this.total_box.ReadOnly = true;
            this.total_box.Size = new System.Drawing.Size(32, 15);
            this.total_box.TabIndex = 7;
            this.total_box.Text = "0";
            this.total_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trained_box
            // 
            this.trained_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.trained_box.BackColor = System.Drawing.Color.Gainsboro;
            this.trained_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trained_box.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trained_box.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.trained_box.Location = new System.Drawing.Point(117, 4);
            this.trained_box.Name = "trained_box";
            this.trained_box.ReadOnly = true;
            this.trained_box.Size = new System.Drawing.Size(22, 15);
            this.trained_box.TabIndex = 7;
            this.trained_box.Text = "0";
            this.trained_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // miscMod1_box
            // 
            this.miscMod1_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.miscMod1_box.BackColor = System.Drawing.Color.Gainsboro;
            this.miscMod1_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.miscMod1_box.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscMod1_box.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.miscMod1_box.Location = new System.Drawing.Point(148, 4);
            this.miscMod1_box.Name = "miscMod1_box";
            this.miscMod1_box.Size = new System.Drawing.Size(22, 15);
            this.miscMod1_box.TabIndex = 7;
            this.miscMod1_box.Text = "0";
            this.miscMod1_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.miscMod1_box.TextChanged += new System.EventHandler(this.miscMod1_box_TextChanged);
            // 
            // miscMod2_box
            // 
            this.miscMod2_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.miscMod2_box.BackColor = System.Drawing.Color.Gainsboro;
            this.miscMod2_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.miscMod2_box.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscMod2_box.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.miscMod2_box.Location = new System.Drawing.Point(179, 4);
            this.miscMod2_box.Name = "miscMod2_box";
            this.miscMod2_box.Size = new System.Drawing.Size(24, 15);
            this.miscMod2_box.TabIndex = 7;
            this.miscMod2_box.Text = "0";
            this.miscMod2_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.miscMod2_box.TextChanged += new System.EventHandler(this.miscMod2_box_TextChanged);
            // 
            // ranks_box
            // 
            this.ranks_box.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ranks_box.BackColor = System.Drawing.Color.Gainsboro;
            this.ranks_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ranks_box.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ranks_box.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ranks_box.Location = new System.Drawing.Point(46, 2);
            this.ranks_box.Margin = new System.Windows.Forms.Padding(0);
            this.ranks_box.Name = "ranks_box";
            this.ranks_box.Size = new System.Drawing.Size(32, 18);
            this.ranks_box.TabIndex = 8;
            this.ranks_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ranks_box.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.ranks_box.ValueChanged += new System.EventHandler(this.ranks_box_ValueChanged);
            // 
            // ability_mod_box
            // 
            this.ability_mod_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ability_mod_box.BackColor = System.Drawing.Color.Gainsboro;
            this.ability_mod_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ability_mod_box.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ability_mod_box.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ability_mod_box.Location = new System.Drawing.Point(86, 4);
            this.ability_mod_box.Name = "ability_mod_box";
            this.ability_mod_box.ReadOnly = true;
            this.ability_mod_box.Size = new System.Drawing.Size(22, 15);
            this.ability_mod_box.TabIndex = 7;
            this.ability_mod_box.Text = "0";
            this.ability_mod_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SkillBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skillTable);
            this.Name = "SkillBox";
            this.Size = new System.Drawing.Size(370, 29);
            this.skillTable.ResumeLayout(false);
            this.skillTable.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ranks_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel skillTable;
        private System.Windows.Forms.CheckBox class_skill_box;
        private System.Windows.Forms.TextBox skill_name_box;
        private System.Windows.Forms.TextBox ability_box;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox total_box;
        private System.Windows.Forms.TextBox trained_box;
        private System.Windows.Forms.TextBox miscMod1_box;
        private System.Windows.Forms.TextBox miscMod2_box;
        private System.Windows.Forms.NumericUpDown ranks_box;
        private System.Windows.Forms.TextBox ability_mod_box;
    }
}
