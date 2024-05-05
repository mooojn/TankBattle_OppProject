using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TankBattles.Properties;

namespace TankBattles
{
    public partial class Hangar : Form
    {
        public static Image shipChoice = Properties.Resources.Ship5;
        public Hangar()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            shipChoice = Properties.Resources.Ship4;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            shipChoice = Properties.Resources.Ship3;
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            shipChoice = Properties.Resources.Ship5;
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            shipChoice = Properties.Resources.Ship6;
            this.Close();
        }
        private void Hangar_Load(object sender, EventArgs e)
        {

        }
    }
}
