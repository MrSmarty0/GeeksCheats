using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using KeyAuthApp;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geeks_Cheats
{
    public partial class SignUp : Form
    {
        public static api KeyAuthApp = new api(
    name: "GEEKS",
    ownerid: "Rwv1ehf0hR",
    secret: "dbaec9a6dc701b7fa28083f017ef1530438b956e7c3a2dbfa6fb0213ddd46a06",
    version: "1.0"
);
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            KeyAuthApp.register(us.Text, ps.Text, Key.Text);
            if (KeyAuthApp.response.success)
            {
                Login main = new Login();
                main.Show();
                this.Hide();
            }
            else
            {
                Program.ShowNotification(KeyAuthApp.response.message);
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();
            KeyAuthApp.check();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Login main = new Login();
            main.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
