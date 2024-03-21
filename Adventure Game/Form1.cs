using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Adventure_Game
{
    public partial class Form1 : Form
    {
        int page = 1;
        int test = 8;
        
        Random randGen = new Random();
        public Form1()
        {
            InitializeComponent();

            optionButton1.Hide();
            optionButton2.Hide();
            optionButton3.Hide();
        }

        private void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    outputLabel.Text = "You are in a campus with you school friends they are planning to go outside at night for camp fire ";
                    optionButton1.Text = "Outside";
                    optionButton2.Text = "Stay";
                    break;
                case 2:
                    outputLabel.Text = "";
                    optionButton1.Text = "";
                    optionButton2.Text = "";
                    break;

            }
        }

        private void optionButton1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 11;
            }
            else if (page == 3)
            {
                page = 4;
            }
            else if (page == 4)
            {
                int randValue = randGen.Next(1, 41);

                if (randValue < 30)
                {
                    page = 6;
                }
                else
                {
                    page = 7;
                }
            }
            else if (page == 5)
            {
                int randValue = randGen.Next(1, 41);

                if (randValue < 30)
                {
                    page = 6;
                }
                else
                {
                    page = 7;
                }
            }
            else if (page == 6)
            {
                page = 99;
            }
            else if (page == 7)
            {
                page = 10; //watch out for this one look at this option in the flowchart
            }
            else if (page == 8)
            {
                page = 10;
            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 11;
            }

            else if (page == 11)
            {
                page = 99;
            }

            else if (page == 12)
            {
                page = 13;
            }
            else if (page == 13)
            {
                page = 15;
            }
            else if (page == 14)
            {
                page = 99;
            }
            else if (page == 15)
            {
                page = 99;
            }
            else if (page == 16)
            {
                page = 17;
            }
            else if (page == 17)
            {
                page = 99;
            }
            else if (page == 18)
            {
                page = 19;
            }
            else if (page == 19)
            {
                page = 99;
            }
            else if (page == 20)
            {
                page = 21;
            }
            else if (page == 21)
            {
                page = 99;
            }
            else if (page == 22)
            {
                page = 23;
            }
            else if (page == 23)
            {
                page = 99;
            }
            else if (page == 24)
            {
                page = 99;
            }
            else if (page == 25)
            {
                page = 99;
            }
        }

        private void optionButton2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 12;
            }
            else if (page == 3)
            {
                page = 5;
            }
            else if (page == 4)
            {
                page = 8;
            }
            else if (page == 5)
            {
                page = 8;
            }
            else if (page == 6)
            {
                page = 1;
            }
            else if (page == 7)
            {
                page = 9;
            }
            else if (page == 8)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 12;
            }

            else if (page == 11)
            {
                page = 1;
            }

            else if (page == 12)
            {
                page = 14;
            }
            else if (page == 13)
            {
                page = 15;
            }
            else if (page == 14)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 1;
            }
            else if (page == 16)
            {
                page = 18;
            }
            else if (page == 17)
            {
                page = 1;
            }
            else if (page == 18)
            {
                page = 20;
            }
            else if (page == 19)
            {
                page = 1;
            }
            else if (page == 20)
            {
                page = 22;
            }
            else if (page == 21)
            {
                page = 1;
            }
            else if (page == 22)
            {
                page = 24;
            }
            else if (page == 23)
            {
                page = 1;
            }
            else if (page == 24)
            {
                page = 1;
            }
            else if (page == 25)
            {
                page = 1;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            optionButton1.Show();
            optionButton2.Show();
            optionButton3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = test + "";
        }
    }
}


