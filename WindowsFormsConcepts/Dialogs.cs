namespace WindowsFormsConcepts;

public partial class Dialogs : Form {
    public Dialogs() {
        InitializeComponent();
    }

    private void changeForeColor_Click(
        object    sender,
        EventArgs e
    ) {
        if (colorDialogSample.ShowDialog() == DialogResult.OK)
            text.ForeColor = colorDialogSample.Color;
    }

    private void changeBackgroundColor_Click(
        object    sender,
        EventArgs e
    ) {
        if (colorDialogSample.ShowDialog() == DialogResult.OK)
            text.BackColor = colorDialogSample.Color;
    }

    private void changeFont_Click(
        object    sender,
        EventArgs e
    ) {
        fontDialogSample.ShowApply   = true;
        fontDialogSample.ShowEffects = true;
        Font lastFont = fontDialogSample.Font = text.Font;
        switch (fontDialogSample.ShowDialog()) {
            case DialogResult.OK:
                text.Font = fontDialogSample.Font;
            break;
            case DialogResult.Cancel:
                text.Font = lastFont;
            break;
        }
    }

    private void fontDialogSample_Apply(
        object    sender,
        EventArgs e
    ) {
        text.Font = fontDialogSample.Font;
    }
}