using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Fast_Furious
{
    public partial class Level3 : Form
    {
        private Player firstPlayer, seconedPlayer;
        private int score1, score2, duration1, duration2;
        private bool is_W_Key = false;
        private bool is_D_Key = false;
        private bool is_S_Key = false;
        private bool is_A_Key = false;
        private bool is_Up_Key = false;
        private bool is_Down_Key = false;
        private bool is_Right_Key = false;
        private bool is_Left_Key = false;
        private int car1X, car2X, car1Y, car2Y;
        private bool car1Finsh = false;
        private bool car2Finsh = false;
        private bool isCoin1 = true;
        private bool isCoin2 = true;
        private bool isCoin3 = true;
        private bool isCoin4 = true;
        private bool notFailed = true;
        private ImageList Image1, Image2;


        private int car1Speed = 5;
        private int car2Speed = 5;
        public Level3(Player firstPlayer, Player seconedPlayer)
        {

            this.firstPlayer = firstPlayer;
            this.seconedPlayer = seconedPlayer;
            score1 = firstPlayer.Score;
            score2 = seconedPlayer.Score;
            duration1 = firstPlayer.Duration;
            duration2 = seconedPlayer.Duration;


            ///////////////////////////////////
            this.KeyDown += Level3_KeyDown;
            this.KeyUp += Level3_KeyUp;
            this.KeyPreview = true;
            InitializeComponent();
            car1X = pictureBox1.Location.X;
            car1Y = pictureBox1.Location.Y;
            car2X = pictureBox2.Location.X;
            car2Y = pictureBox2.Location.Y;

        }
        private void Level3_Load(object sender, EventArgs e)
        {
            label1.Text = "Player1: " + firstPlayer.Name;
            label2.Text = "Player2: " + seconedPlayer.Name;
            label4.Text = "Player1 Score: " + score1;
            label5.Text = "Player2 Score: " + score2;
            label6.Text = "Time(s) :" + level0.totalDuration;
            if (firstPlayer.Color.Equals("Orange"))
            {
                Image1 = Orange;
            }
            else if (firstPlayer.Color.Equals("Blue"))
            {
                Image1 = Blue;
            }
            else
            {
                Image1 = Green;
            }
            if (seconedPlayer.Color.Equals("Orange"))
            {
                Image2 = Orange;
            }
            else if (seconedPlayer.Color.Equals("Blue"))
            {
                Image2 = Blue;
            }
            else
            {
                Image2 = Green;
            }
            pictureBox1.BackgroundImage = Image1.Images[0];
            pictureBox2.BackgroundImage = Image2.Images[0];
            ReadyTimer.Start();
        }
        public Level3()
        {
            score1 = score2 = duration1 = duration2 = 0;
            //this.firstPlayer = Program.Players[0];
            //this.seconedPlayer = Program.Players[1];
            this.firstPlayer = new Player("Computer1", "Male", "age", "Red");
            this.seconedPlayer = new Player("Computer2", "Female", "age", "blue");
            this.seconedPlayer = seconedPlayer;
            ///////////////////////////////////
            this.KeyDown += Level3_KeyDown;
            this.KeyUp += Level3_KeyUp;
            this.KeyPreview = true;
            InitializeComponent();
            car1X = pictureBox1.Location.X;
            car1Y = pictureBox1.Location.Y;
            car2X = pictureBox2.Location.X;
            car2Y = pictureBox2.Location.Y;

        }

        private void moveC2Timer_Tick(object sender, EventArgs e)
        {
            moveCar("car2");
        }

        private void moveC1Timer_Tick(object sender, EventArgs e)
        {
            moveCar("car1");

        }

        private void Computer1Timer_Tick_1(object sender, EventArgs e)
        {
            
            if (car1X >= 400 && car1X <= 818 && car1Y >= 445 && car1Y <= 460)
            {
                car1X += car1Speed;
                pictureBox1.Location = new Point(car1X, car1Y);
                pictureBox1.Image = Image1.Images[0];

            }
            else if (car1X >= 796 && car1X <= 828 && car1Y >= 232 && car1Y <= 450)
            {
                car1Y -= car1Speed;
                pictureBox1.Location = new Point(car1X, car1Y);
                pictureBox1.Image = Image1.Images[3];
            }
            else if (car1X >= 796 && car1X <= 960 && car1Y >= 204 && car1Y <= 232)
            {
                car1X += car1Speed;
                pictureBox1.Location = new Point(car1X, car1Y);
                pictureBox1.Image = Image1.Images[0];
            }
            else if (car1X >= 940 && car1X <= 968 && car1Y >= 36 && car1Y <= 232)
            {
                car1Y -= car1Speed;
                pictureBox1.Location = new Point(car1X, car1Y);
                pictureBox1.Image = Image1.Images[3];
            }
            else if (car1X >= 670 && car1X <= 966 && car1Y >= 30 && car1Y <= 54)
            {
                car1X -= car1Speed;
                pictureBox1.Location = new Point(car1X, car1Y);
                pictureBox1.Image = Image1.Images[2];
            }
            else if (car1X >= 660 && car1X <= 675 && car1Y >= 28 && car1Y <= 130)
            {
                car1Y += car1Speed;
                pictureBox1.Location = new Point(car1X, car1Y);
                pictureBox1.Image = Image1.Images[1];
            }
            else if (car1X >= 570 && car1X <= 673 && car1Y >= 120 && car1Y <= 140)
            {
                car1X -= car1Speed;
                pictureBox1.Location = new Point(car1X, car1Y);
                pictureBox1.Image = Image1.Images[2];
            }
            else if (car1X >= 540 && car1X <= 610 && car1Y >= 30 && car1Y <= 140)
            {
                car1Y -= car1Speed;
                pictureBox1.Location = new Point(car1X, car1Y);
                pictureBox1.Image = Image1.Images[3];
            }
            else if (car1X >= 305 && car1X <= 610 && car1Y >= 20 && car1Y <= 90)
            {
                car1X -= car1Speed;
                pictureBox1.Location = new Point(car1X, car1Y);
                pictureBox1.Image = Image1.Images[2];
            }
            else if (car1X >= 110 && car1X <= 350 && car1Y >= 20 && car1Y <= 175)
            {
                car1Y += car1Speed;
                pictureBox1.Location = new Point(car1X, car1Y);
                pictureBox1.Image = Image1.Images[1];
            }
            else if (car1X >= 60 && car1X <= 350 && car1Y >= 170 && car1Y <= 180)
            {
                car1X -= car1Speed;
                pictureBox1.Location = new Point(car1X, car1Y);
                pictureBox1.Image = Image1.Images[2];
            }
            else if (car1X >= 50 && car1X <= 110 && car1Y >= 170 && car1Y <= 315)
            {
                car1Y += car1Speed;
                pictureBox1.Location = new Point(car1X, car1Y);
                pictureBox1.Image = Image1.Images[1];
            }
            else if (car1X >= 50 && car1X <= 168 && car1Y >= 170 && car1Y <= 350)
            {
                car1X += car1Speed;
                pictureBox1.Location = new Point(car1X, car1Y);
                pictureBox1.Image = Image1.Images[0];
            }
            else if (car1X >= 130 && car1X <= 178 && car1Y >= 170 && car1Y <= 435)
            {
                car1Y += car1Speed;
                pictureBox1.Location = new Point(car1X, car1Y);
                pictureBox1.Image = Image1.Images[1];
            }
            else if (car1X >= 130 && car1X <= 310 && car1Y >= 400 && car1Y <= 445)
            {
                car1X += car1Speed;
                pictureBox1.Location = new Point(car1X, car1Y);
                pictureBox1.Image = Image1.Images[0];
            }
            else if (car1X >= 130 && car1X <= 320 && car1Y >= 340 && car1Y <= 445)
            {
                car1Y -= car1Speed;
                pictureBox1.Location = new Point(car1X, car1Y);
                pictureBox1.Image = Image1.Images[3];
            }
            else if (car1X >= 130 && car1X <= 408 && car1Y >= 330 && car1Y <= 410)
            {
                car1X += car1Speed;
                pictureBox1.Location = new Point(car1X, car1Y);
                pictureBox1.Image = Image1.Images[0];
            }
            else if (car1X >= 400 && car1X <= 415 && car1Y >= 330 && car1Y <= 445)
            {
                car1Y += car1Speed;
                pictureBox1.Location = new Point(car1X, car1Y);
                pictureBox1.Image = Image1.Images[1];
            }
            getCoins();
            finsh();
        }

        private void Computer2Timer_Tick(object sender, EventArgs e)
        {

            if (car2X >= 400 && car2X <= 800 && car2Y >= 420 && car2Y <= 440)
            {
                car2X += car2Speed;
                pictureBox2.Location = new Point(car2X, car2Y);
                pictureBox2.Image = Image2.Images[0];

            }
            else if (car2X >= 750 && car2X <= 805 && car2Y >= 215 && car2Y <= 440)
            {
                car2Y -= car2Speed;
                pictureBox2.Location = new Point(car2X, car2Y);
                pictureBox2.Image = Image2.Images[1];
            }
            else if (car2X >= 750 && car2X <= 933 && car2Y >= 205 && car2Y <= 270)
            {
                car2X += car2Speed;
                pictureBox2.Location = new Point(car2X, car2Y);
                pictureBox2.Image = Image2.Images[0];
            }
            else if (car2X >= 900 && car2X <= 950 && car2Y >= 57 && car2Y <= 250)
            {
                car2Y -= car2Speed;
                pictureBox2.Location = new Point(car2X, car2Y);
                pictureBox2.Image = Image2.Images[1];
            }
            else if (car2X >= 700 && car2X <= 950 && car2Y >= 40 && car2Y <= 60)
            {
                car2X -= car2Speed;
                pictureBox2.Location = new Point(car2X, car2Y);
                pictureBox2.Image = Image2.Images[2];
            }
            else if (car2X >= 690 && car2X <= 720 && car2Y >= 40 && car2Y <= 157)
            {
                car2Y += car2Speed;
                pictureBox2.Location = new Point(car2X, car2Y);
                pictureBox2.Image = Image2.Images[1];
            }
            else if (car2X >= 545 && car2X <= 720 && car2Y >= 140 && car2Y <= 170)
            {
                car2X -= car2Speed;
                pictureBox2.Location = new Point(car2X, car2Y);
                pictureBox2.Image = Image2.Images[2];
            }
            else if (car2X >= 530 && car2X <= 580 && car2Y >= 55 && car2Y <= 170)
            {
                car2Y -= car2Speed;
                pictureBox2.Location = new Point(car2X, car2Y);
                pictureBox2.Image = Image2.Images[3];
            }
            else if (car2X >= 335 && car2X <= 550 && car2Y >= 40 && car2Y <= 60)
            {
                car2X -= car2Speed;
                pictureBox2.Location = new Point(car2X, car2Y);
                pictureBox2.Image = Image2.Images[2];
            }
            else if (car2X >= 320 && car2X <= 360 && car2Y >= 40 && car2Y <= 201)
            {
                car2Y += car2Speed;
                pictureBox2.Location = new Point(car2X, car2Y);
                pictureBox2.Image = Image2.Images[1];
            }
            else if (car2X >= 85 && car2X <= 360 && car2Y >= 170 && car2Y <= 230)
            {
                car2X -= car2Speed;
                pictureBox2.Location = new Point(car2X, car2Y);
                pictureBox2.Image = Image2.Images[2];
            }
            else if (car2X >= 75 && car2X <= 100 && car2Y >= 170 && car2Y <= 300)
            {
                car2Y += car2Speed;
                pictureBox2.Location = new Point(car2X, car2Y);
                pictureBox2.Image = Image2.Images[1];
            }
            else if (car2X >= 75 && car2X <= 190 && car2Y >= 170 && car2Y <= 305)
            {
                car2X += car2Speed;
                pictureBox2.Location = new Point(car2X, car2Y);
                pictureBox2.Image = Image2.Images[0];
            }
            else if (car2X >= 170 && car2X <= 210 && car2Y >= 170 && car2Y <= 425)
            {
                car2Y += car2Speed;
                pictureBox2.Location = new Point(car2X, car2Y);
                pictureBox2.Image = Image2.Images[1];
            }
            else if (car2X >= 170 && car2X <= 280 && car2Y >= 170 && car2Y <= 435)
            {
                car2X += car2Speed;
                pictureBox2.Location = new Point(car2X, car2Y);
                pictureBox2.Image = Image2.Images[0];
            }
            else if (car2X >= 270 && car2X <= 300 && car2Y >= 315 && car2Y <= 435)
            {
                car2Y -= car2Speed;
                pictureBox2.Location = new Point(car2X, car2Y);
                pictureBox2.Image = Image2.Images[3];
            }
            else if (car2X >= 270 && car2X <= 435 && car2Y >= 300 && car2Y <= 430)
            {
                car2X += car2Speed;
                pictureBox2.Location = new Point(car2X, car2Y);
                pictureBox2.Image = Image2.Images[0];
            }
            else if (car2X >= 400 && car2X <= 450 && car2Y >= 300 && car2Y <= 440)
            {
                car2Y += car2Speed;
                pictureBox2.Location = new Point(car2X, car2Y);
                pictureBox2.Image = Image2.Images[1];
            }
            getCoins();
            finsh();
        }

        private void gameTimer_Tick_1(object sender, EventArgs e)
        {
            label6.Text = "Time(s): " + level0.totalDuration++;
            duration1++;
            duration2++;

        }

        private void ReadyTimer_Tick_1(object sender, EventArgs e)
        {
            if (label7.Text == "Go")
            {
                label7.Text = "";
                ReadyTimer.Stop();
            }
            else if (label7.Text == "Stady")
                label7.Text = "Go";
            else if (label7.Text == "Ready")
                label7.Text = "Stady";
            else
                label7.Text = "Ready";

            if (label7.Text == "Go")
                start();
        }

       
        private void start()
        {
            gameTimer.Start();
            if (firstPlayer.Name.Equals("Computer1"))
                Computer1Timer.Start();
            else
                moveC1Timer.Start();
            if (seconedPlayer.Name.Equals("Computer2"))
                Computer2Timer.Start();
            else
                moveC2Timer.Start();



        }     

     

        private void Level3_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    is_W_Key = false;
                    break;
                case Keys.D:
                    is_D_Key = false;
                    break;
                case Keys.S:
                    is_S_Key = false;
                    break;
                case Keys.A:
                    is_A_Key = false;
                    break;
                case Keys.Up:
                    is_Up_Key = false;
                    break;
                case Keys.Right:
                    is_Right_Key = false;
                    break;
                case Keys.Down:
                    is_Down_Key = false;
                    break;
                case Keys.Left:
                    is_Left_Key = false;
                    break;
            }
        }

        private void Level3_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    is_W_Key = true;
                    break;
                case Keys.D:
                    is_D_Key = true;
                    break;
                case Keys.S:
                    is_S_Key = true;
                    break;
                case Keys.A:
                    is_A_Key = true;
                    break;
                case Keys.Up:
                    is_Up_Key = true;
                    break;
                case Keys.Right:
                    is_Right_Key = true;
                    break;
                case Keys.Down:
                    is_Down_Key = true;
                    break;
                case Keys.Left:
                    is_Left_Key = true;
                    break;
            }
        }

        private void moveCar(String c)
        {
            int deltaX, deltaY;
            deltaX = deltaY = 0;
            if (c.Equals("car1"))
            {
                if (is_W_Key)
                {
                    deltaY -= car1Speed;
                    pictureBox1.BackgroundImage = Image1.Images[3];
                }
                if (is_D_Key)
                {
                    deltaX += car1Speed;
                    pictureBox1.BackgroundImage = Image1.Images[0];
                }
                if (is_S_Key)
                {
                    deltaY += car1Speed;
                    pictureBox1.BackgroundImage = Image1.Images[1];
                }
                if (is_A_Key)
                {
                    deltaX -= car1Speed;
                    pictureBox1.BackgroundImage = Image1.Images[2];
                }
                car1X += deltaX;
                car1Y += deltaY;
                pictureBox1.Location = new Point(car1X, car1Y);

                accidant("Car1");
            }
            else
            {
                if (is_Up_Key)
                {
                    deltaY -= car2Speed;
                    pictureBox2.BackgroundImage = Image2.Images[3];
                }
                if (is_Right_Key)
                {
                    deltaX += car2Speed;
                    pictureBox2.BackgroundImage = Image2.Images[0];
                }
                if (is_Down_Key)
                {
                    deltaY += car2Speed;
                    pictureBox2.BackgroundImage = Image2.Images[1];
                }
                if (is_Left_Key)
                {
                    deltaX -= car2Speed;
                    pictureBox2.BackgroundImage = Image2.Images[2];
                }
                car2X += deltaX;
                car2Y += deltaY;
                pictureBox2.Location = new Point(car2X, car2Y);
                accidant("Car2");
            }
            if (notFailed == true)
                faild();
            finsh();
            getCoins();

        }
        private Point accidant(String s)
        {
            if (s.Equals("Car1"))
            {
                if (pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds)
                   || pictureBox1.Bounds.IntersectsWith(pictureBox4.Bounds))
                {
                    car1Y = 445;
                    speedDown("Car1");
                }
                else if (pictureBox1.Bounds.IntersectsWith(pictureBox5.Bounds)
                    || pictureBox1.Bounds.IntersectsWith(pictureBox6.Bounds))
                {

                    car1X = 806;
                    speedDown("Car1");
                }
                else if (pictureBox1.Bounds.IntersectsWith(pictureBox7.Bounds)
                    || pictureBox1.Bounds.IntersectsWith(pictureBox8.Bounds))
                {

                    car1Y = 225;
                    speedDown("Car1");
                }
                else if (pictureBox1.Bounds.IntersectsWith(pictureBox9.Bounds)
                    || pictureBox1.Bounds.IntersectsWith(pictureBox10.Bounds))
                {

                    car1X = 953;
                    speedDown("Car1");
                }
                else if (pictureBox1.Bounds.IntersectsWith(pictureBox11.Bounds)
                    || pictureBox1.Bounds.IntersectsWith(pictureBox12.Bounds))
                {

                    car1Y = 42;
                    speedDown("Car1");
                }
                else if (pictureBox1.Bounds.IntersectsWith(pictureBox13.Bounds)
                    || pictureBox1.Bounds.IntersectsWith(pictureBox14.Bounds))
                {

                    car1X = 677;
                    speedDown("Car1");
                }
                else if (pictureBox1.Bounds.IntersectsWith(pictureBox15.Bounds))
                {

                    car1Y = 150;
                    speedDown("Car1");
                }
                else if (pictureBox1.Bounds.IntersectsWith(pictureBox16.Bounds)
                    || pictureBox1.Bounds.IntersectsWith(pictureBox17.Bounds))
                {

                    car1X = 559;
                    speedDown("Car1");
                }
                else if (pictureBox1.Bounds.IntersectsWith(pictureBox19.Bounds)
                    || pictureBox1.Bounds.IntersectsWith(pictureBox18.Bounds))
                {

                    car1Y = 31;
                    speedDown("Car1");
                }
                else if (pictureBox1.Bounds.IntersectsWith(pictureBox20.Bounds)
                    || pictureBox1.Bounds.IntersectsWith(pictureBox21.Bounds))
                {

                    car1X = 316;
                    speedDown("Car1");
                }
                else if (pictureBox1.Bounds.IntersectsWith(pictureBox22.Bounds)
                    || pictureBox1.Bounds.IntersectsWith(pictureBox23.Bounds))
                {

                    car1Y = 193;
                    speedDown("Car1");
                }
                else if (pictureBox1.Bounds.IntersectsWith(pictureBox24.Bounds))
                {

                    car1X = 62;
                    speedDown("Car1");
                }
                else if (pictureBox1.Bounds.IntersectsWith(pictureBox25.Bounds)
                    || pictureBox1.Bounds.IntersectsWith(pictureBox26.Bounds))
                {

                    car1Y = 309;
                    speedDown("Car1");
                }
                else if (pictureBox1.Bounds.IntersectsWith(pictureBox28.Bounds)
                    || pictureBox1.Bounds.IntersectsWith(pictureBox27.Bounds))
                {

                    car1X = 192;
                    speedDown("Car1");
                }
                else if (pictureBox1.Bounds.IntersectsWith(pictureBox29.Bounds))
                {

                    car1Y = 435;
                    speedDown("Car1");
                }/////////////////////////////////////////
                else if (pictureBox1.Bounds.IntersectsWith(pictureBox30.Bounds)
                    || pictureBox1.Bounds.IntersectsWith(pictureBox31.Bounds))
                {

                    car1X = 300;
                    speedDown("Car1");
                }
                else if (pictureBox1.Bounds.IntersectsWith(pictureBox32.Bounds))
                {

                    car1Y = 324;
                    speedDown("Car1");
                }
                else if (pictureBox1.Bounds.IntersectsWith(pictureBox33.Bounds)
                    || pictureBox1.Bounds.IntersectsWith(pictureBox34.Bounds))
                {

                    car1X = 427;
                    speedDown("Car1");
                }




                return new Point(car1X, car1Y);
            }
            else
            {

                if (pictureBox2.Bounds.IntersectsWith(pictureBox3.Bounds)
                   || pictureBox2.Bounds.IntersectsWith(pictureBox4.Bounds))
                {
                    car2Y = 445;
                    speedDown("Car2");
                }
                else if (pictureBox2.Bounds.IntersectsWith(pictureBox5.Bounds)
                    || pictureBox2.Bounds.IntersectsWith(pictureBox6.Bounds))
                {

                    car2X = 806;
                    speedDown("Car2");
                }
                else if (pictureBox2.Bounds.IntersectsWith(pictureBox7.Bounds)
                    || pictureBox2.Bounds.IntersectsWith(pictureBox8.Bounds))
                {

                    car2Y = 225;
                    speedDown("Car2");
                }
                else if (pictureBox2.Bounds.IntersectsWith(pictureBox9.Bounds)
                    || pictureBox2.Bounds.IntersectsWith(pictureBox10.Bounds))
                {

                    car2X = 953;
                    speedDown("Car2");
                }
                else if (pictureBox2.Bounds.IntersectsWith(pictureBox11.Bounds)
                    || pictureBox2.Bounds.IntersectsWith(pictureBox12.Bounds))
                {

                    car2Y = 42;
                    speedDown("Car2");
                }
                else if (pictureBox2.Bounds.IntersectsWith(pictureBox13.Bounds)
                    || pictureBox2.Bounds.IntersectsWith(pictureBox14.Bounds))
                {

                    car2X = 677;
                    speedDown("Car2");
                }
                else if (pictureBox2.Bounds.IntersectsWith(pictureBox15.Bounds))
                {

                    car2Y = 150;
                    speedDown("Car2");
                }
                else if (pictureBox2.Bounds.IntersectsWith(pictureBox16.Bounds)
                    || pictureBox2.Bounds.IntersectsWith(pictureBox17.Bounds))
                {

                    car2X = 559;
                    speedDown("Car2");
                }
                else if (pictureBox2.Bounds.IntersectsWith(pictureBox19.Bounds)
                    || pictureBox2.Bounds.IntersectsWith(pictureBox18.Bounds))
                {

                    car2Y = 31;
                    speedDown("Car2");
                }
                else if (pictureBox2.Bounds.IntersectsWith(pictureBox21.Bounds)
                    || pictureBox2.Bounds.IntersectsWith(pictureBox20.Bounds))
                {

                    car2X = 316;
                    speedDown("Car2");
                }
                else if (pictureBox2.Bounds.IntersectsWith(pictureBox23.Bounds)
                    || pictureBox2.Bounds.IntersectsWith(pictureBox22.Bounds))
                {

                    car2Y = 193;
                    speedDown("Car2");
                }
                else if (pictureBox2.Bounds.IntersectsWith(pictureBox24.Bounds))
                {

                    car2X = 62;
                    speedDown("Car2");
                }
                else if (pictureBox2.Bounds.IntersectsWith(pictureBox26.Bounds)
                    || pictureBox2.Bounds.IntersectsWith(pictureBox25.Bounds))
                {

                    car2Y = 309;
                    speedDown("Car2");
                }
                else if (pictureBox2.Bounds.IntersectsWith(pictureBox28.Bounds)
                    || pictureBox2.Bounds.IntersectsWith(pictureBox27.Bounds))
                {

                    car2X = 192;
                    speedDown("Car2");
                }
                else if (pictureBox2.Bounds.IntersectsWith(pictureBox29.Bounds))
                {

                    car2Y = 435;
                    speedDown("Car2");
                }
                else if (pictureBox2.Bounds.IntersectsWith(pictureBox31.Bounds)
                    || pictureBox2.Bounds.IntersectsWith(pictureBox30.Bounds))
                {

                    car2X = 300;
                    speedDown("Car2");
                }
                else if (pictureBox2.Bounds.IntersectsWith(pictureBox32.Bounds))
                {

                    car2Y = 324;
                    speedDown("Car2");
                }
                else if (pictureBox2.Bounds.IntersectsWith(pictureBox34.Bounds)
                    || pictureBox2.Bounds.IntersectsWith(pictureBox33.Bounds))
                {

                    car2X = 427;
                    speedDown("Car2");
                }


                return new Point(car2X, car2Y);
            }

        }
        private void speedDown(String S)
        {
            if (S.Equals("Car1"))
            {
                car1Speed = 4;
            }
            else
            {
                car2Speed = 4;
            }
        }
        private void getCoins()
        {
            if (pictureBox1.Bounds.IntersectsWith(pictureBox35.Bounds) && isCoin1)
            {
                car1Speed = 7;
                pictureBox35.Enabled = false;
                pictureBox35.Visible = false;
                isCoin1 = false;
                score1 += 5;

            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox35.Bounds) && isCoin1)
            {
                car2Speed = 7;
                pictureBox35.Enabled = false;
                pictureBox35.Visible = false;
                isCoin1 = false;
                score2 += 5;
            }
            //////////////////////////////////////////////////////////////////////
            if (pictureBox1.Bounds.IntersectsWith(pictureBox36.Bounds) && isCoin2)
            {
                car1Speed = 7;
                pictureBox36.Enabled = false;
                pictureBox36.Visible = false;
                isCoin2 = false;
                score1 += 5;
            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox36.Bounds) && isCoin2)
            {
                car2Speed = 7;
                pictureBox36.Enabled = false;
                pictureBox36.Visible = false;
                isCoin2 = false;
                score2 += 5;
            }
            ////////////////////////////////////////////////////////////////////
            if (pictureBox1.Bounds.IntersectsWith(pictureBox37.Bounds) && isCoin3)
            {
                car1Speed = 7;
                pictureBox37.Enabled = false;
                pictureBox37.Visible = false;
                isCoin3 = false;
                score1 += 5;
            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox37.Bounds) && isCoin3)
            {
                car2Speed = 7;
                pictureBox37.Enabled = false;
                pictureBox37.Visible = false;
                isCoin3 = false;
                score2 += 5;
            }
            ////////////////////////////////////////////////////////////////////
            if (pictureBox1.Bounds.IntersectsWith(pictureBox38.Bounds) && isCoin4)
            {
                car1Speed = 7;
                pictureBox38.Enabled = false;
                pictureBox38.Visible = false;
                isCoin4 = false;
                score1 += 5;
            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox38.Bounds) && isCoin4)
            {
                car2Speed = 7;
                pictureBox38.Enabled = false;
                pictureBox38.Visible = false;
                isCoin4 = false;
                score2 += 5;
            }
            label4.Text = "Player1 Score: " + score1;
            label5.Text = "Player2 Score: " + score2;
        }
        private void finsh()
        {
            if (car1X > 620 && car1X < 640&& car1Y >= 398 )
            {
                moveC1Timer.Stop();
                Computer1Timer.Stop();
                firstPlayer.Duration = duration1;
                firstPlayer.Score = score1;
                car1Finsh = true;
                notFailed = false;
            }
            if (car2X > 620 && car2X < 640 && car2Y >= 398)
            {
                moveC2Timer.Stop();
                Computer2Timer.Stop();
                seconedPlayer.Duration = duration2;
                seconedPlayer.Score = score2;
                car2Finsh = true;
                notFailed = false;
            }
            if (car1Finsh == true && car2Finsh == true)
            {
                gameTimer.Stop();
                nextLevel();
            }
        }
        private void nextLevel()
        {
            MessageBox.Show("Finsh");
            firstPlayer.MinDuration = firstPlayer.Duration;
            firstPlayer.MaxDuration = firstPlayer.Duration;
            firstPlayer.MinScore = firstPlayer.Score;
            firstPlayer.MaxScore =firstPlayer.Score;
            /////////////////////////////////
            seconedPlayer.MinDuration = seconedPlayer.Duration;
            seconedPlayer.MaxDuration = seconedPlayer.Duration;
            seconedPlayer.MinScore = seconedPlayer.Score;
            seconedPlayer.MaxScore = seconedPlayer.Score;
            game g = new game();
            g.p1Name = firstPlayer.Name;
            g.p2Name = seconedPlayer.Name;
            g.totalDuration = level0.totalDuration;
            g.p1Score = score1;
            g.p2Score = score2;
            Program.games.Add(g);
            Intro i = new Intro();
            i.Show();
            this.Close();
        }
        private void faild()
        {
            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds)&&notFailed)
            {
                gameTimer.Stop();
                moveC1Timer.Stop();
                moveC2Timer.Stop();
                MessageBox.Show("Game Over");
                firstPlayer.MaxDuration = duration1;
                firstPlayer.MinDuration = duration1;
                firstPlayer.MaxScore = score1;
                firstPlayer.MinScore = score1;
                /////////////////////////////////
                seconedPlayer.MaxDuration = duration2;
                seconedPlayer.MinDuration = duration2;
                seconedPlayer.MaxScore = score2;
                seconedPlayer.MinScore = score2;
                game g = new game();
                g.p1Name = firstPlayer.Name;
                g.p2Name = seconedPlayer.Name;
                g.totalDuration = level0.totalDuration;
                g.p1Score = score1;
                g.p2Score = score2;
                Program.games.Add(g);
                Intro i = new Intro();
                i.Show();
                this.Close();

            }
        }

    }
}
