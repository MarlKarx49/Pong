using pong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_sharp_pong
{
    public partial class Form1 : Form
    {
        private Canvas formWindow = null;
        public static int windowWidth = 750;
        public static int windowHeight = 675;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // the sender is the button itself in this case
                                                               // e is the event argument
        {
            formWindow = new Canvas();
            formWindow.Text = "Pong Game Screen";
            formWindow.Size = new Size(windowWidth + 25, windowHeight + 50);
            formWindow.Show();
        }
    }
}
