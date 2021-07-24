using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace c_sharp_pong
{
    class LeftPaddle
    {
        public float x = 0;
        public float y = 100;
        public float vy = 0;


        public void Render(Graphics graphics)
        {
            graphics.FillRectangle(new SolidBrush(Color.White), x, y, 10, 50);

            y += vy;
        }        
    }
    class RightPaddle
    {
        public float x = 275;
        public float y = 100;
        public float vy = 0;


        public void Render(Graphics graphics)
        {
            graphics.FillRectangle(new SolidBrush(Color.White), x, y, 10, 50);

            y += vy;
        }
    }
}
