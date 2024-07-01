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
    public partial class GameSetting : Form
    {
        public GameSetting()
        {
            InitializeComponent();
        }
        string WeapondName1 = "Hand", WeapondName2 = "Hand", WeapondName3 = "Hand";
        
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureUser1_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;
            if (SexBox1.Text == "Male")
                kp.DrawImage(Properties.Resources.player, 25, 25);
            if (SexBox1.Text == "Female")
                kp.DrawImage(Properties.Resources.playerWomen, 25, 25);
        }

        private void PictureUser2_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;
            if (SexBox2.Text == "Male")
                kp.DrawImage(Properties.Resources.player, 25, 25);
            if (SexBox2.Text == "Female")
                kp.DrawImage(Properties.Resources.playerWomen, 25, 25);
        }
        private void PictureUser3_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;
            if (SexBox3.Text == "Male")
                kp.DrawImage(Properties.Resources.player, 25, 25);
            if (SexBox3.Text == "Female")
                kp.DrawImage(Properties.Resources.playerWomen, 25, 25);
        }

        private void SexBox_SelectedValueChanged(object sender, EventArgs e)
        {
            PictureUser1.Refresh();
            PictureUser2.Refresh();
            PictureUser3.Refresh();
        }

        private void GameSetting_Load(object sender, EventArgs e)
        {
            trackBarMusic.Value = MainSetting.Default.MusicVol;
            TrackBarSounds.Value = MainSetting.Default.SoundsVol;
            if (MainSetting.Default.FullScreen == true)
                buttonFullscreen.BackgroundImage = Properties.Resources.buttonAccept;
            else
                buttonFullscreen.BackgroundImage = Properties.Resources.buttonDeny;
            if (MainSetting.Default.SavingUser == 1)
                buttonUser1.BackgroundImage = Properties.Resources.buttonAccept;
            if (MainSetting.Default.SavingUser == 2)
                buttonUser2.BackgroundImage = Properties.Resources.buttonAccept;
            if (MainSetting.Default.SavingUser == 3)
                buttonUser3.BackgroundImage = Properties.Resources.buttonAccept;
            // USER 1
            if (UserSaveSlot.Default.Attack1 == 40)
                WeapondName1 = "Sword lvl 1";

            if (UserSaveSlot.Default.Attack1 == 60)
                WeapondName1 = "Sword lvl 2";

            if (UserSaveSlot.Default.Attack1 == 80)
                WeapondName1 = "Sword lvl 3";

            if (UserSaveSlot.Default.UserName1 == "")
                Description1.Text = null;
            else
                Description1.Text = "Lives: " + UserSaveSlot.Default.Live1 + "  -  Coins: " + UserSaveSlot.Default.Coins1 + Environment.NewLine + "Armor: " + UserSaveSlot.Default.Armor1 
                    + "  -  Experience: " + UserSaveSlot.Default.XP1 + "  -  Level: " + UserSaveSlot.Default.Level1 + Environment.NewLine + "Weapond: " + WeapondName1
                    + "  -  Magic: "+ UserSaveSlot.Default.MagicBall1  + Environment.NewLine +"Armor: " + UserSaveSlot.Default.NameArmor1 + "  -  Potion:" + UserSaveSlot.Default.Potion1;
            NameBox1.Text = UserSaveSlot.Default.UserName1;
            SexBox1.Text = UserSaveSlot.Default.Sex1;
            // USER 2
            if (UserSaveSlot.Default.Attack2 == 40)
                WeapondName2 = "Sword lvl 1";

            if (UserSaveSlot.Default.Attack2 == 60)
                WeapondName2 = "Sword lvl 2";

            if (UserSaveSlot.Default.Attack2 == 80)
                WeapondName2 = "Sword lvl 3";

            if (UserSaveSlot.Default.UserName2 == "")
                Description2.Text = null;
            else
                Description2.Text = "Lives: " + UserSaveSlot.Default.Live2 + "  -  Coins: " + UserSaveSlot.Default.Coins2 + Environment.NewLine + "Armor: " + UserSaveSlot.Default.Armor2
                    + "  -  Experience: " + UserSaveSlot.Default.XP2 + "  -  Level: " + UserSaveSlot.Default.Level2 + Environment.NewLine + "Weapond: "+ WeapondName2
                    + "  -  Magic: " + UserSaveSlot.Default.MagicBall2 + Environment.NewLine + "Armor: " + UserSaveSlot.Default.NameArmor2 + "  -  Potion:" + UserSaveSlot.Default.Potion2;
            NameBox2.Text = UserSaveSlot.Default.UserName2;
            SexBox2.Text = UserSaveSlot.Default.Sex2;
            // USER 3
            if (UserSaveSlot.Default.Attack3 == 40)
                WeapondName3 = "Sword lvl 1";

            if (UserSaveSlot.Default.Attack3 == 60)
                WeapondName3 = "Sword lvl 2";

            if (UserSaveSlot.Default.Attack3 == 80)
                WeapondName3 = "Sword lvl 3";

            if (UserSaveSlot.Default.UserName3 == "")
                Description3.Text = null;
            else
                Description3.Text = "Lives: " + UserSaveSlot.Default.Live3 + "  -  Coins: " + UserSaveSlot.Default.Coins3 + Environment.NewLine + "Armor: " + UserSaveSlot.Default.Armor3
                    + "  -  Experience: " + UserSaveSlot.Default.XP3 + "  -  Level: " + UserSaveSlot.Default.Level3 + Environment.NewLine + "Weapond: " + WeapondName3
                    + "  -  Magic: " + UserSaveSlot.Default.MagicBall3 + Environment.NewLine + "Armor: " + UserSaveSlot.Default.NameArmor3 + "  -  Potion:" + UserSaveSlot.Default.Potion3;
            NameBox3.Text = UserSaveSlot.Default.UserName3;
            SexBox3.Text = UserSaveSlot.Default.Sex3;
        }
        private void buttonSave1_Click(object sender, EventArgs e)
        {
            SaveAnimationTimer.Start();
            SaveIcon.Visible = true;
            UserSaveSlot.Default.UserName1 = NameBox1.Text;
            UserSaveSlot.Default.Sex1 = SexBox1.Text;
            UserSaveSlot.Default.Save();
            Description1.Text = "Lives: " + UserSaveSlot.Default.Live1 + "  -  Coins: " + UserSaveSlot.Default.Coins1 + Environment.NewLine + "Armor: " + UserSaveSlot.Default.Armor1
                + "  -  Experience: " + UserSaveSlot.Default.XP1 + "  -  Level: " + UserSaveSlot.Default.Level1 + Environment.NewLine + "Weapond: " + WeapondName1
                + "  -  Magic: " + UserSaveSlot.Default.MagicBall1 + Environment.NewLine + "Armor: " + UserSaveSlot.Default.NameArmor1 + "  -  Potion:" + UserSaveSlot.Default.Potion1;
        }

        private void buttonDetele1_Click(object sender, EventArgs e)
        {
            //USER 1
            NameBox1.Text = null;
            SexBox1.Text = null;
            Description1.Text = null;
            SaveIcon.Visible = true;
            SaveAnimationTimer.Start();
            UserSaveSlot.Default.Live1 = 100;
            UserSaveSlot.Default.Armor1 = 0;
            UserSaveSlot.Default.Attack1 = 0;
            UserSaveSlot.Default.Coins1 = 0;
            UserSaveSlot.Default.XP1 = 0;
            UserSaveSlot.Default.UserName1 = "";
            UserSaveSlot.Default.Sex1 = null;
            UserSaveSlot.Default.Potion1 = null;
            UserSaveSlot.Default.NameArmor1 = null;
            UserSaveSlot.Default.MagicBall1 = null;
            UserSaveSlot.Default.Level1 = 1;
            UserSaveSlot.Default.Save();
            MainSetting.Default.SavingUser = 0;
            MainSetting.Default.Save();
            buttonUser1.BackgroundImage = Properties.Resources.buttonDeny;
        }

        private void SaveAnimationTimer_Tick(object sender, EventArgs e)
        {
            SaveIcon.Visible = false;
            SaveAnimationTimer.Stop();
        }


        private void buttonFullscreen_Click(object sender, EventArgs e)
        {
            if (MainSetting.Default.FullScreen == true)
                MainSetting.Default.FullScreen = false;
            else
                MainSetting.Default.FullScreen = true;
            MainSetting.Default.Save();
            Application.Restart();
        }

        private void buttonUser1_Click(object sender, EventArgs e)
        {
            MainSetting.Default.SavingUser = 1;
            buttonUser1.BackgroundImage = Properties.Resources.buttonAccept;
            buttonUser2.BackgroundImage = Properties.Resources.buttonDeny;
            buttonUser3.BackgroundImage = Properties.Resources.buttonDeny;
            MainSetting.Default.Save();
        }

        private void buttonUser2_Click(object sender, EventArgs e)
        {
            MainSetting.Default.SavingUser = 2;
            buttonUser2.BackgroundImage = Properties.Resources.buttonAccept;
            buttonUser1.BackgroundImage = Properties.Resources.buttonDeny;
            buttonUser3.BackgroundImage = Properties.Resources.buttonDeny;
            MainSetting.Default.Save();
        }

        private void buttonUser3_Click(object sender, EventArgs e)
        {
            MainSetting.Default.SavingUser = 3;
            buttonUser3.BackgroundImage = Properties.Resources.buttonAccept;
            buttonUser1.BackgroundImage = Properties.Resources.buttonDeny;
            buttonUser2.BackgroundImage = Properties.Resources.buttonDeny;
            MainSetting.Default.Save();
        }


        private void buttonSave2_Click(object sender, EventArgs e)
        {
            SaveAnimationTimer.Start();
            SaveIcon.Visible = true;
            UserSaveSlot.Default.UserName2 = NameBox2.Text;
            UserSaveSlot.Default.Sex2 = SexBox2.Text;
            UserSaveSlot.Default.Save();
            Description2.Text = "Lives: " + UserSaveSlot.Default.Live2 + "  -  Coins: " + UserSaveSlot.Default.Coins2 + Environment.NewLine + "Armor: " + UserSaveSlot.Default.Armor2
                + "  -  Experience: " + UserSaveSlot.Default.XP2 + "  -  Level: " + UserSaveSlot.Default.Level2 + Environment.NewLine + "Weapond: "+ WeapondName1
                + "  -  Magic: " + UserSaveSlot.Default.MagicBall2 + Environment.NewLine + "Armor: " + UserSaveSlot.Default.NameArmor2 + "  -  Potion:" + UserSaveSlot.Default.Potion2;
        }

        private void buttonDetele2_Click(object sender, EventArgs e)
        {
            //USER 2
            NameBox2.Text = null;
            SexBox2.Text = null;
            Description2.Text = null;
            SaveIcon.Visible = true;
            SaveAnimationTimer.Start();
            UserSaveSlot.Default.Live2 = 100;
            UserSaveSlot.Default.Armor2 = 0;
            UserSaveSlot.Default.Attack2 = 0;
            UserSaveSlot.Default.Coins2 = 0;
            UserSaveSlot.Default.XP2 = 0;
            UserSaveSlot.Default.UserName2 = "";
            UserSaveSlot.Default.Sex2 = null;
            UserSaveSlot.Default.Potion2 = null;
            UserSaveSlot.Default.NameArmor2 = null;
            UserSaveSlot.Default.MagicBall2 = null;
            UserSaveSlot.Default.Level2 = 1;
            UserSaveSlot.Default.Save();
            MainSetting.Default.SavingUser = 0;
            MainSetting.Default.Save();
            buttonUser2.BackgroundImage = Properties.Resources.buttonDeny;
        }

        private void buttonSave3_Click(object sender, EventArgs e)
        {
            SaveAnimationTimer.Start();
            SaveIcon.Visible = true;
            UserSaveSlot.Default.UserName3 = NameBox3.Text;
            UserSaveSlot.Default.Sex3 = SexBox3.Text;
            UserSaveSlot.Default.Save();
            Description3.Text = "Lives: " + UserSaveSlot.Default.Live3 + "  -  Coins: " + UserSaveSlot.Default.Coins3 + Environment.NewLine + "Armor: " + UserSaveSlot.Default.Armor3
                + "  -  Experience: " + UserSaveSlot.Default.XP3 + "  -  Level: " + UserSaveSlot.Default.Level3 + Environment.NewLine + "Weapond: " + WeapondName3
                + "  -  Magic: " + UserSaveSlot.Default.MagicBall3 + Environment.NewLine + "Armor: " + UserSaveSlot.Default.NameArmor3 + "  -  Potion:" + UserSaveSlot.Default.Potion3;
        }

        private void buttonDetele3_Click(object sender, EventArgs e)
        {
            //USER 3
            NameBox3.Text = null;
            SexBox3.Text = null;
            Description3.Text = null;
            SaveIcon.Visible = true;
            SaveAnimationTimer.Start();
            UserSaveSlot.Default.Live3 = 100;
            UserSaveSlot.Default.Armor3 = 0;
            UserSaveSlot.Default.Attack3 = 0;
            UserSaveSlot.Default.Coins3 = 0;
            UserSaveSlot.Default.XP3 = 0;
            UserSaveSlot.Default.UserName3 = "";
            UserSaveSlot.Default.Sex3 = null;
            UserSaveSlot.Default.Potion3 = null;
            UserSaveSlot.Default.NameArmor3 = null;
            UserSaveSlot.Default.MagicBall3 = null;
            UserSaveSlot.Default.Level3 = 1;
            UserSaveSlot.Default.Save();
            MainSetting.Default.SavingUser = 0;
            MainSetting.Default.Save();
            buttonUser3.BackgroundImage = Properties.Resources.buttonDeny;
        }
        //
        //ANIMATION BUTTON
        //
        private void buttonBack_MouseEnter(object sender, EventArgs e)
        {
            buttonBack.BackgroundImage = Properties.Resources.button2;
        }
        private void buttonBack_MouseLeave(object sender, EventArgs e)
        {
            buttonBack.BackgroundImage = Properties.Resources.button1;
        }
        private void buttonSave1_MouseEnter(object sender, EventArgs e)
        {
            buttonSave1.BackgroundImage = Properties.Resources.button2;
        }


        private void buttonSave1_MouseLeave(object sender, EventArgs e)
        {
            buttonSave1.BackgroundImage = Properties.Resources.button1;
        }

        private void buttonSave2_MouseEnter(object sender, EventArgs e)
        {
            buttonSave2.BackgroundImage = Properties.Resources.button2;
        }

        private void buttonSave2_MouseLeave(object sender, EventArgs e)
        {
            buttonSave2.BackgroundImage = Properties.Resources.button1;
        }

        private void buttonDetele2_MouseEnter(object sender, EventArgs e)
        {
            buttonDetele2.BackgroundImage = Properties.Resources.button2;
        }

        private void buttonDetele2_MouseLeave(object sender, EventArgs e)
        {
            buttonDetele2.BackgroundImage = Properties.Resources.button1;
        }

        private void buttonSave3_MouseEnter(object sender, EventArgs e)
        {
            buttonSave3.BackgroundImage = Properties.Resources.button2;
        }

        private void buttonSave3_MouseLeave(object sender, EventArgs e)
        {
            buttonSave3.BackgroundImage = Properties.Resources.button1;
        }

        private void buttonDetele3_MouseEnter(object sender, EventArgs e)
        {
            buttonDetele3.BackgroundImage = Properties.Resources.button2;
        }

        private void buttonDetele3_MouseLeave(object sender, EventArgs e)
        {
            buttonDetele3.BackgroundImage = Properties.Resources.button1;
        }

        private void buttonDetele1_MouseEnter(object sender, EventArgs e)
        {
            buttonDetele1.BackgroundImage = Properties.Resources.button2;
        }


        private void buttonDetele1_MouseLeave(object sender, EventArgs e)
        {
            buttonDetele1.BackgroundImage = Properties.Resources.button1;
        }
        //SOUND AND MUSIC VOLUME
        private void trackBarMusic_Scroll(object sender, EventArgs e)
        {
            MainSetting.Default.MusicVol = trackBarMusic.Value;
            MainSetting.Default.Save();
        }
        private void TrackBarSounds_Scroll(object sender, EventArgs e)
        {
            MainSetting.Default.SoundsVol = TrackBarSounds.Value;
            MainSetting.Default.Save();
        }

    }
}
