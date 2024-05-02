using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bleh_game
{
    public partial class Form1 : Form
    {
        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 12;
        int score;
        int carImage;

        Random rand = new Random();
        Random carPosition = new Random();

        bool goleft, goright;

        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changeAI(PictureBox TMP)
        {

            TMP.Top = carPosition.Next(100, 400) * -1;
            if (TMP.Tag == "carvasak")
            {
                TMP.Left = carPosition.Next(5, 200);
            }

            if (TMP.Tag == "carparem")
            {
                TMP.Left = carPosition.Next(245, 422);
            }
        }

        private void GameOver()
        {
            gameTimer.Stop();
            start.Enabled = true;
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            else goleft = false;
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            else goright = false;
        }

        private void keyisup(object sender, KeyEventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            label1.Text = "Score: " + score;
            score++;

            if (goleft == true && player.Left > 5)
            {
                player.Left -= playerSpeed;

            }
            if (goright == true && player.Left < 422)
            {
                player.Left += playerSpeed;

            }

            road1.Top += roadSpeed;
            road2.Top += roadSpeed;
            road3.Top += roadSpeed;
            if (road1.Top > 500)
            {
                road1.Top -= 500;
            }
            if (road2.Top > 1000)
            {
                road2.Top -= 1000;
            }
            if (road3.Top > 1500)
            {
                road3.Top -= 1500;
            }

            AI1.Top += trafficSpeed;
            AI2.Top += trafficSpeed;

            if (AI1.Top > 530)
            {
                changeAI(AI1);
            }
            if (AI2.Top > 530)
            {
                changeAI(AI2);
            }

            if ((player.Bounds.IntersectsWith(AI1.Bounds)) || (player.Bounds.IntersectsWith(AI2.Bounds))) {
                GameOver();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ResetGame()
        {
            start.Enabled = false;
            goleft = false;
            goright = false;
            score = 0;

            roadSpeed = 12;
            trafficSpeed = 15;

            AI1.Top = carPosition.Next(200, 500) *- 1;
            AI1.Left = carPosition.Next(5, 200);

            AI2.Top = carPosition.Next(200, 500) * -1;
            AI2.Left = carPosition.Next(245, 422);

            gameTimer.Start();
        }
    }
}
