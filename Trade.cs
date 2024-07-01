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
    public partial class Trade : Form
    {
        //MAIN PROPERTIES
        Random Náhoda = new Random();
        public int coinsInTrade;
        //END OF PROPERTIES
        public Trade()
        {
            InitializeComponent();
        }
        private void Trade_Load(object sender, EventArgs e)
        {
            StopTimer.Start();
            AudioBuy.URL = System.Environment.CurrentDirectory + @"\Sounds\BuyTrade.wav";
            AudioBuy.settings.volume = MainSetting.Default.SoundsVol;
            AudioFail.URL = System.Environment.CurrentDirectory + @"\Sounds\FailTrade.wav";
            AudioFail.settings.volume = MainSetting.Default.SoundsVol;

            coinsInTrade = Settings1.Default.TradeCoins;
            ZobrazeniCoinsInTrade.Text = Convert.ToString(coinsInTrade);
        }

        private void Trade_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void buy1_Click(object sender, EventArgs e)
        {
            ZobrazeniCoinsInTrade.Focus();
            if (coinsInTrade > 9)
            {
                AudioBuy.Ctlcontrols.play();
                coinsInTrade -= 10;
                ZobrazeniCoinsInTrade.Text = Convert.ToString(coinsInTrade);
                Settings1.Default.TradeHeal += Náhoda.Next(10, 50);
                Settings1.Default.TradeCoins = coinsInTrade;
                Settings1.Default.Save();
            }
            else
                AudioFail.Ctlcontrols.play();
        }


        private void buy2_Click(object sender, EventArgs e)
        {
            ZobrazeniCoinsInTrade.Focus();
            if (coinsInTrade > 19 && Settings1.Default.PlayerArmorNow > 0)
            {
                AudioBuy.Ctlcontrols.play();
                coinsInTrade -= 20;
                ZobrazeniCoinsInTrade.Text = Convert.ToString(coinsInTrade);
                Settings1.Default.TradeArmor += Náhoda.Next(10, 50);
                Settings1.Default.TradeCoins = coinsInTrade;
                Settings1.Default.Save();
            }
            else
                AudioFail.Ctlcontrols.play();
        }

        private void poleBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buy3_Click(object sender, EventArgs e)
        {
            ZobrazeniCoinsInTrade.Focus();
            if (coinsInTrade > 4)
            {
                AudioBuy.Ctlcontrols.play();
                coinsInTrade -= 5;
                ZobrazeniCoinsInTrade.Text = Convert.ToString(coinsInTrade);
                Settings1.Default.TradeXP += Náhoda.Next(5, 25);
                Settings1.Default.TradeCoins = coinsInTrade;
                Settings1.Default.Save();
            }
            else
                AudioFail.Ctlcontrols.play();
        }

        private void buy4_Click(object sender, EventArgs e)
        {
            ZobrazeniCoinsInTrade.Focus();
            if (coinsInTrade > 29)
            {
                AudioBuy.Ctlcontrols.play();
                coinsInTrade -= 30;
                ZobrazeniCoinsInTrade.Text = Convert.ToString(coinsInTrade);
                Settings1.Default.TradeSecret = true;
                Settings1.Default.TradeCoins = coinsInTrade;
                Settings1.Default.Save();
            }
            else
                AudioFail.Ctlcontrols.play();
        }
        //
        //ANIMACE BUTTON
        //
        Image pole1 = Properties.Resources.button1;
        Image pole2 = Properties.Resources.button2;
        private void buy1_MouseEnter(object sender, EventArgs e)
        {
            buy1.BackgroundImage = pole2;
        }

        private void buy1_MouseLeave(object sender, EventArgs e)
        {
            buy1.BackgroundImage = pole1;
        }

        private void buy2_MouseEnter(object sender, EventArgs e)
        {
            buy2.BackgroundImage = pole2;
        }

        private void buy2_MouseLeave(object sender, EventArgs e)
        {
            buy2.BackgroundImage = pole1;
        }

        private void buy3_MouseEnter(object sender, EventArgs e)
        {
            buy3.BackgroundImage = pole2;
        }

        private void buy3_MouseLeave(object sender, EventArgs e)
        {
            buy3.BackgroundImage = pole1;
        }

        private void buy4_MouseEnter(object sender, EventArgs e)
        {
            buy4.BackgroundImage = pole2;
        }

        private void buy4_MouseLeave(object sender, EventArgs e)
        {
            buy4.BackgroundImage = pole1;
        }

        private void poleBack_MouseEnter(object sender, EventArgs e)
        {
            poleBack.BackgroundImage = pole2;
        }

        private void poleBack_MouseLeave(object sender, EventArgs e)
        {
            poleBack.BackgroundImage = pole1;
        }

        private void Fokus_Enter(object sender, EventArgs e)
        {
            ZobrazeniCoinsInTrade.Focus();
        }

        private void StopTimer_Tick(object sender, EventArgs e)
        {
            StopTimer.Stop();
            AudioBuy.Ctlcontrols.stop();
            AudioFail.Ctlcontrols.stop();
        }
    }
}
