namespace BagOfHolding
{
    partial class PanelBar
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
            this.back_bar = new System.Windows.Forms.Panel();
            this.front_bar = new System.Windows.Forms.Panel();
            this.back_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_bar
            // 
            this.back_bar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.back_bar.Controls.Add(this.front_bar);
            this.back_bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back_bar.Location = new System.Drawing.Point(0, 0);
            this.back_bar.Margin = new System.Windows.Forms.Padding(0);
            this.back_bar.Name = "back_bar";
            this.back_bar.Size = new System.Drawing.Size(559, 187);
            this.back_bar.TabIndex = 1;
            // 
            // front_bar
            // 
            this.front_bar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.front_bar.Dock = System.Windows.Forms.DockStyle.Left;
            this.front_bar.Location = new System.Drawing.Point(0, 0);
            this.front_bar.Margin = new System.Windows.Forms.Padding(0);
            this.front_bar.Name = "front_bar";
            this.front_bar.Size = new System.Drawing.Size(251, 187);
            this.front_bar.TabIndex = 1;
            // 
            // PanelBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.back_bar);
            this.Name = "PanelBar";
            this.Size = new System.Drawing.Size(559, 187);
            this.back_bar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel back_bar;
        private System.Windows.Forms.Panel front_bar;
    }
}
