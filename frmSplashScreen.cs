using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MRodriguezACP2_2
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void bkgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i = 1; i <= 100; i++)
            {
                Thread.Sleep(50);
                bkgWorker.ReportProgress(i);
            }
        }

        private void bkgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgrBarSplash.Value = e.ProgressPercentage;
            lblProgress.Text = "Progress: " + e.ProgressPercentage.ToString() + "%";
            if(pgrBarSplash.Value >= 100)
            {
                new frmDatabase().Show();
                this.Hide();
            }
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            bkgWorker.WorkerReportsProgress = true;
            bkgWorker.RunWorkerAsync();
        }
    }
}
