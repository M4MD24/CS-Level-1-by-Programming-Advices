using System;
using System.Windows.Forms;

namespace WindowsFormsConcepts.DateTimeControls;

public partial class MonthCalendarExample : Form {
    public MonthCalendarExample() {
        InitializeComponent();
    }

    private void selectedRange_Click(
        object    sender,
        EventArgs e
    ) {
        MessageBox.Show(
            monthCalendarWithShowWeekNumbers.SelectionRange.ToString(),
            @"Selected Range",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }

    private void start_Click(
        object    sender,
        EventArgs e
    ) {
        MessageBox.Show(
            monthCalendarWithShowWeekNumbers.SelectionRange.Start.ToString(
                "F"
            ),
            @"Start Selected Range",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }

    private void end_Click(
        object    sender,
        EventArgs e
    ) {
        MessageBox.Show(
            monthCalendarWithShowWeekNumbers.SelectionRange.End.ToString(
                "F"
            ),
            @"End Selected Range",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }
}