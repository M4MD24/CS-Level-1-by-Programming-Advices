using System;
using System.Windows.Forms;

namespace WindowsFormsConcepts.Containers;

public partial class TabControlExample : Form {
    public TabControlExample() {
        InitializeComponent();
    }

    private void firstNameAnswer_TextChanged(
        object    sender,
        EventArgs e
    ) {
        firstName.Text = firstNameAnswer.Text;
    }

    private void secondNameAnswer_TextChanged(
        object    sender,
        EventArgs e
    ) {
        secondName.Text = secondNameAnswer.Text;
    }

    private void clear_Click(
        object    sender,
        EventArgs e
    ) {
        firstName.Text = firstNameAnswer.Text = secondName.Text = secondNameAnswer.Text = "";
    }
}