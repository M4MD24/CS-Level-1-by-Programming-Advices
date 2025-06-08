namespace WindowsFormsConcepts;

public partial class WindowsFormsConcepts : Form {
    public WindowsFormsConcepts() {
        InitializeComponent();
    }

    private void textBoxesAndButtons_Click(
        object    sender,
        EventArgs e
    ) {
        new TextBoxesAndButtonsAndFormsAndLabels().Show();
    }
}