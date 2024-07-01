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
    public partial class StopMenu : Form
    {
        public StopMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controls helpB = new Controls();
            helpB.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            LogoGameMenu.Focus();
            GameExit gexit = new GameExit();
            gexit.ShowDialog();
            LogoGameMenu.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LogoGameMenu.Focus();
            Cursor.Show();
            MainSetting.Default.GoToMenu = true;
            MainSetting.Default.GoToRespawn = false;
            MainSetting.Default.Save();
            this.Close();
        }

        private void StopMenu_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }
        //
        //ANIMATION BUTTON
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

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackgroundImage = pole2;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackgroundImage = pole1;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackgroundImage = pole2;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackgroundImage = pole1;
        }
    }
}
