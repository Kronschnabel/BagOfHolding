namespace BagOfHolding
{
    partial class Window
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
            this.back_panel = new System.Windows.Forms.Panel();
            this.main_panel = new System.Windows.Forms.Panel();
            this.close_butt = new System.Windows.Forms.Button();
            this.back_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_panel
            // 
            this.back_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(135)))));
            this.back_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.back_panel.Controls.Add(this.close_butt);
            this.back_panel.Controls.Add(this.main_panel);
            this.back_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back_panel.Location = new System.Drawing.Point(0, 0);
            this.back_panel.Margin = new System.Windows.Forms.Padding(0);
            this.back_panel.Name = "back_panel";
            this.back_panel.Padding = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.back_panel.Size = new System.Drawing.Size(900, 500);
            this.back_panel.TabIndex = 0;
            this.back_panel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.back_panel_MouseDoubleClick);
            this.back_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.back_panel_MouseDown);
            this.back_panel.MouseLeave += new System.EventHandler(this.back_panel_MouseLeave);
            this.back_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.back_panel_MouseMove);
            this.back_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.back_panel_MouseUp);
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(175)))));
            this.main_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(3, 30);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(892, 465);
            this.main_panel.TabIndex = 0;
            // 
            // close_butt
            // 
            this.close_butt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.close_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.close_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_butt.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_butt.ForeColor = System.Drawing.Color.White;
            this.close_butt.Image = global::BagOfHolding.Properties.Resources.close_icon;
            this.close_butt.Location = new System.Drawing.Point(872, 3);
            this.close_butt.Name = "close_butt";
            this.close_butt.Size = new System.Drawing.Size(23, 23);
            this.close_butt.TabIndex = 1;
            this.close_butt.UseVisualStyleBackColor = false;
            this.close_butt.Click += new System.EventHandler(this.closeB_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(135)))));
            this.Controls.Add(this.back_panel);
            this.Name = "Window";
            this.Size = new System.Drawing.Size(900, 500);
            this.back_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel back_panel;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Button close_butt;
    }
}
