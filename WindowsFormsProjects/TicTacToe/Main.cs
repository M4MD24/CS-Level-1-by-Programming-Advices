using System.Drawing.Drawing2D;

namespace TicTacToe;

public partial class Main : Form {
    private bool playerXTurn = true;
    private byte playerXClicks = 0,
                 playerOClicks = 0;
    private bool anyoneWon = false;

    public Main() {
        InitializeComponent();
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
            anyoneWon
        )
            return;
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
            if (
                Convert.ToChar(
                    line[1].Tag!
                           .ToString()!
                ) == targetPlayerSymbol &&
                Convert.ToChar(
                    line[2].Tag!
                           .ToString()!
                ) == targetPlayerSymbol
            ) {
                anyoneWon      = true;
                turn.Visible   = false;
                winner.Visible = true;
                winner.Text    = $"Player\n{targetPlayerSymbol}\nWon";
                return;
            }
        }

        if (playerXClicks + playerOClicks != 9)
            return;
        anyoneWon        = true;
        turn.Visible     = false;
        winner.Visible   = true;
        winner.Text      = "Draw";
        winner.ForeColor = Color.Black;
    }
}