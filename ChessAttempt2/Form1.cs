using System;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ChessAttempt2
{
    public partial class Form1 : Form
    {
        PrivateFontCollection pfc = new PrivateFontCollection();

        Label[,] Board = new Label[8, 8]
        {
            {label1,label2,label3,label4,label5,label6,label7,label8},
            {label1,label2,label3,label4,label5,label6,label7,label8},
            {label1,label2,label3,label4,label5,label6,label7,label8},
            {label1,label2,label3,label4,label5,label6,label7,label8},
            {label1,label2,label3,label4,label5,label6,label7,label8},
            {label1,label2,label3,label4,label5,label6,label7,label8},
            {label1,label2,label3,label4,label5,label6,label7,label8},
            {label1,label2,label3,label4,label5,label6,label7,label8}
        };

        public Form1()
        {
            
            InitializeComponent();
            
            InitializeBoard();
        }


        private void InitializeBoard()
        {
            Board[0, 0].Text = "Rip";
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.Font = new System.Drawing.Font(pfc.Families[0], label1.Font.Size);
            label.Text = "Hello!";
        }
    }
}
