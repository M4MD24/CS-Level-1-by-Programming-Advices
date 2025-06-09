namespace WindowsFormsConcepts;

public partial class CheckBoxAndRadioButtonAndGroupBoxAndTag : Form {
    public CheckBoxAndRadioButtonAndGroupBoxAndTag() {
        InitializeComponent();
    }

    private void checkBoxExample_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        submitCheckBoxStatus.Enabled = checkBoxExample.Checked;
    }

    private void submitCheckBoxStatus_Click(
        object    sender,
        EventArgs e
    ) {
        bool status = checkBoxExample.Checked;
        MessageBox.Show(
            status.ToString(),
            "CheckBox Status",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }
}