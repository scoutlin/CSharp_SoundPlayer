using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoundPlayer {
    public partial class SoundPlayer : Form {

        SoundPlayerDll.SoundPlayerDll gSoundPlayerDll;

        public SoundPlayer() {
            InitializeComponent();           
        }

        private void Init() {
            gSoundPlayerDll = new SoundPlayerDll.SoundPlayerDll();
            gSoundPlayerDll.SetSoundPath(textBox_SoundPath.Text);
        }

        private void SoundPlayer_Load(object sender, EventArgs e) {
            Init();
        }

        private void button_PlaySound_Click(object sender, EventArgs e) {
            gSoundPlayerDll.Play();
        }

        private void button_StopSound_Click(object sender, EventArgs e) {
            gSoundPlayerDll.Stop();
        }

        private void button_VolumeDown_Click(object sender, EventArgs e) {
            gSoundPlayerDll.VolDown();
        }

        private void button_VolumeUp_Click(object sender, EventArgs e) {
            gSoundPlayerDll.VolUp();
        }

        private void button_Mute_Click(object sender, EventArgs e) {
            gSoundPlayerDll.Mute();
        }
    }
}
