using System.Drawing.Drawing2D;

namespace TicTacToe;

public partial class Main : Form {
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
        position1.Image = position2.Image = position3.Image = position4.Image = position5.Image = position6.Image = position7.Image = position8.Image = position9.Image = Image.FromFile(
                                                                                                                                                            @"D:\Projects\Learn\ProgrammingAdvices\CS-Level-1-by-Programming-Advices\WindowsFormsProjects\TicTacToe\resources\Nothing.png"
                                                                                                                                                        );
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
}