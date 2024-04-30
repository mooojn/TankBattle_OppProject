using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameProject;
using TankBattles.Properties;

namespace TankBattles
{
    public partial class Form1 : Form
    {
        Game game;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(10, this);

            //game.addGameObject(Resources.Rock4_1, 40, 10, false);
            //game.addGameObject(Resources.Rock4_2, 240, 10, false);
            //game.addGameObject(Resources.Rock4_3, 340, 10, false);
            //game.addGameObject(Resources.Rock4_4, 440, 10, false);
            //game.addGameObject(Resources.Rock4_5, 540, 10, false);
            game.addGameObject(Resources.Rock4_1_no_shadow, 40, 10, false);
            game.addGameObject(Resources.Rock4_2_no_shadow, 140, 10, true);
            game.addGameObject(Resources.Rock4_3_no_shadow, 240, 10, false);
            game.addGameObject(Resources.Rock4_4_no_shadow, 340, 10, true); 
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            game.update();
        }
    }
}
