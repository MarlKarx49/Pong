using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace c_sharp_pong
{
    class LeftPaddle
    {
        public float x = 0;
        public float y = 400;
        public float vy = 0;

        public void Render(Graphics graphics)
        {
            graphics.FillRectangle(new SolidBrush(Color.White), x, y, 10, 50);

            y += vy;
        }        
    }
    class RightPaddle
    {
        public float x = Form1.windowWidth - 25;
        public float y;
        public float vy = 0;
        public Ball ball;
        float height = 60;
        
        public void Render(Graphics graphics, Ball ball)
        {
            AI(ball);
            y += vy;
            graphics.FillRectangle(new SolidBrush(Color.White), x, y, 10, 50);
        }
        public void AI(Ball ball)
        {
            if (ball.y < y && ball.vx > 0) { vy = -3; }
            else if (ball.y > y + height && ball.vx > 0) { vy = 3; }
            else { vy = 0; }
        }
        public void Collision(Ball ball)
        {
            if (ball.x > Form1.windowWidth - 10)
            {

            }
        }
    }
}
