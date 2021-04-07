using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
//Ryan Prosper 2021/04/07

namespace The_Loop
{
    public partial class TheEndlessLoop : Form
    {
        int scene = 0;
        int key = 0;
        public TheEndlessLoop()
        {
            //Starting Scene
            InitializeComponent();
            outputLabel.Text = "Welcome To The Loop Try to Escape";
            yLabel.Text = "Start";
            rLabel.Text = "Close Game";
            gLabel.Visible = false;
            bLabel.Visible = false;
            gImage.Visible = false;
            bImage.Visible = false;
            picBox.Visible = false;
        }
        private void TheEndlessLoop_KeyDown(object sender, KeyEventArgs e)
        {
            Random randGen = new Random();
            int value = randGen.Next(1, 11);
            //The Yellow Scenes or the Up arrow key 
            if (e.KeyCode == Keys.Up)
            {
                if (scene == 0)
                {
                    scene = 1;
                }

                else if (scene == 1)
                {
                    if (value > 1)
                    {
                        scene = 3;
                    }
                    else
                    {
                        scene = 2;
                    }
                }

                else if (scene == 2)
                {
                    scene = 98;
                }

                else if (scene == 3) 
                {
                    scene = 4;
                }

                else if (scene == 4)
                {
                    scene = 1;
                }

                else if (scene == 5)
                {
                    scene = 99;
                }

                else if (scene == 6)
                {
                    scene = 13;
                }

                else if (scene == 7)
                {
                    scene = 8;
                }

                else if (scene == 8)
                {
                    scene = 98;
                }

                else if (scene == 9)
                {
                    scene = 98;
                }

                else if (scene == 10)
                {
                    scene = 98;
                }

                else if (scene == 11)
                {
                    scene = 98;
                }

                else if (scene == 12)
                {
                    scene = 98;
                }

                else if (scene == 13)
                {
                    scene = 15;
                }

                else if (scene == 14)
                {
                    scene = 13;
                }

                else if (scene == 15)
                {
                    scene = 97;
                }

                else if (scene == 16)
                {
                    scene = 98;
                }

                else if (scene == 17)
                {
                    scene = 18;
                }

                else if (scene == 18)
                {
                    scene = 99;
                }

                else if (scene == 18)
                {
                    scene = 99;
                }

                else if (scene == 19)
                {
                    scene = 99;
                }

                else if (scene == 20)
                {
                    scene = 22;
                }

                else if (scene == 21)
                {
                    scene = 99;
                }

                else if (scene == 22)
                {
                    scene = 98;
                }

                else if (scene == 23)
                {
                    scene = 15;
                }

                else if (scene == 24)
                {
                    scene = 8;
                }

                else if (scene == 25)
                {
                    scene = 99;
                }

                else if (scene == 26)
                {
                    scene = 27;
                }

                else if (scene == 27)
                {
                    scene = 99;
                }

                else if (scene == 28)
                {
                    scene = 98;
                }

                else if (scene == 29)
                {
                    scene = 99;
                }

                else if (scene == 30)
                {
                    scene = 98;
                }

                else if (scene == 31)
                {
                    scene = 99;
                }

                else if (scene == 97)
                {
                    scene = 100;
                }

                else if (scene == 98)
                {
                    scene = 100;
                }

                else if (scene == 99)
                {
                    scene = 100;
                }
            }
            
            //The Yellow Scenes or the Down arrow key 
            if (e.KeyCode == Keys.Down)
            {
                if (scene == 1)
                {
                    scene = 17;
                }

                else if (scene == 3)
                {
                    scene = 5;
                }

                else if (scene == 7)
                {
                    if (value > 1)
                    {
                        scene = 9;
                    }
                    else
                    {
                        scene = 11;
                    }
                }

                else if (scene == 13)
                {
                    scene = 1;
                }

                else if (scene == 17)
                {
                    scene = 1;
                }

                else if (scene == 20)
                {
                    scene = 23;
                }

                else if (scene == 26)
                {
                    scene = 31;
                }
                

            }

            //The Yellow Scenes or the Right arrow key 
            if (e.KeyCode == Keys.Right)
            {
                if (scene == 0)
                {
                    scene = 100;
                }

                else if (scene == 1)
                {
                    scene = 26;
                }

                else if (scene == 3)
                {
                    scene = 98;
                }

                else if (scene == 6)
                {
                    scene = 7;
                }

                else if (scene == 7)
                {
                    scene = 14;
                }

                else if (scene == 13)
                {
                    scene = 16;
                }

                else if (scene == 17)
                {
                    scene = 16;
                }

                else if (scene == 20)
                {
                    scene = 21;
                }

                else if (scene == 20)
                {
                    scene = 21;
                }

                else if (scene == 26)
                {
                    scene = 28;
                }

                else if (scene == 97)
                {
                    scene = 1;
                }

                else if (scene == 98)
                {
                    scene = 1;
                }

                else if (scene == 99)
                {
                    scene = 1;
                }
            }

            //The Yellow Scenes or the Left arrow key 
            if (e.KeyCode == Keys.Left)
            {
                if (scene == 1)
                    {
                        if (value > 5)
                        {
                            scene = 1;
                        }
                        else
                        {
                            scene = 25;
                        }
                    }

                else if (scene == 3)
                {
                    scene = 6;
                }

                else if (scene == 7)
                {
                    if (value > 9)
                    {
                        scene = 12;
                    }
                    else
                    {
                        scene = 10;
                    }
                }

                else if (scene == 13)
                {
                    scene = 8;
                }

                else if (scene == 17)
                {
                    if (value > 5)
                    {
                        scene = 19;
                    }
                    else
                    {
                        scene = 20;
                    }
                }

                else if (scene == 20)
                {
                    scene = 24;
                }

                else if (scene == 20)
                {
                    scene = 24;
                }

                else if (scene == 26)
                {
                    if (value > 5)
                    {
                        scene = 30;
                    }
                    else
                    {
                        scene = 29;
                    }
                }
            }

            //The different Scenes 
            switch (scene)
               
            {
                case 1:
                    picBox.BackgroundImage = Properties.Resources.Alarm;
                    SoundPlayer Scene_1 = new SoundPlayer(Properties.Resources.Alarm_Clock);
                    Scene_1.Play();
                    outputLabel.Text ="You awake to the sound of your annoying ass alarm clock. What should you do?";
                    yLabel.Text = "Kick The Alarm Clock into the wall";
                    rLabel.Text = "Get Up to turn it off ";
                    gLabel.Text = "Realize Your running late for your friends party";
                    bLabel.Text = "Chill and wait for it to go off";
                    gLabel.Visible = true;
                    bLabel.Visible = true;
                    gImage.Visible = true;
                    bImage.Visible = true;
                    rLabel.Visible = true;
                    rImage.Visible = true;
                    picBox.Visible = true;
                    Refresh();
                    break;

                case 2:
                    picBox.BackgroundImage = Properties.Resources.Scene_2;
                    outputLabel.Text = "The Alarm Somehow flew back and nailed you in the head, you start to bleed out.";
                    yLabel.Text = "Start Over";
                    rLabel.Text = "Close Game";
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    Refresh();
                    break;

                case 3:
                    picBox.BackgroundImage = Properties.Resources.Scene_3;
                    outputLabel.Text = "You destroy the alarm clock yet victorious, the pain of losing such a beloved clock fills you, You decide to get up from grief What Should you do next  ";
                    yLabel.Text = "Go onto amazon";
                    rLabel.Text = "End it the alarm clock was to special";
                    gLabel.Text = "Continue kicking the alarm clock";
                    bLabel.Text = "Walk into the kitchen";
                    gLabel.Visible = true;
                    bLabel.Visible = true;
                    gImage.Visible = true;
                    bImage.Visible = true;
                    rLabel.Visible = true;
                    rImage.Visible = true;
                    Refresh();
                    break;

                case 4:
                    picBox.BackgroundImage = Properties.Resources.Scene_4;
                    outputLabel.Text = "You Head to the computer and buy the exact same alarm clock and head to bed.";
                    yLabel.Text = "Head To bed";
                    rLabel.Visible = false;
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    rImage.Visible = false;
                    Refresh();
                    break;

                case 5:
                    picBox.BackgroundImage = Properties.Resources.Scene_5;
                    outputLabel.Text = "You're Pain goes away into enjoyment no more of the alarm clock ";
                    yLabel.Text = "Continue";
                    rLabel.Visible = false;
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    rImage.Visible = false;
                    Refresh();

                    break;

                case 6:
                    picBox.BackgroundImage = Properties.Resources.Scene_6;
                    outputLabel.Text = "You remember your keys are on your night stand. You think, Do I want to grab them now or later?";
                    yLabel.Text = "Now";
                    rLabel.Text = "Later";
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    Refresh();
                    break;

                case 7:
                    picBox.BackgroundImage = Properties.Resources.Scene_7;
                    outputLabel.Text = "You decided that its easier to go shower then grab your keys. You ask yourself what to do next?";
                    yLabel.Text = "Start Shower";
                    rLabel.Text = "Go back for keys";
                    gLabel.Text = "Start Bath";
                    bLabel.Text = "Wait for the shower to get warm";
                    gLabel.Visible = true;
                    bLabel.Visible = true;
                    gImage.Visible = true;
                    bImage.Visible = true;
                    rLabel.Visible = true;
                    rImage.Visible = true;
                    Refresh();
                    break;


                case 8:
                    picBox.BackgroundImage = Properties.Resources.Scene_8;
                    outputLabel.Text = "The Showers now started and looks nice and warm. You hop in the shower. All the sudden your skin starts melting off of your body.What a World...What a World!";
                    yLabel.Text = "Continue";
                    rLabel.Visible = false;
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    rImage.Visible = false;
                    break;

                case 9:
                    picBox.BackgroundImage = Properties.Resources.Scene_9;
                    outputLabel.Text = "While Waiting for the bath to fill. You notice that the the water is acid you try and run out but a mysterious figure pushes you into the acid. Probably should have went for the keys";
                    yLabel.Text = "Continue";
                    rLabel.Visible = false;
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    rImage.Visible = false;
                    Refresh();
                    break;

                case 10:
                    picBox.BackgroundImage = Properties.Resources.Scene_8;
                    outputLabel.Text = "While Waiting you notice that the the water is acid you try and run out but a mysterious figure pushes you into the acid.";
                    yLabel.Text = "Continue";
                    rLabel.Visible = false;
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    rImage.Visible = false;
                    Refresh();
                    break;

                case 11:
                    picBox.BackgroundImage = Properties.Resources.Scene_9;
                    outputLabel.Text = "The Bath now started and looks nice and warm. You hop in the bath. All the sudden your skin starts melting off of your body. Looks like someone made soup in the bath oh nevermind that's just you";
                    yLabel.Text = "Continue";
                    rLabel.Visible = false;
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    rImage.Visible = false;
                    Refresh();
                    break;

                case 12:
                    picBox.BackgroundImage = Properties.Resources.Scene_8;
                    outputLabel.Text = "The Bath now started and looks nice and warm. You hop in the bath. All the sudden your skin starts melting off of your body. Looks like someone made soup in the bath oh nevermind that's just you";
                    yLabel.Text = "Continue";
                    rLabel.Visible = false;
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    rImage.Visible = false;
                    Refresh();
                    break;

                case 13:
                    picBox.BackgroundImage = Properties.Resources.Scene_13;
                    outputLabel.Text = "You put the key into your pocket and continue into the kitchen. You ponder what your doing there? then remember...";
                    yLabel.Text = "I was going to work ";
                    rLabel.Text = "Ah I was going to make Breakfast";
                    gLabel.Text = "You Decide to go back asleep";
                    bLabel.Text = "I was heading to the bathroom to shower";
                    gLabel.Visible = true;
                    bLabel.Visible = true;
                    gImage.Visible = true;
                    bImage.Visible = true;
                    rLabel.Visible = true;
                    rImage.Visible = true;
                    Refresh();
                    break;

                case 14:
                    picBox.BackgroundImage = Properties.Resources.Scene_13;
                    key++;
                    outputLabel.Text = "You remember your keys are on your night stand. You think, I want to grab them now.";
                    yLabel.Text = "Now";
                    rLabel.Visible = false;
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    rImage.Visible = false;
                    Refresh();
                    break;

                case 15:
                    picBox.BackgroundImage = Properties.Resources.Scene_7;
                    outputLabel.Text = "You Remember you're late for work you rush out the door you open the door and leave promptly";
                    yLabel.Text = "Continue";
                    rLabel.Visible = false;
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    rImage.Visible = false;
                    Refresh();
                    break;

                case 16:
                    picBox.BackgroundImage = Properties.Resources.Scene_16;
                    outputLabel.Text = "You go to make breakfast and notice one of your knifes are missing. Then the lights go on and off and notice your favorite knife is in your back";
                    yLabel.Text = "Continue";
                    rLabel.Visible = false;
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    rImage.Visible = false;
                    Refresh();
                    break;

                case 17:
                    picBox.BackgroundImage = Properties.Resources.Alarm;
                    outputLabel.Text = "You rush up to get out as soon as possible you don't even remember to get breakfast When You realize";
                    yLabel.Text = "I Have no friends";
                    rLabel.Text = "I've Got time for breakfast";
                    gLabel.Text = "I Don't want to go I'm Heading to bed";
                    bLabel.Text = "I Forgot the gift at home";
                    gLabel.Visible = true;
                    bLabel.Visible = true;
                    gImage.Visible = true;
                    bImage.Visible = true;
                    rLabel.Visible = true;
                    rImage.Visible = true;
                    Refresh();
                    break;

                case 18:
                    picBox.BackgroundImage = Properties.Resources.Game_Over;
                    outputLabel.Text = "You remember the fact you have no friends but you're fine with that.";
                    yLabel.Text = "End Game";
                    rLabel.Visible = false;
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    rImage.Visible = false;
                    Refresh();
                    break;

                case 19:
                    picBox.BackgroundImage = Properties.Resources.Scene_19;
                    outputLabel.Text = "You rush home to find the gift. You grab the axe for your friend and rush to the party. He Loved it!";
                    yLabel.Text = "Continue";
                    rLabel.Visible = false;
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    rImage.Visible = false;
                    Refresh();
                    break;

                case 20:
                    picBox.BackgroundImage = Properties.Resources.Scene_13;
                    outputLabel.Text = "You rush home to find the gift. You notice the axe for your friend is not in the same place where should look first?";
                    yLabel.Text = "Closet";
                    rLabel.Text = "Fridge";
                    gLabel.Text = "Bedroom";
                    bLabel.Text = "Bathroom";
                    gLabel.Visible = true;
                    bLabel.Visible = true;
                    gImage.Visible = true;
                    bImage.Visible = true;
                    rLabel.Visible = true;
                    rImage.Visible = true;
                    Refresh();
                    break;

                case 21:
                    picBox.BackgroundImage = Properties.Resources.Scene_21;
                    outputLabel.Text = "Ha Funny But no its not in the fridge. Here Take a free win on me.";
                    yLabel.Text = "Continue";
                    rLabel.Visible = false;
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    rImage.Visible = false;
                    Refresh();
                    break;

                case 22:
                    picBox.BackgroundImage = Properties.Resources.Scene_19;
                    outputLabel.Text = "Not in here but I found someone in there. With my axe oh...";
                    yLabel.Text = "Continue";
                    rLabel.Visible = false;
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    rImage.Visible = false;
                    Refresh();
                    break;

                case 23:
                    picBox.BackgroundImage = Properties.Resources.Scene_6;
                    outputLabel.Text = "The axe isn't in here but my keys are I take them just in case";
                    yLabel.Text = "Grab keys";
                    rLabel.Visible = false;
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    rImage.Visible = false;
                    break;

                case 24:
                    picBox.BackgroundImage = Properties.Resources.Scene_8;
                    outputLabel.Text = "Well the axe is not in the bathroom but hey I should probably take a shower";
                    yLabel.Text = "Head to the Shower";
                    rLabel.Visible = false;
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    rImage.Visible = false;
                     Refresh();
                    break;

                case 25:
                    picBox.BackgroundImage = Properties.Resources.Alarm;
                    outputLabel.Text = "It goes off and with complete quite you start your day off right";
                    yLabel.Text = "Continue";
                    rLabel.Visible = false;
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    rImage.Visible = false;
                    Refresh();
                    break;

                case 26:
                    picBox.BackgroundImage = Properties.Resources.Alarm;
                    outputLabel.Text = "You get up to turn the clock off and hear footsteps outside your door.What's your next move?";
                    yLabel.Text = "Head for the door with nothing";
                    rLabel.Text = "Get the keys and leave";
                    gLabel.Text = "Grab a axe and fight";
                    bLabel.Text = "Pray";
                    gLabel.Visible = true;
                    bLabel.Visible = true;
                    gImage.Visible = true;
                    bImage.Visible = true;
                    rLabel.Visible = true;
                    rImage.Visible = true;
                    Refresh();
                    break;

                case 27:
                    outputLabel.Text = "Turns out it was nothing";
                    yLabel.Text = "Continue";
                    rLabel.Visible = false;
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    rImage.Visible = false;
                    Refresh();
                    break;

                case 28:
                    picBox.BackgroundImage = Properties.Resources.Scene_13;
                    outputLabel.Text = "The Person see's you going for the keys and slices you in half.Clean cut can't lie";
                    yLabel.Text = "Continue";
                    rLabel.Visible = false;
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    rImage.Visible = false;
                    Refresh();
                    break;

                case 29:
                    picBox.BackgroundImage = Properties.Resources.pixel_Vic_Roy;
                    outputLabel.Text = "God Heard your prayers and decided smite the person who was coming to kill you";
                    yLabel.Text = "Continue";
                    rLabel.Visible = false;
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    rImage.Visible = false;
                    Refresh();
                    break;

                case 30:
                    picBox.BackgroundImage = Properties.Resources.Scene_16;
                    outputLabel.Text = "The Figure heard you praying and slashed you. I don't think he likes god that much";
                    yLabel.Text = "Continue";
                    rLabel.Visible = false;
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    rImage.Visible = false;
                    Refresh();
                    break;

                case 31:
                    picBox.BackgroundImage = Properties.Resources.Scene_16;
                    outputLabel.Text = "Dear god you did a number on the killer like wow I mean your safe but at what cost...";
                    yLabel.Text = "Continue";
                    rLabel.Visible = false;
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    rImage.Visible = false;
                    Refresh();
                    break;

                case 97:
                    picBox.BackgroundImage = Properties.Resources.Scene_6;
                    outputLabel.Text = "That key came in handy";
                    yLabel.Text = "End Game";
                    rLabel.Text = "Start Over";
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    rLabel.Visible = true;
                    rImage.Visible = true;
                    Refresh();
                    break;

                case 98:
                    picBox.BackgroundImage = Properties.Resources.Game_Over;
                    outputLabel.Text = "You Lose";
                    yLabel.Text = "End Game";
                    rLabel.Text = "Start Over";
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    rLabel.Visible = true;
                    rImage.Visible = true;
                    Refresh();
                    break;

                case 99:
                    picBox.BackgroundImage = Properties.Resources.pixel_Vic_Roy;
                    outputLabel.Text = "You Win";
                    yLabel.Text = "End Game";
                    rLabel.Text = "Start Over";
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    rLabel.Visible = true;
                    rImage.Visible = true;
                    Refresh();
                    break;

                case 100:
                    outPutlable2.Text = "Closing Game";
                    outputLabel.Visible = false;
                    Refresh();
                    yLabel.Visible = false;
                    gLabel.Visible = false;
                    bLabel.Visible = false;
                    gImage.Visible = false;
                    bImage.Visible = false;
                    rImage.Visible = false;
                    yImage.Visible = false;
                    rLabel.Visible = false;
                    picBox.Visible = false;
                    Thread.Sleep(1500);
                    Application.Exit();
                    break;
            }
        }

        private void TheEndlessLoop_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BLabel_Click(object sender, EventArgs e)
        {

        }
    }

}
