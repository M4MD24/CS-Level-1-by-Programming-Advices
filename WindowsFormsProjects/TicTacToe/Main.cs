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
    }
}