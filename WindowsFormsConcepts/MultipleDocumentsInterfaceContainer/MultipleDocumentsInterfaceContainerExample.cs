using WindowsFormsConcepts.MultipleDocumentsInterfaceContainer.Forms;

namespace WindowsFormsConcepts.MultipleDocumentsInterfaceContainer;

public partial class MultipleDocumentsInterfaceContainerExample : Form {
    public MultipleDocumentsInterfaceContainerExample() {
        InitializeComponent();
    }

    private readonly Form singleForm = new ExampleForm();

    private void showSingleFormOnly_Click(
        object    sender,
        EventArgs e
    ) {
        singleForm.MdiParent = this;
        singleForm.Show();
    }

    private void ShowMultipleForms_Click(
        object    sender,
        EventArgs e
    ) {
        Form multipleForms = new ExampleForm();
        multipleForms.MdiParent = this;
        multipleForms.Show();
    }
}