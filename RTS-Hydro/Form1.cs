using System;

namespace RTS_Hydro
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        Random random = new Random();
        double preasureVar = 160;

        public void preasureSet(double preasure)
        {
            preasure = Math.Round(preasure, 3);
            preasureLabelVar.Text = preasure + " אעלמספונ.".ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            double preasureVar = random.NextDouble() * (169.999 - 150.000) + 150.000;
            preasureSet(preasureVar);
        }

        private void powerOnButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
