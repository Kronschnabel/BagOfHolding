namespace BagOfHolding
{
    partial class SettingsWindow
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
            this.settings_label = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.settings_panel = new System.Windows.Forms.Panel();
            this.window_color_table = new System.Windows.Forms.TableLayoutPanel();
            this.window_cont_label = new System.Windows.Forms.Label();
            this.window_butt_label = new System.Windows.Forms.Label();
            this.window_strip_label = new System.Windows.Forms.Label();
            this.window_cont_butt = new System.Windows.Forms.Button();
            this.window_butt_butt = new System.Windows.Forms.Button();
            this.window_strip_butt = new System.Windows.Forms.Button();
            this.console_color_table = new System.Windows.Forms.TableLayoutPanel();
            this.console_back_label = new System.Windows.Forms.Label();
            this.console_text_label = new System.Windows.Forms.Label();
            this.console_back_butt = new System.Windows.Forms.Button();
            this.console_text_butt = new System.Windows.Forms.Button();
            this.menu_strip = new System.Windows.Forms.MenuStrip();
            this.main_panel.SuspendLayout();
            this.settings_panel.SuspendLayout();
            this.window_color_table.SuspendLayout();
            this.console_color_table.SuspendLayout();
            this.SuspendLayout();
            // 
            // settings_label
            // 
            this.settings_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settings_label.AutoSize = true;
            this.settings_label.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_label.ForeColor = System.Drawing.Color.Gainsboro;
            this.settings_label.Location = new System.Drawing.Point(3, 38);
            this.settings_label.Name = "settings_label";
            this.settings_label.Size = new System.Drawing.Size(129, 23);
            this.settings_label.TabIndex = 2;
            this.settings_label.Text = "Color Settings";
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.main_panel.Controls.Add(this.settings_panel);
            this.main_panel.Controls.Add(this.menu_strip);
            this.main_panel.Controls.Add(this.settings_label);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Margin = new System.Windows.Forms.Padding(0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(271, 280);
            this.main_panel.TabIndex = 2;
            // 
            // settings_panel
            // 
            this.settings_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settings_panel.BackColor = System.Drawing.Color.Gainsboro;
            this.settings_panel.Controls.Add(this.window_color_table);
            this.settings_panel.Controls.Add(this.console_color_table);
            this.settings_panel.Location = new System.Drawing.Point(0, 64);
            this.settings_panel.Name = "settings_panel";
            this.settings_panel.Size = new System.Drawing.Size(271, 216);
            this.settings_panel.TabIndex = 26;
            // 
            // window_color_table
            // 
            this.window_color_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.window_color_table.ColumnCount = 2;
            this.window_color_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.98529F));
            this.window_color_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.01471F));
            this.window_color_table.Controls.Add(this.window_cont_label, 0, 0);
            this.window_color_table.Controls.Add(this.window_butt_label, 0, 1);
            this.window_color_table.Controls.Add(this.window_strip_label, 0, 2);
            this.window_color_table.Controls.Add(this.window_cont_butt, 1, 0);
            this.window_color_table.Controls.Add(this.window_butt_butt, 1, 1);
            this.window_color_table.Controls.Add(this.window_strip_butt, 1, 2);
            this.window_color_table.Location = new System.Drawing.Point(17, 91);
            this.window_color_table.Name = "window_color_table";
            this.window_color_table.RowCount = 3;
            this.window_color_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.window_color_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.window_color_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.window_color_table.Size = new System.Drawing.Size(237, 107);
            this.window_color_table.TabIndex = 0;
            // 
            // window_cont_label
            // 
            this.window_cont_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.window_cont_label.AutoSize = true;
            this.window_cont_label.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.window_cont_label.Location = new System.Drawing.Point(32, 9);
            this.window_cont_label.Name = "window_cont_label";
            this.window_cont_label.Size = new System.Drawing.Size(128, 18);
            this.window_cont_label.TabIndex = 0;
            this.window_cont_label.Text = "Window Container";
            // 
            // window_butt_label
            // 
            this.window_butt_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.window_butt_label.AutoSize = true;
            this.window_butt_label.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.window_butt_label.Location = new System.Drawing.Point(42, 43);
            this.window_butt_label.Name = "window_butt_label";
            this.window_butt_label.Size = new System.Drawing.Size(108, 18);
            this.window_butt_label.TabIndex = 0;
            this.window_butt_label.Text = "Window Button";
            // 
            // window_strip_label
            // 
            this.window_strip_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.window_strip_label.AutoSize = true;
            this.window_strip_label.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.window_strip_label.Location = new System.Drawing.Point(48, 78);
            this.window_strip_label.Name = "window_strip_label";
            this.window_strip_label.Size = new System.Drawing.Size(96, 18);
            this.window_strip_label.TabIndex = 0;
            this.window_strip_label.Text = "Window Strip";
            // 
            // window_cont_butt
            // 
            this.window_cont_butt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.window_cont_butt.Location = new System.Drawing.Point(202, 6);
            this.window_cont_butt.Name = "window_cont_butt";
            this.window_cont_butt.Size = new System.Drawing.Size(23, 23);
            this.window_cont_butt.TabIndex = 1;
            this.window_cont_butt.UseVisualStyleBackColor = true;
            this.window_cont_butt.Click += new System.EventHandler(this.window_cont_butt_Click);
            // 
            // window_butt_butt
            // 
            this.window_butt_butt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.window_butt_butt.Location = new System.Drawing.Point(202, 40);
            this.window_butt_butt.Name = "window_butt_butt";
            this.window_butt_butt.Size = new System.Drawing.Size(23, 23);
            this.window_butt_butt.TabIndex = 1;
            this.window_butt_butt.UseVisualStyleBackColor = true;
            this.window_butt_butt.Click += new System.EventHandler(this.window_butt_butt_Click);
            // 
            // window_strip_butt
            // 
            this.window_strip_butt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.window_strip_butt.Location = new System.Drawing.Point(202, 76);
            this.window_strip_butt.Name = "window_strip_butt";
            this.window_strip_butt.Size = new System.Drawing.Size(23, 23);
            this.window_strip_butt.TabIndex = 1;
            this.window_strip_butt.UseVisualStyleBackColor = true;
            this.window_strip_butt.Click += new System.EventHandler(this.window_strip_butt_Click);
            // 
            // console_color_table
            // 
            this.console_color_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.console_color_table.ColumnCount = 2;
            this.console_color_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.98529F));
            this.console_color_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.01471F));
            this.console_color_table.Controls.Add(this.console_back_label, 0, 0);
            this.console_color_table.Controls.Add(this.console_text_label, 0, 1);
            this.console_color_table.Controls.Add(this.console_back_butt, 1, 0);
            this.console_color_table.Controls.Add(this.console_text_butt, 1, 1);
            this.console_color_table.Location = new System.Drawing.Point(17, 16);
            this.console_color_table.Name = "console_color_table";
            this.console_color_table.RowCount = 2;
            this.console_color_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.console_color_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.console_color_table.Size = new System.Drawing.Size(237, 69);
            this.console_color_table.TabIndex = 0;
            // 
            // console_back_label
            // 
            this.console_back_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.console_back_label.AutoSize = true;
            this.console_back_label.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console_back_label.Location = new System.Drawing.Point(48, 8);
            this.console_back_label.Name = "console_back_label";
            this.console_back_label.Size = new System.Drawing.Size(97, 18);
            this.console_back_label.TabIndex = 0;
            this.console_back_label.Text = "Console Back";
            // 
            // console_text_label
            // 
            this.console_text_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.console_text_label.AutoSize = true;
            this.console_text_label.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console_text_label.Location = new System.Drawing.Point(51, 42);
            this.console_text_label.Name = "console_text_label";
            this.console_text_label.Size = new System.Drawing.Size(91, 18);
            this.console_text_label.TabIndex = 0;
            this.console_text_label.Text = "Console Text";
            // 
            // console_back_butt
            // 
            this.console_back_butt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.console_back_butt.Location = new System.Drawing.Point(202, 6);
            this.console_back_butt.Name = "console_back_butt";
            this.console_back_butt.Size = new System.Drawing.Size(23, 23);
            this.console_back_butt.TabIndex = 1;
            this.console_back_butt.UseVisualStyleBackColor = true;
            this.console_back_butt.Click += new System.EventHandler(this.console_back_butt_Click);
            // 
            // console_text_butt
            // 
            this.console_text_butt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.console_text_butt.Location = new System.Drawing.Point(202, 39);
            this.console_text_butt.Name = "console_text_butt";
            this.console_text_butt.Size = new System.Drawing.Size(23, 23);
            this.console_text_butt.TabIndex = 1;
            this.console_text_butt.UseVisualStyleBackColor = true;
            this.console_text_butt.Click += new System.EventHandler(this.console_text_butt_Click);
            // 
            // menu_strip
            // 
            this.menu_strip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menu_strip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menu_strip.Location = new System.Drawing.Point(0, 0);
            this.menu_strip.Margin = new System.Windows.Forms.Padding(3);
            this.menu_strip.Name = "menu_strip";
            this.menu_strip.Size = new System.Drawing.Size(271, 24);
            this.menu_strip.TabIndex = 25;
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.main_panel);
            this.Name = "SettingsWindow";
            this.Size = new System.Drawing.Size(271, 280);
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.settings_panel.ResumeLayout(false);
            this.window_color_table.ResumeLayout(false);
            this.window_color_table.PerformLayout();
            this.console_color_table.ResumeLayout(false);
            this.console_color_table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label settings_label;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel settings_panel;
        private System.Windows.Forms.TableLayoutPanel window_color_table;
        private System.Windows.Forms.Label window_cont_label;
        private System.Windows.Forms.Label window_butt_label;
        private System.Windows.Forms.Label window_strip_label;
        private System.Windows.Forms.Button window_cont_butt;
        private System.Windows.Forms.Button window_butt_butt;
        private System.Windows.Forms.Button window_strip_butt;
        private System.Windows.Forms.TableLayoutPanel console_color_table;
        private System.Windows.Forms.Label console_back_label;
        private System.Windows.Forms.Label console_text_label;
        private System.Windows.Forms.Button console_back_butt;
        private System.Windows.Forms.Button console_text_butt;
        private System.Windows.Forms.MenuStrip menu_strip;
    }
}
