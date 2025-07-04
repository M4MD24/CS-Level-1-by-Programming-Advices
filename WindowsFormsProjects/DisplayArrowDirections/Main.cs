namespace DisplayArrowDirections;

public partial class Main : Form {
    public Main() {
        InitializeComponent();
    }

    private void Main_Load(
        object    sender,
        EventArgs e
    ) {
        Icon = new Icon(
            @"D:\Projects\Learn\ProgrammingAdvices\CS-Level-1-by-Programming-Advices\WindowsFormsProjects\DisplayArrowDirections\resources\ArrowDirectionLine.ico"
        );
        image.Image = Image.FromFile(
            @"D:\Projects\Learn\ProgrammingAdvices\CS-Level-1-by-Programming-Advices\WindowsFormsProjects\DisplayArrowDirections\resources\Question.png"
        );
        initializeOptions();
    }

    private void initializeOptions() {
        arrowDirections.Items.Add(
            "Up"
        );
        arrowDirections.Items.Add(
            "Up Right"
        );
        arrowDirections.Items.Add(
            "Right"
        );
        arrowDirections.Items.Add(
            "Down Right"
        );
        arrowDirections.Items.Add(
            "Down"
        );
        arrowDirections.Items.Add(
            "Down Left"
        );
        arrowDirections.Items.Add(
            "Left"
        );
        arrowDirections.Items.Add(
            "Up Left"
        );
    }

    private void arrowDirections_SelectedIndexChanged(
        object    sender,
        EventArgs e
    ) {
        name.Text = arrowDirections.Text;
        image.Image = Image.FromFile(
            $@"D:\Projects\Learn\ProgrammingAdvices\CS-Level-1-by-Programming-Advices\WindowsFormsProjects\DisplayArrowDirections\resources\arrow_direction\ArrowCircle{
                arrowDirections.Text.Replace(
                    " ",
                    ""
                )
            }.png"
        );
    }
}