using WindowsFormsConcepts.DateTimeControls;
using WindowsFormsConcepts.PictureBox;

namespace WindowsFormsConcepts;

public partial class WindowsFormsConcepts : Form {
    public WindowsFormsConcepts() {
        InitializeComponent();
    }

    private void introductionAboutControls_Click(
        object    sender,
        EventArgs e
    ) {
        new IntroductionAboutControls().Show();
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

    private void timer_Click(
        object    sender,
        EventArgs e
    ) {
        new TimerExample().Show();
    }

    private void notifyIcon_Click(
        object    sender,
        EventArgs e
    ) {
        new NotifyIconExample().Show();
    }
}