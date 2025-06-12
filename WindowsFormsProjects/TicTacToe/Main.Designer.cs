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
        statistics      = new System.Windows.Forms.GroupBox();
        resetStatistics = new System.Windows.Forms.Button();
        resetRound      = new System.Windows.Forms.Button();
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
            12F
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
        round.Font = new System.Drawing.Font(
            "Segoe UI",
            12F
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
        // statistics
        //
        statistics.Font = new System.Drawing.Font(
            "Segoe UI",
            12F
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
        ResumeLayout(
            false
        );
    }

    private System.Windows.Forms.Button resetRound;

    private System.Windows.Forms.Button resetStatistics;

    private System.Windows.Forms.GroupBox statistics;

    private System.Windows.Forms.GroupBox round;

    private System.Windows.Forms.GroupBox game;

    private System.Windows.Forms.Label title;

    #endregion
}