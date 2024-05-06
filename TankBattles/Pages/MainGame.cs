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
using System.Media;
using NAudio.Wave;

namespace TankBattles
{
    public partial class MainGame : Form
    {
        SoundPlayer hitFX = new SoundPlayer(@"D:\c# files\TankBattle_OppProject\Assets\hitSound.wav");
        Game game;
        List<Image> objectImages = new List<Image>();
        List<Image> playerImages = new List<Image>();
        List<GameObjectType> objTypes = new List<GameObjectType>();
        Point boundary;
        
        private WaveOutEvent player;
        private AudioFileReader audioFile;

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
            // obj types
            objTypes.Add(GameObjectType.SmallObstacle);
            objTypes.Add(GameObjectType.MidObstacle);
            objTypes.Add(GameObjectType.BigObstacle);

            gameLoop.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            string filePath = @"D:\c# files\TankBattle_OppProject\Assets\mainBG.mp3";

            player = new WaveOutEvent();
            audioFile = new AudioFileReader(filePath);
            player.Init(audioFile);

            // Start playing the MP3 file in the background
            player.Play();


            game = Game.getInstance(this);
            game.setForm(this);
            boundary = new Point(this.Width, this.Height - 125);

            game.addGameObject(new GameObject(objTypes[0], objectImages[0], 1040, 80,  new HorizontalPatrol(20, Direction.Left, boundary)));
            game.addGameObject(new GameObject(objTypes[1], objectImages[1], 1140, 40, new HorizontalPatrol(15, Direction.Left,boundary)));
            game.addGameObject(new GameObject(objTypes[2], objectImages[2], 440, 80, new HorizontalPatrol(12, Direction.Left, boundary)));
            
            //game.addGameObject(new GameObject(GameObjectType.SmallObstacle , objectImages[3], 340, 10, new ZigZagMovement(10, Direction.Up, boundary)));
            
            ////player
            game.addGameObject(new GameObject(GameObjectType.Player, Hangar.shipChoice, 50, 250, new KeyboardMovement(20, boundary), false));
            
            game.addCollision(new CollisionDetection(GameObjectType.Player, objTypes[0], GameAction.DecreaseSmallScore));
            game.addCollision(new CollisionDetection(GameObjectType.Player, objTypes[1], GameAction.DecreaseMidScore));
            game.addCollision(new CollisionDetection(GameObjectType.Player, objTypes[2], GameAction.DecreaseBigScore));

        }
        int i = 0;
        int difficulty = 60;
        int maxObsCount = 3;
        int minObsCount = 0;
        private void gameLoop_Tick(object sender, EventArgs e)
        {
            game.update();
            objectCount.Text = game.GetObjectsCount().ToString();
            if (Convert.ToInt32(score.Text) > Game.score)   // player has faced an obstacle
            {
                hitFX.Play();   
            }
            score.Text = Game.score.ToString();

            // add random objects
            i++;
            if (i == difficulty)
            {
                Random rnd = new Random();
                GameObject player = game.getPlayer();

                // Add one obstacle directly towards the ship
                int speedTowardsShip = rnd.Next(15, 30);
                int distanceL = rnd.Next(1000, 1200);
                game.addGameObject(new GameObject(GameObjectType.SmallObstacle, objectImages[rnd.Next(0, 3)], player.PicBox.Left + distanceL, player.PicBox.Top, new HorizontalPatrol(speedTowardsShip, Direction.Left, boundary)));

                int obstacleCount = rnd.Next(minObsCount, maxObsCount);
                for (int j = 0; j < obstacleCount; j++)
                {
                    int speed = rnd.Next(15, 30);
                    int distanceLSpread = rnd.Next(1000, 1200); 
                    int distanceT = rnd.Next(0, 200);
                    game.addGameObject(new GameObject(objTypes[rnd.Next(0, 3)], objectImages[rnd.Next(0, 3)], player.PicBox.Left + distanceLSpread, player.PicBox.Top + distanceT, new HorizontalPatrol(speed, Direction.Left, boundary)));
                }

                i = 0;
                if (difficulty > 15)
                    difficulty -= 5;
                if (difficulty == 40)
                    minObsCount++;
                if (difficulty == 20)
                {
                    maxObsCount++;
                }
            }

            // game over
            if (Convert.ToInt32(score.Text) < 0)
            {
                player.Stop();
                player.Dispose();
                audioFile.Dispose();

                gameLoop.Enabled = false;
                game.Restart();
                this.Close();
                GameOver f = new GameOver();
                f.Show();
            }
        }

        private void objectCount_Click(object sender, EventArgs e)
        {

        }

        private void score_Click(object sender, EventArgs e)
        {

        }
    }
}
