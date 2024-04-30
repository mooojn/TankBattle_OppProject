using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GameFrameWorkLibrary
{
    public class GameObject
    {
        public PictureBox PicBox;
        public bool IsGravityEnabled = false;
        public GameObject(Image img, int left, int top, bool IsGravityEnabled)
        {
            this.PicBox = new PictureBox();
            this.PicBox.Image = img;
            this.PicBox.Width = img.Width;
            this.PicBox.Height = img.Height;
            this.PicBox.BackColor = Color.Transparent;
            this.PicBox.Left = left;
            this.PicBox.Top = top;
            this.IsGravityEnabled = IsGravityEnabled;
        }
        public void update(int gravity)
        {
            if (IsGravityEnabled)
            {
                PicBox.Top += gravity;
            }
        }
    }
}
