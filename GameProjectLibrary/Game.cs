using GameFrameWorkLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using GameProject.Enums;

namespace GameProject
{
    public class Game
    {
        // attributes
        public static int score;
        int gravity;
        List<GameObject> gameObjects;
        List<CollisionDetection> collisions;
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
            this.collisions = new List<CollisionDetection>();
        }
        public void addGameObject(GameObject obj)
        {   
            gameObjects.Add(obj);
            container.Controls.Add(obj.PicBox);
            gameObjectsCount++;
        }   
        public void removeGameObject(GameObject obj)
        {
            gameObjects.Remove(obj);
            container.Controls.Remove(obj.PicBox);
            gameObjectsCount--;
        }
        public void addCollision(CollisionDetection collision)
        {
            collisions.Add(collision);
        }
        //public void update()
        //{
        //    foreach (GameObject obj in gameObjects)
        //    {
        //        obj.update(gravity);
        //        foreach (GameObject obj2 in gameObjects)
        //        {
        //            if (obj2.type == GameObjectType.Player)
        //            {
        //                foreach (CollisionDetection c in collisions)
        //                {
        //                    c.IsCollide(obj.PicBox, obj2.PicBox);
        //                }
        //            }
        //        }
        //    }
        //}
        public void update()
        {
            for (int i = 0; i < gameObjects.Count; i++)
            {
                GameObject obj = gameObjects[i];
                obj.update(gravity);

                if (obj.type == GameObjectType.Player)
                {
                    for (int j = 0; j < gameObjects.Count; j++)
                    {
                        if (i != j) // Avoid self-collision check
                        {
                            GameObject obj2 = gameObjects[j];
                            if (obj2.type != GameObjectType.Player)
                            {
                                foreach (CollisionDetection c in collisions)
                                {
                                    if (c.IsCollide(obj.PicBox, obj2.PicBox))
                                    {
                                        c.Collide(obj2.type);
                                        removeGameObject(obj2);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public int GetObjectsCount()
        {
            return gameObjectsCount;
        }
        //public int GetScore()
        //{
        //    return score;
        //}
        //public void SetScore(int score)
        //{
        //    this.score = score;
        //}
    }
}
