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
    public partial class LevelMenu : Form
    {
        public LevelMenu()
        {
            InitializeComponent();
        }
        int NowLevel;
        bool playTower = false;
        private void LevelMenu_Load(object sender, EventArgs e)
        {
            //FULLSCREEN LOAD
            if (MainSetting.Default.FullScreen == true)
                this.FormBorderStyle = FormBorderStyle.None;
            else
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Maximized;


            //LEVEL LOAD
            LevelUpdateTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Level1 level1 = new Level1();
            level1.ShowDialog();
            if (MainSetting.Default.GoToRespawn == true)
                RespawnTimer.Start();
            SaveIcon.Visible = true;
            SaveAnimationTimer.Start();
            LevelUpdateTimer.Start();
            playTower = false;
        }

        //
        //ANIMACE BUTTON
        //

        Image pole1 = Properties.Resources.button3;
        Image pole2 = Properties.Resources.button4;
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = pole2;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = pole1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Level2 lv2 = new Level2();
            lv2.ShowDialog();
            if (MainSetting.Default.GoToRespawn == true)
                RespawnTimer.Start();
            SaveIcon.Visible = true;
            SaveAnimationTimer.Start();
            LevelUpdateTimer.Start();
            playTower = false;
        }

        private void RespawnTimer_Tick(object sender, EventArgs e)
        {
            RespawnTimer.Stop();
            if (MainSetting.Default.GoToRespawn == true)
            {
                if (playTower == true)
                {
                    Level18 level18 = new Level18();
                    level18.ShowDialog();
                    if (MainSetting.Default.GoToRespawn == true)
                        RespawnTimer.Start();
                    SaveIcon.Visible = true;
                    SaveAnimationTimer.Start();
                    LevelUpdateTimer.Start();
                }
                else
                {
                    MainSetting.Default.GoToRespawn = false;
                    MainSetting.Default.Save();
                    if (NowLevel == 1)
                    {
                        Level1 level1 = new Level1();
                        level1.ShowDialog();
                        if (MainSetting.Default.GoToRespawn == true)
                            RespawnTimer.Start();
                        SaveIcon.Visible = true;
                        SaveAnimationTimer.Start();
                        LevelUpdateTimer.Start();
                    }
                    if (NowLevel == 2)
                    {
                        Level2 level2 = new Level2();
                        level2.ShowDialog();
                        if (MainSetting.Default.GoToRespawn == true)
                            RespawnTimer.Start();
                        SaveIcon.Visible = true;
                        SaveAnimationTimer.Start();
                        LevelUpdateTimer.Start();
                    }
                    if (NowLevel == 3)
                    {
                        Level3 level3 = new Level3();
                        level3.ShowDialog();
                        if (MainSetting.Default.GoToRespawn == true)
                            RespawnTimer.Start();
                        SaveIcon.Visible = true;
                        SaveAnimationTimer.Start();
                        LevelUpdateTimer.Start();
                    }
                    if (NowLevel == 4)
                    {
                        Level4 level4 = new Level4();
                        level4.ShowDialog();
                        if (MainSetting.Default.GoToRespawn == true)
                            RespawnTimer.Start();
                        SaveIcon.Visible = true;
                        SaveAnimationTimer.Start();
                        LevelUpdateTimer.Start();
                    }
                    if (NowLevel == 5)
                    {
                        Level5 level5 = new Level5();
                        level5.ShowDialog();
                        if (MainSetting.Default.GoToRespawn == true)
                            RespawnTimer.Start();
                        SaveIcon.Visible = true;
                        SaveAnimationTimer.Start();
                        LevelUpdateTimer.Start();
                    }
                    if (NowLevel == 6)
                    {
                        Level6 level6 = new Level6();
                        level6.ShowDialog();
                        if (MainSetting.Default.GoToRespawn == true)
                            RespawnTimer.Start();
                        SaveIcon.Visible = true;
                        SaveAnimationTimer.Start();
                        LevelUpdateTimer.Start();
                    }
                    if (NowLevel == 7)
                    {
                        Level7 level7 = new Level7();
                        level7.ShowDialog();
                        if (MainSetting.Default.GoToRespawn == true)
                            RespawnTimer.Start();
                        SaveIcon.Visible = true;
                        SaveAnimationTimer.Start();
                        LevelUpdateTimer.Start();
                    }
                    if (NowLevel == 8)
                    {
                        Level8 level8 = new Level8();
                        level8.ShowDialog();
                        if (MainSetting.Default.GoToRespawn == true)
                            RespawnTimer.Start();
                        SaveIcon.Visible = true;
                        SaveAnimationTimer.Start();
                        LevelUpdateTimer.Start();
                    }
                    if (NowLevel == 9)
                    {
                        Level9 level9 = new Level9();
                        level9.ShowDialog();
                        if (MainSetting.Default.GoToRespawn == true)
                            RespawnTimer.Start();
                        SaveIcon.Visible = true;
                        SaveAnimationTimer.Start();
                        LevelUpdateTimer.Start();
                    }
                    if (NowLevel == 10)
                    {
                        Level10 level10 = new Level10();
                        level10.ShowDialog();
                        if (MainSetting.Default.GoToRespawn == true)
                            RespawnTimer.Start();
                        SaveIcon.Visible = true;
                        SaveAnimationTimer.Start();
                        LevelUpdateTimer.Start();
                    }
                    if (NowLevel == 11)
                    {
                        Level11 level11 = new Level11();
                        level11.ShowDialog();
                        if (MainSetting.Default.GoToRespawn == true)
                            RespawnTimer.Start();
                        SaveIcon.Visible = true;
                        SaveAnimationTimer.Start();
                        LevelUpdateTimer.Start();
                    }
                    if (NowLevel == 12)
                    {
                        Level12 level12 = new Level12();
                        level12.ShowDialog();
                        if (MainSetting.Default.GoToRespawn == true)
                            RespawnTimer.Start();
                        SaveIcon.Visible = true;
                        SaveAnimationTimer.Start();
                        LevelUpdateTimer.Start();
                    }
                    if (NowLevel == 13)
                    {
                        Level13 level13 = new Level13();
                        level13.ShowDialog();
                        if (MainSetting.Default.GoToRespawn == true)
                            RespawnTimer.Start();
                        SaveIcon.Visible = true;
                        SaveAnimationTimer.Start();
                        LevelUpdateTimer.Start();
                    }
                    if (NowLevel == 14)
                    {
                        Level14 level14 = new Level14();
                        level14.ShowDialog();
                        if (MainSetting.Default.GoToRespawn == true)
                            RespawnTimer.Start();
                        SaveIcon.Visible = true;
                        SaveAnimationTimer.Start();
                        LevelUpdateTimer.Start();
                    }
                    if (NowLevel == 15)
                    {
                        Level15 level15 = new Level15();
                        level15.ShowDialog();
                        if (MainSetting.Default.GoToRespawn == true)
                            RespawnTimer.Start();
                        SaveIcon.Visible = true;
                        SaveAnimationTimer.Start();
                        LevelUpdateTimer.Start();
                    }
                    if (NowLevel == 16)
                    {
                        Level16 level16 = new Level16();
                        level16.ShowDialog();
                        if (MainSetting.Default.GoToRespawn == true)
                            RespawnTimer.Start();
                        SaveIcon.Visible = true;
                        SaveAnimationTimer.Start();
                        LevelUpdateTimer.Start();
                    }
                    if (NowLevel == 17)
                    {
                        Level17 level17 = new Level17();
                        level17.ShowDialog();
                        if (MainSetting.Default.GoToRespawn == true)
                            RespawnTimer.Start();
                        SaveIcon.Visible = true;
                        SaveAnimationTimer.Start();
                        LevelUpdateTimer.Start();
                    }
                }
            }
        }
            private void SaveAnimationTimer_Tick(object sender, EventArgs e)
            {
                SaveIcon.Visible = false;
                SaveAnimationTimer.Stop();
            }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LevelUpdateTimer_Tick(object sender, EventArgs e)
        {
            LevelUpdateTimer.Stop();
            if (MainSetting.Default.SavingUser == 0)
            {
                MessageBox.Show("!                     -- ERROR --                     !" + Environment.NewLine + "-- You must choose your save user --" + Environment.NewLine + "--   go to settings and change it   --", "--ERROR--", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();    
            }
            if (MainSetting.Default.SavingUser == 1)
            {
                foreach (Control x in this.Controls)
                {
                    NowLevel = UserSaveSlot.Default.Level1;
                    if (x is Button && x.TabIndex == NowLevel)
                    {
                        x.Enabled = true;
                        x.BackgroundImage = Properties.Resources.button3;
                    }
                    if (x is Button && x.TabIndex == NowLevel - 1)
                    {
                        x.Enabled = false;
                        x.BackgroundImage = Properties.Resources.button5;
                    }
                    if (x is Button && x.TabIndex < NowLevel)
                    {
                        x.Enabled = false;
                        x.BackgroundImage = Properties.Resources.button5;
                    }
                }
            }
            if (MainSetting.Default.SavingUser == 2)
            {
                foreach (Control x in this.Controls)
                {
                    NowLevel = UserSaveSlot.Default.Level2;
                    if (x is Button && x.TabIndex == NowLevel)
                    {
                        x.Enabled = true;
                        x.BackgroundImage = Properties.Resources.button3;
                    }
                    if (x is Button && x.TabIndex == NowLevel - 1)
                    {
                        x.Enabled = false;
                        x.BackgroundImage = Properties.Resources.button5;
                    }
                    if (x is Button && x.TabIndex < NowLevel)
                    {
                        x.Enabled = false;
                        x.BackgroundImage = Properties.Resources.button5;
                    }
                }
            }
            if (MainSetting.Default.SavingUser == 3)
            {
                foreach (Control x in this.Controls)
                {
                    NowLevel = UserSaveSlot.Default.Level3;
                    if (x is Button && x.TabIndex == NowLevel)
                    {
                        x.Enabled = true;
                        x.BackgroundImage = Properties.Resources.button3;
                    }
                    if (x is Button && x.TabIndex == NowLevel - 1)
                    {
                        x.Enabled = false;
                        x.BackgroundImage = Properties.Resources.button5;
                    }
                    if (x is Button && x.TabIndex < NowLevel)
                    {
                        x.Enabled = false;
                        x.BackgroundImage = Properties.Resources.button5;
                    }
                }
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Level0 lvl0 = new Level0();
            lvl0.ShowDialog();
            if (MainSetting.Default.GoToRespawn == true)
                RespawnTimer.Start();
            SaveIcon.Visible = true;
            SaveAnimationTimer.Start();
            LevelUpdateTimer.Start();
            playTower = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Level3 lvl3 = new Level3();
            lvl3.ShowDialog();
            if (MainSetting.Default.GoToRespawn == true)
                RespawnTimer.Start();
            SaveIcon.Visible = true;
            SaveAnimationTimer.Start();
            LevelUpdateTimer.Start();
            playTower = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Level4 lvl4 = new Level4();
            lvl4.ShowDialog();
            if (MainSetting.Default.GoToRespawn == true)
                RespawnTimer.Start();
            SaveIcon.Visible = true;
            SaveAnimationTimer.Start();
            LevelUpdateTimer.Start();
            playTower = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Level5 lvl5 = new Level5();
            lvl5.ShowDialog();
            if (MainSetting.Default.GoToRespawn == true)
                RespawnTimer.Start();
            SaveIcon.Visible = true;
            SaveAnimationTimer.Start();
            LevelUpdateTimer.Start(); 
            playTower = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Level6 lvl6 = new Level6();
            lvl6.ShowDialog();
            if (MainSetting.Default.GoToRespawn == true)
                RespawnTimer.Start();
            SaveIcon.Visible = true;
            SaveAnimationTimer.Start();
            LevelUpdateTimer.Start();
            playTower = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Level7 lvl7 = new Level7();
            lvl7.ShowDialog();
            if (MainSetting.Default.GoToRespawn == true)
                RespawnTimer.Start();
            SaveIcon.Visible = true;
            SaveAnimationTimer.Start();
            LevelUpdateTimer.Start();
            playTower = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Level8 lvl8 = new Level8();
            lvl8.ShowDialog();
            if (MainSetting.Default.GoToRespawn == true)
                RespawnTimer.Start();
            SaveIcon.Visible = true;
            SaveAnimationTimer.Start();
            LevelUpdateTimer.Start();
            playTower = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Level9 lvl9 = new Level9();
            lvl9.ShowDialog();
            if (MainSetting.Default.GoToRespawn == true)
                RespawnTimer.Start();
            SaveIcon.Visible = true;
            SaveAnimationTimer.Start();
            LevelUpdateTimer.Start();
            playTower = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Level10 lvl10 = new Level10();
            lvl10.ShowDialog();
            if (MainSetting.Default.GoToRespawn == true)
                RespawnTimer.Start();
            SaveIcon.Visible = true;
            SaveAnimationTimer.Start();
            LevelUpdateTimer.Start();
            playTower = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Level11 lvl11 = new Level11();
            lvl11.ShowDialog();
            if (MainSetting.Default.GoToRespawn == true)
                RespawnTimer.Start();
            SaveIcon.Visible = true;
            SaveAnimationTimer.Start();
            LevelUpdateTimer.Start();
            playTower = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Level12 lvl12 = new Level12();
            lvl12.ShowDialog();
            if (MainSetting.Default.GoToRespawn == true)
                RespawnTimer.Start();
            SaveIcon.Visible = true;
            SaveAnimationTimer.Start();
            LevelUpdateTimer.Start();
            playTower = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Level13 lvl13 = new Level13();
            lvl13.ShowDialog();
            if (MainSetting.Default.GoToRespawn == true)
                RespawnTimer.Start();
            SaveIcon.Visible = true;
            SaveAnimationTimer.Start();
            LevelUpdateTimer.Start();
            playTower = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Level14 lvl14 = new Level14();
            lvl14.ShowDialog();
            if (MainSetting.Default.GoToRespawn == true)
                if (MainSetting.Default.GoToRespawn == true)
                    RespawnTimer.Start();
            SaveIcon.Visible = true;
            SaveAnimationTimer.Start();
            LevelUpdateTimer.Start();
            playTower = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Level15 lvl15 = new Level15();
            lvl15.ShowDialog();
            if (MainSetting.Default.GoToRespawn == true)
                RespawnTimer.Start();
            SaveIcon.Visible = true;
            SaveAnimationTimer.Start();
            LevelUpdateTimer.Start();
            playTower = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Level16 lvl16 = new Level16();
            lvl16.ShowDialog();
            if (MainSetting.Default.GoToRespawn == true)
                RespawnTimer.Start();
            SaveIcon.Visible = true;
            SaveAnimationTimer.Start();
            LevelUpdateTimer.Start();
            playTower = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Level17 lvl17 = new Level17();
            lvl17.ShowDialog();
            if (MainSetting.Default.GoToRespawn == true)
                RespawnTimer.Start();
            SaveIcon.Visible = true;
            SaveAnimationTimer.Start();
            LevelUpdateTimer.Start();
            playTower = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            playTower = true;
            Level18 lvl18 = new Level18();
            lvl18.ShowDialog();
            if (MainSetting.Default.GoToRespawn == true)
                RespawnTimer.Start();
            SaveIcon.Visible = true;
            SaveAnimationTimer.Start();
            LevelUpdateTimer.Start();
        }
    }
}
