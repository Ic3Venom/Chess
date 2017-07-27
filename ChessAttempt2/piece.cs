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

        //font used for chess pieces
        static PrivateFontCollection pfc = new PrivateFontCollection();
        private static char[] whitePieces = { 'p', 'n', 'b', 'r', 'q', 'k' };
        private static char[] blackPieces = { 'o', 'm', 'v', 't', 'w', 'l' };
        public static List<string> pieceNames = new List<string>() { "Pawn", "Knight", "Bishop", "Rook", "Queen", "King" };

        public Piece(string name, bool side, Label start)
        {
            this.name = name;
            this.side = side;

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

        public static bool ValidateMove(Label start, Label end)
        {
            return true;
        }

        private bool Pawn(Label start, Label end)
        {
            return true;
        }

        private bool Knight(Label start, Label end)
        {
            return true;
        }

        private bool Bishop(Label start, Label end)
        {
            return true;
        }

        private bool Rook(Label start, Label end)
        {
            return true;
        }

        private bool Queen(Label start, Label end)
        {
            return true;
        }

        private bool King(Label start, Label end)
        {
            return true;
        }
    }
}
