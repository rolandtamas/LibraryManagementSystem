using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        int start = 0;

        private void timer1_Tick(object Sender, EventArgs e)
        {
            start += 1;
            SplashProgress.Value = start;
            if(SplashProgress.Value == 100)
            {
                SplashProgress.Value = 0;
                timer1.Stop();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
