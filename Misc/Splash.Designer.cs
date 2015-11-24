namespace APIUI.Misc
{
  partial class Splash
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
      this.Timer1 = new System.Windows.Forms.Timer(this.components);
      this.Timer2 = new System.Windows.Forms.Timer(this.components);
      this.ApplicationTitle = new System.Windows.Forms.Label();
      this.Version = new System.Windows.Forms.Label();
      this.Copyright = new System.Windows.Forms.Label();
      this.Label2 = new System.Windows.Forms.Label();
      this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
      this.PictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // Timer1
      // 
      this.Timer1.Enabled = true;
      this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
      // 
      // Timer2
      // 
      this.Timer2.Enabled = true;
      this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
      // 
      // ApplicationTitle
      // 
      this.ApplicationTitle.AutoSize = true;
      this.ApplicationTitle.BackColor = System.Drawing.Color.Transparent;
      this.ApplicationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ApplicationTitle.ForeColor = System.Drawing.Color.White;
      this.ApplicationTitle.Location = new System.Drawing.Point(12, 84);
      this.ApplicationTitle.Name = "ApplicationTitle";
      this.ApplicationTitle.Size = new System.Drawing.Size(106, 13);
      this.ApplicationTitle.TabIndex = 19;
      this.ApplicationTitle.Text = "Application Name";
      // 
      // Version
      // 
      this.Version.AutoSize = true;
      this.Version.BackColor = System.Drawing.Color.Transparent;
      this.Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Version.ForeColor = System.Drawing.Color.White;
      this.Version.Location = new System.Drawing.Point(308, 84);
      this.Version.Name = "Version";
      this.Version.Size = new System.Drawing.Size(49, 13);
      this.Version.TabIndex = 18;
      this.Version.Text = "Version";
      // 
      // Copyright
      // 
      this.Copyright.AutoSize = true;
      this.Copyright.BackColor = System.Drawing.Color.Transparent;
      this.Copyright.ForeColor = System.Drawing.Color.White;
      this.Copyright.Location = new System.Drawing.Point(12, 104);
      this.Copyright.Name = "Copyright";
      this.Copyright.Size = new System.Drawing.Size(51, 13);
      this.Copyright.TabIndex = 17;
      this.Copyright.Text = "Copyright";
      // 
      // Label2
      // 
      this.Label2.AutoSize = true;
      this.Label2.Location = new System.Drawing.Point(12, 144);
      this.Label2.Name = "Label2";
      this.Label2.Size = new System.Drawing.Size(54, 13);
      this.Label2.TabIndex = 16;
      this.Label2.Text = "Loading...";
      // 
      // ProgressBar1
      // 
      this.ProgressBar1.Cursor = System.Windows.Forms.Cursors.AppStarting;
      this.ProgressBar1.ForeColor = System.Drawing.Color.Crimson;
      this.ProgressBar1.Location = new System.Drawing.Point(12, 163);
      this.ProgressBar1.Name = "ProgressBar1";
      this.ProgressBar1.Size = new System.Drawing.Size(469, 18);
      this.ProgressBar1.TabIndex = 14;
      // 
      // PictureBox1
      // 
      this.PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox1.BackgroundImage")));
      this.PictureBox1.Location = new System.Drawing.Point(12, 12);
      this.PictureBox1.Name = "PictureBox1";
      this.PictureBox1.Size = new System.Drawing.Size(205, 61);
      this.PictureBox1.TabIndex = 15;
      this.PictureBox1.TabStop = false;
      // 
      // Splash
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.DodgerBlue;
      this.ClientSize = new System.Drawing.Size(493, 193);
      this.ControlBox = false;
      this.Controls.Add(this.ApplicationTitle);
      this.Controls.Add(this.Version);
      this.Controls.Add(this.Copyright);
      this.Controls.Add(this.Label2);
      this.Controls.Add(this.ProgressBar1);
      this.Controls.Add(this.PictureBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Splash";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Load += new System.EventHandler(this.Splash_Shown);
      this.Shown += new System.EventHandler(this.Splash_Shown);
      ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.Timer Timer1;
    internal System.Windows.Forms.Timer Timer2;
    internal System.Windows.Forms.Label ApplicationTitle;
    internal System.Windows.Forms.Label Version;
    internal System.Windows.Forms.Label Copyright;
    internal System.Windows.Forms.Label Label2;
    internal System.Windows.Forms.ProgressBar ProgressBar1;
    internal System.Windows.Forms.PictureBox PictureBox1;
  }
}