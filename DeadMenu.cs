using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Underground_Dungeon
{
    public partial class DeadMenu : Form
    {
        public DeadMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameExit gaex = new GameExit();
            gaex.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainSetting.Default.GoToRespawn = true;
            MainSetting.Default.Save();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainSetting.Default.GoToMenu = true;
            MainSetting.Default.GoToRespawn = false;
            MainSetting.Default.Save();
            this.Close();
        }
        //BUTTON ANIMACE

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.button1;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.button2;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackgroundImage = Properties.Resources.button2;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackgroundImage = Properties.Resources.button1;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.button2;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.button1;
        }
    }
}
