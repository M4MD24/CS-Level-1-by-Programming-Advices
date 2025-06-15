using WindowsFormsConcepts.DateTimeControls;
using WindowsFormsConcepts.PictureBox;

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

    private void messageBox_Click(
        object    sender,
        EventArgs e
    ) {
        new MessageBoxExample().Show();
    }

    private void checkBoxAndRadioButtonAndGroupBoxAndTag_Click(
        object    sender,
        EventArgs e
    ) {
        new CheckBoxAndRadioButtonAndGroupBoxAndTag().Show();
    }

    private void textBox_Click(
        object    sender,
        EventArgs e
    ) {
        new TextBoxExample().Show();
    }

    private void pictureBox_Click(
        object    sender,
        EventArgs e
    ) {
        new PictureBoxExample().Show();
    }

    private void drawing_Click(
        object    sender,
        EventArgs e
    ) {
        new Drawing().Show();
    }

    private void maskedTextBox_Click(
        object    sender,
        EventArgs e
    ) {
        new MaskedTextBoxExample().Show();
    }

    private void comboBox_Click(
        object    sender,
        EventArgs e
    ) {
        new ComboBoxExample().Show();
    }

    private void linkLabel_Click(
        object    sender,
        EventArgs e
    ) {
        new LinkLabelExample().Show();
    }

    private void checkedListBox_Click(
        object    sender,
        EventArgs e
    ) {
        new CheckedListBoxExample().Show();
    }

    private void dateTimePicker_Click(
        object    sender,
        EventArgs e
    ) {
        new DateTimePickerExample().Show();
    }

    private void monthCalendar_Click(
        object    sender,
        EventArgs e
    ) {
        new MonthCalendarExample().Show();
    }
}