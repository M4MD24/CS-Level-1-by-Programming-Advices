namespace WindowsFormsConcepts.DateTimeControls;

public partial class DateTimePickerExample : Form {
    public DateTimePickerExample() {
        InitializeComponent();
    }

    private void DateTimePickerExample_Load(
        object    sender,
        EventArgs e
    ) {
        dateTimePicker_ValueChanged(
            sender,
            e
        );
    }

    private void showShortDate_Click(
        object    sender,
        EventArgs e
    ) {
        MessageBox.Show(
            dateTimePicker.Value.ToShortDateString(),
            @"Short Date",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }

    private void showLongDate_Click(
        object    sender,
        EventArgs e
    ) {
        MessageBox.Show(
            dateTimePicker.Value.ToLongDateString(),
            @"Long Date",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }

    private void dateTimePicker_ValueChanged(
        object    sender,
        EventArgs e
    ) {
        dates.Text = dateTimePicker.Text + Environment.NewLine;
        DateTime dateTimePickerValue = dateTimePicker.Value;
        dates.Text += @"Short Date: " + dateTimePickerValue.ToShortDateString() + Environment.NewLine;
        dates.Text += @"Long Date: "  + dateTimePickerValue.ToLongDateString()  + Environment.NewLine;
        dates.Text += @"Short Time: " + dateTimePickerValue.ToShortTimeString() + Environment.NewLine;
        dates.Text += @"Long Time: "  + dateTimePickerValue.ToLongTimeString()  + Environment.NewLine;
        dates.Text += @"Full DateTime: " + dateTimePickerValue.ToString(
                          "F"
                      ) + Environment.NewLine;
        dates.Text += @"General Date/Time (short): " + dateTimePickerValue.ToString(
                          "g"
                      ) + Environment.NewLine;
        dates.Text += @"General Date/Time (long): " + dateTimePickerValue.ToString(
                          "G"
                      ) + Environment.NewLine;
        dates.Text += @"Month/Day: " + dateTimePickerValue.ToString(
                          "M"
                      ) + Environment.NewLine;
        dates.Text += @"RFC1123: " + dateTimePickerValue.ToString(
                          "R"
                      ) + Environment.NewLine;
        dates.Text += @"Sortable: " + dateTimePickerValue.ToString(
                          "s"
                      ) + Environment.NewLine;
        dates.Text += @"Universal Sortable: " + dateTimePickerValue.ToString(
                          "u"
                      ) + Environment.NewLine;
        dates.Text += @"Year/Month: " + dateTimePickerValue.ToString(
                          "Y"
                      );
    }
}