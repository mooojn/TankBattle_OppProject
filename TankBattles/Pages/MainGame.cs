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
using GameProject;
using GameProject.Movements;
using TankBattles.CustomMovement;
using GameFrameWorkLibrary;
using GameProject.Enums;


namespace TankBattles
{
    public partial class MainGame : Form
    {
        Game game;
        List<Image> objectImages = new List<Image>();
        List<Image> playerImages = new List<Image>();

        public MainGame()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            // objs
            objectImages.Add(Resources.Meteor_01);
            objectImages.Add(Resources.Meteor_02);
            objectImages.Add(Resources.Meteor_09);
            objectImages.Add(Resources.Meteor_10);
            // plrs
            playerImages.Add(Resources.Ship5);  // player ship
            // enemy ships
            playerImages.Add(Resources.Ship2);
            playerImages.Add(Resources.Ship3);
            playerImages.Add(Resources.Ship4);    
            playerImages.Add(Resources.Ship6);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            game = Game.getInstance(this);
            Point boundary = new Point(this.Width, this.Height);
            
            game.addGameObject(new GameObject(GameObjectType.SmallObstacle, objectImages[0], 1040, 80,  new HorizontalPatrol(20, Direction.Left, boundary)));
            game.addGameObject(new GameObject(GameObjectType.MidObstacle, objectImages[1], 1140, 40, new HorizontalPatrol(15, Direction.Left,boundary)));
            game.addGameObject(new GameObject(GameObjectType.BigObstacle, objectImages[2], 440, 10, new VerticalPatrol(12, Direction.Up, boundary)));
            
            //game.addGameObject(new GameObject(GameObjectType.SmallObstacle , objectImages[3], 340, 10, new ZigZagMovement(10, Direction.Up, boundary)));
            
            ////player
            game.addGameObject(new GameObject(GameObjectType.Player, playerImages[0], 220, 100, new KeyboardMovement(10, boundary), false));
            
            game.addCollision(new CollisionDetection(GameObjectType.Player, GameObjectType.SmallObstacle, GameAction.DecreaseSmallScore));
            game.addCollision(new CollisionDetection(GameObjectType.Player, GameObjectType.MidObstacle, GameAction.DecreaseMidScore));
            game.addCollision(new CollisionDetection(GameObjectType.Player, GameObjectType.BigObstacle, GameAction.DecreaseBigScore));





            // enemy
            //game.addGameObject(new GameObject(playerImages[1], 640, 10, new KeyboardMovement(10, boundary)));
            //game.addGameObject(new GameObject(playerImages[2], 740, 10, new KeyboardMovement(10, boundary)));
            //game.addGameObject(new GameObject(playerImages[3], 840, 10, new KeyboardMovement(10, boundary)));
            //game.addGameObject(new GameObject(playerImages[4], 940, 10, new KeyboardMovement(10, boundary)));
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            game.update();
            objectCount.Text = game.GetObjectsCount().ToString();
            score.Text = Game.score.ToString();
        }
    }
}
