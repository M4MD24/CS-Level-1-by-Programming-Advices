namespace WindowsFormsConcepts;

public partial class IntroductionAboutControls : Form {
    public IntroductionAboutControls() {
        InitializeComponent();
    }

    private void textBoxesAndButtons_Click(
        object    sender,
        EventArgs e
    ) {
        new TextBoxesAndButtonsAndFormsAndLabels().Show();
    }

    private void formattingAndAlignments_Click(
        object    sender,
        EventArgs e
    ) {
        new FlatAppearance().Show();
    }

    private void newForms_Click(
        object    sender,
        EventArgs e
    ) {
        new NewForms().Show();
    }
}