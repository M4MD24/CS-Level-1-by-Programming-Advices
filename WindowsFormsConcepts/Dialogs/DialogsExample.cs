namespace WindowsFormsConcepts.Dialogs;

public partial class DialogsExample : Form {
    public DialogsExample() {
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

    private void saveFile_Click(
        object    sender,
        EventArgs e
    ) {
        saveFileDialogSample.InitialDirectory = @"D:\Projects\Learn\ProgrammingAdvices\CS-Level-1-by-Programming-Advices\WindowsFormsConcepts\Dialogs\Files";
        saveFileDialogSample.Title            = @"Save File Dialog";
        saveFileDialogSample.DefaultExt       = "txt";
        saveFileDialogSample.Filter           = @"txt files (*.txt)|*.txt|All Files (*.*)|*.*";
        saveFileDialogSample.FilterIndex      = 2;
        if (saveFileDialogSample.ShowDialog() == DialogResult.OK)
            showFileName(
                saveFileDialogSample.FileName
            );
    }

    private void openFile_Click(
        object    sender,
        EventArgs e
    ) {
        openFileDialogSample.Multiselect = true;
        if (openFileDialogSample.ShowDialog() == DialogResult.OK)
            if (openFileDialogSample.FileNames.Length > 1) {
                string fileNames = "";
                foreach (string fileName in openFileDialogSample.FileNames)
                    fileNames += fileName + Environment.NewLine;
                showFileName(
                    fileNames
                );
            } else
                showFileName(
                    openFileDialogSample.FileName
                );
    }

    private void showFileName(
        string fileName
    ) {
        MessageBox.Show(
            fileName,
            @"FileName",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }
}