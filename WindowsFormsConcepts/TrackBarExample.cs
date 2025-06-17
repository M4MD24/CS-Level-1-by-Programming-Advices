namespace WindowsFormsConcepts;

public partial class TrackBarExample : Form {
    public TrackBarExample() {
        InitializeComponent();
    }

    private void trackBar_Scroll(
        object    sender,
        EventArgs e
    ) {
        indicator.Text = trackBar.Value.ToString();
    }
}