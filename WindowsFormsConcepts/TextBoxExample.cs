using System;
using System.Windows.Forms;

namespace WindowsFormsConcepts;

public partial class TextBoxExample : Form {
    public TextBoxExample() {
        InitializeComponent();
    }

    private void focus_Click(
        object    sender,
        EventArgs e
    ) {
        textBoxWithMaximumLength.Focus();
    }
}