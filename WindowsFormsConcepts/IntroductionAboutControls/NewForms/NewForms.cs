using WindowsFormsConcepts.IntroductionAboutControls.Forms;

namespace WindowsFormsConcepts.IntroductionAboutControls;

public partial class NewForms : Form {
    public NewForms() {
        InitializeComponent();
    }

    private void showForm_Click(
        object    sender,
        EventArgs e
    ) {
        new ExampleForm().Show();
        Close();
    }

    private void showDialogForm_Click(
        object    sender,
        EventArgs e
    ) {
        new ExampleForm().ShowDialog();
        Close();
    }
}