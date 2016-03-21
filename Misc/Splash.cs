using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Reflection;
using System.Threading;

namespace APIUI.Misc
{
  public partial class Splash : Form
  {
    public Splash()
    {
      InitializeComponent();
    }

    private void Splash_Shown(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(this.ProductName.ToString()))
      {
        ApplicationTitle.Text = this.ProductName.ToString();
      }
      else
      {
        //If the application title is missing, use the application name, without the extension
        ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(this.AccessibleName.ToString());
      }

      ////    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

      this.Version.Text = String.Format("Version {0}", AssemblyVersion);

      ////Copyright info
      Copyright.Text = "Horizon Spa & Pool Parts Inc., and its licensors. All rights reserved.";

      ProgressBar1.Value = 0;
    }

    //Timer 1
    private void Timer1_Tick(System.Object sender, System.EventArgs e)
    {
      ProgressBar1.Increment(1);
      if (ProgressBar1.Value == ProgressBar1.Maximum)
      {
        Timer1.Stop();
        Timer2.Stop();
        frmMain frmMain = new frmMain();
        frmMain.Show();
        this.Hide();
      }
    }

    //Timer 2
    void Timer2_Tick(System.Object sender, System.EventArgs e)
    {
      //Static local var
      if (ProgressBar1.Value <= 10)
      {
        Label2.Text = "Checking Database ...";
        ProgressBar1.Value++;
      }
      else if (ProgressBar1.Value <= 20)
      {
        Label2.Text = "Checking Classes ...";       
        ProgressBar1.Value++;
      }
      else if (ProgressBar1.Value <= 30)
      {
        Label2.Text = "Classes Initialized ...";
        ProgressBar1.Value++;
      }
      else if (ProgressBar1.Value <= 40)
      {
        Label2.Text = "Applying System Database ...";
        ProgressBar1.Value++;
      }
      else if (ProgressBar1.Value <= 50)
      {
        Label2.Text = "Applying Registration Application ...";
        ProgressBar1.Value++;
      }
      else if (ProgressBar1.Value <= 60)
      {
        Label2.Text = "Loading Database ...";
        ProgressBar1.Value++;
      }
      else if (ProgressBar1.Value <= 70)
      {
        Label2.Text = "Loading Registration Application ...";
        ProgressBar1.Value++;
      }
      else if (ProgressBar1.Value != 8)
      {
        ProgressBar1.Value++;
        Label2.Text = "Loading ...";
      }
    }

    public string AssemblyVersion
    {
      get
      {
        return Assembly.GetExecutingAssembly().GetName().Version.ToString();
      }
    }
  }
}
