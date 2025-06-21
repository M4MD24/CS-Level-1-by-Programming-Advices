namespace WindowsFormsConcepts.Menus;

public partial class ContextMenuStripExample : Form {
    public ContextMenuStripExample() {
        InitializeComponent();
        loadContextMenusStrips();
    }

    private void loadContextMenuForForm() {
        ToolStripMenuItem changeColorToBlack = new(
                              "Change Color to Black"
                          ),
                          close = new(
                              "Close"
                          );

        changeColorToBlack.Click += (
            _,
            _
        ) => BackColor = Color.Black;
        close.Click += (
            _,
            _
        ) => Close();

        contextMenuStripForTextBoxes.Items.Add(
            changeColorToBlack
        );
        contextMenuStripForTextBoxes.Items.Add(
            close
        );

        contextMenuStripForForm.Items.Add(
            changeColorToBlack
        );
        contextMenuStripForForm.Items.Add(
            close
        );
    }

    private void loadContextMenusStrips() {
        loadContextMenuStripForTextBoxes();
        loadContextMenuForForm();
        attachContextMenuToTextBoxes();
    }

    private void loadContextMenuStripForTextBoxes() {
        ToolStripMenuItem cut = new(
                              "Cut"
                          ),
                          copy = new(
                              "Copy"
                          ),
                          paste = new(
                              "Paste"
                          );

        cut.Click   += cutItem_Click!;
        copy.Click  += copyItem_Click!;
        paste.Click += pasteItem_Click!;

        contextMenuStripForTextBoxes.Items.Add(
            cut
        );
        contextMenuStripForTextBoxes.Items.Add(
            copy
        );
        contextMenuStripForTextBoxes.Items.Add(
            paste
        );
    }

    private void attachContextMenuToTextBoxes() {
        firstTextBox.ContextMenuStrip  = contextMenuStripForTextBoxes;
        secondTextBox.ContextMenuStrip = contextMenuStripForTextBoxes;
        ContextMenuStrip               = contextMenuStripForForm;
    }

    private void cutItem_Click(
        object    sender,
        EventArgs e
    ) {
        if (ActiveControl is TextBox textBox)
            textBox.Cut();
    }

    private void copyItem_Click(
        object    sender,
        EventArgs e
    ) {
        if (ActiveControl is TextBox textBox)
            textBox.Copy();
    }

    private void pasteItem_Click(
        object    sender,
        EventArgs e
    ) {
        if (ActiveControl is TextBox textBox)
            textBox.Paste();
    }
}