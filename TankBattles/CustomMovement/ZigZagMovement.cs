using GameProject;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TankBattles.CustomMovement
{
    internal class ZigZagMovement : IMovement
    {
        private int speed;
        private Direction direction;
        private Point boundary;
        private int count;
        private int offset = 90;
        public ZigZagMovement(int speed, Direction direction, Point boundary)
        {
            this.speed = speed;
            this.direction = direction;
            this.boundary = boundary;
            this.count = 0;
        }
        public Point move(Point location)
        {
            if (direction == Direction.Right)
            {
                if (count < 5)
                {
                    location.X += speed;
                    location.Y -= speed;
                }
                else if (count >= 5 && count < 10)
                {
                    location.X += speed;
                    location.Y += speed;
                }
            }
            else if (direction == Direction.Left)
            {
                if (count < 5)
                {
                    location.X -= speed;
                    location.Y += speed;
                }
                else if (count >= 5 && count < 10)
                {
                    location.X -= speed;
                    location.Y -= speed;
                }
            }
            if ((location.Y + offset) >= boundary.Y)
            {
                direction = Direction.Left;
            }
            else if (location.Y - speed <= 0)
            {
                direction = Direction.Right;
            }
            if (count == 10)
            {
                count = 0;
            }
            count++;
            return location;
        }
    }
}
