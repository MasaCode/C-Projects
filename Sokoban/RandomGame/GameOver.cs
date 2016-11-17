using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomGame
{
    public partial class GameOver : Form
    {
        private RandomGame.FormLocation location;
        
        //private int windowWidth, windowHeight;

        public GameOver()
        {
            InitializeComponent();
        }
        /*
        public GameOver(int playWidth,int playHeight){
            this.Size = new Size(playWidth, playHeight);
            windowWidth = playWidth;
            windowHeight = playHeight;
        }
        */

        private void GameOver_Load(object sender, EventArgs e)
        {
            location = new RandomGame.FormLocation();
            
            
            window.Size = new Size(this.Width,this.Height);
            this.Location = new Point(location.width, location.height);
            window.SizeMode = PictureBoxSizeMode.StretchImage;
            window.Image = Image.FromFile("pics\\gameover.png");
            //this.BackColor = Color.Red;
        }

        private void GameOver_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                //Close();
                Environment.Exit(0);
            }
        }

        private void GameOver_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
