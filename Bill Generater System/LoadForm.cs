using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bill_Generater_System
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
        }

        private void LoadForm_Load(object sender, EventArgs e)
        {
            LoadTimer.Start();
        }

        private void LoadTimer_Tick(object sender, EventArgs e)
        {
            LoadProgressBar.Value += 5;
            if (LoadProgressBar.Value >= 100)
            {
                MainForm MF = new MainForm();
                LoadTimer.Stop();
                this.Hide();
                MF.Show();
            }
        }
    }
}
