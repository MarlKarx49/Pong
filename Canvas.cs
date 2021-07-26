using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace pong
{
    class Canvas:Form
    {
        public Game game;

        public int height = 600;
        public int width = 800;
        public Canvas()
        {
            this.DoubleBuffered = true;
            this.Shown += Canvas_Shown; //Shown is the event, Canvas_Shown is the listener
        }

        private void Canvas_Shown(object sender, EventArgs e) // this is waiting for the window to be shown before creating the game
        {
            game = new Game(this);

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "Canvas";
            this.Load += new System.EventHandler(this.Canvas_Load);
            this.ResumeLayout(false);

        }

        private void Canvas_Load(object sender, EventArgs e)
        {

        }
        //we need to clear the screen, because we want a different background
        ~Canvas()
        {
            game.canvasClosed = true;
        }
    }
}
