using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void enterBut_Click(object sender, EventArgs e)
        {
            int secInput;
            if (int.TryParse(userInput.Text, out secInput))
            {

                int days = 0;
                int hours = 0;
                int minutes = 0;
                int seconds = 0;

                if (secInput > 0)
                {
                    seconds = calcSeconds(secInput);
                    secLabel.Text = seconds.ToString();
                }
                if (secInput >= 60)
                {
                    minutes = secInput / 60;
                    minLabel.Text = minutes.ToString();
                }
                if (secInput >= 3600)
                {
                    hours = secInput / 3600;
                    hoursLabel.Text = hours.ToString();
                }
                if (secInput >= 86400)
                {
                    days = secInput / 86400;
                    daysLabel.Text = days.ToString();
                }
                else if (secInput < 1)
                {
                    MessageBox.Show("Entry can not be less than 1");
                }
            }
            else
            {
                MessageBox.Show("Wrong input, use int only.");

            }
            TabIndex = 0;



        }

        private int calcSeconds(int inputSeconds)
        {
            int sec = inputSeconds % 60;
            return sec;
        }

        private void exitBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
//seconds = inputSeconds % 60 -> mins = inputSeconds / 60 -> hours = mins / 60 -> days = hours/24