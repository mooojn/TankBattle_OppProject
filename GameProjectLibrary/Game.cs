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
        // attributes
        int gravity;
        List<GameObject> gameObjects;
        Form container;
        int gameObjectsCount;
        // singleton instance
        private static Game instance = null;
        public static Game getInstance(Form container, int gravity = 10)
        {
            if (instance == null)
            {
                instance = new Game(container, gravity);
            }
            return instance;
        }
        // constructor
        private Game(Form container, int gravity)
        {
            this.gravity = gravity;
            this.container = container;
            this.gameObjects = new List<GameObject>();
        }
        public void addGameObject(GameObject obj)
        {   
            gameObjects.Add(obj);
            container.Controls.Add(obj.PicBox);
            gameObjectsCount++;
        }   
        public void update()
        {
            foreach (GameObject obj in gameObjects)
            {
                obj.update(gravity);
            }
        }
        public int GetObjectsCount()
        {
            return gameObjectsCount;
        }
    }
}
