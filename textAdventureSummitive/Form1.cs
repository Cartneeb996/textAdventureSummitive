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
        string codeInputText;

        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.B)
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if(scene == 1)
                {
                    scene = 3;
                }
                else if(scene == 4)
                {
                    scene = 5;                   
                }
            }
            else if(e.KeyCode == Keys.R)
            {
                if(scene == 0)
                {
                    scene = 2;
                }
                else if(scene == 1)
                {
                    scene = 4;
                }
                else if(scene == 4)
                {
                    scene = 6;
                }
                
            }
            switch (scene)
            {
                case 0:
                    break;
                case 1:
                    outputLabel.Text = "you went outside, and the sunlight burns your pale skin.\nYou go back inside.";
                    outputLabel.Text += "\nWhich assignment should you work on first?";
                    rLabel.Text = "Programming";
                    bLabel.Text = "English";
                    break;
                case 2:
                    outputLabel.Text = "You died";
                    break;
                case 3:
                    outputLabel.Text = "You die of boredom";
                    break;
                case 4:
                    outputLabel.Text = "You can't find your computer, where will you look?";
                    bLabel.Text = "The gym";
                    rLabel.Text = "The computer lab";                 
                    break;
                case 5:
                    outputLabel.Text = "You can't find your computer, why would you look in the gym?!\nYou miss the due date, stress then have a heart attack and die";
                    break;
                case 6:
                    if (rndNum.Next(1, 11) < 9)
                    {
                        outputLabel.Text = "You find your computer, and work on the assignment:\nto create a program to multiply to entered numbers";
                        outputLabel.Text += "\nType in what you want to code";
                        outputLabel.Text += "\nFirst you have to declare a interger input variable";
                        codeInput.Visible = true;
                        scene = 7;
                    }
                    else
                    {
                        outputLabel.Text = "You can't find your computer, you miss the due date, stress out, then have a heart attack and die";
                    }                   
                    break;
                case 7:
                    outputLabel.Text += "\nThe code:\n" + codeInputText;
                    break;
                case 8:
                    outputLabel.Text = "hmmm that does not seem to work...";
                    scene = 7;
                    break;
                case 9:
                    outputLabel.Text = "that works, now we need to make another input variable " + "\nThe code:\n" + codeInputText;
                    break;
                case 10:
                    outputLabel.Text = "that works, now we need to set them to inputboxes: inputA, inputB " + "\nThe code:\n" + codeInputText;
                    break;
                default:
                    break;
            }
        }

        private void codeInput_TextChanged(object sender, EventArgs e)
        {
            codeInputText = codeInput.Text;
            
        }

        private void codeInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                outputLabel.Text += "\n" + codeInputText;
                if (scene == 7)
                {
                    if (codeInput.Text == "int input;" || codeInput.Text == "int inputNum;" || codeInput.Text == "int inputNumber;")
                    {
                        outputLabel.Text = "that works, now we need to make another input variable" + "\nThe code:\n" + codeInput.Text;
                        codeInputText = codeInput.Text;
                        scene = 9;
                    }
                    else
                    {
                        outputLabel.Text = "hmmm that does not seem to work...";
                        scene = 7;
                    }
                }
                else if(scene == 9)
                {
                    if (codeInput.Text == "int inputB;" || codeInput.Text == "int inputNumB;" || codeInput.Text == "int inputNumberB;")
                    {
                        codeInputText += "\n" + codeInput.Text;
                        outputLabel.Text = "that works, now we need to set them to inputboxes: inputA, inputB" + "\nThe code:\n" + codeInputText; 
                        
                        scene = 10;
                    }
                    else
                    {
                        outputLabel.Text += "hmmm that does not seem to work...";
                        scene = 7;
                    }
                }
                else if(scene == 10)
                {

                    if(codeInput.Text == "input = inputA.Text;" || codeInput.Text == "inputNum =  inputA.Text" || codeInput.Text == "inputNumber = inputNumber.Text;")
                    {
                        codeInputText += "\n" + codeInput.Text;
                        outputLabel.Text = "that works, next input" + "\nThe code:\n" + codeInputText;
                    }//
                }
            }
        }
    }
}
