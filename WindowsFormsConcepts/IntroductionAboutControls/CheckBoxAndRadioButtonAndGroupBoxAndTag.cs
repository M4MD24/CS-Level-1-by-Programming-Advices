namespace WindowsFormsConcepts.IntroductionAboutControls;

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

    private void submitChoice_Click(
        object    sender,
        EventArgs e
    ) {
        string choice;
        if (firstChoice.Checked)
            choice = firstChoice.Text;
        else if (secondChoice.Checked)
            choice = secondChoice.Text;
        else if (thirdChoice.Checked)
            choice = thirdChoice.Text;
        else
            choice = "Nothing";
        MessageBox.Show(
            choice,
            "RadioButton Choice",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }
}