
namespace MRodriguezACP2_2
{
    partial class frmSplashScreen
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
            this.pbxNFL = new System.Windows.Forms.PictureBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.pgrBarSplash = new System.Windows.Forms.ProgressBar();
            this.bkgWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNFL)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxNFL
            // 
            this.pbxNFL.Image = global::MRodriguezACP2_2.Properties.Resources.NFL1;
            this.pbxNFL.Location = new System.Drawing.Point(-1, 1);
            this.pbxNFL.Name = "pbxNFL";
            this.pbxNFL.Size = new System.Drawing.Size(800, 389);
            this.pbxNFL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxNFL.TabIndex = 0;
            this.pbxNFL.TabStop = false;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.ForeColor = System.Drawing.Color.White;
            this.lblProgress.Location = new System.Drawing.Point(380, 428);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(51, 16);
            this.lblProgress.TabIndex = 1;
            this.lblProgress.Text = "label1";
            // 
            // pgrBarSplash
            // 
            this.pgrBarSplash.Location = new System.Drawing.Point(-1, 396);
            this.pgrBarSplash.Name = "pgrBarSplash";
            this.pgrBarSplash.Size = new System.Drawing.Size(800, 23);
            this.pgrBarSplash.TabIndex = 2;
            // 
            // bkgWorker
            // 
            this.bkgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkgWorker_DoWork);
            this.bkgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkgWorker_ProgressChanged);
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pgrBarSplash);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.pbxNFL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash Screen";
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxNFL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxNFL;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar pgrBarSplash;
        private System.ComponentModel.BackgroundWorker bkgWorker;
    }
}