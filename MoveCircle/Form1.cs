using System;
using System.Drawing;
using System.Windows.Forms;
using static Ball;

namespace MoveCircle
{
    public partial class FormBallGame : Form
    {
        private Bitmap canvas;
        private Ball[] balls;
        private string[] kanjis;
        private Brush[] brushes;
        private string fontName = "HG教科書体";
        private string correctText = "森";
        private string mistakeText = "林";
        private string circleText = "〇";
        private double nowTime = 0;
        private int ballCount = 5;
        private int randomResult = 0;

        public FormBallGame()
        {
            InitializeComponent();

        }
        private void FormBallGame_Load(object sender, EventArgs e)
        {
            InitGraphics();
            SetStartPosition();

        }

        private void ButRestart_Click(object sender, EventArgs e)
        {
            InitGraphics();
            SetStartPosition();
        }
        private void mainPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (butRestart.Enabled)
            {
                return;
            }
            SetBalls(e.X, e.Y);
        }
        private void SelectPictureBox_Click(object sender, EventArgs e)
        {
        }
        private void selectPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (butRestart.Enabled)
            {
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                int selectCircle = e.X / selectPictureBox.Height;

                if (randomResult == selectCircle)
                {
                    timer1.Stop();
                    DrowMainPictureBox(Brushes.Red, circleText, true);
                    butRestart.Enabled = true;
                }
                else
                {
                    DrowMainPictureBox(Brushes.Red, correctText, false);
                    for (int i = 0; i < ballCount; i++)
                    {
                        balls[i].pitch = balls[i].pitch - balls[i].pitch / 2;
                    }
                    nowTime = nowTime + 10;
                }
            }

        }
        private void mainPictureBox_Click(object sender, EventArgs e)
        {


        }



        private void Timer1_Tick(object sender, EventArgs e)
        {
            for (int i=0;i<ballCount;i++)
            {
                balls[i].Move();
            }
            nowTime = nowTime + 0.02;
            textTimer.Text = nowTime.ToString("0.00");

        }



        private void InitGraphics()
        {
            brushes = new Brush[ballCount];
            kanjis = new string[ballCount];
            balls = new Ball[ballCount];

            brushes[0] = Brushes.LightPink;
            brushes[1] = Brushes.LightBlue;
            brushes[2] = Brushes.LightGray;
            brushes[3] = Brushes.LightCoral;
            brushes[4] = Brushes.LightGreen;

            DrowCircleSelectPictureBox();

            DrowMainPictureBox(Brushes.Gray, correctText, false);

            butRestart.Enabled = false;
            textHunt.Text = correctText;
        }

        private void SetStartPosition()
        {
            for (int i = 0; i < ballCount; i++)
            {
                kanjis[i] = mistakeText;
            }
            randomResult = new Random().Next(ballCount);
            kanjis[randomResult] = correctText;

            for (int i = 0; i < ballCount; i++)
            {
                balls[i] = new Ball(mainPictureBox, canvas, brushes[i], kanjis[i]);
            }

            int rndXMax = mainPictureBox.Width;
            int rndYMax = mainPictureBox.Height;
            SetBalls(new Random().Next(rndXMax), new Random().Next(rndYMax));

            nowTime = 0;
            timer1.Start();
        }
        private void SetBalls(int x, int y)
        {
            int rndXMax = mainPictureBox.Width;
            int rndYMax = mainPictureBox.Height;
            int rndX;
            int rndY;

            for (int i=0;i<ballCount;i++)
            {
                rndX = new Random(i * x).Next(rndXMax);
                rndY= new Random(i * x).Next(rndYMax);
                balls[i].DeleteCircle();
                balls[i].PutCircle(rndX,rndY);
            }
        }

        private void DrowCircleSelectPictureBox()
        {
            int height = selectPictureBox.Height;//高さ
            int width = selectPictureBox.Width;//幅

            Bitmap selectCanvas = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(selectCanvas))
            {
                //g.FillEllipse(Brushes.LightBlue, 0, 0, height, height);
                for (int i=0; i<ballCount;i++)
                {
                    g.FillEllipse(brushes[i], i * height, 0, height, height);
                }
                selectPictureBox.Image = selectCanvas;
            }

        }
        private void DrowMainPictureBox(Brush color, string text,bool trueFlag)
        {
            int height = mainPictureBox.Height;
            int width = mainPictureBox.Width;

            //描画先とするImageオブジェクトを作成する
            if (canvas == null)
            {
                canvas = new Bitmap(width, height);
            }

            using (Graphics g = Graphics.FromImage(canvas))
            {
                if (trueFlag)
                {
                    g.FillRectangle(Brushes.LightPink, 0, 0, width, height);
                }
                else
                {
                    g.FillRectangle(Brushes.White, 0, 0, width, height);
                }
                //背景に引数で指定した文字列を描画する
                g.DrawString(text, new Font(fontName, height - height / 3), color, 0, 0, new StringFormat());
                //mainPictureBoxに表示する
                mainPictureBox.Image = canvas;
            }
        }


    }
}
