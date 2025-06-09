namespace WindowsFormsConcepts;

public partial class WindowsFormsConcepts : Form {
    public WindowsFormsConcepts() {
        InitializeComponent();
    }

    private void introductionAboutControls_Click(
        object    sender,
        EventArgs e
    ) {
        new IntroductionAboutControls().Show();
    }
}