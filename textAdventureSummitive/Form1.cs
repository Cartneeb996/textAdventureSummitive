using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textAdventureSummitive
{
    public partial class Form1 : Form
    {
        Random rndNum = new Random();
        int scene = 0;
        int step = 0;
        int backPressBlock;
        string codeInputText;

        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B)
            {
                if (scene == 0)
                {
                    step = 0;
                    scene = 1;
                }
                else if (scene == 1)
                {
                    step = 1;
                    scene = 3;
                }
                else if (scene == 4)
                {
                    step = 2;
                    scene = 5;
                }
                else if (scene == 14)
                {
                    scene = 16;
                }
                else if (scene == 16)
                {
                    step = 5;
                    scene = 17;
                }
                else if (scene == 18)
                {
                    step = 6;
                    scene = 19;
                }
                else if (scene == 20)
                {
                    step = 7;
                    if (rndNum.Next(1, 11) > 2)
                    {
                        scene = 20;
                    }
                    else
                    {
                        scene = 21;
                    }
                    //reedo chance
                }
                else if (scene == 21)
                {
                    step = 8;
                    scene = 25;

                }
                else if (scene == 22)
                {
                    step = 8;
                    scene = 24;
                }
            }
            else if (e.KeyCode == Keys.R)
            {
                if (scene == 0)
                {
                    step = 0;
                    scene = 2;
                }
                else if (scene == 1)
                {
                    step = 1;
                    scene = 4;
                }
                else if (scene == 4)
                {
                    step = 2;
                    scene = 6;
                }
                else if (scene == 14)
                {
                    scene = 15;
                }
                else if (scene == 16)
                {
                    step = 5;
                    scene = 18;
                }
                else if (scene == 18)
                {
                    step = 6;
                    if (rndNum.Next(1, 11) > 2)
                    {
                        scene = 20;
                    }
                    else
                    {
                        scene = 21;
                    }
                }
                else if (scene == 20)
                {
                    step = 7;
                    //end
                    scene = 22;
                }
                else if (scene == 21)
                {
                    step = 8;
                    scene = 26;
                }
                else if (scene == 22)
                {
                    step = 8;
                    scene = 23;
                }
                else if(scene == 28)
                {
                    scene = 0;
                }
            }
            else if (e.KeyCode == Keys.Y)
            {
                if (scene == 0)
                {
                    scene = 27;
                }
            }
            else if(e.KeyCode == Keys.Back)
            {
                if (backPressBlock != step)
                {
                        
                        Refresh();

                        if (step > 0)
                        {
                            step--;
                        }
                        else
                        {
                            step = 0;
                        }
                        switch (step)
                        {
                            case 0:
                                scene = 0;
                                break;
                            case 1:
                                scene = 1;
                                break;
                            case 2:
                                scene = 4;
                                break;
                            case 3:
                                scene = 6;
                                break;
                            case 4:
                                scene = 14;
                                break;
                            case 5:
                                scene = 16;
                                break;
                            case 6:
                                scene = 18;
                                break;
                            case 7:
                                scene = 20;
                                break;
                            case 8:
                                break;

                        }
                    }
                backPressBlock = step;

            }


            
            switch (scene)
            {
                case 0:
                    outputLabel.Text = "Press R for the red button, press b for the blue button, Y for yellow button\nYou are lost at school what do you do?";
                    rLabel.Text = "Kill yourself";
                    bLabel.Text = "Go outside";
                    yButton.Visible = true;
                    yLabel.Visible = true;
                    step = 0;
                    break;
                case 1:
                    outputLabel.Text = "you went outside, and the sunlight burns your pale skin.\nYou go back inside.";
                    outputLabel.Text += "\nWhich assignment should you work on first?";
                    rLabel.Text = "Programming";
                    bLabel.Text = "English";
                    yButton.Visible = false;
                    yLabel.Visible = false;
                    step = 1;
                    break;
                case 2:
                    outputLabel.Text = "You died";
                    outputLabel.Text += "\ndo you want to restart the game?";
                    bLabel.Text = "No";
                    rLabel.Text = "Yes";
                    yButton.Visible = false;
                    yLabel.Visible = false;
                    backPressBlock = step;
                    scene = 28;
                    break;
                case 3:
                    outputLabel.Text = "You die of boredom";
                    outputLabel.Text += "\ndo you want to restart the game?";
                    bLabel.Text = "No";
                    rLabel.Text = "Yes";
                    backPressBlock = step;
                    scene = 28;
                    break;
                case 4:
                    outputLabel.Text = "You can't find your computer, where will you look?";
                    bLabel.Text = "The gym";
                    rLabel.Text = "The computer lab";
                    step = 2;
                    break;
                case 5:
                    outputLabel.Text = "You can't find your computer, why would you look in the gym?!\nYou miss the due date, stress then have a heart attack and die";
                    outputLabel.Text += "\ndo you want to restart the game?";
                    bLabel.Text = "No";
                    rLabel.Text = "Yes";
                    backPressBlock = step;
                    scene = 28;
                    break;
                case 6:
                    if (rndNum.Next(1, 11) < 9)
                    {
                        outputLabel.Text = "You find your computer, and work on the assignment:\nto create a program to multiply to entered numbers";
                        outputLabel.Text += "\nType in what you want to code";
                        outputLabel.Text += "\nFirst you have to declare a interger input variable";
                        rLabel.Text = "";
                        bLabel.Text = "";
                        codeInput.Visible = true;
                        codeInput.Enabled = true;
                        scene = 7;
                        step = 3;
                    }
                    else
                    {
                        outputLabel.Text = "You can't find your computer, you miss the due date, stress out, then have a heart attack and die";
                        outputLabel.Text += "\ndo you want to restart the game?";
                        bLabel.Text = "No";
                        rLabel.Text = "Yes";
                        backPressBlock = step;
                        scene = 28;
                    }                   
                    break;
                case 14:
                    break;
                case 15:
                    outputLabel.Text = "The teacher likes it but, you are disappointed in yourself";
                    outputLabel.Text += "\ndo you want to restart the game?";
                    bLabel.Text = "No";
                    rLabel.Text = "Yes";
                    backPressBlock = step;
                    scene = 28;
                    break;
                case 16:
                    outputLabel.Text = "How will you improve it?";
                    bLabel.Text = "Graphics";
                    rLabel.Text = "Code";
                    step = 5;
                    break;
                case 17:
                    outputLabel.Text = "You are not good at graphics and end up making it worse, try again";
                    scene = 16;
                    break;
                case 18:
                    outputLabel.Text = "You program it to be super cool, and get an amazing grade\nWill you continue to program like this in future projects?";
                    bLabel.Text = "No";
                    rLabel.Text = "Yes";
                    step = 6;
                    break;
                case 19:
                    outputLabel.Text = "You fail to do anything with your life";
                    outputLabel.Text += "\ndo you want to restart the game?";
                    bLabel.Text = "No";
                    rLabel.Text = "Yes";
                    backPressBlock = step;
                    scene = 28;
                    break;
                case 20:
                    outputLabel.Text = "You fail become a programmer\nWill you try again?";
                    rLabel.Text = "No";
                    bLabel.Text = "Yes";
                    step = 7;
                    break;
                case 21:
                    outputLabel.Text = "You succeed in programming, and become a great programmer\nWhat will you contribute to?";
                    rLabel.Text = "Canadian Arm";
                    bLabel.Text = "A Video Game";
                    step = 8;
                    break;
                case 22:
                    outputLabel.Text = "what will you become then?";
                    rLabel.Text = "Soldier";
                    bLabel.Text = "Nothing";
                    step = 8;
                    break;
                case 23:
                    outputLabel.Text = "You die in combat, (training combat)";
                    outputLabel.Text += "\ndo you want to restart the game?";
                    bLabel.Text = "No";
                    rLabel.Text = "Yes";
                    backPressBlock = step;
                    scene = 28;
                    break;
                case 24:
                    outputLabel.Text = "You do nothing with you life, the end";
                    outputLabel.Text += "\ndo you want to restart the game?";
                    bLabel.Text = "No";
                    rLabel.Text = "Yes";
                    backPressBlock = step;
                    scene = 28;
                    break;
                case 25:
                    outputLabel.Text = "You design one of the best games ever, you live a long and happy life";
                    outputLabel.Text += "\ndo you want to restart the game?";
                    bLabel.Text = "No";
                    rLabel.Text = "Yes";
                    scene = 28;
                    break;
                case 26:
                    outputLabel.Text = "You program the new Canadian Arm";
                    outputLabel.Text += "\ndo you want to restart the game?";
                    bLabel.Text = "No";
                    rLabel.Text = "Yes";
                    scene = 28;
                    break;
                default:
                    break;
                case 27:
                    outputLabel.Text = "You run away and live in the forest";
                    outputLabel.Text += "\ndo you want to restart the game?";
                    bLabel.Text = "No";
                    rLabel.Text = "Yes";
                    yButton.Visible = false;
                    yLabel.Visible = false;
                    scene = 28;
                    break;
                case 28:
                    Close();
                    break;
            }
            
        }

        private void codeInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void codeInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {

                if (scene == 7)
                {
                    step = 3;
                    if (codeInput.Text == "int input;" || codeInput.Text == "int inputNum;" || codeInput.Text == "int inputNumber;")
                    {
                        outputLabel.Text = "that works, now we need to make another input variable" + "\nThe code:\n" + codeInput.Text;
                        codeInputText = codeInput.Text;
                        codeInput.Text = "";
                        scene = 9;
                    }
                    else
                    {
                        outputLabel.Text = "\nhmmm that does not seem to work...";
                        scene = 7;
                    }
                }
                else if (scene == 9)
                {
                    if (codeInput.Text == "int inputB;" || codeInput.Text == "int inputNumB;" || codeInput.Text == "int inputNumberB;")
                    {
                        outputLabel.Text = "that works, now we need to set them to inputboxes: inputA, inputB" + "\nThe code:\n" + codeInputText;
                        outputLabel.Text += "\n" + codeInput.Text;
                        codeInputText += "\n" + codeInput.Text;
                        codeInput.Text = "";
                        scene = 10;
                    }
                    else
                    {
                        outputLabel.Text += "\nhmmm that does not seem to work...";
                        scene = 9;
                    }
                }
                else if (scene == 10)
                {

                    if (codeInput.Text == "input = inputA.Text;" || codeInput.Text == "inputNum =  inputA.Text" || codeInput.Text == "inputNumber = inputA.Text;")
                    {

                        outputLabel.Text = "that works, next input\nThe code:\n" + codeInputText;
                        outputLabel.Text += "\n" + codeInput.Text;
                        codeInputText += "\n" + codeInput.Text;
                        codeInput.Text = "";
                        scene = 11;
                    }
                    else
                    {
                        outputLabel.Text += "\nhmmm that does not seem to work...";
                        scene = 10;
                    }
                }
                else if (scene == 11)
                {
                    if (codeInput.Text == "inputB = inputB.Text;" || codeInput.Text == "inputNumB =  inputB.Text" || codeInput.Text == "inputNumberB = inputB.Text;")
                    {
                        outputLabel.Text = "now create a integer to hold the calculated value\nThe code:\n" + codeInputText;
                        outputLabel.Text += "\n" + codeInput.Text;
                        codeInputText += "\n" + codeInput.Text;
                        codeInput.Text = "";
                        scene = 12;
                    }
                    else
                    {
                        outputLabel.Text += "\nhmmm that does not seem to work...";
                        scene = 11;
                    }
                }
                else if (scene == 12)
                {
                    if (codeInput.Text == "int value = input*inputB;" || codeInput.Text == "int value = inputNum*inputNumB;" || codeInput.Text == "int value = inputNumber*inputNumberB;" || codeInput.Text == "int math = input*inputB;" || codeInput.Text == "int math = inputNum*inputNumB;" || codeInput.Text == "int math = inputNumber*inputNumberB;" || codeInput.Text == "int result = input*inputB;" || codeInput.Text == "int result = input*inputB;" || codeInput.Text == "int result = input*inputB;")
                    {
                        outputLabel.Text = "display the value to the outputLabel\nThe code:\n" + codeInputText;
                        outputLabel.Text += "\n" + codeInput.Text;
                        codeInputText += "\n" + codeInput.Text;
                        codeInput.Text = "";
                        scene = 13;
                    }
                    else
                    {
                        outputLabel.Text += "\nhmmm that does not seem to work...";
                        scene = 12;
                    }
                }
                else if (scene == 13)
                {
                    if (codeInput.Text == "outputLabel.Text = Convert.ToString(value);" || codeInput.Text == "outputLabel.Text = Convert.ToString(math);" || codeInput.Text == "outputLabel.Text = Convert.ToString(result);")
                    {
                        outputLabel.Text = "The code works!! You have extra time do you decide to improve your code?\nThe code:\n" + codeInputText;
                        outputLabel.Text += "\n" + codeInput.Text;
                        codeInputText += "\n" + codeInput.Text;
                        codeInput.Text = "";
                        rLabel.Text = "No";
                        bLabel.Text = "Yes";
                        step = 4;
                        scene = 14;
                        codeInput.Enabled = false;
                        codeInput.Visible = false;
                    }
                    else
                    {
                        outputLabel.Text += "\nhmmm that does not seem to work...";
                        scene = 13;
                        
                        
                    }
                }
            }
        }
    }
}
