using WindowsFormsConcepts.Containers;
using WindowsFormsConcepts.DateTimeControls;
using WindowsFormsConcepts.IntroductionAboutControls;
using WindowsFormsConcepts.ListView;
using WindowsFormsConcepts.PictureBox;

namespace WindowsFormsConcepts;

public partial class WindowsFormsConcepts : Form {
    public WindowsFormsConcepts() {
        InitializeComponent();
    }

    private void textBoxesAndButtonsAndFormsAndLabels_Click(
        object    sender,
        EventArgs e
    ) {
        new TextBoxesAndButtonsAndFormsAndLabels().Show();
    }

    private void flatAppearance_Click(
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

    private void treeViewAndImageList_Click(
        object    sender,
        EventArgs e
    ) {
        new TreeViewAndImageList.TreeViewAndImageList().Show();
    }

    private void progressBar_Click(
        object    sender,
        EventArgs e
    ) {
        new ProgressBarExample().Show();
    }

    private void listView_Click(
        object    sender,
        EventArgs e
    ) {
        new ListViewExample().Show();
    }

    private void errorProvider_Click(
        object    sender,
        EventArgs e
    ) {
        new ErrorProviderExample().Show();
    }

    private void trackBar_Click(
        object    sender,
        EventArgs e
    ) {
        new TrackBarExample().Show();
    }

    private void numericUpDown_Click(
        object    sender,
        EventArgs e
    ) {
        new NumericUpDownExample().Show();
    }

    private void tabControl_Click(
        object    sender,
        EventArgs e
    ) {
        new TabControlExample().Show();
    }

    private void panel_Click(
        object    sender,
        EventArgs e
    ) {
        new PanelExample().Show();
    }
}