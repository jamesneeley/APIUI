﻿namespace APIUI
{
  partial class frmMain
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.liveAPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aPIDevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(633, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liveAPIToolStripMenuItem,
            this.aPIDevToolStripMenuItem});
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.ShortcutKeyDisplayString = "";
      this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
      this.openToolStripMenuItem.Text = "&Open";
      // 
      // liveAPIToolStripMenuItem
      // 
      this.liveAPIToolStripMenuItem.Name = "liveAPIToolStripMenuItem";
      this.liveAPIToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
      this.liveAPIToolStripMenuItem.Text = "API - Live";
      this.liveAPIToolStripMenuItem.Click += new System.EventHandler(this.liveAPIToolStripMenuItem_Click);
      // 
      // aPIDevToolStripMenuItem
      // 
      this.aPIDevToolStripMenuItem.Name = "aPIDevToolStripMenuItem";
      this.aPIDevToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
      this.aPIDevToolStripMenuItem.Text = "API - Dev";
      this.aPIDevToolStripMenuItem.Click += new System.EventHandler(this.aPIDevToolStripMenuItem_Click);
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(633, 532);
      this.Controls.Add(this.menuStrip1);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "frmMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "frmMain";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem liveAPIToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aPIDevToolStripMenuItem;
  }
}