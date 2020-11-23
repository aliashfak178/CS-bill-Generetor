namespace Bill_Generater_System
{
    partial class LoadForm
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
            this.LoadProgressBar = new iTalk.iTalk_ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LoadProgressBar
            // 
            this.LoadProgressBar.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.LoadProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LoadProgressBar.Location = new System.Drawing.Point(108, 26);
            this.LoadProgressBar.Maximum = ((long)(100));
            this.LoadProgressBar.MinimumSize = new System.Drawing.Size(100, 100);
            this.LoadProgressBar.Name = "LoadProgressBar";
            this.LoadProgressBar.ProgressColor1 = System.Drawing.Color.Yellow;
            this.LoadProgressBar.ProgressColor2 = System.Drawing.Color.Cyan;
            this.LoadProgressBar.ProgressShape = iTalk.iTalk_ProgressBar._ProgressShape.Round;
            this.LoadProgressBar.Size = new System.Drawing.Size(231, 231);
            this.LoadProgressBar.TabIndex = 0;
            this.LoadProgressBar.Text = "iTalk_ProgressBar1";
            this.LoadProgressBar.Value = ((long)(1));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(129, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOADING....";
            // 
            // LoadTimer
            // 
            this.LoadTimer.Enabled = true;
            this.LoadTimer.Interval = 20;
            this.LoadTimer.Tick += new System.EventHandler(this.LoadTimer_Tick);
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(446, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOADDING PAGE";
            this.Load += new System.EventHandler(this.LoadForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_ProgressBar LoadProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer LoadTimer;
    }
}

