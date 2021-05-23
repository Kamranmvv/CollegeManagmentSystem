
namespace Managment_system
{
    partial class Entry
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
            this.components = new System.ComponentModel.Container();
            this.panel_1 = new System.Windows.Forms.Panel();
            this.panel_2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_1 = new System.Windows.Forms.PictureBox();
            this.panel_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_1
            // 
            this.panel_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel_1.Controls.Add(this.panel_2);
            this.panel_1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_1.Location = new System.Drawing.Point(0, 450);
            this.panel_1.Name = "panel_1";
            this.panel_1.Size = new System.Drawing.Size(762, 10);
            this.panel_1.TabIndex = 1;
            // 
            // panel_2
            // 
            this.panel_2.BackColor = System.Drawing.Color.White;
            this.panel_2.Location = new System.Drawing.Point(0, 0);
            this.panel_2.Name = "panel_2";
            this.panel_2.Size = new System.Drawing.Size(20, 10);
            this.panel_2.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox_1
            // 
            this.pictureBox_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_1.Image = global::Managment_system.Properties.Resources.School_College_Management_System_1;
            this.pictureBox_1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_1.Name = "pictureBox_1";
            this.pictureBox_1.Size = new System.Drawing.Size(762, 460);
            this.pictureBox_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_1.TabIndex = 0;
            this.pictureBox_1.TabStop = false;
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 460);
            this.ControlBox = false;
            this.Controls.Add(this.panel_1);
            this.Controls.Add(this.pictureBox_1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Entry";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Entry_Load);
            this.panel_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_1;
        private System.Windows.Forms.Panel panel_2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox_1;
    }
}