using c_sharp_pong;
using pong;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace pong
{
    class Game
    {
        public Canvas window;
        private Thread gameLoopThread;
        private Ball ball;
        private LeftPaddle paddleL;
        private RightPaddle paddleR;
        public float x;
        public float y;
        public float vx;
        public float vy;
        public bool canvasClosed = false;
        
        

        public Game(Canvas canvas)
        {
            window = canvas;
            canvas.Paint += Canvas_Paint; // this is listening for when the window is painted
            x = 10;
            y = 10;
            vx = 2;
            vy = 0;
            ball = new Ball();
            paddleL = new LeftPaddle();
            paddleR = new RightPaddle();
            gameLoopThread = new Thread(GameLoop);
            gameLoopThread.IsBackground = true; //attempt to solve thread running after window closes
            gameLoopThread.Start();
            canvas.KeyDown += Canvas_KeyPress;
            canvas.KeyUp += Canvas_KeyRelease;
            }

        private void Canvas_KeyRelease(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { paddleL.vy = 0; }
            if (e.KeyCode == Keys.S) { paddleL.vy = 0; }
            if (e.KeyCode == Keys.Up) { paddleR.vy = 0; }
            if (e.KeyCode == Keys.Down) { paddleR.vy = 0; }
        }

        private void Canvas_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { paddleL.vy = -2; }
            if (e.KeyCode == Keys.S) { paddleL.vy = 2; }
            if (e.KeyCode == Keys.Up) { paddleR.vy = -2; }
            if (e.KeyCode == Keys.Down) { paddleR.vy = 2; }
        }
        

        private void Canvas_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.Clear(Color.Black);
            ball.Render(graphics);
            paddleL.Render(graphics);
            paddleR.Render(graphics);

        }
        public void GameLoop()
        {
            while (gameLoopThread.IsAlive&&!canvasClosed) // the && checks for a logical condition  - if canvasClosed is NOT closed
            {
                window.BeginInvoke((MethodInvoker)delegate { window.Refresh(); });
                Thread.Sleep(1);
            }
        }

    }
}
