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
    public partial class AudioPlayer : Form
    {
        public AudioPlayer()
        {
            InitializeComponent();
        }

        private void AudioPlayer_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer2.Ctlcontrols.stop();
            axWindowsMediaPlayer3.Ctlcontrols.stop();
        }

        public void SoundUpdate_Tick(object sender, EventArgs e)
        {
            SoundUpdate.Stop();

            MessageBox.Show("něco");
            if (MainSetting.Default.playMenuSoundtrack == true)
                axWindowsMediaPlayer1.Ctlcontrols.play();
            else
                axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
    }
}
