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
    public partial class Level14 : Form
    {

        //Map and live
        Image Live = Properties.Resources.live;
        Image Protection = Properties.Resources.protection;
        Image Coin = Properties.Resources.coin;
        Image XP = Properties.Resources.expirience;

        public Level14()
        {
            InitializeComponent();
        }

        private void liveimage_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;
            kp.DrawImage(Live, 5, 10, 40, 40);
        }

        private void protectionimage_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;
            kp.DrawImage(Protection, 5, 10, 40, 40);
        }

        private void coinimage_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;
            kp.DrawImage(Coin, 5, 10, 40, 40);

        }

        private void expirienceimage_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;
            kp.DrawImage(XP, 5, 10, 40, 40);

        }
        private void Level1_SizeChanged(object sender, EventArgs e)
        {
            poleinventory.Top = this.Height - 50 - poleinventory.Height;
        }

        //
        //OVLÁDÁNÍ POHYBU
        //

        bool goleft = false;
        bool goright = false;
        bool goup = false;
        bool godown = false;
        bool attack = false;
        int enemyHeal = 200;
        Random náhoda = new Random();
        int playerHeal = 100;
        int expirience;
        public int coins;
        int damage;
        bool TradeNow = true;
        int playerDamage = 10;
        int WeapondDamage = 0;
        bool WeapondInHand = false;
        Image Weapon;
        int playerProtection;
        bool ArmorInHand = false;
        Image PlayerArmor = Properties.Resources.chesplate1;
        bool HavePotion = false;
        bool drinkPotion = false;
        string typePotion;
        string typeMagicBall = null;
        bool magicFly = false;
        bool magicAttack = false;
        int MagicBallWay;
        int PlayerLook = 1;
        int EnemyRatHeal = 50;
        bool DoOne = true;
        bool SexMale = true;
        int magicBallDamage;
        int enemyKingHeal = 500;
        int enemyWither = 300;
        System.Media.SoundPlayer Soundtrack = new System.Media.SoundPlayer(Properties.Resources.Soundtrack1);
        private void Level1_Load(object sender, EventArgs e)
        {
            //FULLSCREEN LOAD
            if (MainSetting.Default.FullScreen == true)
                this.FormBorderStyle = FormBorderStyle.None;
            else
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Maximized;

            Cursor.Hide();
            //LOAD SOUNDS
            AudioAttack.URL = System.Environment.CurrentDirectory + @"\Sounds\Attack.wav";
            AudioHit.URL = System.Environment.CurrentDirectory + @"\Sounds\Hit2.wav";
            AudioKing.URL = System.Environment.CurrentDirectory + @"\Sounds\DamageKing.wav";
            AudioWarrior.URL = System.Environment.CurrentDirectory + @"\Sounds\DamageWarrior.wav";
            AudioRat.URL = System.Environment.CurrentDirectory + @"\Sounds\DamageRat.wav";
            AudioWither.URL = System.Environment.CurrentDirectory + @"\Sounds\DamageWither.wav";
            AudioSoundtrack.URL = System.Environment.CurrentDirectory + @"\Sounds\Soundtrack1.wav";

            AudioAttack.settings.volume = MainSetting.Default.SoundsVol;
            AudioHit.settings.volume = MainSetting.Default.SoundsVol;
            AudioKing.settings.volume = MainSetting.Default.SoundsVol;
            AudioWarrior.settings.volume = MainSetting.Default.SoundsVol;
            AudioRat.settings.volume = MainSetting.Default.SoundsVol;
            AudioWither.settings.volume = MainSetting.Default.SoundsVol;
            AudioSoundtrack.settings.volume = MainSetting.Default.MusicVol;


            //USERS LOAD
            if (MainSetting.Default.SavingUser == 0)
            {
                MessageBox.Show("--ERROR--" + Environment.NewLine + "-Save user must be set-");
                this.Close();
            }
            if (MainSetting.Default.SavingUser == 1)
            {
            playerHeal = UserSaveSlot.Default.Live1;
            playerProtection = UserSaveSlot.Default.Armor1;
                WeapondDamage = UserSaveSlot.Default.Attack1;
                if (UserSaveSlot.Default.Armor1 > 0)
                { 
                    ArmorInHand = true;
                    if (UserSaveSlot.Default.NameArmor1 == "Chestplate lvl 1")
                    {
                        slotArmor.Image = Properties.Resources.Chestplate1slot;
                        slotArmorName.Text = "Chestplate lvl 1";
                    }
                    if (UserSaveSlot.Default.NameArmor1 == "Chestplate lvl 2")
                    {
                        slotArmor.Image = Properties.Resources.Chestplate2slot;
                        slotArmorName.Text = "Chestplate lvl 2";
                    }
                    if (UserSaveSlot.Default.NameArmor1 == "Chestplate lvl 3")
                    {
                        slotArmor.Image = Properties.Resources.Chestplate3slot;
                        slotArmorName.Text = "Chestplate lvl 3";
                    }
                }
                expirience = UserSaveSlot.Default.XP1;
            coins = UserSaveSlot.Default.Coins1;

            zobrazeniHeal.Text = Convert.ToString(playerHeal);
            zobrazeniArmor.Text = Convert.ToString(playerProtection);
            zobrazeniCoin.Text = Convert.ToString(coins);
                if (UserSaveSlot.Default.Attack1 == 40)
                {
                    slotWeapond.Image = Properties.Resources.sword1Slot;
                    slotWeapondName.Text = "Sword lvl 1";
                    Weapon = Properties.Resources.sword;
                    WeapondInHand = true;
                }
                if (UserSaveSlot.Default.Potion1 == "Heal potion")
                {
                    slotPotion.Image = Properties.Resources.potionHeal1Slot;
                    slotPotionName.Text = "Heal potion";
                    typePotion = "heal1";
                    HavePotion = true;
                }
                if (UserSaveSlot.Default.Potion1 == "Xp potion")
                {
                    slotPotion.Image = Properties.Resources.potionXPslot;
                    slotPotionName.Text = "Xp potion";
                    typePotion = "Xp1";
                    HavePotion = true;
                }
                if (UserSaveSlot.Default.Potion1 == "potion Boost")
                {
                    slotPotion.Image = Properties.Resources.potionBoost1Slot;
                    slotPotionName.Text = "potion Boost";
                    typePotion = "boost";
                    HavePotion = true;
                }
                if (UserSaveSlot.Default.MagicBall1 == "fireball")
                {
                    slotMagic.Image = Properties.Resources.fireball1Slot;
                    slotMagicName.Text = "Fireball";
                    typeMagicBall = "fireball";
                }
                if (UserSaveSlot.Default.Attack1 == 60)
                {
                    slotWeapond.Image = Properties.Resources.sword2Slot;
                    slotWeapondName.Text = "Sword lvl 2";
                    Weapon = Properties.Resources.sword;
                    WeapondInHand = true;
                }
                if (UserSaveSlot.Default.Attack1 == 80)
                {
                    slotWeapond.Image = Properties.Resources.sword3Slot;
                    slotWeapondName.Text = "Sword lvl 3";
                    Weapon = Properties.Resources.sword;
                    WeapondInHand = true;
                }
                if (UserSaveSlot.Default.Sex1 == "Female")
                    SexMale = false;
                if (UserSaveSlot.Default.MagicBall1 == "magicshoot")
                {
                    slotMagic.Image = Properties.Resources.MagicShootSlot;
                    slotMagicName.Text = "Magic shoot";
                    typeMagicBall = "magicshoot";
                }
                if (UserSaveSlot.Default.MagicBall1 == "energyball")
                {
                    slotMagic.Image = Properties.Resources.energyElipse1Slot;
                    slotMagicName.Text = "Energy Ball";
                    typeMagicBall = "energyball";
                }
            }
            // USER 2 LOAD
            if (MainSetting.Default.SavingUser == 2)
            {
                playerHeal = UserSaveSlot.Default.Live2;
                playerProtection = UserSaveSlot.Default.Armor2;
                WeapondDamage = UserSaveSlot.Default.Attack2;
                if (UserSaveSlot.Default.Armor2 > 0)
                {
                    ArmorInHand = true;
                    if (UserSaveSlot.Default.NameArmor2 == "Chestplate lvl 1")
                    {
                        slotArmor.Image = Properties.Resources.Chestplate1slot;
                        slotArmorName.Text = "Chestplate lvl 1";
                    }
                    if (UserSaveSlot.Default.NameArmor2 == "Chestplate lvl 2")
                    {
                        slotArmor.Image = Properties.Resources.Chestplate2slot;
                        slotArmorName.Text = "Chestplate lvl 2";
                    }
                    if (UserSaveSlot.Default.NameArmor2 == "Chestplate lvl 3")
                    {
                        slotArmor.Image = Properties.Resources.Chestplate3slot;
                        slotArmorName.Text = "Chestplate lvl 3";
                    }
                }
                expirience = UserSaveSlot.Default.XP2;
                coins = UserSaveSlot.Default.Coins2;

                zobrazeniHeal.Text = Convert.ToString(playerHeal);
                zobrazeniArmor.Text = Convert.ToString(playerProtection);
                zobrazeniCoin.Text = Convert.ToString(coins);
                if (UserSaveSlot.Default.Attack2 == 40)
                {
                    slotWeapond.Image = Properties.Resources.sword1Slot;
                    slotWeapondName.Text = "Sword lvl 1";
                    Weapon = Properties.Resources.sword;
                    WeapondInHand = true;
                }
                if (UserSaveSlot.Default.Potion2 == "Heal potion")
                {
                    slotPotion.Image = Properties.Resources.potionHeal1Slot;
                    slotPotionName.Text = "Heal potion";
                    typePotion = "heal1";
                    HavePotion = true;
                }
                if (UserSaveSlot.Default.Potion2 == "Xp potion")
                {
                    slotPotion.Image = Properties.Resources.potionXPslot;
                    slotPotionName.Text = "Xp potion";
                    typePotion = "Xp1";
                    HavePotion = true;
                }
                if (UserSaveSlot.Default.Potion2 == "potion Boost")
                {
                    slotPotion.Image = Properties.Resources.potionBoost1Slot;
                    slotPotionName.Text = "potion Boost";
                    typePotion = "boost";
                    HavePotion = true;
                }
                if (UserSaveSlot.Default.MagicBall2 == "fireball")
                {
                    slotMagic.Image = Properties.Resources.fireball1Slot;
                    slotMagicName.Text = "Fireball";
                    typeMagicBall = "fireball";
                }
                if (UserSaveSlot.Default.Attack2 == 60)
                {
                    slotWeapond.Image = Properties.Resources.sword2Slot;
                    slotWeapondName.Text = "Sword lvl 2";
                    Weapon = Properties.Resources.sword;
                    WeapondInHand = true;
                }
                if (UserSaveSlot.Default.Attack2 == 80)
                {
                    slotWeapond.Image = Properties.Resources.sword3Slot;
                    slotWeapondName.Text = "Sword lvl 3";
                    Weapon = Properties.Resources.sword;
                    WeapondInHand = true;
                }
                if (UserSaveSlot.Default.Sex2 == "Female")
                    SexMale = false;
                if (UserSaveSlot.Default.MagicBall2 == "magicshoot")
                {
                    slotMagic.Image = Properties.Resources.MagicShootSlot;
                    slotMagicName.Text = "Magic shoot";
                    typeMagicBall = "magicshoot";
                }
                if (UserSaveSlot.Default.MagicBall2 == "energyball")
                {
                    slotMagic.Image = Properties.Resources.energyElipse1Slot;
                    slotMagicName.Text = "Energy Ball";
                    typeMagicBall = "energyball";
                }

            }
            // USER 3 LOAD
            if (MainSetting.Default.SavingUser == 3)
            {
                playerHeal = UserSaveSlot.Default.Live3;
                playerProtection = UserSaveSlot.Default.Armor3;
                WeapondDamage = UserSaveSlot.Default.Attack3;
                if (UserSaveSlot.Default.Armor1 > 0)
                {
                    ArmorInHand = true;
                    if (UserSaveSlot.Default.NameArmor3 == "Chestplate lvl 1")
                    {
                        slotArmor.Image = Properties.Resources.Chestplate1slot;
                        slotArmorName.Text = "Chestplate lvl 1";
                    }
                    if (UserSaveSlot.Default.NameArmor3 == "Chestplate lvl 2")
                    {
                        slotArmor.Image = Properties.Resources.Chestplate2slot;
                        slotArmorName.Text = "Chestplate lvl 2";
                    }
                    if (UserSaveSlot.Default.NameArmor3 == "Chestplate lvl 3")
                    {
                        slotArmor.Image = Properties.Resources.Chestplate3slot;
                        slotArmorName.Text = "Chestplate lvl 3";
                    }
                }
                expirience = UserSaveSlot.Default.XP3;
                coins = UserSaveSlot.Default.Coins3;

                zobrazeniHeal.Text = Convert.ToString(playerHeal);
                zobrazeniArmor.Text = Convert.ToString(playerProtection);
                zobrazeniCoin.Text = Convert.ToString(coins);
                if (UserSaveSlot.Default.Attack3 == 40)
                {
                    slotWeapond.Image = Properties.Resources.sword1Slot;
                    slotWeapondName.Text = "Sword lvl 1";
                    Weapon = Properties.Resources.sword;
                    WeapondInHand = true;
                }
                if (UserSaveSlot.Default.Potion3 == "Heal potion")
                {
                    slotPotion.Image = Properties.Resources.potionHeal1Slot;
                    slotPotionName.Text = "Heal potion";
                    typePotion = "heal1";
                    HavePotion = true;
                }
                if (UserSaveSlot.Default.Potion3 == "Xp potion")
                {
                    slotPotion.Image = Properties.Resources.potionXPslot;
                    slotPotionName.Text = "Xp potion";
                    typePotion = "Xp1";
                    HavePotion = true;
                }
                if (UserSaveSlot.Default.Potion3 == "potion Boost")
                {
                    slotPotion.Image = Properties.Resources.potionBoost1Slot;
                    slotPotionName.Text = "potion Boost";
                    typePotion = "boost";
                    HavePotion = true;
                }
                if (UserSaveSlot.Default.MagicBall3 == "fireball")
                {
                    slotMagic.Image = Properties.Resources.fireball1Slot;
                    slotMagicName.Text = "Fireball";
                    typeMagicBall = "fireball";
                }
                if (UserSaveSlot.Default.Attack3 == 60)
                {
                    slotWeapond.Image = Properties.Resources.sword2Slot;
                    slotWeapondName.Text = "Sword lvl 2";
                    Weapon = Properties.Resources.sword;
                    WeapondInHand = true;
                }
                if (UserSaveSlot.Default.Attack3 == 80)
                {
                    slotWeapond.Image = Properties.Resources.sword3Slot;
                    slotWeapondName.Text = "Sword lvl 3";
                    Weapon = Properties.Resources.sword;
                    WeapondInHand = true;
                }
                if (UserSaveSlot.Default.Sex3 == "Female")
                    SexMale = false;
                if (UserSaveSlot.Default.MagicBall3 == "magicshoot")
                {
                    slotMagic.Image = Properties.Resources.MagicShootSlot;
                    slotMagicName.Text = "Magic shoot";
                    typeMagicBall = "magicshoot";
                }
                if (UserSaveSlot.Default.MagicBall3 == "energyball")
                {
                    slotMagic.Image = Properties.Resources.energyElipse1Slot;
                    slotMagicName.Text = "Energy Ball";
                    typeMagicBall = "energyball";
                }
            }
            StopTimer.Start();
        }

        private void Pozadi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
            if (e.KeyCode == Keys.L)
            {
                attack = true;
            }
            if (e.KeyCode == Keys.J)
            {
                drinkPotion = true;
            }
            if (e.KeyCode == Keys.K)
            {
                magicAttack = true;
            }
            if (e.KeyCode == Keys.F10)
            {
                if (MainSetting.Default.CMDonline == true)
                {
                    CodeLine code = new CodeLine();
                    code.ShowDialog();
                    playerHeal += SettingsCodeLine.Default.Heal;
                    zobrazeniHeal.Text = Convert.ToString(playerHeal);
                    coins += SettingsCodeLine.Default.Coin;
                    zobrazeniCoin.Text = Convert.ToString(coins);
                    WeapondDamage = SettingsCodeLine.Default.Damage;
                }
                else
                    MessageBox.Show("Cheats are off", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (e.KeyCode == Keys.F9)
            {
                if (MainSetting.Default.CMDonline == true)
                {
                    playerHeal += SettingsCodeLine.Default.Heal;
                    zobrazeniHeal.Text = Convert.ToString(playerHeal);
                    coins += SettingsCodeLine.Default.Coin;
                    zobrazeniCoin.Text = Convert.ToString(coins);
                    WeapondDamage = SettingsCodeLine.Default.Damage;
                }
                else
                    MessageBox.Show("Cheats are off", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (e.KeyCode == Keys.F8)
                MessageBox.Show("playerHeal: " + playerHeal + " playerProtection: " + playerProtection + " weapondDamage: " + WeapondDamage + " XP: " + expirience + " coins: " + coins 
                    + Environment.NewLine + " SexMale: " + SexMale + " ArmorName: " + UserSaveSlot.Default.NameArmor1 + "enemyHeal: " + enemyHeal);

        }

        private void Pozadi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
            if (e.KeyCode == Keys.L)
            {
                attack = false;
            }
            if (e.KeyCode == Keys.J)
            {
                drinkPotion = false;
            }
            if (e.KeyCode == Keys.K)
            {
                magicAttack = false;
            }
            if (e.KeyCode == Keys.Escape)
            {
                MagmaTimer.Stop();
                TimerWalk.Stop();
                EnemyAttack.Stop();
                EnemyKingAttack.Stop();
                EnemyWitherTimer.Stop();
                EnemyRatAttack.Stop();
                Cursor.Show();
                StopMenu stopm = new StopMenu();
                AudioSoundtrack.Ctlcontrols.pause();
                stopm.ShowDialog();
                AudioSoundtrack.Ctlcontrols.play();
                if (MainSetting.Default.GoToMenu == true)
                {
                    AudioSoundtrack.Ctlcontrols.stop();
                    MainSetting.Default.GoToMenu = false;
                    MainSetting.Default.Save();
                    this.Close();
                }
                else
                { 
                Cursor.Hide();
                    MagmaTimer.Start();
                TimerWalk.Start();
                EnemyAttack.Start();
                EnemyWitherTimer.Start();
                EnemyKingAttack.Start();
                EnemyRatAttack.Start();
                }
            }
        }

        private void TimerWalk_Tick(object sender, EventArgs e)
        {

            if (goleft)
            {
                PlayerArmor = Properties.Resources.chestplate3;
                if (SexMale == true)
                    player.Image = Properties.Resources.player3;
                else
                    player.Image = Properties.Resources.playerWomen3;
                player.Left -= 5;
                PlayerLook = 3;
            }

            if (goright)
            {
                PlayerArmor = Properties.Resources.chestplate4;
                if (SexMale == true)
                    player.Image = Properties.Resources.player4;
                else
                    player.Image = Properties.Resources.playerWomen4;
                player.Left += 5;
                PlayerLook = 4;
            }

            if (goup)
            {
                PlayerArmor = Properties.Resources.chestplate2;
                if (SexMale == true)
                    player.Image = Properties.Resources.player2;
                else
                    player.Image = Properties.Resources.playerWomen2;
                player.Top -= 5;
                PlayerLook = 2;

            }
            if (godown)
            {
                PlayerArmor = Properties.Resources.chesplate1;
                if (SexMale == true)
                    player.Image = Properties.Resources.player;
                else
                    player.Image = Properties.Resources.playerWomen;
                player.Top += 5;
                PlayerLook = 1;
            }
            if (attack)
            {
                player.Refresh();
                AudioAttack.Ctlcontrols.play();
            }
            if (!attack)
            {
                player.Refresh();
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "SecretWall")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                    }
                }
                if (Settings1.Default.TradeSecret == true && x is PictureBox && x.Tag == "SecretWall")
                {
                    this.Controls.Remove(x);
                    this.Controls.Remove(x);
                }


                if (x is PictureBox && x.Tag == "coin")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        coins++;
                        zobrazeniCoin.Text = Convert.ToString(coins);
                    }
                }
                if (x is PictureBox && x.Tag == "LeftBorder")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        player.Left = x.Right;
                    }
                }
                if (x is PictureBox && x.Tag == "RightBorder")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        player.Left = x.Left - player.Width;
                    }
                }
                if (x is PictureBox && x.Tag == "UpBorder")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        player.Top = x.Top + player.Width ;
                    }
                }
                if (x is PictureBox && x.Tag == "DownBorder")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        player.Top = x.Top - player.Width -5;
                    }
                }
                if (x is PictureBox && x.Tag == "chest")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (attack)
                        {
                            coins += Convert.ToInt32(náhoda.Next(1, 11));
                            zobrazeniCoin.Text = Convert.ToString(coins);
                            x.BackgroundImage = Properties.Resources.lootedChest;
                            x.Tag = null;
                        }
                    }
                }
                if (x is PictureBox && x.Tag == "chestGold")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (attack)
                        {
                            coins += Convert.ToInt32(náhoda.Next(10, 31));
                            zobrazeniCoin.Text = Convert.ToString(coins);
                            expirience += náhoda.Next(1, 11);
                            ZobrazeniXP.Text = Convert.ToString(expirience);
                            x.BackgroundImage = Properties.Resources.lootedChestGold;
                            x.Tag = null;
                        }
                    }
                }

                if (x is PictureBox && x.Tag == "potionHeal")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (HavePotion == false)
                        {
                        this.Controls.Remove(x);
                        slotPotion.Image = Properties.Resources.potionHeal1Slot;
                        slotPotionName.Text = "Heal potion";
                        typePotion = "heal1";
                        HavePotion = true;
                        }
                    }
                }
                if (x is PictureBox && x.Tag == "potionXp")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (HavePotion == false)
                        {
                            this.Controls.Remove(x);
                            slotPotion.Image = Properties.Resources.potionXPslot;
                            slotPotionName.Text = "Xp potion";
                            typePotion = "Xp1";
                            HavePotion = true;
                        }
                    }
                }
                if (x is PictureBox && x.Tag == "potionBoost")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (HavePotion == false)
                        {
                            this.Controls.Remove(x);
                            slotPotion.Image = Properties.Resources.potionBoost1Slot;
                            slotPotionName.Text = "potion Boost";
                            typePotion = "boost";
                            HavePotion = true;
                        }
                    }
                }
                if (x is PictureBox && x.Tag == "Trader")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (attack)
                        {
                            if (TradeNow)
                            {
                                TradeNow = false;
                                attack = false;
                                Settings1.Default.TradeCoins = coins;
                                Settings1.Default.PlayerArmorNow = playerProtection;
                                Settings1.Default.Save();
                                godown = false;
                                goup = false;
                                goright = false;
                                goleft = false;
                                Cursor.Show();
                                Trade trade = new Trade();
                                AudioSoundtrack.Ctlcontrols.pause();
                                StopTimer.Start();
                                trade.ShowDialog();
                                AudioSoundtrack.Ctlcontrols.play();
                                Cursor.Hide();
                                coins = Settings1.Default.TradeCoins;
                                playerHeal += Settings1.Default.TradeHeal;
                                playerProtection += Settings1.Default.TradeArmor;
                                expirience += Settings1.Default.TradeXP;
                                ZobrazeniXP.Text = Convert.ToString(expirience);
                                zobrazeniHeal.Text = Convert.ToString(playerHeal);
                                zobrazeniCoin.Text = Convert.ToString(coins);
                                zobrazeniArmor.Text = Convert.ToString(playerProtection);

                                Settings1.Default.TradeHeal = 0;
                                Settings1.Default.TradeArmor = 0;
                                Settings1.Default.TradeCoins = 0;
                                Settings1.Default.TradeXP = 0;
                                Settings1.Default.TradeSecret = false;
                                Settings1.Default.Save();
                                TradeNow = true;
                            }
                        }
                    }
                }
                
                if (x is PictureBox && x.Tag == "sword1")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        slotWeapond.Image = Properties.Resources.sword1Slot;
                        slotWeapondName.Text = "Sword lvl 1";
                        WeapondDamage = 40;
                        Weapon = Properties.Resources.sword;
                        WeapondInHand = true;

                    }
                }
                if (x is PictureBox && x.Tag == "sword2")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        slotWeapond.Image = Properties.Resources.sword2Slot;
                        slotWeapondName.Text = "Sword lvl 2";
                        WeapondDamage = 60;
                        Weapon = Properties.Resources.sword;
                        WeapondInHand = true;
                    }
                }
                if (x is PictureBox && x.Tag == "sword3")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        slotWeapond.Image = Properties.Resources.sword3Slot;
                        slotWeapondName.Text = "Sword lvl 3";
                        WeapondDamage = 80;
                        Weapon = Properties.Resources.sword;
                        WeapondInHand = true;
                    }
                }
                if (x is PictureBox && x.Tag == "fireball1")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        slotMagic.Image = Properties.Resources.fireball1Slot;
                        slotMagicName.Text = "Fireball";
                        typeMagicBall = "fireball";
                    }
                }
                if (x is PictureBox && x.Tag == "fireball2")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        slotMagic.Image = Properties.Resources.MagicShootSlot;
                        slotMagicName.Text = "Magic shoot";
                        typeMagicBall = "magicshoot";
                    }
                }
                if (x is PictureBox && x.Tag == "fireball3")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        slotMagic.Image = Properties.Resources.energyElipse1Slot;
                        slotMagicName.Text = "Energy ball";
                        typeMagicBall = "energyball";
                    }
                }
                if (x is PictureBox && x.Tag == "armor1")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        slotArmor.Image = Properties.Resources.Chestplate1slot;
                        slotArmorName.Text = "Chestplate lvl 1";
                         playerProtection = 100;
                        zobrazeniArmor.Text = Convert.ToString(playerProtection);
                         ArmorInHand = true;
                    }
                }
                if (x is PictureBox && x.Tag == "armor2")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        slotArmor.Image = Properties.Resources.Chestplate2slot;
                        slotArmorName.Text = "Chestplate lvl 2";
                        playerProtection = 150;
                        zobrazeniArmor.Text = Convert.ToString(playerProtection);
                        ArmorInHand = true;
                    }
                }
                if (x is PictureBox && x.Tag == "armor3")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        slotArmor.Image = Properties.Resources.Chestplate3slot;
                        slotArmorName.Text = "Chestplate lvl 3";
                        playerProtection = 200;
                        zobrazeniArmor.Text = Convert.ToString(playerProtection);
                        ArmorInHand = true;
                    }
                }
                if (drinkPotion)
                {
                    if (typePotion == "heal1" && HavePotion == true) 
                    {
                    damage = Convert.ToInt32(náhoda.Next(10, 50));
                    playerHeal += damage;
                        if (playerHeal > 100)
                            playerHeal = 100;
                        zobrazeniHeal.Text = Convert.ToString(playerHeal);
                    HealplayerZobrazeni.Text = "+" + damage;
                        HavePotion = false;
                    }
                    if (typePotion == "Xp1" && HavePotion == true)
                    {
                        damage = Convert.ToInt32(náhoda.Next(10, 50));
                        expirience += damage;
                        ZobrazeniXP.Text = Convert.ToString(expirience);
                        HavePotion = false;
                    }
                    if (typePotion == "boost" && HavePotion == true)
                    {
                        expirience += 100;
                        ZobrazeniXP.Text = Convert.ToString(expirience);
                        playerHeal = 200;
                        zobrazeniHeal.Text = Convert.ToString(playerHeal);
                        HavePotion = false;
                    }
                    slotPotionName.Text = "Potion";
                    slotPotion.Image = null;
                    HealplayerZobrazeni.Visible = true;
                    HealplayerZobrazeni.Top = player.Top;
                    HealplayerZobrazeni.Left = player.Left + player.Width;
                }

                if (player.Bounds.IntersectsWith(door.Bounds))
                {
                    MagmaTimer.Stop();
                    TimerWalk.Stop();
                EnemyAttack.Stop();
                EnemyRatAttack.Stop();
                EnemyKingAttack.Stop();
                EnemyWitherTimer.Stop();
                    AudioSoundtrack.Ctlcontrols.stop();
                if(MainSetting.Default.SavingUser == 1 && DoOne == true)
                    {
                            DoOne = false;
                            UserSaveSlot.Default.Live1 = playerHeal;
                            UserSaveSlot.Default.Armor1 = playerProtection;
                            UserSaveSlot.Default.XP1 = expirience;
                            UserSaveSlot.Default.Coins1 = coins;
                            UserSaveSlot.Default.Attack1 = WeapondDamage;
                            UserSaveSlot.Default.MagicBall1 = typeMagicBall;
                            UserSaveSlot.Default.Level1++;
                            UserSaveSlot.Default.Potion1 = slotPotionName.Text;
                            UserSaveSlot.Default.NameArmor1 = slotArmorName.Text;
                            UserSaveSlot.Default.Save();
                            Cursor.Show();
                            this.Close();
                    }
                    if (MainSetting.Default.SavingUser == 2 && DoOne == true)
                    {
                        DoOne = false;
                        UserSaveSlot.Default.Live2 = playerHeal;
                        UserSaveSlot.Default.Armor2 = playerProtection;
                        UserSaveSlot.Default.XP2 = expirience;
                        UserSaveSlot.Default.Coins2 = coins;
                        UserSaveSlot.Default.Attack2 = WeapondDamage;
                        UserSaveSlot.Default.MagicBall2 = typeMagicBall;
                        UserSaveSlot.Default.Level2++;
                        UserSaveSlot.Default.Potion2 = slotPotionName.Text;
                        UserSaveSlot.Default.NameArmor2 = slotArmorName.Text;
                        UserSaveSlot.Default.Save();
                        Cursor.Show();
                        this.Close();
                    }
                    if (MainSetting.Default.SavingUser == 3 && DoOne == true)
                    {
                        DoOne = false;
                        UserSaveSlot.Default.Live3 = playerHeal;
                        UserSaveSlot.Default.Armor3 = playerProtection;
                        UserSaveSlot.Default.XP3 = expirience;
                        UserSaveSlot.Default.Coins3 = coins;
                        UserSaveSlot.Default.Attack3 = WeapondDamage;
                        UserSaveSlot.Default.MagicBall3 = typeMagicBall;
                        UserSaveSlot.Default.Level3++;
                        UserSaveSlot.Default.Potion3 = slotPotionName.Text;
                        UserSaveSlot.Default.NameArmor3 = slotArmorName.Text;
                        UserSaveSlot.Default.Save();
                        Cursor.Show();
                        this.Close();
                    }
                }

                if (x is PictureBox && x.Tag == "enemy")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (attack == true)
                    {
                        damage = Convert.ToInt32(náhoda.Next(10, playerDamage + WeapondDamage));
                        enemyHeal -= damage;
                        HitZobrazeni.Text = "-" + Convert.ToString(damage);
                        HitZobrazeni.Top = x.Top;
                        HitZobrazeni.Left = x.Left + x.Width;
                        HitZobrazeni.Visible = true;
                        attack = false;
                        AudioWarrior.Ctlcontrols.play();
                    }
                    }
                    if (enemyHeal < 0)
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                        enemyHeal = 200;
                        this.Controls.Remove(x);
                        expirience += Convert.ToInt32(náhoda.Next(1, 11));
                        ZobrazeniXP.Text = Convert.ToString(expirience);
                        }
                    }

                }
                if (x is PictureBox && x.Tag == "enemyKing")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (attack == true)
                        {
                            damage = Convert.ToInt32(náhoda.Next(10, playerDamage + WeapondDamage));
                            enemyKingHeal -= damage;
                            HitZobrazeni.Text = "-" + Convert.ToString(damage);
                            HitZobrazeni.Top = x.Top;
                            HitZobrazeni.Left = x.Left + x.Width;
                            HitZobrazeni.Visible = true;
                            attack = false;
                            AudioKing.Ctlcontrols.play();
                        }
                    }
                    if (enemyKingHeal < 0)
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            enemyKingHeal = 500;
                            this.Controls.Remove(x);
                            expirience += Convert.ToInt32(náhoda.Next(5, 20));
                            ZobrazeniXP.Text = Convert.ToString(expirience);
                        }
                    }
                }
                if (x is PictureBox && x.Tag == "enemyWither")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            if (attack == true)
                            {
                                damage = Convert.ToInt32(náhoda.Next(10, playerDamage + WeapondDamage));
                                enemyWither -= damage;
                                HitZobrazeni.Text = "-" + Convert.ToString(damage);
                                HitZobrazeni.Top = x.Top;
                                HitZobrazeni.Left = x.Left + x.Width;
                                HitZobrazeni.Visible = true;
                                attack = false;
                                AudioWither.Ctlcontrols.play();
                            }
                        }
                    
                    if (enemyWither < 0)
                        {
                            if (player.Bounds.IntersectsWith(x.Bounds))
                            {
                                enemyWither = 300;
                                this.Controls.Remove(x);
                                expirience += Convert.ToInt32(náhoda.Next(10, 30));
                                ZobrazeniXP.Text = Convert.ToString(expirience);
                            }
                        }
                    }
                if (x is PictureBox && x.Tag == "enemyRat")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (attack == true)
                        {
                            damage = Convert.ToInt32(náhoda.Next(10, playerDamage + WeapondDamage));
                            EnemyRatHeal -= damage;
                            HitZobrazeni.Text = "-" + Convert.ToString(damage);
                            HitZobrazeni.Top = x.Top;
                            HitZobrazeni.Left = x.Left + x.Width;
                            HitZobrazeni.Visible = true;
                            attack = false;
                            AudioRat.Ctlcontrols.play();
                        }
                    }
                    if (EnemyRatHeal < 0)
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            EnemyRatHeal = 50;
                            this.Controls.Remove(x);
                            expirience += Convert.ToInt32(náhoda.Next(1, 11));
                            ZobrazeniXP.Text = Convert.ToString(expirience);
                        }
                    }

                }

            }

    }

        private void player_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;
            if (playerHeal < 50)
                kp.DrawImage(Properties.Resources.Blood, 0, 0, 50, 55);
            if (ArmorInHand)
            kp.DrawImage(PlayerArmor, 0, 0, 50, 55);
            if (WeapondInHand)
                kp.DrawImage(Weapon, 0, 0, 50, 55);
            if (attack)
                kp.DrawImage(Properties.Resources.knockback, 0, 0, 50, 50);
        }

        private void EnemyAttack_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "enemy")
            {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        damage = Convert.ToInt32(náhoda.Next(20, 50) - (playerProtection / 2));
                        if (damage > 0) { 
                            playerHeal -= damage;
                            HitplayerZobrazeni.Text = "-" + Convert.ToString(damage);
                            HitplayerZobrazeni.Visible = true;
                            AudioHit.Ctlcontrols.play();
                        }
                        zobrazeniHeal.Text = Convert.ToString(playerHeal);
                        HitplayerZobrazeni.Top = player.Top;
                        HitplayerZobrazeni.Left = player.Left + player.Width;
                        playerProtection -= Convert.ToInt32(náhoda.Next(20, 50)) / 2;
                        zobrazeniArmor.Text = Convert.ToString(playerProtection);
                        if (playerProtection < 0)
                        { 
                            playerProtection = 0;
                            zobrazeniArmor.Text = Convert.ToString(playerProtection);
                            ArmorInHand = false;
                            slotArmor.Image = null;
                            slotArmorName.Text = "Armor";
                        }
                    } 
                if (playerHeal <= 0)
                {
                        MagmaTimer.Stop();
                        EnemyAttack.Stop();
                    TimerWalk.Stop();
                    ClearParticles.Stop();
                    EnemyWitherTimer.Stop();
                    EnemyKingAttack.Stop();
                    EnemyRatAttack.Stop();
                    AudioSoundtrack.Ctlcontrols.stop();
                    DeadMenu deme = new DeadMenu();
                    Cursor.Show();
                    deme.ShowDialog();
                        if (MainSetting.Default.GoToMenu == true)
                        {
                            MainSetting.Default.GoToMenu = false;
                            MainSetting.Default.Save();
                            this.Close();
                        }
                        if (MainSetting.Default.GoToRespawn == true)
                        {
                            this.Close();
                        }
                    }
            }
        }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "enemy")
                {

                    if (player.Top < x.Top && player.Top > x.Top - 200 && player.Left > x.Left - 200 && player.Left < x.Left + 200)
                    { 
                        x.Top -= 20;
                        x.BackgroundImage = Properties.Resources.enemyWarrior2;
                    }
                    if (player.Top > x.Top && player.Top < x.Top + 200 && player.Left > x.Left - 200 && player.Left < x.Left + 200)
                    { 
                        x.Top += 20;
                        x.BackgroundImage = Properties.Resources.enemyWarrior;
                    }
                    if (player.Top > x.Top -200 && player.Top < x.Top + 200 && player.Left > x.Left - 200 && player.Left < x.Left)
                        x.Left -= 20;
                    if (player.Top > x.Top - 200 && player.Top < x.Top + 200 && player.Left > x.Left && player.Left < x.Left + 200)               
                        x.Left += 20;

                }
            }
        }
        private void ClearParticles_Tick(object sender, EventArgs e)
        {
            HitZobrazeni.Visible = false;
            HitplayerZobrazeni.Visible = false;
            HealplayerZobrazeni.Visible = false;
        }

        private void MagicBallWalk_Tick(object sender, EventArgs e)
        {
            if (magicAttack == true && magicFly == false)
            {
                if (typeMagicBall == "fireball")
                {
                    if (expirience > 9)
                    {
                        expirience -= 10;
                    MagicBall.Image = Properties.Resources.fireball1;
                    MagicBall.Top = player.Top;
                    MagicBall.Left = player.Left;
                    if (PlayerLook == 1)
                    MagicBallWay = 1;
                    if (PlayerLook == 2)
                        MagicBallWay = 2;
                    if (PlayerLook == 3)
                        MagicBallWay = 3;
                    if (PlayerLook == 4)
                        MagicBallWay = 4;
                    magicFly = true;
                    MagicBall.Visible = true;
                        magicBallDamage = 100;
                    }
                }
                if (typeMagicBall == "magicshoot")
                    if (expirience > 14)
                    {
                        expirience -= 15;
                        MagicBall.Image = Properties.Resources.fireball2;
                        MagicBall.Top = player.Top;
                        MagicBall.Left = player.Left;
                        if (PlayerLook == 1)
                            MagicBallWay = 1;
                        if (PlayerLook == 2)
                            MagicBallWay = 2;
                        if (PlayerLook == 3)
                            MagicBallWay = 3;
                        if (PlayerLook == 4)
                            MagicBallWay = 4;
                        magicFly = true;
                        MagicBall.Visible = true;
                        magicBallDamage = 150;
                    }
                if (typeMagicBall == "energyball")
                    if (expirience > 19)
                    {
                        expirience -= 20;
                        MagicBall.Image = Properties.Resources.fireball3;
                        MagicBall.Top = player.Top;
                        MagicBall.Left = player.Left;
                        if (PlayerLook == 1)
                            MagicBallWay = 1;
                        if (PlayerLook == 2)
                            MagicBallWay = 2;
                        if (PlayerLook == 3)
                            MagicBallWay = 3;
                        if (PlayerLook == 4)
                            MagicBallWay = 4;
                        magicFly = true;
                        MagicBall.Visible = true;
                        magicBallDamage = 200;
                    }
            }
            ZobrazeniXP.Text = Convert.ToString(expirience);
            if (MagicBallWay == 1)
                MagicBall.Top += 5;
            if (MagicBallWay == 2)
                MagicBall.Top -= 5;
            if (MagicBallWay == 3)
                MagicBall.Left -= 5;
            if (MagicBallWay == 4)
                MagicBall.Left += 5;


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "DownBorder")
                {
                    if (MagicBall.Bounds.IntersectsWith(x.Bounds))
                    {
                        MagicBallWay = 0;
                        magicFly = false;
                        MagicBall.Visible = false;
                    }
                }
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "UpBorder")
                {
                    if (MagicBall.Bounds.IntersectsWith(x.Bounds))
                    {
                        MagicBallWay = 0;
                        magicFly = false;
                        MagicBall.Visible = false;
                    }
                }
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "RightBorder")
                {
                    if (MagicBall.Bounds.IntersectsWith(x.Bounds))
                    {
                        MagicBallWay = 0;
                        magicFly = false;
                        MagicBall.Visible = false;
                    }
                }
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "LeftBorder")
                {
                    if (MagicBall.Bounds.IntersectsWith(x.Bounds))
                    {
                        MagicBallWay = 0;
                        magicFly = false;
                        MagicBall.Visible = false;
                    }
                }
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "enemy")
                {
                    if (MagicBall.Bounds.IntersectsWith(x.Bounds))
                    {
                        MagicBallWay = 0;
                        magicFly = false;
                        MagicBall.Visible = false;
                        AudioWarrior.Ctlcontrols.play();
                        if (MagicBall.Bounds.IntersectsWith(x.Bounds))
                            {
                                enemyHeal -= magicBallDamage;
                            MagicBall.Top = 0;
                            MagicBall.Left = 0;
                            if (enemyHeal < 1)
                            { 
                                enemyHeal = 200;
                                this.Controls.Remove(x);
                                expirience += Convert.ToInt32(náhoda.Next(1, 11));
                                ZobrazeniXP.Text = Convert.ToString(expirience);
                            }
                        }
                    }
                }
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "enemyWither")
                {
                    if (MagicBall.Bounds.IntersectsWith(x.Bounds))
                    {
                        MagicBallWay = 0;
                        magicFly = false;
                        MagicBall.Visible = false;
                        AudioWither.Ctlcontrols.play();
                        if (MagicBall.Bounds.IntersectsWith(x.Bounds))
                        {
                            enemyWither -= magicBallDamage;
                            MagicBall.Top = 0;
                            MagicBall.Left = 0;
                            if (enemyWither < 1)
                            {
                                enemyWither = 200;
                                this.Controls.Remove(x);
                                expirience += Convert.ToInt32(náhoda.Next(10, 30));
                                ZobrazeniXP.Text = Convert.ToString(expirience);
                            }
                        }
                    }
                }
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "enemyKing")
                {
                    if (MagicBall.Bounds.IntersectsWith(x.Bounds))
                    {
                        MagicBallWay = 0;
                        magicFly = false;
                        MagicBall.Visible = false;
                        AudioKing.Ctlcontrols.play();
                        if (MagicBall.Bounds.IntersectsWith(x.Bounds))
                        {
                            enemyKingHeal -= magicBallDamage;
                            MagicBall.Top = 0;
                            MagicBall.Left = 0;
                            if (enemyKingHeal < 1)
                            {
                                enemyKingHeal = 500;
                                this.Controls.Remove(x);
                                expirience += Convert.ToInt32(náhoda.Next(5, 20));
                                ZobrazeniXP.Text = Convert.ToString(expirience);
                            }
                        }
                    }
                }
            }
            foreach (Control z in this.Controls)
            {
                if (z is PictureBox && z.Tag == "enemyRat")
                {
                    if (MagicBall.Bounds.IntersectsWith(z.Bounds))
                    {
                        MagicBallWay = 0;
                        magicFly = false;
                        MagicBall.Visible = false;
                        AudioRat.Ctlcontrols.play();
                        if (MagicBall.Bounds.IntersectsWith(z.Bounds))
                        {
                            MagicBall.Top = 0;
                            MagicBall.Left = 0;

                                EnemyRatHeal = 50;
                                this.Controls.Remove(z);
                                expirience += Convert.ToInt32(náhoda.Next(1, 11));
                                ZobrazeniXP.Text = Convert.ToString(expirience);                           
                        }
                    }
                }
            }
        }

        private void EnemyRatAttack_Tick(object sender, EventArgs e)
        {
            foreach (Control z in this.Controls)
            {
                if (z is PictureBox && z.Tag == "enemyRat")
                {
                    if (player.Bounds.IntersectsWith(z.Bounds))
                    {
                        damage = Convert.ToInt32(náhoda.Next(5, 11) - (playerProtection / 2));
                        if (damage > 0)
                        {
                            playerHeal -= damage;
                            HitplayerZobrazeni.Text = "-" + Convert.ToString(damage);
                            HitplayerZobrazeni.Visible = true;
                            AudioHit.Ctlcontrols.play();
                        }
                        zobrazeniHeal.Text = Convert.ToString(playerHeal);
                        HitplayerZobrazeni.Top = player.Top;
                        HitplayerZobrazeni.Left = player.Left + player.Width;
                        playerProtection -= Convert.ToInt32(náhoda.Next(5, 11)) / 2;
                        zobrazeniArmor.Text = Convert.ToString(playerProtection);
                        if (playerProtection < 0)
                        {
                            playerProtection = 0;
                            zobrazeniArmor.Text = Convert.ToString(playerProtection);
                            ArmorInHand = false;
                            slotArmor.Image = null;
                            slotArmorName.Text = "Armor";
                        }
                    }
                    if (playerHeal <= 0)
                    {
                        MagmaTimer.Stop();
                        EnemyAttack.Stop();
                        TimerWalk.Stop();
                        EnemyKingAttack.Stop();
                        EnemyWitherTimer.Stop();
                        ClearParticles.Stop();
                        EnemyRatAttack.Stop();
                        AudioSoundtrack.Ctlcontrols.stop();
                        Cursor.Show();
                        DeadMenu deme = new DeadMenu();
                        deme.ShowDialog();
                        if (MainSetting.Default.GoToMenu == true)
                        {
                            MainSetting.Default.GoToMenu = false;
                            MainSetting.Default.Save();
                            this.Close();
                        }
                        if (MainSetting.Default.GoToRespawn == true)
                        {
                            this.Close();
                        }
                    }
                }
            }

            foreach (Control z in this.Controls)
            {
                if (z is PictureBox && z.Tag == "enemyRat")
                {

                    if (player.Top < z.Top && player.Top > z.Top - 200 && player.Left > z.Left - 200 && player.Left < z.Left + 200)                 
                        z.Top -= 20;                 
                    if (player.Top > z.Top && player.Top < z.Top + 200 && player.Left > z.Left - 200 && player.Left < z.Left + 200)
                        z.Top += 20;
                    if (player.Top > z.Top - 200 && player.Top < z.Top + 200 && player.Left > z.Left - 200 && player.Left < z.Left)
                    { 
                        z.Left -= 20;
                        z.BackgroundImage = Properties.Resources.enemyRat;                       
                    }
                    if (player.Top > z.Top - 200 && player.Top < z.Top + 200 && player.Left > z.Left && player.Left < z.Left + 200)
                    { 
                        z.Left += 20;
                        z.BackgroundImage = Properties.Resources.enemyRat2;
                    }

                }
            }


        }

        private void EnemyKingAttack_Tick(object sender, EventArgs e)
        {
            foreach (Control z in this.Controls)
            {
                if (z is PictureBox && z.Tag == "enemyKing")
                {
                    if (player.Bounds.IntersectsWith(z.Bounds))
                    {
                        damage = Convert.ToInt32(náhoda.Next(30, 100) - (playerProtection / 2));
                        if (damage > 0)
                        {
                            playerHeal -= damage;
                            HitplayerZobrazeni.Text = "-" + Convert.ToString(damage);
                            HitplayerZobrazeni.Visible = true;
                            AudioHit.Ctlcontrols.play();
                        }
                        zobrazeniHeal.Text = Convert.ToString(playerHeal);
                        HitplayerZobrazeni.Top = player.Top;
                        HitplayerZobrazeni.Left = player.Left + player.Width;
                        playerProtection -= Convert.ToInt32(náhoda.Next(30, 100)) / 2;
                        zobrazeniArmor.Text = Convert.ToString(playerProtection);
                        if (playerProtection < 0)
                        {
                            playerProtection = 0;
                            zobrazeniArmor.Text = Convert.ToString(playerProtection);
                            ArmorInHand = false;
                            slotArmor.Image = null;
                            slotArmorName.Text = "Armor";
                        }
                    }
                    if (playerHeal <= 0)
                    {
                        EnemyAttack.Stop();
                        TimerWalk.Stop();
                        ClearParticles.Stop();
                        EnemyRatAttack.Stop();
                        EnemyWitherTimer.Stop();
                        EnemyKingAttack.Stop();
                        AudioSoundtrack.Ctlcontrols.stop();
                        DeadMenu deme = new DeadMenu();
                        Cursor.Show();
                        deme.ShowDialog();
                        if (MainSetting.Default.GoToMenu == true)
                        {
                            MainSetting.Default.GoToMenu = false;
                            MainSetting.Default.Save();
                            this.Close();
                        }
                        if (MainSetting.Default.GoToRespawn == true)
                        {
                            this.Close();
                        }
                    }
                }
            }

            foreach (Control z in this.Controls)
            {
                if (z is PictureBox && z.Tag == "enemyKing")
                {

                    if (player.Top < z.Top && player.Top > z.Top - 200 && player.Left > z.Left - 200 && player.Left < z.Left + 200)
                    {
                        z.Top -= 30;
                        z.BackgroundImage = Properties.Resources.enemyKing2;
                    }
                    if (player.Top > z.Top && player.Top < z.Top + 200 && player.Left > z.Left - 200 && player.Left < z.Left + 200)
                    {
                        z.Top += 30;
                        z.BackgroundImage = Properties.Resources.enemyKing;
                    }
                    if (player.Top > z.Top - 200 && player.Top < z.Top + 200 && player.Left > z.Left - 200 && player.Left < z.Left)
                        z.Left -= 30;
                    if (player.Top > z.Top - 200 && player.Top < z.Top + 200 && player.Left > z.Left && player.Left < z.Left + 200)
                        z.Left += 30;

                }
            }



        }

        private void EnemyWitherTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control z in this.Controls)
            {
                if (z is PictureBox && z.Tag == "enemyWither")
                {
                    if (player.Bounds.IntersectsWith(z.Bounds))
                    {
                        damage = Convert.ToInt32(náhoda.Next(30, 70) - (playerProtection / 2));
                        if (damage > 0)
                        {
                            playerHeal -= damage;
                            HitplayerZobrazeni.Text = "-" + Convert.ToString(damage);
                            HitplayerZobrazeni.Visible = true;
                            AudioHit.Ctlcontrols.play();
                        }
                        zobrazeniHeal.Text = Convert.ToString(playerHeal);
                        HitplayerZobrazeni.Top = player.Top;
                        HitplayerZobrazeni.Left = player.Left + player.Width;
                        playerProtection -= Convert.ToInt32(náhoda.Next(30, 70)) / 2;
                        zobrazeniArmor.Text = Convert.ToString(playerProtection);
                        if (playerProtection < 0)
                        {
                            playerProtection = 0;
                            zobrazeniArmor.Text = Convert.ToString(playerProtection);
                            ArmorInHand = false;
                            slotArmor.Image = null;
                            slotArmorName.Text = "Armor";
                        }
                    }
                    if (playerHeal <= 0)
                    {
                        MagmaTimer.Stop();
                        EnemyAttack.Stop();
                        TimerWalk.Stop();
                        ClearParticles.Stop();
                        EnemyRatAttack.Stop();
                        EnemyKingAttack.Stop();
                        EnemyWitherTimer.Stop();
                        AudioSoundtrack.Ctlcontrols.stop();
                        DeadMenu deme = new DeadMenu();
                        Cursor.Show();
                        deme.ShowDialog();
                        if (MainSetting.Default.GoToMenu == true)
                        {
                            MainSetting.Default.GoToMenu = false;
                            MainSetting.Default.Save();
                            this.Close();
                        }
                        if (MainSetting.Default.GoToRespawn == true)
                        {
                            this.Close();
                        }
                    }
                }
            }

            foreach (Control z in this.Controls)
            {
                if (z is PictureBox && z.Tag == "enemyWither")
                {

                    if (player.Top < z.Top && player.Top > z.Top - 200 && player.Left > z.Left - 200 && player.Left < z.Left + 200)
                    {
                        z.Top -= 20;
                        z.BackgroundImage = Properties.Resources.enemyWither2;
                    }
                    if (player.Top > z.Top && player.Top < z.Top + 200 && player.Left > z.Left - 200 && player.Left < z.Left + 200)
                    {
                        z.Top += 20;
                        z.BackgroundImage = Properties.Resources.enemyWither;
                    }
                    if (player.Top > z.Top - 200 && player.Top < z.Top + 200 && player.Left > z.Left - 200 && player.Left < z.Left)
                        z.Left -= 20;
                    if (player.Top > z.Top - 200 && player.Top < z.Top + 200 && player.Left > z.Left && player.Left < z.Left + 200)
                        z.Left += 20;

                }
            }

        }

        private void StopTimer_Tick(object sender, EventArgs e)
        {
            AudioAttack.Ctlcontrols.stop();
            AudioHit.Ctlcontrols.stop();
            AudioKing.Ctlcontrols.stop();
            AudioRat.Ctlcontrols.stop();
            AudioWarrior.Ctlcontrols.stop();
            AudioWither.Ctlcontrols.stop();
            StopTimer.Stop();
        }

        private void MagmaTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "MagmaGround")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        damage = Convert.ToInt32(náhoda.Next(5, 11) - (playerProtection / 2));
                        if (damage > 0)
                        {
                            playerHeal -= damage;
                            HitplayerZobrazeni.Text = "-" + Convert.ToString(damage);
                            HitplayerZobrazeni.Visible = true;
                            AudioHit.Ctlcontrols.play();
                        }
                        zobrazeniHeal.Text = Convert.ToString(playerHeal);
                        HitplayerZobrazeni.Top = player.Top;
                        HitplayerZobrazeni.Left = player.Left + player.Width;
                        playerProtection -= Convert.ToInt32(náhoda.Next(20, 50)) / 2;
                        zobrazeniArmor.Text = Convert.ToString(playerProtection);
                        if (playerProtection < 0)
                        {
                            playerProtection = 0;
                            zobrazeniArmor.Text = Convert.ToString(playerProtection);
                            ArmorInHand = false;
                            slotArmor.Image = null;
                            slotArmorName.Text = "Armor";
                        }
                    }
                    if (playerHeal <= 0)
                    {
                        MagmaTimer.Stop();
                        EnemyAttack.Stop();
                        TimerWalk.Stop();
                        ClearParticles.Stop();
                        EnemyWitherTimer.Stop();
                        EnemyKingAttack.Stop();
                        EnemyRatAttack.Stop();
                        AudioSoundtrack.Ctlcontrols.stop();
                        DeadMenu deme = new DeadMenu();
                        Cursor.Show();
                        deme.ShowDialog();
                        if (MainSetting.Default.GoToMenu == true)
                        {
                            MainSetting.Default.GoToMenu = false;
                            MainSetting.Default.Save();
                            this.Close();
                        }
                        if (MainSetting.Default.GoToRespawn == true)
                        {
                            this.Close();
                        }
                    }
                }
            }
        }
    }    
}
