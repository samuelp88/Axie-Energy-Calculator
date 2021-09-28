using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overlay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RenderEnergy();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = alwaysOnTopCheck.Checked;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            switch(e.KeyChar)
            {
                case (char)13:
                    EnergyCounter.nextRound();
                    RenderEnergy();
                    break;
                case '+':
                    EnergyCounter.addEnergy();
                    RenderEnergy();
                    break;
                case '-':
                    EnergyCounter.removeEnergy();
                    RenderEnergy();
                    break;
            }
        }

        public void RenderEnergy()
        {
            currentEnergy.Text = EnergyCounter.energy.ToString();
            round.Text = EnergyCounter.round.ToString();
        }

        private void increaseButton_Click(object sender, EventArgs e)
        {
            EnergyCounter.addEnergy();
            RenderEnergy();
        }

        private void decreaseButton_Click(object sender, EventArgs e)
        {
            EnergyCounter.removeEnergy();
            RenderEnergy();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            EnergyCounter.reset();
            RenderEnergy();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnergyCounter.nextRound();
            RenderEnergy();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 credits = new Form2();
            credits.ShowDialog();
        }
    }
}
