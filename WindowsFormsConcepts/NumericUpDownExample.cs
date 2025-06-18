namespace WindowsFormsConcepts;

public partial class NumericUpDownExample : Form {
    public NumericUpDownExample() {
        InitializeComponent();
    }

    private void numericUpDown_ValueChanged(
        object    sender,
        EventArgs e
    ) {
        counter.Text = numericUpDown.Value.ToString(
            ""
        );
    }
}