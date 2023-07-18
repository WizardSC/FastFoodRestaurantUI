using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodRestaurantUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnLeftBorder.Height = button1.Height;
            pnLeftBorder.Top = button1.Top; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnLeftBorder.Height = button3.Height;
            pnLeftBorder.Top = button3.Top;
        }
    }
}
