using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ChessAttempt2
{
    public partial class Form1 : Form
    {
        List<Piece> pieces = new List<Piece>();
        Label lastPiece = null;
        bool side = true, gameStart = false, moved = false;
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
            pieces.Add(new Piece(Piece.pieceNames[3], true,  row8_1));
            pieces.Add(new Piece(Piece.pieceNames[1], true,  row8_2));
            pieces.Add(new Piece(Piece.pieceNames[2], true,  row8_3));
            pieces.Add(new Piece(Piece.pieceNames[4], true,  row8_4));
            pieces.Add(new Piece(Piece.pieceNames[5], true,  row8_5));
            pieces.Add(new Piece(Piece.pieceNames[2], true,  row8_6));
            pieces.Add(new Piece(Piece.pieceNames[1], true,  row8_7));
            pieces.Add(new Piece(Piece.pieceNames[3], true,  row8_8));
            pieces.Add(new Piece(Piece.pieceNames[3], false, row1_1));
            pieces.Add(new Piece(Piece.pieceNames[1], false, row1_2));
            pieces.Add(new Piece(Piece.pieceNames[2], false, row1_3));
            pieces.Add(new Piece(Piece.pieceNames[4], false, row1_4));
            pieces.Add(new Piece(Piece.pieceNames[5], false, row1_5));
            pieces.Add(new Piece(Piece.pieceNames[2], false, row1_6));
            pieces.Add(new Piece(Piece.pieceNames[1], false, row1_7));
            pieces.Add(new Piece(Piece.pieceNames[3], false, row1_8));
            pieces.Add(new Piece(Piece.pieceNames[0], false, row2_8));
            pieces.Add(new Piece(Piece.pieceNames[0], true,  row7_1));
            pieces.Add(new Piece(Piece.pieceNames[0], true,  row7_2));
            pieces.Add(new Piece(Piece.pieceNames[0], true,  row7_3));
            pieces.Add(new Piece(Piece.pieceNames[0], true,  row7_4));
            pieces.Add(new Piece(Piece.pieceNames[0], true,  row7_5));
            pieces.Add(new Piece(Piece.pieceNames[0], true,  row7_6));
            pieces.Add(new Piece(Piece.pieceNames[0], true,  row7_7));
            pieces.Add(new Piece(Piece.pieceNames[0], true,  row7_8));
            pieces.Add(new Piece(Piece.pieceNames[0], false, row2_1));
            pieces.Add(new Piece(Piece.pieceNames[0], false, row2_2));
            pieces.Add(new Piece(Piece.pieceNames[0], false, row2_3));
            pieces.Add(new Piece(Piece.pieceNames[0], false, row2_4));
            pieces.Add(new Piece(Piece.pieceNames[0], false, row2_5));
            pieces.Add(new Piece(Piece.pieceNames[0], false, row2_6));
            pieces.Add(new Piece(Piece.pieceNames[0], false, row2_7));
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
            player1.Enabled = !player1.Enabled;
            player2.Enabled = !player2.Enabled;
            side = !side;

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
            return new Piece("None", true, label);
        }

        private void resetColor(Label piece)
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
            message.Text = null;

            gameStart = !gameStart;

            //Need to flip player1/player2 after game starts
            player2Time.Enabled = true;
            player2.Enabled = true;

            Clocks();
        }

        private void label_Click(object sender, EventArgs e)
        {
            if (gameStart)
            {
                resetColor(lastPiece);

                Label thisPiece = sender as Label;

                if(!moved)
                {
                    thisPiece.BackColor = System.Drawing.Color.LightGreen;
                    lastPiece = thisPiece;
                    moved = !moved;
                    return;
                }

                Piece p1 = findPiece(thisPiece);
                Piece p2 = findPiece(lastPiece);
                
                if (Piece.ValidateMove(p1, p2))
                {
                    p2.MovePiece(p1);
                    pieces.Remove(p2);
                    resetColor(thisPiece);

                    lastPiece = null;
                    moved = false;
                    Clocks();

                    return;
                }
                else
                {
                    lastPiece = thisPiece;
                    resetColor(thisPiece);
                }
                /*if (p2.GetSide() == side)
                {
                    if (p2 != null && Piece.ValidateMove(p1, p2))
                    {
                        p2.MovePiece(thisPiece);
                        thisPiece.Dispose();
                        pieces.Remove(findPiece(lastPiece));
                        resetColor(thisPiece);
                        lastPiece = null;
                        Clocks();
                        return;
                    }
                    lastPiece = thisPiece;
                }*/
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
