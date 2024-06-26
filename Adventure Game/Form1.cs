﻿using System;
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
        int page;
        
        Random randGen = new Random();


        public Form1()
        {
            InitializeComponent();

            optionButton1.Hide();
            optionButton2.Hide();
            optionButton3.Hide();

            optionButton1.Click += optionButton1_Click;
            optionButton2.Click += optionButton2_Click;


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
                    outputLabel.Text = "Telling them everything what happened";
                    Refresh();
                    Thread.Sleep(2000);
                    outputLabel.Text = "Your friend ran to you and tells you everything that happened";
                    optionButton1.Text = "Run right away ";
                    optionButton2.Text = "Find a safe place and make a plan";
                    Refresh();
                    break;
                case 3:
                    outputLabel.Text = "You stayed with your friend and suddenly you hear strange sounds from the basement and your teacher is out with the other friends, What would you do?";
                    optionButton1.Text = "No";
                    optionButton2.Text = "Explore";
                    break;
                case 4:
                    outputLabel.Text = "You and your friend started a movie but the noise is to irritating so you decide to go, check anyways";
                    Refresh();
                    Thread.Sleep(2000);
                    outputLabel.Text = "You open the basement, it's pitch black and suddenly a strange looking creature jumped on your friend";
                    optionButton1.Text = "Save";
                    optionButton2.Text = "Get out of there";
                    break;
                case 5:
                    outputLabel.Text = "You open the basement, it's pitch black and suddenly a strange looking creature jumped on you friend";
                    optionButton1.Text = "Save";
                    optionButton2.Text = "Get out of there";
                    break;
                case 6:
                    outputLabel.Text = "You die saving your friend\r\nYour a TRUE FRIEND! \r\n Play Again";
                    optionButton1.Text = "Yes ";
                    optionButton2.Text = "No";
                    break;
                case 7:
                    outputLabel.Text = "You lived...\r\nYou locked the basement.";
                    optionButton1.Text = "Call";
                    optionButton2.Text = "Run";
                    break;
                case 8:
                    outputLabel.Text = "Are you going to call your friends or run to your friends?";
                    optionButton1.Text = "Call";
                    optionButton2.Text = "Run";
                    break;
                case 9:
                    outputLabel.Text = "The electricity ran out the last option is to run to them";
                    Refresh();
                    Thread.Sleep(2000);
                    page = 10;

                    break;
                case 10:
                    outputLabel.Text = "You guys ran to your friends and told them everything";
                    optionButton1.Text = "Run right away";
                    optionButton2.Text = "Find a safe place and make a plan";
                    break;
                case 11:
                    outputLabel.Text = "You and your friends got chased and killed by scary looking creature. \r\n Play Again?";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    break;
                case 12:
                    outputLabel.Text = "You find a house where no one lives there but to keep yourself alive you decide to break into it";
                    optionButton1.Text = "Explore";
                    optionButton2.Text = "No";
                    break;
                case 13:
                    outputLabel.Text = "Your safe! \r\nYou also find a gun, some food and water for temporary, the map to escape.";
                    Refresh();
                    Thread.Sleep(2000);
                    outputLabel.Text = "Your plan is to wait for the electricity to call or go outside and escape yourself";
                    optionButton1.Text = "Wait";
                    optionButton2.Text = "Try escaping";
                    break;
                case 14:
                    outputLabel.Text = "The next day you were killed by the creature\r\nPlay Again?";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    break;
                case 15:
                    outputLabel.Text = "You have waited to long, your resources ran out and the electricity hasn't came you died\r\nPlay Again?";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    break;
                case 16:
                    outputLabel.Text = "According to the map you are on the way to escape. In the morning you realize there is no creature roaming around";
                    Refresh();
                    Thread.Sleep(3000);
                    outputLabel.Text = "They are planning to reach a small hotel and according to the map it will take them 10 hours walk and 6 hours car";
                    optionButton1.Text = "Walk";
                    optionButton2.Text = "Find a Car nearby";
                    break;
                case 17:
                    outputLabel.Text = "You ran out of resources and wasn't able to reach the hotel before evening you got hunted\r\nPlay Again?";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    break;
                case 18:
                    outputLabel.Text = "You found a car after 3 and half hours of walking you have to go 2 more";
                    Refresh();
                    Thread.Sleep(3000);
                    outputLabel.Text = "You reached the hotel successfully and safely but as you were going to it you saw blood and dead bodies of people.";
                    Refresh();
                    Thread.Sleep(3000);
                    outputLabel.Text = "You saw a creature trying to chase you  but lucky you ended up saving yourself in a room. The next morning you saw no creature outside so that made you wonder why the creature are not seen but they can in the night. There is a gas station nearby";
                    optionButton1.Text = "Fuel";
                    optionButton2.Text = "It's fine, keep going";
                    break;
                case 19:
                    outputLabel.Text = "The car stopped mid way and no shelter was there you died\r\nPlay Again?";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    break;
                case 20:
                    outputLabel.Text = "You were close to escaping but suddenly your car got in engine problem ";
                    optionButton1.Text = "Fix it";
                    optionButton2.Text = "Walk 2 hours and escape";
                    break;
                case 21:
                    outputLabel.Text = "You tried but too late\r\nPlay Again?";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    break;
                case 22:
                    optionButton3.Show();
                    outputLabel.Text = "You chose walk for 2 hours but it turn evening and creature are getting outside";
                    optionButton1.Text = "Hide";
                    optionButton2.Text = "Run Separate";
                    optionButton3.Text = "Pull out a gun and stay together";
                    break;
                case 23:
                    optionButton3.Hide();
                    outputLabel.Text = "You and your friend were hunted by different creature\r\nPlay Again?";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    break;
                case 24:
                    outputLabel.Text = "You were run out of bullets you died\r\nPlay Again?";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    break;
                case 25:
                    outputLabel.Text = "You survived the night and was successful escaping ";
                    Refresh();
                    Thread.Sleep(2000);
                    outputLabel.Text = "Game over \r\nPart 2 coming soon!\r\nPlay Again?";
                    optionButton1.Text = "Yes";
                    optionButton2.Text = "No";
                    break;
                case 99:
                    outputLabel.Text = "Thanks for playing!";
                    optionButton1.Text = "";
                    optionButton2.Text = "";

                    optionButton1.Hide();
                    optionButton2.Hide();

                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
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
                page = 12;
            }
            else if (page == 3)
            {
                page = 5;
            }
            else if (page == 4 || page == 5)
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
                page = 1;
            }
            else if (page == 7 && page == 8 && page == 9)
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
                page = 13;
            }
            else if (page == 13)
            {
                page = 16;
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
                page = 25;
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

            DisplayPage();
        }

        private void optionButton2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 11;
            }
            else if (page == 3)
            {
                page = 4;
            }
            else if (page == 4 || page == 5)
            {
                page = 8;
            }
            else if (page == 6)
            {
                page = 99;
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
                page = 11;
            }

            else if (page == 11)
            {
                page = 99;
            }

            else if (page == 12)
            {
                page = 14;
            }
            else if (page == 13)
            {
                page = 15;
            }
            else if (page == 14 && page == 15)
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

            DisplayPage();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            optionButton1.Show();
            optionButton2.Show();
            optionButton3.Hide();

            startButton.Hide();

            page = 1;

            DisplayPage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


