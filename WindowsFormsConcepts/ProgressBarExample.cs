using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsConcepts;

public partial class ProgressBarExample : Form {
    public ProgressBarExample() {
        InitializeComponent();
    }

    private void load_Click(
        object    sender,
        EventArgs e
    ) {
        load.Enabled = false;

        progressBar.Minimum = progressBar.Value = 0;
        progressBar.Maximum = 100;

        while (progressBar.Value < progressBar.Maximum) {
            loadRate.Text = ++progressBar.Value + @"%";
            Thread.Sleep(
                25
            );
            progressBar.Refresh();
            loadRate.Refresh();
        }

        load.Enabled = true;
    }

    private void resetLoad_Click(
        object    sender,
        EventArgs e
    ) {
        loadRate.Text = $@"{progressBar.Value = 0}%";
    }
}