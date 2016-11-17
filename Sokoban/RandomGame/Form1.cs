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

    public partial class Form1 : Form
    {
        private RandomGame.FormLocation location;
        private String[] front = { "pics\\front\\front1.png", "pics\\front\\front2.png", "pics\\front\\front3.png", "pics\\front\\front4.png" };
        private String[] back = { "pics\\back\\back1.png", "pics\\back\\back2.png", "pics\\back\\back3.png", "pics\\back\\back4.png" };
        private String[] right = { "pics\\right\\right1.png", "pics\\right\\right2.png", "pics\\right\\right3.png", "pics\\right\\right4.png" };
        private String[] left = { "pics\\left\\left1.png", "pics\\left\\left2.png", "pics\\left\\left3.png", "pics\\left\\left4.png" };
        private String[] floor = { "pics\\floor\\box.png", "pics\\floor\\boxTop.png", "pics\\floor\\floor.png", "pics\\floor\\wall.png","pics\\floor\\Fit.png"};
        private PictureBox[] box = new PictureBox[1000];
        private char[] GameField = new char[1000];
        private Image[] image = new Image[16];
        private PictureBox current = new PictureBox();
        private int count, add;
        //private int divede = 16, Number = 256;
        private int divede, Number;
        private int space, size;
        private String tag = "Front";
        private int Index = 0,tempIndex;
        private int score;
        private int FitNumber, BoxNumber, BlankNumber, WallNumber, CharacterNumber = 1;
        private int Level = 0;
        private Boolean judgeLevel = true;
        private int width, height;
        private int windowWidth, windowHeight;
        private int toolHummer=0;
        private Boolean toolflag = true, clickflag = false;

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private int ResetCount=0;
        private GameOver over;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            location = new RandomGame.FormLocation();
            this.Location = new Point(location.width, location.height);
            GenerateRandom();

            over = new GameOver();

            if((Level%3) == 0 && Level != 0)
            {
               
                String text = hummerLabel.Text.ToString().Substring(0, 9);
                toolHummer++;
                if(toolHummer < 10) hummerLabel.Text = text + 0.ToString() + toolHummer.ToString();
                if(toolHummer >= 10) hummerLabel.Text = text + toolHummer.ToString();


            }
            toolflag = true;



            if (Level > 31)
            {
                Level = 31; //limit of level
            }

            if (Level == 0)
            {
                divede = 9;
                width = 3; //Initialization
                height = 4; //Initialization
                Number = divede * divede;
            }
            else
            {
                if (judgeLevel)
                {
                    divede = divede + 1;
                    Number = divede * divede;
                }
            }
            score = 0;
            FitNumber = BoxNumber;
            space = 20;
            size = 40;
            int x = space, y = space;
            count = 0;
            add = 0;
            int a = 0;
            int i = 0;
            int temp = 0;
            for (i = 0; i < front.Length; i++)
            {
                image[i] = Image.FromFile(front[i]);
            }
            temp = i;
            for (; i < back.Length + temp; i++)
            {
                image[i] = Image.FromFile(back[a]);
                a++;
            }
            a = 0;
            temp = i;
            for (; i < right.Length + temp; i++)
            {
                image[i] = Image.FromFile(right[a]);
                a++;
            }
            a = 0;
            temp = i;
            for (; i < left.Length + temp; i++)
            {
                image[i] = Image.FromFile(left[a]);
                a++;
            }

            for (int j = 0; j < Number; j++)
            {
                box[j] = new PictureBox();
                box[j].Name = j.ToString();
                box[j].Image = Image.FromFile(floor[2]);
                box[j].Location = new Point(x, y);
                if ((j + 1) % divede == 0)
                {
                    x = space;
                    y = y + size;
                }
                else
                {
                    x = x + size;
                }
                box[j].Size = new Size(size, size);
                this.Controls.Add(box[j]);
                GameField[j] = 'E';
                box[j].Click += new EventHandler(OnPicClick);
            }

            SettingMaterial(WallNumber, 3, 'W');
            SettingMaterial(BoxNumber, 0, 'B');
            SettingMaterial(BlankNumber, 1, 'H');
            SettingMaterial(CharacterNumber, 0, 'C');

            current = new PictureBox();
            current = box[Index];
            this.Size = new Size((space * width + size * divede), (space * height + size * (Number / divede) + 15)); //15 for hummer

            windowHeight = space * width + size * divede;
            windowWidth = space * height + size * (Number / divede) ;

            hummerLabel.Location = new Point((windowWidth/2)-80,windowHeight-35);
            
            //hummerLabel.Location = new Point(100, 400);
            //MessageBox.Show("Box : " + BoxNumber.ToString() + "\nBlank : " + BlankNumber.ToString() + "\nFitNumber : " + FitNumber.ToString());
        }

        private void OnPicClick(Object sender,EventArgs e)
        {
            String text;
            if (toolHummer > 0 && clickflag == true)
            {
                var Which = (PictureBox)sender;
                current = Which;
                tempIndex = Index;
                Index = Convert.ToInt32(current.Name);
                if (GameField[Index] == 'W')
                {
                    box[Index].Image = Image.FromFile(floor[2]);
                    GameField[Index] = 'E';
                    toolHummer--;
                    this.Cursor = null;
                    text = hummerLabel.Text.ToString().Substring(0, 9);
                    if(toolHummer < 10) hummerLabel.Text = text + 0.ToString() + toolHummer.ToString();
                    if (toolHummer >= 10) hummerLabel.Text = text + toolHummer.ToString();
                }
                Index = tempIndex;
                current = box[Index];
                clickflag = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count == 4)
            {
                count = 0;
            }

            if (tag.Equals("Front"))
            {
                add = 0;
            }
            else if (tag.Equals("Back"))
            {
                add = 4;
            }
            else if (tag.Equals("Right"))
            {
                add = 8;
            }
            else if (tag.Equals("Left"))
            {
                add = 12;
            }

            current.Image = image[count + add];
        }

        private void GenerateRandom(){
            Random rnd = new Random();
            
            if (Level == 0)
            {
                WallNumber = rnd.Next(1, 10) + 5;
                BlankNumber = 1;
                BoxNumber = BlankNumber;
            }
            else
            {
                if (judgeLevel)
                {
                    WallNumber = WallNumber + 5;
                    BlankNumber++;
                    BoxNumber = BlankNumber;
                }
            }
        }

        private void SettingMaterial(int MaxNumber, int picNum, char symbol)
        {
            Random rnd = new Random();
            Boolean flag = true;
            int place = 0;
            if (symbol != 'C')
            {
                for (int a = 0; a < MaxNumber; a++)
                {
                    do
                    {
                        flag = true;
                        if (symbol == 'W')
                        {
                            place = rnd.Next(0, Number);
                        }
                        else
                        {
                            place = rnd.Next(divede, Number - divede);
                            if (place == (((place / divede) + 1) * divede - 1) || place == (place - (place % divede))) flag = false;
                            if (symbol == 'B')
                            {
                                if ((GameField[place - 1] != 'E' && GameField[place + divede] != 'E') || (GameField[place + 1] != 'E' && GameField[place - divede] != 'E') || (GameField[place -1] != 'E' && GameField[place - divede] != 'E') || (GameField[place+1] != 'E' && GameField[place + divede] != 'E')) flag = false;
                            }
                        }
                        
                    } while (GameField[place] != 'E' || flag != true);
                    
                    box[place].Image = Image.FromFile(floor[picNum]);
                    GameField[place] = symbol;
                }
            }
            else
            {
                do
                {
                    place = rnd.Next(0, Number);
                } while (GameField[place] != 'E');
                box[place].Image = image[0];
                Index = place;
                timer1.Start();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            score++;
            if (e.KeyCode == Keys.Down)
            {
                if (Index + divede < Number)
                {
                    if (GameField[Index + divede] == 'W'|| GameField[Index + divede] == 'H')
                    {
                        tag = "Front";
                        return;
                    }
                    //It works well so far.
                    else if (GameField[Index + divede] == 'B')
                    {
                        if (Index + divede + divede >= Number)
                        {
                            tag = "Front";
                            return;
                        }
                        //MessageBox.Show((Index + divede + divede).ToString() + " and " + GameField[Index + divede]);
                        if (!(GameField[Index + divede + divede] == 'W'|| GameField[Index + divede + divede] == 'B'))
                        {

                            //for character
                            current.Image = Image.FromFile(floor[2]);
                            current = box[Index + divede];
                            Index = Convert.ToInt32(current.Name);
                            current.Image = image[0]; // because tag is Front
                            tag = "Front";

                            //for real box
                            GameField[Index] = 'E';
                            box[Index + divede].Image = Image.FromFile(floor[0]);
                            if (GameField[Index + divede] == 'H')
                            {
                                FitNumber--;
                                GameField[Index + divede] = 'F'; // fit
                                box[Index + divede].Image = Image.FromFile(floor[4]);
                                if (FitNumber == 0)
                                {
                                    judgeLevel = true;
                                    Level++;

                                    MessageBox.Show("You Finished Level." + Level.ToString() + "!!\nYour Score is " + score.ToString());
                                    //Close();
                                    destroy();
                                    Form1_Load(sender, e);
                                }
                            }
                            else
                            {
                                GameField[Index + divede] = 'B';
                            }

                        }
                    }
                    else {
                         current.Image = Image.FromFile(floor[2]);
                        current = box[Index + divede];
                        Index = Convert.ToInt32(current.Name);
                        current.Image = image[0]; // tag is Front
                        tag = "Front";
                    }
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if ((Index - divede) > -1)
                {
                    if (GameField[Index - divede] == 'W'|| GameField[Index - divede] == 'H')
                    {
                        tag = "Back";
                        return;
                    }
                    //It works well so far.
                    else if (GameField[Index - divede] == 'B')
                    {
                        if (Index - divede - divede < -1)
                        {
                            tag = "Back";
                            return;
                        }

                        if (!(GameField[Index - divede - divede] == 'W' ||GameField[Index - divede - divede] == 'B'))
                        {
                            //for character
                            current.Image = Image.FromFile(floor[2]);
                            current = box[Index - divede];
                            Index = Convert.ToInt32(current.Name);
                            current.Image = image[4]; //tag is back
                            tag = "Back";

                            //for real box
                            GameField[Index] = 'E';
                            box[Index - divede].Image = Image.FromFile(floor[0]);
                            if (GameField[Index - divede] == 'H')
                            {
                                FitNumber--;
                                GameField[Index - divede] = 'F'; // fit
                                box[Index - divede].Image = Image.FromFile(floor[4]);
                                if (FitNumber == 0)
                                {
                                    judgeLevel = true;
                                    Level++;

                                    MessageBox.Show("You Finished Level." + Level.ToString() + "!!\nYour Score is " + score.ToString());
                                    //Close();
                                    destroy();
                                    Form1_Load(sender, e);
                                }
                            }
                            else
                            {
                                GameField[Index - divede] = 'B';
                            }

                        }
                    }

                    else {
                        current.Image = Image.FromFile(floor[2]);
                        current = box[Index - divede];
                        Index = Convert.ToInt32(current.Name);
                        current.Image = image[4]; //tag is back
                        tag = "Back";
                    }
                }
            }

            else if (e.KeyCode == Keys.Right)
            {
                if ((((Index / divede) + 1) * divede - 1) + 1 > Index + 1)
                {
                    if (GameField[Index + 1] == 'W' || GameField[Index + 1] == 'H')
                    {
                        tag = "Right";
                        return;
                    }
                    //It works well so far.
                    else if (GameField[Index + 1] == 'B')
                    {
                        if (Index + 2 >= (((Index / divede) + 1) * divede - 1) + 1)
                        {
                            tag = "Right";
                            return;
                        }

                        if (!(GameField[Index + 2] == 'W'|| GameField[Index + 2] == 'B'))
                        {
                            //for character
                            current.Image = Image.FromFile(floor[2]);
                            current = box[Index + 1];
                            Index = Convert.ToInt32(current.Name);
                            current.Image = image[8]; // tag is Right
                            tag = "Right";

                            //for real box
                            GameField[Index] = 'E';
                            box[Index + 1].Image = Image.FromFile(floor[0]);
                            if (GameField[Index + 1] == 'H')
                            {
                                FitNumber--;
                                GameField[Index + 1] = 'F'; // fit
                                box[Index + 1].Image = Image.FromFile(floor[4]);
                                if (FitNumber == 0)
                                {
                                    judgeLevel = true;
                                    Level++;

                                    MessageBox.Show("You Finished Level." + Level.ToString() + "!!\nYour Score is " + score.ToString());
                                    //Close();
                                    destroy();
                                    Form1_Load(sender, e);
                                }
                            }
                            else
                            {
                                GameField[Index + 1] = 'B';
                            }
                        }
                    }


                    else {
                        current.Image = Image.FromFile(floor[2]);
                        current = box[Index + 1];
                        Index = Convert.ToInt32(current.Name);
                        current.Image = image[8]; //tag is Right
                        tag = "Right";
                    }

                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                if ((Index - (Index % divede)) - 1 < Index - 1)
                {
                    if (GameField[Index - 1] == 'W' || GameField[Index - 1] == 'H')
                    {
                        tag = "Left";
                        return;
                    }

                    //It works well so far.
                    else if (GameField[Index - 1] == 'B')
                    {
                        if (Index - 2 <= (Index - (Index % divede)) - 1)
                        {
                            tag = "Left";
                            return;
                        }

                        if (!(GameField[Index - 2] == 'W'|| GameField[Index - 2] == 'B'))
                        {
                            //for character
                            current.Image = Image.FromFile(floor[2]);
                            current = box[Index - 1];
                            Index = Convert.ToInt32(current.Name);
                            current.Image = image[12]; // tag is Left
                            tag = "Left";

                            //for real box
                            GameField[Index] = 'E';
                            box[Index - 1].Image = Image.FromFile(floor[0]);
                            if (GameField[Index - 1] == 'H')
                            {
                                FitNumber--;
                                GameField[Index - 1] = 'F'; // fit
                                box[Index - 1].Image = Image.FromFile(floor[4]);
                                if (FitNumber == 0)
                                {
                                    judgeLevel = true;
                                    Level++;
                                    MessageBox.Show("You Finished Level." + Level.ToString() + "!!\nYour Score is " + score.ToString());
                                    //Close();
                                    destroy();
                                    Form1_Load(sender, e);
                                }
                            }
                            else
                            {
                                GameField[Index - 1] = 'B';
                            }
                        }
                    }

                    else {
                        current.Image = Image.FromFile(floor[2]);
                        current = box[Index - 1];
                        Index = Convert.ToInt32(current.Name);
                        current.Image = image[12]; // tag is Left
                        tag = "Left";
                    }
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                DialogResult R = MessageBox.Show("Are you Sure that you want to reset the field?", "Cancelling Reservation", MessageBoxButtons.YesNo);
                if (R == DialogResult.Yes)
                {
                    judgeLevel = false;
                    destroy();
                    Form1_Load(sender, e);
                    toolflag = false;
                    ResetCount++;
                    if(ResetCount == 5)
                    {
                        over.Size = new Size(this.Width, this.Height);
                        over.Show();
                        this.Visible = false;
                    }
                }
                else
                {
                    return;
                }

            } else if (e.KeyCode == Keys.H) // for Hummer
            {
                if (toolHummer > 0)
                {
                    clickflag = true;
                    this.Cursor = Cursors.Cross;
                    return;
                }
                else
                {
                    MessageBox.Show("Now You can not use Hummer...");
                }
            }
        }

        
        private void destroy()
        {
            for(int a=0; a< Number; a++)
            {
                this.Controls.Remove(box[a]);
                if(a < 16)
                {
                    image[a] = null;
                }
            }
            this.Controls.Remove(current);
        }



    }
}
