using DiscordRPC;
using DracoCheats;
using Geeks_Cheats.Properties;
using KeyAuthApp;
using System;
using System.Windows.Forms;

namespace Geeks_Cheats
{
    public partial class Login : Form
    {
        public static api KeyAuthApp = new api(
            name: "GEEKS",
            ownerid: "Rwv1ehf0hR",
            secret: "dbaec9a6dc701b7fa28083f017ef1530438b956e7c3a2dbfa6fb0213ddd46a06",
            version: "1.0"
        );
        public Login()
        {
            InitializeComponent();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            KeyAuthApp.login(us.Text, ps.Text);
            if (KeyAuthApp.response.success)
            {
                timer1.Enabled = true;
            }
            else
            {
                Program.ShowNotification(KeyAuthApp.response.message);
            }

            Properties.Settings.Default.userName = us.Text;
            Properties.Settings.Default.passUser = ps.Text;
            Properties.Settings.Default.Save();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();
            KeyAuthApp.check();

            if (Settings.Default.userName != string.Empty)
            {
                Properties.Settings.Default.userName = us.Text;
                Properties.Settings.Default.passUser = ps.Text;
                Properties.Settings.Default.Save();
            }

            Program.ShowNotification("Welcome To Geeks Cheats");

            RPC.rpctimestamp = Timestamps.Now;
            RPC.InitializeRPC();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Save_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.userName = us.Text;
            Properties.Settings.Default.passUser = ps.Text;
            Properties.Settings.Default.Save();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            SignUp main = new SignUp();
            main.Show();
            this.Hide();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();

            Program.ShowNotification("Sign in SucessFully");
            timer1.Enabled = false;
        }
    }
}
