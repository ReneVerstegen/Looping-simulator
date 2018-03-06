using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Looping_simulator
{
    public partial class Form1 : Form
    {
        int speed, weight, ratio;
        bool pin;

        public Form1()
        {
            InitializeComponent();
        }

        private void Weight_TextChanged(object sender, EventArgs e)
        {
            weight = int.Parse(Weight.Text);
        }

        private void Speed_TextChanged(object sender, EventArgs e)
        {
            speed = int.Parse(Speed.Text);
        }

        private void Ratio_TextChanged(object sender, EventArgs e)
        {
            ratio = int.Parse(Ratio.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pin = checkBox1.Checked;
        }



    }
}
