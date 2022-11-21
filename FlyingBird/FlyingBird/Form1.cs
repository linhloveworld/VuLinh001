using System;
using System.Drawing;
using System.Windows.Forms;

namespace FlyingBird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Move(Player, e);
        }

        new void Move(object sender, KeyEventArgs e)
        {
            PictureBox chim = sender as PictureBox;
            Point newPoint = new Point(chim.Location.X, chim.Location.Y);
            bool isMove = false;
            switch (e.KeyCode)
            {
                case Keys.Right:
                    if (newPoint.X + Contain.PlayerSpeed + chim.Size.Width < Size.Width)
                    {
                        newPoint.X += Contain.PlayerSpeed;
                        isMove = true;
                    }
                    break;
                case Keys.Left:
                    if (newPoint.X - Contain.PlayerSpeed > 0)
                    {
                        newPoint.X -= Contain.PlayerSpeed;
                        isMove = true;
                    }

                    break;
                case Keys.Up:
                    if (newPoint.Y - Contain.PlayerSpeed > 0)
                    {
                        newPoint.Y -= Contain.PlayerSpeed;
                        isMove = true;
                    }

                    break;
                case Keys.Down:
                    if (newPoint.Y + Contain.PlayerSpeed + chim.Size.Height +
                        Contain.TitleBarHeight < this.Size.Height)
                    {
                        newPoint.Y += Contain.PlayerSpeed;
                        isMove = true;
                    }
                    break;
                default:
                    break;
            }
            if (isMove)
            {
                chim.Location = newPoint;
            }
        }
        
        /*bool isIdle = false;
        private void PlayerAnimation_Tick(object sender,EventArgs e)
        {
            if (isIdle)
            {
                Player.BackgroundImage = Properties.Resources.<hinhmoi>;
            }
            else
            {
                Player.BackgroundImage = Properties.Resources.<hinhmoi>;
            }
            isIdle = !isIdle;
        }*/
    }
}
