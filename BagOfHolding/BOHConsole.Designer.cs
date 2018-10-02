namespace BagOfHolding
{
    partial class BOHConsole
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.console_box = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // console_box
            // 
            this.console_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.console_box.BackColor = System.Drawing.Color.Black;
            this.console_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.console_box.DetectUrls = false;
            this.console_box.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.console_box.Location = new System.Drawing.Point(13, 13);
            this.console_box.Name = "console_box";
            this.console_box.Size = new System.Drawing.Size(891, 404);
            this.console_box.TabIndex = 0;
            this.console_box.Text = "";
            this.console_box.DoubleClick += new System.EventHandler(this.console_box_DoubleClick);
            this.console_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.console_box_KeyDown);
            // 
            // BOHConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(916, 495);
            this.Controls.Add(this.console_box);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BOHConsole";
            this.Text = "BOHConsole";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.RichTextBox console_box;
    }
} 


