using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Final_
{
    public partial class frmGame : Form
    {
        bool player_turn = true;
        int turn_count = 0; 

        public frmGame()
        {
            InitializeComponent();

            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            player_turn = true;
            lblTurnDisplay.Text = "Player X's Turn";

            btnX.Enabled = false;
            btnO.Enabled = false;

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

        }

        private void btnO_Click(object sender, EventArgs e)
        {
            player_turn = false;
            lblTurnDisplay.Text = "Player O's Turn";

            btnX.Enabled = false;
            btnO.Enabled = false;

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lblTurnDisplay.Text = "";
            turn_count = 0;

            btnX.Enabled = true;
            btnO.Enabled = true;

            btn1.Text = "";
            btn1.Enabled = false;

            btn2.Text = "";
            btn2.Enabled = false;

            btn3.Text = "";
            btn3.Enabled = false;

            btn4.Text = "";
            btn4.Enabled = false;

            btn5.Text = "";
            btn5.Enabled = false;

            btn6.Text = "";
            btn6.Enabled = false;

            btn7.Text = "";
            btn7.Enabled = false;

            btn8.Text = "";
            btn8.Enabled = false;

            btn9.Text = "";
            btn9.Enabled = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrid_click(object sender, EventArgs e)
        {
            Button btnGrid = (Button)sender;

            if (player_turn == true)
            {
                btnGrid.Text = "X";
                lblTurnDisplay.Text = "Player O's Turn";
            }

            else
            {
                btnGrid.Text = "O";
                lblTurnDisplay.Text = "Player X's Turn";
            }

            player_turn = !player_turn;
            btnGrid.Enabled = false;
            turn_count++;

            checker();
        }

        private void checker()
        {
            bool player_winner = false;

            //vertical patterns 
            if ((btn1.Text == btn4.Text) && (btn4.Text == btn7.Text) && (!btn1.Enabled))
                player_winner = true;
            else if ((btn2.Text == btn5.Text) && (btn5.Text == btn8.Text) && (!btn2.Enabled))
                player_winner = true;
            else if ((btn3.Text == btn6.Text) && (btn3.Text == btn9.Text) && (!btn3.Enabled))
                player_winner = true;

            //horizontal patterns 
            else if ((btn1.Text == btn2.Text) && (btn1.Text == btn3.Text) && (!btn1.Enabled))
                player_winner = true;
            else if ((btn4.Text == btn5.Text) && (btn4.Text == btn6.Text) && (!btn4.Enabled))
                player_winner = true;
            else if ((btn7.Text == btn8.Text) && (btn7.Text == btn9.Text) && (!btn7.Enabled))
                player_winner = true;

            //diagonal patterns
           else if ((btn1.Text == btn5.Text) && (btn1.Text == btn9.Text) && (!btn1.Enabled))
                player_winner = true;
           else if ((btn3.Text == btn5.Text) && (btn3.Text == btn7.Text) && (!btn3.Enabled))
                player_winner = true;

            if (player_winner == true)
            {
                string player = "";
                if (player_turn)
                    player = "O";
                else
                    player = "X";

                MessageBox.Show("Player " + player + " wins!");

                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;

                turn_count = 0;
            }
            else if (turn_count == 9)
            {
                MessageBox.Show("It's a Draw!");
                turn_count = 0;
            }
        }

    }
}
