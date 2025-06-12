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
        title           = new System.Windows.Forms.Label();
        game            = new System.Windows.Forms.GroupBox();
        round           = new System.Windows.Forms.GroupBox();
        turn            = new System.Windows.Forms.Label();
        statistics      = new System.Windows.Forms.GroupBox();
        resetStatistics = new System.Windows.Forms.Button();
        resetRound      = new System.Windows.Forms.Button();
        winner          = new System.Windows.Forms.Label();
        round.SuspendLayout();
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
        game.Font = new System.Drawing.Font(
            "Segoe UI",
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
        game.TabIndex = 5;
        game.TabStop  = false;
        game.Text     = "Game";
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
            "Segoe UI",
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
        // turn
        //
        turn.Font = new System.Drawing.Font(
            "Segoe UI",
            12F
        );
        turn.ForeColor = System.Drawing.Color.Blue;
        turn.Location = new System.Drawing.Point(
            15,
            35
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
        statistics.Font = new System.Drawing.Font(
            "Segoe UI",
            12F,
            System.Drawing.FontStyle.Bold
        );
        statistics.Location = new System.Drawing.Point(
            50,
            330
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
        // resetStatistics
        //
        resetStatistics.Location = new System.Drawing.Point(
            75,
            495
        );
        resetStatistics.Name = "resetStatistics";
        resetStatistics.Size = new System.Drawing.Size(
            100,
            25
        );
        resetStatistics.TabIndex                = 4;
        resetStatistics.Text                    = "Reset Statistics";
        resetStatistics.UseVisualStyleBackColor = true;
        //
        // resetRound
        //
        resetRound.Location = new System.Drawing.Point(
            75,
            290
        );
        resetRound.Name = "resetRound";
        resetRound.Size = new System.Drawing.Size(
            100,
            25
        );
        resetRound.TabIndex                = 2;
        resetRound.Text                    = "Reset Round";
        resetRound.UseVisualStyleBackColor = true;
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
            35
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
        // Main
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(
            7F,
            15F
        );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(
            684,
            561
        );
        Controls.Add(
            resetStatistics
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
        round.ResumeLayout(
            false
        );
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Label winner;

    private System.Windows.Forms.Label turn;

    private System.Windows.Forms.Button resetRound;

    private System.Windows.Forms.Button resetStatistics;

    private System.Windows.Forms.GroupBox statistics;

    private System.Windows.Forms.GroupBox round;

    private System.Windows.Forms.GroupBox game;

    private System.Windows.Forms.Label title;

    #endregion
}