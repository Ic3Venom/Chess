using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessAttempt2
{
    class Piece
    {
        private string name;
        private bool side;

        //font used for chess pieces
        static PrivateFontCollection pfc = new PrivateFontCollection();
        static char[] whitePieces = { 'p', 'n', 'b', 'r', 'q', 'k' };
        static char[] blackPieces = { 'o', 'm', 'v', 't', 'w', 'l' };

        public Piece(string name, bool side, Label start)
        {
            this.name = name;
            this.side = side;

            foreach()
            switch (name)
            {
                case "Pawn":
                    start.Text = whitePieces[0].ToString();
                    break;
                case "Knight":
                    start.Text = whitePieces[1].ToString();
                    break;
                case "Bishop":
                    start.Text = whitePieces[2].ToString();
                    break;
                case "Rook":
                    start.Text = whitePieces[3].ToString();
                    break;
                case "Queen":
                    start.Text = whitePieces[4].ToString();
                    break;
                case "King":
                    start.Text = whitePieces[5].ToString();
                    break;
            }
        }

        //Font used to create the chess pieces
        public static void InitCustomLabelFont()
        {
            int fontLength = Properties.Resources.CASEFONT.Length;
            byte[] fontdata = Properties.Resources.CASEFONT;

            System.IntPtr data = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontLength);
            System.Runtime.InteropServices.Marshal.Copy(fontdata, 0, data, fontLength);

            pfc.AddMemoryFont(data, fontLength);
        }

        public bool ValidateMove(Label start, Label end)
        {
            switch (name)
            {
                case "Pawn":
                    break;
                case "Knight":
                    break;
                case "Bishop":
                    break;
                case "Rook":
                    break;
                case "Queen":
                    break;
                case "King":
                    break;
                default:
                    return false;
            }
            return false;
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
