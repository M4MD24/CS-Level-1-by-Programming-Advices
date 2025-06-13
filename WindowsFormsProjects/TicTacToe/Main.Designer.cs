namespace TicTacToe;

partial class Main {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(
        bool disposing
    ) {
        if (disposing && (components != null)) {
            components.Dispose();
        }

        base.Dispose(
            disposing
        );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        title            = new System.Windows.Forms.Label();
        game             = new System.Windows.Forms.GroupBox();
        position9        = new System.Windows.Forms.PictureBox();
        position8        = new System.Windows.Forms.PictureBox();
        position7        = new System.Windows.Forms.PictureBox();
        position6        = new System.Windows.Forms.PictureBox();
        position5        = new System.Windows.Forms.PictureBox();
        position4        = new System.Windows.Forms.PictureBox();
        position3        = new System.Windows.Forms.PictureBox();
        position2        = new System.Windows.Forms.PictureBox();
        position1        = new System.Windows.Forms.PictureBox();
        playAgain        = new System.Windows.Forms.Button();
        round            = new System.Windows.Forms.GroupBox();
        winner           = new System.Windows.Forms.Label();
        turn             = new System.Windows.Forms.Label();
        statistics       = new System.Windows.Forms.GroupBox();
        playerO_WinCount = new System.Windows.Forms.Label();
        playerX_WinCount = new System.Windows.Forms.Label();
        resetRound       = new System.Windows.Forms.Button();
        note             = new System.Windows.Forms.Label();
        game.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) position9).BeginInit();
        ((System.ComponentModel.ISupportInitialize) position8).BeginInit();
        ((System.ComponentModel.ISupportInitialize) position7).BeginInit();
        ((System.ComponentModel.ISupportInitialize) position6).BeginInit();
        ((System.ComponentModel.ISupportInitialize) position5).BeginInit();
        ((System.ComponentModel.ISupportInitialize) position4).BeginInit();
        ((System.ComponentModel.ISupportInitialize) position3).BeginInit();
        ((System.ComponentModel.ISupportInitialize) position2).BeginInit();
        ((System.ComponentModel.ISupportInitialize) position1).BeginInit();
        round.SuspendLayout();
        statistics.SuspendLayout();
        SuspendLayout();
        //
        // title
        //
        title.Font = new System.Drawing.Font(
            "Kristen ITC",
            27F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        title.Location = new System.Drawing.Point(
            225,
            25
        );
        title.Name = "title";
        title.Size = new System.Drawing.Size(
            250,
            50
        );
        title.TabIndex  = 0;
        title.Text      = "Tic Tac Toe";
        title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //
        // game
        //
        game.Controls.Add(
            position9
        );
        game.Controls.Add(
            position8
        );
        game.Controls.Add(
            position7
        );
        game.Controls.Add(
            position6
        );
        game.Controls.Add(
            position5
        );
        game.Controls.Add(
            position4
        );
        game.Controls.Add(
            position3
        );
        game.Controls.Add(
            position2
        );
        game.Controls.Add(
            position1
        );
        game.Font = new System.Drawing.Font(
            "Kristen ITC",
            12F,
            System.Drawing.FontStyle.Bold
        );
        game.Location = new System.Drawing.Point(
            250,
            125
        );
        game.Name = "game";
        game.Size = new System.Drawing.Size(
            400,
            400
        );
        game.TabIndex =  5;
        game.TabStop  =  false;
        game.Text     =  "Game";
        game.Paint    += game_Paint;
        //
        // position9
        //
        position9.Location = new System.Drawing.Point(
            270,
            270
        );
        position9.Name = "position9";
        position9.Size = new System.Drawing.Size(
            80,
            80
        );
        position9.SizeMode   =  System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        position9.TabIndex   =  8;
        position9.TabStop    =  false;
        position9.MouseClick += position9_MouseClick;
        //
        // position8
        //
        position8.Location = new System.Drawing.Point(
            160,
            270
        );
        position8.Name = "position8";
        position8.Size = new System.Drawing.Size(
            80,
            80
        );
        position8.SizeMode   =  System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        position8.TabIndex   =  7;
        position8.TabStop    =  false;
        position8.MouseClick += position8_MouseClick;
        //
        // position7
        //
        position7.Location = new System.Drawing.Point(
            50,
            270
        );
        position7.Name = "position7";
        position7.Size = new System.Drawing.Size(
            80,
            80
        );
        position7.SizeMode   =  System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        position7.TabIndex   =  6;
        position7.TabStop    =  false;
        position7.MouseClick += position7_MouseClick;
        //
        // position6
        //
        position6.Location = new System.Drawing.Point(
            270,
            160
        );
        position6.Name = "position6";
        position6.Size = new System.Drawing.Size(
            80,
            80
        );
        position6.SizeMode   =  System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        position6.TabIndex   =  5;
        position6.TabStop    =  false;
        position6.MouseClick += position6_MouseClick;
        //
        // position5
        //
        position5.Location = new System.Drawing.Point(
            160,
            160
        );
        position5.Name = "position5";
        position5.Size = new System.Drawing.Size(
            80,
            80
        );
        position5.SizeMode   =  System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        position5.TabIndex   =  4;
        position5.TabStop    =  false;
        position5.MouseClick += position5_MouseClick;
        //
        // position4
        //
        position4.Location = new System.Drawing.Point(
            50,
            160
        );
        position4.Name = "position4";
        position4.Size = new System.Drawing.Size(
            80,
            80
        );
        position4.SizeMode   =  System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        position4.TabIndex   =  3;
        position4.TabStop    =  false;
        position4.MouseClick += position4_MouseClick;
        //
        // position3
        //
        position3.Location = new System.Drawing.Point(
            270,
            50
        );
        position3.Name = "position3";
        position3.Size = new System.Drawing.Size(
            80,
            80
        );
        position3.SizeMode   =  System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        position3.TabIndex   =  2;
        position3.TabStop    =  false;
        position3.MouseClick += position3_MouseClick;
        //
        // position2
        //
        position2.Location = new System.Drawing.Point(
            160,
            50
        );
        position2.Name = "position2";
        position2.Size = new System.Drawing.Size(
            80,
            80
        );
        position2.SizeMode   =  System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        position2.TabIndex   =  1;
        position2.TabStop    =  false;
        position2.MouseClick += position2_MouseClick;
        //
        // position1
        //
        position1.Location = new System.Drawing.Point(
            50,
            50
        );
        position1.Name = "position1";
        position1.Size = new System.Drawing.Size(
            80,
            80
        );
        position1.SizeMode   =  System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        position1.TabIndex   =  0;
        position1.TabStop    =  false;
        position1.MouseClick += position1_MouseClick;
        //
        // playAgain
        //
        playAgain.Enabled = false;
        playAgain.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point,
            ((byte) 0)
        );
        playAgain.Location = new System.Drawing.Point(
            450,
            550
        );
        playAgain.Name = "playAgain";
        playAgain.Size = new System.Drawing.Size(
            200,
            50
        );
        playAgain.TabIndex                =  6;
        playAgain.Text                    =  "Play Again";
        playAgain.UseVisualStyleBackColor =  true;
        playAgain.Click                   += playAgain_Click;
        //
        // round
        //
        round.Controls.Add(
            winner
        );
        round.Controls.Add(
            turn
        );
        round.Font = new System.Drawing.Font(
            "Kristen ITC",
            12F,
            System.Drawing.FontStyle.Bold
        );
        round.Location = new System.Drawing.Point(
            50,
            125
        );
        round.Name = "round";
        round.Size = new System.Drawing.Size(
            150,
            150
        );
        round.TabIndex = 1;
        round.TabStop  = false;
        round.Text     = "Round 1";
        //
        // winner
        //
        winner.Font = new System.Drawing.Font(
            "Segoe UI",
            12F
        );
        winner.ForeColor = System.Drawing.Color.Green;
        winner.Location = new System.Drawing.Point(
            15,
            30
        );
        winner.Name = "winner";
        winner.Size = new System.Drawing.Size(
            120,
            100
        );
        winner.TabIndex  = 1;
        winner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        winner.Visible   = false;
        //
        // turn
        //
        turn.Font = new System.Drawing.Font(
            "Segoe UI",
            12F
        );
        turn.ForeColor = System.Drawing.Color.Blue;
        turn.Location = new System.Drawing.Point(
            15,
            30
        );
        turn.Name = "turn";
        turn.Size = new System.Drawing.Size(
            120,
            100
        );
        turn.TabIndex  = 0;
        turn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //
        // statistics
        //
        statistics.Controls.Add(
            playerO_WinCount
        );
        statistics.Controls.Add(
            playerX_WinCount
        );
        statistics.Font = new System.Drawing.Font(
            "Kristen ITC",
            12F,
            System.Drawing.FontStyle.Bold
        );
        statistics.Location = new System.Drawing.Point(
            50,
            375
        );
        statistics.Name = "statistics";
        statistics.Size = new System.Drawing.Size(
            150,
            150
        );
        statistics.TabIndex = 3;
        statistics.TabStop  = false;
        statistics.Text     = "Statistics";
        //
        // playerO_WinCount
        //
        playerO_WinCount.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        playerO_WinCount.ForeColor = System.Drawing.Color.Black;
        playerO_WinCount.Location = new System.Drawing.Point(
            15,
            90
        );
        playerO_WinCount.Name = "playerO_WinCount";
        playerO_WinCount.Size = new System.Drawing.Size(
            120,
            25
        );
        playerO_WinCount.TabIndex  = 3;
        playerO_WinCount.Text      = "Player O = 0 time(s)";
        playerO_WinCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // playerX_WinCount
        //
        playerX_WinCount.Font = new System.Drawing.Font(
            "Segoe UI",
            9F
        );
        playerX_WinCount.ForeColor = System.Drawing.Color.Black;
        playerX_WinCount.Location = new System.Drawing.Point(
            15,
            45
        );
        playerX_WinCount.Name = "playerX_WinCount";
        playerX_WinCount.Size = new System.Drawing.Size(
            120,
            25
        );
        playerX_WinCount.TabIndex  = 2;
        playerX_WinCount.Text      = "Player X = 0 time(s)";
        playerX_WinCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // resetRound
        //
        resetRound.Enabled = false;
        resetRound.Location = new System.Drawing.Point(
            75,
            300
        );
        resetRound.Name = "resetRound";
        resetRound.Size = new System.Drawing.Size(
            100,
            25
        );
        resetRound.TabIndex                =  2;
        resetRound.Text                    =  "Reset Round";
        resetRound.UseVisualStyleBackColor =  true;
        resetRound.Click                   += resetRound_Click;
        //
        // note
        //
        note.Font = new System.Drawing.Font(
            "Kristen ITC",
            9F,
            System.Drawing.FontStyle.Bold
        );
        note.Location = new System.Drawing.Point(
            50,
            550
        );
        note.Name = "note";
        note.Size = new System.Drawing.Size(
            375,
            50
        );
        note.TabIndex  = 6;
        note.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //
        // Main
        //
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            684,
            661
        );
        Controls.Add(
            playAgain
        );
        Controls.Add(
            note
        );
        Controls.Add(
            resetRound
        );
        Controls.Add(
            statistics
        );
        Controls.Add(
            round
        );
        Controls.Add(
            game
        );
        Controls.Add(
            title
        );
        StartPosition =  System.Windows.Forms.FormStartPosition.CenterScreen;
        Text          =  "Tic Tac Toe";
        Load          += Main_Load;
        game.ResumeLayout(
            false
        );
        ((System.ComponentModel.ISupportInitialize) position9).EndInit();
        ((System.ComponentModel.ISupportInitialize) position8).EndInit();
        ((System.ComponentModel.ISupportInitialize) position7).EndInit();
        ((System.ComponentModel.ISupportInitialize) position6).EndInit();
        ((System.ComponentModel.ISupportInitialize) position5).EndInit();
        ((System.ComponentModel.ISupportInitialize) position4).EndInit();
        ((System.ComponentModel.ISupportInitialize) position3).EndInit();
        ((System.ComponentModel.ISupportInitialize) position2).EndInit();
        ((System.ComponentModel.ISupportInitialize) position1).EndInit();
        round.ResumeLayout(
            false
        );
        statistics.ResumeLayout(
            false
        );
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Label note;

    private System.Windows.Forms.Button playAgain;

    private System.Windows.Forms.PictureBox position3;

    private System.Windows.Forms.PictureBox position1;
    private System.Windows.Forms.PictureBox position2;
    private System.Windows.Forms.PictureBox position5;
    private System.Windows.Forms.PictureBox position4;
    private System.Windows.Forms.PictureBox position9;
    private System.Windows.Forms.PictureBox position8;
    private System.Windows.Forms.PictureBox position7;

    private System.Windows.Forms.PictureBox position6;

    private System.Windows.Forms.Label playerO_WinCount;

    private System.Windows.Forms.Label playerX_WinCount;

    private System.Windows.Forms.Label winner;

    private System.Windows.Forms.Label turn;

    private System.Windows.Forms.Button resetRound;

    private System.Windows.Forms.GroupBox statistics;

    private System.Windows.Forms.GroupBox round;

    private System.Windows.Forms.GroupBox game;

    private System.Windows.Forms.Label title;

    #endregion
}