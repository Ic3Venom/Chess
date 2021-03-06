﻿using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ChessAttempt2
{
    class Piece
    {
        private string name;
        private int color;
        private Label label;

        public static List<Piece> stored = new List<Piece>();
        public static List<Piece> moves = new List<Piece>();
        public static List<string> pieceNames = new List<string>()
            { "Pawn", "Knight", "Bishop", "Rook", "Queen", "King", "None" };

        //font used for chess pieces
        private static PrivateFontCollection pfc = new PrivateFontCollection();
        private static char[] whitePieces = { 'p', 'n', 'b', 'r', 'q', 'k' };
        private static char[] blackPieces = { 'o', 'm', 'v', 't', 'w', 'l' };
        
        public Piece(string name, int color, Label label)
        {
            this.name = name;
            this.color = color;
            this.label = label; 

            if (color == 0)
            {
                label.Font = new System.Drawing.Font(pfc.Families[0], 72);
                label.Text = whitePieces[pieceNames.IndexOf(name)].ToString();
            }
            else if (color == 1)
            {
                label.Font = new System.Drawing.Font(pfc.Families[0], 72);
                label.Text = blackPieces[pieceNames.IndexOf(name)].ToString();
            }
            //Empty piece
            else
            {
                label.Text = " ";
            }
        }

        //Font used to create the chess pieces
        public static void InitCustomLabelFont()
        {
            int fontLength = Properties.Resources.CASEFONT.Length;
            byte[] fontdata = Properties.Resources.CASEFONT;

            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);

            pfc.AddMemoryFont(data, fontLength);
        }

        public void Replace(Piece newPiece)
        {
            newPiece.label.Font = new System.Drawing.Font(pfc.Families[0], 72);
            newPiece.label.Text = label.Text;

            label.Text = " ";
            label = newPiece.label;
        }
        public void Move(Piece newPiece)
        {

        }

        public void DefaultColor()
        {
            if ((int)(label.Name[3] - '0') % 2 == 0)
            {
                if ((int)(label.Name[5] - '0') % 2 == 0)
                {
                    label.BackColor = System.Drawing.Color.SkyBlue;
                }
                else
                {
                    label.BackColor = System.Drawing.Color.MistyRose;
                }
            }
            else
            {
                if ((int)(label.Name[5] - '0') % 2 == 0)
                {
                    label.BackColor = System.Drawing.Color.MistyRose;
                }
                else
                {
                    label.BackColor = System.Drawing.Color.SkyBlue;
                }
            }
        }
        public void Color(System.Drawing.Color color)
        {
            label.BackColor = color;
        }

        public static Piece PieceAt(int x, int y)
        {
            return null;
        }
        public static Piece Find(Label label)
        {
            foreach (Piece piece in stored)
            {
                if (label == piece.GetLabel())
                {
                    return piece;
                }
            }

            return new Piece("None", 2, label);
        }

        public  void ShowPossibleMoves()
        {
            moves.Clear();

            switch (name)
            {
                case "Pawn":
                    Pawn();
                    break;
                case "Knight":
                    Knight();
                    break;
                case "Bishop":
                    Bishop();
                    break;
                case "Rook":
                    Rook();
                    break;
                case "Queen":
                    Queen();
                    break;
                case "King":
                    King();
                    break;
                case "None":
                    break;
            } 
            foreach(Piece p in moves)
            {
                p.Color(System.Drawing.Color.LightGreen);
            }          
        }
        private void Pawn()
        {

        }
        
        private void Knight( )
        {
            //<+-1,+-2>, <+-2,+-1>
        }
        private void Bishop( )
        {
            //<+-n,+-n>
        }
        private void Rook( )
        {
            //<+-n,0>, <0,+-n>
        }
        private void Queen( )
        {
            //<+-n,+-n>, <+-n,0>, <0,+-n>
        }
        private void King( )
        {
            //<+-1,+-1>, <0,+-1>, <+-1,0> unique
        }

        public static bool ValidateMove(Piece start, Piece end, bool side)
        {
            bool valid = false;

            valid = pieceLogic(start, end, side);

            return valid;
        }
        private static bool pieceLogic(Piece start, Piece end, bool side)
        {
            /* Necessary logic points that need to be covered:
                - Both pieces can't be of the same color
                - The first piece can't be the opposite color as the current side
                - The second piece can't be the same color as the current side
                - The first piece can't be of type "None"
                - Player 1 can't select a black piece as first piece
                - Player 2 can't select a white piece as first piece
            */
            return !((start.GetColor() == end.GetColor())
                || (side == true  && start.GetColor() == 1)
                || (side == true  && end.GetColor() == 0)
                || (side == false && start.GetColor() == 0)
                || (side == false && end.GetColor() == 1)
                || (start.GetColor() == 2));
        }
        
        public string GetName( )
        {
            return name;
        }
        public int GetColor( )
        {
            return color;
        }
        public Label GetLabel( )
        {
            return label;
        }
    }
}
