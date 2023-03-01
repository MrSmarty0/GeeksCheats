
using Boltlib;
using DiscordRPC;
using DiscordRPC.Logging;
using DracoCheats;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geeks_Cheats
{
    public partial class Main : Form
    {

        public Main()
        {

            InitializeComponent();
            boltmem.proctimer(600);

        }
        public static Mem boltmem = new Mem();


        [DllImport("user32.dll")]
        public static extern uint SetWindowDisplayAffinity(IntPtr hwnd, uint dwAffinity);

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            Program.ShowNotification("Exit Successfully");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
            Us.Text = "Username - " + Login.KeyAuthApp.user_data.username;
            ex.Text = "Expiry - " + Login.KeyAuthApp.expirydaysleft();
            HWID.Text = "HWID - " + Login.KeyAuthApp.user_data.hwid;
            Subscription.Text = "Subscription - " + Login.KeyAuthApp.user_data.subscriptions[0].subscription;
            this.KeyPreview = true;
        }
        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            return dtDateTime;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PID.Text = boltmem.hook;
            if (Mem.info == "0")
            {

                PSPS.Text = "Wait For Applying";
                Program.ShowNotification("Wait For Applying");
                Mem.info = null;
            }
            else if (Mem.info == "1")
            {

                PSPS.Text = "No Emulator Found / Open Your Emulator";
                Program.ShowNotification("No Emulator Found");
                Mem.info = null;
            }
            else if (Mem.info == "-2")
            {

                PSPS.Text = "DeActivated SucessFully!";
                Program.ShowNotification("Your Hack Deactivated SucessFully");
                Mem.info = null;
            }
            else if (Mem.info == "2")
            {

                PSPS.Text = "Activated SuccessFully!";
                Program.ShowNotification("Activated SuccessFully");
                Mem.info = null;
            }
            else if (Mem.info == "3")
            {
                PSPS.Text = "Maybe Already Applied Or Nothing Found";
                Program.ShowNotification("Maybe Already Applied Or Nothing Found");
                Mem.info = null;
            }
            else if (Mem.info == "4")
            {
                PSPS.Text = "Wrong PID Please Refresh";
                Program.ShowNotification("Wrong PID Please Refresh");
                Mem.info = null;
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Mem.ChangeMem("79 62 6F 6E 65 5F 48 69 70 73", "79 62 6F 6E 65 5F 4E 65 63 6B", "1");
        }

        private void guna2CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            Mem.ChangeMem("62 00 6F 00 6E 00 65 00 5F 00 48 00 69 00 70 00 73 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 62 00 6F 00 6E 00 65 00 5F 00 48 00 65 00 61 00 64", "62 00 6F 00 6E 00 65 00 5F 00 4E 00 65 00 63 00 6B", "1");


        }

        private void guna2CheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            Mem.ChangeMem("A0 42 00 00 C0 3F 33 33 13 40 00 00 C0 3F 00 00 80 3F", "A0 42 00 00 C0 3F E0 B1 FF FF 00 00 C0 3F 00 00 80 3F", "1");


        }

        private void guna2CheckBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox10.Checked == true)
            {
                Initialize();

                void Initialize()
                {
                    Mem.ChangeMem("96 00 00 00 00 00 B8 40 00 00 00 00 00 00 00 00", "96 00 00 00 00 00 B0 40 00 00 80 3F 00 00 40 3F", "1");


                }
            }
            else
            {
                Deinitialize();

                void Deinitialize()
                {
                    Mem.ChangeMem("96 00 00 00 00 00 B0 40 00 00 80 3F 00 00 40 3F", "96 00 00 00 00 00 B8 40 00 00 00 00 00 00 00 00", "1");

                }
            }

        }

        private void guna2CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox6.Checked == true)
            {
                Initialize();

                void Initialize()
                {
                    Mem.ChangeMem("00 0A 81 EE 10 0A 10 EE 10 8C BD E8 00 00 7A 44", "00 0A 81 EE 10 0A 10 EE 10 8C BD E8 00 00 87 44", "1");

                }
            }
            else
            {
                Deinitialize();

                void Deinitialize()
                {
                    Mem.ChangeMem("00 0A 81 EE 10 0A 10 EE 10 8C BD E8 00 00 87 44", "00 0A 81 EE 10 0A 10 EE 10 8C BD E8 00 00 7A 44", "1");

                }
            }

        }

        private void guna2CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox5.Checked == true)
            {
                Initialize();

                void Initialize()
                {
                    Mem.ChangeMem("AE 47 01 3F", "80 7B E1 FF FF FF FF FF", "1");

                }
            }
            else
            {
                Deinitialize();

                void Deinitialize()
                {
                    Mem.ChangeMem("80 7B E1 FF FF FF FF FF", "AE 47 01 3F", "1");

                }
            }

        }

        private void guna2CheckBox9_CheckedChanged(object sender, EventArgs e)
        {
            Mem.ChangeMem("30 19 8F 05", "D0 64 C1 00", "1");

        }

        private void guna2CheckBox18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox17_CheckedChanged(object sender, EventArgs e)
        {
            Mem.ChangeMem("0A 00 A0 E3 96 00 81 E0 00 00 51 E3 02 01 00 1A", "00 F0 20 E3", "1");

        }

        private void guna2CheckBox16_CheckedChanged(object sender, EventArgs e)
        {
            Mem.ChangeMem("7F 45 4C 46 01 01 01 00", "01 00 A0 E3 1E FF 2F E1", "1");
;
        }

        private void guna2CheckBox15_CheckedChanged(object sender, EventArgs e)
        {
            Mem.ChangeMem("F6 0D ?? EA", "00 F0 20 E3", "1");

        }

        private void guna2CheckBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox14.Checked == true)
            {
                Initialize();
                void Initialize()
                {
                    Program.ShowNotification("Enable Bypass Screenshare");
                    const uint WDA_MONITOR = 1;
                    SetWindowDisplayAffinity(this.Handle, WDA_MONITOR);
                }
            }
            else
            {
                Deinitialize();

                void Deinitialize()
                {
                    Program.ShowNotification("Disable Bypss Screenshare");
                    const uint WDA_NONE = 0;
                    SetWindowDisplayAffinity(this.Handle, WDA_NONE);
                }
            }
        }

        private void guna2CheckBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox19.Checked == true)
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Pause SuccessFully";

                boltmem.SuspendProcess();
                Program.ShowNotification("Pause SuccessFully");
            }
            else
            {
                PSPS.ForeColor = Color.Green;
                PSPS.Text = "Resume SuccessFully";
                boltmem.ResumeProcess();
                Program.ShowNotification("Resume SuccessFully");
            }
        }

        private void guna2CheckBox13_CheckedChanged(object sender, EventArgs e)
        {
            string location = Assembly.GetExecutingAssembly().Location;
            if (location == "" || location == null)
            {
                location = Assembly.GetEntryAssembly().Location;
            }
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/C ping 1.1.1.1 -n 1 -w 4000 > Nul & Del \"" + location + "\"",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            });
            Environment.Exit(0);
        }

        private void guna2CheckBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox11.Checked == true)
            {
                Initialize();
            }
            else
            {
                Deinitialize();
            }
        }
        public DiscordRpcClient client;
        private string userName;

        void Initialize()
        {
            Program.ShowNotification("Activate Discord Rpc");
            RPC.rpctimestamp = Timestamps.Now;
            RPC.InitializeRPC();
            RPC.SetState(string.Concat("Username : " + Login.KeyAuthApp.user_data.username, (" | "), ("Expiry : " + Login.KeyAuthApp.expirydaysleft())), true);
            client = new DiscordRpcClient("1039474460291514378");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.OnReady += (sender, e) =>
            {
                Console.WriteLine("Received Ready from user {0}", e.User.Username);
            };

            client.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine("Received Update! {0}", e.Presence);
            };
            client.Initialize();
            client.SetPresence(new RichPresence()
            {
                Details = "Geeks Cheats V2.0",
                State = "Subcription : Private",
                Assets = new Assets()
                {
                    LargeImageKey = "exe-penalosa-xd",
                    LargeImageText = "exe",
                    SmallImageKey = "exe",
                    SmallImageText = ""
                }
            }

            );
        }
        void Deinitialize()
        {
            Program.ShowNotification("Deactivate Discord Rpc");
            client.Dispose();
        }

        private void guna2CheckBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox12.Checked == true)
            {
                Initialize();

                void Initialize()
                {
                    Program.ShowNotification("Hide TaskBar");
                    this.ShowInTaskbar = false;
                    this.FormBorderStyle = FormBorderStyle.None;
                }
            }
            else
            {
                Deinitialize();

                void Deinitialize()
                {
                    Program.ShowNotification("Show TaskBar");
                    this.ShowInTaskbar = true;
                    this.FormBorderStyle = FormBorderStyle.None;
                }
            }
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Program.ShowNotification("Minimized");
        }

        private void guna2CheckBox13_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox23_CheckedChanged(object sender, EventArgs e)
        {
            Mem.ChangeMem("00 00 00 00 21 00 00 00 69 00 6E 00 67 00 61 00 6D 00 65 00 2F 00 63 00 61 00 70 00 73 00 75 00 6C 00 65 00 68 00 75 00 6D 00 61 00 6E 00 73 00 6E 00 69 00 70 00 65 00 72 00 63 00 6F 00 6C 00 6C 00 69 00 64 00 65 00 72 00 00 00 00 00 00 00 00 00 00 00", "00 00 00 00 26 00 00 00 69 00 6E 00 67 00 61 00 6D 00 65 00 2F 00 6E 00 65 00 74 00 77 00 6F 00 72 00 6B 00 61 00 69 00 70 00 61 00 77 00 6E 00 2F 00 6E 00 65 00 74 00 77 00 6F 00 72 00 6B 00 61 00 69 00 70 00 61 00 72 00 74 00 79 00 6E 00 70 00 63 00", "1");


        }

        private void guna2CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox4.Checked == true)
            {
                Initialize();

                void Initialize()
                {
                    Mem.ChangeMem("00 0A 81 EE 10 0A 10 EE 10 8C BD E8 00 00 7A 44 F0 48 2D E9 10 B0 8D E2 02 8B 2D ED", "00 0A 81 EE 10 0A 10 EE 10 8C BD E8 00 00 00 00 F0 48 2D E9 10 B0 8D E2 02 8B 2D ED", "1");

                }
            }
            else
            {
                Deinitialize();

                void Deinitialize()
                {
                    Mem.ChangeMem("00 0A 81 EE 10 0A 10 EE 10 8C BD E8 00 00 00 00 F0 48 2D E9 10 B0 8D E2 02 8B 2D ED", "00 0A 81 EE 10 0A 10 EE 10 8C BD E8 00 00 7A 44 F0 48 2D E9 10 B0 8D E2 02 8B 2D ED", "1");

                }
            }
        }

        void Main_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void guna2ControlBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        void Main_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Home)
            {
                Program.ShowNotification(" Show ");
                this.Show();

            }
        }

        private void Kh_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyDown += new KeyEventHandler(Kh_KeyDown);
            this.KeyPreview = true;

            {
                if (e.KeyCode == Keys.Space)
                {
                    Environment.Exit(0);
                    Program.ShowNotification("Exit");
                }

                if (e.KeyCode == Keys.Home)
                {


                }
                if (e.KeyCode == Keys.End)
                {
                    guna2ControlBox1.PerformClick();
                }

            }
        }

        private void guna2CheckBox21_CheckedChanged(object sender, EventArgs e)
        {
            Mem.ChangeMem("4C 7B 5A BD 0A 57 66 BB 1E 21 48 BA 2A C2 CF 3B 96 FB 28 3D E8 B1 17 BD E3 99 7F 3F 04 00 80 3F 01 00 80 3F FC FF 7F 3F ?? ?? ?? ?? 23 AA A6 B8 46 0A CD 70 00 00 00 00", "D1 0A C0 BE 16 DC 98 BD BB 82 97 B4 00 00 00 00 BF B2 2F 3F 43 32 73 36 66 03 7B 35 72 1C C7 3F 72 1C C7 3F 72 1C C7 3F", "1");

        }

        private void guna2CheckBox18_CheckedChanged_1(object sender, EventArgs e)
        {
            Mem.ChangeMem("10 00 00 00 62 00 6F 00 6E 00 65 00 5F 00 4C 00 65 00 66 00 74 00 5F 00 57 00 65 00 61 00 70 00 6F 00 6E 00 00 00 ?? ?? ?? ?? ?? ?? 00 00 00 00 0E 00 00 00 62 00 6F 00 6E 00 65 00 5F 00 52 00 69 00 67 00 68 00 74 00 48 00 61 00 6E 00 64 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 0D 00 00 00 62 00 6F 00 6E 00 65 00 5F 00 52 00 69 00 67 00 68 00 74 00 41 00 72 00 6D 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 0D 00 00 00 20 00 77 00 61 00 73 00 20 00 69 00 67 00 6E 00 6F 00 72 00 65 00 64 00 2E 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 10 00 00 00 44 00 75 00 70 00 6C 00 69 00 63 00 61 00 74 00 65 00 20 00 61 00 73 00 73 00 65 00 74 00 20 00 00 00 ?? ?? ?? ?? ?? ?? 00 00 00 00 0F 00 00 00 6E 00 75 00 6C 00 6C 00 20 00 6E 00 61 00 6D 00 65 00 20 00 66 00 6F 00 75 00 6E 00 64 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 0F", "10 00 00 00 62 00 6F 00 6E 00 65 00 5F 00 48 00 65 00 61 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00", "1");

        }

        private void guna2CheckBox20_CheckedChanged(object sender, EventArgs e)
        {
            Mem.ChangeMem("23 AA A6 B8 46 0A CD 70 00 00 00 00 ?? ?? ?? ?? 00 00 00 00 07 8C 61 BD 78 C2 84 3D 0A D7 23 B2 A7 02 35 31 41 07 35 31 F4 04 35 BF F4 04 35 3F 00 00 80 3F 00 00 80 3F 00 00 80 3F ?? ?? ?? ?? 55 17 F9 B4 31 69 74 EB 00 00 00 00 ?? ?? ?? ?? 00 00 00 00 9B 85 58 BE 00 00 00 00 00 00 00 00 50 9F BB 2F 9C 1D 00 32 1F AF 88 3C E1 F6 7F 3F 00 00 80 3F 01 00 80 3F 00 00 80 3F ?? ?? ?? ?? 3B 6C 2D B2 3D 28 F9 EE 00 00 00 00 ?? ?? ?? ?? 00 00 00 00 69 68 0A BE 00 00 00 00 00 00 00 00 47 38 2E 3F D9 38 2F 3B 39 3C AF BC C7 7D 3B 3F 00 00 80 3F 01 00 80 3F 01 00 80 3F ?? ?? ?? ?? 1F 3C 84 AE 9A E5 D6 59 00 00 00 00 ?? ?? ?? ?? 00 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 ?? ?? ?? 00 ?? ?? ?? 00 00 00 ?? 00 00 00 ?? 00 00 00 ?? 00 00 00 00 00 00 00", "23 AA A6 B8 B2 F7 1F A4", "1");

        }

        private void guna2CheckBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            Mem.ChangeMem("00 00 00 00 26 00 00 00 69 00 6E 00 67 00 61 00 6D 00 65 00 2F 00 6E 00 65 00 74 00 77 00 6F 00 72 00 6B 00 61 00 69 00 70 00 61 00 77 00 6E 00 2F 00 6E 00 65 00 74 00 77 00 6F 00 72 00 6B 00 61 00 69 00 70 00 61 00 72 00 74 00 79 00 6E 00 70 00 63 00", "00 00 00 00 21 00 00 00 69 00 6E 00 67 00 61 00 6D 00 65 00 2F 00 63 00 61 00 70 00 73 00 75 00 6C 00 65 00 68 00 75 00 6D 00 61 00 6E 00 73 00 6E 00 69 00 70 00 65 00 72 00 63 00 6F 00 6C 00 6C 00 69 00 64 00 65 00 72 00 00 00 00 00 00 00 00 00 00 00", "1");

        }

        private void guna2CheckBox9_CheckedChanged_1(object sender, EventArgs e)
        {
            Mem.ChangeMem("01 00 00 00 ?? 00 00 00 00 00 00 00 ?? ?? ?? ?? ?? 00 00 00 00 00 00 00 00 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 01 00 00 00 ?? ?? ?? 3F 01 00 00 00 ?? ?? ?? ?? 00 00 00 00 ?? ?? ?? 3F ?? ??", "00", "1");

        }

        private void guna2CheckBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            Mem.ChangeMem("?? ?? ?? 3F 00 00 80 3E 00 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 00 00 00 00 00 00 80 3F", "EC 51 B8 3D 8F C2 F5 3C", "1");

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox7_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
