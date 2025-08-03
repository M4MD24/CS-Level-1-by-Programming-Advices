using System;
using System.Windows.Forms;

namespace WindowsFormsConcepts;

public partial class ComboBoxExample : Form {
    private byte currentCount;

    public ComboBoxExample() {
        InitializeComponent();
    }

    private void addMoreOptions_Click(
        object    sender,
        EventArgs e
    ) {
        comboBoxWithAddMoreOptions.Items.Add(
            $"Option {++currentCount}"
        );
    }

    private void comboBoxWithSelectedIndexChanged_SelectedIndexChanged(
        object    sender,
        EventArgs e
    ) {
        MessageBox.Show(comboBoxWithSelectedIndexChanged.Text);
    }

    private void ComboBoxExample_Load(
        object    sender,
        EventArgs e
    ) {
        comboBoxWithSelectedIndex.SelectedIndex = 1;
    }
}