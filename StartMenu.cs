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
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AudioSoundtrack.Ctlcontrols.stop();
            LevelMenu lvmenu = new LevelMenu();
            lvmenu.ShowDialog();
        }     

        private void StartMenu_Load(object sender, EventArgs e)
        {
            if (MainSetting.Default.FullScreen == true)    
                this.FormBorderStyle = FormBorderStyle.None;  
            else
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Maximized;

            AudioSoundtrack.URL = System.Environment.CurrentDirectory + @"\Sounds\MenuSoundtrack.wav";
            AudioSoundtrack.settings.volume = MainSetting.Default.MusicVol;
            AudioSoundtrack.Ctlcontrols.play();            
        }       
        private void button3_Click(object sender, EventArgs e)
        {
            Credits cred = new Credits();
            AudioSoundtrack.Ctlcontrols.pause();
            cred.ShowDialog();
            AudioSoundtrack.Ctlcontrols.play();
            pictureBox2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Controls ctrl = new Controls();
            ctrl.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GameExit exit = new GameExit();
            exit.ShowDialog();
        }
        //
        //ANIMACE BUTTON
        //
        Image pole1 = Properties.Resources.button1;
        Image pole2 = Properties.Resources.button2;

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = pole2;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = pole1;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackgroundImage = pole2;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = pole1;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackgroundImage = pole2;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackgroundImage = pole1;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackgroundImage = pole2;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackgroundImage = pole1;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackgroundImage = pole2;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackgroundImage = pole1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameSetting gameset = new GameSetting();
            gameset.ShowDialog();
        }
    }
}
