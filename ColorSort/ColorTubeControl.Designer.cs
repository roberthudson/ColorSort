
namespace ColorSort
{
    partial class ColorTube
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.verticalProgressBar4 = new ColorSort.VerticalProgressBar();
            this.verticalProgressBar3 = new ColorSort.VerticalProgressBar();
            this.verticalProgressBar2 = new ColorSort.VerticalProgressBar();
            this.verticalProgressBar1 = new ColorSort.VerticalProgressBar();
            this.SuspendLayout();
            // 
            // verticalProgressBar4
            // 
            this.verticalProgressBar4.Cursor = System.Windows.Forms.Cursors.Cross;
            this.verticalProgressBar4.Enabled = false;
            this.verticalProgressBar4.Location = new System.Drawing.Point(21, 28);
            this.verticalProgressBar4.Name = "verticalProgressBar4";
            this.verticalProgressBar4.Size = new System.Drawing.Size(32, 32);
            this.verticalProgressBar4.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.verticalProgressBar4.TabIndex = 3;
            // 
            // verticalProgressBar3
            // 
            this.verticalProgressBar3.Cursor = System.Windows.Forms.Cursors.Cross;
            this.verticalProgressBar3.Enabled = false;
            this.verticalProgressBar3.Location = new System.Drawing.Point(21, 57);
            this.verticalProgressBar3.Name = "verticalProgressBar3";
            this.verticalProgressBar3.Size = new System.Drawing.Size(32, 32);
            this.verticalProgressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.verticalProgressBar3.TabIndex = 2;
            // 
            // verticalProgressBar2
            // 
            this.verticalProgressBar2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.verticalProgressBar2.Enabled = false;
            this.verticalProgressBar2.Location = new System.Drawing.Point(21, 85);
            this.verticalProgressBar2.Name = "verticalProgressBar2";
            this.verticalProgressBar2.Size = new System.Drawing.Size(32, 32);
            this.verticalProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.verticalProgressBar2.TabIndex = 1;
            // 
            // verticalProgressBar1
            // 
            this.verticalProgressBar1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.verticalProgressBar1.Enabled = false;
            this.verticalProgressBar1.Location = new System.Drawing.Point(21, 114);
            this.verticalProgressBar1.Name = "verticalProgressBar1";
            this.verticalProgressBar1.Size = new System.Drawing.Size(32, 32);
            this.verticalProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.verticalProgressBar1.TabIndex = 0;
            // 
            // ColorTube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.verticalProgressBar4);
            this.Controls.Add(this.verticalProgressBar3);
            this.Controls.Add(this.verticalProgressBar2);
            this.Controls.Add(this.verticalProgressBar1);
            this.Name = "ColorTube";
            this.Size = new System.Drawing.Size(74, 171);
            this.Click += new System.EventHandler(this.ColorTube_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private VerticalProgressBar verticalProgressBar1;
        private VerticalProgressBar verticalProgressBar2;
        private VerticalProgressBar verticalProgressBar3;
        private VerticalProgressBar verticalProgressBar4;
    }
}
