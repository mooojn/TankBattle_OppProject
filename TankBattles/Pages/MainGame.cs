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
using GameProject.Movements;
using TankBattles.CustomMovement;
using TankBattles.Properties;
using GameFrameWorkLibrary;


namespace TankBattles
{
    public partial class MainGame : Form
    {
        Game game;
        List<Image> objectImages = new List<Image>();
        
        public MainGame()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            // objs
            objectImages.Add(Resources.Rock4_1_no_shadow);
            objectImages.Add(Resources.Rock4_2_no_shadow);
            objectImages.Add(Resources.Rock4_3_no_shadow);
            objectImages.Add(Resources.Rock4_4_no_shadow);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            game = Game.getInstance(this);
            Point boundary = new Point(this.Width, this.Height);
            
            game.addGameObject(new GameObject(objectImages[0], 40, 10, new HorizontalPatrol(10, Direction.Down, boundary)));
            game.addGameObject(new GameObject(objectImages[1], 140, 10, new VerticalPatrol(10, Direction.Left, boundary)));
            game.addGameObject(new GameObject(objectImages[2], 240, 10, new ZigZagMovement(10, Direction.Up, boundary)));
            game.addGameObject(new GameObject(objectImages[3], 340, 10, new KeyboardMovement(10, boundary)));
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            game.update();
            objectCount.Text = game.GetObjectsCount().ToString();
        }
    }
}
