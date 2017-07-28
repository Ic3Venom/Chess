using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ChessAttempt2
{
    public partial class Form1 : Form
    {
        List<Piece> pieces = new List<Piece>();
        bool side = false, gameStart = false;
        Label startLabel = null;
        int p1time, p2time;


        public Form1()
        {
            InitializeComponent();
            Piece.InitCustomLabelFont();
            InitializeBoard();

            message.Text = "Click here to begin the game";
        }

        private void InitializeBoard()
        {
            //Wall of text, but it's better than looping through null labels
            pieces.Add(new Piece(Piece.pieceNames[3], 0, row8_1));
            pieces.Add(new Piece(Piece.pieceNames[1], 0, row8_2));
            pieces.Add(new Piece(Piece.pieceNames[2], 0, row8_3));
            pieces.Add(new Piece(Piece.pieceNames[4], 0, row8_4));
            pieces.Add(new Piece(Piece.pieceNames[5], 0, row8_5));
            pieces.Add(new Piece(Piece.pieceNames[2], 0, row8_6));
            pieces.Add(new Piece(Piece.pieceNames[1], 0, row8_7));
            pieces.Add(new Piece(Piece.pieceNames[3], 0, row8_8));
            pieces.Add(new Piece(Piece.pieceNames[3], 1, row1_1));
            pieces.Add(new Piece(Piece.pieceNames[1], 1, row1_2));
            pieces.Add(new Piece(Piece.pieceNames[2], 1, row1_3));
            pieces.Add(new Piece(Piece.pieceNames[4], 1, row1_4));
            pieces.Add(new Piece(Piece.pieceNames[5], 1, row1_5));
            pieces.Add(new Piece(Piece.pieceNames[2], 1, row1_6));
            pieces.Add(new Piece(Piece.pieceNames[1], 1, row1_7));
            pieces.Add(new Piece(Piece.pieceNames[3], 1, row1_8));
            pieces.Add(new Piece(Piece.pieceNames[0], 1, row2_8));
            pieces.Add(new Piece(Piece.pieceNames[0], 0, row7_8));
            pieces.Add(new Piece(Piece.pieceNames[0], 0, row7_1));
            pieces.Add(new Piece(Piece.pieceNames[0], 0, row7_2));
            pieces.Add(new Piece(Piece.pieceNames[0], 0, row7_3));
            pieces.Add(new Piece(Piece.pieceNames[0], 0, row7_4));
            pieces.Add(new Piece(Piece.pieceNames[0], 0, row7_5));
            pieces.Add(new Piece(Piece.pieceNames[0], 0, row7_6));
            pieces.Add(new Piece(Piece.pieceNames[0], 0, row7_7));
            pieces.Add(new Piece(Piece.pieceNames[0], 1, row2_1));
            pieces.Add(new Piece(Piece.pieceNames[0], 1, row2_2));
            pieces.Add(new Piece(Piece.pieceNames[0], 1, row2_3));
            pieces.Add(new Piece(Piece.pieceNames[0], 1, row2_4));
            pieces.Add(new Piece(Piece.pieceNames[0], 1, row2_5));
            pieces.Add(new Piece(Piece.pieceNames[0], 1, row2_6));
            pieces.Add(new Piece(Piece.pieceNames[0], 1, row2_7));
        }

        private void Clocks()
        {
            //swap clocks/sides
            player1Time.Enabled = !player1Time.Enabled;
            player2Time.Enabled = !player2Time.Enabled;
            player1.Enabled = !player1.Enabled;
            player2.Enabled = !player2.Enabled;
            side = !side;

            if (side)
            {
                message.Text = "Player 1's turn!";
            }
            else
            {
                message.Text = "Player 2's turn!";
            }

        }

        private Piece findPiece(Label label)
        {
            foreach (Piece piece in pieces)
            {
                if (label == piece.GetLabel())
                {
                    return piece;
                }
            }
            return new Piece("None", 2, label);
        }

        private void Color(Label piece)
        {
            if (piece != null)
            {
                if ((int)(piece.Name[3] - '0') % 2 == 0)
                {
                    if ((int)(piece.Name[5] - '0') % 2 == 0)
                    {
                        piece.BackColor = System.Drawing.Color.White;
                    }
                    else
                    {
                        piece.BackColor = System.Drawing.Color.Gray;
                    }
                }
                else
                {
                    if ((int)(piece.Name[5] - '0') % 2 == 0)
                    {
                        piece.BackColor = System.Drawing.Color.Gray;
                    }
                    else
                    {
                        piece.BackColor = System.Drawing.Color.White;
                    }
                }
            }
        }

        private void game_Start(object sender, EventArgs e)
        {
            message.Click -= game_Start;
            message.Text = "Player 1's turn!";

            gameStart = !gameStart;

            //Need to flip player1/player2 after game starts
            player1Time.Enabled = true;
            player1.Enabled = true;
            side = true;
            
        }

        private void label_Click(object sender, EventArgs e)
        {
            if (gameStart)
            {
                Color(startLabel);

                Label endLabel = sender as Label;

                endLabel.BackColor = System.Drawing.Color.PaleGreen; //System.Drawing.Color.LightGreen;
                

                if (startLabel == null)
                {
                    startLabel = endLabel;
                    return;
                }
                
                Piece start = findPiece(startLabel);
                Piece end = findPiece(endLabel);

                if (start == end)
                {
                    Color(endLabel);
                    startLabel = null;
                    endLabel = null;
                }
                else if (Piece.ValidateMove(start, end, side))
                {
                    start.Move(end);
                    pieces.Remove(end);
                    Color(endLabel);

                    startLabel = null;
                    Clocks();
                }
                else
                {
                    startLabel = endLabel;
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
