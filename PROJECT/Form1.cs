using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class Form1 : Form
    {
        public PictureBox[] snake = new PictureBox[400];
        public int rI, rj;
        public PictureBox fruit;
        public int dirX, dirY;
        public int hieght = 875;
        public int width = 900;
        public int size = 40;
        public int score=0;
        public int i;        
        public  Label labelscore;
        public Form1()
        {
            InitializeComponent();
            this.KeyDown+= new KeyEventHandler(Move);
            this.Width = width;
            this.Height = hieght;
            generatemap();
            timer1.Tick += new EventHandler(_update);
            timer1.Interval = 500;
            timer1.Start();
            dirX = 1;
            dirY = 0;
            Label labelScore = new Label();
            labeScr.Text = "Score: 0";
            labeScr.Location =new Point(810,10);  
            this.Controls.Add(labelscore);
            snake[0] = new PictureBox();
            snake[0].Location = new Point(201, 201);
            snake[0].Size = new Size(size-1, size-1);
            snake[0].BackColor = Color.Green;                          
            this.Controls.Add(snake[0]);
            fruit = new PictureBox();
            fruit.BackColor = Color.Yellow;
            fruit.Size = new Size(size, size);
            _generateFruit();
            this.Text = "Змейка";   
           
        }
        private void _generateFruit()
        {
            Random rnd = new Random();
            rI = rnd.Next(0,hieght-size);
            int tempI = rI % size;
            rI -= tempI;
            //
            rj = rnd.Next(0, width - size);
            int tempj = rj % size;
            rj -= tempj;
            fruit.Location = new Point(rI, rj);
            this.Controls.Add(fruit);
            rj++;
            rI++;
        }
        private void _checkBorders()
        {
            if (snake[0].Location.X < 0)
            {
                for (int _i = 1; _i <= score; _i++)
                {
                    this.Controls.Remove(snake[_i]);
                }
                score = 0;
                labeScr.Text = "Score: " + score;
                dirX = 1;
            }
            if (snake[0].Location.X > hieght)
            {
                for (int _i = 1; _i <= score; _i++)
                {
                    this.Controls.Remove(snake[_i]);
                }
                score = 0;
                labeScr.Text = "Score: " + score;
                dirX = -1;
            }
            if (snake[0].Location.Y < 0)
            {
                for (int _i = 1; _i <= score; _i++)
                {
                    this.Controls.Remove(snake[_i]);
                }
                score = 0;
                labeScr.Text = "Score: " + score;
                dirY = 1;
            }
            if (snake[0].Location.Y > hieght)
            {
                for (int _i = 1; _i <= score; _i++)
                {
                    this.Controls.Remove(snake[_i]);
                }
                score = 0;
                labeScr.Text = "Score: " + score;
                dirY = -1;
            }
        }
        private void _moveSnake()
        {
            for (int i = score; i >= 1; i--)
            {
                snake[i].Location = snake[i - 1].Location;
               
            }
             snake[0].Location = new Point(snake[0].Location.X + dirX * (size), snake[0].Location.Y + dirY * (size));
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
         void Move(object sender, KeyEventArgs e)
        {   switch (e.KeyData.ToString())
            {
                case "Up":
                   dirY =-1;
                    dirX = 0;
                    break;
                case "Down":
                    dirY = 1;
                    dirX = 0;
                    break;
                case "Right":
                    dirX = 1;
                    dirY = 0;
                    break;
                case "Left":
                    dirX = -1;
                    dirY = 0;
                    break;
            }           
        }
        private void _eat()
        {
            if(snake[0].Location.X==rI && snake[0].Location.Y==rj)
            {
                labeScr.Text = "score" + ++score;
                snake[score] = new PictureBox();
                snake[score].Location = new Point(snake[score - 1].Location.X + 40 * dirX, snake[score - 1].Location.Y - 40 * dirY);
                snake[score].Size = new Size(size-1, size-1);
                snake[score].BackColor = Color.GreenYellow;
                this.Controls.Add(snake[score]);
                _generateFruit();
               
                
            }
        }

        private void _update(Object myobject,EventArgs e)
        {
            _eat();
            _moveSnake();
            _eatSelf();
            _checkBorders();
        }
        private void _eatSelf()
        {
            for (int _i = 1; _i < score; _i++)
            {
                if (snake[0].Location == snake[_i].Location)
                {
                    for (int _j = _i; _j <= score; _j++)
                        this.Controls.Remove(snake[_j]);
                    score = score - (score - _i + 1);
                    labeScr.Text = "Score: " + score;

                }
            }
        }

      private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void generatemap()
        {
            for(int i= 0; i< width/size; i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.Black;
                pic.Location = new Point(0,size*i);
                pic.Size = new Size(width , 1);
                this.Controls.Add(pic);
            }
            for(int i=0;i<=hieght/size;i++) 
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.Black;
                pic.Location = new Point( size * i,0);
                pic.Size = new Size(1,width);
                this.Controls.Add(pic);

            }
        }
            
               
       
    }
}
