namespace WindowsFormsConcepts;

public partial class CheckedListBoxExample : Form {
    private byte currentItemCount;

    public CheckedListBoxExample() {
        InitializeComponent();
    }

    private void addItem_Click(
        object    sender,
        EventArgs e
    ) {
        items.Items.Add(
            $"Item {++currentItemCount}"
        );
    }

    private void showItems_Click(
        object    sender,
        EventArgs e
    ) {
        string checkedItems = "";

        foreach (string checkedItem in items.CheckedItems)
            checkedItems += checkedItem + '\n';

        MessageBox.Show(
            checkedItems,
            @"Checked Items",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }

    private void checkAllItems_Click(
        object    sender,
        EventArgs e
    ) {
        for (
            int index = 0;
            index < items.Items.Count;
            index++
        )
            items.SetItemChecked(
                index,
                true
            );
    }

    private void uncheckAllItems_Click(
        object    sender,
        EventArgs e
    ) {
        for (
            int index = 0;
            index < items.Items.Count;
            index++
        )
            items.SetItemChecked(
                index,
                false
            );
    }

    private void removeSelectedItem_Click(
        object    sender,
        EventArgs e
    ) {
        items.Items.Remove(
            items.SelectedItem!
        );
    }
}