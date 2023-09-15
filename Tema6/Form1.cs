using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema6
{
    public partial class Form1 : Form
    {
        private const int BoxWidth = 400;
        private const int BoxHeight = 300;
        private const int BallRadius = 20;
        private const int BallSpeed = 5;

        private Point ballPosition;
        private Size ballVelocity;
        private Color ballColor;

        private Timer animationTimer;
        public Form1()
        {
            InitializeComponent();
            InitializeAnimation();
        }
        private void InitializeAnimation()
        {
            ballPosition = new Point(BoxWidth / 2, BoxHeight / 2);
            ballVelocity = new Size(BallSpeed, BallSpeed);
            ballColor = Color.Red;

            animationTimer = new Timer();
            animationTimer.Interval = 16; // Approximately 60 FPS
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Actualizăm poziția mingii în funcție de viteză
            ballPosition += ballVelocity;

            // Verificăm coliziunile cu pereții cutiei
            if (ballPosition.X <= 0 || ballPosition.X >= BoxWidth - BallRadius * 2)
            {
                ballVelocity.Width = -ballVelocity.Width; // Inversăm direcția pe axa X
            }

            if (ballPosition.Y <= 0 || ballPosition.Y >= BoxHeight - BallRadius * 2)
            {
                ballVelocity.Height = -ballVelocity.Height; // Inversăm direcția pe axa Y
            }

            // Redesenăm cutia și mingea
            animationPictureBox.Invalidate();
        }
        private void animationPictureBox_Paint(object sender, PaintEventArgs e)
        {
            // Desenăm cutia
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, BoxWidth - 1, BoxHeight - 1);

            // Desenăm mingea
            using (SolidBrush brush = new SolidBrush(ballColor))
            {
                e.Graphics.FillEllipse(brush, ballPosition.X, ballPosition.Y, BallRadius * 2, BallRadius * 2);
            }
        }
        private void changeColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                ballColor = colorDialog.Color;
            }
        }
    }
}
