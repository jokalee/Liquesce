﻿namespace LiquesceTray
{
    partial class FreeSpace
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreeSpace));
         this.timer1 = new System.Windows.Forms.Timer(this.components);
         this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
         this.SuspendLayout();
         // 
         // timer1
         // 
         this.timer1.Enabled = true;
         this.timer1.Interval = 3000;
         this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
         // 
         // flowLayout
         // 
         this.flowLayout.AutoScroll = true;
         this.flowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
         this.flowLayout.Location = new System.Drawing.Point(0, 0);
         this.flowLayout.Name = "flowLayout";
         this.flowLayout.Size = new System.Drawing.Size(814, 362);
         this.flowLayout.TabIndex = 0;
         // 
         // FreeSpace
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(814, 362);
         this.Controls.Add(this.flowLayout);
         this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximumSize = new System.Drawing.Size(939, 107688);
         this.MinimizeBox = false;
         this.MinimumSize = new System.Drawing.Size(830, 40);
         this.Name = "FreeSpace";
         this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
         this.Text = "Liquesce Free Space";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FreeSpace_FormClosing);
         this.Load += new System.EventHandler(this.Form1_Load);
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;




    }
}