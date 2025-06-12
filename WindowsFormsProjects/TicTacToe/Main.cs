using System.Drawing.Drawing2D;

namespace TicTacToe;

public partial class Main : Form {
    private bool playerXTurn = true;

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
        /*winner.Text = "Player\nX\nWon";*/
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

    private void selectPosition(
        PictureBox position
    ) {
        if (
            position.Tag != null
        )
            return;
        position.Image = Image.FromFile(
            $@"D:\Projects\Learn\ProgrammingAdvices\CS-Level-1-by-Programming-Advices\WindowsFormsProjects\TicTacToe\resources\{
                (
                    playerXTurn
                            ? "X"
                            : "O"
                )
            }.png"
        );
        position.Tag = "";
        playerXTurn  = !playerXTurn;
    }

    private void position9_MouseClick(
        object         sender,
        MouseEventArgs e
    ) {
        selectPosition(
            position9
        );
    }
}