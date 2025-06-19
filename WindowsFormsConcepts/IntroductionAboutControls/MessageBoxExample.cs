namespace WindowsFormsConcepts.IntroductionAboutControls;

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

    private void showMessageBoxWithCaption_Click(
        object    sender,
        EventArgs e
    ) {
        MessageBox.Show(
            "Hello, this is a message",
            "Hello, this is a caption"
        );
    }

    private void showMessageBoxWithCaptionAndOtherButtonsAndIconAndDefaultButton_Click(
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