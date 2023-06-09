using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Scroll_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.MouseWheel += panel1_Scroll;
        }
        int isup = 0;
        int isdown = 0;
        private void panel1_Scroll(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                isup++;
                label1.Text = "Scroll Direction Counter\r\n\r\nUp : " + isup + "\r\nDown : " + isdown + "";
            }
            else
            {
                isdown++;
                label1.Text = "Scroll Direction Counter\r\n\r\nUp : " + isup + "\r\nDown : " + isdown + "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isup = 0;
            isdown = 0;
            label1.Text = "Scroll Direction Counter\r\n\r\nUp : " + isup + "\r\nDown : " + isdown + "";
        }
    }
}
