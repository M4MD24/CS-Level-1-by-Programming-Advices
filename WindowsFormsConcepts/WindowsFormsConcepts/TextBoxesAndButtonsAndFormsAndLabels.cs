namespace WindowsFormsConcepts;

public partial class TextBoxesAndButtonsAndFormsAndLabels : Form {
    public TextBoxesAndButtonsAndFormsAndLabels() {
        InitializeComponent();
    }

    private void pasteByClick_Click(
        object    sender,
        EventArgs e
    ) {
        copyist.Text = paster.Text;
    }

    private void pasteByHover_MouseHover(
        object    sender,
        EventArgs e
    ) {
        copyist.Text = paster.Text;
    }

    private void paster_TextChanged(
        object    sender,
        EventArgs e
    ) {
        copyist.Text = paster.Text;
        title.Text   = paster.Text;
        Text         = paster.Text;
    }

    private void disablePaster_Click(
        object    sender,
        EventArgs e
    ) {
        paster.Enabled = false;
    }

    private void enablePaster_Click(
        object    sender,
        EventArgs e
    ) {
        paster.Enabled = true;
    }

    private void hidePaster_Click(
        object    sender,
        EventArgs e
    ) {
        paster.Visible = false;
    }

    private void showPaster_Click(
        object    sender,
        EventArgs e
    ) {
        paster.Visible = true;
    }

    private void changePasterBackgroundToRed_Click(
        object    sender,
        EventArgs e
    ) {
        paster.BackColor = Color.Red;
    }

    private void changePasterBackgroundToWhite_Click(
        object    sender,
        EventArgs e
    ) {
        paster.BackColor = Color.White;
    }

    private void changeFormText_Click(
        object    sender,
        EventArgs e
    ) {
        Text = paster.Text;
    }

    private void changeTitle_Click(
        object    sender,
        EventArgs e
    ) {
        title.Text = paster.Text;
    }

    private void disableChangeByTextChanged_Click(
        object    sender,
        EventArgs e
    ) {
        paster.TextChanged -= paster_TextChanged!;
    }

    private void enableChangeByTextChanged_Click(
        object    sender,
        EventArgs e
    ) {
        paster.TextChanged += paster_TextChanged!;
    }
}