using System;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ChessAttempt2
{
    public partial class Form1 : Form
    {
        Piece[32] pieces;
        Label lastPiece = null;
        bool side = true;
        int p1time, p2time;


        public Form1()
        {
            InitializeComponent();
            InitializeBoard();
            Piece.InitCustomLabelFont();

            message.Text = "Click here to start the game!";
        }

        private void InitializeBoard()
        {
            /*foreach (Control c in tableLayoutPanel1.Controls)
            {
                if (c is Label)
                {
                    Label label = c as Label;
                    
                    if (label.Name.StartsWith("row7_"))
                    {
                        label.Font = new System.Drawing.Font(pfc.Families[0], 72);
                        label.Text = "p";
                    }

                    else if (label.Name.StartsWith("row2_"))
                    {
                        label.Font = new System.Drawing.Font(pfc.Families[0], 72);
                        label.Text = "o";
                    }

                    else
                    {
                        for ( int i = 0; i < 8; i++)
                        {
                            if (label.Name == "row8_" + (i+1).ToString())
                            {
                                label.Font = new System.Drawing.Font(pfc.Families[0], 72);
                                label.Text = whitePieces[i].ToString();
                            }

                            else if (label.Name == "row1_" + (i + 1).ToString())
                            {
                                label.Font = new System.Drawing.Font(pfc.Families[0], 72);
                                label.Text = blackPieces[i].ToString();
                            }
                        }
                    }
                }
            }*/

            foreach (int i in {1,2,7,8})
            {

            }


        }

        private void Clocks()
        {

            if (side)
            {
                message.Text = "Player 1's turn!";
            }
            else
            {
                message.Text = "Player 2's turn!";
            }

            //swap clocks/sides
            player1Time.Enabled = !player1Time.Enabled;
            player2Time.Enabled = !player2Time.Enabled;
            
            side = !side;

        }

        private bool validMove()
        {
            return true;
            return false;
        }

        private void game_Start(object sender, EventArgs e)
        {
            message.Click -= game_Start;
            message.Text = null;
            player1.Enabled = true;
            Clocks();
        }
        
        private void label_Click(object sender, EventArgs e)
        {
            resetColor(lastPiece);

            Label label = sender as Label;
            
            label.BackColor = System.Drawing.Color.LightGreen;

            if (validMove())
            {
                Clocks();
            }

            lastPiece = label;
        }

        private void resetColor(Label lastPiece)
        {
            if (lastPiece != null)
            {
                if ((int)(lastPiece.Name[3] - '0') % 2 == 0)
                {
                    if ((int)(lastPiece.Name[5] - '0') % 2 == 0)
                    {
                        lastPiece.BackColor = System.Drawing.Color.White;
                    }
                    else
                    {
                        lastPiece.BackColor = System.Drawing.Color.Gray;
                    }
                }
                else
                {
                    if ((int)(lastPiece.Name[5] - '0') % 2 == 0)
                    {
                        lastPiece.BackColor = System.Drawing.Color.Gray;
                    }
                    else
                    {
                        lastPiece.BackColor = System.Drawing.Color.White;
                    }
                }
            }
        }

        private void player1_Tick(object sender, EventArgs e)
        {
            p1time++;
            player1Time.Text = "P1: " + (TimeSpan.FromSeconds(p1time).ToString(@"hh\:mm\:ss"));
            
        }

        private void player2_Tick(object sender, EventArgs e)
        {
            p2time++;
            player2Time.Text = "P2: " + (TimeSpan.FromSeconds(p2time).ToString(@"hh\:mm\:ss"));
            
        }
    }
}
