using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakGame
{
/*
    public class sneak
    {
        private int Headlocation;
        private int Taillocation;
        private String name;

        public sneak(){
            Headlocation = new int();
            Taillocation = new int();
        }

        public void setHead(int Head) {
            Headlocation = Head;
        }
        public int getHead()
        {
            return Headlocation;
        }

        public void setTail(int Tail)
        {
            Taillocation = Tail;
        }
        public int getTail()
        {
            return Taillocation;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return name;
        }

    }
*/

    public partial class Form1 : Form
    {

        private String[] head = new String[3];
        private String[] tail = new String[3];

        private String floor = "Pics\\floor.jpg";
        private String one = "Pics\\one.png";
        private String two = "Pics\\two.png";
        private String three = "Pics\\three.png";
        private String four = "Pics\\four.png";
        private String five = "Pics\\five.png";
        private String six = "Pics\\six.png";
        private String playerone = "Pics\\playerOne.png";
        private String playertwo = "Pics\\playerTwo.png";
        private String starticon = "Pics\\starticon.png";
        private String goalicon = "Pics\\goalicon.png";
        private String top = "Pics\\ratherTop.png";
        private String bottom = "Pics\\ratherBottom.png";
        private String players = "Pics\\players.png";
        private String playeronegoal = "Pics\\playerOnegoal.png";
        private String playertwogoal = "Pics\\playerTwogoal.png";

        private int place1 = 0;
        private int place2 = 0;
        private int[] sneakhead = new int[3];
        
        private int[] sneaktail = new int[3];
     
        private int[] ratherTop = new int[3];
      
        private int[] ratherBottom = new int[3];

        private int time = 0;

        private int count = 1;

        private PictureBox[] box = new PictureBox[30];
        Boolean wow = true;
        Boolean wow2 = true;

        //private char[] field = new char[30];

        //private sneak[] sneaks = new sneak[3];


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int randomX;
           // for (int i = 0; i < 36; i++)
            //{
               // field[i] = 'f';
           // }
                //box[] = {pic1,pic2,pic3,pic4,pic5,pic6,pic7,pic8,pic9,pic10,pic11,pic12,pic13,pic14,pic15,pic16,pic17,pic18,pic19,pic20,pic21,pic22,pic23,pic24,pic25,pic26,pic27,pic28,pic29,pic30};
            head[0] = "Pics\\head.png";
            head[1] = "Pics\\head2.png";
            head[2] = "Pics\\head3.png";

            tail[0] = "Pics\\tail.png";
            tail[1] = "Pics\\tail2.png";
            tail[2] = "Pics\\tail3.png";

            box[0] = pic0;
            box[1] = pic1;
            box[2] = pic2;
            box[3] = pic3;
            box[4] = pic4;
            box[5] = pic5;
            box[6] = pic6;
            box[7] = pic7;
            box[8] = pic8;
            box[9] = pic9;
            box[10] = pic10;
            box[11] = pic11;
            box[12] = pic12;
            box[13] = pic13;
            box[14] = pic14;
            box[15] = pic15;
            box[16] = pic16;
            box[17] = pic17;
            box[18] = pic18;
            box[19] = pic19;
            box[20] = pic20;
            box[21] = pic21;
            box[22] = pic22;
            box[23] = pic23;
            box[24] = pic24;
            box[25] = pic25;
            box[26] = pic26;
            box[27] = pic27;
            box[28] = pic28;
            box[29] = pic29;
            
            
            
            draw(box, 30, floor);
            draw(start1, playerone);
            draw(start2, playertwo);
            draw(goal, goalicon);
        }

        private void startbutton_Click(object sender, EventArgs e)
        {

            if (time == 0)
            {
                Random r = new Random();
                int[] valid = new int[20];
                int i = 0;
                int x = 0, y = 0;
                Boolean flag = true;
                int place = 0;

                for (int j = 0; j < 3; j++)
                {
                    do
                    {

                        sneakhead[j] = r.Next(6,30);
                        if (i != 0)
                        {
                            flag = check(valid, i, sneakhead[j]);
                        }

                    } while (flag != true);
                    valid[i] = sneakhead[j];
                    //sneaks[j].setHead(sneakhead[j]);
                    //sneaks[j].setName("sneak" + j);
                    //field[sneakhead[j]] = 'H';
                    i++;
                    flag = false;

                }

                for (int j = 0; j < 3; j++)
                {
                    do
                    {
                        ratherTop[j] = r.Next(6,30);
                        flag = check(valid, i, ratherTop[j]);
                    } while (flag != true);
                    valid[i] = ratherTop[j];
                    //field[ratherTop[j]] = 'U';
                    i++;
                    flag = false;
                }

                Boolean flag2 = false;
                //I need to fix this 
                for (int j = 0; j < 3; j++)
                {
                    do
                    {
                        sneaktail[j] = r.Next(0, 18);
                        flag2 = check(valid, i, sneaktail[j]);
                        if (flag2 == true)
                        {
                            if(sneakhead[j] < sneaktail[j]){
                                flag2 = false;
                            }
                        }
                        
                    } while (flag2 != true);
                    valid[i] = sneaktail[j];
                    i++;
                    //sneaks[j].setTail(sneaktail[j]);
                    //field[sneaktail[j]] = 'T';
                    flag2 = false;
                }

                for (int j = 0; j < 3; j++)
                {
                    do
                    {
                        ratherBottom[j] = r.Next(0, 18);
                        flag2 = check(valid, i, ratherBottom[j]);
                        if (flag2 == true)
                        {
                            if (ratherTop[j] < ratherBottom[j])
                            {
                                flag2 = false;
                            }
                        }

                    } while (flag2 != true);
                    valid[i] = ratherBottom[j];
                    //field[ratherBottom[j]] = 'D'; 
                    i++;
                    flag2 = false;
                }




                    for (int m = 0; m < 3; m++)
                    {
                        draw(box[sneakhead[m]], head[m]);
                        draw(box[sneaktail[m]], tail[m]);
                        draw(box[ratherTop[m]], top);
                        draw(box[ratherBottom[m]], bottom);

                    }
                time++;
            }


        }




        private void draw(PictureBox[] box,int count,String picture){
            for(int i=0; i<count; i++){
                box[i].SizeMode = PictureBoxSizeMode.StretchImage;
                box[i].Image = Image.FromFile(picture);
            }

        }


        private void draw(PictureBox pic, String picture)
        {
            pic.Image = Image.FromFile(picture);
            pic.SizeMode = PictureBoxSizeMode.StretchImage; 
        }

        private Boolean check(int[] valid, int count,int RandomNumber)
        {
            for (int i = 0; i < count; i++)
            {
                if(valid[i] == RandomNumber){
                    return false;
                }

           }
           return true;
        }



        private void play_Click(object sender, EventArgs e)
        {
            


            Random r2 = new Random();
            int number = r2.Next(1, 7);
            if (number == 1)
            {
                draw(saikoro, one);
            }
            else if (number == 2)
            {
                draw(saikoro, two);
            }
            else if (number == 3)
            {
                draw(saikoro, three);
            }
            else if (number == 4)
            {
                draw(saikoro, four);
            }
            else if (number == 5)
            {
                draw(saikoro, five);
            }
            else
            {
                draw(saikoro, six);
            }


            if ((count % 2) == 0)
            {
                player2(number);
            }
            else
            {
                player1(number);
            }

            count++;


        }

        private void player1(int number)
        {
            int temp;
            if (place1 == 0 && wow == true)
            {
                draw(start1, starticon);
            }
            else
            {
                wow = false;
                draw(box[place1], floor);
            }

            for (int m = 0; m < 3; m++)
            {
                if (sneaktail[m] == place1 && place1 != place2)
                {
                    draw(box[place1], tail[m]);
                }
                if (ratherTop[m] == place1 && place1 != place2)
                {
                    draw(box[place1], top);
                }

            }

            if (place1 != 0)
            {
                if (place1 == place2)
                {
                    draw(box[place1], playertwo);
                }
            }

            temp = place1;

            if (wow == true)
            {
                place1 = place1 + number - 1;
            }
            else
            {
                place1 = place1 + number;
            }

            if (place1 > 30)
            {
                place1 = 0;
            }

            if (place1 == 30)
            {
                if (place1 != place2)
                {
                    draw(goal, playeronegoal);
                }
                else
                {
                    draw(goal, players);
                }
            }
            else
            {

                //field[place1] = 'f';
                name.Text = "Player1";
                for (int m = 0; m < 3; m++)
                {
                    if (sneakhead[m] == place1)
                    {
                        place1 = sneaktail[m];
                    }
                    if (ratherBottom[m] == place1)
                    {
                        place1 = ratherTop[m];
                    }

                }
                if (place2 == place1 && place1 != 0)
                {
                    draw(box[place1], players);
                }
                else if(place1 < 30)
                {
                    draw(box[place1], playerone);

                }
            }
                if (place2 == 30)
                {
                    MessageBox.Show("Player2 win the game");
                    Close();
                }

            
        }


        private void player2(int number)
        {
           
            name.Text = "Player2";
            if (place2 == 0 && wow2 == true)
            {
                draw(start2, starticon);
            }
            else{
                wow2 = false;
                draw(box[place2], floor);
            }

            for(int m = 0; m<3; m++)
            {
                if(sneaktail[m] == place2 && place1 != place2 )
                {
                    draw(box[place2], tail[m]);
                }
                if (ratherTop[m] == place2 && place1 != place2)
                {
                    draw(box[place2], top);
                }
                
            }
            if (place2 != 0)
            {
                if (place1 == place2)
                {
                    draw(box[place2], playerone);
                }
            }

            //field[place2] = 'f';
            if (wow2 == true)
            {
                place2 = place2 + number - 1;
            }
            else
            {
                place2 = place2 + number;
            }
        

            if(place2 > 30)
            {
                place2 = 0;
            }

            if (place2 == 30)
            {
                if (place2 != place1)
                {
                    draw(goal, playertwogoal);
                }
                else
                {
                    draw(goal, players);
                }


            }
            else {

                for (int m = 0; m < 3; m++)
                {
                    if (sneakhead[m] == place2)
                    {
                        place2 = sneaktail[m];
                    }
                    if (ratherBottom[m] == place2)
                    {
                        place2 = ratherTop[m];
                    }
                }

                if (place1 == place2)
                {
                    draw(box[place2], players);
                }
                else {
                    draw(box[place2], playertwo);
                }
            }


            if (place1 == 30)
            {
                MessageBox.Show("Player1 win the game");
                Close();
            }
        }

        private void pic29_Click(object sender, EventArgs e)
        {

        }

        private void pic28_Click(object sender, EventArgs e)
        {

        }

        private void pic26_Click(object sender, EventArgs e)
        {

        }

        private void pic27_Click(object sender, EventArgs e)
        {

        }

        private void pic19_Click(object sender, EventArgs e)
        {

        }

        private void pic24_Click(object sender, EventArgs e)
        {

        }
    }

}
