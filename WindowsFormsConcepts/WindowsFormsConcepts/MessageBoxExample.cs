namespace WindowsFormsConcepts;

public partial class MessageBoxExample : Form {
    public MessageBoxExample() {
        InitializeComponent();
    }

    private void showMessageBox_Click(
        object    sender,
        EventArgs e
    ) {
        MessageBox.Show(
            "Hello, this is a message"
        );
    }

    private void showMessageBoxWithTitle_Click(
        object    sender,
        EventArgs e
    ) {
        MessageBox.Show(
            "Hello, this is a message",
            "Hello, this is a title"
        );
    }

    private void showMessageBoxWithTitleAndOtherButtonsAndIconAndDefaultButton_Click(
        object    sender,
        EventArgs e
    ) {
        DialogResult result = MessageBox.Show(
            "Are you sure?",
            "Confirm",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2
        );

        MessageBox.Show(
            $"You clicked: {result}",
            "User Response",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }
}