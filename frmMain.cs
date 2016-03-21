using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;



namespace APIUI
{
  public partial class frmMain : Form
  {
    private String connectionString1 = ConfigurationManager.ConnectionStrings["APIUI.Properties.Settings.hspp1devo3ConnectionStringLive"].ConnectionString;
    private String connectionString2 = ConfigurationManager.ConnectionStrings["APIUI.Properties.Settings.hspp1devo3ConnectionStringDev"].ConnectionString;

    public frmMain()
    {
      InitializeComponent();
    }

    private void liveAPIToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Configuration myConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
      myConfig.ConnectionStrings.ConnectionStrings["APIUI.Properties.Settings.hspp1devo3ConnectionStringLive"].ConnectionString = connectionString1;
      myConfig.Save(ConfigurationSaveMode.Modified, true);
      ConfigurationManager.RefreshSection("connectionStrings");

      Form1 newMDIChild =  new Form1(connectionString1);
      // Set the Parent Form of the Child window.
      newMDIChild.MdiParent = this;
      newMDIChild.Show();
      
    }

    private void aPIDevToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Configuration myConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
      myConfig.ConnectionStrings.ConnectionStrings["APIUI.Properties.Settings.hspp1devo3ConnectionStringDev"].ConnectionString = connectionString2;
      myConfig.Save(ConfigurationSaveMode.Modified, true);
      ConfigurationManager.RefreshSection("connectionStrings");
    
      Form2 newMDIChild = new Form2(connectionString2);
      // Set the Parent Form of the Child window.
      newMDIChild.MdiParent = this;
      // Display the new form.
      newMDIChild.Show();
    }

    private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
