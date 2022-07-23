using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
        public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I knew!");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void questionLBL_Click(object sender, EventArgs e)
        {

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            Random random = new Random();
            if(sender is Button bt)
            {
                int RandomX = random.Next(this.Width - 135);
                int RandomY = random.Next(this.Height - 135);
                bt.Location = new Point(RandomX,RandomY);
                int randomColor = random.Next(Colors.colors.Length);
                this.BackColor =Colors.colors[randomColor] ;
            }
        }
    }
    public class Colors
    {
        public static Color[] colors = new Color[] {
            Color.Red,
            Color.Green,
            Color.Blue,
            Color.White,
            Color.Aqua,
            Color.Brown,
            Color.Yellow,
            Color.Chocolate
        };
        public Color this[int index] => colors[index];

    }
}
