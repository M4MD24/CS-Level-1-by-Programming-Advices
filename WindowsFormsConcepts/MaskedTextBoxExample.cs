using System;
using System.Windows.Forms;

namespace WindowsFormsConcepts;

public partial class MaskedTextBoxExample : Form {
    public MaskedTextBoxExample() {
        InitializeComponent();
    }

    private void submit_Click(
        object    sender,
        EventArgs e
    ) {
        if (maskedTextBoxWithCustomAndBeepOnError.MaskFull)
            MessageBox.Show(
                @"Is Full",
                @"Status",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        else
            MessageBox.Show(
                @"Isn't Full",
                @"Status",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
    }
}