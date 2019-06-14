namespace MyGUiAppFirst
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.showColorDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialogBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialogBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(160, 374);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 36);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Ganesha Omkara";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showColorDialogToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(597, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // showColorDialogToolStripMenuItem
            // 
            this.showColorDialogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorDialogBoxToolStripMenuItem,
            this.fontDialogBoxToolStripMenuItem});
            this.showColorDialogToolStripMenuItem.Name = "showColorDialogToolStripMenuItem";
            this.showColorDialogToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.showColorDialogToolStripMenuItem.Text = "ShowDialogs";
            // 
            // colorDialogBoxToolStripMenuItem
            // 
            this.colorDialogBoxToolStripMenuItem.Name = "colorDialogBoxToolStripMenuItem";
            this.colorDialogBoxToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.colorDialogBoxToolStripMenuItem.Text = "ColorDialogBox";
            this.colorDialogBoxToolStripMenuItem.Click += new System.EventHandler(this.colorDialogBoxToolStripMenuItem_Click);
            // 
            // fontDialogBoxToolStripMenuItem
            // 
            this.fontDialogBoxToolStripMenuItem.Name = "fontDialogBoxToolStripMenuItem";
            this.fontDialogBoxToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.fontDialogBoxToolStripMenuItem.Text = "FontDialogBox";
            this.fontDialogBoxToolStripMenuItem.Click += new System.EventHandler(this.fontDialogBoxToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 466);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showColorDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorDialogBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontDialogBoxToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}