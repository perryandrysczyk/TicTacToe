using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticTacToe
{
	public partial class Form1 : Form
	{
		//variable to decide if button is x or o
		bool isClicked = false;


		public Form1()
		{

			InitializeComponent();

		}


		private void buttonClick(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			//if button click is flase print o, if true print x
			isClicked = !isClicked;
			if (isClicked == true)
			{ button.Text = "X"; }
			else if (isClicked == false)
			{ button.Text = "O"; }


			//find a winner			
			if (button1.Text == button2.Text && button1.Text == button3.Text)
			{
                MessageBox.Show(button1.Text + " Wins!", "Game Over!");            
            }

			else if (button1.Text == button5.Text && button1.Text == button9.Text)
			{
                MessageBox.Show(button1.Text + " Wins!", "Game Over!");
            }

            else if (button1.Text == button4.Text && button1.Text == button7.Text)
			{
                MessageBox.Show(button1.Text + " Wins!", "Game Over!");
            }

            else if (button2.Text == button5.Text && button5.Text == button8.Text)
			{
                MessageBox.Show(button2.Text + " Wins!", "Game Over!");
            }

            else if (button3.Text == button5.Text && button3.Text == button7.Text)
			{
                MessageBox.Show(button3.Text + " Wins!", "Game Over!");
            }

            else if (button3.Text == button6.Text && button3.Text == button9.Text)
			{
                MessageBox.Show(button3.Text + " Wins!", "Game Over!");
            }

            else if (button4.Text == button5.Text && button4.Text == button6.Text)
			{
                MessageBox.Show(button4.Text + " Wins!", "Game Over!");
            }

            else if (button7.Text == button8.Text && button7.Text == button9.Text)
			{
                MessageBox.Show(button7.Text + " Wins!" ,"Game Over!");
            }




        }


	}
}
