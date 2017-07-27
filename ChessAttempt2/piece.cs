using System.Collections.Generic;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ChessAttempt2
{
    class Piece
    {
        private string name;
        private bool side;
        private Label label;

        //font used for chess pieces
        private static PrivateFontCollection pfc = new PrivateFontCollection();
        private static char[] whitePieces = { 'p', 'n', 'b', 'r', 'q', 'k', ' '};
        private static char[] blackPieces = { 'o', 'm', 'v', 't', 'w', 'l'};
        public static List<string> pieceNames = new List<string>() { "Pawn", "Knight", "Bishop", "Rook", "Queen", "King", "None"};

        public Piece(string name, bool side, Label start)
        {
            this.name = name;
            this.side = side;
            this.label = start;

            if (side)
            {
                start.Font = new System.Drawing.Font(pfc.Families[0], 72);
                start.Text = whitePieces[pieceNames.IndexOf(name)].ToString();
            }
            else
            {
                start.Font = new System.Drawing.Font(pfc.Families[0], 72);
                start.Text = blackPieces[pieceNames.IndexOf(name)].ToString();
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

        public void MovePiece(Piece newPiece)
        {
            newPiece.label.Font = new System.Drawing.Font(pfc.Families[0], 72);

            newPiece.label.Text = this.label.Text;
            this.label.Text = null;
            this.label = newPiece.label;
        }

        public static bool ValidateMove(Piece p1, Piece p2)
        {
            //If both pieces are empty
            if (p1 == null && p2 == null)
                return false;
            //If the first piece is empty
            if (p2.label.Text == " ")
                return false;
            //If the second piece is empty
            else if (p1.label.Text == " ")
                return true;
            //If both pieces are of the same color
            else if ((p1.name == "None" && p2.side == true) || (p1.side == true && p2.side == true))
                return false;
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
        public bool GetSide( )
        {
            return side;
        }
        public Label GetLabel( )
        {
            return label;
        }
        public void SetName(string name)
        {
            if (side)
            {
                label.Text = whitePieces[pieceNames.IndexOf(name)].ToString();
            }
            else
            {
                label.Text = blackPieces[pieceNames.IndexOf(name)].ToString();
            }
        }
    }
}
