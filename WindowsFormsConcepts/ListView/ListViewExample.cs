using WindowsFormsConcepts.ListView.models;

namespace WindowsFormsConcepts.ListView;

public partial class ListViewExample : Form {
    private enum Color {
        Red,
        Green,
        Blue
    }

    public ListViewExample() {
        InitializeComponent();
    }

    private void ListViewExample_Load(
        object    sender,
        EventArgs e
    ) {
        initializeImages();
        setupItemColumns();
    }

    private void setupItemColumns() {
        items.Columns.Add(
            "Title",
            180
        );
        items.Columns.Add(
            "Description",
            320
        );
        items.FullRowSelect = true;
        items.GridLines     = true;
    }

    private void initializeImages() {
        const string PATH = "D:\\Projects\\Learn\\ProgrammingAdvices\\CS-Level-1-by-Programming-Advices\\WindowsFormsConcepts\\ListView\\resources\\";

        initializeSmallImages(
            PATH
        );
        initializeLargeImages(
            PATH
        );
    }

    private void initializeLargeImages(
        string path
    ) {
        largeImages.Images.Add(
            "RedSquare",
            Image.FromFile(
                path + $"{Color.Red}Square.png"
            )
        );
        largeImages.Images.Add(
            "GreenSquare",
            Image.FromFile(
                path + $"{Color.Green}Square.png"
            )
        );
        largeImages.Images.Add(
            "BlueSquare",
            Image.FromFile(
                path + $"{Color.Blue}Square.png"
            )
        );
    }

    private void initializeSmallImages(
        string path
    ) {
        smallImages.Images.Add(
            "RedSquare",
            Image.FromFile(
                path + $"{Color.Red}Square.png"
            )
        );
        smallImages.Images.Add(
            "GreenSquare",
            Image.FromFile(
                path + $"{Color.Green}Square.png"
            )
        );
        smallImages.Images.Add(
            "BlueSquare",
            Image.FromFile(
                path + $"{Color.Blue}Square.png"
            )
        );
    }

    private void add_Click(
        object    sender,
        EventArgs e
    ) {
        string titleValue = enteredTitle.Text;
        if (
            string.IsNullOrEmpty(
                titleValue
            )
        ) {
            MessageBox.Show(
                @"No Title Entered",
                @"Enter Title",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        string descriptionValue = enteredDescription.Text;
        if (
            string.IsNullOrEmpty(
                descriptionValue
            )
        ) {
            MessageBox.Show(
                @"No Description Entered",
                @"Enter Description",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        string colorValue = "";
        foreach (Control option in color.Controls)
            if (
                option is RadioButton {
                    Checked: true
                } selectedColor
            ) {
                colorValue = selectedColor.Text;
                break;
            }

        if (
            string.IsNullOrEmpty(
                colorValue
            )
        ) {
            MessageBox.Show(
                @"No color selected",
                @"Select a Color",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        addItem(
            new Item(
                titleValue.Trim(),
                descriptionValue.Trim(),
                colorValue.Trim()
            )
        );

        clearFields();
    }

    private void addItem(
        Item itemValues
    ) {
        ListViewItem item = new ListViewItem(
            itemValues.getTitle()
        );
        item.SubItems.Add(
            itemValues.getDescription()
        );
        item.ImageIndex = Enum.TryParse(
                              itemValues.getColor(),
                              out Color colorValue
                          )
                                  ? (int) colorValue
                                  : -1;

        items.Items.Add(
            item
        );
    }

    private void clearFields() {
        enteredTitle.Clear();
        enteredDescription.Clear();
        foreach (Control option in color.Controls)
            if (option is RadioButton colorValue)
                colorValue.Checked = false;
    }

    private void largeIcon_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        items.View = View.LargeIcon;
    }

    private void smallIcon_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        items.View = View.SmallIcon;
    }

    private void tile_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        items.View = View.Tile;
    }

    private void list_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        items.View = View.List;
    }

    private void details_CheckedChanged(
        object    sender,
        EventArgs e
    ) {
        items.View = View.Details;
    }

    private void addRandomItem_Click(
        object    sender,
        EventArgs e
    ) {
        Random random = new Random();

        string[] sampleTitles = [
            "Sample A",
            "Sample B",
            "Sample C"
        ];
        string[] sampleDescriptions = [
            "This is a sample a",
            "This is a sample b",
            "This is a sample c"
        ];
        string[] colors = Enum.GetNames(
            typeof(Color)
        );

        int randomTitleAndDescriptionNumber = random.Next(
            sampleTitles.Length
        );
        string randomTitle = sampleTitles[
                   randomTitleAndDescriptionNumber
               ],
               randomDescription = sampleDescriptions[
                   randomTitleAndDescriptionNumber
               ],
               randomColor = colors[
                   random.Next(
                       colors.Length
                   )
               ];

        addItem(
            new Item(
                randomTitle,
                randomDescription,
                randomColor
            )
        );
    }

    private void remove_Click(
        object    sender,
        EventArgs e
    ) {
        while (items.SelectedItems.Count > 0)
            items.Items.Remove(
                items.SelectedItems[0]
            );
    }

    private void select_Click(
        object    sender,
        EventArgs e
    ) {
        foreach (ListViewItem item in items.Items) {
            if (item.Text != enteredTitle.Text)
                continue;
            item.Selected = true;
            item.Focused  = true;
            item.EnsureVisible();
            break;
        }
    }
}