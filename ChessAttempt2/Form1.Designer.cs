namespace ChessAttempt2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.message = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.Timer(this.components);
            this.player2 = new System.Windows.Forms.Timer(this.components);
            this.player2Time = new System.Windows.Forms.Label();
            this.player1Time = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.row1_1 = new System.Windows.Forms.Label();
            this.row1_2 = new System.Windows.Forms.Label();
            this.row1_3 = new System.Windows.Forms.Label();
            this.row1_4 = new System.Windows.Forms.Label();
            this.row1_5 = new System.Windows.Forms.Label();
            this.row1_6 = new System.Windows.Forms.Label();
            this.row1_7 = new System.Windows.Forms.Label();
            this.row1_8 = new System.Windows.Forms.Label();
            this.row2_1 = new System.Windows.Forms.Label();
            this.row2_2 = new System.Windows.Forms.Label();
            this.row2_3 = new System.Windows.Forms.Label();
            this.row2_4 = new System.Windows.Forms.Label();
            this.row2_5 = new System.Windows.Forms.Label();
            this.row2_6 = new System.Windows.Forms.Label();
            this.row2_7 = new System.Windows.Forms.Label();
            this.row2_8 = new System.Windows.Forms.Label();
            this.row3_1 = new System.Windows.Forms.Label();
            this.row3_2 = new System.Windows.Forms.Label();
            this.row3_3 = new System.Windows.Forms.Label();
            this.row3_4 = new System.Windows.Forms.Label();
            this.row3_5 = new System.Windows.Forms.Label();
            this.row3_6 = new System.Windows.Forms.Label();
            this.row3_7 = new System.Windows.Forms.Label();
            this.row3_8 = new System.Windows.Forms.Label();
            this.row4_1 = new System.Windows.Forms.Label();
            this.row4_2 = new System.Windows.Forms.Label();
            this.row4_3 = new System.Windows.Forms.Label();
            this.row4_4 = new System.Windows.Forms.Label();
            this.row4_5 = new System.Windows.Forms.Label();
            this.row4_6 = new System.Windows.Forms.Label();
            this.row4_7 = new System.Windows.Forms.Label();
            this.row4_8 = new System.Windows.Forms.Label();
            this.row5_1 = new System.Windows.Forms.Label();
            this.row5_2 = new System.Windows.Forms.Label();
            this.row5_3 = new System.Windows.Forms.Label();
            this.row5_4 = new System.Windows.Forms.Label();
            this.row5_5 = new System.Windows.Forms.Label();
            this.row5_6 = new System.Windows.Forms.Label();
            this.row5_7 = new System.Windows.Forms.Label();
            this.row5_8 = new System.Windows.Forms.Label();
            this.row6_1 = new System.Windows.Forms.Label();
            this.row6_2 = new System.Windows.Forms.Label();
            this.row6_3 = new System.Windows.Forms.Label();
            this.row6_4 = new System.Windows.Forms.Label();
            this.row6_5 = new System.Windows.Forms.Label();
            this.row6_6 = new System.Windows.Forms.Label();
            this.row6_7 = new System.Windows.Forms.Label();
            this.row6_8 = new System.Windows.Forms.Label();
            this.row7_1 = new System.Windows.Forms.Label();
            this.row7_2 = new System.Windows.Forms.Label();
            this.row7_3 = new System.Windows.Forms.Label();
            this.row7_4 = new System.Windows.Forms.Label();
            this.row7_5 = new System.Windows.Forms.Label();
            this.row7_6 = new System.Windows.Forms.Label();
            this.row7_7 = new System.Windows.Forms.Label();
            this.row7_8 = new System.Windows.Forms.Label();
            this.row8_1 = new System.Windows.Forms.Label();
            this.row8_2 = new System.Windows.Forms.Label();
            this.row8_3 = new System.Windows.Forms.Label();
            this.row8_4 = new System.Windows.Forms.Label();
            this.row8_5 = new System.Windows.Forms.Label();
            this.row8_6 = new System.Windows.Forms.Label();
            this.row8_7 = new System.Windows.Forms.Label();
            this.row8_8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.Color.LightGray;
            this.message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.message.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(200, 0);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(400, 41);
            this.message.TabIndex = 1;
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.message.Click += new System.EventHandler(this.game_Start);
            // 
            // player1
            // 
            this.player1.Interval = 1000;
            this.player1.Tick += new System.EventHandler(this.player1_Tick);
            // 
            // player2
            // 
            this.player2.Interval = 1000;
            this.player2.Tick += new System.EventHandler(this.player2_Tick);
            // 
            // player2Time
            // 
            this.player2Time.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.player2Time.Enabled = false;
            this.player2Time.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Time.Location = new System.Drawing.Point(600, 0);
            this.player2Time.Name = "player2Time";
            this.player2Time.Size = new System.Drawing.Size(198, 41);
            this.player2Time.TabIndex = 2;
            this.player2Time.Text = "P2: 00:00:00";
            this.player2Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1Time
            // 
            this.player1Time.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.player1Time.Enabled = false;
            this.player1Time.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Time.Location = new System.Drawing.Point(0, 0);
            this.player1Time.Name = "player1Time";
            this.player1Time.Size = new System.Drawing.Size(199, 41);
            this.player1Time.TabIndex = 3;
            this.player1Time.Text = "P1: 00:00:00";
            this.player1Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.row1_1, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.row1_2, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.row1_3, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.row1_4, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.row1_5, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.row1_6, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.row1_7, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.row1_8, 7, 7);
            this.tableLayoutPanel1.Controls.Add(this.row2_1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.row2_2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.row2_3, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.row2_4, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.row2_5, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.row2_6, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.row2_7, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.row2_8, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.row3_1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.row3_2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.row3_3, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.row3_4, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.row3_5, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.row3_6, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.row3_7, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.row3_8, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.row4_1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.row4_2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.row4_3, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.row4_4, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.row4_5, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.row4_6, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.row4_7, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.row4_8, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.row5_1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.row5_2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.row5_3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.row5_4, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.row5_5, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.row5_6, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.row5_7, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.row5_8, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.row6_1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.row6_2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.row6_3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.row6_4, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.row6_5, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.row6_6, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.row6_7, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.row6_8, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.row7_1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.row7_2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.row7_3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.row7_4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.row7_5, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.row7_6, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.row7_7, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.row7_8, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.row8_1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.row8_2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.row8_3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.row8_4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.row8_5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.row8_6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.row8_7, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.row8_8, 7, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 41);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 800);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // row1_1
            // 
            this.row1_1.BackColor = System.Drawing.Color.SkyBlue;
            this.row1_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row1_1.Location = new System.Drawing.Point(0, 700);
            this.row1_1.Margin = new System.Windows.Forms.Padding(0);
            this.row1_1.Name = "row1_1";
            this.row1_1.Size = new System.Drawing.Size(100, 100);
            this.row1_1.TabIndex = 131;
            this.row1_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row1_1.Click += new System.EventHandler(this.label_Click);
            // 
            // row1_2
            // 
            this.row1_2.BackColor = System.Drawing.Color.MistyRose;
            this.row1_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row1_2.Location = new System.Drawing.Point(100, 700);
            this.row1_2.Margin = new System.Windows.Forms.Padding(0);
            this.row1_2.Name = "row1_2";
            this.row1_2.Size = new System.Drawing.Size(100, 100);
            this.row1_2.TabIndex = 130;
            this.row1_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row1_2.Click += new System.EventHandler(this.label_Click);
            // 
            // row1_3
            // 
            this.row1_3.BackColor = System.Drawing.Color.SkyBlue;
            this.row1_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row1_3.Location = new System.Drawing.Point(200, 700);
            this.row1_3.Margin = new System.Windows.Forms.Padding(0);
            this.row1_3.Name = "row1_3";
            this.row1_3.Size = new System.Drawing.Size(100, 100);
            this.row1_3.TabIndex = 129;
            this.row1_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row1_3.Click += new System.EventHandler(this.label_Click);
            // 
            // row1_4
            // 
            this.row1_4.BackColor = System.Drawing.Color.MistyRose;
            this.row1_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row1_4.Location = new System.Drawing.Point(300, 700);
            this.row1_4.Margin = new System.Windows.Forms.Padding(0);
            this.row1_4.Name = "row1_4";
            this.row1_4.Size = new System.Drawing.Size(100, 100);
            this.row1_4.TabIndex = 128;
            this.row1_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row1_4.Click += new System.EventHandler(this.label_Click);
            // 
            // row1_5
            // 
            this.row1_5.BackColor = System.Drawing.Color.SkyBlue;
            this.row1_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row1_5.Location = new System.Drawing.Point(400, 700);
            this.row1_5.Margin = new System.Windows.Forms.Padding(0);
            this.row1_5.Name = "row1_5";
            this.row1_5.Size = new System.Drawing.Size(100, 100);
            this.row1_5.TabIndex = 127;
            this.row1_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row1_5.Click += new System.EventHandler(this.label_Click);
            // 
            // row1_6
            // 
            this.row1_6.BackColor = System.Drawing.Color.MistyRose;
            this.row1_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row1_6.Location = new System.Drawing.Point(500, 700);
            this.row1_6.Margin = new System.Windows.Forms.Padding(0);
            this.row1_6.Name = "row1_6";
            this.row1_6.Size = new System.Drawing.Size(100, 100);
            this.row1_6.TabIndex = 126;
            this.row1_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row1_6.Click += new System.EventHandler(this.label_Click);
            // 
            // row1_7
            // 
            this.row1_7.BackColor = System.Drawing.Color.SkyBlue;
            this.row1_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row1_7.Location = new System.Drawing.Point(600, 700);
            this.row1_7.Margin = new System.Windows.Forms.Padding(0);
            this.row1_7.Name = "row1_7";
            this.row1_7.Size = new System.Drawing.Size(100, 100);
            this.row1_7.TabIndex = 125;
            this.row1_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row1_7.Click += new System.EventHandler(this.label_Click);
            // 
            // row1_8
            // 
            this.row1_8.BackColor = System.Drawing.Color.MistyRose;
            this.row1_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row1_8.Location = new System.Drawing.Point(700, 700);
            this.row1_8.Margin = new System.Windows.Forms.Padding(0);
            this.row1_8.Name = "row1_8";
            this.row1_8.Size = new System.Drawing.Size(100, 100);
            this.row1_8.TabIndex = 124;
            this.row1_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row1_8.Click += new System.EventHandler(this.label_Click);
            // 
            // row2_1
            // 
            this.row2_1.BackColor = System.Drawing.Color.MistyRose;
            this.row2_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row2_1.Location = new System.Drawing.Point(0, 600);
            this.row2_1.Margin = new System.Windows.Forms.Padding(0);
            this.row2_1.Name = "row2_1";
            this.row2_1.Size = new System.Drawing.Size(100, 100);
            this.row2_1.TabIndex = 123;
            this.row2_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row2_1.Click += new System.EventHandler(this.label_Click);
            // 
            // row2_2
            // 
            this.row2_2.BackColor = System.Drawing.Color.SkyBlue;
            this.row2_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row2_2.Location = new System.Drawing.Point(100, 600);
            this.row2_2.Margin = new System.Windows.Forms.Padding(0);
            this.row2_2.Name = "row2_2";
            this.row2_2.Size = new System.Drawing.Size(100, 100);
            this.row2_2.TabIndex = 122;
            this.row2_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row2_2.Click += new System.EventHandler(this.label_Click);
            // 
            // row2_3
            // 
            this.row2_3.BackColor = System.Drawing.Color.MistyRose;
            this.row2_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row2_3.Location = new System.Drawing.Point(200, 600);
            this.row2_3.Margin = new System.Windows.Forms.Padding(0);
            this.row2_3.Name = "row2_3";
            this.row2_3.Size = new System.Drawing.Size(100, 100);
            this.row2_3.TabIndex = 121;
            this.row2_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row2_3.Click += new System.EventHandler(this.label_Click);
            // 
            // row2_4
            // 
            this.row2_4.BackColor = System.Drawing.Color.SkyBlue;
            this.row2_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row2_4.Location = new System.Drawing.Point(300, 600);
            this.row2_4.Margin = new System.Windows.Forms.Padding(0);
            this.row2_4.Name = "row2_4";
            this.row2_4.Size = new System.Drawing.Size(100, 100);
            this.row2_4.TabIndex = 120;
            this.row2_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row2_4.Click += new System.EventHandler(this.label_Click);
            // 
            // row2_5
            // 
            this.row2_5.BackColor = System.Drawing.Color.MistyRose;
            this.row2_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row2_5.Location = new System.Drawing.Point(400, 600);
            this.row2_5.Margin = new System.Windows.Forms.Padding(0);
            this.row2_5.Name = "row2_5";
            this.row2_5.Size = new System.Drawing.Size(100, 100);
            this.row2_5.TabIndex = 119;
            this.row2_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row2_5.Click += new System.EventHandler(this.label_Click);
            // 
            // row2_6
            // 
            this.row2_6.BackColor = System.Drawing.Color.SkyBlue;
            this.row2_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row2_6.Location = new System.Drawing.Point(500, 600);
            this.row2_6.Margin = new System.Windows.Forms.Padding(0);
            this.row2_6.Name = "row2_6";
            this.row2_6.Size = new System.Drawing.Size(100, 100);
            this.row2_6.TabIndex = 118;
            this.row2_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row2_6.Click += new System.EventHandler(this.label_Click);
            // 
            // row2_7
            // 
            this.row2_7.BackColor = System.Drawing.Color.MistyRose;
            this.row2_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row2_7.Location = new System.Drawing.Point(600, 600);
            this.row2_7.Margin = new System.Windows.Forms.Padding(0);
            this.row2_7.Name = "row2_7";
            this.row2_7.Size = new System.Drawing.Size(100, 100);
            this.row2_7.TabIndex = 117;
            this.row2_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row2_7.Click += new System.EventHandler(this.label_Click);
            // 
            // row2_8
            // 
            this.row2_8.BackColor = System.Drawing.Color.SkyBlue;
            this.row2_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row2_8.Location = new System.Drawing.Point(700, 600);
            this.row2_8.Margin = new System.Windows.Forms.Padding(0);
            this.row2_8.Name = "row2_8";
            this.row2_8.Size = new System.Drawing.Size(100, 100);
            this.row2_8.TabIndex = 116;
            this.row2_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row2_8.Click += new System.EventHandler(this.label_Click);
            // 
            // row3_1
            // 
            this.row3_1.BackColor = System.Drawing.Color.SkyBlue;
            this.row3_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row3_1.Location = new System.Drawing.Point(0, 500);
            this.row3_1.Margin = new System.Windows.Forms.Padding(0);
            this.row3_1.Name = "row3_1";
            this.row3_1.Size = new System.Drawing.Size(100, 100);
            this.row3_1.TabIndex = 115;
            this.row3_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row3_1.Click += new System.EventHandler(this.label_Click);
            // 
            // row3_2
            // 
            this.row3_2.BackColor = System.Drawing.Color.MistyRose;
            this.row3_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row3_2.Location = new System.Drawing.Point(100, 500);
            this.row3_2.Margin = new System.Windows.Forms.Padding(0);
            this.row3_2.Name = "row3_2";
            this.row3_2.Size = new System.Drawing.Size(100, 100);
            this.row3_2.TabIndex = 114;
            this.row3_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row3_2.Click += new System.EventHandler(this.label_Click);
            // 
            // row3_3
            // 
            this.row3_3.BackColor = System.Drawing.Color.SkyBlue;
            this.row3_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row3_3.Location = new System.Drawing.Point(200, 500);
            this.row3_3.Margin = new System.Windows.Forms.Padding(0);
            this.row3_3.Name = "row3_3";
            this.row3_3.Size = new System.Drawing.Size(100, 100);
            this.row3_3.TabIndex = 113;
            this.row3_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row3_3.Click += new System.EventHandler(this.label_Click);
            // 
            // row3_4
            // 
            this.row3_4.BackColor = System.Drawing.Color.MistyRose;
            this.row3_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row3_4.Location = new System.Drawing.Point(300, 500);
            this.row3_4.Margin = new System.Windows.Forms.Padding(0);
            this.row3_4.Name = "row3_4";
            this.row3_4.Size = new System.Drawing.Size(100, 100);
            this.row3_4.TabIndex = 112;
            this.row3_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row3_4.Click += new System.EventHandler(this.label_Click);
            // 
            // row3_5
            // 
            this.row3_5.BackColor = System.Drawing.Color.SkyBlue;
            this.row3_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row3_5.Location = new System.Drawing.Point(400, 500);
            this.row3_5.Margin = new System.Windows.Forms.Padding(0);
            this.row3_5.Name = "row3_5";
            this.row3_5.Size = new System.Drawing.Size(100, 100);
            this.row3_5.TabIndex = 111;
            this.row3_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row3_5.Click += new System.EventHandler(this.label_Click);
            // 
            // row3_6
            // 
            this.row3_6.BackColor = System.Drawing.Color.MistyRose;
            this.row3_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row3_6.Location = new System.Drawing.Point(500, 500);
            this.row3_6.Margin = new System.Windows.Forms.Padding(0);
            this.row3_6.Name = "row3_6";
            this.row3_6.Size = new System.Drawing.Size(100, 100);
            this.row3_6.TabIndex = 110;
            this.row3_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row3_6.Click += new System.EventHandler(this.label_Click);
            // 
            // row3_7
            // 
            this.row3_7.BackColor = System.Drawing.Color.SkyBlue;
            this.row3_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row3_7.Location = new System.Drawing.Point(600, 500);
            this.row3_7.Margin = new System.Windows.Forms.Padding(0);
            this.row3_7.Name = "row3_7";
            this.row3_7.Size = new System.Drawing.Size(100, 100);
            this.row3_7.TabIndex = 109;
            this.row3_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row3_7.Click += new System.EventHandler(this.label_Click);
            // 
            // row3_8
            // 
            this.row3_8.BackColor = System.Drawing.Color.MistyRose;
            this.row3_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row3_8.Location = new System.Drawing.Point(700, 500);
            this.row3_8.Margin = new System.Windows.Forms.Padding(0);
            this.row3_8.Name = "row3_8";
            this.row3_8.Size = new System.Drawing.Size(100, 100);
            this.row3_8.TabIndex = 108;
            this.row3_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row3_8.Click += new System.EventHandler(this.label_Click);
            // 
            // row4_1
            // 
            this.row4_1.BackColor = System.Drawing.Color.MistyRose;
            this.row4_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row4_1.Location = new System.Drawing.Point(0, 400);
            this.row4_1.Margin = new System.Windows.Forms.Padding(0);
            this.row4_1.Name = "row4_1";
            this.row4_1.Size = new System.Drawing.Size(100, 100);
            this.row4_1.TabIndex = 107;
            this.row4_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row4_1.Click += new System.EventHandler(this.label_Click);
            // 
            // row4_2
            // 
            this.row4_2.BackColor = System.Drawing.Color.SkyBlue;
            this.row4_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row4_2.Location = new System.Drawing.Point(100, 400);
            this.row4_2.Margin = new System.Windows.Forms.Padding(0);
            this.row4_2.Name = "row4_2";
            this.row4_2.Size = new System.Drawing.Size(100, 100);
            this.row4_2.TabIndex = 106;
            this.row4_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row4_2.Click += new System.EventHandler(this.label_Click);
            // 
            // row4_3
            // 
            this.row4_3.BackColor = System.Drawing.Color.MistyRose;
            this.row4_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row4_3.Location = new System.Drawing.Point(200, 400);
            this.row4_3.Margin = new System.Windows.Forms.Padding(0);
            this.row4_3.Name = "row4_3";
            this.row4_3.Size = new System.Drawing.Size(100, 100);
            this.row4_3.TabIndex = 105;
            this.row4_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row4_3.Click += new System.EventHandler(this.label_Click);
            // 
            // row4_4
            // 
            this.row4_4.BackColor = System.Drawing.Color.SkyBlue;
            this.row4_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row4_4.Location = new System.Drawing.Point(300, 400);
            this.row4_4.Margin = new System.Windows.Forms.Padding(0);
            this.row4_4.Name = "row4_4";
            this.row4_4.Size = new System.Drawing.Size(100, 100);
            this.row4_4.TabIndex = 104;
            this.row4_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row4_4.Click += new System.EventHandler(this.label_Click);
            // 
            // row4_5
            // 
            this.row4_5.BackColor = System.Drawing.Color.MistyRose;
            this.row4_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row4_5.Location = new System.Drawing.Point(400, 400);
            this.row4_5.Margin = new System.Windows.Forms.Padding(0);
            this.row4_5.Name = "row4_5";
            this.row4_5.Size = new System.Drawing.Size(100, 100);
            this.row4_5.TabIndex = 103;
            this.row4_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row4_5.Click += new System.EventHandler(this.label_Click);
            // 
            // row4_6
            // 
            this.row4_6.BackColor = System.Drawing.Color.SkyBlue;
            this.row4_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row4_6.Location = new System.Drawing.Point(500, 400);
            this.row4_6.Margin = new System.Windows.Forms.Padding(0);
            this.row4_6.Name = "row4_6";
            this.row4_6.Size = new System.Drawing.Size(100, 100);
            this.row4_6.TabIndex = 102;
            this.row4_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row4_6.Click += new System.EventHandler(this.label_Click);
            // 
            // row4_7
            // 
            this.row4_7.BackColor = System.Drawing.Color.MistyRose;
            this.row4_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row4_7.Location = new System.Drawing.Point(600, 400);
            this.row4_7.Margin = new System.Windows.Forms.Padding(0);
            this.row4_7.Name = "row4_7";
            this.row4_7.Size = new System.Drawing.Size(100, 100);
            this.row4_7.TabIndex = 101;
            this.row4_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row4_7.Click += new System.EventHandler(this.label_Click);
            // 
            // row4_8
            // 
            this.row4_8.BackColor = System.Drawing.Color.SkyBlue;
            this.row4_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row4_8.Location = new System.Drawing.Point(700, 400);
            this.row4_8.Margin = new System.Windows.Forms.Padding(0);
            this.row4_8.Name = "row4_8";
            this.row4_8.Size = new System.Drawing.Size(100, 100);
            this.row4_8.TabIndex = 100;
            this.row4_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row4_8.Click += new System.EventHandler(this.label_Click);
            // 
            // row5_1
            // 
            this.row5_1.BackColor = System.Drawing.Color.SkyBlue;
            this.row5_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row5_1.Location = new System.Drawing.Point(0, 300);
            this.row5_1.Margin = new System.Windows.Forms.Padding(0);
            this.row5_1.Name = "row5_1";
            this.row5_1.Size = new System.Drawing.Size(100, 100);
            this.row5_1.TabIndex = 99;
            this.row5_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row5_1.Click += new System.EventHandler(this.label_Click);
            // 
            // row5_2
            // 
            this.row5_2.BackColor = System.Drawing.Color.MistyRose;
            this.row5_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row5_2.Location = new System.Drawing.Point(100, 300);
            this.row5_2.Margin = new System.Windows.Forms.Padding(0);
            this.row5_2.Name = "row5_2";
            this.row5_2.Size = new System.Drawing.Size(100, 100);
            this.row5_2.TabIndex = 98;
            this.row5_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row5_2.Click += new System.EventHandler(this.label_Click);
            // 
            // row5_3
            // 
            this.row5_3.BackColor = System.Drawing.Color.SkyBlue;
            this.row5_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row5_3.Location = new System.Drawing.Point(200, 300);
            this.row5_3.Margin = new System.Windows.Forms.Padding(0);
            this.row5_3.Name = "row5_3";
            this.row5_3.Size = new System.Drawing.Size(100, 100);
            this.row5_3.TabIndex = 97;
            this.row5_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row5_3.Click += new System.EventHandler(this.label_Click);
            // 
            // row5_4
            // 
            this.row5_4.BackColor = System.Drawing.Color.MistyRose;
            this.row5_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row5_4.Location = new System.Drawing.Point(300, 300);
            this.row5_4.Margin = new System.Windows.Forms.Padding(0);
            this.row5_4.Name = "row5_4";
            this.row5_4.Size = new System.Drawing.Size(100, 100);
            this.row5_4.TabIndex = 96;
            this.row5_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row5_4.Click += new System.EventHandler(this.label_Click);
            // 
            // row5_5
            // 
            this.row5_5.BackColor = System.Drawing.Color.SkyBlue;
            this.row5_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row5_5.Location = new System.Drawing.Point(400, 300);
            this.row5_5.Margin = new System.Windows.Forms.Padding(0);
            this.row5_5.Name = "row5_5";
            this.row5_5.Size = new System.Drawing.Size(100, 100);
            this.row5_5.TabIndex = 95;
            this.row5_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row5_5.Click += new System.EventHandler(this.label_Click);
            // 
            // row5_6
            // 
            this.row5_6.BackColor = System.Drawing.Color.MistyRose;
            this.row5_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row5_6.Location = new System.Drawing.Point(500, 300);
            this.row5_6.Margin = new System.Windows.Forms.Padding(0);
            this.row5_6.Name = "row5_6";
            this.row5_6.Size = new System.Drawing.Size(100, 100);
            this.row5_6.TabIndex = 94;
            this.row5_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row5_6.Click += new System.EventHandler(this.label_Click);
            // 
            // row5_7
            // 
            this.row5_7.BackColor = System.Drawing.Color.SkyBlue;
            this.row5_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row5_7.Location = new System.Drawing.Point(600, 300);
            this.row5_7.Margin = new System.Windows.Forms.Padding(0);
            this.row5_7.Name = "row5_7";
            this.row5_7.Size = new System.Drawing.Size(100, 100);
            this.row5_7.TabIndex = 93;
            this.row5_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row5_7.Click += new System.EventHandler(this.label_Click);
            // 
            // row5_8
            // 
            this.row5_8.BackColor = System.Drawing.Color.MistyRose;
            this.row5_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row5_8.Location = new System.Drawing.Point(700, 300);
            this.row5_8.Margin = new System.Windows.Forms.Padding(0);
            this.row5_8.Name = "row5_8";
            this.row5_8.Size = new System.Drawing.Size(100, 100);
            this.row5_8.TabIndex = 92;
            this.row5_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row5_8.Click += new System.EventHandler(this.label_Click);
            // 
            // row6_1
            // 
            this.row6_1.BackColor = System.Drawing.Color.MistyRose;
            this.row6_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row6_1.Location = new System.Drawing.Point(0, 200);
            this.row6_1.Margin = new System.Windows.Forms.Padding(0);
            this.row6_1.Name = "row6_1";
            this.row6_1.Size = new System.Drawing.Size(100, 100);
            this.row6_1.TabIndex = 91;
            this.row6_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row6_1.Click += new System.EventHandler(this.label_Click);
            // 
            // row6_2
            // 
            this.row6_2.BackColor = System.Drawing.Color.SkyBlue;
            this.row6_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row6_2.Location = new System.Drawing.Point(100, 200);
            this.row6_2.Margin = new System.Windows.Forms.Padding(0);
            this.row6_2.Name = "row6_2";
            this.row6_2.Size = new System.Drawing.Size(100, 100);
            this.row6_2.TabIndex = 90;
            this.row6_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row6_2.Click += new System.EventHandler(this.label_Click);
            // 
            // row6_3
            // 
            this.row6_3.BackColor = System.Drawing.Color.MistyRose;
            this.row6_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row6_3.Location = new System.Drawing.Point(200, 200);
            this.row6_3.Margin = new System.Windows.Forms.Padding(0);
            this.row6_3.Name = "row6_3";
            this.row6_3.Size = new System.Drawing.Size(100, 100);
            this.row6_3.TabIndex = 89;
            this.row6_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row6_3.Click += new System.EventHandler(this.label_Click);
            // 
            // row6_4
            // 
            this.row6_4.BackColor = System.Drawing.Color.SkyBlue;
            this.row6_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row6_4.Location = new System.Drawing.Point(300, 200);
            this.row6_4.Margin = new System.Windows.Forms.Padding(0);
            this.row6_4.Name = "row6_4";
            this.row6_4.Size = new System.Drawing.Size(100, 100);
            this.row6_4.TabIndex = 88;
            this.row6_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row6_4.Click += new System.EventHandler(this.label_Click);
            // 
            // row6_5
            // 
            this.row6_5.BackColor = System.Drawing.Color.MistyRose;
            this.row6_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row6_5.Location = new System.Drawing.Point(400, 200);
            this.row6_5.Margin = new System.Windows.Forms.Padding(0);
            this.row6_5.Name = "row6_5";
            this.row6_5.Size = new System.Drawing.Size(100, 100);
            this.row6_5.TabIndex = 87;
            this.row6_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row6_5.Click += new System.EventHandler(this.label_Click);
            // 
            // row6_6
            // 
            this.row6_6.BackColor = System.Drawing.Color.SkyBlue;
            this.row6_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row6_6.Location = new System.Drawing.Point(500, 200);
            this.row6_6.Margin = new System.Windows.Forms.Padding(0);
            this.row6_6.Name = "row6_6";
            this.row6_6.Size = new System.Drawing.Size(100, 100);
            this.row6_6.TabIndex = 86;
            this.row6_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row6_6.Click += new System.EventHandler(this.label_Click);
            // 
            // row6_7
            // 
            this.row6_7.BackColor = System.Drawing.Color.MistyRose;
            this.row6_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row6_7.Location = new System.Drawing.Point(600, 200);
            this.row6_7.Margin = new System.Windows.Forms.Padding(0);
            this.row6_7.Name = "row6_7";
            this.row6_7.Size = new System.Drawing.Size(100, 100);
            this.row6_7.TabIndex = 85;
            this.row6_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row6_7.Click += new System.EventHandler(this.label_Click);
            // 
            // row6_8
            // 
            this.row6_8.BackColor = System.Drawing.Color.SkyBlue;
            this.row6_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row6_8.Location = new System.Drawing.Point(700, 200);
            this.row6_8.Margin = new System.Windows.Forms.Padding(0);
            this.row6_8.Name = "row6_8";
            this.row6_8.Size = new System.Drawing.Size(100, 100);
            this.row6_8.TabIndex = 84;
            this.row6_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row6_8.Click += new System.EventHandler(this.label_Click);
            // 
            // row7_1
            // 
            this.row7_1.BackColor = System.Drawing.Color.SkyBlue;
            this.row7_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row7_1.Location = new System.Drawing.Point(0, 100);
            this.row7_1.Margin = new System.Windows.Forms.Padding(0);
            this.row7_1.Name = "row7_1";
            this.row7_1.Size = new System.Drawing.Size(100, 100);
            this.row7_1.TabIndex = 83;
            this.row7_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row7_1.Click += new System.EventHandler(this.label_Click);
            // 
            // row7_2
            // 
            this.row7_2.BackColor = System.Drawing.Color.MistyRose;
            this.row7_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row7_2.Location = new System.Drawing.Point(100, 100);
            this.row7_2.Margin = new System.Windows.Forms.Padding(0);
            this.row7_2.Name = "row7_2";
            this.row7_2.Size = new System.Drawing.Size(100, 100);
            this.row7_2.TabIndex = 82;
            this.row7_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row7_2.Click += new System.EventHandler(this.label_Click);
            // 
            // row7_3
            // 
            this.row7_3.BackColor = System.Drawing.Color.SkyBlue;
            this.row7_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row7_3.Location = new System.Drawing.Point(200, 100);
            this.row7_3.Margin = new System.Windows.Forms.Padding(0);
            this.row7_3.Name = "row7_3";
            this.row7_3.Size = new System.Drawing.Size(100, 100);
            this.row7_3.TabIndex = 81;
            this.row7_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row7_3.Click += new System.EventHandler(this.label_Click);
            // 
            // row7_4
            // 
            this.row7_4.BackColor = System.Drawing.Color.MistyRose;
            this.row7_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row7_4.Location = new System.Drawing.Point(300, 100);
            this.row7_4.Margin = new System.Windows.Forms.Padding(0);
            this.row7_4.Name = "row7_4";
            this.row7_4.Size = new System.Drawing.Size(100, 100);
            this.row7_4.TabIndex = 80;
            this.row7_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row7_4.Click += new System.EventHandler(this.label_Click);
            // 
            // row7_5
            // 
            this.row7_5.BackColor = System.Drawing.Color.SkyBlue;
            this.row7_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row7_5.Location = new System.Drawing.Point(400, 100);
            this.row7_5.Margin = new System.Windows.Forms.Padding(0);
            this.row7_5.Name = "row7_5";
            this.row7_5.Size = new System.Drawing.Size(100, 100);
            this.row7_5.TabIndex = 79;
            this.row7_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row7_5.Click += new System.EventHandler(this.label_Click);
            // 
            // row7_6
            // 
            this.row7_6.BackColor = System.Drawing.Color.MistyRose;
            this.row7_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row7_6.Location = new System.Drawing.Point(500, 100);
            this.row7_6.Margin = new System.Windows.Forms.Padding(0);
            this.row7_6.Name = "row7_6";
            this.row7_6.Size = new System.Drawing.Size(100, 100);
            this.row7_6.TabIndex = 78;
            this.row7_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row7_6.Click += new System.EventHandler(this.label_Click);
            // 
            // row7_7
            // 
            this.row7_7.BackColor = System.Drawing.Color.SkyBlue;
            this.row7_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row7_7.Location = new System.Drawing.Point(600, 100);
            this.row7_7.Margin = new System.Windows.Forms.Padding(0);
            this.row7_7.Name = "row7_7";
            this.row7_7.Size = new System.Drawing.Size(100, 100);
            this.row7_7.TabIndex = 77;
            this.row7_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row7_7.Click += new System.EventHandler(this.label_Click);
            // 
            // row7_8
            // 
            this.row7_8.BackColor = System.Drawing.Color.MistyRose;
            this.row7_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row7_8.Location = new System.Drawing.Point(700, 100);
            this.row7_8.Margin = new System.Windows.Forms.Padding(0);
            this.row7_8.Name = "row7_8";
            this.row7_8.Size = new System.Drawing.Size(100, 100);
            this.row7_8.TabIndex = 76;
            this.row7_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row7_8.Click += new System.EventHandler(this.label_Click);
            // 
            // row8_1
            // 
            this.row8_1.BackColor = System.Drawing.Color.MistyRose;
            this.row8_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row8_1.Location = new System.Drawing.Point(0, 0);
            this.row8_1.Margin = new System.Windows.Forms.Padding(0);
            this.row8_1.Name = "row8_1";
            this.row8_1.Size = new System.Drawing.Size(100, 100);
            this.row8_1.TabIndex = 75;
            this.row8_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row8_1.Click += new System.EventHandler(this.label_Click);
            // 
            // row8_2
            // 
            this.row8_2.BackColor = System.Drawing.Color.SkyBlue;
            this.row8_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row8_2.Location = new System.Drawing.Point(100, 0);
            this.row8_2.Margin = new System.Windows.Forms.Padding(0);
            this.row8_2.Name = "row8_2";
            this.row8_2.Size = new System.Drawing.Size(100, 100);
            this.row8_2.TabIndex = 74;
            this.row8_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row8_2.Click += new System.EventHandler(this.label_Click);
            // 
            // row8_3
            // 
            this.row8_3.BackColor = System.Drawing.Color.MistyRose;
            this.row8_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row8_3.Location = new System.Drawing.Point(200, 0);
            this.row8_3.Margin = new System.Windows.Forms.Padding(0);
            this.row8_3.Name = "row8_3";
            this.row8_3.Size = new System.Drawing.Size(100, 100);
            this.row8_3.TabIndex = 73;
            this.row8_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row8_3.Click += new System.EventHandler(this.label_Click);
            // 
            // row8_4
            // 
            this.row8_4.BackColor = System.Drawing.Color.SkyBlue;
            this.row8_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row8_4.Location = new System.Drawing.Point(300, 0);
            this.row8_4.Margin = new System.Windows.Forms.Padding(0);
            this.row8_4.Name = "row8_4";
            this.row8_4.Size = new System.Drawing.Size(100, 100);
            this.row8_4.TabIndex = 72;
            this.row8_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row8_4.Click += new System.EventHandler(this.label_Click);
            // 
            // row8_5
            // 
            this.row8_5.BackColor = System.Drawing.Color.MistyRose;
            this.row8_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row8_5.Location = new System.Drawing.Point(400, 0);
            this.row8_5.Margin = new System.Windows.Forms.Padding(0);
            this.row8_5.Name = "row8_5";
            this.row8_5.Size = new System.Drawing.Size(100, 100);
            this.row8_5.TabIndex = 71;
            this.row8_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row8_5.Click += new System.EventHandler(this.label_Click);
            // 
            // row8_6
            // 
            this.row8_6.BackColor = System.Drawing.Color.SkyBlue;
            this.row8_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row8_6.Location = new System.Drawing.Point(500, 0);
            this.row8_6.Margin = new System.Windows.Forms.Padding(0);
            this.row8_6.Name = "row8_6";
            this.row8_6.Size = new System.Drawing.Size(100, 100);
            this.row8_6.TabIndex = 70;
            this.row8_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row8_6.Click += new System.EventHandler(this.label_Click);
            // 
            // row8_7
            // 
            this.row8_7.BackColor = System.Drawing.Color.MistyRose;
            this.row8_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row8_7.Location = new System.Drawing.Point(600, 0);
            this.row8_7.Margin = new System.Windows.Forms.Padding(0);
            this.row8_7.Name = "row8_7";
            this.row8_7.Size = new System.Drawing.Size(100, 100);
            this.row8_7.TabIndex = 69;
            this.row8_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row8_7.Click += new System.EventHandler(this.label_Click);
            // 
            // row8_8
            // 
            this.row8_8.BackColor = System.Drawing.Color.SkyBlue;
            this.row8_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row8_8.Location = new System.Drawing.Point(700, 0);
            this.row8_8.Margin = new System.Windows.Forms.Padding(0);
            this.row8_8.Name = "row8_8";
            this.row8_8.Size = new System.Drawing.Size(100, 100);
            this.row8_8.TabIndex = 68;
            this.row8_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.row8_8.Click += new System.EventHandler(this.label_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 841);
            this.Controls.Add(this.player1Time);
            this.Controls.Add(this.player2Time);
            this.Controls.Add(this.message);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chess";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Timer player1;
        private System.Windows.Forms.Timer player2;
        private System.Windows.Forms.Label player2Time;
        private System.Windows.Forms.Label player1Time;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label row8_5;
        private System.Windows.Forms.Label row8_6;
        private System.Windows.Forms.Label row8_7;
        private System.Windows.Forms.Label row8_8;
        private System.Windows.Forms.Label row1_1;
        private System.Windows.Forms.Label row1_2;
        private System.Windows.Forms.Label row1_3;
        private System.Windows.Forms.Label row1_4;
        private System.Windows.Forms.Label row1_5;
        private System.Windows.Forms.Label row1_6;
        private System.Windows.Forms.Label row1_7;
        private System.Windows.Forms.Label row1_8;
        private System.Windows.Forms.Label row2_1;
        private System.Windows.Forms.Label row2_2;
        private System.Windows.Forms.Label row2_3;
        private System.Windows.Forms.Label row2_4;
        private System.Windows.Forms.Label row2_5;
        private System.Windows.Forms.Label row2_6;
        private System.Windows.Forms.Label row2_7;
        private System.Windows.Forms.Label row2_8;
        private System.Windows.Forms.Label row3_1;
        private System.Windows.Forms.Label row3_2;
        private System.Windows.Forms.Label row3_3;
        private System.Windows.Forms.Label row3_4;
        private System.Windows.Forms.Label row3_5;
        private System.Windows.Forms.Label row3_6;
        private System.Windows.Forms.Label row3_7;
        private System.Windows.Forms.Label row3_8;
        private System.Windows.Forms.Label row4_1;
        private System.Windows.Forms.Label row4_2;
        private System.Windows.Forms.Label row4_3;
        private System.Windows.Forms.Label row4_4;
        private System.Windows.Forms.Label row4_5;
        private System.Windows.Forms.Label row4_6;
        private System.Windows.Forms.Label row4_7;
        private System.Windows.Forms.Label row4_8;
        private System.Windows.Forms.Label row5_1;
        private System.Windows.Forms.Label row5_2;
        private System.Windows.Forms.Label row5_3;
        private System.Windows.Forms.Label row5_4;
        private System.Windows.Forms.Label row5_5;
        private System.Windows.Forms.Label row5_6;
        private System.Windows.Forms.Label row5_7;
        private System.Windows.Forms.Label row5_8;
        private System.Windows.Forms.Label row6_1;
        private System.Windows.Forms.Label row6_2;
        private System.Windows.Forms.Label row6_3;
        private System.Windows.Forms.Label row6_4;
        private System.Windows.Forms.Label row6_5;
        private System.Windows.Forms.Label row6_6;
        private System.Windows.Forms.Label row6_7;
        private System.Windows.Forms.Label row6_8;
        private System.Windows.Forms.Label row7_1;
        private System.Windows.Forms.Label row7_2;
        private System.Windows.Forms.Label row7_3;
        private System.Windows.Forms.Label row7_4;
        private System.Windows.Forms.Label row7_5;
        private System.Windows.Forms.Label row7_6;
        private System.Windows.Forms.Label row7_7;
        private System.Windows.Forms.Label row7_8;
        private System.Windows.Forms.Label row8_1;
        private System.Windows.Forms.Label row8_2;
        private System.Windows.Forms.Label row8_3;
        private System.Windows.Forms.Label row8_4;
    }
}

