using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; 


namespace TankBattles.Pages
{
    public partial class StartMenu : Form
    {
        SoundPlayer player = new SoundPlayer(@"D:\c# files\TankBattle_OppProject\Assets\spaceShooterMainBG.wav");
        SoundPlayer player1 = new SoundPlayer(@"D:\c# files\TankBattle_OppProject\Assets\s1.wav");
        SoundPlayer player2 = new SoundPlayer(@"D:\c# files\TankBattle_OppProject\Assets\s2.wav");
        public StartMenu()
        {
            player.Play();
            InitializeComponent();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            player2.Play();
            this.Hide();
            Form f = new MainGame();
            f.Show();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            player1.Play();
            System.Threading.Thread.Sleep(1000);
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form f = new Hangar();
            f.Show();
        }
    }
}
