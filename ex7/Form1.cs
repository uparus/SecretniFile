using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex7
{
    public partial class Form1 : Form
    {
        int score;
        int maxTime;
        int steps = 15;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;
            StartNewGame();
        }
        private void StartNewGame()
        {
            score = 0;
            maxTime = 10;
            updateLabel();

            pictureBoxCheese.Location = new Point(10, 10);
            pictureBoxMouse.Location = new Point(this.ClientSize.Width - pictureBoxMouse.Width - 10, this.ClientSize.Height - pictureBoxMouse.Height - 10);
            pictureBoxCheese.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMouse.SizeMode = PictureBoxSizeMode.Zoom;

            timer1.Interval = 1500;
            timer1.Start();

            timer2.Interval = 1000;
            timer2.Start();
        }
        private void moveCheeseRandom()
        {
            int minY = 0;
            int minX = 0;

            int maxX = this.ClientSize.Width - pictureBoxCheese.Width;
            int maxY = this.ClientSize.Height - pictureBoxCheese.Height;

            int rX = rand.Next(minX, Math.Max(minX + 1, maxX));
            int rY = rand.Next(minY, Math.Max(minY + 1, maxY));

            pictureBoxCheese.Location = new Point(rX, rY);

            checkCollision();
        }
        private void checkCollision()
        {
            if (pictureBoxCheese.Bounds.IntersectsWith(pictureBoxMouse.Bounds))
            {
                score++;
                updateLabel();
                moveCheeseRandom();
                System.Media.SystemSounds.Asterisk.Play();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveCheeseRandom();
        }
        private void updateLabel()
        {
            this.Text = $"Очки: {score} Время: {maxTime}";
            //label1.Text = $"Очки: {score}";
            //label2.Text = $"Время осталось: {maxTime}";
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int newX = pictureBoxMouse.Left;
            int newY = pictureBoxMouse.Top;

            int minX = 10;
            int maxX = this.ClientSize.Width - pictureBoxMouse.Width - 10;
            int minY = 10;
            int maxY = this.ClientSize.Height - pictureBoxMouse.Height;

            switch (e.KeyCode)
            {
                case Keys.W:
                    {
                        newY -= steps;
                        break;
                    }

                case Keys.S:
                    {
                        newY += steps;
                        break;
                    }
                case Keys.A:
                    {
                        newX -= steps;
                        break;
                    }
                case Keys.D:
                    {
                        newX += steps;
                        break;
                    }
             }
            newX = Math.Max(minX, Math.Min(newX, maxX));
            newY = Math.Max(minY, Math.Min(newY, maxY));
            pictureBoxMouse.Location = new Point(newX,newY);
            checkCollision();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            maxTime--;
            updateLabel();

            if (maxTime <= 0)
            {
                timer1.Stop();
                timer2.Stop();

                DialogResult res = MessageBox.Show(
                    $"Время вышло!\nВы собрали кусочков сыра: {score}.\nХотите сыграть еще раз?",
                    "Игра окончена",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (res == DialogResult.Yes)
                {
                    StartNewGame();
                }
                else
                {
                    this.Close();
                }
            
        }
        }
    }
}
