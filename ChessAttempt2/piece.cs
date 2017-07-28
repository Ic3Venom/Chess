using System;
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

        //font used for chess pieces
        private static PrivateFontCollection pfc = new PrivateFontCollection();
        private static char[] whitePieces = { 'p', 'n', 'b', 'r', 'q', 'k'};
        private static char[] blackPieces = { 'o', 'm', 'v', 't', 'w', 'l'};
        public static List<string> pieceNames = new List<string>() { "Pawn", "Knight", "Bishop", "Rook", "Queen", "King", "None"};

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

        public void Move(Piece newPiece)
        {
            newPiece.label.Font = new System.Drawing.Font(pfc.Families[0], 72);
            newPiece.label.Text = label.Text;

            label.Text = " ";
            label = newPiece.label;
        }

        public static bool ValidateMove(Piece start, Piece end, bool side)
        {
            //If both pieces are empty
            if (start.GetColor() == 2  && end.GetColor() == 2)
                return false;
            //If the first piece is empty
            if (start.GetColor() == 2)
                return false;
            //If player 1 selects a black piece first
            else if (side == true && start.GetColor() == 1)
                return false;
            //If player 2 selects a white piece first
            else if (side == false && start.GetColor() == 0)
                return false;
            //If player 1 selects their own piece to move onto
            else if (side == true && end.GetColor() == 0)
                return false;
            //If player 2 selects their own piece to move onto
            else if (side == false && end.GetColor() == 1)
                return false;
            //If start piece is of opposite color to end piece
            else if (start.GetColor() != end.GetColor())
                return true;
            //If the second piece is empty
            else if (end.GetColor() == 2)
                return true;
            //Extraneous solutions
            // TODO: remove after debug
            else
                return false;
        }

        private bool Pawn(Label end)
        {
            return true;
        }

        private bool Knight(Label end)
        {
            return true;
        }

        private bool Bishop(Label end)
        {
            return true;
        }

        private bool Rook(Label end)
        {
            return true;
        }

        private bool Queen(Label end)
        {
            return true;
        }

        private bool King(Label end)
        {
            return true;
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
