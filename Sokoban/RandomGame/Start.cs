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
    public partial class Start : Form
    {
        private Form1 playGame;
        private RandomGame.FormLocation location;

        public Start()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            playGame.Show();
            this.Visible = false;
        }

        private void Start_Load(object sender, EventArgs e)
        {
            Image background = Image.FromFile("pics\\StartWindow.png");

            location = new RandomGame.FormLocation();
            this.Location = new Point(location.width, location.height);
            playGame = new Form1();
            //this.BackgroundImage = Image.FromFile("pics\\StartWindow.png");
            this.BackgroundImage = background;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Drop the box to blank.\n2.When you reset 5 times, player loses.\n3.Reset : push 'Enter' key.\n4.Hummer : push 'H' key");
        }

        private void Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
