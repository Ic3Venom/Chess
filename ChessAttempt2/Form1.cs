using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Reflection;

namespace ChessAttempt2
{
    public partial class Form1 : Form
    {
        List<Piece> pieces = new List<Piece>();
        Label lastPiece = null;
        bool side = true;
        int p1time, p2time;


        public Form1()
        {
            InitializeComponent();
            Piece.InitCustomLabelFont();
            InitializeBoard();
            

            message.Text = "Press anywhere to begin the game!";
        }

        private void InitializeBoard()
        {
            //Wall of text, but it's better than looping through null labels
            pieces.Add(new Piece("Rook",   true,  row8_1));
            pieces.Add(new Piece("Knight", true,  row8_2));
            pieces.Add(new Piece("Bishop", true,  row8_3));
            pieces.Add(new Piece("Queen",  true,  row8_4));
            pieces.Add(new Piece("King",   true,  row8_5));
            pieces.Add(new Piece("Bishop", true,  row8_6));
            pieces.Add(new Piece("Knight", true,  row8_7));
            pieces.Add(new Piece("Rook",   true,  row8_8));
            pieces.Add(new Piece("Rook",   false, row1_1));
            pieces.Add(new Piece("Knight", false, row1_2));
            pieces.Add(new Piece("Bishop", false, row1_3));
            pieces.Add(new Piece("Queen",  false, row1_4));
            pieces.Add(new Piece("King",   false, row1_5));
            pieces.Add(new Piece("Bishop", false, row1_6));
            pieces.Add(new Piece("Knight", false, row1_7));
            pieces.Add(new Piece("Rook",   false, row1_8));
            pieces.Add(new Piece("Pawn", true,  row7_1));
            pieces.Add(new Piece("Pawn", true,  row7_2));
            pieces.Add(new Piece("Pawn", true,  row7_3));
            pieces.Add(new Piece("Pawn", true,  row7_4));
            pieces.Add(new Piece("Pawn", true,  row7_5));
            pieces.Add(new Piece("Pawn", true,  row7_6));
            pieces.Add(new Piece("Pawn", true,  row7_7));
            pieces.Add(new Piece("Pawn", true,  row7_8));
            pieces.Add(new Piece("Pawn", false, row2_1));
            pieces.Add(new Piece("Pawn", false, row2_2));
            pieces.Add(new Piece("Pawn", false, row2_3));
            pieces.Add(new Piece("Pawn", false, row2_4));
            pieces.Add(new Piece("Pawn", false, row2_5));
            pieces.Add(new Piece("Pawn", false, row2_6));
            pieces.Add(new Piece("Pawn", false, row2_7));
            pieces.Add(new Piece("Pawn", false, row2_8));
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

            if (Piece.ValidateMove(lastPiece, label))
                Clocks();

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
