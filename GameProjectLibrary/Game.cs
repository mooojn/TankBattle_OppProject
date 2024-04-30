using GameFrameWorkLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GameProject
{
    public class Game
    {
        int gravity = 10;
        List<GameObject> gameObjects;
        Form container;
        public Game(int gravity, Form container)
        {
            this.gravity = gravity;
            this.container = container;
            this.gameObjects = new List<GameObject>();
        }
        public void addGameObject(Image img, int left, int top, bool isGravityEnabled)
        {   
            GameObject obj = new GameObject(img, left, top, isGravityEnabled);
            gameObjects.Add(obj);
            container.Controls.Add(obj.PicBox);
        }   
        public void update()
        {
            foreach (GameObject obj in gameObjects)
            {
                obj.update(gravity);
            }
        }
    }
}
