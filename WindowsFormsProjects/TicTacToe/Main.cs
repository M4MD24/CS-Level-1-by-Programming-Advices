using System.Drawing.Drawing2D;

namespace TicTacToe;

public partial class Main : Form {
    private enum RoundStatus {
        PlayerXWon,
        PlayerOWon,
        Draw
    }

    private bool playerXTurn = true;
    private byte playerXClicks,
                 playerOClicks;
    private bool endRound;
    private byte roundCount = 1;
    private byte xPlayerWonCount,
                 oPlayerWonCount;
    private const byte STOP_GAME_AT = 10;

    public Main() {
        InitializeComponent();
        note.Text = $"Important Note: You Can Play {STOP_GAME_AT} Rounds Only, Playing for a long time isn't beneficial.";
    }

    private void Main_Load(
        object    sender,
        EventArgs e
    ) {
        Icon = new Icon(
            @"D:\Projects\Learn\ProgrammingAdvices\CS-Level-1-by-Programming-Advices\WindowsFormsProjects\TicTacToe\resources\TicTacToe.ico"
        );
        turn.Text = "Player\nX\nTurn";
        initializeGameTable();
    }

    private void initializeGameTable() {
        foreach (
            var position in new[] {
                position1,
                position2,
                position3,
                position4,
                position5,
                position6,
                position7,
                position8,
                position9
            }
        ) {
            position.Image = Image.FromFile(
                @"D:\Projects\Learn\ProgrammingAdvices\CS-Level-1-by-Programming-Advices\WindowsFormsProjects\TicTacToe\resources\Nothing.png"
            );
            position.Tag = null;
        }
    }

    private void game_Paint(
        object         sender,
        PaintEventArgs e
    ) {
        Color color = Color.Black;
        Pen pen = new Pen(
            color
        );
        pen.Width = 4;

        pen.StartCap = LineCap.Round;
        pen.EndCap   = LineCap.Round;

        e.Graphics.DrawLine(
            pen,
            143,
            25,
            143,
            375
        );
        e.Graphics.DrawLine(
            pen,
            253,
            25,
            253,
            375
        );
        e.Graphics.DrawLine(
            pen,
            25,
            143,
            375,
            143
        );
        e.Graphics.DrawLine(
            pen,
            25,
            253,
            375,
            253
        );
    }

    private void position1_MouseClick(
        object         sender,
        MouseEventArgs e
    ) {
        selectPosition(
            position1
        );
    }

    private void position2_MouseClick(
        object         sender,
        MouseEventArgs e
    ) {
        selectPosition(
            position2
        );
    }

    private void position3_MouseClick(
        object         sender,
        MouseEventArgs e
    ) {
        selectPosition(
            position3
        );
    }

    private void position4_MouseClick(
        object         sender,
        MouseEventArgs e
    ) {
        selectPosition(
            position4
        );
    }

    private void position5_MouseClick(
        object         sender,
        MouseEventArgs e
    ) {
        selectPosition(
            position5
        );
    }

    private void position6_MouseClick(
        object         sender,
        MouseEventArgs e
    ) {
        selectPosition(
            position6
        );
    }

    private void position7_MouseClick(
        object         sender,
        MouseEventArgs e
    ) {
        selectPosition(
            position7
        );
    }

    private void position8_MouseClick(
        object         sender,
        MouseEventArgs e
    ) {
        selectPosition(
            position8
        );
    }

    private void position9_MouseClick(
        object         sender,
        MouseEventArgs e
    ) {
        selectPosition(
            position9
        );
    }

    private void selectPosition(
        PictureBox position
    ) {
        if (
            position.Tag != null ||
            endRound
        )
            return;
        resetRound.Enabled = true;
        char playerSymbol = playerXTurn
                                    ? 'X'
                                    : 'O';
        position.Image = Image.FromFile(
            $@"D:\Projects\Learn\ProgrammingAdvices\CS-Level-1-by-Programming-Advices\WindowsFormsProjects\TicTacToe\resources\{playerSymbol}.png"
        );
        position.Tag = playerSymbol;
        if (playerXTurn)
            playerXClicks++;
        else
            playerOClicks++;
        playerXTurn = !playerXTurn;
        playerSymbol = playerXTurn
                               ? 'X'
                               : 'O';
        turn.Text = $"Player\n{playerSymbol}\nTurn";
        if (
            playerXClicks >= 3 ||
            playerOClicks >= 3
        )
            checkWinner();
    }

    private void checkWinner() {
        PictureBox[][] lines = [
            [
                position1,
                position2,
                position3
            ],
            [
                position4,
                position5,
                position6
            ],
            [
                position7,
                position8,
                position9
            ],
            [
                position1,
                position4,
                position7
            ],
            [
                position2,
                position5,
                position8
            ],
            [
                position3,
                position6,
                position9
            ],
            [
                position1,
                position5,
                position9
            ],
            [
                position3,
                position5,
                position7
            ]
        ];

        foreach (var line in lines) {
            if (
                line.Any(
                    position => position.Tag == null
                )
            )
                continue;

            char targetPlayerSymbol = Convert.ToChar(
                line[0].Tag!.ToString()!
            );
            if (Convert.ToChar(
                    line[1].Tag!
                           .ToString()!
                ) != targetPlayerSymbol ||
                Convert.ToChar(
                    line[2].Tag!
                           .ToString()!
                ) != targetPlayerSymbol)
                continue;
            displayWhoWon(
                targetPlayerSymbol == 'X'
                        ? RoundStatus.PlayerXWon
                        : RoundStatus.PlayerOWon,
                Color.Green
            );
            return;
        }

        if (playerXClicks + playerOClicks != 9)
            return;
        displayWhoWon(
            RoundStatus.Draw,
            Color.Black
        );
    }

    private void displayWhoWon(
        RoundStatus roundStatus,
        Color       color
    ) {
        endRound       = true;
        turn.Visible   = false;
        winner.Visible = true;
        winner.Text = roundStatus == RoundStatus.Draw
                              ? "Draw"
                              : $"Player\n{
                                  (
                                      roundStatus == RoundStatus.PlayerXWon
                                              ? 'X'
                                              : 'O'
                                  )
                              }\nWon";
        winner.ForeColor   = color;
        resetRound.Enabled = false;
        increasePlayerWins(
            roundStatus
        );
        if (roundCount != STOP_GAME_AT)
            playAgain.Enabled = true;
        else {
            round.Enabled      = false;
            statistics.Enabled = false;
            game.Enabled       = false;
            note.ForeColor     = Color.OliveDrab;
        }
    }

    private void increasePlayerWins(
        RoundStatus roundStatus
    ) {
        switch (roundStatus) {
            case RoundStatus.PlayerXWon:
                playerX_WinCount.Text = $"Player X = {++xPlayerWonCount} time(s)";
            break;
            case RoundStatus.PlayerOWon:
                playerO_WinCount.Text = $"Player O = {++oPlayerWonCount} time(s)";
            break;
        }
    }

    private void resetRound_Click(
        object    sender,
        EventArgs e
    ) {
        initializeGameTable();
        playerXTurn        = true;
        turn.Text          = "Player\nX\nTurn";
        playerXClicks      = 0;
        playerOClicks      = 0;
        endRound           = false;
        resetRound.Enabled = false;
    }

    private void playAgain_Click(
        object    sender,
        EventArgs e
    ) {
        resetRound_Click(
            sender,
            e
        );
        playAgain.Enabled = false;
        round.Text        = $"Round {++roundCount}";
        turn.Visible      = true;
        winner.Visible    = false;
    }
}