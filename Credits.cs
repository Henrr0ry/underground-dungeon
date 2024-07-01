using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Underground_Dungeon
{
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }
        string playerName = "player";

        private void Credits_Load(object sender, EventArgs e)
        {
            AudioEnd.URL = System.Environment.CurrentDirectory + @"\Sounds\Soundtrack2.wav";
            AudioEnd.settings.volume = MainSetting.Default.MusicVol;
            AudioEnd.Ctlcontrols.play();
            //FULLSCREEN
            if (MainSetting.Default.FullScreen == true)
                this.FormBorderStyle = FormBorderStyle.None;
            else
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Maximized;
            //CREDITS
            playerName = "player";
            if (MainSetting.Default.SavingUser == 1 &&  UserSaveSlot.Default.UserName1 != "")
                playerName = UserSaveSlot.Default.UserName1;
            if (MainSetting.Default.SavingUser == 2 && UserSaveSlot.Default.UserName2 != "")
                playerName = UserSaveSlot.Default.UserName2;
            if (MainSetting.Default.SavingUser == 3 && UserSaveSlot.Default.UserName3 != "")
                playerName = UserSaveSlot.Default.UserName3;
            
            label1.Text = "You do it, you won " + Convert.ToString(playerName);
            panel1.Left = (this.Width / 2) - (panel1.Width / 2);
            panel1.Top = this.Height;
            CreditsTimer.Start();
            Cursor.Hide();
        }

        private void CreditsTimer_Tick(object sender, EventArgs e)
        {
            panel1.Top -= 1;
            if (panel1.Top <= -panel1.Height)
            { 
                this.Close();
                Cursor.Show();
            }
        }

        private void Credits_Click(object sender, EventArgs e)
        {
            Cursor.Show();
            buttonSkip.Top = this.Height - 100;
            buttonSkip.Left = this.Width - 200;
            buttonSkip.Visible = true;
            buttonSkip.Enabled = true;
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            AudioEnd.Ctlcontrols.stop();
            this.Close();
        }

    }
}
