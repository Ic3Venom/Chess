using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ChessAttempt2
{
    public partial class Form1 : Form
    {
        List<Piece> moves = new List<Piece>();
        bool side, gameStart;
        Piece start;
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
            Piece.stored.Add(new Piece(Piece.pieceNames[3], 1, row8_1));
            Piece.stored.Add(new Piece(Piece.pieceNames[1], 1, row8_2));
            Piece.stored.Add(new Piece(Piece.pieceNames[2], 1, row8_3));
            Piece.stored.Add(new Piece(Piece.pieceNames[4], 1, row8_4));
            Piece.stored.Add(new Piece(Piece.pieceNames[5], 1, row8_5));
            Piece.stored.Add(new Piece(Piece.pieceNames[2], 1, row8_6));
            Piece.stored.Add(new Piece(Piece.pieceNames[1], 1, row8_7));
            Piece.stored.Add(new Piece(Piece.pieceNames[3], 1, row8_8));
            Piece.stored.Add(new Piece(Piece.pieceNames[3], 0, row1_1));
            Piece.stored.Add(new Piece(Piece.pieceNames[1], 0, row1_2));
            Piece.stored.Add(new Piece(Piece.pieceNames[2], 0, row1_3));
            Piece.stored.Add(new Piece(Piece.pieceNames[4], 0, row1_4));
            Piece.stored.Add(new Piece(Piece.pieceNames[5], 0, row1_5));
            Piece.stored.Add(new Piece(Piece.pieceNames[2], 0, row1_6));
            Piece.stored.Add(new Piece(Piece.pieceNames[1], 0, row1_7));
            Piece.stored.Add(new Piece(Piece.pieceNames[3], 0, row1_8));
            Piece.stored.Add(new Piece(Piece.pieceNames[0], 1, row7_8));
            Piece.stored.Add(new Piece(Piece.pieceNames[0], 1, row7_1));
            Piece.stored.Add(new Piece(Piece.pieceNames[0], 1, row7_2));
            Piece.stored.Add(new Piece(Piece.pieceNames[0], 1, row7_3));
            Piece.stored.Add(new Piece(Piece.pieceNames[0], 1, row7_4));
            Piece.stored.Add(new Piece(Piece.pieceNames[0], 1, row7_5));
            Piece.stored.Add(new Piece(Piece.pieceNames[0], 1, row7_6));
            Piece.stored.Add(new Piece(Piece.pieceNames[0], 1, row7_7));
            Piece.stored.Add(new Piece(Piece.pieceNames[0], 0, row2_1));
            Piece.stored.Add(new Piece(Piece.pieceNames[0], 0, row2_2));
            Piece.stored.Add(new Piece(Piece.pieceNames[0], 0, row2_3));
            Piece.stored.Add(new Piece(Piece.pieceNames[0], 0, row2_4));
            Piece.stored.Add(new Piece(Piece.pieceNames[0], 0, row2_5));
            Piece.stored.Add(new Piece(Piece.pieceNames[0], 0, row2_6));
            Piece.stored.Add(new Piece(Piece.pieceNames[0], 0, row2_7));
            Piece.stored.Add(new Piece(Piece.pieceNames[0], 0, row2_8));
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

        private Piece FetchPiece(int x, int y)
        {
            int counter = 0;
            x--;
            y--;

            foreach( Label l in tableLayoutPanel1.Controls )
            {

                if (counter == (y * 8) + x)
                {
                    return Piece.Find(l);
                }
                
                //c...++
                counter++;
            }

            return null;
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
                Piece end = Piece.Find(sender as Label);
                 
                end.Color(System.Drawing.Color.PaleGreen);
                

                if (start == null)
                {
                    end.ShowPossibleMoves();
                    start = end;
                    return;
                }
                else
                {
                    start.DefaultColor();
                }

                if (start == end)
                {
                    end.DefaultColor();
                    start = null;
                }
                else if (Piece.ValidateMove(start, end, side))
                {
                    start.Replace(end);
                    Piece.stored.Remove(end);
                    Piece.stored.Add(start);
                    end.DefaultColor();

                    start = null;
                    Clocks();
                }
                else
                {
                    start = end;
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
