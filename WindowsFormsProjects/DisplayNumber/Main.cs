namespace DisplayNumber;

public partial class Main : Form {
    public Main() {
        InitializeComponent();
    }

    private void Main_Load(
        object    sender,
        EventArgs e
    ) {
        Icon = new Icon(
            @"D:\Projects\Learn\ProgrammingAdvices\CS-Level-1-by-Programming-Advices\WindowsFormsProjects\DisplayNumber\resources\number.ico"
        );
        image.Image = Image.FromFile(
            @"D:\Projects\Learn\ProgrammingAdvices\CS-Level-1-by-Programming-Advices\WindowsFormsProjects\DisplayNumber\resources\question.png"
        );
    }

    private void zero_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        updateNameAndImage(
            zero
        );
    }

    private void one_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        updateNameAndImage(
            one
        );
    }

    private void two_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        updateNameAndImage(
            two
        );
    }

    private void three_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        updateNameAndImage(
            three
        );
    }

    private void four_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        updateNameAndImage(
            four
        );
    }

    private void five_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        updateNameAndImage(
            five
        );
    }

    private void six_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        updateNameAndImage(
            six
        );
    }

    private void seven_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        updateNameAndImage(
            seven
        );
    }

    private void eight_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        updateNameAndImage(
            eight
        );
    }

    private void nine_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        updateNameAndImage(
            nine
        );
    }

    private void updateNameAndImage(
        RadioButton choice
    ) {
        image.Image = Image.FromFile(
            $@"D:\Projects\Learn\ProgrammingAdvices\CS-Level-1-by-Programming-Advices\WindowsFormsProjects\DisplayNumber\resources\numbers\{name.Text = choice.Text}.png"
        );
    }
}