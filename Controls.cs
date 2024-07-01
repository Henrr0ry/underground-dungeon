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
    public partial class Controls : Form
    {
        public Controls()
        {
            InitializeComponent();
        }
        int openList;

        private void Controls_Load(object sender, EventArgs e)
        {
            if (MainSetting.Default.FullScreen == true)
                this.FormBorderStyle = FormBorderStyle.None;
            else
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Maximized;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void poleTutorialBook_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;
            if (openList == 0)
            kp.DrawImage(Properties.Resources.List0, 500, 0, 500, 600);
            if (openList == 1)
            { 
                kp.DrawImage(Properties.Resources.List1, 0, 0, 500, 600);
                kp.DrawImage(Properties.Resources.List2, 500, 0, 500, 600);
            }
            if (openList == 2)
            {
                kp.DrawImage(Properties.Resources.List3, 0, 0, 500, 600);
                kp.DrawImage(Properties.Resources.List4, 500, 0, 500, 600);
            }
            if (openList == 3)
            {
                kp.DrawImage(Properties.Resources.List5, 0, 0, 500, 600);
                kp.DrawImage(Properties.Resources.List6, 500, 0, 500, 600);
            }
            if (openList == 4)
            {
                kp.DrawImage(Properties.Resources.List7, 0, 0, 500, 600);
            }
        }

        private void poleLeft_Click(object sender, EventArgs e)
        {
            openList -= 1;
            if (openList < 0)
                openList = 0;
            poleTutorialBook.Refresh();
        }

        private void poleRight_Click(object sender, EventArgs e)
        {
            openList += 1;
            if (openList > 4)
                openList = 4;
            poleTutorialBook.Refresh();
        }
        //
        //ANIMACE BUTTON
        //
        Image pole1 = Properties.Resources.button1;
        Image pole2 = Properties.Resources.button2;
        private void poleLeft_MouseEnter(object sender, EventArgs e)
        {
            poleLeft.BackgroundImage = pole2;
        }

        private void poleLeft_MouseLeave(object sender, EventArgs e)
        {
            poleLeft.BackgroundImage = pole1;
        }

        private void poleRight_MouseEnter(object sender, EventArgs e)
        {
            poleRight.BackgroundImage = pole2;
        }

        private void poleRight_MouseLeave(object sender, EventArgs e)
        {
            poleRight.BackgroundImage = pole1;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = pole2;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = pole1;
        }

    }
}
