using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace AprilVision_ALPHA
{
    public partial class LoaderUI : Form
    {
        public LoaderUI()
        {
            InitializeComponent();
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            await Task.Delay(1000);
            WebClient updatecheck = new WebClient();
            panel4.Width = 290;
            label1.Text = ("Checking For Updates");
            await Task.Delay(1000);
            if (!updatecheck.DownloadString("https://raw.githubusercontent.com/robloxexploit123/AprilVision-ALPHA-/main/UpdateCheck").Contains("1.0"))
            {
                label1.Text = ("You do not have the correct version!");
                MessageBox.Show("You do not have the correct version for AprilVision. Would you like to join the discord server?", "AprilVision");
                Information.Discordinvite();
                await Task.Delay(1000);
                Application.Exit();
            }
            else
            {
                panel4.Width = 310;
                label1.Text = "Checking For Patch";
                await Task.Delay(1000);
                WebClient PatchCheck = new WebClient();
                if (!PatchCheck.DownloadString("https://raw.githubusercontent.com/robloxexploit123/AprilVision-ALPHA-/main/PatchCheck").Contains("Not Patched"))
                {
                   MessageBox.Show("AprilVision Is Patched Right Now. If you would like, yo ucan join the discord server For lates Updates / Announcments", "AprilVision");
                    Information.Discordinvite();
                    await Task.Delay(1000);
                    Application.Exit();
                }
                else
                {
                    panel4.Width = 510;
                    label4.Text = ("Loading AprilVision Exploit. . .");
                    await Task.Delay(1500);
                    panel4.Width = 757;
                    await Task.Delay(2500);
                    this.Hide();
                    MainUI mainUI = new MainUI();
                    mainUI.Show();
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
